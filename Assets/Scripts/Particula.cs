using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Particula : MonoBehaviour
{
    public GameObject objeto;
    public ParticleSystem particula;
    public List<ParticleCollisionEvent> collisionEvents;

    // Start is called before the first frame update
    void Start()
    {
        particula = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
        Instantiate(particula, transform.position, particula.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        OnParticleCollision(objeto);
    }

    void OnParticleCollision(GameObject other)
    {
        int numCollisionEvents = particula.GetCollisionEvents(other, collisionEvents);

        Rigidbody rb = other.GetComponent<Rigidbody>();
        int i = 0;

        Debug.Log("Colision de la particula contra un objeto ");

        while (i < numCollisionEvents)
        {
            if (rb)
            {
                Vector3 pos = collisionEvents[i].intersection;
                Vector3 force = collisionEvents[i].velocity * 10;
                rb.AddForce(force);
            }

            i++;
        }
    }



    //float Choose(float[] probs)
    //{

    //    float total = 0;

    //    foreach (float elem in probs)
    //    {
    //        total += elem;
    //    }

    //    float randomPoint = Random.value * total;

    //    for (int i = 0; i < probs.Length; i++)
    //    {
    //        if (randomPoint < probs[i])
    //        {
    //            return i;
    //        }
    //        else
    //        {
    //            randomPoint -= probs[i];
    //        }
    //    }
    //    return probs.Length - 1;
    //}





}
