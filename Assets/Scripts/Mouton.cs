using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouton : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject _zoneDanger;
    [SerializeField] private GameObject _para;

    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){

        //Debug.Log(other.gameObject.tag);

        if(other.gameObject.tag == _zoneDanger.gameObject.tag){

            _para.SetActive(true);
            _rb.drag += 1;
        }

    }

}
