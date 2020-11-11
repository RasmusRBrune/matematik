using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    // Update is called once per frame
    void Update()
    {
        //teller hvor lang spiller har køret 
        ScoreText.text = player.position.z.ToString("0");
        
    }
  
}
