using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Object1 : MonoBehaviour
{
    [SerializeField] private int MuseuDeArtePopular = 0;

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
        MuseuDeArtePopular = 1;
        PlayerPrefs.SetInt("museudeartepopular", MuseuDeArtePopular);
        Debug.Log(MuseuDeArtePopular);
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3);
        GameObject.Destroy(gameObject);
    }
}
