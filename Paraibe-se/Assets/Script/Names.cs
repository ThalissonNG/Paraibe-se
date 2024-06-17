using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Names : MonoBehaviour
{
    public string NomeUsuario;
    public string NomeCidade;
    public string NomeEstado;

    public TMP_InputField _InputFieldUsuario;
    public TMP_InputField _InputFieldCidade;
    public TMP_InputField _InputFieldEstado;

    void Start()
    {
        // Carrega os dados de PlayerPrefs quando o script inicia
        NomeUsuario = PlayerPrefs.GetString("_NomeUsuario", "");
        NomeCidade = PlayerPrefs.GetString("_NomeCidade", "");
        NomeEstado = PlayerPrefs.GetString("_NomeEstado", "");

        // Define os valores carregados nos InputFields
        _InputFieldUsuario.text = NomeUsuario;
        _InputFieldCidade.text = NomeCidade;
        _InputFieldEstado.text = NomeEstado;

        // Adiciona listeners para os campos de entrada
        _InputFieldUsuario.onValueChanged.AddListener(OnUsuarioChanged);
        _InputFieldCidade.onValueChanged.AddListener(OnCidadeChanged);
        _InputFieldEstado.onValueChanged.AddListener(OnEstadoChanged);
    }
    void OnDisable()
    {
        // Salva os dados em PlayerPrefs quando o script é desativado
        PlayerPrefs.SetString("_NomeUsuario", NomeUsuario);
        PlayerPrefs.SetString("_NomeCidade", NomeCidade);
        PlayerPrefs.SetString("_NomeEstado", NomeEstado);
        PlayerPrefs.Save();
    }

    public void OnUsuarioChanged(string newUser)
    {
        NomeUsuario = newUser;
    }

    public void OnCidadeChanged(string newCity)
    {
        NomeCidade = newCity;
    }

    public void OnEstadoChanged(string newState)
    {
        NomeEstado = newState;
    }
}
