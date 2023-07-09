using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{

    Vector3 goal;
    
    [SerializeField] float speedScaler = .10;

    // Start is called before the first frame update
    void Start()
    {
        goal = GameObject.FindGameObjectsWithTag("GameController")[0].GetComponent<GoalPositionSignal>().GetGoalPosition();
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = goal.x - transform.position.x;
        float directionZ = goal.z - transform.position.z;
        float scaling = directionX + directionZ;

        float moveX = directionX / scaling * speedScaler;
        float moveZ = directionZ / scaling * speedScaler;

        this.GetComponent<Rigidbody>().AddForce(moveX, 0, moveZ, ForceMode.VelocityChange);
    }
    
}
