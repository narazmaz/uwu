using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_script : MonoBehaviour
{
  
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(100 * Time.deltaTime, 10 * Time.deltaTime, 0);
    }
}
