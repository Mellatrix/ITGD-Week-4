using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    private int randVal;
    public Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randVal = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && i == randVal)
        {
            gameObject.SetActive(false);
        }
        
    }
}
