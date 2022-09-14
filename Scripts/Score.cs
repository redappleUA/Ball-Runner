using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Transform player;
    public static int ScorePoints { get; private set; }

    private void Awake() => player = gameObject.GetComponent<Transform>();

    private void FixedUpdate() => ScorePoints = -(int)player.position.x;
}
