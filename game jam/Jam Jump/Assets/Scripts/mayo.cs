using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mayo : MonoBehaviour
{
    private bool FacingRight = true;
    public Transform target;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

// Update is called once per frame
void FixedUpdate()
    {
        if (FacingRight)
        {
            if (target.position.x < transform.position.x)
            {
                Flip();
            }
        }
        else
        {
            if (target.position.x >= transform.position.x)
            {
                Flip();
            }
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        FacingRight = !FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
