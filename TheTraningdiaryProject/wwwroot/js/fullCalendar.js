(function () {

    $(document).ready(function () {
        $('#calendar').fullCalendar(
            {
                header: {
                    left: "prev, next, today",
                    center: "title",
                    right: "month, agendaWeek, agendaDay"
                },

                lang: "sv",
                defaulView: "month",
                editable: true,
                allDaySlot: false,
                selectable: true,
                slotMinutes: 15,

            });
    });

})();