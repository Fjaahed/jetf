using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] jet;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(Spawnjet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void jets()
    {
            int rand = Random.Range(0,jet.Length);
            float randyPos= Random.Range(-12.7f,10.2f);
            Instantiate(jet[rand], new Vector3( transform.position.x,randyPos,transform.position.z) ,Quaternion.Euler(0,0,-90));
        
    }

    IEnumerator Spawnjet() {
       while(true){
             yield return new WaitForSeconds(4);
               jets();
       }
    }
}
