// https://www.hackerrank.com/challenges/fair-rations/problem
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

function fairRations(B) {
    var total = B.reduce((a,b) => a + b, 0);
    
    if(total % 2 != 0)
        return -1;

    var count = 0;

    for(var i = 1; i < B.length; i++){
        if(B[i-1] % 2 != 0){
            count += 2;
            B[i]++;
        }
    }

    return count;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const N = parseInt(readLine(), 10);

    const B = readLine().split(' ').map(BTemp => parseInt(BTemp, 10));

    let result = fairRations(B);

    if(result == -1)
        ws.write("NO" + "\n");
    else
        ws.write(result + "\n");

    ws.end();
}