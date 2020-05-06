var id;

function updateUser(id) {
    window.location.href = '/Home/Atualizar/' + id;
}

function deleteUser(id) {
    this.id = id;
}

function okDeleteUser() {
    window.location.href = '/Home/Deletar/' + this.id;
    this.id = null;
}