using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickActionEventHandler : MonoBehaviour
{
    [System.Serializable]
    public class InteractionEvent : UnityEvent { }
    [Space(10)]
    [SerializeField]
    private float ClickResponseDelay = 0;
    [Space(20)]
    [SerializeField]
    private InteractionEvent OnClick;

    private void Start()
    {
        Physics.queriesHitTriggers = true;
    }
    private bool IsOverUI()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        if (results.Count > 0)
        {
            return results.Any(t => t.gameObject.GetComponent<CanvasRenderer>());
        }

        return false;
    }
    void OnMouseDown()
    {
        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject == null && !IsOverUI())
        {
            if (ClickResponseDelay > 0)
            {
                if (waitAndInvokeEventsCor != null)
                {
                    StopCoroutine(waitAndInvokeEventsCor);
                }

                waitAndInvokeEventsCor = StartCoroutine(IWaitAndInvokeEvents());
            }
            else
            {
                OnClick.Invoke();
            }
        }

    }

    private Coroutine waitAndInvokeEventsCor;
    private IEnumerator IWaitAndInvokeEvents()
    {
        yield return new WaitForSeconds(ClickResponseDelay);
        waitAndInvokeEventsCor = null;
        OnClick.Invoke();
    }


}
