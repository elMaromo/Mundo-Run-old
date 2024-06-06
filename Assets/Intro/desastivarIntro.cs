using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class desastivarIntro : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Canvas canvas;

   
    public GameObject imagenIntro;
    public GameObject fondoNegro;

    public GameObject slidersalir;
    


    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        // Suscribirse al evento de finalización del video
        videoPlayer.loopPointReached += OnVideoEnd;

    }

    void OnVideoEnd(VideoPlayer vp)
    {
        
        
        // Desactivar el Canvas cuando el video haya terminado
        Destroy(imagenIntro);
        
        canvas.enabled = false;

        StartCoroutine(Carga());

    }
 

    IEnumerator Carga()
    {
        //yield return new WaitForSeconds(0.01f);
        fondoNegro.SetActive(true);

        slidersalir.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        
        AsyncOperation operacionCarga = SceneManager.LoadSceneAsync(2);

       
    }
   

}
