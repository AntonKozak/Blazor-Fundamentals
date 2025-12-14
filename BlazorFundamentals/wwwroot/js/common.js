window.showToastr = function (type, message, title) {
    if (type === 'success') {
        toastr.success(message, title);
    } else if (type === 'error') {
        toastr.error(message, title);
    } else if (type === 'info') {
        toastr.info(message, title);
    } else if (type === 'warning') {
        toastr.warning(message, title);
    }
}


window.showSwal = function (type, message) {
    if (type === 'success') {
        Swal.fire({title: "Good job!", text: message, icon: "success"});
    } else if (type === 'error') {
        Swal.fire({title: "Error!", text: message, icon: "error"});
    } else if (type === 'info') {
        Swal.fire({title: "Info!", text: message, icon: "info"});
    } else if (type === 'warning') {
        Swal.fire({title: "Warning!", text: message, icon: "warning"});
    }
}
