//https://www.hackerrank.com/challenges/countingsort2/problem
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

function countingSort(arr) {
    var count = new Array(100).fill(0);
    for(var i = 0; i < arr.length; i++)
        count[arr[i]]+= 1;

    var sum = 0;
    for(var i = 0; i < count.length; i++){
        var temp = count[i];
        count[i] = sum;
        sum += temp;
    }

    var output = new Array(arr.length);

    for(var i = 0; i < arr.length; i++){
        output[count[arr[i]]] = arr[i];
        count[arr[i]] += 1;
    }

    return output;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    let result = countingSort(arr);

    ws.write(result.join(" ") + "\n");

    ws.end();
}
