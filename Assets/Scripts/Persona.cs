using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Persona : MonoBehaviour, IParticula
{
    public Transform trans;
    public GameObject prefab;
    private float deletePersona = 3.0f;
    private bool deleteClon = false;

 

    // Start is called before the first frame update
    //[System.Obsolete]
    void Start()
    {
        lanzarParticula();

        //Instantiate(gameObject, transform.position, transform.rotation);
        //Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Application.Quit();
            //Debug.Log("Escape pressed!");
            //realizar el random para generar la persona con covid o sin covid 
            switch (Random.Range(0,3))
            {
                case 0:
                    Instantiate(prefab, transform.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(prefab, transform.position, Quaternion.identity);
                    break ;
                    case 2:
                    Instantiate(prefab, transform.position, Quaternion.identity);
                    break;
                default:
                    break;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Application.Quit();
            //Debug.Log("Escape pressed!");
            var clones = GameObject.FindGameObjectsWithTag("tagPerson");
            if (clones.Any())
            {
                foreach (var clone in clones)
                {
                    Destroy(clone);
                }
            }
         
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

    }

    public void lanzarParticula()
    {

        ParticleSystem ps = GetComponent<ParticleSystem>();

        if (this.GetComponent<ParticleSystem>() == null)
            return;

        this.GetComponent<ParticleSystem>().Stop();
        this.GetComponent<ParticleSystem>().randomSeed = (uint)Random.Range(0, 9999999);
        this.GetComponent<ParticleSystem>().Play();


        var em = ps.emission;

        em.enabled = true;

        em.SetBursts(
            new ParticleSystem.Burst[]{
                new ParticleSystem.Burst(2.0f, 100),
                new ParticleSystem.Burst(4.0f, 100)
            });


    }


}
