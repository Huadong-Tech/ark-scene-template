using UnityEngine;
using System;

public class ExhibitionStandTagInitiator : TagInitiator
{
    [Serializable]
    public enum ExhibitionStandLevel
    {
        Small = 1,
        Middle = 2,
        Big = 3,
    }

    [Header("展位号")]
    public string exhibitionNo;
    [Header("模型ID")]
    public string modelId;
    [Header("展台类型")]
    public ExhibitionStandLevel exhibitionLevel;
    [Header("是否显示当前展台")]
    public bool show;
    [Header("是否为固定展台")]
    public bool fixedModel;
    [Header("固定展台")]
    [Tooltip("fixedModel为true时不可为空")]
    public GameObject exhibitionStandGameObject;
}
