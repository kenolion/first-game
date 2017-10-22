﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;

    public float sensitivty = 5.0f;
    public float smoothing = 2.0f;
    private float test = 0.0f;

    public float moveSpeed = 20.0f;
    public bool invert;
    private float hozTurn = 0.0f;
    private float verTurn = 0.0f;
    GameObject character;
	// Use this for initialization
	void Start ()
    { 
	    character = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensitivty * smoothing, sensitivty * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);


    }
}
