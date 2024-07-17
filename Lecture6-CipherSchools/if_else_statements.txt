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
        if (age >= 18)
        {
            Debug.Log("You can vote");
        }
        else {
            Debug.Log("You can't vote");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
