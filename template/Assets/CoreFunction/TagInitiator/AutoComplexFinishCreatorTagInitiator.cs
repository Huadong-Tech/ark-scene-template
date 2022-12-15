using UnityEngine;

public class AutoComplexFinishCreatorTagInitiator : TagInitiator
{
    public enum UnitPixel
    {
        m_16 = 16,
        m_32 = 32,
        m_64 = 64,
        m_96 = 96,
        m_128 = 128,
        m_160 = 160,
        m_192 = 192,
        m_224 = 224,
        m_256 = 256,
        m_288 = 288,
        m_320 = 320,
        m_352 = 352,
        m_384 = 384,
        m_512 = 512,
    }

    [Header("装修位 ID")]
    public int finishID;
    [Header("检测距离(m)")]
    public float distance = 12.0f;
    [Header("像素密度(/m)")]
    public UnitPixel unitPixel = UnitPixel.m_64;
    [Header("默认图")]
    public Texture2D defaultTexture;
}
