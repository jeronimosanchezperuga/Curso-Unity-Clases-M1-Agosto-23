using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class botonScript : MonoBehaviour
{
    public GameObject botonNormal;
    public GameObject botonPresionado;
    public GameObject coheteFalso;
    public GameObject coheteVerdadero;

    // Start is called before the first frame update
    void Start()
    {
        botonNormal.SetActive(true);
        botonPresionado.SetActive(false);
        coheteFalso.SetActive(true);
        coheteVerdadero.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        botonNormal.SetActive(false);
        botonPresionado.SetActive(true);
        coheteFalso.SetActive(false);
        coheteVerdadero.SetActive(true);
    }
    void OnMouseUp()
    {
        botonNormal.SetActive(true);
        botonPresionado.SetActive(false);
    }
}
