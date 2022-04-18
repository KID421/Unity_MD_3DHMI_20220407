using UnityEngine;

/// <summary>
/// 點擊物件
/// </summary>
public class ClickObject : MonoBehaviour
{
    /// <summary>
    /// 更新事件：Start 後執行
    /// 約 60 FPS - Frame Per Second - 一秒鐘執行約 60 次
    /// </summary>
    private void Update()
    {
        ClickAndShowObject();
    }

    /// <summary>
    /// 點擊並顯示物件
    /// </summary>
    private void ClickAndShowObject()
    {
        // 如果 按下左鍵 或 單點觸控螢幕
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // print("點擊左鍵！");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.gameObject);
            }
        }
    }
}
