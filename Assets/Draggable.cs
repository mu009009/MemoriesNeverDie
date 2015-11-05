using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public void OnbeingDrag(PointerEventData eventData){
		Debug.Log("OnBeingDrag");
	}

	public void OnDrag(PointerEventData eventData)
	{
		Debug.Log ("OnDrag");

		this.transform.position = eventData.position;
	}

	public void OnendDrag(PointerEventData evenData)
	{
		Debug.Log("OnEndDrag");
	}

}
