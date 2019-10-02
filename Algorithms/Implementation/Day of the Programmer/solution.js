//https://www.hackerrank.com/challenges/day-of-the-programmer/problem
'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function dayOfProgrammer(year) {
    var s;
    if(year == 1918)
    return "26.09." + year;

    if(year < 1918){
        s = year % 4 == 0 ? "12.09." : "13.09.";
    }
    else{
        s = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) ? "12.09." : "13.09.";

    }

    return s + year;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const year = parseInt(readLine().trim(), 10);

    const result = dayOfProgrammer(year);

    ws.write(result + '\n');

    ws.end();
}