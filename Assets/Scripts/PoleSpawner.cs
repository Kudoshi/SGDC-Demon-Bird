using System.Collections;
using UnityEngine;

public class PoleSpawner : MonoBehaviour
{
    public float GapAmount;
    public float PoleSpawnPoint;
    public SpriteRenderer PolePrefab;
    public GameObject ScoreTrigger;
    public float GapMinHeight;
    public float GapMaxHeight;
    public float GapTime;

    private void Start()
    {
        StartCoroutine(GeneratePole());
    }

    private IEnumerator GeneratePole()
    {
        while (true)
        {
            float heightPoint = Random.Range(GapMinHeight, GapMaxHeight);

            float topPoleHeightPos = heightPoint + (GapAmount / 2) + (PolePrefab.bounds.size.y / 2);
            float botPoleHeightPos = heightPoint - (GapAmount / 2) - (PolePrefab.bounds.size.y / 2);

            Vector3 topPoleSpawnPoint = new Vector3(PoleSpawnPoint, topPoleHeightPos, 0);
            Vector3 botPoleSpawnPoint = new Vector3(PoleSpawnPoint, botPoleHeightPos, 0);

            SpriteRenderer poleTop = Instantiate(PolePrefab, topPoleSpawnPoint, Quaternion.identity);
            SpriteRenderer poleBot = Instantiate(PolePrefab, botPoleSpawnPoint, Quaternion.identity);

            Instantiate(ScoreTrigger, new Vector3(PoleSpawnPoint, heightPoint, 0), Quaternion.identity);

            yield return new WaitForSeconds(GapTime);
        }
    }
}
