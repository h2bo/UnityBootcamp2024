using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnWeapon : MonoBehaviour
{
    public GameObject theBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButton(0))
        //do stuff




        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject.Instantiate(theBox, this.transform.position, this.transform.rotation);
            
        }
        //detect the enter key being pressed
        // spawn a granola box
    }
}
