//https://www.hackerrank.com/challenges/js10-bitwise
'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function getMaxLessThanK(n, k){
    var max = 0;
    for(var i = 1, j = 2; j <= n && i <= n - 1; j++){
        if((i & j) > max && (i & j) < k)
            max = (i & j);
        if(j == n){
            i++;
            j = i;
        }
    }

    return max;
}

function main() {
    const q = +(readLine());
    
    for (let i = 0; i < q; i++) {
        const [n, k] = readLine().split(' ').map(Number);
        
        console.log(getMaxLessThanK(n, k));
    }
}