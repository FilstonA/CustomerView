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
            { "data": "title", "width": "5%" },
            { "data": "forename", "width": "5%" },
            { "data": "surname", "width": "5%" },
            { "data": "dateOfBirth", "width": "10%" },
            { "data": "email", "width": "5%" },
            { "data": "status", "width": "5%" },
            { "data": "isMarketingAllowed", "width": "5%" },
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