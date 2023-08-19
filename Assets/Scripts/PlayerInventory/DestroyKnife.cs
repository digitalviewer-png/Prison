using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKnife : MonoBehaviour
{
    public void DestroyThisObject()
    {
        Destroy(this.gameObject);
    }
}
