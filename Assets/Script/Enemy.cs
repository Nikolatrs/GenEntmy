using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _incline = 0.2f;
    [SerializeField] private float _spid = 0.3f;

    private Vector3 _vectrForward;

    private void Awake()
    {
        _vectrForward = transform.forward;
    }

    private void Update()
    {
        MowePerson();
    }

    private void MowePerson()
    {
        Vector3 nextPosition = _vectrForward * _spid;
        transform.forward = Vector3.down* _incline + _vectrForward;
        transform.position += nextPosition;
    }
}
