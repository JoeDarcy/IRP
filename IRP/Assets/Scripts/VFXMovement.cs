using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXMovement : MonoBehaviour
{
    public float moveSpeed;
    public float startDelay;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 6.65f)
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}
