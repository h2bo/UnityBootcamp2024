using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granolaMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.smoothDeltaTime * 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touched this: " + other.gameObject.name);
    }



}
