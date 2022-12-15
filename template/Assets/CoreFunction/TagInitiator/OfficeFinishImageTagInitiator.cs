using UnityEngine;

public class OfficeFinishImageTagInitiator : TagInitiator
{
    public enum PixelSize
    {
        m_32 = 32,
        m_64 = 64,
        m_128 = 128,
        m_256 = 256,
        m_512 = 512,
        m_1024 = 1024,
        m_2048 = 2048,
        m_4096 = 4096,
    }

    [Header("装修位 ID")]
    public int finishID;
    [Header("默认图")]
    public Texture2D defaultTexture;
    [Header("图片尺寸上限")]
    public PixelSize maxSize = PixelSize.m_1024;
}
