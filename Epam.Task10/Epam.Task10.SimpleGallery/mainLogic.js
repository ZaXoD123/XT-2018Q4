"use strict";
let timer;
let interval;
let isGoing = false;
let isPaused = true;
let setIntervalInvoked = false;
let remainingTime = 10;

function Timer(callback, delay) {
    let timerId, start, remaining = delay;

    this.pause = function() {
        window.clearTimeout(timerId);
        remaining -= new Date() - start;
    };

    this.resume = function() {
        start = new Date();
        window.clearTimeout(timerId);
        timerId = window.setTimeout(callback, remaining);
    };

    this.resume();
}

window.onload = function () {
    init();
};

function init() {
    if(isGoing === true)
    {
        alert("process is isGoing already");
        return;
    }
    isGoing = true;
    let page = window.location.pathname.split("/").pop();
    switch (page){
        case "index.html":
            pageSwitcher("page1.html");
            break;
        case "page1.html":
            pageSwitcher("page2.html");
            break;
        case "page2.html":
            pageSwitcher("page3.html");
            break;
    }
}

function instantSwitchForward() {
    let page = window.location.pathname.split("/").pop();
    switch (page){
        case "index.html":
            window.location.replace("page1.html");
            break;
        case "page1.html":
            window.location.replace("page2.html");
            break;
        case "page2.html":
            window.location.replace("page3.html");
            break;
    }
}

function instantSwitchBackwards() {
    let page = window.location.pathname.split("/").pop();
    switch (page){
        case "index.html":
            alert("It is the first page!");
            break;
        case "page1.html":
            window.location.replace("index.html");
            break;
        case "page2.html":
            window.location.replace("page1.html");
            break;
        case "page3.html":
            window.location.replace("page2.html");
            break;
    }
}

function pageSwitcher(page) {
    let header = document.getElementById("remaining-time");
    timer = new Timer(function () {
        window.location.replace(page);
    }, 10000);

    header.innerHTML = "Time remaining " + remainingTime;
    isPaused = false;
    if(!setIntervalInvoked)
    {
        setIntervalInvoked = true;
        interval = setInterval(function () {
            if(isPaused !== true)
            {
                remainingTime--;
                header.innerHTML = "Time remaining " + remainingTime;
                if(remainingTime <= 0){
                    clearInterval(interval);
                }
            }
        },1000);
    }
}

function stopSwitcher() {
    isPaused = true;
    isGoing = false;
    timer.pause();
}

function closeWindow() {
    window.close();
}

function firstPageRedirect() {
    window.location.replace("index.html");
}