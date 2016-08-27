// Write your Javascript code.
// Write your Javascript code.

// En annonym funtion som med hjälp av (); executes direkt.

(function () {

    //var ele = $("#username");
    //ele.text("Johan Lasse Öhberg");

    //var m = $("#main");
    //m.on("mouseenter", function () {
    //    m.style = "background-color: #888;";
    //});

    //m.on("mouseleave", function () {
    //    m.style = "";
    //});

    //var menuItems = $("ul.menu li a");
    //menuItems.on("click", function () {

    //    var me = $(this);
    //    alert(me.text());
    //});

    var $sidebarAndWrapper = $("#sidebar, #wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");

        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
        else {
            $icon.addClass("fa-angle-left");
            $icon.removeClass("fa-angle-right");
        }
    });

    $(document).ready(function () {
        $('#calendar').fullCalendar(
            {
                header: {
                    left: "Prev,next today",
                    center: "title",
                    right: "month, agendaWeek, agendaDay"
                },

                defaulView: "agendaDay",
                editable: true,
                allDaySlot: false,
                selectable: true,
                slotMinutes: 15,

            });
    });

})();