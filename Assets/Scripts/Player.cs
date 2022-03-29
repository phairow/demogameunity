using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;

    private string WALK_ANIMATION = "Walk";

    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
    }

    void PlayerMoveKeyboard() {
        movementX = Input.GetAxis("Horizontal");

        Debug.Log("x value is : " + movementX + " , delta time: " + Time.deltaTime);

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer() {
        anim.speed = 0.3f;
        if (movementX > 0 ) {
            sr.flipX = false;
            anim.SetBool(WALK_ANIMATION, true);
        } else if (movementX < 0) {
            sr.flipX = true;
            anim.SetBool(WALK_ANIMATION, true);
        } else {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }
}
