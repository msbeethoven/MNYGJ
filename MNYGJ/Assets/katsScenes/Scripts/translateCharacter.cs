using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translateCharacter : MonoBehaviour
{
    [SerializeField]
    private GameObject _victoryObject;

    [SerializeField]
    private MovementTest _movementTestPrefab;

    private Vector3 _startPosition;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3? newPosition = null;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            newPosition = new Vector3(transform.position.x, transform.position.y + (Time.deltaTime * speed), transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            newPosition = new Vector3(transform.position.x - (Time.deltaTime * speed), transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
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
