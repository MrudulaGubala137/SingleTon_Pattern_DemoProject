using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject healthPrefab;
    GameObject temp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray.origin, ray.direction,out hit))
            {
                temp=Instantiate(healthPrefab,hit.point,Quaternion.identity);
             
                GameManager.Instance.AddTrashCan(temp);
                print(GameManager.Instance.TrashCans.Count);
            }
        }
       /* if(Input.GetMouseButtonDown(1))
        {
            GameManager.Instance.RemoveTrashCan();
            print(GameManager.Instance.TrashCans.Count);
        }*/
        
    }
}
