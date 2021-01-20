console.log("hi from home");

createSelector();


function createSelector() {
    let countries = ['United States', 'India', 'United Kingdom', 'Romania'];

    for (var i = 0; i < countries.length; i++) {
        let element = `
                <option value ${countries[i]}>${countries[i]}</option>
        `;
        $("#countrySelector").append(element);
    }


    



    
}