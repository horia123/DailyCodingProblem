console.log('Finding if any two members of the array: 7, 10, 6, 8, 12, 3 are equal with k1: 17 or k2: 12');

let arr = [7, 10, 6, 8, 12, 3];
let k = 17;
let k2 = 12;
let found = false;
let found2 = false;

var valuesArr = [];

for (var i = 0; i < arr.length; i++) {
    if (valuesArr.find(e => e === k - arr[i])) {
        found = true;
    }

    if (valuesArr.find(e => e === k2 - arr[i])) {
        found2 = true;
    }

    valuesArr.push(arr[i]);
}

logFound(found, k);
logFound(found2, k2);

function logFound(found, no){ 
    if(found){
        console.log('Two such elements that add up to ' + no + ' were Found.');
    }
    else{
        console.log('Two such elements that add up to ' + no + ' were NOT Found.');
    }
}

function contains(a, obj) {
    for (var i = 0; i < a.length; i++) {
        if (a[i] === obj) {
            return true;
        }
    }
    return false;
}