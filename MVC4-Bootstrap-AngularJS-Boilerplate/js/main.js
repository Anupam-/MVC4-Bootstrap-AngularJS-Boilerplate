'use strict';

// Instantiate our angular module and make it a global var called 'app'
var app = angular.module('app', []);

app.controller('AppController',
    function AppController($scope) {
        $scope.version = "1";
    }
);

$(document).ready(function () {    

});
