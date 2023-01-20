using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road_move : MonoBehaviour
{
    public Renderer meshRenderer;

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        meshRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime,0);
    }
}
