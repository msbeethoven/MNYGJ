using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowPlayerCamera : MonoBehaviour
{
    [SerializeField]
    private float _introStartY, _introEndY, _introMovementIncrement = 1;

    [SerializeField]
    private Transform _playerTransform;

    [SerializeField]
    private float _minViewportY = 0.2f, _maxViewportY = 0.8f,
    _downTranslation = -10f, _upTranslation = 10f;

    Camera _camera;

    Vector3 _startPosition;

    public bool IsIntroducingScene { get; private set; }

    void Awake() 
    {
        _camera = GetComponent<Camera>();
        _startPosition = transform.position;
    }

    IEnumerator Start()
    {
        IsIntroducingScene = true;
        float y = _introStartY;
        while (y > _introEndY)
        {
            y -= Time.deltaTime * _introMovementIncrement;
            y = Mathf.Max(_introEndY, y);
            transform.position = new Vector3(_startPosition.x, y, _startPosition.z);
            yield return null;
        }
        IsIntroducingScene = false;
    }

    void Update()
    {
        if (IsIntroducingScene) { return; }
        Vector2 viewportPosition = _camera.WorldToViewportPoint(_playerTransform.position);
        float viewportY = viewportPosition.y;
        if (viewportY > _maxViewportY)
        {
            transform.Translate(0, _upTranslation, 0, Space.World);
        } else if (viewportY < _minViewportY && transform.position != _startPosition)
        {
            transform.Translate(0, _downTranslation, 0, Space.World);
        }
    }
}
