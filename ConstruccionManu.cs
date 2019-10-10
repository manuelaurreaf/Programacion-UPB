using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using manuela; 
public class ConstruccionManu : MonoBehaviour
{
    [SerializeField] float salud;
    [SerializeField] MotorManuela construccion; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void destruir()
    {
        salud -= construccion.damage /2;
    }
}
