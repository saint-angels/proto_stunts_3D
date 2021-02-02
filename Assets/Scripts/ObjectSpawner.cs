using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public event Action<Rotator> ObjectSpawned = (newObject) => { };
    public Transform spawnPoint = null;
    public Rotator objectPrefab = null;
    public float speed;
    public float dropTimeScale;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rotator newObject = Instantiate(objectPrefab, spawnPoint); 
           ObjectSpawned(newObject);
           newObject.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * speed);
            // Time.timeScale = dropTimeScale;
            //Time.timeScale = dropTimeScale;
            //asdfasdf
        }
    }
}
