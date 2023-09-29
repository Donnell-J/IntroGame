using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    int speed = 30;
    Rigidbody rb;

    [SerializeField]
    InputActionReference movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = movement.action.ReadValue<Vector2>();
        rb.MovePosition(transform.position + new Vector3(input.x,0,input.y) * speed * Time.deltaTime);
    }
}
