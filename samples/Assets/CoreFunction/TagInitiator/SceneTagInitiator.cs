using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SceneTagInitiator : TagInitiator
{
    [Serializable]
    public enum SitDownType
    {
        Auto = 0,
        DoubleClick = 1, // 双击坐下
    }

    [Serializable]
    public class Range
    {
        public float min;
        public float max;
    }

    [Serializable]
    public class Playstart
    {
        public Range x;
        public float y;
        public Range z;
        public float rotation;
    }
    
    [Serializable]
    public class Map
    {
        [Header("地图")]
        public Sprite map; // 地图的比例要求和模型保持一致，且边缘距离为零
        [Header("模型的实际宽度")]
        public float width;
        [Header("模型的实际高度")]
        public float height;
        [Header("边距")]
        public float margin = 150f;
        [Header("模型相对原点的偏移度")]
        public Vector3 offset; // 模型中心点的坐标
    }

    [Header("版本号")]
    public string version;
    [Header("出生点")]
    public Playstart[] playstarts;
    [Header("地图")]
    public Map map;
    [Header("坐下的方式")]
    public SitDownType sitDownType;
    [Header("自动降低帧率")]
    public bool autoDropFrame;
}
