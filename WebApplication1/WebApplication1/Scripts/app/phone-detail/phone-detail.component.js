angular.
  module('phoneDetail').
  component('phoneDetail', {
      controller: ['$http', '$routeParams',
        function PhoneDetailController($http, $routeParams) {
            var self = this;

            if ($routeParams.phoneId == null)
            {
                $routeParams.phoneId = "dell-streak-7";
            }

            $http.get('/Content/Json/' + $routeParams.phoneId + '.json').then(function (response) {
                self.phone = response.data;
            });
        }
      ]
  });