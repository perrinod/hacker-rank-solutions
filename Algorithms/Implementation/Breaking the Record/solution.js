//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
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


function breakingRecords(scores) {
    var highest, lowest, highTotal, lowTotal;
    highest = lowest = scores[0];
    highTotal = lowTotal = 0;
    for(var i = 0; i < scores.length; i++){
        if(highest < scores[i]){
            highest = scores[i];
            highTotal++;
        }
        if(lowest > scores[i]){
            lowest = scores[i];
            lowTotal++;
        }
    }

    return new Array (highTotal, lowTotal);

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const scores = readLine().split(' ').map(scoresTemp => parseInt(scoresTemp, 10));

    const result = breakingRecords(scores);

    ws.write(result.join(' ') + '\n');

    ws.end();
}
