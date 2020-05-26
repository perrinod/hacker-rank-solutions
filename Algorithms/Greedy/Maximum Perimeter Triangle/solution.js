// https://www.hackerrank.com/challenges/maximum-perimeter-triangle/problem
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

function maximumPerimeterTriangle(sticks) {
    sticks.sort(function(a,b){return a-b});

    for(var i = sticks.length - 1; i > 1; i--){
        if(sticks[i-2] + sticks[i-1] > sticks[i])
            return [sticks[i-2], sticks[i-1], sticks[i]];
    }

    return [-1];

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const sticks = readLine().split(' ').map(sticksTemp => parseInt(sticksTemp, 10));

    let result = maximumPerimeterTriangle(sticks);

    ws.write(result.join(" ") + "\n");

    ws.end();
}