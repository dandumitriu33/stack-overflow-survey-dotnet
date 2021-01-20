console.log("hi from home");

createSelector();


function createSelector() {
    let countries = ['United States', 'India', 'United Kingdom', 'Romania'];

    for (var i = 0; i < countries.length; i++) {
        let element = `
                <option value="${countries[i]}">${countries[i]}</option>
        `;
        $("#countrySelector").append(element);
    }
    
}

$("#countrySelector").change(function () {
    console.log("changed country");
});

$("#displayDataButton").click(function () {
    console.log("display clicked");
    let country = getDomCountry();
    console.log("got country: " + country)
    let languages = getDomLanguages();
    console.log("languages: " + languages);
})

function getDomCountry() {
    let selectedCountry = $("#countrySelector").val();
    return selectedCountry;
}

function getDomLanguages() {
    let languages = [];
    if ($("#checkC").is(":checked")) { languages.push('C') };
    if ($("#checkCPlusPlus").is(":checked")) { languages.push('CPlusPlus') };
    if ($("#checkCSharp").is(":checked")) { languages.push('CSharp') };
    if ($("#checkGo").is(":checked")) { languages.push('Go') };
    if ($("#checkJava").is(":checked")) { languages.push('Java') };
    if ($("#checkJavaScript").is(":checked")) { languages.push('JavaScript') };
    if ($("#checkObjectiveC").is(":checked")) { languages.push('ObjectiveC') };
    if ($("#checkPerl").is(":checked")) { languages.push('Perl') };
    if ($("#checkPHP").is(":checked")) { languages.push('PHP') };
    if ($("#checkPython").is(":checked")) { languages.push('Python') };
    if ($("#checkRuby").is(":checked")) { languages.push('Ruby') };
    if ($("#checkRust").is(":checked")) { languages.push('Rust') };
    if ($("#checkSQL").is(":checked")) { languages.push('SQL') };
    if ($("#checkSwift").is(":checked")) { languages.push('Swift') };
    return languages;
}
