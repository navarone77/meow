using UnityEngine;
using UnityEngine.EventSystems;

public class PointerDetection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Entered Object" + eventData.pointerEnter.name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Left Object");
    }
}
