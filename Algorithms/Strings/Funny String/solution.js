//https://www.hackerrank.com/challenges/funny-string/problem
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

function funnyString(s) {
    for(var i = 0, j = s.length - 1; i < s.length - 1; i++, j--){
        if(Math.abs(s.charCodeAt(i) - s.charCodeAt(i+1)) != Math.abs(s.charCodeAt(j) - s.charCodeAt(j-1)))
            return "Not Funny";
    }

    return "Funny";

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const q = parseInt(readLine(), 10);

    for (let qItr = 0; qItr < q; qItr++) {
        const s = readLine();

        let result = funnyString(s);

        ws.write(result + "\n");
    }

    ws.end();
}
