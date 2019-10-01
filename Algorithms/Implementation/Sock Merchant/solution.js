//https://www.hackerrank.com/challenges/sock-merchant/problem
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

function addPair(dict, myKey, myValue) {
    dict[myKey] = myValue;
};

function getValue(dict, myKey) {
    return dict[myKey];
};

function sockMerchant(n, ar) {
    var dict = {};

    for(var i = 0; i < ar.length; i++){
        if(dict.hasOwnProperty(ar[i]))
            addPair(dict, ar[i], getValue(dict, ar[i]) + 1);
        else   
            addPair(dict, ar[i], 1);
    }

    var pairs = 0;
    for (var key in dict){
        pairs += Math.floor(getValue(dict, key) / 2);
    }

    return pairs;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const ar = readLine().split(' ').map(arTemp => parseInt(arTemp, 10));

    let result = sockMerchant(n, ar);

    ws.write(result + "\n");

    ws.end();
}