using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///
///</summary>
public class NewBehaviourScript : MonoBehaviour
{
    private float zzs;
    public GameObject wy;
    public void wyzz(bool Iszz)
    {
        if (Iszz)
            Debug.Log("wy is zz");
        else
            Debug.Log("wy is sb");
    }
    private void KillWy()
    {
        GameObject.Destroy(wy);
    }
}
