//https://www.hackerrank.com/challenges/plus-minus/problem
'use strict';

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

function plusMinus(arr) {

    var positive, negative, zero;
    positive = negative = zero = 0;
    for(var i = 0; i < arr.length; i++){
        if(arr[i] > 0) positive++;
        else if(arr[i] < 0) negative++;
        else zero++;
    }

    console.log(positive / arr.length + "\n" + negative /arr.length + "\n" + zero / arr.length);

}

function main() {
    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    plusMinus(arr);
}
