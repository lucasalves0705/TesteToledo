// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var app = new Vue({
    el: '#form1',
    data: function () {
        return {
            email: "",
            emailBlured: false,
            valid: false,
            submitted: false,
            username: "",
            usernameBlured: false,
            cpf: "",
            cpfBlured: false,
            rua: "",
            ruaBlured: false,
            numero: "",
            numeroBlured: false,
            cidade: "",
            cidadeBlured: false,
            bairro: "",
            bairroBlured: false,
            telefone: "",
            telefoneBlured: false,
            celular: "",
            celularBlured: false
        }
    },

    methods: {

        validate: function () {
            this.usernameBlured = true;
            this.cpfBlured = true;
            this.ruaBlured = true;
            this.numeroBlured = true;
            this.cidadeBlured = true;
            this.bairroBlured = true;
            this.telefoneBlured = true;
            this.celularBlured = true;

            if (this.validEmail(this.email) &&
                this.validBairro(this.cidade) &&
                this.validCidade(this.cidade) &&
                this.validNumero(this.numero) &&
                this.validRua(this.rua) &&
                this.validCPF(this.cpf) &&
                this.validTelefone(this.telefone) &&
                this.validCelular(this.phone) &&
                this.validUsername(this.username))
            {
                this.valid = true;
            }
        },

        validEmail: function (email) {
            var re = /(.+)@(.+){2,}\.(.+){2,}/;
            if (re.test(email.toLowerCase())) {
                return true;
            }
        },

        validUsername: function (username) {

            if (username != "") {
                return true;
            }
        },

        validRua: function (rua) {

            if (rua != "") {
                return true;
            }
        },

        validNumero: function (numero) {

            if (numero != "" && $.isNumeric(numero)) {
                return true;
            }
        },

        validBairro: function (bairro) {

            if (bairro != "") {
                return true;
            }
        },

        validCidade: function (cidade) {

            if (cidade != "") {
                return true;
            }
        },

        validCPF: function (cpf) {

            if (cpf.length > 10 && cpf.length < 12) {
                return true;
            }
        },

        validTelefone: function (telefone) {
            if (telefone.length > 9 && telefone.length < 12) { return true; }
        }, submit: function () { this.validate(); if (this.valid) { this.submitted = true; } },

        validCelular: function (celular) {
            if (celular.length > 9 && celular.length < 12) { return true; }
        }, submit: function () { this.validate(); if (this.valid) { this.submitted = true; } }
    }
});