using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public float move_speed;
    [SerializeField] private Transform transform;
    public Mission mission;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        //without animation of fliping the sprite
        transform.Translate(Input.GetAxis("Horizontal") * move_speed * Time.deltaTime, 0, 0);
        transform.Translate(0, Input.GetAxis("Vertical") * move_speed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ambassador")
        {
            mission.TapAmbassador();
        }
        if (collision.gameObject.tag == "Book")
        {
            mission.ExamineBook();
        }
        if (collision.gameObject.tag == "Statue")
        {
            mission.ExamineStatue();
        }
        if (collision.gameObject.tag == "Drink")
        {
            mission.GetDrink();
        }
        if (collision.gameObject.tag == "NPC")
        {
            mission.TalkWithPeople();
        }

    }
}
