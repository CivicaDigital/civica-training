import * as validators from './validators';

export const validateInput = input => ({ valid: false, inputName: input.name, errorMessage: 'wrong' });

export const validateForm = () => {
  const inputs = document.querySelectorAll('.validated');
  for (let i = 0; i < inputs.length; i++) {
    const input = inputs[i];
    const inputData = {
      name: input.name,
      value: input.value,
      validation: input.getAttribute('data-validation')
    };

    if (!validateInput(inputData).valid) {
      input.classList.add('red');
    }
  }
};

window.onload = function onload() {
  document.querySelector('#validate').onclick = validateForm;
};
