using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngularGizmos : MonoBehaviour
{
    public float angleDegrees = 45f;
    public float lineLength = 5f;

    private void OnDrawGizmosSelected()
    {
        Vector3 startPoint = transform.position;

        float angleRadians = angleDegrees * Mathf.Deg2Rad;

        Vector3 direction = new Vector3(Mathf.Cos(angleRadians), Mathf.Sin(angleRadians), 0f);

        Vector3 endPoint = startPoint + direction * lineLength;
        
        Gizmos.color = Color.green;
        Gizmos.DrawLine(startPoint, endPoint);
    }
}
