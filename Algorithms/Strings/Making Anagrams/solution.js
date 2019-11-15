//https://www.hackerrank.com/challenges/making-anagrams/problem
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

function makingAnagrams(s1, s2) {
    var count = 0;

    for(var letter of s1){
            var found = s2.indexOf(letter);
            if(found != -1){
                s2 = s2.substring(0, found) + s2.substring(found + 1, s2.length);
                count++;
            }
    }

    return s1.length - count + s2.length;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const s1 = readLine();

    const s2 = readLine();

    let result = makingAnagrams(s1, s2);

    ws.write(result + "\n");

    ws.end();
}
