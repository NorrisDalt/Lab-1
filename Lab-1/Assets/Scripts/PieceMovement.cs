using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    public enum ChessPiece { Pawn, Rook, Knight, Bishop, Queen, King }
    public ChessPiece Type;

    private void OnDrawGizmosSelected()
    {
        ChessPiece piece = Type;

        switch (piece)
        {
            case ChessPiece.Pawn:
                Gizmos.color = Color.white;
                Gizmos.DrawLine(transform.position, new Vector3(-3, 0, 1));
                break;
            case ChessPiece.Rook:
                Gizmos.color = Color.gray;
                Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
                break;
            case ChessPiece.Knight:
                Gizmos.color = Color.black;
                Gizmos.DrawLine(transform.position, new Vector3(1, 1, 1));
                break;
            case ChessPiece.Bishop:
                Gizmos.color = Color.blue;
                Gizmos.DrawLine(transform.position, new Vector3(4, 2, 1));
                Gizmos.DrawLine(transform.position, new Vector3(-3, -1, 1));
                break;
            case ChessPiece.Queen:
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, new Vector3(4, 1, 1));
                Gizmos.DrawLine(transform.position, new Vector3(-3, 0, 1));
                Gizmos.DrawLine(transform.position, new Vector3(0, 4, 1));
                Gizmos.DrawLine(transform.position, new Vector3(-3, -3, 1));
                Gizmos.DrawLine(transform.position, new Vector3(4, -3, 1));
                break;
            case ChessPiece.King:
                Gizmos.color = Color.yellow;
                Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
                break;
        }
    }
}
