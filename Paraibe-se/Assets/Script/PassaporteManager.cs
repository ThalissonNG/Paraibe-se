using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaporteManager : MonoBehaviour
{
    [SerializeField] private int ValorMuseuArtePopular;
    [SerializeField] private int ValorMonumentoFarra;
    [SerializeField] private int ValorMuseuDeAlgodao;
    [SerializeField] private int ValorParqueDoPovo;
    [SerializeField] private int ValorCatedral;
    [SerializeField] private int ValorBarDoCuscuz;
    [SerializeField] private int ValorMuseuDigital;
    [SerializeField] private int ValorParqueDaCrianca;
    [SerializeField] private int ValorPioneiros;

    [SerializeField] private GameObject CarimboMuseuDeArte;
    [SerializeField] private GameObject CarimboMonumentoFarra;
    [SerializeField] private GameObject CarimboMuseuDeAlgodao;
    [SerializeField] private GameObject CarimboParqueDoPovo;
    [SerializeField] private GameObject CarimboCatedral;
    [SerializeField] private GameObject CarimboBarDoCuscuz;
    [SerializeField] private GameObject CarimboMuseuDigital;
    [SerializeField] private GameObject CarimboParqueDaCrianca;
    [SerializeField] private GameObject CarimboPioneiros;
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

    void Update()
    {
        if(ValorMuseuArtePopular == 1)
        {
            CarimboMuseuDeArte.SetActive(true);
        }
        if (ValorBarDoCuscuz == 1)
        {
            CarimboBarDoCuscuz.SetActive(true);      
        }
        if (ValorCatedral == 1)
        {
            CarimboCatedral.SetActive(true);
        }
        if (ValorMonumentoFarra == 1)
        {
            CarimboMonumentoFarra.SetActive(true);
        }
        if (ValorMuseuDigital == 1)
        {
            CarimboMuseuDigital.SetActive(true);
        }
        if (ValorMuseuDeAlgodao == 1)
        {
            CarimboMuseuDeAlgodao.SetActive(true);
        }
        if (ValorParqueDaCrianca == 1)
        {
            CarimboParqueDaCrianca.SetActive(true);
        }
        if (ValorParqueDoPovo == 1)
        {
            CarimboParqueDoPovo.SetActive(true);
        }
        if (ValorPioneiros == 1)
        {
            CarimboParqueDoPovo.SetActive(true);
        }
    }
}
