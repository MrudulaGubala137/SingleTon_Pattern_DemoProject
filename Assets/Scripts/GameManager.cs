using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager
{
    // Start is called before the first frame update
   private static GameManager instance;
    private List<GameObject> trashCans=new List<GameObject>();
    private List<GameObject> goalPoints=new List<GameObject>();
    public List<GameObject> TrashCans { get { return trashCans; }}
    public List<GameObject> GoalPoints { get { return goalPoints; }}
    public static GameManager Instance { 
        get { 
            if(instance == null)
            {
                instance = new GameManager();
            }
            return instance; } }
    public void AddTrashCan(GameObject tempTrashCan)
    {
        TrashCans.Add(tempTrashCan);
    }
    public void AddGoalPoints(GameObject tempGoalPoints)
    {
        GoalPoints.Add(tempGoalPoints);
    }
    public void RemoveTrashCan(GameObject tempTrashCan)
    {
        int index = trashCans.IndexOf(tempTrashCan);
        GameObject.Destroy(trashCans[index]);
        TrashCans.RemoveAt(index);
    }
}
