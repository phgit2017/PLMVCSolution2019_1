var UNITMANAGEMENT = (function () {
    var _variables =
    {
        params: null,
        default
    };

    var _doInitializeData = function () {
        $('#units-tables').DataTable({
            ajax: {
                url: _variables.params.getDetailsUrl,
                type: 'POST',
                dataSrc: 'data',
                contentType: 'application/json',
                dataType: 'json'
            },
            columns: [
                {
                    data: null, render: function (data, type, row) {
                        return "<a href=''>" + data.UnitId + "</a>";
                    }
                },
                { data: 'UnitId' },
                { data: 'UnitDescription' }
            ]
        });
    }

    var _doInitializeElements = function (options) {

    }

    var initialize = function (options) {
        try {
            _variables.params = options || {};
            _doInitializeData();
            _doInitializeElements();
        }
        catch (e) {
            if (typeof console !== "undefined" && console !== null) {
                console.error("Error parsing inline options", ex);
            }
        }
    }

    return {
        initialize: initialize,
        _variables: _variables
    }
})();

$(document).ready(function () {
    var options = window.adminOptions;
    UNITMANAGEMENT.initialize(options);

    
});