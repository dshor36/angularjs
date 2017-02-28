angular.
  module('phoneList').
  component('phoneList', {
      templateUrl: '/Templates/PhoneListTemplate',
      controller: ['Phone',
        function PhoneListController(Phone) {
            this.phones = Phone.query();
            this.orderProp = 'age';
        }
      ]
  });