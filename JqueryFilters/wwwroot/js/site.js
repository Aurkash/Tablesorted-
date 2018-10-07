// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//$('table').ddTableFilter();

$(function () {
    $table = $('.tablesorter').tablesorter({
        headerTemplate: "{content} {icon}",
        cssIconNone: "glyphicon glyphicon-sort",
        cssIconAsc: "glyphicon glyphicon-chevron-up",
        cssIconDesc: "glyphicon glyphicon-chevron-down",
        cssChildRow: "tablesorter-childRow",
        headers: {
            5: { filter: false },
            6: { filter: false },
            7: { filter: false }
        },

        widgets: ["filter"],
        widgetOptions: {

            // If there are child rows in the table (rows with class name from "cssChildRow" option)
            // and this option is true and a match is found anywhere in the child row, then it will make that row
            // visible; default is false
            filter_childRows: true,

            // filter child row content by column; filter_childRows must also be true
            filter_childByColumn: false,

            filter_cssFilter: 'tablesorter-filter',

            // Set this option to false to make the searches case sensitive
            filter_ignoreCase: true,

            // jQuery selector string of an element used to reset the filters
            filter_reset: '.reset',
            
            filter_hideEmpty: true,
            // Delay in milliseconds before the filter widget starts searching; This option prevents searching for
            // every character while typing and should make searching large tables faster.
            filter_searchDelay: 300,

            // Set this option to true to use the filter to find text from the start of the column
            // So typing in "a" will find "albert" but not "frank", both have a's; default is false
            filter_startsWith: false,
            filter_external: '.search',

            //filter function for count column so that exat match is found
            filter_functions: {

                // Exact match only
                4: function (e, n, f, i, $r) {
                    return e == f;
                }

            }
        }

    });

    $checkboxes = $('.searchStatus').on('change', function () {
        var status = [],
            currentFilters = $.tablesorter.getFilters($table);
        $checkboxes.each(function () {
            if (this.checked) {
                status.push(this.value);
            }
        });
        currentFilters[7] = status.join('|');
        $.tablesorter.setFilters($table, currentFilters);
    });

    $table.find('.tablesorter-childRow').addClass('hidden');
});

