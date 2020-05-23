// https://www.hackerrank.com/challenges/strong-password/problem
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

function minimumNumber(n, password) {
        var count = 0;
        const lowerCase = RegExp(".*[a-z].*");
        const upperCase = RegExp(".*[A-Z].*");
        const digit = RegExp(".*[0-9].*");
        const specialCharacter = RegExp("^[a-zA-Z0-9]*$");

        if(!lowerCase.test(password))
            count++;
        if(!upperCase.test(password))
            count++;
        if(!digit.test(password))
            count++;
        if(specialCharacter.test(password))
            count++;

        return Math.max(count, 6 - n);

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const password = readLine();

    let answer = minimumNumber(n, password);

    ws.write(answer + "\n");

    ws.end();
}