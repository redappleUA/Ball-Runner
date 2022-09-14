using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] private Transform player; //TODO: Respawn

    private void OnTriggerEnter(Collider other) => FindObjectOfType<GameOverScreen>(true).OpenGameOverScreen(Score.ScorePoints);
}
