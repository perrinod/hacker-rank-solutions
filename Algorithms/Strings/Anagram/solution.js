//https://www.hackerrank.com/challenges/anagram/problem
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

function anagram(s) {
    if(s.length % 2 != 0)
        return -1;
    
    var s1 = s.substring(0, s.length / 2);
    var s2 = s.substring(s.length / 2, s.length);

    var count = 0;

    for(var letter of s1){
        var found = s2.indexOf(letter);
        if(found != -1)
            s2 = s2.substring(0, found) + s2.substring(found + 1, s2.length);
        else
            count++;

    }

    return count;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const q = parseInt(readLine(), 10);

    for (let qItr = 0; qItr < q; qItr++) {
        const s = readLine();

        let result = anagram(s);

        ws.write(result + "\n");
    }

    ws.end();
}
