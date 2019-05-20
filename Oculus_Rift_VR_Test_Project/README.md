# Game: Oculus Rift VR Test Project
# Developed by: Ricardo Guerra

This is a test project created for the purpose of testing Oculus Rift
controller button input. The "Builds" folder contains the Build for this test
project which includes the "Oculus Rift VR Test Project.exe" file, which is the
game itself. Please make sure to keep all of the files in the Build folder
together to ensure that the game will work properly, and please note that this
game will only work properly with the Oculus Rift. The "Scripts" folder contains
a C# Script called "TestOculusRiftControllerButtonInput.cs" which is made to
test controller button input for the Oculus Rift controller buttons. The
"OculusRiftVRTestProject.unitypackage" is a Unity package that contains all of
the Game Objects and the C# Script for this project and can be imported into
your Unity Project for testing.

Notes about the "Oculus Rift VR Test Project" game:
In this test project, there is a Player Controller Game Object which can be
moved around with the Oculus Rift left controller joystick. The game's camera
will move along with the Player Controller Game Object. Moving the Oculus Rift
right controller joystick in the left direction will move the camera's view to
the left, and moving the right controller joystick in the right direction will
move the camera's view to the right. There is a Canvas and Panel Game Object
where text will be displayed. The default message that displays on the Panel
requests the user to "Press a button to test controller input of your Oculus
Rift." When each of the buttons of the Oculus Rift controllers are pressed, this
message will change depending on which button is pressed. There is also a Green
Cube, Red Sphere, and a Blue Cone Game Object. Various actions will occur to the
Green Cube, Red Sphere, and Blue Cone Game Objects depending on which button is
pressed. Here is a list of actions that will occur when each button is pressed.

1) Pressing the 'X' button will decrease the size of the Green Cube, Red Sphere,
and Blue Cone Game Objects. The message that displays on the Panel will change
to "You've pressed the 'X' button!"
2) Pressing the 'Y' button will increase the size of the Green Cube, Red Sphere,
and Blue Cone Game Objects. The message that displays on the Panel will change
to "You've pressed the 'Y' button!"
3) Pressing the 'Start' button will reset the Green Cube, Red Sphere, and Blue
Cone Game Objects to their original settings. The message that displays on the
Panel will change to "You've pressed the 'Start' button!"
4) When pressing the 'Left Stick' button, the message that displays on the Panel
will change to "You've pressed the 'Left Stick' button!"
5) Pressing the 'A' button will make the Green Cube Game Object disappear.
Pressing the 'A' button again will make the Green Cube Game Object reappear. The
message that displays on the Panel will change to "You've pressed the 'A'
button!"
6) When pressing the 'B' button, the message that displays on the Panel will
change to "You've pressed the 'B' button!"
7) When pressed the 'Right Stick' button, the message that displays on the Panel
will change to "You've pressed the 'Right Stick' button!"
