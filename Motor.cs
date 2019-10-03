using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
    [SerializeField] float magnitud = 8, t = 0, magDash = 500;
    [SerializeField] float magAng = 450;
    [SerializeField] AudioClip idle;
    [SerializeField] AudioClip driving;
    AudioSource mAudio;
    Rigidbody mBody;
    // Start is called before the first frame update
    void Start()
    {
        mAudio = GetComponent<AudioSource>();
        mBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        //Desplazamiento del tanque
        Vector3 dirZ = transform.forward;
        float sentido = Input.GetAxis("Vertical");
        Vector3 velocidad = magnitud * dirZ * sentido;
        Vector3 distancia = velocidad * Time.deltaTime;
        transform.position = transform.position + distancia;
        //Rotacion del tanque
        Vector3 dirAng = new Vector3(0, 1, 0);
        float sAng = Input.GetAxis("Horizontal");
        Vector3 vAng = magAng * dirAng * sAng;
        Vector3 distAng = vAng * Time.deltaTime;
        transform.eulerAngles +=  distAng;

        if (sentido != 0 || sAng != 0)
        {
            mAudio.clip = driving;
            if (!mAudio.isPlaying) mAudio.Play();
        }
        else
        {
            mAudio.clip = idle;
            if (!mAudio.isPlaying) mAudio.Play();
        }
        //Dash del tanque con un contador para que no se pueda hacer todo el tiempo
        t += Time.deltaTime;
        if (t >= 7)
        {
            float sen = 1;
            Vector3 dash = transform.forward + transform.up;
            Vector3 force = magDash * dash * sen;

            if (Input.GetButtonDown("Jump"))
            {
                mBody.AddForce(force);
                t = 0;
            }
        }


    }
}
