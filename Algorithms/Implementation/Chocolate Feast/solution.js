//https://www.hackerrank.com/challenges/chocolate-feast/problem
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

function chocolateFeast(n, c, m) {
    var chocolate = Math.floor(n / c), wrappers = chocolate;

    while(wrappers >= m){
        var extra = Math.floor(wrappers / m);
        chocolate += extra;
        wrappers = extra + wrappers % m;
    }

    return chocolate;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const t = parseInt(readLine(), 10);

    for (let tItr = 0; tItr < t; tItr++) {
        const ncm = readLine().split(' ');

        const n = parseInt(ncm[0], 10);

        const c = parseInt(ncm[1], 10);

        const m = parseInt(ncm[2], 10);

        let result = chocolateFeast(n, c, m);

        ws.write(result + "\n");
    }

    ws.end();
}
