using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BarDoCuscuz : MonoBehaviour
{
    [SerializeField] private int BarDoCuscuzINT = 0;

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
        BarDoCuscuzINT = 1;
        PlayerPrefs.SetInt("bardocuscuz", BarDoCuscuzINT);
        Debug.Log(BarDoCuscuzINT);
        StartCoroutine(DestroyObject());
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3);
        GameObject.Destroy(gameObject);
    }
}
