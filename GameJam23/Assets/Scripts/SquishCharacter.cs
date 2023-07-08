using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquishCharacter : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Obstacle")) {
            print("Squished!");
        }
    }
}
