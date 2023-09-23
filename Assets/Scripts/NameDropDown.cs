using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using TMPro;

public class NameDropDown : MonoBehaviour
{
    public TextAsset namesCSV;
    public List<String> names = new List<string>();
    public TMP_Dropdown dropdown;
    private char lineSeperator = '\n';

    private void Start() 
    {
        dropdown = GetComponent<TMP_Dropdown>();
        ReadData();    
    }

    private void ReadData()
    {
        String[] tempNames = namesCSV.text.Split(lineSeperator);
        foreach (var name in tempNames)
        {
            names.Add(name);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(names);
    }
}
