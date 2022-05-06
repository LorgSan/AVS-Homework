using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTilt : MonoBehaviour
{
    float sensitivity = 10f;
    [SerializeField] Vector2 clampValue = new Vector2(1f, 1f);
    bool MouseClicked;
    //[SerializeField] float ClampValue;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseClicked = true;
        }
        if (MouseClicked == true)
        {
            MouseRotation();
        }
    }

    void MouseRotation()
    {
        float xMove = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        float yMove = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;
      
        transform.Translate(xMove,0f, 0f);
        transform.Translate(0f, yMove, 0f);
        // initially, the temporary vector should equal the player's position
        Vector3 clampedPosition = transform.position;
        // Now we can manipulte it to clamp the y element
        //clampedPosition.x = Mathf.Clamp(transform.position.x, -2.1f, 2.1f);
        //clampedPosition.y= Mathf.Clamp(transform.position.y, -2.1f, 2.1f);
        clampedPosition.x = Mathf.Clamp(transform.position.x, -clampValue.x, clampValue.x);
        clampedPosition.y= Mathf.Clamp(transform.position.y, -clampValue.y, clampValue.y);
        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;
    }
}
