using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");    
        float vert = Input.GetAxis("Vertical");


        transform.Translate(new Vector3(horiz * speed * Time.deltaTime, vert * speed * Time.deltaTime, 0f));
    }
}
