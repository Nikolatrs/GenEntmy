using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public void GenPublic(float rotateBot)
    {
        GeneratinEnemi(rotateBot);
    }

    private void GeneratinEnemi(float rotateBot)
    {
        Vector2 positionOnCircle = Random.insideUnitCircle * transform.localScale.x;
        Vector3 positionOnSpown = new Vector3(positionOnCircle.x, 0, positionOnCircle.y);

        Vector3 globalPosition = transform.position + positionOnSpown;
        Instantiate(_enemy, globalPosition, Quaternion.Euler(0, rotateBot, 0));
    }
}
