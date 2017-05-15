// chart docs @ http://www.chartjs.org/docs/

$(function () {
    var dataloaded = $.Event("dataloaded")
    var ctx = document.getElementById("chartarea");

    var data = {
        labels: [],
        datasets: []
    }

    var options = {
        animation: false,
        responsive: true
    }; 
    
    setInterval(function () {
        $.ajax({
            url: "/api/chartdata/1"
        }).done(function (dataSet) {           
            new Chart(ctx, {
                type: 'line',
                data: dataSet,
                options: options
            });
        });
    }, 2000);
});