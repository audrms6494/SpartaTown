using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpriteControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject rice;
    [SerializeField] private GameObject noodle;

    private SpriteRenderer riceSprite;
    private SpriteRenderer noodleSprite;
    private Animator riceAnimator;
    private Animator noodleAnimator;

    void Start()
    {
        riceSprite = rice.GetComponent<SpriteRenderer>();
        noodleSprite = noodle.GetComponent<SpriteRenderer>();
        riceAnimator = rice.GetComponent<Animator>();
        noodleAnimator = noodle.GetComponent<Animator>();

        ChooseCharacter();
    }

    public void ChooseCharacter()
    {
        if (PlayerPrefs.GetString("Character") == "Rice")
        {
            riceSprite.enabled = true;
            riceAnimator.enabled = true;
            noodleSprite.enabled = false;
            noodleAnimator.enabled = false;
        }
        else if (PlayerPrefs.GetString("Character") == "Noodle")
        {
            riceSprite.enabled = false;
            riceAnimator.enabled = false;
            noodleSprite.enabled = true;
            noodleAnimator.enabled = true;
        }
    }

}
