using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Hits = 0;
    private void OnCollisionEnter(Collision other)
    { if (other.gameObject.tag != "Hit")
      {
           Hits++;
        Debug.Log("Player Bumped into a Wall this no. of times:" + Hits);
      }
    
    }
}
