using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarkManager : MonoBehaviour
{
    public int donusHizi;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * donusHizi * Time.deltaTime);
    }
}
