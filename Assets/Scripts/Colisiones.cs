using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Colisiones : MonoBehaviour
{
    public float time = 60f;
    public TextMeshProUGUI textTime;
    public TextMeshProUGUI text;

    public Rigidbody rab;
    public float punto;
    public TextMeshProUGUI point;

    // Start is called before the first frame update
    void Start()
    {
        time --;
        textTime.text = "Tiempo: " + time;

        rab = GetComponent<Rigidbody>();
        point.text = "Puntos: " + punto.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //if (time <= 0)
        {
            SceneManager.LoadScene("Escena2");
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            punto++;
            point.text = "Puntos: " + punto.ToString();
            Destroy(this.gameObject);
        }

    }
}
