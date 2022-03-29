using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [HideInInspector]
    public  float speed;

    private Rigidbody2D myBody;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();

        speed = -2f;
    }

    // Update is called once per frame
    void Update()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }
}
