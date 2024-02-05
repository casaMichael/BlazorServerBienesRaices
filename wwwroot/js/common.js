window.onload;

window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "Operacion correcta", { timeOut: 1000 });
    }
    if (type === "error") {
        toastr.error(message, "Operacion fallida", { timeOut: 1000 });
    }
}

window.SweetAlert = (type, message) => {
    if (type === "success") {
        Swal.fire
        (
            'Success Notification',
            message,
            'success'
        );
    }
    if (type === "error") {
        Swal.fire
            (
                'Error Notification',
                message,
                'error'
            );
    }
}