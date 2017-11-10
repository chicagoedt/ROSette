using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEditor;



[InitializeOnLoad]
public class PanelManager {
    Dictionary<string, Panel> panels;

    static PanelManager(){
        Panel panel = new Panel("first panel");
        panel.insertBlock(new Block(1));
    }

    void addPanel(string name){
        panels.Add(name, new Panel(name));
    }

    void runPanel(string name){
        Panel panel = panels[name];
        ArrayList blocks = panel.getBlocks();
        
        //TODO interact with map
    }

    
}
