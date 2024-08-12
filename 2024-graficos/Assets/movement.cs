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
    [SerializeField] public KeyCode rotationLeft = KeyCode.None;
    [SerializeField] public KeyCode rotationRight = KeyCode.None;
    [SerializeField] public KeyCode colorChange = KeyCode.None;

    public Color newColor;
    public SpriteRenderer spriteRenderer;

    public Vector3 rotation;
    public float speed = 1;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color= newColor;
    }
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

        if (Input.GetKeyDown(rotationLeft))
        {
            transform.Rotate(-rotation * Time.deltaTime);
        }

        if (Input.GetKeyDown(rotationRight))
        {
            transform.Rotate(rotation * Time.deltaTime);
        }

        if (Input.GetKeyUp(colorChange))
        {
            newColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            spriteRenderer.color = newColor;
        }
    }
}
