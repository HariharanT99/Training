window.onload = function(){
    var request = new XMLHttpRequest();

    request.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            var convertstr = JSON.parse(this.responseText)

            var out = document.querySelector('#body')
            var modal = document.querySelector('#indModal')

            convertstr.data.map((user) => 
            {
                out.innerHTML += 
                `
                <tr>
                    <td>${user.id}</td>
                    <td>${user.email}</td>
                    <td>${user.first_name}</td>
                    <td>${user.last_name}</td>
                    <td><img src="${user.avatar}" class="img-thumbnail"></td>
                </tr>
                `
            })
        }
    }
    request.open('GET', 'https://reqres.in/api/users?page=2')
    request.send()
}