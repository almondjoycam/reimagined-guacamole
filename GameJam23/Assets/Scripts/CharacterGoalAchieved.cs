using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGoalAchieved : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
    
        if (other.gameObject.CompareTag("Character")) {
            print("Goal! - You Lose!");
        }
      
    } 
}
