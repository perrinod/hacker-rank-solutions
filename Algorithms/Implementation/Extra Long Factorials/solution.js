// https://www.hackerrank.com/challenges/extra-long-factorials/problem
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

function extraLongFactorials(n) {
    var factorial = BigInt(1);

    for(var i = n; i > 1; i--)
        factorial *= BigInt(i);

    console.log(factorial.toString());

}

function main() {
    const n = parseInt(readLine(), 10);

    extraLongFactorials(n);
}
