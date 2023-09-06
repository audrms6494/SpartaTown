using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NameInput : MonoBehaviour
{
    public TMP_Text ScriptTxt;
    private string _playername;
    // Start is called before the first frame update
    void Start()
    {
        _playername = PlayerPrefs.GetString("PlayerName");
        ScriptTxt.text = _playername;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
