using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int rotate = 75;
        transform.Rotate(0 , 0, rotate + Time.deltaTime );
        
    }

    // Update is called once per frame
    void Update()
    {
       
    
 }
}