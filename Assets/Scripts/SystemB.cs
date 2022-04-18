using UnityEngine;

public class SystemB : MonoBehaviour
{
    public SystemA systemA;

    private void Awake()
    {
        systemA.passwordPublic = 777;

        // systemA.passwordPrivate = 999;
    }
}
