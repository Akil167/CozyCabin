function toggleTaxiService() { 
    const taxiService = document.getElementById('taxi-service'); 
    const pickupLocation = document.getElementById('pickup-location'); 
    const pickupTime = document.getElementById('pickup-time'); 
    const chooseTaxi = document.getElementById('choose-taxi'); 
 
    if (taxiService.checked) { 
        pickupLocation.disabled = false; 
        pickupTime.disabled = false; 
        chooseTaxi.disabled = false; 
    } else { 
        pickupLocation.disabled = true; 
        pickupTime.disabled = true; 
        chooseTaxi.disabled = true; 
    } 
}