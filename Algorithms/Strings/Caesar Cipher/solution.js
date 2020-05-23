// https://www.hackerrank.com/challenges/caesar-cipher-1/problem
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

function caesarCipher(s, k) {
    for(var i = 0; i < s.length; i++){
        if(s.charAt(i).toUpperCase() != s.charAt(i).toLowerCase()){
            var a = s.charAt(i) == s.charAt(i).toUpperCase() ? 'A' : 'a';
            s = s.substring(0, i) + String.fromCharCode(a.charCodeAt(0) + (s.charCodeAt(i) - a.charCodeAt(0) + k) % 26) + s.substring(i + 1);
        }
    }

    return s;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    const s = readLine();

    const k = parseInt(readLine(), 10);

    let result = caesarCipher(s, k);

    ws.write(result + "\n");

    ws.end();
}
