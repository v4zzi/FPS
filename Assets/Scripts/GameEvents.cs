using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents instance;

    public event Action onDoorTriggerEnter;

    public event Action onDoorTriggerExit;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenTriggerDoor()
    {
        onDoorTriggerEnter();
    }

    public void CloseTriggerDoor()
    {
        onDoorTriggerExit();
    }
}
