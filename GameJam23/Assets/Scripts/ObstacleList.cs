using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleList : MonoBehaviour
{

    GameObject[] Obstacles;
    int speedScale = 10;

    // Start is called before the first frame update
    void Start()
    {
        Obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        print(Obstacles);
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        for(int i = 0; i < Obstacles.Length; i++) {
                Rigidbody body = Obstacles[i].GetComponent<Rigidbody>();
                body.AddForce(speedScale*horizontal*Time.deltaTime,0,speedScale*vertical*Time.deltaTime,ForceMode.VelocityChange);
        }
        
           
    }
}
