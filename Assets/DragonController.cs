using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    [SerializeField] private float speed;
    private FixedJoystick FixedJoystick;
    public Rigidbody rigidBody;

     public void Awake()
     {
        speed = Random.Range(0.01f,0.2f);
     }

    private void OnEnable()
    {
        FixedJoystick = FindObjectOfType<FixedJoystick>();
    

    }

    private void FixedUpdate()
    {
        float xVal = FixedJoystick.Horizontal;
        float yVal = FixedJoystick.Vertical;

        Vector3 movement = new Vector3(xVal, 0, yVal);
        rigidBody.velocity = movement * speed;

        if(xVal !=0 && yVal !=0 )
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, yVal)*Mathf.Rad2Deg, transform.eulerAngles.z);
        }
        
    }
}
