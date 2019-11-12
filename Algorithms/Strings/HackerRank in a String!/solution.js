//https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
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

function hackerrankInString(s) {
    var hackerRank = "hackerrank";
    if(s.length < hackerRank.length)
        return "NO";

    var i = 0;
    for(var c of s){
        if(hackerRank.charAt(i) == c)
            i++;
        
        if(i == hackerRank.length)
            return "YES";
    }

    return "NO";

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const q = parseInt(readLine(), 10);

    for (let qItr = 0; qItr < q; qItr++) {
        const s = readLine();

        let result = hackerrankInString(s);

        ws.write(result + "\n");
    }

    ws.end();
}
