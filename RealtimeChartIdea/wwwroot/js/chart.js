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
    
    //var myChart = new Chart(ctx, {
    //    type: 'line',
    //    data: data,
    //    options: options
    //})

    setInterval(function () {
        $.ajax({
            url: "/api/chartdata/1"
        }).done(function (dataSet) {

            // initialize
            if (this.data == null) {
                this.data = { datasets: [] }
            }

            // Static bar graph operation.
            //data.labels = dataSet.labels;
            //data.datasets[0].data = dataSet.values;

            // progressive line graph.
            var length = dataSet.values.length;

            for (var i = 0; i < length; i++) {

                if (this.data.datasets.length < i) {
                    this.data.datasets.push({ data: [dataSet.values[i]] });
                } else {
                    this.data.datasets[i].data.push(dataSet.values[i]);
                }

                
                
                //data.datasets[i].data.push(dataSet.values[i]);
                //data.datasets[i].data.shift();
            }
            
            new Chart(ctx, {
                type: 'line',
                data: this.data,
                options: options
            });
        });
    }, 2000);
});