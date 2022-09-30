using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    [SerializeField] private Texture2D cursorStandard;
    [SerializeField] private LayerMask groundMask;

    [SerializeField] private PlayerMove playerMove;

    void Start()
    {
        Cursor.SetCursor(cursorStandard, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, groundMask))
            {
                playerMove.SetPlayerMove(true, hit.point);
            }
        }
    }

}
