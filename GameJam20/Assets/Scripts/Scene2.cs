using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2 : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Text_taquillas;
    public GameObject pasillo;
    public GameObject taquillaas;
    public bool follow_player;
    public bool yatengollave;
    public bool papelyboli;
    public Text box_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (follow_player)
        {
            Cam.transform.position = new Vector3(this.transform.position.x, 0, -10);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        if (collision.gameObject.name == "Taquillas")
        {
            //Debug.Log("taquillas");
            Text_taquillas.SetActive(true);
            
        }
        if (collision.gameObject.name == "Comedor" && papelyboli)
        {

        }
    }
    private void OnTriggerExit2D(Collider2D collision) 
    {
        Text_taquillas.SetActive(false);
    }
    public void Taquillas()
    {
        taquillaas.SetActive(false);
        //GameObject.Find("Player").GetComponent<Movement>().can_move=false;
        follow_player = false;
        if (Movement.can_move == false)
        {
            Movement.can_move = true;
        }
        Text_taquillas.SetActive(false);
        pasillo.SetActive(true);
        Cam.transform.position = new Vector3(0, 15, -10);
    }
    public void Pasillo()
    {
        taquillaas.SetActive(true);
        follow_player = true;
        //GameObject.Find("Player").GetComponent<Movement>().can_move=true();
        Cam.transform.position = new Vector3(0, 0, -10);
        pasillo.SetActive(false);
        Text_taquillas.SetActive(true);
        if (Movement.can_move == true)
        {
            Movement.can_move = false;
        }
    }
    
    public void butt1()
    {
        StartCoroutine(Fallo());
    }
    public void butt2()
    {
        if (yatengollave) StartCoroutine(aqui_nada());
        else StartCoroutine(Llave());
    }
    public void butt3()
    {
        if (yatengollave) StartCoroutine(abrir_taquilla());
        else StartCoroutine(no_abrir_taquilla());
    }

    IEnumerator Fallo()
    {
        box_text.text = "Esta taquilla está cerrada. No puedo abrirla.";
        //Debug.Log("corutina");
        yield return new WaitForSeconds(2f);
        //Debug.Log("ya he esperado");
        box_text.text = "";


        yield break;
        
    }
    IEnumerator Llave()
    {
        yatengollave = true;
        box_text.text = "He encontrado una llave";
        yield return new WaitForSeconds(2f);
        box_text.text = "";
        yield break;
    }
    IEnumerator aqui_nada()
    {
        box_text.text = "Aquí no hay nada";
        yield return new WaitForSeconds(2f);
        box_text.text = "";
        yield break;
    }
    IEnumerator abrir_taquilla()
    {
        box_text.text = "Cogeré mi papel y boli";
        papelyboli = true;
        taquillaas.SetActive(false);
        yield break;
    }
    IEnumerator no_abrir_taquilla()
    {
        
        box_text.text = "Necesito una llave para abrir esto";
        yield return new WaitForSeconds(2f);
        box_text.text = "";
        yield break;
    }




}
