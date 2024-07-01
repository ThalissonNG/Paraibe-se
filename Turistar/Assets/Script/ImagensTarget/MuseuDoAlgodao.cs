using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MuseuDoAlgodao : MonoBehaviour
{
    [SerializeField] private int MuseuDoAlgodaoINT = 0;

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
        MuseuDoAlgodaoINT = 1;
        PlayerPrefs.SetInt("museudoalgodao", MuseuDoAlgodaoINT);
        Debug.Log(MuseuDoAlgodaoINT);
        StartCoroutine(DestroyObject());
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3);
        GameObject.Destroy(gameObject);
    }
}
