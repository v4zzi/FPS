using UnityEngine;
using DG.Tweening;
public class DoorController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameEvents.instance.onDoorTriggerEnter += OpenDoor;
        GameEvents.instance.onDoorTriggerExit += CloseDoor;
    }

    void OpenDoor ()
    {
        //transform.Translate(new Vector3(0, 6.696565f, 0));
        transform.DOMoveY(9.696565f, 2);
    }

    void CloseDoor ()
    {
        //transform.Translate(new Vector3(0, -6.696565f, 0));
        transform.DOMoveY(3.696565f, 2);
    }

}
