
using UnityEngine;

public class play_rotation : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float forwardForce = 4000f;
    public float sidewaysForce = 120f;
    public float upwaysForce = 1000f;
    bool playerjump = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            //køre spiller til venster
            rb.AddForce(0,0,sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            //køre spiller til venster
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
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

        if (Input.GetKey("space") && playerjump == true)
        {
            //får spiler til at hoppe
            rb.AddForce(0, upwaysForce * Time.deltaTime, 0, ForceMode.Impulse);
            //så han ikke kan hoppe igen
            playerjump = false;

        }
        if (rb.position.y > 1f)
        {
            if (Input.GetKey("l"))
            {
                player.Rotate(0, 0, -sidewaysForce * Time.deltaTime);
            }

            if (Input.GetKey("j"))
            {
                player.Rotate(0, 0, sidewaysForce * Time.deltaTime);
            }
            if (Input.GetKey("k"))
            {
                player.Rotate(-sidewaysForce * Time.deltaTime,0,0);
            }

            if (Input.GetKey("i"))
            {
                player.Rotate(sidewaysForce * Time.deltaTime,0,0);
            }
            if (Input.GetKey("u"))
            {
                player.Rotate(0,-sidewaysForce * Time.deltaTime, 0);
            }

            if (Input.GetKey("o"))
            {
                player.Rotate(0,sidewaysForce * Time.deltaTime, 0);
            }
        }
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
            playerjump = true;
        }
        //se hvis du har ramme et objekt med taget obstacle
        if (Collisioninfo.collider.tag == "obstacle")
        {
            //går så spille ikke kan køre mere
            //move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
