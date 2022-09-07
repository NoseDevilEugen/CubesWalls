 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.AI;
     
 public class RandomizeWalls : MonoBehaviour
 {	

    public NavMeshSurface surface;

     void Start()
     {

        var wall1=GameObject.Find("Wall1");
        wall1.transform.position=new Vector3(Random.Range(-7, -5), 1, Random.Range(-8, 7));
        var wall2=GameObject.Find("Wall2");
        wall2.transform.position=new Vector3(Random.Range(-5, -2), 1, Random.Range(-8, 7));
        var wall3=GameObject.Find("Wall3");
        wall3.transform.position=new Vector3(Random.Range(-2, -0), 1, Random.Range(-8, 7));
        var wall4=GameObject.Find("Wall4");
        wall4.transform.position=new Vector3(Random.Range(-0, 2), 1, Random.Range(-8, 7));
        var wall5=GameObject.Find("Wall5");
        wall5.transform.position=new Vector3(Random.Range(2, 5), 1, Random.Range(-8, 7));
        var wall6=GameObject.Find("Wall6");
        wall6.transform.position=new Vector3(Random.Range(5, 7), 1, Random.Range(-8, 7));
        var wall7=GameObject.Find("Wall7");
        wall7.transform.position=new Vector3(Random.Range(-7, 7), 1, Random.Range(-8, 7));
        var wall8=GameObject.Find("Wall8");
        wall8.transform.position=new Vector3(Random.Range(-7, 7), 1, Random.Range(-8, 7));

        var death=GameObject.Find("DangerZone");
        death.transform.position=new Vector3(Random.Range(-6, 6), 1, Random.Range(-6, 6));
        var death1=GameObject.Find("DangerZone1");
        death1.transform.position=new Vector3(Random.Range(-6, 6), 1, Random.Range(-6, 6));
        var death2=GameObject.Find("DangerZone2");
        death2.transform.position=new Vector3(Random.Range(-6, 6), 1, Random.Range(-6, 6));
        var death3=GameObject.Find("DangerZone3");
        death3.transform.position=new Vector3(Random.Range(-6, 6), 1, Random.Range(-6, 6));
        var death4=GameObject.Find("DangerZone4");
        death4.transform.position=new Vector3(Random.Range(-6, 6), 1, Random.Range(-6, 6));
        var death5=GameObject.Find("DangerZone5");
        death5.transform.position=new Vector3(Random.Range(-6, 6), 1, Random.Range(-6, 6));

        //surface.RemoveNavMeshData();
		surface.BuildNavMesh();

     }
 }