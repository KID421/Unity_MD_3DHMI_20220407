using UnityEngine;

/// <summary>
/// 視窗介面管理器
/// </summary>
public class WindowUIManager : MonoBehaviour
{
	[SerializeField, Header("品牌類型")]
	private Brand brand;
	[SerializeField, Header("彈出視窗物件")]
	private GameObject[] windows;

	/// <summary>
	/// 開始事件：播放後執行一次
	/// </summary>
	private void Start()
	{
		// 視窗物件[品牌編號].啟動設定(顯示) - true 顯示，false 隱藏
		windows[(int)brand].SetActive(true);
	}
}

/// <summary>
/// 品牌類型
/// </summary>
public enum Brand
{
	BrandA, BrandB
}