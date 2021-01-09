using System.Collections;
using System.Collections.Generic;
using Helpers;
using UnityEngine;

public class GameplayController : SingletonComponent<GameplayController>
{

    public ObjectSpawner spawner;
    Rotator currentObject;

     
    public Cinemachine.CinemachineVirtualCamera virtualCamera;
    public void AddObjectRotation(PlayerInput.RotationDir direction)
    {
        // Debug.Log(direction);
       if (currentObject != null)
       {
           var dir2axis = new Dictionary<PlayerInput.RotationDir, Vector3>(){
               { PlayerInput.RotationDir.LEFT, Vector3.up },
               { PlayerInput.RotationDir.RIGHT, Vector3.up * -1f },
               { PlayerInput.RotationDir.UP, Vector3.right},
               { PlayerInput.RotationDir.DOWN, Vector3.right * -1f }
           };
           var torque = currentObject.torqueMultiplier * dir2axis[direction];
           print(torque);
            currentObject.GetComponent<Rigidbody>().AddTorque(currentObject.torqueMultiplier * dir2axis[direction] );
       } 
    }

    public void AddObjectRotation(Vector3 rotation)
    {
        if (currentObject != null)
       {
            currentObject.Rotate(rotation);
       } 
    }

    void Start()
    {
       spawner.ObjectSpawned += (newObject) => {
           currentObject = newObject;
            virtualCamera.Follow = currentObject.transform;
            //virtualCamera.LookAt = currentObject.transform;     
       }; 
    }

    void Update()
    {
        
    }
}
