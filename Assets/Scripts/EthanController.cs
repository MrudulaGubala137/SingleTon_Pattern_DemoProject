using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EthanController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] goalPoints;
    NavMeshAgent agent;
    Vector3 lastPoint;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        goalPoints = GameObject.FindGameObjectsWithTag("Goal");
        GotoLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance<1f)
        {
            GotoLocation();
        }
    }
    public void GotoLocation()
    {
        lastPoint = agent.destination;
        agent.SetDestination(goalPoints[Random.Range(0, goalPoints.Length)].transform.position);
    }
}
