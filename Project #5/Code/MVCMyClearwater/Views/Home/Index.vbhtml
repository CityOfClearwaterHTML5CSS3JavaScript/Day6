@Code
    ViewData("Title") = "Index"
End Code

<div id="bsCarousel" class="carousel slide">
    <!-- Indicators -->
    <ol class="carousel-indicators">
        <li data-target="#bsCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#bsCarousel" data-slide-to="1"></li>
        <li data-target="#bsCarousel" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner">
        <div class="item active">
            <img src="~/assets/images/content/ClearwaterBeachBestCityBeach.png">
        </div>
        <div class="item">
            <img src="~/assets/images/content/WinterTheDolphin.png">
        </div>
        <div class="item">
            <img src="~/assets/images/content/Scientology.png">
        </div>
    </div>
    <!-- Controls -->
    <a class="left carousel-control" href="#bsCarousel" data-slide="prev">
        <i class="fa fa-angle-left fa-4x"></i>
    </a>
    <a class="right carousel-control" href="#bsCarousel" data-slide="next">
        <i class="fa fa-angle-right fa-4x"></i>
    </a>
</div>

@section scripts
    <script>console.log("from index.html");</script>
End Section