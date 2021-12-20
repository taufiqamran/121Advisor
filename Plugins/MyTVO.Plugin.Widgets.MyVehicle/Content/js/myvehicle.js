$(document).ready(function () {

    $('.input-images').imageUploader({
        label: 'Drag your file here, or select file',
        imagesInputName: 'logo',
        maxFiles: 1,
        extensions: ['.jpg', '.jpeg', '.png', '.JPG', '.JPEG', '.PNG']
    });

});


+function ($) {
    'use strict';
    if ('undefined' == typeof (jQuery)) {
        throw new Error('jQuery JS required');
    }
    function vehicleTypeSelectHandler() {
        var $this = $(this);
        var selectedItem = $this.val();
        var vehicleBrand = $($this.data('vehiclebrand'));
        var loading = $($this.data('loading'));
        loading.show();
        $.ajax({
            cache: false,
            type: "GET",
            url: $this.data('url'),
            data: {
                'vehicleType': selectedItem
            },
            success: function (data, textStatus, jqXHR) {
                vehicleBrand.html('');
                $.each(data,
                    function (id, option) {
                        vehicleBrand.append($('<option></option>').val(option).html(option));
                    });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert('Failed to retrieve states.');
            },
            complete: function (jqXHR, textStatus) {

                loading.hide();
            }
        });
    }
    function vehicleBrandSelectHandler() {
        var $this = $(this);
        var selectedItem = $this.val();
        var vehicleTypeSelectedVal = $($this.data('vehicletypeselected')).val();
        var vehicleModel = $($this.data('vehiclemodel'));
        var loading = $($this.data('loading'));
        loading.show();
        $.ajax({
            cache: false,
            type: "GET",
            url: $this.data('url'),
            data: {
                'vehicleType': vehicleTypeSelectedVal,
                'vehicleBrand': selectedItem
            },
            success: function (data, textStatus, jqXHR) {
                vehicleModel.html('');
                $.each(data,
                    function (id, option) {
                        vehicleModel.append($('<option></option>').val(option).html(option));
                    });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert('Failed to retrieve states.');
            },
            complete: function (jqXHR, textStatus) {

                loading.hide();
            }
        });
    }
    function vehicleModelSelectHandler() {
        var $this = $(this);
        var selectedItem = $this.val();
        var vehicleTypeSelectedVal = $($this.data('vehicletypeselected')).val();
        var vehicleBrandSelectedVal = $($this.data('vehiclebrandselected')).val();
        var vehicleSeries = $($this.data('vehicleseries'));
        var loading = $($this.data('loading'));
        loading.show();
        $.ajax({
            cache: false,
            type: "GET",
            url: $this.data('url'),
            data: {
                'vehicleType': vehicleTypeSelectedVal,
                'vehicleBrand': vehicleBrandSelectedVal,
                'vehicleModel': selectedItem
            },
            success: function (data, textStatus, jqXHR) {
                vehicleSeries.html('');
                $.each(data,
                    function (id, option) {
                        vehicleSeries.append($('<option></option>').val(option).html(option));
                    });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert('Failed to retrieve states.');
            },
            complete: function (jqXHR, textStatus) {

                loading.hide();
            }
        });
    }

    if ($(document).has('[data-trigger="vehicleType-select"]')) {
        $('select[data-trigger="vehicleType-select"]').change(vehicleTypeSelectHandler);
    }
    if ($(document).has('[data-trigger="vehicleBrand-select"]')) {
        $('select[data-trigger="vehicleBrand-select"]').change(vehicleBrandSelectHandler);
    }
    if ($(document).has('[data-trigger="vehicleModel-select"]')) {
        $('select[data-trigger="vehicleModel-select"]').change(vehicleModelSelectHandler);
    }
    //$.fn.countrySelect = function () {
    //    this.each(function () {
    //        $(this).change(vehicleTypeSelectHandler);
    //    });
    //}
}(jQuery); 