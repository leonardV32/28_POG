using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "EventsSO/GameEvent")]
public class GameEventGeneric : ScriptableObject
{
    private List<GameEventListenerGeneric> listeners = new List<GameEventListenerGeneric>();

    public void AddListener(GameEventListenerGeneric newListener)
    {
        listeners.Add(newListener);
    }

    public void RemoveListener(GameEventListenerGeneric listenerToRemove)
    {
        listeners.Remove(listenerToRemove);
    }

    public void Raise()
    {
        foreach (var eventListener in listeners)
        {
            eventListener.OnEventRaised();
        }
    }
}
