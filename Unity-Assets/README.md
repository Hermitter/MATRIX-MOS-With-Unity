# Drag & Drop All Files Into Your Unity Project
This folder contains all the unity assets you need to read your MATRIX Device's Sensors. 
Once all files are inside your unity project, open the "example" scene to get started.

# Setting Up The Connection
![ScreenShot](https://i.imgur.com/0GxrCfE.png)

Assuming your MOS app is running, click on the "SocketIO" Game Object. This object 
should have a url field to input the ip of your MATRIX device
- ws://YOUR_PI_IP:PORT/socket.io/?EIO=4&transport=websocket

The "SocketIO" Game Object will also have boxes that you need to check for the sensors you want to use.

# Usage
```
//Gyroscope
MATRIX.Gyroscope.pitch //float
MATRIX.Gyroscope.roll //float
MATRIX.Gyroscope.yaw //float
MATRIX.Gyroscope.x //float
MATRIX.Gyroscope.y //float
MATRIX.Gyroscope.z //float

//UV
MATRIX.UV.value //float
MATRIX.UV.risk //string

//Temperature
MATRIX.Temperature.value //float

//Humidity
MATRIX.Humidity.value //float

//Pressure
MATRIX.Pressure.value //float

//Accelerometer
MATRIX.Accelerometer.x //float
MATRIX.Accelerometer.y //float
MATRIX.Accelerometer.z //float

//Magnetometer
MATRIX.Magnetometer.x //float
MATRIX.Magnetometer.y //float
MATRIX.Magnetometer.z //float

```
