using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour

{
    private int i;
    public Renderer rend;
    private int random;



    void Start()
    {
        i=3;
        random = Random.Range(200,251);
    }


    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.CompareTag("Red") && i==100) {
            gameObject.SetActive(false);
        }
        if (gameObject.CompareTag("Blue") && i==random) {
            rend.enabled = false;
        }

    }
}
