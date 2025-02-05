var arrData =  [
        {
            "name": "serviceJobNumber",
            "value": "17"
        },
        {
            "name": "depot",
            "value": "6"
        },
        {
            "name": "serviceJobStatus",
            "value": "504"
        },
        {
            "name": "stockNumber",
            "value": "1049"
        },
        {
            "name": "start",
            "value": "1/10/2024"
        },
        {
            "name": "estimatedTimeMinutes",
            "value": "23"
        },
        {
            "name": "hoursWorked",
            "value": "15"
        },
        {
            "name": "billedHours",
            "value": "12"
        },
        {
            "name": "vehicleArrivalTime",
            "value": "12"
        },
        {
            "name": "vehicleReturnedToCustomerTime",
            "value": "returned"
        },
        {
            "name": "vehicleRequiredTime",
            "value": "15minutes"
        },
        {
            "name": "netJobTotal",
            "value": "1200"
        },
        {
            "name": "vatJobTotal",
            "value": "1500"
        }
    ];

function fromArrayToJSON(){
    var jsonData = {};
    arrData.forEach((d) => jsonData[d.name] = d.value);
    console.log({jsonData:jsonData});
}


fromArrayToJSON();