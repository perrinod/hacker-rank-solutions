//https://www.hackerrank.com/challenges/game-of-thrones/problem
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

function gameOfThrones(s) {
    s = s.split('').sort().join('');

    var palindrome = s.length % 2 == 0 ? true : false;

    for(var i = 0, j = 0; j < s.length; j++){
        if(s[i] != s[j]){
            if((j - i) % 2 != 0){
                if(palindrome)
                    return "NO";
                palindrome = true;
            }
            
            i = j;
        }
    }

    return "YES";

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const s = readLine();

    let result = gameOfThrones(s);

    ws.write(result + "\n");

    ws.end();
}
