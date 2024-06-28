using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ParqueDaCrianca : MonoBehaviour
{
    [SerializeField] private int ParqueDaCriancaINT = 0;

    private ObserverBehaviour mObserverBehaviour;
    void Awake()
    {
        ObserverBehaviour mObserverBehaviour = GetComponent<ObserverBehaviour>();

        if (mObserverBehaviour != null)
            mObserverBehaviour.OnTargetStatusChanged += OnStatusChanged;
    }
    void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        Debug.LogFormat("TargetName: {0}, Status is: {1}, StatusInfo is: {2}", behaviour.TargetName, status.Status, status.StatusInfo);
    }

    public void TargetInScene()
    {
        ParqueDaCriancaINT = 1;
        PlayerPrefs.SetInt("parquedacrianca", ParqueDaCriancaINT);
        Debug.Log(ParqueDaCriancaINT);
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3);
        GameObject.Destroy(gameObject);
    }
}
