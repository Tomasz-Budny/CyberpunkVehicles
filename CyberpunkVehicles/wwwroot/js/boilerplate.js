function vehicleBoilerplate({body, description, drivetrain, group, horsePower,
                                id, imageRelativePath, name, topSpeed, weight, year}) {
    return (
        `<div class="vehicle columns is-centered vehicle${id}">
            <div class="vehicle-errors ">   
              
            </div>
             <div class="vehicle-content column is-four-fifths ">
                    <div class="media">
                        <figure class="media-left ">
                            <p class="image">
                                <img src="${imageRelativePath}" alt="${name}">
                            </p>
                        </figure>
                        <div class="media-content">
                            <div class="content">
                                <h1>${name}</h1>
                                <h4>${group}</h4>
                                <p>${description}</p>
                            </div>
                        </div>
                    </div>
                    <div class="expand-container">
                        <i class="fa-solid fa-angle-down expand-btn"></i>
                    </div>
                    <div class="vehicle-details is-hidden">
                        <div class="columns">
                            <div class="column">
                                <div class="info-left">
                                    <p>Drivetrain:</p>
                                    <p>Body:</p>
                                    <p>Weight:</p>
                                </div>
                                <div class="info-right">
                                    <p>${drivetrain}</p>
                                    <p>${body}</p>
                                    <p>${weight}</p>
                                </div>
                            </div>
                            <div class="column">
                                <div class="info-left">
                                    <p>Horse Power:</p>
                                    <p>Top Speed:</p>
                                    <p>Year:</p>
                                </div>
                                <div class="info-right">
                                    <p>${horsePower}</p>
                                    <p>${topSpeed}</p>
                                    <p>${year}</p>
                                </div>
                            </div>
                        </div>
                        <div class="vehicle-options">
                            <input type="hidden" id="vehicleId" value="${id}">
                            <i class="fa-solid fa-xmark delete-btn"></i>
                        </div>
                        
                    <div class="collapse-container columns is-centered">
                            <i class="fa-solid fa-angle-up collapse-btn"></i> 
                    </div>
                </div>
            
        </div>`);
}
