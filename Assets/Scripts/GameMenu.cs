using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameMenu : MonoBehaviour
{

    public Text levelText;

    // Start is called before the first frame update
    void Start(){
        levelText.text = "0";
    }

    public void PlayGame(){
        if (Game.startingLevel == 0)
            Game.startingAtLevelZero = true;
        else
            Game.startingAtLevelZero = false;

        Application.LoadLevel("Level");
    }

    public void ChangedValue(float value){
        Game.startingLevel = (int)value;
        levelText.text = value.ToString();
    }

    public void LaunchGameMenu()
    {
        Application.LoadLevel("GameMenu");
    }
}
