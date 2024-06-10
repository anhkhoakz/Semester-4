function suggest(input) {
    let query = input.trim();
    let suggestionsContainer = document.getElementById("suggestions");
    suggestionsContainer.innerHTML = "";

    if (query.length >= 2) {
        $.ajax({
            url: "http://localhost/Lab10/Ex02.php",
            method: "POST",
            data: { query: query },
            success: function (data) {
                let matchedCountries = JSON.parse(data);
                for (let i = 0; i < matchedCountries.length; i++) {
                    let country = matchedCountries[i];
                    console.log(country.country);
                    let suggestion = document.createElement("div");
                    suggestion.className = "suggestion list-group-item";
                    suggestion.innerHTML = country.country;
                    suggestionsContainer.appendChild(suggestion);
                }
            },
        });
    }
}
