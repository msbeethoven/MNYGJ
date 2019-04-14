using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
 public static PlayerJump instance;
  public float counter = 0;
  // public float moveForce = 10f;
  // private bool isMoving = false;
  // public Vector2 endPosition;
  // public Vector2 startPosition;
  private new Rigidbody2D rigidbody;
  public float scrollSpeed = -1.5f;

  public bool gameOver = false;

  // Start is called before the first frame update

  void Start()
  {
    rigidbody = GetComponent<Rigidbody2D>();

  }

  void Awake(){
      if (instance == null){
          instance = this;
      }
      else if (instance != this){
          Destroy(gameObject);
      }
  }

  // Update is called once per frame
  void Update()
  {

    // if (!isMoving)
    // {

    if (Input.GetMouseButton(0))
    {
      // StartCoroutine("MoveForward");
      // counter++;

      // if (counter % 2 != 0)
      // {
      //   StopCoroutine("MoveForward");
      //   isMoving = false;

      // }

      Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

      Vector3 movingThingsPos = rigidbody.transform.position;
      //Vector3 movingThingsPos = new Vector3(transform.position.x, transform.position.y, -0.0001f);
      Vector3 dir = pos - movingThingsPos;
      dir.Normalize();

      rigidbody.transform.Translate(dir * 10 * Time.deltaTime);

    }

    //    }



  }


  // private IEnumerator MoveForward()
  // {
  //   isMoving = true;
  //   if (Input.touchCount > 0)
  //   {
  //     Touch touch = Input.GetTouch(0);
  //     Debug.Log(touch);
  //   }
  //   transform.Translate(Vector3.up * 20 * Time.deltaTime);

  //   yield return new WaitForSeconds(.1f);
  //   isMoving = false;
  //   yield return null;
  // }

}
