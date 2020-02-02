using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2 : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Text_taquillas;
    public GameObject Text_Comedor;
    public GameObject pasillo;
    public GameObject taquillaas;
    public GameObject Comedor_barrier;
    public GameObject Comedor_text;
    public GameObject comida_botones;
    public GameObject texto_mision;

    //botones comedor cutrísimo xxdd
    public GameObject bonto_quiero;
    public GameObject bonto_tomar;
    public GameObject bonto_esa;
    public GameObject bonto_sopa;
    public GameObject bonto_silla;
    public GameObject bonto_tenedor;



    public bool follow_player;
    public bool yatengollave;
    public bool papelyboli;
    public Text box_text;
    public Text Comida_error;
    public bool lock_camara;
    public bool cambio_cam;
    int SopaLetras;
    

    // Start is called before the first frame update
    void Start()
    {
        //Quiero tomar esa sopa
         SopaLetras = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (!lock_camara) return;
        if (this.transform.position.x < 0 || cambio_cam)
        {
            follow_player = false;
        }else if (this.transform.position.x>0 || !cambio_cam)
        {
            follow_player = true;
        }

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
        if (collision.gameObject.name == "Comida")
        {
            //Debug.Log("taquillas");
            Text_Comedor.SetActive(true);

        }


        if (collision.gameObject.name == "Comedor_text" && !papelyboli)
        {
            //Debug.Log("taquillas");
            StartCoroutine(busca_lapiz());
        }



    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Text_taquillas.SetActive(false);
        Text_Comedor.SetActive(false);
    }
    public void Taquillas()
    {
        cambio_cam = true;
        taquillaas.SetActive(false);
        //GameObject.Find("Player").GetComponent<Movement>().can_move=false;
        follow_player = false;
        if (Movement.can_move == false)
        {
            Movement.can_move = true;
        }
        texto_mision.SetActive(true);
        Text_taquillas.SetActive(false);
        pasillo.SetActive(true);
        Cam.transform.position = new Vector3(0, 15, -10);
    }
    public void Pasillo()
    {
        cambio_cam = false;
        taquillaas.SetActive(true);
        follow_player = true;
        //GameObject.Find("Player").GetComponent<Movement>().can_move=true();
        Cam.transform.position = new Vector3(0, 0, -10);
        pasillo.SetActive(false);
        texto_mision.SetActive(false);
        Text_taquillas.SetActive(true);
        if (Movement.can_move == true)
        {
            Movement.can_move = false;
        }
    }
    public void Comida()
    {
        Text_Comedor.SetActive(false);
        follow_player = false;
        Cam.transform.position = new Vector3(22, 15, -10);
        comida_botones.SetActive(true);
        if (Movement.can_move == false)
        {
            Movement.can_move = true;
        }
    }
    public void Comedor()
    {
        comida_botones.SetActive(false);
        follow_player = true;
        Cam.transform.position = new Vector3(22, 0, -10);

        Text_Comedor.SetActive(true);
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
        Comedor_barrier.SetActive(false);
        Comedor_text.SetActive(false);
        papelyboli = true;
        yield return new WaitForSeconds(2f);
        box_text.text = "";
        taquillaas.SetActive(false);
        lock_camara = true;
        yield break;
    }
    IEnumerator no_abrir_taquilla()
    {

        box_text.text = "Necesito una llave para abrir esto";
        yield return new WaitForSeconds(2f);
        box_text.text = "";
        yield break;
    }
    IEnumerator busca_lapiz()
    {
        // Movement.can_move = false;
        box_text.text = "Necesito mi lapiz y mi boli";
        yield return new WaitForSeconds(2f);
        box_text.text = "";
        // Movement.can_move = true;
        //Debug.Log("ya he esperado");
        yield break;

    }
    IEnumerator Error_comida()
    {
        Comida_error.text = "Uy creo que me he equivocado. Empezaré de nuevo";
        yield return new WaitForSeconds(2f);
        Comida_error.text = "";
        yield break;
    }
    IEnumerator comida_frase()
    {
        Comida_error.text = "Creo que me han entendido";
        yield return new WaitForSeconds(2f);
        Comida_error.text = "";
        yield break;
    }




    public void SopaLetrasB1()
    {
        
        Button butt1 = bonto_quiero.GetComponent<Button>();
        butt1.enabled=false;

        SopaLetras += 1;
        Debug.Log(SopaLetras);

        if (SopaLetras == 10)
        {
            StartCoroutine(comida_frase());
            Debug.Log("YEAH NOS LO HEMOS PACHAO");
        }
        if (SopaLetras > 10)
        {
            SopaLetras = 0;
            Debug.Log("Start again");
            StartCoroutine(Error_comida());

        }
    }
    public void SopaLetrasB2()
    {
        Button butt2 = bonto_tomar.GetComponent<Button>();
        butt2.enabled = false;
        SopaLetras += 2;
        Debug.Log(SopaLetras);
        if (SopaLetras == 10)
        {
            StartCoroutine(comida_frase());
            Debug.Log("YEAH NOS LO HEMOS PACHAO");
        }
        if (SopaLetras > 10)
        {
            SopaLetras = 0;
            Debug.Log("Start again");
            StartCoroutine(Error_comida());

        }
    }
    public void SopaLetrasB3()
    {
        Button butt3 = bonto_esa.GetComponent<Button>();
        butt3.enabled = false;
        SopaLetras += 3;

        Debug.Log(SopaLetras);
        if (SopaLetras == 10)
        {
            StartCoroutine(comida_frase());
            Debug.Log("YEAH NOS LO HEMOS PACHAO");
        }
        if (SopaLetras > 10)
        {
            SopaLetras = 0;
            Debug.Log("Start again");
            StartCoroutine(Error_comida());

        }
    }
    public void SopaLetrasB4()
    {
        Button butt4 = bonto_sopa.GetComponent<Button>();
        butt4.enabled = false;
        SopaLetras += 4;

        Debug.Log(SopaLetras);
        if (SopaLetras == 10)
        {
            StartCoroutine(comida_frase());
            Debug.Log("YEAH NOS LO HEMOS PACHAO");
        }
        if (SopaLetras > 10)
        {
            SopaLetras = 0;
            Debug.Log("Start again");
            StartCoroutine(Error_comida());

        }
    }
  public void SopaLetrasB5()
    {
        Button butt5 = bonto_tenedor.GetComponent<Button>();
        butt5.enabled = false;
        SopaLetras += 50;

        Debug.Log(SopaLetras);
      
        if (SopaLetras > 10)
        {
            SopaLetras = 0;
            Debug.Log("Start again");
            StartCoroutine(Error_comida());

        }
    }
   public void SopaLetrasB6()
    {
        Button butt6 = bonto_silla.GetComponent<Button>();
        butt6.enabled = false;
        SopaLetras += 60;
        if (SopaLetras > 10)
        {
            SopaLetras = 0;
            Debug.Log("Start again");
            StartCoroutine(Error_comida());

        }
        Debug.Log(SopaLetras);
    }


}
