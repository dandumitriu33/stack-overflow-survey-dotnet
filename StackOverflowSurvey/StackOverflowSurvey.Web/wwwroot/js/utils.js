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

export { getCountries };