using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager
{
    // Start is called before the first frame update
   private static GameManager instance;
    private List<GameObject> trashCans=new List<GameObject>();
    public List<GameObject> TrashCans { get { return trashCans; }}
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
    public void RemoveTrashCan(int index)
    {
        //int index = trashCans.IndexOf(tempTrashCan);
        TrashCans.RemoveAt(index);
    
    }
}
