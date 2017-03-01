angular.
  module('phonecatApp').
  config(['$locationProvider', '$routeProvider',
    function config($locationProvider, $routeProvider) {
        //$locationProvider.hashPrefix('!');

        $routeProvider.
          when('/phones', {
              templateUrl: '/Templates/PhoneListTemplate',
              Controller: "PhoneListController"
          }).
          when('/phones/:phoneId', {
              templateUrl: '/Templates/PhoneDetailTemplate',
              Controller: "PhoneDetailController"
          }).
          otherwise({
              redirectTo: '/phones'
          });
    }
  ]);