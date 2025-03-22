const AddStudent = async (student) => {
    try {
        const result = await AjaxPOST('/Student/AddStudent', student);
        if (result.success) {
            alert('Student Added Successfuly!');
            window.location.href = '/Student/Index';
        } else {
            alert('Failed to Add Student:' + result.message);
        }
    }
        catch (error) {
        console.error('Error Adding Student: ', error);
        alert('An error occured while adding the student.');
    }
}

$(document).ready(function () {
    $('#addStudentForm').on('submit', function (e) {
        e.preventDefault();
        const student = {
            FirstName: $('#Firstname').val(),
            LastName: $('#Lastname').val(),
            Age: $('#Age').val(),
            Course: $('#Course').val()
        };
        AddStudent(student);
    });
});