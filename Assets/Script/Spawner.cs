using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Generator[] _spawnPoints;
    private float _delay = 2.0f;
    private float _startDelay = 0;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnamy), _startDelay, _delay);
    }

    private void SpawnEnamy()
    {
        var spawn = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        Vector3 direction = RandomDirection();
        spawn.GenerationPublic(direction);
    }

    private Vector3 RandomDirection()
    {
        Vector2 randomPointOnCircle = Random.insideUnitCircle;
        Vector3 direction3D = new Vector3(randomPointOnCircle.x, 0, randomPointOnCircle.y);
        return direction3D;
    }
}
