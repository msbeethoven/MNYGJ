// using UnityEngine;
// using System.Collections;

// // Vector3.MoveTowards example.

// // A cube can be moved around the world. It is kept inside a 1 unit by 1 unit
// // xz space. A small, long cylinder is created and positioned away from the center of
// // the 1x1 unit. The cylinder is moved between two locations. Each time the cylinder is
// // positioned the cube moves towards it. When the cube reaches the cylinder the cylinder
// // is re-positioned to the other location. The cube then changes direction and moves
// // towards the cylinder again.
// //
// // A floor object is created for you.
// //
// // To view this example, create a new 3d Project and create a Cube placed at
// // the origin. Create Example.cs and change the script code to that shown below.
// // Save the script and add to the Cube.
// //
// // Now run the example.

// public class MoveTowards : MonoBehaviour
// {
//     // Adjust the speed for the application.
//     public float speed = 1.0f;

//     // The target (cylinder) position.
//     private Transform target;

//     void Awake()
//     {
//         // Position the cube at the origin.
//         transform.position = new Vector3(0.0f, 0.0f, 0.0f);

//         // Create and position the cylinder. Reduce the size.
//         GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
//         Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);

//         // Grab cylinder values and place on the target.
//         target = cylinder.transform;
//         target.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);
//         target.transform.position = new Vector3(0.8f, 0.0f, 0.8f);

//         // Position the camera.
//         Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
//         Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, -0.5f);

//         // Create and position the floor.
//         GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
//         floor.transform.position = new Vector3(0.0f, -1.0f, 0.0f);
//     }

//     void Update()
//     {
//         // Move our position a step closer to the target.
//         float step =  speed * Time.deltaTime; // calculate distance to move
//         transform.position = Vector3.MoveTowards(transform.position, target.position, step);

//         // Check if the position of the cube and sphere are approximately equal.
//         if (Vector3.Distance(transform.position, target.position) < 0.001f)
//         {
//             // Swap the position of the cylinder.
//             target.position *= -1.0f;
//         }
//     }
// }

using UnityEngine;
using System.Collections;
using UnityEngine.iOS;

// Input.GetTouch example.
//
// Attach to an origin based cube.
// A screen touch moves the cube on an iPhone or iPad.
// A second screen touch reduces the cube size.

public class MoveTowards : MonoBehaviour
{
    private Vector3 position;
    private float width;
    private float height;

    void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void OnGUI()
    {
        // Compute a fontSize based on the size of the screen width.
        GUI.skin.label.fontSize = (int)(Screen.width / 25.0f);

        GUI.Label(new Rect(20, 20, width, height * 0.25f),
            "x = " + position.x.ToString("f2") +
            ", y = " + position.y.ToString("f2"));
    }

    void Update()
    {
        // Handle screen touches.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                pos.y = (pos.y - height) / height;
                position = new Vector3(-pos.x, pos.y, 0.0f);

                // Position the cube.
                transform.position = position;
            }

            if (Input.touchCount == 2)
            {
                touch = Input.GetTouch(1);

                if (touch.phase == TouchPhase.Began)
                {
                    // Halve the size of the cube.
                    transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                }

                if (touch.phase == TouchPhase.Ended)
                {
                    // Restore the regular size of the cube.
                    transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                }
            }
        }
    }
}


