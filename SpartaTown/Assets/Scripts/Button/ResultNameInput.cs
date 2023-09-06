using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class ResultNameInput : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    private string playerName = null;

    // ���콺 Ŭ���� ����
    public void InputName()
    {
        playerName = playerNameInput.text;
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
    }
}

