using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquishCharacter : MonoBehaviour
{

    GameObject levelActions;

    private void Start() {
        levelActions = GameObject.FindGameObjectsWithTag("GameController")[0];
    }


    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Obstacle")) {
            print("Squished!");
            //Squish Animation
            levelActions.GetComponent<LevelActions>().LevelWin();
        }
    }
}
