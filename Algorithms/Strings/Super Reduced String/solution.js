//https://www.hackerrank.com/challenges/reduced-string/problem
'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function superReducedString(s) {
    var i = 0;
    while(i < s.length - 1){
        if(s.charAt(i) == s.charAt(i+1)){
            s = s.substring(0,i) + s.substring(i+2);
            if(i != 0)
                i--;
        }
        else
                i++;
        }

    if(s.length == 0)
        s = "Empty String";

    return s;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const s = readLine();

    const result = superReducedString(s);

    ws.write(result + '\n');

    ws.end();
}
