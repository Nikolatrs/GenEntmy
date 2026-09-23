using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Generator[] _spawnPoints;
    private float _delay = 2;
    private float _startDelay = 0;


    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnamy), _startDelay, _delay);
    }

    private void SpawnEnamy()
    {
        var spown = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        float angle =  Random.Range(0, 360);
        spown.GenPublic(angle);
    }
}
