using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomAnimationTriggerTagInitiator : TagInitiator
{
    [Header("动画对象")]
    public string animationName; // 游戏对象的名称
    [Header("触发对象")]
    public bool trigger;  // 点击当前对象是否触发动画
    [Header("触发按钮")]
    public Button triggerButton;  // 触发动画的Button按钮
    [Header("提示语")]
    public string alert; // 提示语
}
