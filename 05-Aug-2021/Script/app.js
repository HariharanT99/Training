window.onload = function(){
    var request = new XMLHttpRequest()
    var userlist = []

    request.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            var convertstr = JSON.parse(this.responseText)

            var out = document.getElementById('tbody')

            convertstr.data.map((user) => 
            {
                userlist.push(user)
                out.innerHTML += 
                `
                <tr>
                    <td><a type="button" class="btn" data-bs-toggle="modal" data-bs-target="#infoModal">${user.id}</a></td>
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

    function Pop(d){
        var popup = document.getElementById('dis')

        userlist.forEach((item) => {
            if (item.id === d)
            {
                popup.innerHTML +=
                `
                <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">${User.first_name}</h5>
                </div>
                <div class="modal-body">
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
                `
            }
        })
    }
}