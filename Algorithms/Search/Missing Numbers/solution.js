//https://www.hackerrank.com/challenges/missing-numbers/problem
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

function missingNumbers(arr, brr) {
    arr.sort((a,b) => a - b);
    brr.sort((a,b) => a - b);
    var missing = new Set();

    var i = 0, j = 0;
    while(i < brr.length){
        if(j >= arr.length || arr[j] != brr[i])
            missing.add(brr[i]);
        else
            j++;

        i++;
    }

    return Array.from(missing);

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    const m = parseInt(readLine(), 10);

    const brr = readLine().split(' ').map(brrTemp => parseInt(brrTemp, 10));

    const result = missingNumbers(arr, brr);

    ws.write(result.join(' ') + '\n');

    ws.end();
}