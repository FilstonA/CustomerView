var dataTable

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Customer/GetAll"
        },
        "columns": [
            { "data": "title", "width": "15%" },
            { "data": "forename", "width": "15%" },
            { "data": "surname", "width": "15%" },
            { "data": "dateOfBirth", "width": "15%" },
            { "data": "email", "width": "15%" },
            { "data": "status", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                                <div class="text-black">
                                    <a href="/Admin/Customer/Upsert/${data}" class="btn btn-success text-white" style="cursor:pointer"><i class="fas fa-edit"></i></a>
                                    <a class="btn btn-danger text-white" style="cursor:pointer"><i class="fas fa-trash-alt"></i></a>
                                </div>
                            `;
                }, "width": "10%"
            }
        ]
    });
}