using System.Collections;
using UnityEngine;

public class PoleSpawner : MonoBehaviour
{
    public float PoleSpawnPoint;
    public GameObject[] PolePrefab;
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
            
            int poleType = Random.Range(0, PolePrefab.Length);

            Instantiate(PolePrefab[poleType], new Vector3(PoleSpawnPoint, heightPoint,0) , Quaternion.identity);

            yield return new WaitForSeconds(GapTime);
        }
    }
}
