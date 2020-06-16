console.log('Compute multiplication for arr: 1, 2, 3, 4, 5');

let arr = [1, 2, 3, 4, 5];

let internalArr = [];

for(var i = 0; i < arr.length; i++){
    var product = 1;
    for(var j = 0; j < arr.length; j++){
        if(j != i){
            product = product * arr[j];
        }
    }

    internalArr.push(product);
}

internalArr.forEach(element => {
    console.log(element + " ");    
});