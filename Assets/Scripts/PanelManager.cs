using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEditor;


public class PanelManager {
    Dictionary<string, Panel> panels;

    public PanelManager() {

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
