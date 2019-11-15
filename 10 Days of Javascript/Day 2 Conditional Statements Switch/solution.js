//https://www.hackerrank.com/challenges/js10-switch/problem
'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function getLetter(s) {
    let letter;
    switch(s.charAt(0)){
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            return 'A';
            break;
        case "b":
        case "c":
        case "d":
        case "f":
        case "g":
            return 'B';
            break;
        case "h":
        case "j":
        case "k":
        case "l":
        case "m":
            return 'C';
            break;
        default:
            return 'D';
            break;
    }
    return letter;
}


function main() {
    const s = readLine();
    
    console.log(getLetter(s));
}
