@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>HİSAR HUKUK BÜROSU</h1>
    <p class="lead">ADALET BİZİM İŞİMİZ....</p>
    <p><a href="https://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>


<div class="col-sm-6 team-card col-lg-4">
    <div class="card-wrap">
        <div class="card-box">
            <h2>AV.EMRE KIZILTAŞ</h2>
        </div>
        <img src="~/Picture/foto1.jpg" alt="">
        <div class="content-wrap">
            denemeeee

        </div>
        <p><a class="btn btn-default" @Html.ActionLink("bilgi", "About", "Home")>BİLGİ &raquo;</a></p>
    </div>
</div>
<div class="col-md-6 animate fadeInLeftBig" data-delay="100">

    <div class="team-sec team-sec1">
        <div class="col-md-4">
            <h2>AV.ABDULAHAT DİLEK</h2>
            <p>KAMU HUKUKU</p>
            <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301866">BİLGİ &raquo;</a></p>
        </div>
        </div>
    </div>
        <div class="col-md-4">
            <h2>TACETTİN ÇEVİK</h2>
            <p>İDARE HUKUK</p>
            <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">BİLGİ &raquo;</a></p>
        </div>
    </div>
    <div class="features">
        <div class="row">
            <div class="col-md-6 animate fadeInLeftBig" data-delay="100">

                <div class="team-sec team-sec1">
                    <div class="member"><img src="~/Picture/foto1.jpg" alt=""></div>
                    <div class="detail-left pull-right">
                        <h4>Av. Merve ÇETİN</h4>
                        <span>Özgeçmiş</span>
                        <p>
                            DİL:

                            Türkçe, İngilizce<br>

                            ÜYELİK:

                            İstanbul 1 No'lu Baro - Baro Numarası: 53839
                        </p>

                    </div>
                    <div class="clearfix"></div>
                </div>



            </div>


            <div class="col-md-6 animate fadeInRightBig" data-delay="100">

                <div class="team-sec team2">
                    <div class="member"><img src="imagesnew/team1.jpg" alt=""></div>
                    <div class="detail-left">
                        <h4>Av. Merve ÇETİN</h4>
                        <span>İletişim Bilgileri</span>
                        <p>
                            E-Posta:<a href="mailto:avcetinmerve@gmail.com?Subject=Web%20Sitesi%20Üzerinden" target="_top"> avcetinmerve@gmail.com</a><br>
                            İletişim:<a href="tel:+908508880180">+90 (850) 888-01-80</a> <br>
                            Adres: Cevizli Mah. Keşan Sk. No:2 D:1 Kartal/İstanbul
                        </p>

                    </div>
                    <div class="clearfix"></div>
                </div>



            </div>


        </div>
    </div>
</div>