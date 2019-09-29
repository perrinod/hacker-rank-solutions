//https://www.hackerrank.com/challenges/insertionsort1/problem
'use strict';

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

function insertionSort1(n, arr) {
    var insertValue = arr[n - 1];
    var j = n - 2;

    while(j >= 0){
        if(insertValue < arr[j])
            arr[j + 1] = arr[j];
        else
            break;

        j--;
        console.log(arr.join(" "));
    }

    arr[j + 1] = insertValue;
    console.log(arr.join(" "));

}

function main() {
    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    insertionSort1(n, arr);
}
