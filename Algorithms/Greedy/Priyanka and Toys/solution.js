// https://www.hackerrank.com/challenges/priyanka-and-toys/problem
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

function toys(w) {
    w.sort(function(a,b){return a - b});

    var containers = 1;
    var minimum = w[0];

    for(var i = 1; i < w.length; i++){
        if(w[i] > minimum + 4){
            containers++;
            minimum = w[i];
        }
    }

    return containers;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const w = readLine().split(' ').map(wTemp => parseInt(wTemp, 10));

    let result = toys(w);

    ws.write(result + "\n");

    ws.end();
}