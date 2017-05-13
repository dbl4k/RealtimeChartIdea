// live data help http://jsbin.com/yitep/5/edit?html,js,output

$(function () {
    var ctx = document.getElementById("myChart");

    data = {
        labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"],
        datasets: [{
            data: [12, 19, 3, 5, 2, 3],
        }],
    }

    options = {
        animation: false,
        responsive: true, 
        yAxes: [{
            display: true,
            ticks: {
                beginAtZero: true,
                steps: 10,
                stepValue: 5,
                max: 10
            }
        }]
    }; 

    var myChart = new Chart(ctx, {
        type: 'bar',
        data: data,
        options: options
    })

    setInterval(function () {
        $.ajax({
            url: "/api/chartdata/1"
        }).done(function (dataSet) {

            data.labels = dataSet.labels;
            data.datasets[0].data = dataSet.values;
        
            new Chart(ctx, {
                type: 'bar',
                data: data,
                options: options
            });
        });
    }, 2000);
});