using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
/**
    Vector3 goal;
    
    [SerializeField] int speedScaler = 10;

    // Start is called before the first frame update
    void Start()
    {
        goal = GameObject.FindGameObjectsWithTag("GameController").GetGoalPosition();
    }

    // Update is called once per frame
    void Update()
    {
        double directionX = goal.x - this.x;
        double directionZ = goal.z - this.z;
        double scaling = directionX + directionZ;

        double moveX = directionX / scaling * speedScaler;
        double moveZ = directionZ / scaling * speedScaler;

        this.GetComponent<Rigidbody>().AddForce(moveX, 0, moveZ, ForceMode.VelocityChange);
    }
    */
}
