using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Move player with WASD or arrow keys");
        Debug.Log("Do not hit the walls!");
    }

    void MovePlayer() 
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xVal, 0, zVal);
    }
}
