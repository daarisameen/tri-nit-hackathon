using UnityEngine;

// to change the scene or reload the scene that I'm already on
// here I have to respawn my player so...
using UnityEngine.SceneManagement;

public class gamemager : MonoBehaviour
{
    // Start is called before the first frame update

    bool gamehasended = false;

    public float resartdealy = 1f;

    public GameObject completelevelui;


    public void CompleteLevel()
    {
      completelevelui.SetActive(true);
      
    }

    // user defined function does not exist on its own
    public void EndGame()
    {
        if(gamehasended==false)
        {
          gamehasended = true;
          Debug.Log("Game Ended");

          // Invoke takes two argument 1st is function name and 2nd is delay amount
          Invoke("Restart",resartdealy);
        }
    }

    void Restart()
    {
SceneManager.LoadScene("SampleScene");
    }


}
