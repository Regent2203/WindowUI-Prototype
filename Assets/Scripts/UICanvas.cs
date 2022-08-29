using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICanvas : MonoBehaviour
{
    public static Transform Root;

    private void Awake()
    {
        Root = transform;
    }
}
