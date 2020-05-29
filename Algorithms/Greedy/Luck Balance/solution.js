// https://www.hackerrank.com/challenges/luck-balance/problem
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

function luckBalance(k, contests) {
    var luck = 0;
    contests.sort(function(a,b){ return a[0]-b[0]; });

    for(var i = contests.length - 1; i >= 0; i--){
        if(contests[i][1] == 1){
            if(k > 0){
                luck += contests[i][0];
                k--;
            }
            else
                luck -= contests[i][0];
        }
        else
            luck += contests[i][0];
    }

    return luck;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const nk = readLine().split(' ');

    const n = parseInt(nk[0], 10);

    const k = parseInt(nk[1], 10);

    let contests = Array(n);

    for (let i = 0; i < n; i++) {
        contests[i] = readLine().split(' ').map(contestsTemp => parseInt(contestsTemp, 10));
    }

    const result = luckBalance(k, contests);

    ws.write(result + '\n');

    ws.end();
}
