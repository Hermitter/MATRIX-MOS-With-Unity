using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class MATRIX : MonoBehaviour {

    //Pick Desired Sensors
    public bool useGyroscope = false;
    public bool useUV = false;
    public bool useTemperature = false;
    public bool useHumidity = false;
    public bool usePressure = false;
    public bool useAccelerometer = false;
    public bool useMagnetometer = false;

    private SocketIOComponent socket;

    //On Game Start
    public void Start()
    {
        //locate socket.io prefab
        GameObject go = GameObject.Find("SocketIO");
        socket = go.GetComponent<SocketIOComponent>();

        //Set Event Listeners
        socket.On("open", Open);//connection made
        socket.On("error", Error);//socket.io error
        socket.On("close", Close);//connection lost
        //Set MATRIX Sensor Event Listeners
        socket.On("gyroscopeData", gyroscopeData);
        socket.On("uvData", uvData);
        socket.On("temperatureData", temperatureData);
        socket.On("humidityData", humidityData);
        socket.On("pressureData", pressureData);
        socket.On("accelerometerData", accelerometerData);
        socket.On("magnetometerData", magnetometerData);

        //start non-blocking loop
        StartCoroutine("eventLoop");
    }

    ////////////////////////////////////////////
    // Requesting Device Data
    ////////////////////////////////////////////
    private IEnumerator eventLoop()
    {
        //delay to properly initialize
        yield return new WaitForSecondsRealtime(0.1f);
        //loop forever
        while (true)
        {
            yield return new WaitForSecondsRealtime(0f);//no delay
            //Use sensors if requested\\
            if (useGyroscope)
                socket.Emit("gyroscope");
            if (useUV)
                socket.Emit("uv");
            if (useTemperature)
                socket.Emit("temperature");
            if (useHumidity)
                socket.Emit("humidity");
            if (usePressure)
                socket.Emit("pressure");
            if (useAccelerometer)
                socket.Emit("accelerometer");
            if (useMagnetometer)
                socket.Emit("magnetometer");
        }
    }

    ////////////////////////////////////////////
    // Event Listener Functions
    ////////////////////////////////////////////

    //////////////////////////
    // On Connection
    public void Open(SocketIOEvent e)
    {
        Debug.Log("[SocketIO] Open received: " + e.name + " " + e.data);
    }
    //////////////////////////
    // Socket.io Error
    public void Error(SocketIOEvent e)
    {
        Debug.Log("[SocketIO] Error received: " + e.name + " " + e.data);
    }
    //////////////////////////
    // Lost Connection To Server
    public void Close(SocketIOEvent e)
    {
        Debug.Log("[SocketIO] Close received: " + e.name + " " + e.data);
    }
    //////////////////////////
    // Gyroscope
    public static class Gyroscope
    {
        public static float yaw = 0f;
        public static float pitch = 0f;
        public static float roll = 0f;
        public static float x = 0f;
        public static float y = 0f;
        public static float z = 0f;
    }
    public void gyroscopeData(SocketIOEvent e)
    {
        Gyroscope.yaw = float.Parse(e.data["yaw"].ToString());
        Gyroscope.pitch = float.Parse(e.data["pitch"].ToString());
        Gyroscope.roll = float.Parse(e.data["roll"].ToString());
        Gyroscope.x = float.Parse(e.data["x"].ToString());
        Gyroscope.y = float.Parse(e.data["y"].ToString());
        Gyroscope.z = float.Parse(e.data["z"].ToString());
        Debug.Log(e.data);
    }
    //////////////////////////
    // UV
    public static class UV
    {
        public static float value = 0f;
        public static string risk = "";
    }
    public void uvData(SocketIOEvent e)
    {
        UV.value = float.Parse(e.data["value"].ToString());
        UV.risk = e.data["risk"].ToString();
        Debug.Log(e.data);
    }
    //////////////////////////
    // Temperature 
    public static class Temperature
    {
        public static float value = 0f;
        public static string risk = "";
    }
    public void temperatureData(SocketIOEvent e)
    {
        Temperature.value = float.Parse(e.data["value"].ToString());
        Debug.Log(e.data);
    }
    //////////////////////////
    // Humidity 
    public static class Humidity
    {
        public static float value = 0f;
        public static string risk = "";
    }
    public void humidityData(SocketIOEvent e)
    {
        Humidity.value = float.Parse(e.data["value"].ToString());
        Debug.Log(e.data);
    }
    //////////////////////////
    // Pressure 
    public static class Pressure
    {
        public static float value = 0f;
        public static string risk = "";
    }
    public void pressureData(SocketIOEvent e)
    {
        Pressure.value = float.Parse(e.data["value"].ToString());
        Debug.Log(e.data);
    }
    //////////////////////////
    // Accelerometer 
    public static class Accelerometer
    {
        public static float x = 0f;
        public static float y = 0f;
        public static float z = 0f;
    }
    public void accelerometerData(SocketIOEvent e)
    {
        Accelerometer.x = float.Parse(e.data["x"].ToString());
        Accelerometer.y = float.Parse(e.data["y"].ToString());
        Accelerometer.z = float.Parse(e.data["z"].ToString());
        Debug.Log(e.data);
    }
    //////////////////////////
    // Magnetometer 
    public static class Magnetometer
    {
        public static float x = 0f;
        public static float y = 0f;
        public static float z = 0f;
    }
    public void magnetometerData(SocketIOEvent e)
    {
        Magnetometer.x = float.Parse(e.data["x"].ToString());
        Magnetometer.y = float.Parse(e.data["y"].ToString());
        Magnetometer.z = float.Parse(e.data["z"].ToString());
        Debug.Log(e.data);
    }
}
