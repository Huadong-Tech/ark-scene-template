using UnityEngine;

public class RoomTagInitiator : TagInitiator
{
    public enum Shape
    {
        Square,
        Circle,
    }
    
    [Header("房间ID")]
    public int roomId;
    [Header("房间外的安全位置")]
    public Vector3 gate;
    [Header("区域形状")]
    public Shape shape;
}


