using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
     [SerializeField] float moveSpeed = 10f; 
    // Start is called before the first frame update
    void Start()
    {
       PrintInstructions(); 
    }
    void Update()
    {
        MovePlayer();
        
    }

    void PrintInstructions()
    {
        Debug.Log("welcome");
        Debug.Log("Move Your Player with WASD or arrow keys");
        Debug.Log("Dont hit the walls");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }

    
    
}
