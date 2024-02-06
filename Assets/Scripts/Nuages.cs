using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuages : MonoBehaviour
{
    // Start is called before the first frame update

    private float _positionX;
    private float _positionY;
    private float _positionZ;
    [SerializeField] private float _vitesse = 4;

    void Start()
    {

        _positionX = transform.position.x;
        _positionX = transform.position.y;
        _positionX = transform.position.z;

    
        
    }

    // Update is called once per frame
    void Update()
    {

        BougeNuage();

    }


    void BougeNuage(){

        //float _nouellePositionX = _nouellePositionX + 1;

        //-----------------------------------------------ca sert a 
        //_positionX = _positionX + (_vitesse * Time.deltaTime);

        //transform.position = new Vector3(_positionX,_positionY, _positionZ);

        //-----------------------------------------------ca sert a 


    transform.Translate(Vector3.right * _vitesse * Time.deltaTime);     // Vexteurs4(1,0,0);

    }

}
