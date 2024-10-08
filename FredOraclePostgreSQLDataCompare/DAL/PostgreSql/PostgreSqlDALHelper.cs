﻿using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace FredOraclePostgreSQLDataCompare.DAL.PostgreSql
{
  public static class PostgreSqlDALHelper
  {
    public static string GetConnexionString(string databaseName = "postgres", string sqlServerName = ".")
    {
      return "SELECT datname FROM pg_database WHERE datistemplate = false;";
      //return $"Data Source={sqlServerName};Initial Catalog={databaseName};Integrated Security=True";
    }

    public static string CreateConnectionString(string host, string username, string password, string databaseName = "postgres", int port = 5432)
    {
      return $"Host={host};Port={port};Username={username};Database={databaseName};CommandTimeout=0";
    }

    public static bool VerifyDatabaseConnexion(string sqlQuery, string databaseName, string sqlServerName)
    {
      bool result = false;
      string connectionString = GetConnexionString(databaseName, sqlServerName);
      string query = sqlQuery;

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        try
        {
          connection.Open();
          var queryResult = command.ExecuteScalar();
          if (queryResult == null)
          {
            result = true; // if no result then connexion is ok
          }
          else
          {
            result = true;
          }
        }
        catch (Exception)
        {
          result = false;
        }
        finally
        {
          connection.Close();
        }
      }

      return result;
    }

    public static string ExecuteSqlQueryOneResult(string sqlQuery, string databaseName, string sqlServerName)
    {
      string result = string.Empty;
      string connectionString = GetConnexionString(databaseName, sqlServerName);
      string query = sqlQuery;

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        try
        {
          connection.Open();
          var queryResult = command.ExecuteScalar();
          if (queryResult == null)
          {
            result = string.Empty;
          }
          else
          {
            result = queryResult.ToString();
          }
        }
        catch (Exception exception)
        {
          Console.WriteLine(exception.Message);
        }
        finally
        {
          connection.Close();
        }
      }

      if (result == null)
      {
        result = string.Empty;
      }

      return result;
    }

    /// <summary>
    /// Execute an SQL query.
    /// </summary>
    /// <param name="sqlQuery">The SQL query to be run.</param>
    /// <param name="databaseName">The name of the database.</param>
    /// <param name="sqlServerName">The name of the SQL server.</param>
    /// <returns>An SQL data reader type.</returns>
    public static SqlDataReader ExecuteSqlQueryToDataReader(string sqlQuery, string databaseName, string sqlServerName)
    {
      SqlDataReader result = null;
      string connectionString = GetConnexionString(databaseName, sqlServerName);
      string query = sqlQuery;

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        try
        {
          connection.Open();
          SqlDataReader queryResult = command.ExecuteReader();
          if (queryResult == null)
          {
            result = null;
          }
          else
          {
            result = queryResult;
          }
        }
        catch (Exception)
        {
          //MessageBox.show(exception.Message);
        }
        finally
        {
          connection.Close();
        }
      }

      return result;
    }

    /// <summary>
    /// Execute a SQL query.
    /// </summary>
    /// <param name="sqlQuery">The SQL query to be run.</param>
    /// <param name="databaseName">The name of the database.</param>
    /// <param name="sqlServerName">The name of the SQL server.</param>
    /// <returns>An SQL data reader type.</returns>
    public static List<string> ExecuteSqlQueryToListOfStrings(string connectionString, string query)
    {
      var result = new List<string>();
      var connexion = new NpgsqlConnection(connectionString);
      try
      {
        connexion.Open();
        var command = new NpgsqlCommand(query, connexion);
        NpgsqlDataReader reader = command.ExecuteReader();
        if (reader == null)
        {
          result = new List<string>();
        }
        else
        {
          if (reader.HasRows)
          {
            while (reader.Read())
            {
              result.Add($"{reader.GetString(0)}");
            }
          }
        }
      }
      catch (Exception)
      {
        result = new List<string>();
      }
      finally
      {
        connexion.Close();
      }

      return result;
    }

    public static bool WriteToDatabase(string sqlQuery, DateTime requestDate, double euro, double dollar)
    {
      bool result = false;
      using (SqlConnection connection = new SqlConnection(GetConnexionString()))
      {
        //string query = "INSERT INTO [dbo].[BitCoin] ([Date], [RateEuros], [RateDollar]) VALUES(@theDate, @rateEuro, @ratedollar)";
        string query = sqlQuery;

        using (SqlCommand command = new SqlCommand(query, connection))
        {
          command.Parameters.AddWithValue("@theDate", requestDate);
          command.Parameters.AddWithValue("@rateEuro", euro);
          command.Parameters.AddWithValue("@ratedollar", dollar);

          connection.Open();
          var QueryResult = command.ExecuteNonQuery();

          // Check Error
          if (QueryResult < 0)
          {
            result = false;
          }
          else
          {
            result = true;
          }
        }
      }

      return result;
    }

    public static List<T> DataReaderMapToList<T>(IDataReader dataReader)
    {
      List<T> list = new List<T>();
      T obj = default(T);
      while (dataReader.Read())
      {
        obj = Activator.CreateInstance<T>();
        foreach (PropertyInfo propertyInfo in obj.GetType().GetProperties())
        {
          if (!object.Equals(dataReader[propertyInfo.Name], DBNull.Value))
          {
            propertyInfo.SetValue(obj, dataReader[propertyInfo.Name], null);
          }
        }

        list.Add(obj);
      }

      return list;
    }

    public static IEnumerable<string> GetData(string filter, Func<IDataRecord, string> factory, string databaseName, string sqlServerName, string sqlQuery)
    {
      using (SqlConnection sqlConnection = new SqlConnection(GetConnexionString(databaseName, sqlServerName)))
      using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
      {
        sqlCommand.Parameters.Add("@Filter", SqlDbType.NVarChar, 255).Value = filter;
        sqlConnection.Open();

        using (IDataReader reader = sqlCommand.ExecuteReader())
        {
          while (reader.Read())
          {
            yield return factory(reader);
          }

          reader.Close();
        }
      }
    }

    public static int ExecuteNonQuery(string connexionString, string sqlRequest)
    {
      var result = -10;
      string connectionStringWithPassword = connexionString;

      var connexion = new NpgsqlConnection(connectionStringWithPassword);
      try
      {
        connexion.Open();
        var command = new NpgsqlCommand(sqlRequest, connexion);
        command.CommandType = CommandType.Text;
        int returnRows = command.ExecuteNonQuery();
        result = returnRows;
      }
      catch (Exception)
      {
        result = -10;
      }
      finally
      {
        connexion.Close();
      }

      return result;
    }

    public static string ExecuteQueryToString(string connexionString, string sqlRequest)
    {
      var result = string.Empty;
      var connexion = new NpgsqlConnection(connexionString);
      try
      {
        connexion.Open();
        var command = new NpgsqlCommand(sqlRequest, connexion);
        NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
          result = reader.GetString(0);
        }
      }
      catch (Exception exception)
      {
        result = $"erreur-{exception.Message}";
      }
      finally
      {
        connexion.Close();
      }

      return result;
    }

    public static int ExecuteNonQueryStoredProcedureWithParameters(string connectionString, string sqlRequest, string parameterName, string parameterValue)
    {
      var result = -10;
      var connexion = new NpgsqlConnection(connectionString);
      try
      {
        connexion.Open();
        var command = new NpgsqlCommand(sqlRequest, connexion);
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = sqlRequest;
        command.Parameters.Add(parameterName, NpgsqlDbType.Text).Value = parameterValue;
        int returnRows = command.ExecuteNonQuery();
        result = returnRows;
      }
      catch (Exception)
      {
        result = -10;
      }
      finally
      {
        connexion.Close();
      }

      return result;
    }

    public static int ExecuteNonQueryStoredProcedureWithParameters(string connectionString, string sqlRequest, string parameterName, int parameterValue)
    {
      var result = -10;
      var connexion = new NpgsqlConnection(connectionString);
      try
      {
        connexion.Open();
        var command = new NpgsqlCommand(sqlRequest, connexion);
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = sqlRequest;
        command.Parameters.Add(parameterName, NpgsqlDbType.Integer).Value = parameterValue;
        int returnRows = command.ExecuteNonQuery();
        result = returnRows;
      }
      catch (Exception)
      {
        result = -10;
      }
      finally
      {
        connexion.Close();
      }

      return result;
    }

    public static int ExecuteNonQueryStoredProcedureWithoutParameters(string connectionString, string sqlRequest)
    {
      var result = -10;
      string connectionStringWithPassword = connectionString;

      var connexion = new NpgsqlConnection(connectionStringWithPassword);
      try
      {
        connexion.Open();
        var command = new NpgsqlCommand(sqlRequest, connexion);
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = sqlRequest;
        int returnRows = command.ExecuteNonQuery();
        result = returnRows;
      }
      catch (Exception)
      {
        result = -10;
      }
      finally
      {
        connexion.Close();
      }

      return result;
    }

    public static string[,] ExecuteQueryToArray(string connexionString, string sqlRequest, int numberOfColumn = 3, int numberOfRow = 4)
    {
      var result = new string[numberOfColumn, numberOfRow];
      var column = 0;
      int row = 0;
      var connexion = new NpgsqlConnection(connexionString);
      try
      {
        connexion.Open();
        var command = new NpgsqlCommand(sqlRequest, connexion);
        NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
          result[column, row] = (string)reader[0];
          column++;
          result[column, row] = (string)reader[1];
          column++;
          result[column, row] = (string)reader[2];
          row++;
          column = 0;
        }
      }
      catch (Exception)
      {
        result[0, 0] = "error";
      }
      finally
      {
        connexion.Close();
      }

      return result;
    }

    public static bool TestConnection(string connexionString)
    {
      bool result = false;
      NpgsqlConnection connection = new NpgsqlConnection(connexionString);
      try
      {
        connection.Open();
        result = true;
      }
      catch (Exception)
      {
        result = false;
      }

      result = connection.State == ConnectionState.Open;
      connection.Close();
      return result;
    }

    public static int ExecuteQueryToInteger(string connectionString, string query)
    {
      var result = 0;
      try
      {
        using (var connexion = new NpgsqlConnection(connectionString))
        {
          connexion.Open();

          using (var cmd = new NpgsqlCommand(query, connexion))
          {
            var count = (int)(long)cmd.ExecuteScalar();
            result = count;
          }
        }
      }
      catch (Exception)
      {
        result = -10;
      }

      return result;
    }

    public static long ExecuteQueryToLong(string connexionString, string sqlRequest)
    {
      long result = -10;
      var connexion = new NpgsqlConnection(connexionString);
      try
      {
        connexion.Open();
        var command = new NpgsqlCommand(sqlRequest, connexion);
        NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
          result = reader.GetInt64(0);
        }
      }
      catch (Exception)
      {
        result = -10;
      }
      finally
      {
        connexion.Close();
      }

      return result;
    }

    internal static void LoadTableIntoDGV(string connectionString, string query, DataGridView dataGridViewPostgreSql)
    {
      using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
          {
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewPostgreSql.DataSource = dataTable;
          }
        }
        catch (Exception)
        {
        }
      }
    }

    internal static DataTable ExecuteQuerytoDataTable(string connectionString, string query)
    {
      var dataTable = new DataTable();
      using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
          {
            dataTable = new DataTable();
            adapter.Fill(dataTable);
          }
        }
        catch (Exception)
        {
        }
      }

      return dataTable;
    }
  }
}
