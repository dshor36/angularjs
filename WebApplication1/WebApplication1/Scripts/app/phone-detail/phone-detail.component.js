angular.
  module('phoneDetail').
  component('phoneDetail', {
      templateUrl: '/Templates/PhoneDetailTemplate',
      controller: ['$http', '$routeParams',
          function PhoneDetailController($http, $routeParams) {
              var self = this;

              $http.get('/Content/Json/' + $routeParams.phoneId + '.json').then(function (response) {
                  self.phone = response.data;
              });
          }
      ]
  });