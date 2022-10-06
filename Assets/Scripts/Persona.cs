using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using Vector3 = System.Numerics.Vector3;

public class Persona : MonoBehaviour
{
    public GameObject persona;
    Vector3 position;
    Quaternion rotation;

    public CondicionEstadoFisico EstadoFisicoPersona { get; set; }
    public bool EnfermedadRespiratoriaBase { get; set; }
    public int RangoEdad { get; set; }
    public bool Sedentario { get; set; }
    public CondicionSocial EstadoSocial { get; set; }
    public string LugarTrabajoExpoCovid { get; set; }

    public void GenerarInstanciaPersonas()
    {
        Instantiate(persona);
    }

    

}

public enum CondicionEstadoFisico
{
    bueno,
    regular,
    malo
}

public enum CondicionSocial
{
    Alta,
    Media,
    Baja,
    Pobreza
}




