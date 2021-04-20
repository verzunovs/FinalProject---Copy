$(document).ready(function () {

    $('button.view-cities').click(function () {
        $.ajax({
            type: 'GET',
            url: '/api/city/getall',
        }).done(function (response) {

            var container = $('div.cities-container');
            container.html('<ul>');

            response.forEach(function (city) {
                container.append(`<li>Id : ${city.Id}, Name : ${city.Name}`);
            });

            container.append('</ul>');
        }).fail(function (e) {
            alert('ERROR');
        });
    });
})
