using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTower : MonoBehaviour{
    public float Speed;
    public Transform target;

    
  
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * Speed);
    }
}
