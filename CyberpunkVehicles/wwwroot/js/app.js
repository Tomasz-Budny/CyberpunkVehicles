const addVehicleBtn = document.querySelector('.add-vehicle');
const createVehicleForm = document.querySelector('.create-new-vehicle');
const form = document.querySelector('.create-vehicle-form');
const preview = document.querySelector('#upload-label').querySelector('img');
const submit = document.querySelector('.submit-btn');

document.querySelector('#upload').onchange = event => {
    const [file] = event.target.files;
    if(file){
        preview.src = URL.createObjectURL(file);
    }
}

addVehicleBtn.addEventListener('click', () => {
    addVehicleBtn.classList.add('is-hidden');
    createVehicleForm.classList.remove('is-hidden');
});

createVehicleForm.querySelector('.abort-btn').addEventListener('click', () => {
    createVehicleForm.classList.add('is-hidden');
    resetForm();
    addVehicleBtn.classList.remove('is-hidden');
});

function resetForm() {
    form.reset();
    preview.src = "Images/defaultImage.jpg";
    hideErrors();
}

function assignAllBtns() {
    const expandBtns = document.querySelectorAll('.expand-btn');
    const collapseBtns = document.querySelectorAll('.collapse-btn')
    const deleteBtns = document.querySelectorAll('.delete-btn');

    expandBtns.forEach(el => el.addEventListener('click', expandBtnClick));
    collapseBtns.forEach(el => el.addEventListener('click', collapseBtnClick));
    deleteBtns.forEach(el => el.addEventListener('click', deleteBtnClick))
}

async function deleteBtnClick(event) {
    const options = event.target.parentNode;
    const id = options.querySelector('input').value;
    await deleteVehicleById(id)
}

function collapseBtnClick(event) {
    const vehicleDetails = event.target.parentNode.parentNode;
    const vehicle = vehicleDetails.parentNode;
    vehicle.querySelector('.expand-container').classList.remove('is-hidden');
    vehicleDetails.classList.add('is-hidden');
}

function expandBtnClick(event) {
    const expandCont = event.target.parentNode;
    const vehicle = expandCont.parentNode;
    vehicle.querySelector('.vehicle-details').classList.remove('is-hidden');
    expandCont.classList.add('is-hidden');
}

function assignHideErrorsBtns() {
    const hideErrorBtns = document.querySelectorAll('.hide-error-btn');
    hideErrorBtns.forEach(el => el.addEventListener('click', hideErrorBtnClick));
}

function hideErrorBtnClick(event) {
    const error = event.target.parentNode.parentNode.parentNode;
    const errorsCont = error.parentNode;
    errorsCont.removeChild(error);
}

function displayErrors(errors) {
    const errorCont = document.querySelector('.create-vehicle-errors');
    errorCont.innerHTML = '';
    const fields = Object.keys(errors);
    fields.forEach(field => {
        errors[field].forEach(error => {
            errorCont.innerHTML += errorBoilerplate(`${error}`);
        })
    });
    assignHideErrorsBtns();
}

function hideErrors() {
    const errorCont = document.querySelector('.create-vehicle-errors');
    errorCont.innerHTML = '';
}

assignAllBtns();