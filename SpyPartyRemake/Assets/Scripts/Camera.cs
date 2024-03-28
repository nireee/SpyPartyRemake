using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform cur_transform;
    public GameObject agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveWithPlayer();
    }

    void MoveWithPlayer()
    {
        cur_transform.Translate(agent.transform.position.x, agent.transform.position.y, cur_transform.position.z);
    }
}
