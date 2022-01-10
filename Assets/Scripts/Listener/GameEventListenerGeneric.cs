using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameEventListenerGeneric : MonoBehaviour
{
    public GameEventGeneric gameEvent;
    public UnityEvent gameEventCallback;

    private void OnEnable()
    {
        gameEvent.AddListener(this);
    }

    private void OnDisable()
    {
        gameEvent.RemoveListener(this);
    }

    public void OnEventRaised()
    {
        gameEventCallback.Invoke();
    }
}

