//https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem
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

function jumpingOnClouds(c, k) {
    var energy = 100;
    var i = k;

    while(true){

       if(i == c.length || c[i] == 1)
           energy -= 2;
        
        energy--;

        if(i == 0 || i == c.length)
           break;
        
        i += k;
        
        if(i >= c.length)
           i -= c.length;
    }

    return energy;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const nk = readLine().split(' ');

    const n = parseInt(nk[0], 10);

    const k = parseInt(nk[1], 10);

    const c = readLine().split(' ').map(cTemp => parseInt(cTemp, 10));

    let result = jumpingOnClouds(c, k);

    ws.write(result + "\n");

    ws.end();
}