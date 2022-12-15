using UnityEngine;
using UnityEngine.UI;

public class CustomAnimationTriggerTagInitiator : TagInitiator
{
    [Header("动画对象名称")]
    public string animationName;
    [Header("触发对象")]
    [Tooltip("点击当前对象是否触发动画")]
    public bool trigger;
    [Header("触发按钮")]
    public Button triggerButton;
    [Header("提示语")]
    public string alert;
}
