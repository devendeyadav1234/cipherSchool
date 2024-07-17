using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_DataTypes : MonoBehaviour
{
    int myInt=5; // Private by default
    float myFloat = 10.5f;
    bool myBool = true;

    public string myString; // Whenever i make my variable public, it will be shown in the inspector
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The Value of myInt is: " + myInt);
        Debug.Log("The Value of myFloat is: " + myFloat);
        Debug.Log("The Value of myBool is: " + myBool);
        Debug.Log("My Name is " + myString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
