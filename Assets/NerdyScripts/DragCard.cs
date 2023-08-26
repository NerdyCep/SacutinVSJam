using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragCard : MonoBehaviour
{
    
    [SerializeField] private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    public void Take()
    {
        
    }

    public void Hold()
    {
       var position =  Input.mousePosition;
        var worldPosition = _mainCamera.ScreenToWorldPoint(position);
        transform.position = (Vector2)worldPosition;
    }

    public void Releas(PointerEventData eventData)
    {
        // Логика, которая может быть выполнена при завершении перетаскивания
    }
}
