angular.
  module('phoneList').
  component('phoneList', {
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