using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEditor;
using Mono.Data.Sqlite;
using System.Data;
using System;

[InitializeOnLoad]
public class PanelManager : MonoBehaviour {
    ArrayList panels;

    static PanelManager()
    {
        UnityEngine.Debug.Log(lookupBlockByID(0));
    }
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    static string lookupBlockByID(int id){
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
