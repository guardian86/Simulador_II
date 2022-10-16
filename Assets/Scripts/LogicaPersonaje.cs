using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    private int inicialPosicion = 0;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        //rotar el personaje
        transform.Rotate(inicialPosicion, x * Time.deltaTime * velocidadRotacion, inicialPosicion);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
