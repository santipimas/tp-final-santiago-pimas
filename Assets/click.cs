using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject[] modelos;
    private int currentIndex = 0;
    void Start()
    {
        for (int i = 0; i < modelos.Length; i++)
        {
            if (i == 0)
            {
                modelos[i].SetActive(true);
            }
            else
            {
                modelos[i].SetActive(false);
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            modelos[currentIndex].SetActive(false);
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = modelos.Length - 1;
            }
            modelos[currentIndex].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            modelos[currentIndex].SetActive(false);
            currentIndex++;
            if (currentIndex >= modelos.Length)
            {
                currentIndex = 0;
            }
            modelos[currentIndex].SetActive(true);
        }
    }


}
