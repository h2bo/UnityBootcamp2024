using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowMoveScript : MonoBehaviour
{

    public GameObject thePlayer;



    // Start is called before the first frame update
    void Start()
    {
        //GameObject thePlayer = GameObject.Find("thePlayer");

        Debug.Log(thePlayer.transform.position);
    }

    private void FixedUpdate()
    {
        this.transform.LookAt(thePlayer.transform);
        this.transform.Translate(Vector3.forward * Time.deltaTime);
        //2. walk towards the player

            //get position of the player
    }
}
