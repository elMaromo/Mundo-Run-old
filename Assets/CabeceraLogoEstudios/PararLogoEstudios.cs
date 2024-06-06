using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class PararLogoEstudios : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Canvas canvas;


    public GameObject menuvideo;
    public GameObject LogoVideo;

    public Animator aniLogo;
    public Animator aniNuevaPartida;
    public Animator aniSalir;
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        // Suscribirse al evento de finalización del video
        videoPlayer.loopPointReached += OnVideoEnd;

    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Desactivar el Canvas cuando el video haya terminado

        menuvideo.SetActive(true);
        
        StartCoroutine("LogoYbotonesMenu");

    }
    IEnumerator LogoYbotonesMenu()
    {
        yield return new WaitForSeconds(1f);
        aniLogo.Play("ApareceAnimacionLogo");
        aniNuevaPartida.Play("ApareceAnimacionNuevaPartida");
        aniSalir.Play("ApareceAnimacionSalir");
        LogoVideo.SetActive(false);



    }


}
