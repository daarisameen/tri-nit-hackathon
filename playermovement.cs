using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public int forceConst = 10;
    public float sidewayForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, forceConst*Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -0.5f)
        {
          FindObjectOfType<gamemager>().EndGame();
        }

    }
}
