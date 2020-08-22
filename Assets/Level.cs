using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    static int level;
    public int num = 1;
    static public Strategy get_level()
    {
        switch (level)
        {
            case 1:
                return new Easy();
            case 2:
                return new Normal();
            case 3:
                return new Hard();
            default:
                return new Easy();
        }
    }
    //public void Change_Easy()
    //{
    //    Level.level = 1;
    //}
    //public void Change_Normal()
    //{
    //    Level.level = 2;
    //}
    //public void Change_Hard()
    //{
    //    Level.level = 3;
    //}
    public void ChangeLevel()
    {
        Level.level = this.num;
        SceneManager.LoadScene("Maingame");
    }
}
