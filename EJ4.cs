using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ4 : MonoBehaviour
{
    Light mLuz;
    // Start is called before the first frame update
    void Start()
    {
        mLuz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
       float magnitude = transform.localScale.magnitude;
        mLuz.intensity = 0.5f * magnitude;
    }
}
