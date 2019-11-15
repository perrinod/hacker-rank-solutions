//https://www.hackerrank.com/challenges/js10-loops/problem
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

function vowelsAndConsonants(s) {
    const vowels = "aeiou";
    var constonants = "";

    for(var letter of s){
        if(vowels.includes(letter))
            console.log(letter);
        else
            constonants += letter + '\n';
    }

    console.log(constonants);
}


function main() {
    const s = readLine();
    
    vowelsAndConsonants(s);
}