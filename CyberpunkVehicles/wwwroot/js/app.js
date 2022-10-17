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