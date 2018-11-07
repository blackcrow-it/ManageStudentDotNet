$(document).ready(function() {
    $(".btnDeleteClick").click(function () {
        const currentBtn = $(this);
        console.log(currentBtn.attr("id"));
        if (confirm("Do you delete?")) {
            $.ajax({
                url: `/Students/Delete?rollNumber=${currentBtn.attr("id")}`,
                method: "DELETE",
                success: function (data) {
                    console.log("Success Delete");
                    currentBtn.parent().parent().remove();
                }
            });
        }
    });
})