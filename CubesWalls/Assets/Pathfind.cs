using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfind : MonoBehaviour
{
	public Transform[] points;
  	private NavMeshAgent nav;
  	private int destPoint;
    private int seconds;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
    nav = GetComponent<NavMeshAgent>();    
    timer= 0.0f;
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    if(seconds<2)
      {
      timer += Time.deltaTime;
      seconds = (int)(timer % 60);

      }
    else
      {
      if (!nav.pathPending 
        && nav.remainingDistance < 0.5f
        && nav.pathStatus == NavMeshPathStatus.PathComplete)
  		  {
        
  		  GoToNextPoint();
  		  }  
      }
  }

    void GoToNextPoint()
  	{
  		if (points.Length == 0)
  		{
  		return;
  		}
  	nav.destination = points[destPoint].position;
  	destPoint = (destPoint + 1) % points.Length;
  }
}
