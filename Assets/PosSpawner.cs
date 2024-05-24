using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosSpawner : MonoBehaviour
{
    public List<GameObject> spawners = new List<GameObject>();
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SetPos",3f);
    }
    public void SetPos()
    {
      Vector3 getPos =  camera.transform.position;

     foreach (var item in spawners)
     {
        //vector3.back
        item.transform.position = getPos;    
     }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
