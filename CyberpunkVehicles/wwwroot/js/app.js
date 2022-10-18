const addVehicleBtn = document.querySelector('.add-vehicle');
const createVehicleForm = document.querySelector('.create-new-vehicle');
const form = document.querySelector('.create-vehicle-form');
const preview = document.querySelector('#upload-label').querySelector('img');

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
    preview.src = "Images/defaultImage.jpg"
}

function assignAllBtns() {
    const expandBtns = document.querySelectorAll('.expand-btn');
    const collapseBtns = document.querySelectorAll('.collapse-btn')
    const deleteBtns = document.querySelectorAll('.delete-btn');

    expandBtns.forEach(el => el.addEventListener('click', expandBtnClick));
    collapseBtns.forEach(el => el.addEventListener('click', collapseBtnClick));
    deleteBtns.forEach(el => el.addEventListener('click', deleteBtnClick))
}

function deleteBtnClick(event) {
    const options = event.target.parentNode;
    const id = options.querySelector('input').value;
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

assignAllBtns();