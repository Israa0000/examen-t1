using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UIElements;

public class squares : MonoBehaviour
{
    [SerializeField] GameObject redSquare;
    [SerializeField] GameObject blueSquare;
    [SerializeField] GameObject redRotateSquare;
    [SerializeField] GameObject blueRotateSquare;
    [SerializeField] float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        redSquare.transform.position = Vector3.left;
        blueSquare.transform.position = Vector3.right;
        redSquare.GetComponent<SpriteRenderer>().color = Color.red;
        blueSquare.GetComponent<SpriteRenderer>().color = Color.blue;
        redRotateSquare.GetComponent<SpriteRenderer>().color = Color.red;
        blueRotateSquare.GetComponent<SpriteRenderer>().color = Color.blue;
    }
        // Update is called once per frame
        void Update()
    {
        redRotateSquare.transform.Rotate(new Vector3(0,0,7) * speed * Time.deltaTime);
        blueRotateSquare.transform.Rotate(new Vector3(0, 0, 7) * speed * Time.deltaTime);

            if (Input.GetKey(KeyCode.UpArrow)) 
                {
                redSquare.transform.position += Time.deltaTime * speed * Vector3.up;
                blueSquare.transform.position += Time.deltaTime * speed * Vector3.up;
                }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                redSquare.transform.position += Time.deltaTime * speed * Vector3.left;
                blueSquare.transform.position += Time.deltaTime * speed * Vector3.left;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                redSquare.transform.position += Time.deltaTime * speed * Vector3.right;
                blueSquare.transform.position += Time.deltaTime * speed * Vector3.right;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                redSquare.transform.position += Time.deltaTime * speed * Vector3.down;
                blueSquare.transform.position += Time.deltaTime * speed * Vector3.down;
            }

            if (Input.GetKey(KeyCode.W)) 
            {
                redSquare.transform.position += Time.deltaTime * speed * Vector3.up;
                blueSquare.transform.position += Time.deltaTime * speed * Vector3.down;
            }

            if (Input.GetKey(KeyCode.A))
            {
                redSquare.transform.position += Time.deltaTime * speed * Vector3.left;
                blueSquare.transform.position += Time.deltaTime * speed * Vector3.right;
            }

            if (Input.GetKey(KeyCode.D))
            {
                redSquare.transform.position += Time.deltaTime * speed * Vector3.right;
                blueSquare.transform.position += Time.deltaTime * speed * Vector3.left;
            }

            if (Input.GetKey(KeyCode.S))
            {
                redSquare.transform.position += Time.deltaTime * speed * Vector3.down;
                blueSquare.transform.position += Time.deltaTime * speed * Vector3.up;
            }
    }
}
