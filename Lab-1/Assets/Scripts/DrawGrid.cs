using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGrid : MonoBehaviour
{

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(255, 255, 255, 0.5f);
        Gizmos.DrawCube(transform.position, new Vector3(8, 8, 1));

        for(int i = -4; i <= 4; i++)
        {
            Gizmos.DrawLine(new Vector3(i + transform.position.x, -4 + transform.position.y, 0), new Vector3(i + transform.position.x, 4 + transform.position.y, 0));
            Gizmos.DrawLine(new Vector3(-4 + transform.position.x, i + transform.position.y, 0), new Vector3(4 + transform.position.x, i + transform.position.y, 0));
        }
    }
}
