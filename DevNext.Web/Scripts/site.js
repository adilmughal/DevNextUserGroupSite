/// <reference path="_references.js"/>
function onEventFormReady() {
    $('.datepicker').datepicker({ dateFormat: "mm/dd/yy" });
}


function IsVirtualEventClick() {
    if ($('#IsVirtualEvent').is(':checked')) {
        $('#locationDiv input, #locationDiv select').addClass('uneditable-input').attr('readonly', 'readonly').attr('disabled', 'disabled');
        $('#locationDiv').hide();
    } else {
        $('#locationDiv input,#locationDiv select').removeClass('uneditable-input').removeAttr('readonly').removeAttr('disabled');
        $('#locationDiv').show();
    }
}

function validateEventForm(form) {
    var isValid = true;

    $('#StartDateTime').val($('#StartDate').val() + ' ' + $('#StartTime option:selected').val());
    $('#EndDateTime').val($('#EndDate').val() + ' ' + $('#EndTime option:selected').val());
    
    var startDate = new Date($('#StartDateTime').val());
    var endDate = new Date($('#EndDateTime').val());
    if (startDate > endDate)
        isValid = false;
    return isValid;
}

