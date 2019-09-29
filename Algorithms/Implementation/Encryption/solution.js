//https://www.hackerrank.com/challenges/encryption/problem
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

function encryption(s) {
        var size = s.length;
        var encrypted = "";
        var L = Math.floor(Math.sqrt(size));
        var b = (L * L >= size) ? L : L + 1;
    
        for(var i = 0; i < b; i++){
            for(var j = i; j < size;){
                encrypted = encrypted + s.charAt(j);
                j = b + j;
            }
            encrypted = encrypted + " ";
        }

        return encrypted;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const s = readLine();

    let result = encryption(s);

    ws.write(result + "\n");

    ws.end();
}