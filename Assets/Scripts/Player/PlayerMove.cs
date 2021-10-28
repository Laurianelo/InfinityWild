using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speed = 3f;
    [SerializeField] private float leftRightSpeed = 3f;
    void Update()
    {
        MoveForward();
        RightAndLeftMovement();
    }


    private void RightAndLeftMovement()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
    }
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed,Space.World);
    }
}
