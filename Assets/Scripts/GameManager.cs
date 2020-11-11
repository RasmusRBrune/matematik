using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gamehasended = false;
    public float restartdelay = 1f;
    public GameObject completelevelUI;
    public void EndGame()
    {
        //se hvi du har tabe bane 
        if (gamehasended==false)
        {
            gamehasended = true;
            Invoke("restart",restartdelay);
        }
    }
    void restart()
    {
        //Genstartet bane
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void level_complete()
    {
        //vidser et hvis test his du når i mål
        completelevelUI.SetActive(true);
    }
}
