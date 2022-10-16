using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    public Transform trans;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
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
            Instantiate(prefab, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Application.Quit();
            //Debug.Log("Escape pressed!");
            Destroy(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

    }




}
