using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Jugador : MonoBehaviour
{
    public Rigidbody RB;
    public float movder;
    public float movizq;
    public float speed = 6;


    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            movizq.position(Vector3.left) * speed * Time.deltaTime;
        }*/

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //olvide como hacer que se mueva :(( no repase -_-
        }
    }
    
}
