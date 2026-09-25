using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public void GenerationPublic(Vector3 direction)
    {
        GenerationEnemy(direction);
    }

    private void GenerationEnemy(Vector3 direction)
    {
        Vector2 positionOnCircle = Random.insideUnitCircle * (transform.localScale.x/2);
        Vector3 positionOnSpown = transform.position + new Vector3(positionOnCircle.x, 0, positionOnCircle.y);
        Vector3 derectionEnemy = direction;
        Instantiate(_enemy, positionOnSpown, Quaternion.identity).IndicateDirection(derectionEnemy);
    }
}
