using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Timer_maxTime;
    private bool Timer_activate;
    [SerializeField] private float Timer_curTime;
    // Start is called before the first frame update
    void Start()
    {
        Timer_curTime = 0.0f;
        Timer_activate = false;
    }


    // Update is called once per frame
    void Update()
    {
        if( Timer_activate )
        {
            Timer_curTime += Time.deltaTime;
        }

        Alert();
    }

    public float GetCurTime()
    {
        return Timer_curTime;
    }

    public void StartTimer()
    {
        Timer_activate = true;
    }

    public void StopTimer()
    {
        Timer_activate = false;
        ResetTimer();
    }


    void Alert()
    {
        if(Timer_curTime == Timer_maxTime)
        {
            Debug.Log("Timer Alert!");
        }
    }

    void ResetTimer()
    {
        Timer_curTime = 0.0f;
    }
}
