// https://www.hackerrank.com/challenges/sherlock-and-array/problem
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

function balancedSums(arr) {
        var sum = arr.reduce((a,b) => a + b, 0);

        if(sum == arr[0])
            return "YES";

        var total = arr[0];

        for(var i = 1; i < arr.length; i++){
            if(total == sum - arr[i] - total || sum - arr[i] == 0)
                return "YES";

            total += arr[i];
        }

        return "NO";
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const T = parseInt(readLine().trim(), 10);

    for (let TItr = 0; TItr < T; TItr++) {
        const n = parseInt(readLine().trim(), 10);

        const arr = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));

        const result = balancedSums(arr);

        ws.write(result + '\n');
    }

    ws.end();
}