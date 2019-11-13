//https://www.hackerrank.com/challenges/cut-the-sticks/problem
'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function cutTheSticks(arr) {
    arr.sort((a,b) => a - b);
    var sticks = new Array();
    sticks.push(arr.length);

    for(var i = 0; i < arr.length - 1; i++){
        if(arr[i] != arr[i+1])
            sticks.push(arr.length - (i + 1));
    }

    return sticks;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    let result = cutTheSticks(arr);

    ws.write(result.join("\n") + "\n");

    ws.end();
}