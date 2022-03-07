function externalAlert() {
    alert('This is an external alert');
}

function externalConfirm() {
    if(confirm('Are you sure?')) {
        alert('Yess');
    }         
    else {
        alert('Noo');
    }
}

function externalPrompt() {
    var fName = prompt('Enter your first name?');
    var lName = prompt('Enter your last name?');
    alert('Welcome '+fName+' '+lName);
}