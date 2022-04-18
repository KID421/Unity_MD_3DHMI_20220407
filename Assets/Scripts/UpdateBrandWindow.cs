using UnityEngine;
using UnityEngine.UI;   // �n���� UGUI �����ޥΦ��R�W�Ŷ�

/// <summary>
/// �ĤG���ܧ�~�P�������覡
/// 1. ����
/// 2. ���D
/// 3. ����
/// 4. ���
/// 5. ����
/// </summary>
public class UpdateBrandWindow : MonoBehaviour
{
    [SerializeField, Header("����")]
    private Image imgBG;
    [SerializeField, Header("���D")]
    private Text textTitle;
    [SerializeField, Header("����")]
    private Text textContent;
    [SerializeField, Header("���")]
    private Image[] imgOptions;
    [SerializeField, Header("����")]
    private Image imgClose;

    [SerializeField, Header("�~�P����")]
    private Brand brand;
    [SerializeField, Header("�~�P�������")]
    private BrandWindowUIData[] brandUIData;

    private void Start()
    {
        UpdateUI();
    }

    /// <summary>
    /// ��s��������
    /// </summary>
    private void UpdateUI()
    {
        int brandIndex = (int)brand;
        BrandWindowUIData data = brandUIData[brandIndex];

        imgBG.color = data.colorBg;                     // ���� �C��
        textTitle.fontSize = data.sizeTitle;            // ���D �j�p
        textTitle.font = data.fontTitle;                // ���D �r��
        textContent.color = data.colorContent;          // ���� �C��

        for (int i = 0; i < imgOptions.Length; i++)
        {
            imgOptions[i].color = data.colorOption;     // �ﶵ �C��
        }

        imgClose.sprite = data.spriteClose;             // ���� �Ϥ�
    }
}
