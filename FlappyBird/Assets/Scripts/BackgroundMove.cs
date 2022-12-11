using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    private MeshRenderer mRenderer;
    public float speed = 0.81f;
    //private Vector3 startPos;

    //private void Start()
    //{
    //    startPos = transform.position;
    //}

    //private void Update()
    //{
    //    transform.Translate(Vector3.left * speed * Time.deltaTime);

    //    if(transform.position.x < -17.70511f)
    //    {
    //        transform.position = startPos;
    //    }
    //}

    private void Awake()
    {
        mRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        mRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }

}
