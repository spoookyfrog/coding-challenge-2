using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        float movement = 6.5f;
        transform.Translate(0 , movement , Time.deltaTime, 0 );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
