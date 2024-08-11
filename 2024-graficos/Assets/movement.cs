using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static System.Runtime.CompilerServices.RuntimeHelpers;


public class movement : MonoBehaviour
{
    [SerializeField] public KeyCode right = KeyCode.None;
    [SerializeField] public KeyCode left = KeyCode.None;
    [SerializeField] public KeyCode up = KeyCode.None;
    [SerializeField] public KeyCode down = KeyCode.None;
    [SerializeField] public KeyCode test = KeyCode.None;

    public Vector3 rotation;
    public float speed = 1;
   
    void Update()
    {

        Vector3 pos = transform.position;

        if (Input.GetKey(right))
        {
            pos.x += speed * Time.deltaTime;

        }
        else if (Input.GetKey(left))
        {
            pos.x -= speed * Time.deltaTime;
        }

        else if (Input.GetKey(up))
        {
            pos.y += speed * Time.deltaTime;
        }
        else if (Input.GetKey(down))
        {
            pos.y -= speed * Time.deltaTime;
        }
        transform.position = pos;

        if (Input.GetKey(test))
        {
            transform.Rotate(rotation * Time.deltaTime);
        }
    }
}
