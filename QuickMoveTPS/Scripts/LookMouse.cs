using UnityEngine;

public class LookMouse : MonoBehaviour
{
    [SerializeField] private Camera cam;

    void Update()
    {
        LookToMouse();
    }

    void LookToMouse()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(transform.position);
        Vector3 deltaPos = Input.mousePosition - screenPos;
        var final = Mathf.Atan2(deltaPos.x, deltaPos.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, final, 0));
    }
}