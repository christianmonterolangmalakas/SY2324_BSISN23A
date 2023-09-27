using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlebehaviorscript1: MonoBehaviour
{
    public float rotationSpeed = 50.0f;
    private void Awake()
    {
        Debug.Log("I am awake");
    }
    private void OnEnable()
    {
        Debug.Log("I am Enable");

    }

    private void OnDisable()
    {
        Debug.Log("I am Disable");

    }




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Components started");
    }
    private void Update()
    {

        transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
    }
    private void OnDestroy()
    {
        Debug.Log("I am Destroyed");
    }
}
