// Calculator functionality

let displayValue = '';

function appendNumber(number) {
    displayValue += number;
    updateDisplay();
}

function appendOperator(operator) {
    displayValue += ' ' + operator + ' ';
    updateDisplay();
}

function calculate() {
    try {
        // Replace the displayValue string into an evaluable expression
        const result = eval(displayValue);
        displayValue = result.toString();
    } catch (e) {
        displayValue = 'Error';
    }
    updateDisplay();
}

function clearDisplay() {
    displayValue = '';
    updateDisplay();
}

function deleteLastChar() {
    displayValue = displayValue.slice(0, -1);
    updateDisplay();
}

function updateDisplay() {
    // Assuming there's an HTML element with ID 'display'
    document.getElementById('display').innerText = displayValue;
}