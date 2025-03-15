using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(391.6685f, 6.047169f, 86.95406f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
