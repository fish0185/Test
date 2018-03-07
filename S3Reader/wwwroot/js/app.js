var app = angular.module('app', []);
app.controller('main',
    function ($scope, getJson) {
        $scope.test = "gar";
        getJson.fetch();
    });

app.service('getJson', function($http) {
    this.fetch = function() {
        $http.get('api/s3reader/gary').then(function(data) {
            console.log(data);
        });
    }
});