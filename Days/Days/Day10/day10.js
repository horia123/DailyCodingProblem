console.log('Job scheduler which takes in a function f and an integer n, and calls f after n milliseconds');

function printSomething(){
    console.log("Something");
}

function scheduleJob(fn, n){
    if(typeof fn !== 'function'){
        console.log("Fn argument MUST be a function.");
    }
    if(typeof n !== 'number'){
        console.log("Second argument MUST be a number.");
    }

    setTimeout(fn, n);
}

scheduleJob(printSomething, 3000);