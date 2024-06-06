using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PararVideoFinal : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Canvas canvas;

    
    
    public GameObject ReinicioOsalir;
    public GameObject fondoNegro;




    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        // Suscribirse al evento de finalización del video
        videoPlayer.loopPointReached += OnVideoEnd;

    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Desactivar el Canvas cuando el video haya terminado
        ReinicioOsalir.SetActive(true);
        fondoNegro.SetActive(false);
        canvas.enabled = false;
       

    }
}
