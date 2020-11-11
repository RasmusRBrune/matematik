using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void load_next_level()
    {
        //til at går vidre til næste bane
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
