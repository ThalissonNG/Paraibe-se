using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaporteManager : MonoBehaviour
{
    [SerializeField] private int ValorMuseuArtePopular;

    public GameObject Carimbo1;
    void Start()
    {
        ValorMuseuArtePopular = PlayerPrefs.GetInt("museudeartepopular");
    }

    // Update is called once per frame
    void Update()
    {
        if(ValorMuseuArtePopular == 1)
        {
            Carimbo1.SetActive(true);
        }
    }
}
