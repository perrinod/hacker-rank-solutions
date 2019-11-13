//https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem
'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function minimumAbsoluteDifference(arr) {
    var minDiff = Number.MAX_SAFE_INTEGER;
    arr.sort((a,b) => a - b);
    
    for(var i = 0; i < arr.length - 1; i++){
        var diff = Math.abs(arr[i] - arr[i+1]);
        if(diff < minDiff)
            minDiff = diff;
    }

    return minDiff;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    const result = minimumAbsoluteDifference(arr);

    ws.write(result + '\n');

    ws.end();
}