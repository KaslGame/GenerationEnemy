using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _stopDistance;

    private Transform _target;

    private void Update()
    {
        if (_target != null)
            if (Vector2.Distance(transform.position, _target.position) > _stopDistance)
                transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        _target = target.transform;
    }
}
