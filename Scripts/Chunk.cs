using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Transform Begin; //������� ����� (������ �� ������� �����)
    public Transform End; //ʳ���� ����� (������ �� ������� �����)

    public Mesh[] Blocks; //г�� ������� �����

    public AnimationCurve ChanceFromDistance;

    private void Start()
    {
        foreach(var filter in GetComponentsInChildren<MeshFilter>()) //��������� �� ������ �����
        {
            if(filter.sharedMesh == Blocks[0])
                filter.sharedMesh = Blocks[Random.Range(0, Blocks.Length)]; //�������� �������� ���� � �������
           
        }
    }
}
