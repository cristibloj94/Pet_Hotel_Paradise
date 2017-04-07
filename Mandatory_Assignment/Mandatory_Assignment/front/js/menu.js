jQuery(document).ready(function($){

// menu show / hide functions

	$('.js-menu__list').addClass('invisible');
	var transition = 100;

	$('.js-menu__button--closed').click(function(){

		// Toggle button classes
		$(this).toggleClass('visible invisible');
		$('.js-menu__button--open').toggleClass('invisible visible');

		// fade menu
		$('.js-menu__list').fadeIn(transition);

		$('.overlay').fadeIn(transition, function(){
			$(this).toggleClass('invisible visible');
		});
	});


	$('.js-menu__button--open').click(function(){

		// Toggle button classes
		$(this).toggleClass('visible invisible');
		$('.js-menu__button--closed').toggleClass('invisible visible');

		// fade menu
		$('.js-menu__list').fadeOut(transition);

		$('.overlay').fadeOut(transition, function(){
			$(this).toggleClass('visible invisible');
		});
	});

});