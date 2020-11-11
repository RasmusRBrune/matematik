
using UnityEngine;

public class player_move : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 4000f;
    public float sidewaysForce = 120f;
    public float upwaysForce = 1000f;
    bool playerjump = true;
    void FixedUpdate()
    {
        //her før vi spiller til at køre framd
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //i de her if statements ser vi om spiller har lave et input 
        if (Input.GetKey("d"))
        {
            //køre spiller til venster
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //køre spiller til højre
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 

        if (Input.GetKey("space") && playerjump==true)
        {
            //får spiler til at hoppe
            rb.AddForce(0, upwaysForce * Time.deltaTime, 0, ForceMode.Impulse);
           //så han ikke kan hoppe igen
            playerjump = false;
           
        }
       //nu mere hvis du røre ud at bane
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void OnCollisionEnter(Collision Collisioninfo)
    {
        //se hvis du er på jorden så du kan hoppe 
        if (Collisioninfo.collider.tag == "ground")
        {
            playerjump =true;
        }
    }

}
