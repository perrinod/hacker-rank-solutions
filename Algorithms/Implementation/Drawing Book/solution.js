//https://www.hackerrank.com/challenges/drawing-book/problem
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
    inputString = inputString.trim().split('\n').map(str => str.trim());

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function pageCount(n, p) {
    if(n == p || p == 1)
        return 0;

    if(n % 2 == 0)
        n = n + 1;

    var back = Math.floor((n - p) / 2);
    var front = Math.floor(p / 2);
    
    if (front > back)
        return back;

    return front;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const p = parseInt(readLine(), 10);

    let result = pageCount(n, p);

    ws.write(result + "\n");

    ws.end();
}
