	$('#ACTs1').submit(function (e) {
	var _valid = true;
	var Application = $('#application').val();
	var Name = $('#name').val();
	var Manufacturer = $('#manufacturer').val();
	var Year_of_issue = $('#year_of_issue').val();
	var Commissioning = $('#commissioning').val();
	var Condition = $('#condition').val();
	var Assessment = $('#assessment').val();


	$(".error").remove();
	$(".cont_int").removeClass('error-input');

	if (Application.length < 1) {
		$('#application')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}

	if (Name.length < 1) {
		$('#name')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}

	if (Manufacturer.length < 1) {
		$('#manufacturer')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}

	if (Year_of_issue.length < 4) {
		$('#year_of_issue')
			.after('<span class="error">Введите не менее четырех цифр!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}
		if (Commissioning.length < 1) {
		$('#сommissioning')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}
	if (Condition.length < 1) {
		$('#condition')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}
		if (Assessment.length < 1) {
			$('#assessment')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}

	if (!_valid) {
		e.preventDefault();
	}
});

$('#ACTs1_edit').submit(function (e) {

	var _valid = true;
	var Application = $('#application').val();
	var Name = $('#name').val();
	var Manufacturer = $('#manufacturer').val();
	var Year_of_issue = $('#year_of_issue').val();
	var Commissioning = $('#commissioning').val();
	var Condition = $('#condition').val();
	var Assessment = $('#assessment').val();


	$(".error").remove();
	$(".cont_int").removeClass('error-input');

	if (Application.length < 1) {
		$('#application')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}

	if (Name.length < 1) {
		$('#name')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}

	if (Manufacturer.length < 1) {
		$('#manufacturer')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}

	if (Year_of_issue.length < 4) {
		$('#year_of_issue')
			.after('<span class="error">Введите не менее четырех цифр!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}
	if (Commissioning.length < 1) {
		$('#сommissioning')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}
	if (Condition.length < 1) {
		$('#condition')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}
	if (Assessment.length < 1) {
		$('#assessment')
			.after('<span class="error">Это обязательное поле!</span>')
			.closest('cont_inf')
			.addClass('error-input');
		_valid = false;
	}

	if (!_valid) {
		e.preventDefault();
	}
});
