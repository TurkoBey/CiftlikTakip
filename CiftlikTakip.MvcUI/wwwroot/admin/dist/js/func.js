function performSave(formData, url) {
    Swal.fire({
        title: 'Emin misiniz?',
        html: `değerini eklemek istediğinize emin misiniz?`,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Evet',
        cancelButtonText: 'Vazgeç!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                method: "POST",
                dataType: "json",
                contentType: false,
                processData: false,
                data: formData,
                success: function (response) {
                    var message = response.isSuccess ? 'İşlem Başarılı' : 'İşlem Başarısız';
                    var content = response.message;

                    if (response.errorMessages && response.errorMessages.length > 0) {
                        content += "<br>" + response.errorMessages.join("<br>");
                    }

                    Swal.fire({
                        title: message,
                        html: content,
                        icon: response.isSuccess ? 'success' : 'error'
                    }).then((result) => {
                        if (response.isSuccess) {
                            location.reload(); // Sayfayı yenile
                        }
                    });
                },
                error: function (error) {
                    console.error("Hata:", error);
                    Swal.fire('Hata!', 'Silme işlemi sırasında bir hata oluştu.', 'error');
                }
            });
        }
    });
}

$(".btnEdit").click(function () {
    var id = $(this).attr("vId");
    var url = $(this).attr("url");
    Swal.fire({
        title: 'Güncelleme yapmak istermisiniz?',
        html: `${id}<br>id değerini güncellenmek istediğinize emin misiniz?`,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Evet',
        cancelButtonText: 'Vazgeç!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url + `${id}`,
                method: "POST",
                dataType: "json",
                success: function (response) {
                    performEdit(response);
                    $("#modal-lg").modal("show");
                },
                error: function (error) {
                    console.error("Hata:", error);
                    Swal.fire('Hata!', 'Veriyi getirme işlemi sırasında bir hata oluştu.', 'error');
                }
            });
        }
    });
});

$("#btnWebInfoSave").click(function (event) {
    var id = $("#eId").val();
    var tSiteBaslik = $("#txtSiteBaslik").val();
    var tCopyright = $("#txtCopyright").val();
    var tgsm = $("#txtgsm").val();
    var tSabitNo = $("#txtSabitNo").val();
    var teMail = $("#txteMail").val();
    var tAdres = $("#txtAdres").val();
    var tMapLink = $("#txtMapLink").val();

    if (tSiteBaslik != null) {
        var formData = new FormData();
        formData.append("id", id);
        formData.append("siteName", tSiteBaslik);
        formData.append("copyright", tCopyright);
        formData.append("phoneNumber", tSabitNo);
        formData.append("mobileNumber", tgsm);
        formData.append("email", teMail);
        formData.append("address", tAdres);
        formData.append("googleMapsLink", tMapLink);

        Swal.fire({
            title: 'Emin misiniz?',
            html: `${tSiteBaslik} değerini eklemek istediğinize emin misiniz?`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç!'
        }).then((result) => {
            if (result.isConfirmed) {
                console.log("sdadsadad" + result.isConfirmed)
                $.ajax({
                    url: "/admin/WebsiteInfo/AddOrUpdate",
                    method: "POST",
                    dataType: "json",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (response) {
                        var message = response.isSuccess ? 'İşlem Başarılı' : 'İşlem Başarısız';
                        var content = response.message;

                        if (response.errorMessages && response.errorMessages.length > 0) {
                            content += "<br>" + response.errorMessages.join("<br>");
                        }

                        Swal.fire({
                            title: message,
                            html: content,
                            icon: response.isSuccess ? 'success' : 'error'
                        }).then((result) => {
                            if (response.isSuccess) {
                                location.reload(); // Sayfayı yenile
                            }
                        });
                    },
                    error: function (error) {
                        console.error("Hata:", error);
                        Swal.fire('Hata!', 'Ekleme işlemi sırasında bir hata oluştu.', 'error');
                    }
                });
            }
        });
    } else {
        alert("asddsadsadasdasdsadasdaddsda")
    }
});

$("#btnNewTeamUser").click(function () {
    var id = $("#eId").val();
    var file = $("#photo").get(0).files[0];
    var tFullName = $("#txtFullName").val();
    var tRole = $("#txtRole").val();
    var tTwitter = $("#txtTwitter").val();
    var tFacebook = $("#txtFacebook").val();
    var tInstagram = $("#txtInstagram").val();
    var tLinkedIn = $("#txtLinkedIn").val();
    var txtDescription = $("#txtDescription").val();

    if (txtFullName != null) {
        var formData = new FormData();
        if (id !== null && id !== undefined && id !== "") {
            formData.append("id", id);
        }
        formData.append("fullName", tFullName);
        formData.append("role", tRole);
        formData.append("twitter", tTwitter);
        formData.append("facebook", tFacebook);
        formData.append("instagram", tInstagram);
        formData.append("linkedIn", tLinkedIn);
        formData.append("description", txtDescription);
        formData.append("photoPath", file);

        Swal.fire({
            title: 'Emin misiniz?',
            html: `${tFullName} değerini eklemek istediğinize emin misiniz?`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç!'
        }).then((result) => {
            if (result.isConfirmed) {
                console.log("sdadsadad" + result.isConfirmed)
                $.ajax({
                    url: "/admin/FTeam/AddOrUpdate",
                    method: "POST",
                    dataType: "json",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (response) {
                        var message = response.isSuccess ? 'İşlem Başarılı' : 'İşlem Başarısız';
                        var content = response.message;

                        if (response.errorMessages && response.errorMessages.length > 0) {
                            content += "<br>" + response.errorMessages.join("<br>");
                        }

                        Swal.fire({
                            title: message,
                            html: content,
                            icon: response.isSuccess ? 'success' : 'error'
                        }).then((result) => {
                            if (response.isSuccess) {
                                location.reload(); // Sayfayı yenile
                            }
                        });
                    },
                    error: function (error) {
                        console.error("Hata:", error);
                        Swal.fire('Hata!', 'Ekleme işlemi sırasında bir hata oluştu.', 'error');
                    }
                });
            }
        });
    } else {
        alert("asddsadsadasdasdsadasdaddsda")
    }
});

$("#btnNewService").click(function () {
    var id = $("#eId").val();
    var tFullName = $("#txtbaslik").val();
    var tRole = $("#txtikon").val();
    var tTwitter = $("#txtAciklama").val();


    if (tFullName != null) {
        var formData = new FormData();
        if (id !== null && id !== undefined && id !== "") {
            formData.append("id", id);
        }
        formData.append("title", tFullName);
        formData.append("icon", tRole);
        formData.append("description", tTwitter);

        Swal.fire({
            title: 'Emin misiniz?',
            html: `${tFullName} değerini eklemek istediğinize emin misiniz?`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç!'
        }).then((result) => {
            if (result.isConfirmed) {
                console.log("sdadsadad" + result.isConfirmed)
                $.ajax({
                    url: "/admin/FService/AddOrUpdate",
                    method: "POST",
                    dataType: "json",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (response) {
                        var message = response.isSuccess ? 'İşlem Başarılı' : 'İşlem Başarısız';
                        var content = response.message;

                        if (response.errorMessages && response.errorMessages.length > 0) {
                            content += "<br>" + response.errorMessages.join("<br>");
                        }

                        Swal.fire({
                            title: message,
                            html: content,
                            icon: response.isSuccess ? 'success' : 'error'
                        }).then((result) => {
                            if (response.isSuccess) {
                                location.reload(); // Sayfayı yenile
                            }
                        });
                    },
                    error: function (error) {
                        console.error("Hata:", error);
                        Swal.fire('Hata!', 'Ekleme işlemi sırasında bir hata oluştu.', 'error');
                    }
                });
            }
        });
    } else {
        alert("asddsadsadasdasdsadasdaddsda")
    }
});

$("#btnNewFaq").click(function () {
    var id = $("#eId").val();
    var tFullName = $("#txtQuestion").val();
    var tRole = $("#txtAnswer").val();


    if (tFullName != null) {
        var formData = new FormData();
        if (id !== null && id !== undefined && id !== "") {
            formData.append("id", id);
        }
        formData.append("question", tFullName);
        formData.append("answer", tRole);

        Swal.fire({
            title: 'Emin misiniz?',
            html: `${tFullName} değerini eklemek istediğinize emin misiniz?`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç!'
        }).then((result) => {
            if (result.isConfirmed) {
                console.log("sdadsadad" + result.isConfirmed)
                $.ajax({
                    url: "/admin/FFaq/AddOrUpdate",
                    method: "POST",
                    dataType: "json",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (response) {
                        var message = response.isSuccess ? 'İşlem Başarılı' : 'İşlem Başarısız';
                        var content = response.message;

                        if (response.errorMessages && response.errorMessages.length > 0) {
                            content += "<br>" + response.errorMessages.join("<br>");
                        }

                        Swal.fire({
                            title: message,
                            html: content,
                            icon: response.isSuccess ? 'success' : 'error'
                        }).then((result) => {
                            if (response.isSuccess) {
                                location.reload(); // Sayfayı yenile
                            }
                        });
                    },
                    error: function (error) {
                        console.error("Hata:", error);
                        Swal.fire('Hata!', 'Ekleme işlemi sırasında bir hata oluştu.', 'error');
                    }
                });
            }
        });
    } else {
        alert("asddsadsadasdasdsadasdaddsda")
    }
});

$("#btnNewUser").click(function () {
    var id = $("#eId").val();
    var tmail = $("#txtmail").val();
    var tadi = $("#txtadi").val();
    var tparola = $("#txtparola").val();


    if (tFullName != null) {
        var formData = new FormData();
        if (id !== null && id !== undefined && id !== "") {
            formData.append("id", id);
        }
        formData.append("email", tmail);
        formData.append("username", tadi);
        formData.append("password", tparola);

        Swal.fire({
            title: 'Emin misiniz?',
            html: `${tmail} değerini eklemek istediğinize emin misiniz?`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç!'
        }).then((result) => {
            if (result.isConfirmed) {
                console.log("sdadsadad" + result.isConfirmed)
                $.ajax({
                    url: "/admin/Authentication/AddOrUpdate",
                    method: "POST",
                    dataType: "json",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (response) {
                        var message = response.isSuccess ? 'İşlem Başarılı' : 'İşlem Başarısız';
                        var content = response.message;

                        if (response.errorMessages && response.errorMessages.length > 0) {
                            content += "<br>" + response.errorMessages.join("<br>");
                        }

                        Swal.fire({
                            title: message,
                            html: content,
                            icon: response.isSuccess ? 'success' : 'error'
                        }).then((result) => {
                            if (response.isSuccess) {
                                location.reload(); // Sayfayı yenile
                            }
                        });
                    },
                    error: function (error) {
                        console.error("Hata:", error);
                        Swal.fire('Hata!', 'Ekleme işlemi sırasında bir hata oluştu.', 'error');
                    }
                });
            }
        });
    } else {
        alert("asddsadsadasdasdsadasdaddsda")
    }
});

$("#btnNewEmployee").click(function () {
    var id = $("#eId").val();
    var image = $("#photo").get(0).files[0];
    var tTCKN = $("#txtTCKN").val();
    var tFirstName = $("#txtFirstName").val();
    var tLastName = $("#txtLastName").val();
    var tMobilePhone = $("#txtMobilePhone").val();
    var tStartDate = $("#reservationdate input").val();
    var tDescription = $("#txtDescription").val();

    if (tFirstName != null) {
        var formData = new FormData();
        if (id !== null && id !== undefined && id !== "") {
            formData.append("id", id);
        }
        formData.append("TCKN", tTCKN);
        formData.append("firstName", tFirstName);
        formData.append("lastName", tLastName);
        formData.append("mobilePhone", tMobilePhone);
        formData.append("startDate", tStartDate);
        formData.append("description", tDescription);
        formData.append("image", image);

        Swal.fire({
            title: 'Emin misiniz?',
            html: `${tFirstName} değerini eklemek istediğinize emin misiniz?`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç!'
        }).then((result) => {
            if (result.isConfirmed) {
                console.log("sdadsadad" + result.isConfirmed)
                $.ajax({
                    url: "/admin/Employee/AddOrUpdate",
                    method: "POST",
                    dataType: "json",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (response) {
                        var message = response.isSuccess ? 'İşlem Başarılı' : 'İşlem Başarısız';
                        var content = response.message;

                        if (response.errorMessages && response.errorMessages.length > 0) {
                            content += "<br>" + response.errorMessages.join("<br>");
                        }

                        Swal.fire({
                            title: message,
                            html: content,
                            icon: response.isSuccess ? 'success' : 'error'
                        }).then((result) => {
                            if (response.isSuccess) {
                                location.reload(); // Sayfayı yenile
                            }
                        });
                    },
                    error: function (error) {
                        console.error("Hata:", error);
                        Swal.fire('Hata!', 'Ekleme işlemi sırasında bir hata oluştu.', 'error');
                    }
                });
            }
        });
    } else {
        alert("asddsadsadasdasdsadasdaddsda")
    }
});
$("#btnNewStall").click(function () {
    var id = $("#eId").val();
    var tTitle = $("#txtbaslik").val();
    var tDescription = $("#txtAciklama").val();

    if (tTitle != null) {
        var formData = new FormData();
        if (id !== null && id !== undefined && id !== "") {
            formData.append("id", id);
        }
        formData.append("title", tTitle);
        formData.append("description", tDescription);

        Swal.fire({
            title: 'Emin misiniz?',
            html: `${tTitle} değerini eklemek istediğinize emin misiniz?`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç!'
        }).then((result) => {
            if (result.isConfirmed) {
                console.log("sdadsadad" + result.isConfirmed)
                $.ajax({
                    url: "/admin/AnimalStall/AddOrUpdate",
                    method: "POST",
                    dataType: "json",
                    contentType: false,
                    processData: false,
                    data: formData,
                    success: function (response) {
                        var message = response.isSuccess ? 'İşlem Başarılı' : 'İşlem Başarısız';
                        var content = response.message;

                        if (response.errorMessages && response.errorMessages.length > 0) {
                            content += "<br>" + response.errorMessages.join("<br>");
                        }

                        Swal.fire({
                            title: message,
                            html: content,
                            icon: response.isSuccess ? 'success' : 'error'
                        }).then((result) => {
                            if (response.isSuccess) {
                                location.reload(); // Sayfayı yenile
                            }
                        });
                    },
                    error: function (error) {
                        console.error("Hata:", error);
                        Swal.fire('Hata!', 'Ekleme işlemi sırasında bir hata oluştu.', 'error');
                    }
                });
            }
        });
    } else {
        alert("asddsadsadasdasdsadasdaddsda")
    }
});