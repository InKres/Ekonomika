using Photon.Pun;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEventer : MonoBehaviour
{
    private PhotonView PhotonView;

    void Start()
    {
        PhotonView = GetComponent<PhotonView>();
    }

    void Update()
    {
        // PhotonView.RpcSecure("");

        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            RaycastHit _hit;
            if (Physics.Raycast(ray, out _hit, Mathf.Infinity))
            {
                switch (_hit.transform.tag)
                {
                    case "House":
                        {
                            Debug.Log("����� �� ����!");
                        }
                        break;

                    case "Market":
                        {
                            Debug.Log("����� �� �������!");
                        }
                        break;

                    case "Forest":
                        {
                            Debug.Log("����� �� ����!");
                        }
                        break;

                    case "Mine":
                        {
                            Debug.Log("����� �� �����!");
                        }
                        break;

                    default:
                        break;
                }
            }
        }*/
    }
}
