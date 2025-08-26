function validateForm() {
    let message = "";
    let username = document.getElementById('username').value.trim();
    let pin = document.getElementById('pin').value.trim();
    let states = document.getElementById('states').value;
    let validatePin = document.getElementById('validatePin').checked;
    let dairy = document.querySelector('input[name="dairy"]:checked');

    // Username validation
    if (username.length < 6 || username.length > 8) {
        message += "Username not validated<br>";
    }

    // Pin validation
    if (validatePin) {
        if (pin === "") {
            message += "Pin not validated<br>";
        } else if (!/^[a-zA-Z0-9]+$/.test(pin)) {
            message += "Pin not validated<br>";
        } else {
            message += "Pin validated<br>";
        }
    }

    // States validation
    if (states === "") {
        message += "States not validated<br>";
    }
    if (!dairy) {
        message += "Dairy selection not validated<br>";
    }

    // Final message
    document.getElementById('message').innerHTML = message || "Form validated successfully!";
}
