using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEditor;

public class Panel {

    //Will contain all of the blocks in this panel, in order
    private ArrayList blocks;

    private string name;

    public Panel(string panelName){
        blocks = new ArrayList();
        this.name = panelName;
    }

    string getName(){
        return name;
    }

    public ArrayList getBlocks(){
        return blocks;
    }

    //To add a block to this panel
    public void insertBlock(Block block){
        blocks.Add(block);
    }

    void insertBlock(Block block, int pos){
        try{
            blocks.Insert(pos, block);
        }
        catch(System.IndexOutOfRangeException e){
            UnityEngine.Debug.Log(e.StackTrace);
        }
    }

    void removeBlock(int pos){
        try{
            blocks.RemoveAt(pos);
        }
        catch (System.IndexOutOfRangeException e){
            UnityEngine.Debug.Log(e.StackTrace);
        }
    }    
}
