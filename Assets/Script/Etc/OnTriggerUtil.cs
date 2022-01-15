using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerUtil : MonoBehaviour
{
    public string targetTag = "Player";
    public UnityEvent OnTriggerEnterEvent, OnTriggerExitEvent;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag(targetTag))
        {
            OnTriggerEnterEvent?.Invoke();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag(targetTag))
        {
            OnTriggerExitEvent?.Invoke();
        }
    }
}
