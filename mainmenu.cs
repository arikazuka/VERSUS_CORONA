using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
    public string playGameLevel;

   
    public void Playgame()
    {
        Application.LoadLevel(playGameLevel);
    }

    public void Quitgame()
    {
        Application.Quit();
    }

}

