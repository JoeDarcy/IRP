using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXMovement : MonoBehaviour
{
    public static float moveSpeed;
    public float startDelay;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 6.65f)
            transform.Translate(moveSpeed * Time.deltaTime * Vector2.right);    
    }
}
