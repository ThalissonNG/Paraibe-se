using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosaico : MonoBehaviour
{
    [SerializeField] private GameObject[] mosaico = new GameObject[9];
    [SerializeField] private int[] valores = new int[9];

    void Start()
    {
        valores[0] = PlayerPrefs.GetInt("museudeartepopular");
        valores[1] = PlayerPrefs.GetInt("bardocuscuz");
        valores[2] = PlayerPrefs.GetInt("catedral");
        valores[3] = PlayerPrefs.GetInt("farradabudega");
        valores[4] = PlayerPrefs.GetInt("museudigital");
        valores[5] = PlayerPrefs.GetInt("museudoalgodao");
        valores[6] = PlayerPrefs.GetInt("parquedacrianca");
        valores[7] = PlayerPrefs.GetInt("parquedopovo");
        valores[8] = PlayerPrefs.GetInt("pioneiros");
    }
    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < mosaico.Length; i++)
        {
            if (valores[i] == 1)
            {
                mosaico[i].SetActive(true);
            }
        }
    }

}
