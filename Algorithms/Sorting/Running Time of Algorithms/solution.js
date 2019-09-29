//https://www.hackerrank.com/challenges/runningtime/problem
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

function runningTime(arr) {
    var shift = 0;
    var i = 1;
        while(i < arr.length){
        var j = i;
        while(j > 0 && arr[j-1] > arr[j]){
            arr[j] = arr[j] + arr[j-1];
            arr[j-1] = arr[j] - arr[j-1];
            arr[j] = arr[j] - arr[j-1];
            j--;
            shift++;
        }
        i++;
    }

    return shift;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    let result = runningTime(arr);

    ws.write(result + "\n");

    ws.end();
}
