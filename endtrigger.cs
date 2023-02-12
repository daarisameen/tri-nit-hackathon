using UnityEngine;

public class endtrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public gamemager gamemanager;

    // this is predefined function based on Trigger properties
    void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();
    }
}
