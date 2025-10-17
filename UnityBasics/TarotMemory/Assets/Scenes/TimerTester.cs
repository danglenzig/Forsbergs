using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimerTester : MonoBehaviour
{

    private float elapsed = 0.0f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



        for (int i = 0; i< 10; i++)
        {
            StartCoroutine(WaitThenDo(1.0f));
            Debug.Log(elapsed);
        }
    }

    private void Update()
    {
        elapsed += Time.deltaTime;
    }

    private System.Collections.IEnumerator WaitThenDo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }
}
