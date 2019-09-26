using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    Rigidbody mBody;
    Renderer mRender;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        mBody = GetComponent<Rigidbody>();
        mRender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t <= 3)
        {
            Color c = new Color(1, 0, 0);
            mRender.material.color = c;
        }
        else if(t > 3 && t <= 6)
        {
            Color c = new Color(0, 0, 1);
            mRender.material.color = c;
        }
        else
        {
            Color c = new Color(0.8f, 0, 1);
            mRender.material.color = c;
        }
    }
}
