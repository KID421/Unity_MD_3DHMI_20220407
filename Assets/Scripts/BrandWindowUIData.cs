using UnityEngine;

/// <summary>
/// 各品牌視窗介面資料
/// 1. 底圖顏色
/// 2. 標題大小、字型
/// 3. 內文顏色
/// 4. 單選顏色
/// 5. 關閉圖片
/// </summary>
[CreateAssetMenu(menuName = "KID/BrandUIData", fileName = "BrandUIData")]
public class BrandWindowUIData : ScriptableObject
{
    [Header("底圖顏色")]
    public Color colorBg;
    [Header("標題大小")]
    public int sizeTitle;
    [Header("標題字型")]
    public Font fontTitle;
    [Header("內文顏色")]
    public Color colorContent;
    [Header("單選顏色")]
    public Color colorOption;
    [Header("關閉圖片")]
    public Sprite spriteClose;
}
