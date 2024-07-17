using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    int global; // Global Variables can be accessed by the whole program because they are global in nature 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(add(2,4));
    }

    // Update is called once per frame
    void Update()
    {
        // add(); 
        // Will get called in every frame

    }

    // Customized Functions
    public int add(int num1, int num2)
    {
        Debug.Log("This is add Function");
        // result is a local variable, it is only know inside this scope
        int result=num1+num2;
        return result;
    }
}
