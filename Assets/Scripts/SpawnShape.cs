using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SpawnShape : MonoBehaviour
{
    public TMP_Dropdown shapeDropdown;
    public Scrollbar scaleScrollbar;
    public void Spawn()
    {
        int shapeIndex = shapeDropdown.value;
        float scale = scaleScrollbar.value;

        GameObject shape = null;

        switch (shapeIndex)
        {
            case 0:
                shape = GameObject.CreatePrimitive(PrimitiveType.Cube);
                shape.transform.localScale = new Vector3(scale, scale, scale);
                break;
            case 1:
                shape = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                shape.transform.localScale = new Vector3(scale, scale, scale);
                break;
            case 2:
                shape = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                shape.transform.localScale = new Vector3(scale, scale, scale);
                break;
            case 3:
                shape = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                shape.transform.localScale = new Vector3(scale, scale, scale);
                break;
            default:
                break;
        }

        shape.transform.position = new Vector3(0, 1, 0);
        Renderer renderer = shape.GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV();

        Rigidbody rb = shape.AddComponent<Rigidbody>();
        rb.useGravity = true;

        shape.AddComponent<XRGrabInteractable>();
    }
}
