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

getAllVehicles();