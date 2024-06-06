using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Botones : MonoBehaviour
{
    public tiempo activarTiempo;

    public GameObject tutorial;
    public GameObject MusicaPrincipal;

    public GameObject detectorTutorial;

    public GameObject mapa;

    public Pause pulsarPause;

    public GameObject Pausatutorial;
    public GameObject opcionesPausa;

    public GameObject cartelReiniciar;
    public GameObject irMenuSalir;

    public GameObject findelTiempo;
    public GameObject findelTiemporeiniciar;
    public GameObject findelTiemposalir;

    public GameObject personajeInicio;
    public GameObject personajePrincipal;

    public AudioSource sonidosPasos;
    public float fadeOutTime = 10.0f;

    public AudioSource sonidoBoton;

    public void CerrarTutorial()
    {
        sonidoBoton.Play();
        MusicaPrincipal.SetActive(true);
        pulsarPause.puedePulsar = true;
        activarTiempo.enMarcha = true;
        Time.timeScale = 1;
        tutorial.SetActive(false);
        Destroy(detectorTutorial);

        mapa.SetActive(true);

        personajePrincipal.SetActive(true);
        Destroy(personajeInicio);

        sonidosPasos.enabled = true;

        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        // Guarda el volumen inicial
        float startVolume = sonidosPasos.volume;

        // Calcula el incremento por frame
        float fadeSpeed = startVolume / fadeOutTime;

        // Realiza el desvanecimiento
        while (sonidosPasos.volume > 0)
        {
            sonidosPasos.volume -= fadeSpeed * Time.deltaTime;
            yield return null;
        }

        // Asegúrate de que el volumen sea cero al final
        sonidosPasos.volume = 0;
    }
    public void AbrirTutorial()
    {
        sonidoBoton.Play();
        pulsarPause.puedePulsar = false;
        
        
        Pausatutorial.SetActive(true);
        opcionesPausa.SetActive(false);
        

        

    }
    public void volverPausa()
    {

        pulsarPause.puedePulsar = true;


        Pausatutorial.SetActive(false);
        opcionesPausa.SetActive(true);
        sonidoBoton.Play();



    }
    public void botonReiniciar()
    {
        sonidoBoton.Play();
        pulsarPause.puedePulsar = false;


        cartelReiniciar.SetActive(true);
        opcionesPausa.SetActive(false);




    }
    public void ReiniciarSi()
    {
        Time.timeScale = 1;
        pulsarPause.puedePulsar = true;
        SceneManager.LoadScene("intro");
        sonidoBoton.Play();




    }
    public void ReiniciarNo()
    {

        pulsarPause.puedePulsar = true;


        cartelReiniciar.SetActive(false);
        opcionesPausa.SetActive(true);
        sonidoBoton.Play();



    }
    public void menuSalir()
    {

        pulsarPause.puedePulsar = false;


        irMenuSalir.SetActive(true);
        opcionesPausa.SetActive(false);
        sonidoBoton.Play();



    }

   
    public void MenuPrincipalNo()
    {

        pulsarPause.puedePulsar = true;


        irMenuSalir.SetActive(false);
        opcionesPausa.SetActive(true);
        sonidoBoton.Play();



    }
    public void SalirDelJuego()
    {

        Application.Quit();
        sonidoBoton.Play();



    }

    public void FindeltiempobotonReiniciar()
    {

        //pulsarPause.puedePulsar = false;

        sonidoBoton.Play();
        findelTiemporeiniciar.SetActive(true);
        findelTiempo.SetActive(false);




    }
    public void FindeltiempoReiniciarSi()
    {
        Time.timeScale = 1;
        //pulsarPause.puedePulsar = true;
        SceneManager.LoadScene("intro");
        sonidoBoton.Play();




    }
    public void FindeltiempoReiniciarNo()
    {



        sonidoBoton.Play();
        findelTiemporeiniciar.SetActive(false);
        findelTiempo.SetActive(true);




    }

    public void Findeltiempobotonsalir()
    {

        //pulsarPause.puedePulsar = false;

        sonidoBoton.Play();
        findelTiemposalir.SetActive(true);
        findelTiempo.SetActive(false);




    }
    public void FindeltiemposalirSi()
    {
        Application.Quit();
        sonidoBoton.Play();




    }
    public void FindeltiemposalirNo()
    {



        sonidoBoton.Play();
        findelTiemposalir.SetActive(false);
        findelTiempo.SetActive(true);




    }


}
