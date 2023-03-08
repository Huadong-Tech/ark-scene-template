using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ExhibitionStandTagInitiator : TagInitiator
{
    [Serializable]
    public enum ExhibitionStandLevel
    {
        Small = 1, // 小
        Middle = 2, // 中
        Big = 3, // 大
    }

    [Header("展位号")]
    public string exhibitionNo; // 展位号
    [Header("模型ID")]
    public string modelId; // 模型ID
    [Header("展台类型")]
    public ExhibitionStandLevel exhibitionLevel; // ExhibitionStandLevel
    [Header("是否显示当前展台")]
    public bool show; // 是否显示
    [Header("是否为固定展台")]
    public bool fixedModel; // 是否为固定模型
    public GameObject exhibitionStandGameObject; // fixedModel == true, 不可为空
}
