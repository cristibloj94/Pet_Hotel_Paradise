$(document).ready(function(){
	var slide_number = 1;
	var timer;

	function testimonials(){
    	if(slide_number == 1){
    		$(".js-testimonials > article:nth-child(1)").fadeOut(1000, function() {
				$(".js-testimonials > article:nth-child(2)").fadeIn(1000);
			});
		}
		else if(slide_number == 2){
			$(".js-testimonials > article:nth-child(2)").fadeOut(1000, function() {
				$(".js-testimonials > article:nth-child(3)").fadeIn(1000);
			});
		}
		else if(slide_number == 3){
			$(".js-testimonials > article:nth-child(3)").fadeOut(1000, function() {
				$(".js-testimonials > article:nth-child(1)").fadeIn(1000);
			});
		}
		if(slide_number == 3) slide_number = 1;
		else slide_number++;
	}
	timer = setInterval(testimonials, 6000);
	testimonials();
});