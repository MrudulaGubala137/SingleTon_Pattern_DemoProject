using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EthanController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    //private GameObject[] goalPoints;
    NavMeshAgent agent;
    Vector3 lastPoint;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //goalPoints = GameObject.FindGameObjectsWithTag("Goal");
        GotoLocation();
    }

    // Update is called once per frame
    void Update()
    {

        if(agent.remainingDistance<1f && GameManager.Instance.GoalPoints.Count>=1)
        {
            GotoLocation();
        }
        else
        {
            transform.position = this.transform.position;
        }
       // Vector3.Distance(this.transform.position,);
       foreach(GameObject item in GameManager.Instance.GoalPoints)
        {
          float tempDistance= Vector3.Distance(this.transform.position,item.transform.position);
            if(tempDistance < 5f && Random.Range(0,10)<5)
            {
               // print("char distance is below 5");
                agent.SetDestination(lastPoint);
            }
            else if(tempDistance <1f)
            {
                GameManager.Instance.RemoveTrashCan(item);
            }
        }
    }
    public void GotoLocation()
    {
        lastPoint = agent.destination;
        //agent.SetDestination(goalPoints[Random.Range(0, goalPoints.Length)].transform.position);
        agent.SetDestination(GameManager.Instance.GoalPoints[Random.Range(0, GameManager.Instance.GoalPoints.Count)].transform.position);
    }
}
