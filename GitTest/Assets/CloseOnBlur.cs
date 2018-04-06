using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOnBlur : MonoBehaviour {
    bool mouseHover;

    //Simple check wether or not the mouse cursor is over the element
    public void SetHover(bool hover)
    {
        mouseHover = hover;
    }

    //If the left(0)mousebutton is clicked and the cursor is not over the element. Close the element. 
    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && !mouseHover)
        {
            gameObject.SetActive(false);
        }
    }
}
