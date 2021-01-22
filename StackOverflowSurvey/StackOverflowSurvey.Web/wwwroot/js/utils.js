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
        return 'rgba(33, 56, 139, 1)';
    } else if (language === "CPlusPlus") {
        return 'rgba(32, 118, 7, 1)';
    } else if (language === "CSharp") {
        return 'rgba(124, 54, 132, 1)';
    } else if (language === "Go") {
        return 'rgba(116, 201, 213, 1)';
    } else if (language === "Java") {
        return 'rgba(223, 31, 46, 1)';
    } else if (language === "JavaScript") {
        return 'rgba(247, 208, 77, 1)';
    } else if (language === "ObjectiveC") {
        return 'rgba(195, 195, 195, 1)';
    } else if (language === "Perl") {
        return 'rgba(80, 76, 105, 1)';
    } else if (language === "PHP") {
        return 'rgba(131, 143, 182, 1)';
    } else if (language === "Python") {
        return 'rgba(100, 243, 58, 1)';
    } else if (language === "Ruby") {
        return 'rgba(130, 2, 12, 1)';
    } else if (language === "SQL") {
        return 'rgba(214, 58, 171, 1)';
    } else if (language === "Swift") {
        return 'rgba(243, 119, 58, 1)';
    } else {
        return 'green';
    }
}

export { getCountries, getDataForCountry };