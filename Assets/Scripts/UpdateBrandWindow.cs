using UnityEngine;
using UnityEngine.UI;   // 要控制 UGUI 必須引用此命名空間

/// <summary>
/// 第二種變更品牌介面的方式
/// 1. 底圖
/// 2. 標題
/// 3. 內文
/// 4. 單選
/// 5. 關閉
/// </summary>
public class UpdateBrandWindow : MonoBehaviour
{
    [SerializeField, Header("底圖")]
    private Image imgBG;
    [SerializeField, Header("標題")]
    private Text textTitle;
    [SerializeField, Header("內文")]
    private Text textContent;
    [SerializeField, Header("單選")]
    private Image[] imgOptions;
    [SerializeField, Header("關閉")]
    private Image imgClose;

    [SerializeField, Header("品牌類型")]
    private Brand brand;
    [SerializeField, Header("品牌介面資料")]
    private BrandWindowUIData[] brandUIData;

    private void Start()
    {
        UpdateUI();
    }

    /// <summary>
    /// 更新視窗介面
    /// </summary>
    private void UpdateUI()
    {
        int brandIndex = (int)brand;
        BrandWindowUIData data = brandUIData[brandIndex];

        imgBG.color = data.colorBg;                     // 底圖 顏色
        textTitle.fontSize = data.sizeTitle;            // 標題 大小
        textTitle.font = data.fontTitle;                // 標題 字型
        textContent.color = data.colorContent;          // 內文 顏色

        for (int i = 0; i < imgOptions.Length; i++)
        {
            imgOptions[i].color = data.colorOption;     // 選項 顏色
        }

        imgClose.sprite = data.spriteClose;             // 關閉 圖片
    }
}
