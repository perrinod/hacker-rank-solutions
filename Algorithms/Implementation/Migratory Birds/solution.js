//https://www.hackerrank.com/challenges/migratory-birds/problem
'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function migratoryBirds(arr) {
        var birds = new Array(5).fill(0);

        for(var i = 0; i < arr.length; i++){
            birds[arr[i]-1]++;
        }

        var highest, index;
        highest = index = 0;

        for(var i = 0; i < birds.length; i++){
            if(highest < birds[i]){
                highest = birds[i];
                index = i + 1;
            }
        }
    
        return index;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const arrCount = parseInt(readLine().trim(), 10);

    const arr = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));

    const result = migratoryBirds(arr);

    ws.write(result + '\n');

    ws.end();
}