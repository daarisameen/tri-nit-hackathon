using UnityEngine;

public class playercollision : MonoBehaviour
{

    public playermovement movement;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo )
    {
       if(collisionInfo.collider.tag=="obstacle")
       {
         movement.enabled = false;
        FindObjectOfType<gamemager>().EndGame();
       }
    }
}
