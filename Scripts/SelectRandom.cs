using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandom : MonoBehaviour
{
    public int CountToLeave = 1;
    void Start()
    {
        while(transform.childCount > CountToLeave)
        {
            Transform childToDestroy = transform.GetChild(Random.Range(0, transform.childCount));
            DestroyImmediate(childToDestroy.gameObject);
        }
    }

}
