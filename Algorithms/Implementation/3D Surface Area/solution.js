// https://www.hackerrank.com/challenges/3d-surface-area/problem
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

function surfaceArea(A) {
    var area = 0;

    for(var i = 0; i < A.length; i++){
        for(var j = 0; j < A[i].length; j++){
            area += 4 * A[i][j] + 2;

            if(i + 1 < A.length)
                area -= 2 * Math.min(A[i][j], A[i + 1][j]);

            if(j + 1 < A[i].length)
                    area -= 2 * Math.min(A[i][j], A[i][j + 1]);
        }   
    }

    return area;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const HW = readLine().split(' ');

    const H = parseInt(HW[0], 10);

    const W = parseInt(HW[1], 10);

    let A = Array(H);

    for (let i = 0; i < H; i++) {
        A[i] = readLine().split(' ').map(ATemp => parseInt(ATemp, 10));
    }

    let result = surfaceArea(A);

    ws.write(result + "\n");

    ws.end();
}
