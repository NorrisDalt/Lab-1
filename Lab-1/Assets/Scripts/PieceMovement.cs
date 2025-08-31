using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PieceMovement : MonoBehaviour
{
    public enum ChessPiece { Pawn, Rook, Knight, Bishop, Queen, King }
    public ChessPiece Type;

    private Handles handleName;


    private void DrawCorrectAngle(float aAngle, float bLength)
    {
        Vector3 startPoint = transform.position;

        float angleRadians = aAngle * Mathf.Deg2Rad;

        Vector3 direction = new Vector3(Mathf.Cos(angleRadians), Mathf.Sin(angleRadians), 0f);

        Vector3 endPoint = startPoint + direction * bLength;

        Gizmos.color = Color.green;
        Gizmos.DrawLine(startPoint, endPoint);
    }

    private void OnDrawGizmosSelected()
    {
        ChessPiece piece = Type;

        switch (piece)
        {
            case ChessPiece.Pawn:
                Gizmos.color = Color.white;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .75f, "Pawn");
                DrawCorrectAngle(90, 2);
                break;
            case ChessPiece.Rook:
                Gizmos.color = Color.gray;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .75f, "Rook");
                DrawCorrectAngle(90, 7);
                DrawCorrectAngle(180, 7);
                break;
            case ChessPiece.Knight:
                Gizmos.color = Color.black;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .7f, "Knight");
                Gizmos.color = Color.green;

                Vector3 start = transform.position;

                Gizmos.DrawLine(start, start + new Vector3(2, 0, 0));
                Gizmos.DrawLine(start + new Vector3(2, 0, 0), start + new Vector3(2, 1, 0));

                Gizmos.DrawLine(start, start + new Vector3(2, 0, 0));
                Gizmos.DrawLine(start + new Vector3(2, 0, 0), start + new Vector3(2, -1, 0));

                Gizmos.DrawLine(start, start + new Vector3(-2, 0, 0));
                Gizmos.DrawLine(start + new Vector3(-2, 0, 0), start + new Vector3(-2, 1, 0));

                Gizmos.DrawLine(start, start + new Vector3(-2, 0, 0));
                Gizmos.DrawLine(start + new Vector3(-2, 0, 0), start + new Vector3(-2, -1, 0));

                Gizmos.DrawLine(start, start + new Vector3(0, 2, 0));
                Gizmos.DrawLine(start + new Vector3(0, 2, 0), start + new Vector3(1, 2, 0));

                Gizmos.DrawLine(start, start + new Vector3(0, 2, 0));
                Gizmos.DrawLine(start + new Vector3(0, 2, 0), start + new Vector3(-1, 2, 0));

                Gizmos.DrawLine(start, start + new Vector3(0, -2, 0));
                Gizmos.DrawLine(start + new Vector3(0, -2, 0), start + new Vector3(1, -2, 0));

                Gizmos.DrawLine(start, start + new Vector3(0, -2, 0));
                Gizmos.DrawLine(start + new Vector3(0, -2, 0), start + new Vector3(-1, -2, 0));
                break;
            case ChessPiece.Bishop:
                Gizmos.color = Color.blue;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .75f, "Bishop");
                DrawCorrectAngle(45, 4.2f);
                DrawCorrectAngle(135, 4.2f);
                DrawCorrectAngle(225, 4.2f);
                DrawCorrectAngle(315, 4.2f);
                break;
            case ChessPiece.Queen:
                Gizmos.color = Color.red;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * 1.5f, "Queen");
                DrawCorrectAngle(0, 4);
                DrawCorrectAngle(45, 4);
                DrawCorrectAngle(90, 4);
                DrawCorrectAngle(135, 4);
                DrawCorrectAngle(180, 4);
                DrawCorrectAngle(225, 4);
                DrawCorrectAngle(270, 4);
                DrawCorrectAngle(315, 4);
                break;
            case ChessPiece.King:
                Gizmos.color = Color.yellow;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .75f, "King");
                DrawCorrectAngle(0, 1f);
                DrawCorrectAngle(45, 1.4f);
                DrawCorrectAngle(90, 1f);
                DrawCorrectAngle(135, 1.4f);
                DrawCorrectAngle(180, 1f);
                DrawCorrectAngle(225, 1.4f);
                DrawCorrectAngle(270, 1f);
                DrawCorrectAngle(315, 1.4f);
                break;
        }
    }
}
