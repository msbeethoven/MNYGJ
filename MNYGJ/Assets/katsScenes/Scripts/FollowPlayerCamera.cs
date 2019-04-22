using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowPlayerCamera : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;

    [SerializeField]
    private float _minViewportY = 0.2f, _maxViewportY = 0.8f,
    _downTranslation = -10f, _upTranslation = 10f;

    Camera _camera;

    void Awake() { _camera = GetComponent<Camera>(); }
    void Update()
    {
        Vector2 viewportPosition = _camera.WorldToViewportPoint(_playerTransform.position);
        float viewportY = viewportPosition.y;
        if (viewportY > _maxViewportY)
        {
            transform.Translate(0, _upTranslation, 0, Space.World);
        } else if (viewportY < _minViewportY)
        {
            transform.Translate(0, _downTranslation, 0, Space.World);
        }
    }
}
