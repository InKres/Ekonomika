using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float mouseX;
    private float mouseY;

    [Header("Чуствительность мыши")]
    public float sensitivityMouse = 200f;

    public Transform Player;

    private void FixedUpdate()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivityMouse * Time.deltaTime;
        mouseY += Input.GetAxis("Mouse Y") * sensitivityMouse * Time.deltaTime;


        //Player.Rotate(mouseX * new Vector3(0, 1, 0));
        //transform.Rotate(-mouseY * new Vector3(1, 0, 0));

        mouseY = Mathf.Clamp(mouseY, -38f, 38f);

        //Camera rotation only allowed if game us not paused
        transform.rotation = Quaternion.Euler(-mouseY, mouseX, 0f);
        Player.transform.rotation = Quaternion.Euler(0f, mouseX, 0f);
    }
    
}
