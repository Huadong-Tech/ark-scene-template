using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTagInitiator : TagInitiator
{
    [Header("旋转速度")]
    public float rotateVelocity = 0.1f;
    [Header("波动速度")]
    public float fluctuateVelocity = 0.01f;
    [Header("波动幅度")]
    public float fluctuateValue = 0.1f;
    [Header("是否面向相机")]
    public bool faceCamera; // value == true时，旋转效果失效
    [Header("鼠标放上去是否静止")]
    public bool hoverStop = false;
}
