using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOLLOWPLAYER : MonoBehaviour
{
    public Transform player;
    public Vector3 offset   ;
    public float mouseSensitivity = 100f;


    //til at camera kan være follow spiller 
    void Update()
    {
        transform.position = player.position + offset;
        
       /* Camera mycam = GetComponent<Camera>();
        transform.LookAt(mycam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane)), Vector3.up);*/
        transform.rotation = player.rotation;
    }
}
