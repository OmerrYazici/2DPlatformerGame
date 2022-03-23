using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public float speed;
    public Transform bir, iki, startPos;
    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == bir.position.x)
        {
            nextPos = iki.position;
        }
        if (transform.position.x == iki.position.x)
        {
            nextPos = bir.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}
