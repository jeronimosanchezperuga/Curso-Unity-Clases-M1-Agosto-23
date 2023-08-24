using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScritpt : MonoBehaviour
{
    public float velocidadFinal = 0.1f;
    public float velocidadActual;
    public GameObject fuegoMotores;

    // Start is called before the first frame update
    void Start()
    {
        fuegoMotores.SetActive(false);
        Invoke("LanzarCohete",2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, velocidadActual, 0);
        AnimacionFuegoMotores();
    }

    void LanzarCohete()
    {
        velocidadActual = velocidadFinal;
        fuegoMotores.SetActive(true);
    }

    void AnimacionFuegoMotores()
    {
        fuegoMotores.transform.localScale = Vector3.one * Random.Range(0.5f,1.5f);
    }
}
