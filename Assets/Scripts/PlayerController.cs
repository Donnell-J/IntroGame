using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
    public Vector2 moveValue;
    public float speed;

    void OnMove(InputValue value){
        moveValue = value.Get<Vector2>();
    }

    void FixedUpdate(){
<<<<<<< HEAD
        Vector3 movement = new Vector3(moveValue.x,0.0f,moveValue.y).normalized;
=======
        Vector3 movement=new Vector3(moveValue.x,0.0f,moveValue.y).normalized;
>>>>>>> 03c461cc5580cef0ca6e93798cfa96632bbda49b
        GetComponent<Rigidbody>().AddForce(movement*speed*Time.fixedDeltaTime);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "PickUp"){
            other.gameObject.SetActive(false);
        }
    }
}