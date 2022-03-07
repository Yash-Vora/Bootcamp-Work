//Regular Expression Declaration - Globally.
var $FNameLNameRegEx = /^([a-zA-Z]{2,20})$/;
var $FullNameRegEx = /^([a-zA-Z ]{2,40})$/;
var $BankAccountNameRegEx = /^([a-zA-Z ]{2,60})$/;
var $PasswordRegEx = /^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\w\s]).{8,12}$/;

var $EmailIdRegEx = /^\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,8}\b$/i;
var $ConNoRegEx = /^([0-9]{10})$/;
var $AgeRegEx = /^([0-9]{1,2})$/;
var $AadhaarNoRegEx = /^([0-9]{12})$/;
var $GSTNoRegEx=/^[0-9]{2}[A-Z]{5}[0-9]{4}[A-Z]{1}[1-9A-Z]{1}Z[0-9A-Z]{1}$/;
var $IndianDrivingLicenseNoRegEx = /^([A-Z]{2,3}[-/0-9]{8,13})$/;
var $IndianVehicleRegNoRegEx = /^([A-Z]{2}[0-9]{1,2}[A-Z]{1,3}[0-9]{1,4})$/;
var $PincodeRegEx = /^[1-9][0-9]{5,6}$/;
var $PANNoRegEx = /^[A-Z]{3}[ABCFGHLJPT][A-Z][0-9]{4}[A-Z]$/;
var $IFSCCodeRegEx = /^[A-Za-z]{4}0[A-Z0-9a-z]{6}$/;
var $BankAccountNoRegEx = /^([0-9]{9,18})$/;
var $PostTitleRegex =/^(.{30,300})$/;
var $PostDescRegex = /^(.{100,3000})$/;
var $LatitudeLongitude=/^(-?(?:1[0-7]|[1-9])?\d(?:\.\d{1,8})?|180(?:\.0{1,8})?)$/;

var $nameValidationFlag = false, $phoneValidationFlag = false, $addressValidationFlag = false;

// Initializing JQuery
$(document).ready(function(){
    // Name Validation
    $('#name').blur(function(){
        $('#nameValidation').empty();
        if($(this).val() == '') {
            $('#nameValidation').html('Field is mandatory...!');
        }
        else {
            if (!$(this).val().match($FNameLNameRegEx)) {
                $('#nameValidation').html('Invalid Name...!');
            }
        }
    });

    // Phone Validation
    $('#phone').blur(function(){
        $('#phoneValidation').empty();
        if($(this).val() == '') {
            $('#phoneValidation').html('Field is mandatory...!');
        }
        else {
            if (!$(this).val().match($ConNoRegEx)) {
                $('#phoneValidation').html('Invalid Phone Number...!');
            }
        }
    });

    // Address Validation
    $('#address').blur(function(){
        $('#addressValidation').empty();
        if($(this).val() == '') {
            $('#addressValidation').html('Field is mandatory...!');
        }
        else {
            if ($(this).val().length >= 5000) {
                $('#addressValidation').html('Address cannot be more then 5000 characters...!');
            }
        }
    });

    // Name Validation on Keypress
    $('#name').keypress(function(e){
        $('#nameValidation').empty();
        var flag = false;
        var ascciValue = parseInt(e.which);
        if((ascciValue>=65 && ascciValue<=90) || (ascciValue>=97 && ascciValue<=122)) {
            flag = true;
        }
        else {
            $('#nameValidation').html('Invalid Input...!');
        }
        return flag;
    });

    // Phone Number Validation on Keypress
    $('#phone').keypress(function(e){
        $('#phoneValidation').empty();
        var flag = false;
        var ascciValue = parseInt(e.which);
        if(ascciValue>=48 && ascciValue<=57) {
            flag = true;
        }
        else {
            $('#phoneValidation').html('Invalid Input...!');
        }
        return flag;
    });

    // All Field Validation when Submit button is clicked
    $('#btn').click(function(){
        // Name Validation
        $nameValidationFlag = false;
        $('#nameValidation').empty();
        if($('#name').val() == '') {
            $('#nameValidation').html('Field is mandatory...!');
        }
        else {
            if (!$('#name').val().match($FNameLNameRegEx)) {
                $('#nameValidation').html('Invalid Name...!');
            }
            else {
                $nameValidationFlag = true;
            }
        }

        // Phone Validation
        $phoneValidationFlag = false;
        $('#phoneValidation').empty();
        if($('#phone').val() == '') {
            $('#phoneValidation').html('Field is mandatory...!');
        }
        else {
            if (!$('#phone').val().match($ConNoRegEx)) {
                $('#phoneValidation').html('Invalid Phone Number...!');
            }
            else {
                $phoneValidationFlag = true;
            }
        }

        // Address Validation
        $addressValidationFlag = false;
        $('#addressValidation').empty();
        if($('#address').val() == '') {
            $('#addressValidation').html('Field is mandatory...!');
        }
        else {
            if ($('#address').val().length >= 5000) {
                $('#addressValidation').html('Address cannot be more then 5000 characters...!');
            }
            else {
                $addressValidationFlag = true;
            }
        }

        if ($nameValidationFlag == true && $phoneValidationFlag == true && $addressValidationFlag == true) {
            alert('Form Submitted Successfully...!');
        }
    });
});