using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
   
    public float speed = 5f;
    public float jumpForce = 5f;
    public bool isJumping = false;

    private Rigidbody rb;
    private Animator animator;

    public float movimientoLados = 0;

    public float LimitedePistaPositivo = 3;
    public float LimitedePistanegativo = -3;

    public GiroMundo PararMundo;


    public BoxCollider Choque;
    public BoxCollider Agachar;
    public BoxCollider Pies;

    

    public bool botonA = true;
    public bool PuedeAgachar = true;
    

    private bool BotonUnavez = false;

    public bool Agachaynosalta = true;


    public LosPies lospies;

    public float MovMuroInvisible = 5f;

   

    private void Start()
    {
        PararMundo = FindObjectOfType<GiroMundo>();
        lospies = FindObjectOfType<LosPies>();

        

        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        

        
        
    }

    private void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, 0);

        transform.position = transform.position + movementDirection * speed * Time.deltaTime;

        
        if (transform.position.x > LimitedePistaPositivo)
        {
            transform.position = new Vector3(LimitedePistaPositivo, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < LimitedePistanegativo)
        {
            transform.position = new Vector3(LimitedePistanegativo, transform.position.y, transform.position.z);
        }
        

        animator.SetBool("Teclas", true);
        animator.SetBool("SeAgacha", false);



        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            if (Agachaynosalta == true)
            {
                animator.SetBool("Teclas", false);
                animator.Play("Jump");
                PuedeAgachar = false;

                rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
                isJumping = true;
                
            }
        }

     
        if(Input.GetKeyDown(KeyCode.S) && PuedeAgachar == true)
        {
            if(!BotonUnavez)
            {
               Agachaynosalta = false;
               PararMundo.speedRot = 15;
               animator.Play("Agacharse");
               animator.SetBool("SeAgacha", true);
               Choque.enabled = false;
               Agachar.enabled = true;
               StartCoroutine("SeAgachaColision");
               BotonUnavez = true;
               


            }

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            BotonUnavez = false;
        }

    }

    IEnumerator SeAgachaColision()
    {
        yield return new WaitForSeconds(1f);
        Choque.enabled = true;
        Agachar.enabled = false;
        animator.SetBool("SeAgacha", false);
        PararMundo.speedRot = 10;
        animator.SetBool("Parado", false);
        speed = 5f;
        Agachaynosalta = true;

    }
    





    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tierra"))
        {
            
                isJumping = false;
           
        }
       
    }
    public void OnCollisionStay(Collision collision)
    {
        if (lospies.SigueCorriendo == false)
        {
            if (collision.collider.CompareTag("Untagged"))
            {
                PararMundo.speedRot = 0;

                animator.SetBool("Parado", true);
                animator.SetBool("AndarLado", false);
                PuedeAgachar = false;





                if (Input.GetKey(KeyCode.A) && botonA == true)
                {

                    botonA = true;
                    animator.Play("AndarIzquierda");
                    animator.SetBool("AndarLado", true);
                    animator.SetBool("Teclas", false);
                    speed = 2f;
                    return;

                }
                if (Input.GetKey(KeyCode.D))
                {

                    botonA = false;
                    animator.Play("AndarDerecha");
                    animator.SetBool("AndarLado", true);
                    animator.SetBool("Teclas", false);
                    speed = 2f;
                    return;

                }
                else if (!Input.GetKey(KeyCode.D))
                {
                    botonA = true;
                }


            }

            else if (isJumping == false)
            {
                PuedeAgachar = true;
            }

        }
        

        if (collision.collider.CompareTag("Agachate"))
        {
                PararMundo.speedRot = 0;

                animator.SetBool("Parado", true);
                animator.SetBool("AndarLado", false);
                PuedeAgachar = true;





                if (Input.GetKey(KeyCode.A) && botonA == true)
                {

                    botonA = true;
                    animator.Play("AndarIzquierda");
                    animator.SetBool("AndarLado", true);
                    animator.SetBool("Teclas", false);
                    speed = 2f;
                    return;

                }
                if (Input.GetKey(KeyCode.D))
                {

                    botonA = false;
                    animator.Play("AndarDerecha");
                    animator.SetBool("AndarLado", true);
                    animator.SetBool("Teclas", false);
                    speed = 2f;
                    return;

                }
                else if (!Input.GetKey(KeyCode.D))
                {
                    botonA = true;
                }


        }
        





        

    }
    public void OnCollisionExit(Collision collision)
    {

        if (collision.collider.CompareTag("Untagged"))
        {
            PararMundo.speedRot = 10;
            animator.SetBool("Parado", false);
            animator.SetBool("Teclas", false);
            animator.SetBool("AndarLado", false);

            speed = 5f;

        }

        


    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Collider>().CompareTag("Tropiezo"))
        {
            
            PararMundo.speedRot = 5;

            animator.SetBool("Tropieza", true);



        }

        if (other.CompareTag("MuroInvisible"))
        {

            Vector3 forwardDirection = transform.forward;


            Vector3 targetPosition = transform.position + forwardDirection;


            transform.position = Vector3.MoveTowards(transform.position, targetPosition, MovMuroInvisible * Time.deltaTime);
        }
        else if (!other.CompareTag("MuroInvisible"))
        {

            
        }
        if (other.GetComponent<Collider>().CompareTag("Frenar"))
        {

            PararMundo.speedRot = 5;

        }

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Tropiezo"))
        {
            StartCoroutine("TiempoTropiezo");
            animator.SetBool("Tropieza", false);
            rb.mass = 10;

        }
        if (other.GetComponent<Collider>().CompareTag("Frenar"))
        {

            PararMundo.speedRot = 10;

        }
    }
    IEnumerator TiempoTropiezo()
    {
        yield return new WaitForSeconds(1f);
        PararMundo.speedRot = 10;
        rb.mass = 1;

    }

}


