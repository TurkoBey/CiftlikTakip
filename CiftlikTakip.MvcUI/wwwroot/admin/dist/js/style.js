$(document).ready(function () {

    $("#btnLogIn").click(function () {
        var btnLogIn = $(this);
        btnLogIn.text('Giriş Yapılıyor...');
        var formDataObject =
        {
            Email: $("#email").val(),
            Password: $("#password").val()
        };

        $.ajax({
            url: "/admin/Authentication/LogIn",
            method: "post",
            dataType: "json",
            data: { dto: formDataObject },
            success: function (response) {
                var message, icon;

                if (response.isSuccess) {
                    message = 'Giriş Başarılı';
                    icon = 'success';
                } else {
                    message = 'Giriş Başarısız';
                    icon = 'error';
                }

                var content = response.message;

                if (response.errorMessages && response.errorMessages.length > 0) {
                    content += "<br>" + response.errorMessages.join("<br>");
                }

                if (response.isSuccess) {
                    toastr.success(message)
                    setInterval(function () {
                        window.location.href = "/admin/Home/Index"; // Yönlendirmek istediğiniz adresi buraya ekleyin
                    }, 1500);// Yönlendirmek geçikme süresi ( 1000 = 1sn )
                } else {
                    toastr.error(message)
                }
            },
            complete: function () {
                btnLogIn.text('Giriş Yap'); // İşlem tamamlandığında butonun metnini geri al
            }
        });
    });

    $(".btnDelete").click(function () {
        var id = $(this).attr("vId");
        var title = $(this).attr("itemTitle");
        var url = $(this).attr("url");
        Swal.fire({
            title: 'Emin misiniz?',
            html: `${title}<br>${id}<br>id değerini silmek istediğinize emin misiniz?`,
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
    });

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
                        performEdit(response, id);
                        $("#eId").val(id);
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
    
    $("#btnExit").click(function () {
        Swal.fire({
            title: 'Çıkış yapmak istediğinizden emin misiniz?',
            text: "Bu işlemi geri alamayacaksınız!",
            icon: 'information',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: "İptal",
            confirmButtonText: 'Çıkış Yap'
        }).then((result) => {
            if (result.isConfirmed) {
                // Kullanıcı "Çıkış Yap" düğmesine tıkladığında AJAX isteği gönder ve ASP.NET Session'ı kaldır
                $.ajax({
                    url: "/admin/Authentication/Logout", // Çıkış yapılacak URL'yi buraya girin
                    method: "POST", // Gerekli metodunuza uygun olarak burayı "GET" veya "POST" olarak değiştirebilirsiniz
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
                                window.location.href = "/admin"; // Yönlendirmek istediğiniz adresi buraya ekleyin
                            }
                        });
                    },
                    error: function (error) {
                        console.error("Hata:", error);
                        Swal.fire('Hata!', 'Çıkış işlemi sırasında bir hata oluştu.', 'error');
                    }
                });
            }
        });
    });

    $("#btnNew").click(function () {
        var h4Element = document.getElementById("myH4");
        h4Element.textContent = "Yeni Kartı";
    });

    $("#btnSave").click(function () {
        //$("#btnClearAddMovie").trigger("click");
        alert("sadddd")
        performAdd();
    });

    $(".btnUpdate").click(function () {
        performAddOrUpdate();
    });

    $(".btnShow").click(function () {
        var id = $(this).attr("vId");
        var url = $(this).attr("url");

        $.ajax({
            url: url + `${id}`,
            method: "POST",
            dataType: "json",
            success: function (response) {
                performShow(response, id);
                $("#gmodal-lg").modal("show");
            },
            error: function (error) {
                console.error("Hata:", error);
                Swal.fire('Hata!', 'Veriyi getirme işlemi sırasında bir hata oluştu.', 'error');
            }
        });
    });
});
