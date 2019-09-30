//https://www.hackerrank.com/challenges/strange-advertising/problem
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

function viralAdvertising(n) {
    var total = 0, floor = 5;
    
    for(var i = 0; i < n; i++){
        total += Math.floor(floor / 2);
        floor = Math.floor(floor / 2) * 3;
    }
    
    return total;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    let result = viralAdvertising(n);

    ws.write(result + "\n");

    ws.end();
}