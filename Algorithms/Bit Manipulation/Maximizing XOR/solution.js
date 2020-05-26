// https://www.hackerrank.com/challenges/maximizing-xor/problem
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

function maximizingXor(l, r) {
    var largest = 0;

    for(var i = l; i <= r; i++)
        for(var j = l; j <= r; j++)
            largest = Math.max(largest, i^j);

    return largest;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const l = parseInt(readLine(), 10);

    const r = parseInt(readLine(), 10);

    let result = maximizingXor(l, r);

    ws.write(result + "\n");

    ws.end();
}