﻿using System;

namespace FredOraclePostgreSQLDataCompare
{
  public static class PostgreSqlConnection
  {
    public static string GetGeneralConnexionString()
    {
      return "Data Source = {serverName}; Initial Catalog = {databaseName}; Persist Security Info = True; User ID = {userName}; Password = {password}";
    }

    public static string GetAllTableNamesRequest()
    {
      // table_schema,
      return "SELECT table_name FROM information_schema.tables ORDER BY table_name;";
      //return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'U'";
    }

    public static string GetAllTableNamesForASpecificSchemaRequest(string schemaName = "public")
    {
      // table_schema,
      return $"SELECT table_name FROM information_schema.tables WHERE table_schema = '{schemaName}' ORDER BY table_name;";
      //return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'U'";
    }

    public static string GetAllDefaultConstraintsRequest()
    {
      return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'D'";
    }

    public static string GetAllForeignKeysRequest()
    {
      return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'F'";
    }

    public static string GetAllFunctionsRequest()
    {
      return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'FN'";
    }

    public static string TestRequest()
    {
      return "select 1+2;";
    }

    public static string GetAllDatabaseNamesRequest()
    {
      return $"SELECT datname FROM pg_database WHERE datistemplate = false AND datname != 'postgres';";
    }

    public static string GetAllStoredProcedureRequest()
    {
      return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'P'";
    }

    public static string GetAllPrimaryKeyRequest()
    {
      return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'PK'";
    }

    public static string GetAllServiceQueueRequest()
    {
      return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'SQ'";
    }

    public static string GetAllTriggerRequest()
    {
      return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'TR'";
    }

    public static string GetAllViewRequest()
    {
      return "SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'V'";
    }

    public static string GetAllColumnFromATableRequest(string tableName, string schema = "")
    {
      //SELECT table_catalog, table_schema, table_name, column_name, data_type FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'facture'
      return $"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '{tableName}' AND table_schema = (SELECT current_user) ORDER BY 1;";
    }

    public static string GetAllSchemasRequest()
    {
      return "SELECT schema_name FROM information_schema.schemata where schema_name not in ('information_schema', 'pg_catalog') ORDER BY schema_name;";
    }

    public static string GetAllOwnerUsers()
    {
      //return "SELECT nspname FROM pg_catalog.pg_namespace;";
      return "select distinct schema_owner FROM information_schema.schemata;";
    }

    public static string GetAllPostgreSqlTables(string user)
    {
      return $"SELECT table_name FROM information_schema.tables WHERE table_schema = '{user}' AND table_type = 'BASE TABLE' ORDER BY 1;";
    }

    public static string GetcurrentUserRequest()
    {
      return "SELECT current_user;";
    }

    public static string CountNumberOfRecordsRequest(string tableName)
    {
      return $"SELECT COUNT(*) FROM {tableName};";
    }

    public static string SelectAllFromTableRequest(string tableName)
    {
      return $"SELECT * FROM {tableName};";
    }
  }
}
