using UnityEngine;

/// <summary>
/// ���������޲z��
/// </summary>
public class WindowUIManager : MonoBehaviour
{
	[SerializeField, Header("�~�P����")]
	private Brand brand;
	[SerializeField, Header("�u�X��������")]
	private GameObject[] windows;

	/// <summary>
	/// �}�l�ƥ�G��������@��
	/// </summary>
	private void Start()
	{
		// ��������[�~�P�s��].�Ұʳ]�w(���) - true ��ܡAfalse ����
		windows[(int)brand].SetActive(true);
	}
}

/// <summary>
/// �~�P����
/// </summary>
public enum Brand
{
	BrandA, BrandB
}