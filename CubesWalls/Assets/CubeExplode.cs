using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeExplode : MonoBehaviour
{
    public int cubesPerAxis=3;
    public float delay=1f;
    public float force=300f;
    public float radius=2f;
    public bool isHold=false;
    private int seconds;
    private float timer;

    public Material r_Material;
    public Material i_Material;
    public Renderer prd;

    public Vector3 startPos;
    private GameObject isPlayer;

    public Color firstC;
    public Color secondC;



    // Start is called before the first frame update
    void Start()
    {


    // Invoke("Main", delay);   
    isPlayer=GameObject.Find("Player");
    startPos=isPlayer.transform.position;

    prd = isPlayer.GetComponent<Renderer>();
   
    timer= 0.0f;
    }

    void CreateCube(Vector3 coordinates)
        {
        GameObject cube=GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer rd=cube.GetComponent<Renderer>();
        rd.material=gameObject.GetComponent<Renderer>().material;
        cube.transform.localScale=transform.localScale/cubesPerAxis;
        Vector3 firstCube = transform.position - transform.localScale/2 + cube.transform.localScale/2;
        cube.transform.position = firstCube+Vector3.Scale(coordinates, cube.transform.localScale);


        Object.Destroy(cube, 2.0f);


        Rigidbody rb = cube.AddComponent<Rigidbody>();
        rb.AddExplosionForce(force, transform.position, radius);

        }


    void myDeath()
        {
        for(int x=0; x<cubesPerAxis; x++)
            {
            for(int y=0; y<cubesPerAxis; y++)
                {
                for (int z=0; z<cubesPerAxis; z++)
                    {
                    CreateCube(new Vector3(x, y, z));
                    }    
                }

            }                
        //Destroy(gameObject);
        gameObject.transform.position=startPos;   
        }

    // Update is called once per frame
    void Update()
    {
        if(isHold==true && seconds<2)
            {
            prd=gameObject.GetComponent<Renderer>();
            prd.material=i_Material;
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);

            }
        else
            {
            prd=gameObject.GetComponent<Renderer>();
            prd.material=r_Material;
            isHold=false;  
            seconds=0;
            timer=0f;    
            } 
    }

    
    void OnTriggerEnter(Collider collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Danger" && isHold==false)
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Invoke("myDeath", 0f);
        }

        if(collision.gameObject.name=="Target")
            {
            SceneManager.LoadScene( SceneManager.GetActiveScene().name );    
            }
    }
    

    
}
