using UnityEngine;

public class triggerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameEvents.instance.OpenTriggerDoor();
    }

    private void OnTriggerExit(Collider other)
    {
        GameEvents.instance.CloseTriggerDoor();
    }

}
