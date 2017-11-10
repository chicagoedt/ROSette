using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class Block
{
    int blockID;
    object value;
    string name;

    public Block(int id)
    {
        this.blockID = id;
        this.name = lookupBlockNameByID(id);
    }

    string getName(){
        return name;
    }

    void setValue(object val)
    {
        this.value = val;
    }

    object getValue()
    {
        return value;
    }

    static string lookupBlockNameByID(int id)
    {
        string name = "";

        string conn = "URI=file:" + Application.dataPath + "/Blocks.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open();
        IDbCommand dbcmd = dbconn.CreateCommand();

        string sqlQuery = "SELECT Name " + "FROM Blocks " + "WHERE ID = " + id.ToString();
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();

        if (reader.Read())
        {
            name = reader.GetString(0);
        }
        else return null;

        reader.Close();
        dbcmd.Dispose();
        dbconn.Close();

        return name;
    }
}
