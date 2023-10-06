using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{
    public GameObjectplayer;
    private Vector3offset;

    void Start(){
        offset = transform.position;
    }

    void LateUpdate(){
        transform.position = player.transform.position + offset;
    }
