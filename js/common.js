//スライダー
$('.slider').slick({
    dots: true,
    arrows: true,
    infinite: true,
    autoplay: true,
    speed: 700,
    swipe: true,
    centerMode: true,
    centerPadding: '20%',
    responsive:[{
      breakpoint: 1024,
      settings: {
        slidesToShow: 1,
        slideToScroll: 1,
        centerMode: false,
      }
    }, {
      breakpoint: 599,
      settings: {
        slideToShow: 1,
        dots: false,
        arrows: false,
      }
    }]
  });
$('.slider').on('beforeChange', function(){
    $('.slick-current').removeClass('is--active');
  });
  $('.slider').on('afterChange', function(){
    $('.slick-current').addClass('is--active');
  });

  //トップに戻る
    var appear = false;
    var pagetop = $('#page_top');
    $(window).scroll(function () {
      if ($(this).scrollTop() > 2000) {  //2000pxスクロールしたら
        if (appear == false) {
          appear = true;
          pagetop.stop().animate({
            'right': '50px' //右から50pxの位置に
          }, 300); //0.3秒かけて現れる
        }
      } else {
        if (appear) {
          appear = false;
          pagetop.stop().animate({
            'right': '-50px' //右から-50pxの位置に
          }, 300); //0.3秒かけて隠れる
        }
      }
    });
    pagetop.click(function () {
      $('body, html').animate({ scrollTop: 0 }, 500); //0.5秒かけてトップへ戻る
      return false;
    });


    function delayScrollAnime() {
      var time = 0.2;//遅延時間を増やす秒数の値
      var value = time;
      $('.card').each(function () {
        var parent = this;					//親要素を取得
        var elemPos = $(this).offset().top;//要素の位置まで来たら
        var scroll = $(window).scrollTop();//スクロール値を取得
        var windowHeight = $(window).height();//画面の高さを取得
        var childs = $(this).children();	//子要素を取得
        
        if (scroll >= elemPos - windowHeight && !$(parent).hasClass("play")) {//指定領域内にスクロールが入ったらまた親要素にクラスplayがなければ
          $(childs).each(function () {
            
            if (!$(this).hasClass("fadeUp")) {//アニメーションのクラス名が指定されているかどうかをチェック
              
              $(parent).addClass("play");	//親要素にクラス名playを追加
              $(this).css("animation-delay", value + "s");//アニメーション遅延のCSS animation-delayを追加し
              $(this).addClass("fadeUp");//アニメーションのクラス名を追加
              value = value + time;//delay時間を増加させる
              
              //全ての処理を終わったらplayを外す
              var index = $(childs).index(this);
              if((childs.length-1) == index){
                $(parent).removeClass("play");
              }
            }
          })
        }else {
          $(childs).removeClass("fadeUp");//アニメーションのクラス名を削除
          value = time;//delay初期値の数値に戻す
        }
      })
    }
    
    // 画面をスクロールをしたら動かしたい場合の記述
      $(window).scroll(function (){
        delayScrollAnime();/* アニメーション用の関数を呼ぶ*/
      });
    // ここまで画面をスクロールをしたら動かしたい場合の記述
    
    // 画面が読み込まれたらすぐに動かしたい場合の記述
      $(window).on('load', function(){
        delayScrollAnime();/* アニメーション用の関数を呼ぶ*/
      });
    // ここまで画面が読み込まれたらすぐに動かしたい場合の記述

      $(function() {
        　$('.hamburger-icon').click(function() {//クリックしたとき
        　　$(this).toggleClass('drop-menu__active');//アクティブを切り替え
        
        　if ($(this).hasClass('drop-menu__active')) {
        　　$('.drop-menu').addClass('drop-menu__active');
        　} else {
        　　$('.drop-menu').removeClass('drop-menu__active');
        　}
        　});
        });
