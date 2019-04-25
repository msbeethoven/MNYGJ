using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translateCharacter : MonoBehaviour
{
    const float _ONE_THIRD = 1 / 3f;
    const float _TWO_THIRDS = 2 / 3f;

    [SerializeField]
    private GameObject _victoryObject;

    [SerializeField]
    private FollowPlayerCamera _cameraFollow;

    [SerializeField]
    private MovementTest _movementTestPrefab;

    private Vector3 _startPosition;
    public float speed = 10f;

    private void Awake()
    {
        Input.multiTouchEnabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_cameraFollow.IsIntroducingScene) { return; }
        if (!Input.GetMouseButtonDown(0)) { return; }

        Vector3? newPosition = null;

        // equal to touch position on mobile if multiTouch is
        // disabled or if only one finger is on the device
        Vector3 mousePos = Input.mousePosition;
        Vector3 viewportPosition = Camera.main.ScreenToViewportPoint(mousePos);
        float normalizedX = viewportPosition.x;

        if (normalizedX < _ONE_THIRD)
        {
            newPosition = new Vector3(transform.position.x - (Time.deltaTime * speed), transform.position.y, transform.position.z);
        }
        else if (normalizedX < _TWO_THIRDS)
        {
            newPosition = new Vector3(transform.position.x, transform.position.y + (Time.deltaTime * speed), transform.position.z);
        }
        else
        {
            newPosition = new Vector3(transform.position.x + (Time.deltaTime * speed), transform.position.y, transform.position.z);
        }

        if (newPosition.HasValue)
        {
            Move(newPosition.Value);
        }


    }

    void Move(Vector3 newPosition)
    {
        MovementTest testComponent = Instantiate(_movementTestPrefab, newPosition, Quaternion.identity);
        if (testComponent.CanMove)
        {
            transform.position = newPosition;
        }
        Destroy(testComponent.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Obstacle")
        {
            transform.position = _startPosition;
        }
        else if (collider.tag == "Victory")
        {
            _victoryObject.SetActive(true);
            CoinBank.AddCoins(50);
        }
    }
}
