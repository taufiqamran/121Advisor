function changeInput() {
    var tesdd = document.getElementById('mata');

    if (tesdd != null) {
        var selectedValue = tesdd.value;
        console.log(selectedValue);

        if (selectedValue == "Insurance") {
            $("#mimi").showElement();
            $("#momo").showElement();

        } else if (selectedValue == "Driving") {
            $("#momo").showElement();
            $("#mimi").hideElement();
            $("#numbee").hideElement();
        } else if (selectedValue == "JPJ") {
            $("#momo").hideElement();
            $("#mimi").hideElement();
            $("#numbee").showElement();
        } else {

        }

    }

}

//this method is used to show an element by removing the appropriate hiding class
//we don't use the jquery show/hide methods since they don't work with "display: flex" properly
$.fn.showElement = function () {
    this.removeClass('d-none');
}

//this method is used to hide an element by adding the appropriate hiding class
//we don't use the jquery show/hide methods since they don't work with "display: flex" properly
$.fn.hideElement = function () {
    this.addClass('d-none');
}
