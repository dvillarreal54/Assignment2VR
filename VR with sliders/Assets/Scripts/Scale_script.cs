using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale_script : MonoBehaviour
{
    // Start is called before the first frame update
    public void sSlider(float value)
    {
        Vector3 sc = transform.localScale;
        sc.x = value;
        sc.y = value;
        sc.z = value;
        transform.localScale = sc;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
