using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTracker : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
