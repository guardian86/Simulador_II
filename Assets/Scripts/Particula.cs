using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particula : MonoBehaviour
{
    public ParticleSystem particula;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(particula, transform.position, particula.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }







}
