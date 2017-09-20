///Start Socket Sevrver
var io = require('socket.io')(6001);//(port)
console.log('server started');

////////////////////////////////////
// Config & Start MATRIX Sensors
///////////////////////////////////
var options = {
	refresh: 100,
	timeout: 15000
}

//Gyroscope
var gyroscopeData = {};
matrix.init('gyroscope', options).then(function(data){
	gyroscopeData = data;
});
//UV
var uvData = {};
matrix.init('uv', options).then(function(data){
	uvData = data;
});
//Temperature
var temperatureData = {};
matrix.init('temperature', options).then(function(data){
	temperatureData = data;
});
//Humidity
var humidityData = {};
matrix.init('humidity', options).then(function(data){
	humidityData = data;
});
//Pressure
var pressureData = {};
matrix.init('pressure', options).then(function(data){
	pressureData = data;
});
//Accelerometer
var accelerometerData = {};
matrix.init('accelerometer', options).then(function(data){
	accelerometerData = data;
});
//Magnetometer
var magnetometerData = {};
matrix.init('magnetometer', options).then(function(data){
	magnetometerData = data;
});

////////////////////////////
//Event Listeners
///////////////////////////
io.on('connection', function (socket) {
	console.log('Client Connected\n Sending Data...');

	//Send gyroscope data on request
	socket.on('gyroscope', function () {
		socket.emit('gyroscopeData', gyroscopeData);
	});

	//Send uv data on request
	socket.on('uv', function () {
		socket.emit('uvData', uvData);
	});

	//Send uv data on request
	socket.on('temperature', function () {
		socket.emit('temperatureData', temperatureData);
	});

	//Send humidity data on request
	socket.on('humidity', function () {
		socket.emit('humidityData', humidityData);
	});

	//Send humidity data on request
	socket.on('pressure', function () {
		socket.emit('pressureData', pressureData);
	});

	//Send accelerometer data on request
	socket.on('accelerometer', function () {
		socket.emit('accelerometerData', accelerometerData);
	});

	//Send magnetometer data on request
	socket.on('magnetometer', function () {
		socket.emit('magnetometerData', magnetometerData);
	});

	//Client has left or lost connection
	socket.on('disconnect', function () {
		console.log('Client Disconnected');
	});
});