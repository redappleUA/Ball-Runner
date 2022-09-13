using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Transform Begin; //Початок чанку (задано на кожному чанку)
    public Transform End; //Кінець чанку (задано на кожному чанку)

    public Mesh[] Blocks; //Різні варіанти блоків

    public AnimationCurve ChanceFromDistance;

    private void Start()
    {
        foreach(var filter in GetComponentsInChildren<MeshFilter>()) //Проходимо всі чайлди чанку
        {
            if(filter.sharedMesh == Blocks[0])
                filter.sharedMesh = Blocks[Random.Range(0, Blocks.Length)]; //Вибираємо рандомно один з варіантів
           
        }
    }
}
