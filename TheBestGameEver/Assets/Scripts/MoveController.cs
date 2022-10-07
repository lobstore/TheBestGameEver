using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public Camera mainCamera;
    public float speed = 0;
    private GameObject player;
    private Queue<Vector3> target = new Queue<Vector3>();
    private void Start()
    {
        player = gameObject;
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;
            target.Enqueue(mousePos);

        }
        if (target != null && target.Count!=0)
        {
            if (Vector3.Distance(player.transform.position, target.Peek()) >= 0.2f)
            {
                player.transform.position = Vector3.Lerp(player.transform.position,target.Peek(), Time.deltaTime*speed);
            }
            else
            {
                target.Dequeue();
            }
        }
    }

}
