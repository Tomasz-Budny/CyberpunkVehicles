const uri = 'https://localhost:5001/api/vehicle';

const getAllVehicles = async () => {
    await axios.get(uri)
        .then(response => {
            displayVehicles(response);
            assignAllBtns();
        })
        .catch(err => console.log(err));
};

const displayVehicles = ({data}) => {
    const vehicles = document.querySelector('.vehicles');
    vehicles.innerHTML = '';
    for(const vehicle of data.reverse()) {
        vehicles.innerHTML += vehicleBoilerplate(vehicle);
    }
};

const createVehicle = async () => {
    const formData = new FormData(form);
    await axios.post(uri, formData)
        .then(response => {
            getAllVehicles();
            resetForm();
        })
        .catch(({response}) => {
            if(response && response.request.status === 400){
                displayErrors(response.data.errors);
            }
        });
}
submit.addEventListener('click', createVehicle)

function displayErrors(errors) {
    const errorCont = document.querySelector('.create-vehicle-errors');
    errorCont.innerHTML = '';
    const fields = Object.keys(errors);
    fields.forEach(field => {
        errors[field].forEach(error => {
            errorCont.innerHTML += errorBoilerplate(`${field}: ${error}`)
        })
    });
    assignHideErrorsBtns();
}

getAllVehicles();