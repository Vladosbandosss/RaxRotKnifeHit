using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeSpawner : MonoBehaviour
{
    [SerializeField]GameObject knifePrefab;
    [SerializeField] Transform spawnPoint;

    [SerializeField] Text scoreText;
    private int score =0;
    private void Awake()
    {
        scoreText.text = score.ToString();
    }

  public void SpawnKnife()
    {
        GameObject go = Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation);
        go.transform.parent = spawnPoint;
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
