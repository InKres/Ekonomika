using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Скорость перемещения персонажа")]
    public float speed = 7f;

    PhotonView view;
    public GameObject camera;
    public PlayerController scriptPlayerController;

    private void Awake()
    {
        view = GetComponent<PhotonView>();
        if (!view.IsMine)
        {
            camera.SetActive(false);
            scriptPlayerController.enabled = false;
        }
    }
    // Update is called once per frame
    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }

    }
}
