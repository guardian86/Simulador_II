using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarPersonas : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Application.Quit();
            //Debug.Log("Escape pressed!");
            Destroy(prefab, 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
