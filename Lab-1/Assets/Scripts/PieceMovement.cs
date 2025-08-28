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
                Handles.Label(transform.position * .7f, "Pawn");
                DrawCorrectAngle(90, 2);
                break;
            case ChessPiece.Rook:
                Gizmos.color = Color.gray;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .7f, "Rook");
                DrawCorrectAngle(90, 8);
                DrawCorrectAngle(180, 8);
                break;
            case ChessPiece.Knight:
                Gizmos.color = Color.black;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .7f, "Knight");
                break;
            case ChessPiece.Bishop:
                Gizmos.color = Color.blue;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .7f, "Bishop");
                DrawCorrectAngle(45, 2);
                DrawCorrectAngle(135, 2);
                DrawCorrectAngle(225, 2);
                DrawCorrectAngle(315, 2);
                break;
            case ChessPiece.Queen:
                Gizmos.color = Color.red;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .7f, "Queen");
                DrawCorrectAngle(0, 2);
                DrawCorrectAngle(45, 2);
                DrawCorrectAngle(90, 2);
                DrawCorrectAngle(135, 2);
                DrawCorrectAngle(180, 2);
                DrawCorrectAngle(225, 2);
                DrawCorrectAngle(270, 2);
                DrawCorrectAngle(315, 2);
                break;
            case ChessPiece.King:
                Gizmos.color = Color.yellow;
                Handles.color = Color.blue;
                Handles.DrawWireDisc(transform.position, new Vector3(1, 1, 1), 1f);
                Handles.Label(transform.position * .7f, "King");
                DrawCorrectAngle(0, 1);
                DrawCorrectAngle(45, 1);
                DrawCorrectAngle(90, 1);
                DrawCorrectAngle(135, 1);
                DrawCorrectAngle(180, 1);
                DrawCorrectAngle(225, 1);
                DrawCorrectAngle(270, 1);
                DrawCorrectAngle(315, 1);
                break;
        }
    }
}
