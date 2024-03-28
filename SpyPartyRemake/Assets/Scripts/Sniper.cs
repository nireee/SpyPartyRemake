using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
    public GameObject[] targets;
    [SerializeField] private List<GameObject> suspious_targets;
    public GameObject focus;

    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        focus.SetActive(false);
        List<GameObject> suspious_targets = new List<GameObject>();
        FindSusTarget();
    }

    // Update is called once per frame
    void Update()
    {
        //bug with this part, will be fix later
        //timer.StartTimer();
        //if (timer.GetCurTime() == 0.1f)
        //{
        //    focus.SetActive(true);
        //    Observe(suspious_targets[0]);
        //    Debug.Log(suspious_targets[0]);
        //}
        //if (timer.GetCurTime() == 5.0f)
        //{
        //    Observe(suspious_targets[1]);
        //    Debug.Log(suspious_targets[1]);
        //    timer.StopTimer();
        //}
        
    }

    void FindSusTarget()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            var target = targets[i];
            if (target.tag == "Player" || target.tag == "DoubleAgent")
            {
                suspious_targets.Add(target);
            }
        }
    }

    void Observe(GameObject target)
    {
        focus.transform.position = target.transform.position;
    }

    void Sabotage(GameObject target)
    {
        //Selection of actions to sabotage each of the missions
    }

    void Evaluate(GameObject target)
    {
        //deduce on-going mission
    }

    void Snipe(GameObject target)
    {
        if(target.tag == "Player")
        {
            //sniper win
            Debug.Log("Sniper Wins!");
        }
        else
        {
            Debug.Log("Wrong Target Shot!");
        }
    }
}
