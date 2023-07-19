using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlanTekrarEtsin : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 baslangicPozisyonu; 
    private float tekrarEt;
    void Start()
    {
        baslangicPozisyonu = transform.position;
        tekrarEt = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < baslangicPozisyonu.x -tekrarEt)
        {
            transform.position = baslangicPozisyonu;
        }
    }
}
