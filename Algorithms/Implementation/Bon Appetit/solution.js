//https://www.hackerrank.com/challenges/bon-appetit/problem
'use strict';

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

function sum(bill){
    var sum = 0;
    for(var i = 0; i < bill.length; i++)
        sum += bill[i];

    return sum;
}

function bonAppetit(bill, k, b) {

    var total = (sum(bill) - bill[k]) / 2;
    var output = (total == b) ? "Bon Appetit" : (b - total);

    console.log(output);

}

function main() {
    const nk = readLine().replace(/\s+$/g, '').split(' ');

    const n = parseInt(nk[0], 10);

    const k = parseInt(nk[1], 10);

    const bill = readLine().replace(/\s+$/g, '').split(' ').map(billTemp => parseInt(billTemp, 10));

    const b = parseInt(readLine().trim(), 10);

    bonAppetit(bill, k, b);
}
