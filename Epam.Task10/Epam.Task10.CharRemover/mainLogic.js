"use strict";
alert(CharRemover(prompt("Enter Something")));

function CharRemover(str) {
    str.split(" ").forEach(function (t) {
        for (let i = 0; i < t.length; i++) {
            if (t.lastIndexOf(t[i]) !== t.indexOf(t[i])) {
                while(str.indexOf(t[i]) !== -1 && t[i] !== "!" &&
                t[i] !== "." &&
                t[i] !== "," &&
                t[i] !== ";" &&
                t[i] !== "?" &&
                t[i] !== ":")
                    str = str.replace(t[i],"")
            }
        }
    });
    return str;
}
