//https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
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

function designerPdfViewer(h, word) {
    
    var max = 0;

    for(var i = 0; i < word.length; i++){
        if(h[(word.charAt(i)).charCodeAt(0) - 97] > max){
            max = h[(word.charAt(i)).charCodeAt(0) - 97];
        }
    }

    return max * word.length;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const h = readLine().split(' ').map(hTemp => parseInt(hTemp, 10));

    const word = readLine();

    let result = designerPdfViewer(h, word);

    ws.write(result + "\n");

    ws.end();
}
