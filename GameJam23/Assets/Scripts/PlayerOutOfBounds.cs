using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutOfBounds : MonoBehaviour
{

    GameObject levelActions;

    private void Start() {
        levelActions = GameObject.FindGameObjectsWithTag("GameController")[0];
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Character")) {
            print("Character Out of Bounds! - You Win!");
            // Out of Bounds Animation Call
            levelActions.GetComponent<LevelActions>().LevelWin();
        }
    }
}
