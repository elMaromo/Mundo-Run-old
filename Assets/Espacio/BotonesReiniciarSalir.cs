using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesReiniciarSalir : MonoBehaviour
{
    public void Reiniciar()
    {
        
        SceneManager.LoadScene("intro");
      

    }
    public void SalirDelJuego()
    {

        Application.Quit();
        



    }
}
