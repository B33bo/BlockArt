using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mtouch : MonoBehaviour
{
    public static cursorwin pointer;
    public Texture2D mouse, click, error, middleclick;
    public bool setter;

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

    void Start()
    {
        if (setter)
        {
            Cursor.SetCursor(mouse, Vector2.zero, CursorMode.Auto);

            pointer = this;
        }
    }

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            Cursor.SetCursor(click, Vector2.zero, CursorMode.Auto);
        }
    }
}
