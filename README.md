# MATRIX-Unity-Sensor-Utility-App
This MOS app allow you to send the sensor data from your MATRIX to a unity client.
- Sensors: https://matrix-io.github.io/matrix-documentation/matrix-os/reference/sensors/#magnetometer

This connection uses Socket.io as a server to send data. The 
<a href="https://github.com/Hermitter/MATRIX-Unity-Sensor-Utility-App/blob/master/MATRIX-Unity-Project/Assets/MATRIX.cs">MATRIX.cs</a>
file allows you to pick which sensors you want.
- Unity Socket.io Library: https://www.assetstore.unity3d.com/en/#!/content/21721
- IP address & sensors are set with the SocketIO game object

# Expanding
Although this app only sends sensor data, it can easily be expanded to read and control every component of your MATRIX from Unity. Feel free to use these files
in any way to help you create your unity project.
