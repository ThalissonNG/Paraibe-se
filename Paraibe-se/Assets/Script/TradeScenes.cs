using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TradeScenes : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void CampinaGrande()
    {
        SceneManager.LoadScene(1);
    }
    public void Passaporte()
    {
        SceneManager.LoadScene(2);
    }
    public void Conta()
    {
        SceneManager.LoadScene(3);
    }
    public void Mosaico()
    {
        SceneManager.LoadScene(4);
    }
}
