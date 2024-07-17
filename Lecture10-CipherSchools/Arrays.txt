using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] myArray; // Ny this we can give size from inspector since it is public
    public int[] myArray1=new int[5]; // New instance of the array
    // Start is called before the first frame update
    void Start(){
        for(int i = 0; i < myArray1.Length; i++){
            Debug.Log("Value: " + myArray1[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
