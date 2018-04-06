using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CloseOnBlur2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
    bool mouseHover;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseHover = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseHover = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0) && !mouseHover)
        {
            gameObject.SetActive(false);
        }
    }
}
