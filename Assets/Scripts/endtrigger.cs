using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public GameManager gameManager;
     void OnTriggerEnter()
    {
        //til målet hvis spille ramme objekt
        gameManager.level_complete();
    }
}
