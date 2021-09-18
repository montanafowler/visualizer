using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour {

    private Vector3 distanceToMove;
    private float zCoordinate;

    void OnMouseDown() {
        zCoordinate = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        distanceToMove = gameObject.transform.position - GetMouseAsWorldPointWithObjZCoordinate();
    }

    private Vector3 GetMouseAsWorldPointWithObjZCoordinate() {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = zCoordinate;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    void OnMouseDrag() {
        transform.position = GetMouseAsWorldPointWithObjZCoordinate() + distanceToMove;
    }
}

