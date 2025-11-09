using System;
using UnityEngine;

public class SideToSide : MonoBehaviour
{
    private Vector3 startRo;
    public float speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startRo = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * 45;

        

        

        transform.eulerAngles = new Vector3(0, offset, 0);
    }
}
