using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chang : MonoBehaviour
{
    // Start is called before the first frame update
    public void chang_game()
    {
        SceneManager.LoadScene("Maingame");
    }
    public void change_staert()
    {
        SceneManager.LoadScene("Maingame");
    }
}
