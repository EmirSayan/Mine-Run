using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokEt : MonoBehaviour
{
    private float kenar = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -kenar)
        {
            Destroy(gameObject);
        }
    }
}
