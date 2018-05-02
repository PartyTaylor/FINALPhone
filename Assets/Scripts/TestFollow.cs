using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestFollow : MonoBehaviour
{

    public Transform player;
    public ItemCounter count;
    public NavMeshAgent agent;
    public int total;
    public int currentTotal;
    public PhoneLight battery;
    public float speed;
    private void Start()
    {
        count = GameObject.FindGameObjectWithTag("Player").GetComponent<ItemCounter>();
        agent = GetComponent<NavMeshAgent>();
        currentTotal = 0;
        speed = agent.speed;
    }

    void Update()
    {
        total = count.getTotalItem();
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = player.position;
        speed = (100 - battery.getBattery()) / 100 + speed;
        agent.speed = speed;
        if (total >= currentTotal)
        {
            currentTotal = total;
            agent.speed = agent.speed * 2;
        }
    }
}