"use strict";

var counterConnection = new signalR.HubConnectionBuilder().withUrl("/CounterUsersOnline").build();

counterConnection.on("updateCount", function (Count) {
    var textMessage = document.getElementById("UserOnline");
    textMessage.innerHTML = Count;
});

counterConnection.start();