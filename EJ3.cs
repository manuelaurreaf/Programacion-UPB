using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ3 : MonoBehaviour
{
    Light mLuz;
    Renderer mRender;
    // Start is called before the first frame update
    void Start()
    {
        mLuz = GetComponent<Light>();
        mRender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mLuz.intensity >= 0.25 && mLuz.intensity < 0.5)
        {
            Color c = new Color(0, 0, 1);
            mRender.material.color = c;
        }
        else if (mLuz.intensity >= 0.5 && mLuz.intensity < 0.75)
        {
            Color c = new Color(1, 0, 0);
            mRender.material.color = c;
        }
        else
        {
            Color c = new Color(1, 1, 1);
            mRender.material.color = c;
        }
    }
}
