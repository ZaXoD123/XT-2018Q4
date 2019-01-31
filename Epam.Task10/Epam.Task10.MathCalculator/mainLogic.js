"use strict";
alert(calculate(prompt("Expression")));
function calculate(str) {
    let firstMatch = str.match(/[+\-*\/=]/);
    let result;
    try {

        result = parseFloat(str.substr(0, firstMatch.index));
    }
    catch (error){
        return error;
    }
    let match;
    let nextMatch;
    while (match = str.match(/[+\-*\/=]/)) {
        str = str.substr(match.index + 1, str.length);
        nextMatch = str.match(/[+\-*\/=]/);
        try {
            switch (match[0]) {
                case "+":
                    result += parseFloat(str.substr(0, nextMatch.index));
                    break;
                case "*":
                    result *= parseFloat(str.substr(0, nextMatch.index));
                    break;
                case "-":
                    result -= parseFloat(str.substr(0, nextMatch.index));
                    break;
                case "/":
                    result /= parseFloat(str.substr(0, nextMatch.index));
                    break;
                case "=":
                    return result;
            }
        }
        catch (error){
            return error;
        }
    }
}