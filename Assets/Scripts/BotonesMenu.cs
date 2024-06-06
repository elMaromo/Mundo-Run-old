using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class BotonesMenu : MonoBehaviour
{

    public GameObject irSalir;
    public GameObject irMenuPrincipal;


    public Animator aniLogo;
    public Animator aniNuevaPartida;
    public Animator aniSalir;
    
    public bool activosalir = true;
    public bool desactivarLoop = false;

    public VideoPlayer videoPlayer;
    public Button botonToggleLoop;
    public AudioSource sonidoBoton;
    void Start()
    {
        // Asigna la función ToggleLoop al evento onClick del botón
        botonToggleLoop.onClick.AddListener(ToggleLoop);
    }


    public void NuevaPartida()
    {
        sonidoBoton.Play();
        aniLogo.Play("animacionLogo");
        aniNuevaPartida.Play("animacionNuevaPartida");
        aniSalir.Play("animacionSalir");
        sonidoBoton.Play();

        activosalir = false;
        desactivarLoop = true;

        StartCoroutine("pedirDesactivarLoop");

    }
    IEnumerator pedirDesactivarLoop()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("intro");



    }

    void ToggleLoop()
    {
        if (desactivarLoop == true)
        {
            videoPlayer.isLooping = !videoPlayer.isLooping;
        }
    }
        

    public void SalirDelJuego()
    {
        if (activosalir == true)
        {

            irMenuPrincipal.SetActive(false);
            irSalir.SetActive(true);
            
        }
        sonidoBoton.Play();
    }
    public void SalirSi()
    {

        Application.Quit();
        sonidoBoton.Play();

    }
    public void SalirNo()
    {
        sonidoBoton.Play();
        irMenuPrincipal.SetActive(true);
        irSalir.SetActive(false);



    }

}
