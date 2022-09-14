using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Transform Begin; //Start of chunk (set on each chunk)
    public Transform End; //End of chunk (set on each chunk)
    public AnimationCurve ChanceFromDistance;

    [SerializeField] private Mesh[] Blocks; //Different options of blocks

    private void Start()
    {
        foreach(var filter in GetComponentsInChildren<MeshFilter>()) //We go through all the childs of Chunk
        {
            if(filter.sharedMesh == Blocks[0])
                filter.sharedMesh = Blocks[Random.Range(0, Blocks.Length)]; //We choose one of the options at random
        }
    }
}
