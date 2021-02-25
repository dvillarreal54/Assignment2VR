using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y_Script : MonoBehaviour
{
    public void Slider_Changed(float newValue)
    {
        Vector3 pos = transform.position;
        pos.y = newValue;
        transform.position = pos;
    }
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
