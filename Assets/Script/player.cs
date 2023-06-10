using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;
    Rigidbody2D rigid;

    void Start()
    {
        //Output the current screen window width in the console
        Debug.Log("Screen Width : " + Screen.width);
        Debug.Log("Screen Height : " + Screen.height);
    }

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        speed = 3;
    }

    void Update(){
        if (rigid.position.x > Screen.width){
        }

        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
        if (Input.GetAxisRaw("Jump") == 1){
            speed = 5;
        }
        else{
            speed = 3;
        }
    }

    void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
    }
}
