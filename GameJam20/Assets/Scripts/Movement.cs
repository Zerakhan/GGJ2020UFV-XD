using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 targetPosition;
    bool hide = false;
    public GameObject esconder;
    public GameObject escondite1;
    public GameObject escondite2;
    public GameObject escondite3;
    public GameObject escondite4;
    public Vector3 escondido;
    public bool audifono;
    // Update is called once per frame
    void Update()
    {
        if (hide) Hide();
        else Move();
    }
    void Move()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            /*if(targetPosition.x == escondite1.transform.position.x && audifono)
            {
                esconder.SetActive(true);
                escondido = escondite1.transform.position;
            }
            else if (targetPosition.x == escondite2.transform.position.x && audifono)
            {
                esconder.SetActive(true);
                escondido = escondite2.transform.position;
            }
            else if (targetPosition.x == escondite3.transform.position.x && audifono)
            {
                esconder.SetActive(true);
                escondido = escondite3.transform.position;
            }
            else if (targetPosition.x == escondite4.transform.position.x && audifono)
            {
                esconder.SetActive(true);
                escondido = escondite4.transform.position;
            }*/
        }
        targetPosition.y = 0;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
    }
    public void Hidden()
    {
        audifono = false;
    }
    void Hide()
    {

    }
}