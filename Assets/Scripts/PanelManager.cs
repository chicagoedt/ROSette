using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEditor;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class PanelManager : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        printAllBlocks();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void printAllBlocks()
    {
        string conn = "URI=file:" + Application.dataPath + "/Blocks.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT ID,Name " + "FROM Blocks";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            int ID = reader.GetInt32(0);
            string name = reader.GetString(1);

            UnityEngine.Debug.Log("ID = " + ID + "  name =" + name);
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }

    string lookupBlockByID(int id){
        //TODO
        return "";
    }

    
}
