const searchbar = $('#searchInput');
const table = $('table');

searchbar.on('keyup', function (event) {
    var searchValue = searchbar.val();
    $.ajax({
        url: '/Employee/Search',
        type: 'Get',
        data: { searchInput: searchValue },
        success: function (result) {
            table.html(result);
        },
        error: function (xhr, status, error) {
            console.log(error)
        }
    })
})