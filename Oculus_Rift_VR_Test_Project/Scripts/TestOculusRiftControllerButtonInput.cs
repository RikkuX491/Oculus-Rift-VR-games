using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * C# Script name: TestOculusRiftControllerButtonInput
 * Author: Ricardo Guerra
 * Updated: May 19, 2019
 * 
 * Description: This is a C# Script made to test controller button input for the Oculus Rift
 *              controller buttons. When each of the buttons of the controllers are pressed,
 *              various actions will occur in the "Oculus Rift VR Test Project".
 */

public class TestOculusRiftControllerButtonInput : MonoBehaviour {

    // The Green Cube Game Object.
    public GameObject greenCube;

    // The Red Sphere Game Object.
    public GameObject redSphere;

    // The Blue Cone Game Object.
    public GameObject blueCone;

    // The text that displays on the Canvas and Panel.
    public Text panelText;

    // The original position of the Green Cube Game Object.
    private Vector3 greenCube_originalPosition;
    // The original rotation values of the Green Cube Game Object.
    private Quaternion greenCube_originalRotation;
    // The original rigidbody settings for the Green Cube Game Object.
    private Rigidbody rb_greenCube;

    // The original position of the Red Sphere Game Object.
    private Vector3 redSphere_originalPosition;
    // The original rotation values of the Red Sphere Game Object.
    private Quaternion redSphere_originalRotation;
    // The original rigidbody settings for the Red Sphere Game Object.
    private Rigidbody rb_redSphere;

    // The original position of the Blue Cone Game Object.
    private Vector3 blueCone_originalPosition;
    // The original rotation values of the Blue Cone Game Object.
    private Quaternion blueCone_originalRotation;
    // The original rigidbody settings for the Blue Cone Game Object.
    private Rigidbody rb_blueCone;

    // Use this for initialization
    void Start()
    {
        // Holds a copy of the original position, the original rotation values, and the original
        // rigidbody settings for the Green Cube Game Object when the game starts.
        greenCube_originalPosition = greenCube.transform.position;
        greenCube_originalRotation = greenCube.transform.rotation;
        rb_greenCube = greenCube.GetComponent<Rigidbody>();

        // Holds a copy of the original position, the original rotation values, and the original
        // rigidbody settings for the Red Sphere Game Object when the game starts.
        redSphere_originalPosition = redSphere.transform.position;
        redSphere_originalRotation = redSphere.transform.rotation;
        rb_redSphere = redSphere.GetComponent<Rigidbody>();

        // Holds a copy of the original position, the original rotation values, and the original
        // rigidbody settings for the Blue Cone Game Object when the game starts.
        blueCone_originalPosition = blueCone.transform.position;
        blueCone_originalRotation = blueCone.transform.rotation;
        rb_blueCone = blueCone.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Oculus Rift, Left controller buttons: X, Y, Start, Left Stick.
         */

        // If the user pressed the 'X' button...
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            // A log prints to the console saying that the 'X' button was pressed.
            Debug.Log("Pressed X button");
            // Text prints to the panel saying that the 'X' button was pressed.
            panelText.text = "You've pressed the 'X' button!";

            // If the Scale of the Red Sphere is greater than 0.1 (the Green Cube, Red Sphere,
            // and the Blue Cone are all the same size), decrease the Scale of the Green Cube,
            // Red Sphere, and Blue Cone Game Objects by 0.1.
            if (redSphere.transform.localScale.x > 0.1f)
            {
                greenCube.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                redSphere.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
                blueCone.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            }
        }

        // If the user pressed the 'Y' button...
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            // A log prints to the console saying that the 'Y' button was pressed.
            Debug.Log("Pressed Y button");
            // Text prints to the panel saying that the 'Y' button was pressed.
            panelText.text = "You've pressed the 'Y' button!";

            // If the Scale of the Red Sphere is less than 1 (the Green Cube, Red Sphere, and the
            // Blue Cone are all the same size), increase the Scale of the Green Cube, Red
            // Sphere, and Blue Cone Game Objects by 0.1.
            if (redSphere.transform.localScale.x < 1.0f)
            {
                greenCube.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                redSphere.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                blueCone.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
        }

        // If the user pressed the 'Start' button.
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            // A log prints to the console saying that the 'Start' button was pressed.
            Debug.Log("Pressed Start button");
            // Text prints to the panel saying that the 'Start' button was pressed.
            panelText.text = "You've pressed the 'Start' button!";

            // Reset the Green Cube, Red Sphere, and Blue Cone Game Objects to their original
            // settings.
            resetGameObjects();
        }

        // If the user pressed the 'Left Stick' button.
        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick))
        {
            // A log prints to the console saying that the 'Left Stick' button was pressed.
            Debug.Log("Pressed Left Stick button");
            // Text prints to the panel saying that the 'Left Stick' button was pressed.
            panelText.text = "You've pressed the 'Left Stick' button!";
        }

        /*
         * Oculus Rift, Right controller buttons: A, B, Right Stick.
         */

        // If the user pressed the 'A' button.
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            // A log prints to the console saying that the 'A' button was pressed.
            Debug.Log("Pressed A button");
            // Text prints to the panel saying that the 'A' button was pressed.
            panelText.text = "You've pressed the 'A' button!";

            // If the Green Cube Game Object is currently inactive, set it to be active to make
            // it reappear in the game.
            if (!greenCube.activeInHierarchy) greenCube.SetActive(true);
            // Else, set the Green Cube Game Object to be inactive to make it disappear.
            else greenCube.SetActive(false);
        }

        // If the user pressed the 'B' button.
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            // A log prints to the console saying that the 'B' button was pressed.
            Debug.Log("Pressed B button");
            // Text prints to the panel saying that the 'B' button was pressed.
            panelText.text = "You've pressed the 'B' button!";
        }

        // If the user pressed the 'Right Stick' button.
        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstick))
        {
            // A log prints to the console saying that the 'Right Stick' button was pressed.
            Debug.Log("Pressed Right Stick button");
            // Text prints to the panel saying that the 'Right Stick' button was pressed.
            panelText.text = "You've pressed the 'Right Stick' button!";
        }

    }

    /*
     * Method name: resetGameObjects
     * Return type: void
     * Purpose: Reset the Green Cube, Red Sphere, and Blue Cone Game Objects to their original
     *          settings.
     */

    private void resetGameObjects()
    {
        // If the Green Cube Game Object is currently inactive, set it to be active to make
        // it reappear in the game.
        if (!greenCube.activeInHierarchy) greenCube.SetActive(true);
        // Reset the position of the Green Cube.
        greenCube.transform.position = greenCube_originalPosition;
        // Reset the rotation of the Green Cube.
        greenCube.transform.rotation = greenCube_originalRotation;
        // Reset the scale of the Green Cube.
        greenCube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        // Set the velocity of the Green Cube back to 0.
        rb_greenCube.velocity = Vector3.zero;
        rb_greenCube.angularVelocity = Vector3.zero;
        rb_greenCube.Sleep();

        // Reset the position of the Red Sphere.
        redSphere.transform.position = redSphere_originalPosition;
        // Reset the rotation of the Red Sphere.
        redSphere.transform.rotation = redSphere_originalRotation;
        // Reset the scale of the Red Sphere.
        redSphere.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        // Set the velocity of the Red Sphere back to 0.
        rb_redSphere.velocity = Vector3.zero;
        rb_redSphere.angularVelocity = Vector3.zero;
        rb_redSphere.Sleep();

        // Reset the position of the Blue Cone.
        blueCone.transform.position = blueCone_originalPosition;
        // Reset the rotation of the Blue Cone.
        blueCone.transform.rotation = blueCone_originalRotation;
        // Reset the scale of the Blue Cone.
        blueCone.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        // Set the velocity of the Blue Cone back to 0.
        rb_blueCone.velocity = Vector3.zero;
        rb_blueCone.angularVelocity = Vector3.zero;
        rb_blueCone.Sleep();
    }
}