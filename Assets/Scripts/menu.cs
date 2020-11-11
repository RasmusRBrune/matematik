using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    //det har skal være til startmeun som er det føste du se når du op'er spille 
    public void StartGame()
    { 
        //det har til at start spille 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   
}
