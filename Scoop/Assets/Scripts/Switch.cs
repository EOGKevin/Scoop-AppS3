using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    public void ToMiniGame()
    {
        SceneManager.LoadScene("MiniGame-Scene");
    }

    public void ToProfile()
    {
        SceneManager.LoadScene("Profile-Scene");
    }
}
