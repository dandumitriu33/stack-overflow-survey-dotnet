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
        .then(json => constructDataVisualisation(countryName, languages, json))
        .catch (err => console.log(err));
}

function constructDataVisualisation(countryName, languages, json) {
    console.log(json);    
    var languageColors = [];
    var dbDataSets = [];
    for (var i = 0; i < languages.length; i++) {
        languageColors.push(getColorForLang(languages[i]));
        var set = {
            label: `${languages[i]}`,
            data: [],
            borderColor: getColorForLang(languages[i])
        }
        var tempData = [];
        for (var j = 0; j < json.length; j++) {
            tempData.push(json[j].LanguagesPercent[languages[i]]);
        }
        set.data = tempData;
        dbDataSets.push(set);
    }

    document.getElementById('dataChart').innerHTML = "";
    let dataChart = document.getElementById('dataChart').getContext('2d');
    
    Chart.defaults.global.elements.line.fill = false;
    let countryChart = new Chart(dataChart, {
        type: 'line',
        data: {
            labels: ['2011', '2012', '2013', '2014', '2015', '2016', '2017', '2018', '2019', '2020'],
            datasets: dbDataSets,
            
            backgroundColor: languageColors,
            //backgroundColor: [ // can be color name, 'rgba(255, 99, 132, 0.6)', hexadecimal value '#777'
            //    'green',
            //    'blue',
            //    'red',
            //    'brown',
            //    'yellow',
            //    'cyan'
            //]
            //backgroundColor: 'green',
            borderWidth: 1,
            borderColor: '#000',
            hoverBorderWidth: 2,
            hoverBorderColor: '#000'
        },
        options: {            
            title: {
                display: true,
                text: `Language Percent for ${countryName}`,
                fontSize: 18
            },
            legend: {
                display: true, // or true to show, makes more sense in pie charts
                position: 'right', // top, bottom, left, right
                labels: {
                    fontColor: 'black'
                }
            },
            layout: {
                padding: {
                    left: 0,
                    right: 0,
                    bottom: 0,
                    top: 0
                }
            },
            tooltips: {
                enabled: true // true, false for on and off
            },
            line: {
                backgroundColor: false
            }
        }
    })
}

function getColorForLang(language) {
    if (language === "C") {
        return 'gray';
    } else if (language === "CPlusPlus") {
        return 'blue';
    } else if (language === "CSharp") {
        return 'purple';
    } else if (language === "Go") {
        return 'cyan';
    } else {
        return 'green';
    }
}

export { getCountries, getDataForCountry };