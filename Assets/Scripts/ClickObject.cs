using UnityEngine;

/// <summary>
/// �I������
/// </summary>
public class ClickObject : MonoBehaviour
{
    /// <summary>
    /// ��s�ƥ�GStart �����
    /// �� 60 FPS - Frame Per Second - �@��������� 60 ��
    /// </summary>
    private void Update()
    {
        ClickAndShowObject();
    }

    /// <summary>
    /// �I������ܪ���
    /// </summary>
    private void ClickAndShowObject()
    {
        // �p�G ���U���� �� ���IĲ���ù�
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // print("�I������I");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.collider.gameObject);
            }
        }
    }
}
