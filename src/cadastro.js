const form = document.getElementById("form");
const email = document.getElementById("email");
const senha = document.getElementById("senha");
    
form.addEventListener('submit', (e) => {
    e.preventDefault();
 
    checkInputs();
});
 
function checkInputs() {
    const emailValue = email.value;
    const senhaValue = senha.value;
 
 
     if(emailValue === '') {
         setErrorFor(email, 'O email é obrigatório.');
     } else if (!checkEmail(emailValue)) {
         setErrorFor(email, 'Por favor, insira um email válido.');
     } else {
         setSuccessFor(email);
     }
 
     if(senhaValue === '') {
         setErrorFor(senha, "A senha é obrigatória.");
     } else if(senhaValue.length < 7) {
         setErrorFor(senha, "A senha precisa ter no mínimo 7 caracteres.");
     } else{
         setSuccessFor(senha);
     }
 
 
     const formControls = form.querySelectorAll('.form-control');
 
     const formIsValid = [... formControls].every((formControl) => {
         return formControl.className === 'form-control success';
     });
 
     if(formIsValid) {
         console.log('Sua inscrição foi enviada com sucesso');
     }
}
 
function setErrorFor(input, message) {
    const formControl = input.parentElement;
    const small = formControl.querySelector("small");
 
    // Adiciona a mensagem de erro
    small.innerText = message;
 
    // Adiciona a classe de erro
    formControl.className = "form-control error";

    small.className=""
}
 
function setSuccessFor(input) {
    const formControl = input.parentElement;
    const small = formControl.querySelector("small");
    formControl.className = 'form-control success';
    small.className="hidden"
    small.innerText =""
}
 
function checkEmail(email) {
    return /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(
      email
    );
  }