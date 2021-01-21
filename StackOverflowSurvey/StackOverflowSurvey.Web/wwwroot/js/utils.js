console.log("hi from utils");

async function getCountries() {    
    var URL = 'https://localhost:44332/api/query/all-countries';
    // GET Request.
    fetch(URL)
        // Handle success
        .then(response => response.json())  // convert to json
        .then(json => {
            console.log(json)
            json.sort();
            for (var i = 0; i < json.length; i++) {
                let element = `
                                <option value="${json[i]}">${json[i]}</option>
                            `;
                $("#countrySelector").append(element);
            }
            })    //print data to console
        .catch(err => console.log('Request Failed', err)); // Catch errors
}

async function getDataForCountry(countryName, languages) {
    console.log("GDFC: " + countryName);
    console.log("GDFC L1: " + languages[0]);
    var data = {
        "CountryName": countryName,
        "Languages": languages
    }
    var URL = 'https://localhost:44332/api/query/data-for-country';
    fetch(URL, {
        method: "POST",
        body: JSON.stringify(data),
        headers: { "Content-type": "application/json; charset=UTF-8" }
        })
        .then(response => response.json())
        .then(json => constructDataVisualisation(json))
        .catch (err => console.log(err));
}

function constructDataVisualisation(json) {
    console.log(json);
}

export { getCountries, getDataForCountry };