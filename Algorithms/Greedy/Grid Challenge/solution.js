// https://www.hackerrank.com/challenges/grid-challenge/problem
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

function gridChallenge(grid) {
    var string = grid[0];
    grid[0] = string.split('').sort().join('');

    for(var i = 1; i < grid.length; i++){
        string = grid[i];
        grid[i] = string.split('').sort().join('');

        for(var j = 0; j < grid[i].length; j++){
            if(grid[i-1][j] > grid[i][j])
                return "NO";
        }

    }

    return "YES";

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const t = parseInt(readLine(), 10);

    for (let tItr = 0; tItr < t; tItr++) {
        const n = parseInt(readLine(), 10);

        let grid = [];

        for (let i = 0; i < n; i++) {
            const gridItem = readLine();
            grid.push(gridItem);
        }

        let result = gridChallenge(grid);

        ws.write(result + "\n");
    }

    ws.end();
}
