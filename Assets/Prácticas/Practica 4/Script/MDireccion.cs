using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDireccion : MonoBehaviour
{
    float velocidad;
        Transform objetivo;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 0.5f;
        objetivo = GameObject.Find("tesoro").GetComponent<Transform>();
        Debug.Log(objetivo.name);
        Vector3 dir = objetivo.position - this.transform.position;
        Debug.Log(dir.magnitude);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = objetivo.position - this.transform.position;
        if(dir.magnitude > 1)
        {
            this.transform.Translate(dir.normalized * velocidad, Space.World);
        }
        
    }
}
