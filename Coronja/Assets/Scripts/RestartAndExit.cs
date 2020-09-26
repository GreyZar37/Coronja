using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAndExit : MonoBehaviour
{
    // Start is called before the first frame update

    bool gameHasEnded = false;

    public void Restart()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            RestartFunction();
        }
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Exit();
        }
    }

    void RestartFunction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Exit()
    {
        Application.Quit();
    }




}
