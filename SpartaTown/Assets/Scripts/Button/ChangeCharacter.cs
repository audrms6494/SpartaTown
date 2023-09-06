using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacter : MonoBehaviour
{
    public Sprite riceimage;
    public Sprite noodleimage;
    private Image currentimage;
    private void Start()
    {
        PlayerPrefs.SetString("Character", "Rice");
        currentimage = GetComponent<Image>();
    }
    // Start is called before the first frame update
    public void Change()
    {
        if (PlayerPrefs.GetString("Character") == "Rice")
        {
            PlayerPrefs.SetString("Character", "Noodle");
            currentimage.sprite = noodleimage;
        }
        else if (PlayerPrefs.GetString("Character") == "Noodle")
        {
            PlayerPrefs.SetString("Character", "Rice");
            currentimage.sprite = riceimage;
        }
    }
}
