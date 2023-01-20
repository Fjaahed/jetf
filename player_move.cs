using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public Transform transform;
    public float speed = 2f;
    public float rotationspeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0,speed*Time.deltaTime,0);
            //transform.rotation = Quaternion.lerp(transform.rotation,Quaternion.Euler(0,0,7),rotationspeed * Time.deltaTime );
        }

         if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0,speed*Time.deltaTime,0);
        }

        if (transform.position.y<-7.8f)
        {
            transform.position = new Vector3(transform.position.x,-7.8f,transform.position.z);
        }

        if (transform.position.y>7.7f)
        {
            transform.position = new Vector3(transform.position.x,7.7f,transform.position.z);
        }
    }
    private void OnTriggerEnter2d(Collider2D collision){
        Debug.Log("booom!!");
    }
}
