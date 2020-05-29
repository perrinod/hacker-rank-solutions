// https://www.hackerrank.com/challenges/closest-numbers/problem
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

function closestNumbers(arr) {
    arr.sort(function(a,b){ return a-b; });
    var minimum = Number.MAX_SAFE_INTEGER;
    var closest = [];

    for(var i = 1; i < arr.length; i++){
        if(arr[i] - arr[i-1] < minimum)
            closest = [];
            
        if(arr[i] - arr[i-1] <= minimum){
            minimum = arr[i] - arr[i-1];
            closest.push(arr[i-1]);
            closest.push(arr[i]);
        }
    }

    return closest;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    let result = closestNumbers(arr);

    ws.write(result.join(" ") + "\n");

    ws.end();
}