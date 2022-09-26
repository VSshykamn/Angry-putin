using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] private float TankSpeed = 1.5f;
    [SerializeField] private float RotateSpeed = 9f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float MovementVertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, MovementVertical) * TankSpeed * Time.deltaTime);

        float RotateMovement = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, RotateMovement, 0) * RotateSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.X))
        {
            TankSpeed = 5f;
            RotateSpeed = 15f;


        }

        else if (Input.GetKeyDown(KeyCode.C)) 
        {
            TankSpeed = 1.5f;
            RotateSpeed = 9f;
        }
        
    }
}
