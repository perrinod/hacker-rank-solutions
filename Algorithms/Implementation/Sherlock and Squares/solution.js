//https://www.hackerrank.com/challenges/sherlock-and-squares/problem
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

function squares(a, b) {
    var count = 0;

    while(a <= b){

        if(Math.sqrt(a) % 1.0 == 0){
            count++;
            a = (a >= 16) ? a + Math.floor(Math.sqrt(a)) * 2 : ++a;
        }
        else
            a++;
    }
    
    return count;


}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const q = parseInt(readLine(), 10);

    for (let qItr = 0; qItr < q; qItr++) {
        const ab = readLine().split(' ');

        const a = parseInt(ab[0], 10);

        const b = parseInt(ab[1], 10);

        let result = squares(a, b);

        ws.write(result + "\n");
    }

    ws.end();
}