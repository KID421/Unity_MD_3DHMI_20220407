using UnityEngine;

/// <summary>
/// �U�~�P�����������
/// 1. �����C��
/// 2. ���D�j�p�B�r��
/// 3. �����C��
/// 4. ����C��
/// 5. �����Ϥ�
/// </summary>
[CreateAssetMenu(menuName = "KID/BrandUIData", fileName = "BrandUIData")]
public class BrandWindowUIData : ScriptableObject
{
    [Header("�����C��")]
    public Color colorBg;
    [Header("���D�j�p")]
    public int sizeTitle;
    [Header("���D�r��")]
    public Font fontTitle;
    [Header("�����C��")]
    public Color colorContent;
    [Header("����C��")]
    public Color colorOption;
    [Header("�����Ϥ�")]
    public Sprite spriteClose;
}
