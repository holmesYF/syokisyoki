using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenesMaingame : MonoBehaviour
{
    // Start is called before the first frame update
    public void chanege_scenes()
    {
        SceneManager.LoadScene("Maingame");
    }
}
