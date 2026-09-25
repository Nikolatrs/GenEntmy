using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _incline = 0.2f;
    [SerializeField] private float _spid = 0.3f;

    private Vector3 _vectrForward;

    private void Awake()
    {
        _vectrForward = transform.forward.normalized;
    }

    private void Update()
    {
        MowePerson();
    }

    public void IndicateDirection(Vector3 derectionEnemy)
    {
        _vectrForward = derectionEnemy.normalized;
    }

    private void MowePerson()
    {
        Vector3 nextPosition = _vectrForward * _spid;
        Vector3 vectorIncline = Vector3.down * _incline + _vectrForward;
        transform.forward = vectorIncline;
        transform.Translate(nextPosition, Space.World);
    }
}
