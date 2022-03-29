using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [HideInInspector]
    public  float speed;

    private Rigidbody2D myBody;

    private SpriteRenderer sr;
    private Animator anim;

    private bool Flip = false;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        speed = -2f;
    }

    // Update is called once per frame
    void Update()
    {
        AnimateDragon();
    }

    void AnimateDragon() {
        anim.speed = 0.3f;

        sr.flipX = Flip;
        float currentSpeed = Flip ? speed * -1 : speed;
        myBody.velocity = new Vector2(currentSpeed, myBody.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("dragon collision");
        if (collision.gameObject.CompareTag("Boundary")) {
            Flip = !Flip;

            Debug.Log("dragon flip: " + Flip);
        }
    }
    
}
