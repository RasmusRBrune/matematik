using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCOLLISION : MonoBehaviour
{
    public player_move move;
   
    void OnCollisionEnter(Collision Collisioninfo)
    {
        //se hvis du har ramme et objekt med taget obstacle
        if (Collisioninfo.collider.tag== "obstacle")
        {
            //går så spille ikke kan køre mere
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
 
}
