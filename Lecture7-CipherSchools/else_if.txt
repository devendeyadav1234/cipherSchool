using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional_Statements : MonoBehaviour
{
    // If the age of the person is greater than 18, person can vote
    // Start is called before the first frame update
    public int age;
    void Start()
    {
        if (age<18) {
            Debug.Log("You are a teenager");
        }else if(age>=18 && age<60){ 
            Debug.Log("You are an Adult");
        }
        else{
            Debug.Log("You are old");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
