using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 汽車控制
/// 1. W 移動
/// 2. 更新時速
/// </summary>
public class CarControl : MonoBehaviour
{
    [SerializeField, Header("移動按鍵")]
    private KeyCode keyMove = KeyCode.W;
    [SerializeField, Header("時速")]
    private Text textSpeed;
    [SerializeField, Header("時速小")]
    private Text textSpeedSmall;
    [SerializeField, Header("速度"), Range(0, 50)]
    private float speed = 10;
    [SerializeField, Header("車子大燈")]
    private GameObject goLight;
    [SerializeField, Header("切換大燈按鍵")]
    private KeyCode keyLight = KeyCode.Q;

    private Rigidbody rig;

    /// <summary>
    /// 喚醒事件：Start 之前執行一次，初始化設定，取得元件
    /// </summary>
    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        SwitchLight();
    }

    /// <summary>
    /// 移動汽車
    /// </summary>
    private void Move()
    {
        if (Input.GetKey(keyMove))
        {
            // print("按住移動按鍵");
            rig.velocity = new Vector3(0, 0, speed);
        }

        float z = rig.velocity.z * 10;          // z * 10
        z = Mathf.Clamp(z, 0, 500);             // 夾住（值，最小，最大）
        textSpeed.text = z.ToString("f0");
        textSpeedSmall.text = z.ToString("f0");
    }

    /// <summary>
    /// 切換大燈
    /// </summary>
    private void SwitchLight()
    {
        if (Input.GetKeyDown(keyLight))
        {
            // 車燈.啟動設定（車燈目前啟動狀態相反值）
            goLight.SetActive(!goLight.activeInHierarchy);
        }
    }
}
