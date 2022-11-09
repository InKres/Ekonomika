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
                            Debug.Log("Нажал по дому!");
                        }
                        break;

                    case "Market":
                        {
                            Debug.Log("Нажал по маркету!");
                        }
                        break;

                    case "Forest":
                        {
                            Debug.Log("Нажал по лесу!");
                        }
                        break;

                    case "Mine":
                        {
                            Debug.Log("Нажал по шахте!");
                        }
                        break;

                    default:
                        break;
                }
            }
        }*/
    }
}
