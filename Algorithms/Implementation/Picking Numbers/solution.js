//https://www.hackerrank.com/challenges/picking-numbers/problem
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

function pickingNumbers(a) {
    var maximum = 0;
    var frequency = new Array(100).fill(0);

    for(var i = 0; i < a.length; i++)
        frequency[a[i]]++;

    for(var i = 2; i < frequency.length; i++)
        maximum = Math.max(maximum, frequency[i] + frequency[i-1]);

    return maximum;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine().trim(), 10);

    const a = readLine().replace(/\s+$/g, '').split(' ').map(aTemp => parseInt(aTemp, 10));

    const result = pickingNumbers(a);

    ws.write(result + '\n');

    ws.end();
}