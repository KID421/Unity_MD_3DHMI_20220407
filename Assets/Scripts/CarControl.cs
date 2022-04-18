using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �T������
/// 1. W ����
/// 2. ��s�ɳt
/// </summary>
public class CarControl : MonoBehaviour
{
    [SerializeField, Header("���ʫ���")]
    private KeyCode keyMove = KeyCode.W;
    [SerializeField, Header("�ɳt")]
    private Text textSpeed;
    [SerializeField, Header("�ɳt�p")]
    private Text textSpeedSmall;
    [SerializeField, Header("�t��"), Range(0, 50)]
    private float speed = 10;

    private Rigidbody rig;

    /// <summary>
    /// ����ƥ�GStart ���e����@���A��l�Ƴ]�w�A���o����
    /// </summary>
    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// ���ʨT��
    /// </summary>
    private void Move()
    {
        if (Input.GetKey(keyMove))
        {
            // print("�����ʫ���");
            rig.velocity = new Vector3(0, 0, speed);
        }

        float z = rig.velocity.z * 10;          // z * 10
        z = Mathf.Clamp(z, 0, 500);             // ����]�ȡA�̤p�A�̤j�^
        textSpeed.text = z.ToString("f0");
        textSpeedSmall.text = z.ToString("f0");
    }
}
