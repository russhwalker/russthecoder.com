
//Recursion
function addTill10(num){
    console.log(num);
    if(num >= 10){
        return num;
    }
    var newNumber = num + 1;
    return addTill10(newNumber);
}
addTill10(3);