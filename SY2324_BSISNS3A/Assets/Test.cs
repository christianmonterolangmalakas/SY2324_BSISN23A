using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float moveSpeed = 3f;
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

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
    private void OnDestroy()
    {
        Debug.Log("I am Destroyed");
    }
}