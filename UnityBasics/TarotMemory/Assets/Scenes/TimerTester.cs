using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimerTester : MonoBehaviour
{

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



        
    }

    private async void TestMethod()
    {
        
    }

    private System.Collections.IEnumerator WaitThenDo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }
}
