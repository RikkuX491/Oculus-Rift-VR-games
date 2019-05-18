using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestOculusRiftControllerButtonInput : MonoBehaviour {

    // The Green Cube Game Object.
    public GameObject objectA;

    // The Red Sphere Game Object.
    public GameObject objectB;

    // The Blue Cone Game Object.
    public GameObject objectC;

    // The text that displays on the Canvas and Panel.
    public Text panelText;

    // Holds a copy of the Game Objects objectA, objectB, and objectC when the game starts.
    private Vector3 objectA_originalPosition;
    private Quaternion objectA_originalRotation;
    private Rigidbody rb_ObjectA;

    private Vector3 objectB_originalPosition;
    private Quaternion objectB_originalRotation;
    private Rigidbody rb_ObjectB;

    private Vector3 objectC_originalPosition;
    private Quaternion objectC_originalRotation;
    private Rigidbody rb_ObjectC;

    // Use this for initialization
    void Start()
    {
        // Holds a copy of the Game Objects objectA, objectB, and objectC when the game starts.
        objectA_originalPosition = objectA.transform.position;
        objectA_originalRotation = objectA.transform.rotation;
        rb_ObjectA = objectA.GetComponent<Rigidbody>();

        objectB_originalPosition = objectB.transform.position;
        objectB_originalRotation = objectB.transform.rotation;
        rb_ObjectB = objectB.GetComponent<Rigidbody>();

        objectC_originalPosition = objectC.transform.position;
        objectC_originalRotation = objectC.transform.rotation;
        rb_ObjectC = objectC.GetComponent<Rigidbody>();

        // objectA.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Left controller buttons: X, Y, Start, Left Stick.
         */

        // If the user pressed the 'X' button.
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            Debug.Log("Pressed X button");
            panelText.text = "You've pressed the 'X' button!";

            // Decrease the Scale of the Cube, Sphere, and Cone Game Objects.
            if (objectA.transform.localScale.x > 0.1f)
            {
                objectA.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                objectB.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                objectC.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            }
        }

        // If the user pressed the 'Y' button.
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            Debug.Log("Pressed Y button");
            panelText.text = "You've pressed the 'Y' button!";

            // Increase the Scale of the Cube, Sphere, and Cone Game Objects.
            if (objectA.transform.localScale.x < 1.0f)
            {
                objectA.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                objectB.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                objectC.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
        }

        // If the user pressed the 'Start' button.
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            Debug.Log("Pressed Start button");
            panelText.text = "You've pressed the 'Start' button!";

            // Reset the Cube, Sphere, and Cone Game Objects to their original settings.
            resetGameObjects();
        }

        // If the user pressed the 'Left Stick' button.
        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
        {
            Debug.Log("Pressed Left Stick button");
            panelText.text = "You've pressed the 'Left Stick' button!";
        }

        /*
         * Right controller buttons: A, B, Right Stick.
         */

        // If the user pressed the 'A' button.
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("Pressed A button");
            panelText.text = "You've pressed the 'A' button!";
            if (!objectA.activeInHierarchy) objectA.SetActive(true);
            else objectA.SetActive(false);
        }

        // If the user pressed the 'B' button.
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            Debug.Log("Pressed B button");
            panelText.text = "You've pressed the 'B' button!";
        }

        // If the user pressed the 'Right Stick' button.
        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstick))
        {
            Debug.Log("Pressed Right Stick button");
            panelText.text = "You've pressed the 'Right Stick' button!";
        }

    }

    /*
     * Method name: resetGameObjects
     * Return type: void
     * Purpose: Reset the Cube, Sphere, and Cone Game Objects to their original settings.
     */

    private void resetGameObjects()
    {
        objectA.SetActive(true);
        // Reset the position of the Cube.
        objectA.transform.position = objectA_originalPosition;
        // Reset the rotation of the Cube.
        objectA.transform.rotation = objectA_originalRotation;
        // Reset the scale of the Cube.
        objectA.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        // Set the velocity of the Cube back to 0.
        rb_ObjectA.velocity = Vector3.zero;
        rb_ObjectA.angularVelocity = Vector3.zero;
        rb_ObjectA.Sleep();

        // Reset the position of the Sphere.
        objectB.transform.position = objectB_originalPosition;
        // Reset the rotation of the Sphere.
        objectB.transform.rotation = objectB_originalRotation;
        // Reset the scale of the Sphere.
        objectB.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        // Set the velocity of the Sphere back to 0.
        rb_ObjectB.velocity = Vector3.zero;
        rb_ObjectB.angularVelocity = Vector3.zero;
        rb_ObjectB.Sleep();

        // Reset the position of the Cone.
        objectC.transform.position = objectC_originalPosition;
        // Reset the rotation of the Cone.
        objectC.transform.rotation = objectC_originalRotation;
        // Reset the scale of the Cone.
        objectC.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        // Set the velocity of the Cone back to 0.
        rb_ObjectC.velocity = Vector3.zero;
        rb_ObjectC.angularVelocity = Vector3.zero;
        rb_ObjectC.Sleep();
    }
}