using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGoalAchieved : MonoBehaviour
{

    GameObject levelActions;

    private void Start() {
        levelActions = GameObject.FindGameObjectsWithTag("GameController")[0];
    }

    private void OnCollisionEnter(Collision other) {
    
        if (other.gameObject.CompareTag("Character")) {
            print("Goal! - You Lose!");

            levelActions.GetComponent<LevelActions>().LevelLose();
        }
      
    } 
}
