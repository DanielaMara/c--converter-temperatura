var ConverterService =
{
    getIndex: function (celsius, callback) {
        $.ajax({
            url: 'service/converter.aspx.cs',
            data: { 'celsius': celsius },
            success: function (result) {
                callback(parseFloat(result));
            },
            error: function () {
                callback(null);
            }
        });
    }
};