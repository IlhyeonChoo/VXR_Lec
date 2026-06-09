using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public void MoveForward()
    {
        this.transform.position += this.transform.forward;
    }    
}
