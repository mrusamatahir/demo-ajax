function AddRow() {
    tbody = $('#tBody');
    var row = '<tr>'
        + '<td><input class="Name form-control form-control-sm type="text" ></td>'
        + '<td><input class="Reg form-control form-control-sm type="text" ></td>'
        + '<td><input type="file" class="img" multiple /></td>'
        + '<td><button id="addRowBtn" type="button" class="btn btn-info">Add New Row</button></td>'
        + '</tr>';
    tbody.append(row);
}

$('#tBody').on('click', '#addRowBtn', function () {
    AddRow();
    var rowCount = $('#tBody tr').length;
})