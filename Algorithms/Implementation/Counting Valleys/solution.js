//https://www.hackerrank.com/challenges/counting-valleys/problem
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

function countingValleys(n, s) {
    var valley, count;
    valley = count = 0;
    var downhill = false;

    for(var i = 0; i < n; i++){
        if(s[i] == 'U')
            valley++;
        else
        {
            if(valley == 0)
                downhill = true;

            valley--;
        }
        
        if(valley == 0 && downhill){
            count++;
            downhill = !downhill;
        }
    }

    return count;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const s = readLine();

    let result = countingValleys(n, s);

    ws.write(result + "\n");

    ws.end();
}
