using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosaico : MonoBehaviour
{
    [SerializeField] private GameObject[] mosaico = new GameObject[9];
    public int ValorDoMosaico = -1;

    [SerializeField] private int ValorMuseuArtePopular;
    [SerializeField] private int ValorMonumentoFarra;
    [SerializeField] private int ValorMuseuDeAlgodao;
    [SerializeField] private int ValorParqueDoPovo;
    [SerializeField] private int ValorCatedral;
    [SerializeField] private int ValorBarDoCuscuz;
    [SerializeField] private int ValorMuseuDigital;
    [SerializeField] private int ValorParqueDaCrianca;
    [SerializeField] private int ValorPioneiros;

    void Start()
    {
        ValorMuseuArtePopular = PlayerPrefs.GetInt("museudeartepopular");
        ValorBarDoCuscuz = PlayerPrefs.GetInt("bardocuscuz");
        ValorCatedral = PlayerPrefs.GetInt("catedral");
        ValorMonumentoFarra = PlayerPrefs.GetInt("farradabudega");
        ValorMuseuDigital = PlayerPrefs.GetInt("museudigital");
        ValorMuseuDeAlgodao = PlayerPrefs.GetInt("museudoalgodao");
        ValorParqueDaCrianca = PlayerPrefs.GetInt("parquedacrianca");
        ValorParqueDoPovo = PlayerPrefs.GetInt("parquedopovo");
        ValorPioneiros = PlayerPrefs.GetInt("pioneiros");
    }
    // Update is called once per frame
    void Update()
    {
        if (ValorMuseuArtePopular == 1)
        {
            mosaico[0].SetActive(true);
        }
        if (ValorBarDoCuscuz == 1)
        {
            mosaico[1].SetActive(true);
        }
        if (ValorCatedral == 1)
        {
            mosaico[2].SetActive(true);
        }
        if (ValorMonumentoFarra == 1)
        {
            mosaico[3].SetActive(true);
        }
        if (ValorMuseuDigital == 1)
        {
            mosaico[4].SetActive(true);
        }
        if (ValorMuseuDeAlgodao == 1)
        {
            mosaico[5].SetActive(true);
        }
        if (ValorParqueDaCrianca == 1)
        {
            mosaico[6].SetActive(true);
        }
        if (ValorParqueDoPovo == 1)
        {
            mosaico[7].SetActive(true);
        }
        if (ValorPioneiros == 1)
        {
            mosaico[8].SetActive(true);
        }



        //if (Input.GetMouseButtonDown(0)) 
        //{
        //    Debug.Log("apertoui");
        //    ValorDoMosaico++;
        //}
        //if (ValorDoMosaico > 9)
        //{
        //    ValorDoMosaico = 10; 
        //}
        //else
        //{
        //    for (int i = 0; i < mosaico.Length; i++)
        //    {
        //        if (i == ValorDoMosaico)
        //        {
        //            mosaico[i].SetActive(true);
        //        }
        //    }
        //}
    }

}
