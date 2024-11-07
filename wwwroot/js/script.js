let currentStage = 0;

const stages = [
    "orderPlaced",
    "preparing",
    "outForDelivery",
    "delivered"
];

function updateStage() {
    if (currentStage < stages.length) {
        document.getElementById(stages[currentStage]).classList.add("active");
        currentStage++;
    }
}
