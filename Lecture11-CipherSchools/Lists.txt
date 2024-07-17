using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    public List<string> myList= new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        myList.Add("John");
        myList.Add("Bob");
        myList.Add("Jenny");

        for(int i=0;i<myList.Count;i++){
            Debug.Log(myList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
