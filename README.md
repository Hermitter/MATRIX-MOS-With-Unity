# MATRIX-MOS-With-Unity
![Gyroscope Demo](https://thumbs.gfycat.com/HappyThickBassethound-size_restricted.gif)
# Overview
This project contains two important folders. The first folder, Unity-Assets, goes into your exsisting unity project. The second file, Unity-Sensor-Utility, is a MOS app that is installed on your MATRIX device. 
- Guides: 
  - Element14: https://www.element14.com/community/community/raspberry-pi/blog/2017/09/27/matrix-creator-app-to-read-sensors-in-unity
  - Hackster: https://www.hackster.io/matrix-labs/read-matrix-creator-sensors-in-unity-cf177c

The MOS app allow you to send the sensor data from your MATRIX to a unity client.
- Sensors: https://matrix-io.github.io/matrix-documentation/matrix-os/reference/sensors

This connection uses Socket.io as a server to send data. The 
<a href="https://github.com/Hermitter/MATRIX-Unity-Sensor-Utility-App/blob/master/Unity-Assets/MATRIX.cs">MATRIX.cs</a>
file contains options to pick the sensors you want to use. Once attached to a game object, every script will have access to calling your MATRIX's sensors.
- Unity Socket.io Library is already included: https://www.assetstore.unity3d.com/en/#!/content/21721
- IP address is set with the SocketIO game object

# Expanding
Although this app only sends sensor data, it can easily be expanded to read and control every component of your MATRIX from Unity. Feel free to use these files in any way to help you with your project.
