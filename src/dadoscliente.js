document.getElementById('altura').addEventListener('input', function(event) {
    let input = event.target;
    let value = input.value.replace(/\D/g, ''); // Remove todos os caracteres não numéricos
    value = value.replace(/(\d)(\d+)/, '$1,$2'); // Adiciona uma vírgula após o primeiro dígito
    input.value = value;
});