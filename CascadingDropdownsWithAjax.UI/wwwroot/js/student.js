$(function () {
    $("#StudentId").on("change", function () {
        var studentId = $(this).val();
        $("#CourseId").empty();
        $("#CourseId").append("<option value=''>Select Course</option>");
        $.getJSON(`?handler=Courses&studentId=${studentId}`, (data) => {
            $.each(data, function (i, item) {
                $("#CourseId").append(`<option value="${item.courseId}">${item.courseName}</option>`);
            });
        });
    });
});