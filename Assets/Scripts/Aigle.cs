using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aigle : MonoBehaviour
{
    // Start is called before the first frame update


    private Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BougeAigle();
    }

    void BougeAigle(){

        _rb.velocity = Vector3.forward;
    }

}
