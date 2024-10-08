﻿using System;
using Npgsql;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FredOraclePostgreSQLDataCompare.DAL.Oracle
{
  public static class OracleDALHelper
  {
    public static string GetGeneralConnexionString()
    {
      return "Data Source = {serverName}; Initial Catalog = {databaseName}; Persist Security Info = True; User ID = {userName}; Password = {password}";
    }

    public static string TestRequest()
    {
      return "select 1+2 FROM DUAL;";
    }

    public static bool TestOracleDbConnection(string connectionString)
    {
      var result = true;
      using (OracleConnection connection = new OracleConnection(connectionString))
      {
        try
        {
          connection.Open();

          //string query = "SELECT table_name FROM all_tables WHERE owner = 'PP_INTER_REF'";

          //using (OracleCommand command = new OracleCommand(query, connection))
          //{
          //  using (OracleDataReader reader = command.ExecuteReader())
          //  {
          //    Console.WriteLine("Tables in the database:");
          //    while (reader.Read())
          //    {
          //      Console.WriteLine(reader.GetString(0));
          //    }
          //  }
          //}
        }
        catch (Exception)
        {
          result = false;
        }
      }

      return result;
    }

    public static string GetAllOracleTablesRequest()
    {
      return "SELECT table_name FROM all_tables WHERE owner = (SELECT user from dual) ORDER BY table_name";
    }

    internal static List<string> ExecuteQueryToListOfStrings(string connectionString, string query)
    {
      var result = new List<string>();
      using (OracleConnection connection = new OracleConnection(connectionString))
      {
        try
        {
          connection.Open();

          using (OracleCommand command = new OracleCommand(query, connection))
          {
            using (OracleDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                result.Add(reader.GetString(0));
              }
            }
          }
        }
        catch (Exception)
        {
          result = new List<string>();
          connection.Close();
        }
      }

      return result;
    }

    public static int ExecuteQueryToInteger(string connectionString, string query)
    {
      int result = 0;
      using (OracleConnection connection = new OracleConnection(connectionString))
      {
        try
        {
          connection.Open();

          using (OracleCommand command = new OracleCommand(query, connection))
          {
            object queryResult = command.ExecuteScalar();

            if (queryResult != null && int.TryParse(queryResult.ToString(), out int parsedResult))
            {
              result = parsedResult;
            }
            else
            {
              result = -10;
            }
          }
        }
        catch (Exception)
        {
          result = -10;
          connection.Close();
        }
      }

      return result;
    }

    public static string CountNumberOfRecordsRequest(string tableName)
    {
      return $"SELECT COUNT(*) FROM {tableName}";
    }

    public static string GetAllColumnsRequest(string tableName)
    {
      return $"SELECT column_name FROM user_tab_columns WHERE table_name = '{tableName}' ORDER BY 1";
    }

    internal static void LoadTableIntoDGV(string connectionString, string query, DataGridView dataGridView)
    {
      using (OracleConnection connection = new OracleConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
          {
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
          }
        }
        catch (Exception)
        {
          
        }
      }
    }

    internal static string SelectAllFromTableRequest(string tableName)
    {
      return $"SELECT * FROM {tableName}";
    }

    internal static DataTable ExecuteQueryToDataTable(string connectionString, string query)
    {
      var dataTable = new DataTable();
      using (OracleConnection connection = new OracleConnection(connectionString))
      {
        try
        {
          connection.Open();
          using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
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
