using UnityEngine;
using UnityEngine.InputSystem;

public class UITogle : MonoBehaviour
{
    public InputActionProperty toggleUI;
    public GameObject targetUI;

    private void OnEnable()
    {
        toggleUI.action.Enable();
    }

    private void OnDisable()
    {
        toggleUI.action.Disable();
    }

    private void Update()
    {
        if (toggleUI.action.WasPressedThisFrame())
        {
            targetUI.SetActive(!targetUI.activeSelf);
        }
    }
}
