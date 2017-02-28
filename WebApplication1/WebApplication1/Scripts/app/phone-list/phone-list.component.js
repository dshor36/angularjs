angular.
  module('phoneList').
  component('phoneList', {
      templateUrl: '/Templates/PhoneListTemplate',
      controller: ['$http',
          function PhoneListController($http) {
              var self = this;
              self.orderProp = 'age';

              $http.get('/Content/Json/phones.json').then(function (response) {
                  self.phones = response.data;
              });
          }
      ]
  });