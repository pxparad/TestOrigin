using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class yandex : MonoBehaviour
{
    [DllImport("__Internal")]

    private static extern void Hello();

    public void HelloButton()
    {
        Hello();
    }
}
