using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject MapaCG;
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject VuforiaCam;
    [SerializeField] private string NomeUsuario;
    [SerializeField] private TextMeshProUGUI _NomeUsuario;


    [SerializeField] private bool ArTrue = true;
    #region Habilitar/Desabilitar Camera
    void Start()
    {
        MapaCG = GameObject.Find("MapaCG");
    }
    void Update()
    {
        NomeUsuario = PlayerPrefs.GetString("_NomeUsuario");
        _NomeUsuario.text = NomeUsuario;
        ActiveMap();
    }
    public void ButtonOnOffAr()
    {
        switch (ArTrue) 
        {
            case true:
                ArTrue = false; 
                break;
            case false:
                ArTrue = true;
                break;
        }
    }
    private void ActiveMap()
    {
        if (ArTrue)
        {
            MapaCG.SetActive(true);
        }
        else
        {
            MapaCG.SetActive(false);
        }
    }
    #endregion


}
