using System.Collections.Generic;
using UnityEngine;
using System;

public class ExhibitionStandModelTagInitiator : TagInitiator
{
    [Serializable]
    public class ExhibitionStandModelInfo
    {
        [Header("展台名称")]
        public string name;
        [Header("展台预制体")]
        public GameObject prefab;
        [Header("展台ID")]
        public string modelId;
    }

    [Header("小型展台")]
    public List<ExhibitionStandModelInfo> small;
    [Header("中型展台")]
    public List<ExhibitionStandModelInfo> middle;
    [Header("大型展台")]
    public List<ExhibitionStandModelInfo> big;
}
