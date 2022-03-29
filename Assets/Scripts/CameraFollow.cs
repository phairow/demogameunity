using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;

    private Vector3 tempPos;

    [SerializeField]
    private float minX;

    [SerializeField]
    private float maxX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate() {
        UpdateCamera();
    }

    void UpdateCamera() {
        tempPos = transform.position;
        tempPos.x = player.position.x;

        Debug.Log("x = " + tempPos.x);
        if (tempPos.x < minX) {
            tempPos.x = minX;
        }

        if (tempPos.x > maxX) {
            tempPos.x = maxX;
        }
        Debug.Log("x = " + tempPos.x);

        transform.position = tempPos;
    }
}
