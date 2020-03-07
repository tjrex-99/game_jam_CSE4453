using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target.position.y != transform.position.y)
        {
            transform.position = new Vector3(0f, target.position.y, -10f);
        }
    }
}
