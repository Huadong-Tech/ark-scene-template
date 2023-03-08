using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CustomAnimationTagInitiator : TagInitiator
{

    [Serializable]
    public class AnimationConfigInfo
    {
        [Header("开启动画的条件")]
        public string startKey; // AnimationController内Parameters的Key值，Trigger类型
        [Header("关闭动画的条件")]
        public string stopKey; // AnimationController内Parameters的Key值，Trigger类型
        [Header("挂着Animator控件的对象")]
        public GameObject aniamtorGameObjet;
    }

    [Serializable]
    public class AudioConfigInfo
    {
        [Header("动画绑定的音频")]
        public AudioClip audioClip;
        [Header("延迟播放时间")]
        public float delayPlayTime; // >0
    }

    [Header("动画")]
    public List<AnimationConfigInfo> animationConfigInfos;
    [Header("动画音频")]
    public AudioConfigInfo animationAudioConfigInfo;

}
