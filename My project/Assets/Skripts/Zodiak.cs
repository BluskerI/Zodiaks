using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Zodiak : MonoBehaviour
{

    public TextAsset file;
    public Text uitext;

    Dictionary<string, string> zodiakDictionary;

    void Start()
    {
        var text = file.text;
        var zodiaks = text.Split('\n');
        zodiakDictionary = new Dictionary<string, string>();
        foreach( var zodiak in zodiaks)
        {
            string[] keyValue = zodiak.Split(':');
            zodiakDictionary.Add(keyValue[0], keyValue[1]);

        }
    }

    public void Show(string key)
    {
        uitext.text = zodiakDictionary[key];
    }
  

}
