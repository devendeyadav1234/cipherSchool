using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_case : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    void Start()
    {
        switch(score){
            case 10:
                // Logic Here
                Debug.Log("Perfect Score");
                break;
            case 5:
                // Logic Here
                Debug.Log("The Score is Half");
                break;
            default:
                Debug.Log("The Score is not Good Enough");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
