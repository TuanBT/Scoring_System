var idName = ["matchCount", "time", "weight", "sex", "typeMatch", "numberMatch"];
var className = ["scoreText", "btn", "HBoxTextH", "HBoxTextScore"];

$(document).ready(function () {
    window.onload = function () {
        init();
        initOneSize();
    };
    window.onresize = function (event) {
        init();
        initOneSize();
    };
});//End ready


//Reset
function init() {
    //Set line height
    for (var i = 0; i < idName.length; i++) {
        $('#' + idName[i]).css('line-height', $('#' + idName[i]).height() + "px");
    }
    for (var i = 0; i < className.length; i++) {
        $('.' + className[i]).css('line-height', $('.' + className[i]).height() + "px");
    }

    //Set Width
    $('#WeightSex').css('width', $('#WeightSex').height());
    $('#typeMatch').css('width', $('#typeMatch').height() / 2);
    $('#numberMatch').css('width', $('#numberMatch').height() * 2);

    //Set FontSiz
    $('#numberMatch').css('font-size', Math.floor($('#numberMatch').height()));
    changeFontZise(1,1,'typeMatch','typeMatchText');
    changeFontZise(1,1,'weight','weightText');
    changeFontZise(1,1,'sex','sexText');

    changeFontZise(2,2,'biginfoRed','biginfoRedText');
    changeFontZise(2,2,'biginfoBlue','biginfoBlueText');
    if($('#biginfoRedText').height()>$('#biginfoBlueText').height()){
        $('#biginfoRedText').css('font-size', $('#biginfoBlueText').css('font-size'));
    }else{
        $('#biginfoBlueText').css('font-size', $('#biginfoRedText').css('font-size'));
    }
    changeFontZise(2,2,'smallInfoRed','smallInfoRedText');
    changeFontZise(2,2,'smallInfoBlue','smallInfoBlueText');
    if($('#smallInfoRedText').height()>$('#smallInfoBlueText').height()){
        $('#smallInfoRedText').css('font-size', $('#smallInfoBlueText').css('font-size'));
    }else{
        $('#smallInfoBlueText').css('font-size', $('#smallInfoRedText').css('font-size'));
    }

    changeFontZise(2,2,'matchCount','matchCountText');
    changeFontZise(2,2,'time','timeText');
    $('.btn').css('font-size',$('.btn').width()/3);
}

function initOneSize(){
    changeFontZise(1,1,'scoreContainRed','scoreTextsRed');
    changeFontZise(1,1,'scoreContainBlue','scoreTextsBlue');
    $('.hboxText').css('font-size', Math.floor($('.HBox').width()*0.8));
    for (var i = Math.floor($('.HBox').width()); i > 0; i--) {
        if ($('.hboxText').width() > $('.HBox').width()*0.8) {
            $('.hboxText').css('font-size', i);
        } else break;
    }
}


function changeFontZise(typeFa, typeSo, father, son) {
    //1: width, 2:height
    if (typeFa == 1 && typeSo == 1) {
        $('#' + son).css('font-size', Math.floor($('#' + father).width()));
        for (var i = Math.floor($('#' + father).width()); i > 0; i--) {
            if ($('#' + son).width() > $('#' + father).width()) {
                $('#' + son).css('font-size', i);
            } else break;
        }
    }
    if (typeFa == 2 && typeSo == 2) {
        $('#' + son).css('font-size', Math.floor($('#' + father).height()));
        for (var i = Math.floor($('#' + father).height()); i > 0; i--) {
            if ($('#' + son).height() > $('#' + father).height()) {
                $('#' + son).css('font-size', i);
            } else break;
        }
    }
}

function tickScore(score,type){
    //1: Red, 2:Blue
    if(type==1){
        var oldScore = parseInt($('#scoreTextsRed').html());
        $('#scoreTextsRed').html(score+oldScore);
    }else if(type==2){
        var oldScore = parseInt($('#scoreTextsBlue').html());
        $('#scoreTextsBlue').html(score+oldScore);
    }
}