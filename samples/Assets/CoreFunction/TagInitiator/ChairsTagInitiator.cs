using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChairsTagInitiator : TagInitiator
{
    public enum AccessoryType
    {
        None,
        Laptop,
        Desktop
    }
    
    public enum OrientationType
    {
        None, // 无
        Custom, // 自定义
        Front, // 前
        Behind, // 后

    }

    [Serializable]
    public class Accessory
    {
        [Header("附件类型")]
        public AccessoryType accessoryType = AccessoryType.None;
        [Header("附件的位置偏移量")]
        public Vector3 accessoryOffset = Vector3.zero;
        [Header("附件的旋转角度")]
        public Vector3 accessoryRotation = Vector3.zero;
    }

    [Serializable]
    public class StandUpBeer
    {
        [Header("起立类型")]
        public OrientationType safetyBeerOrientation = OrientationType.None;
        [Header("safetyBeerOrientation == Custom 时，填写")]
        public Vector3 safetyPosition;
        [Header("safetyBeerOrientation == Front 时，填写")]
        public float safetyPositionFrontScale = 1.0f;
        [Header("safetyBeerOrientation == Behind 时，填写")]
        public float safetyPositionBehindScale = 1.3f;

    }

    public StandUpBeer standUpBeer;
    public Accessory accessory;


}
