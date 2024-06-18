using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ParqueDoPovo : MonoBehaviour
{
    [SerializeField] private int ParqueDoPovoINT = 0;

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
        ParqueDoPovoINT = 1;
        PlayerPrefs.SetInt("parquedopovo", ParqueDoPovoINT);
        Debug.Log(ParqueDoPovoINT);
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3);
        GameObject.Destroy(gameObject);
    }
}
