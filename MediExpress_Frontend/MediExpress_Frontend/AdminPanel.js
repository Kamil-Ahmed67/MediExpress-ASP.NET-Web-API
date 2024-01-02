var adminPanelApp = angular.module('adminPanelApp', ['ngRoute']);

adminPanelApp.config(function ($routeProvider) {
    $routeProvider
        .when('/customers', {
            templateUrl: 'views/customers.html',
            controller: 'CustomerController'
        })
        .when('/pharmacists', {
            templateUrl: 'views/pharmacists.html',
            controller: 'PharmacistController'
        })
        .otherwise({
            redirectTo: '/customers'
        });
});

adminPanelApp.controller('CustomerController', function ($scope, AdminService) {
    // Fetch customers from service
    $scope.customers = AdminService.getCustomers();

    // Function to delete a customer
    $scope.deleteCustomer = function (customerId) {
        AdminService.deleteCustomer(customerId);
        // Update the customers list after deletion
        $scope.customers = AdminService.getCustomers();
    };

    // Function to update a customer
    $scope.updateCustomer = function (customer) {
        AdminService.updateCustomer(customer);
        // Update the customers list after updating
        $scope.customers = AdminService.getCustomers();
    };
});

adminPanelApp.controller('PharmacistController', function ($scope, AdminService) {
    // Fetch pharmacists from service
    $scope.pharmacists = AdminService.getPharmacists();

    // Function to delete a pharmacist
    $scope.deletePharmacist = function (pharmacistId) {
        AdminService.deletePharmacist(pharmacistId);
        // Update the pharmacists list after deletion
        $scope.pharmacists = AdminService.getPharmacists();
    };

    // Function to update a pharmacist
    $scope.updatePharmacist = function (pharmacist) {
        AdminService.updatePharmacist(pharmacist);
        // Update the pharmacists list after updating
        $scope.pharmacists = AdminService.getPharmacists();
    };
});

adminPanelApp.service('AdminService', function () {
    // Simulated data for customers and pharmacists (replace this with actual data)
    var customers = [
        { id: 1, name: 'Customer 1' },
        { id: 2, name: 'Customer 2' },
        // Add more customers
    ];

    var pharmacists = [
        { id: 1, name: 'Pharmacist 1' },
        { id: 2, name: 'Pharmacist 2' },
        // Add more pharmacists
    ];

    return {
        getCustomers: function () {
            return customers;
        },
        getPharmacists: function () {
            return pharmacists;
        },
        deleteCustomer: function (customerId) {
            // Delete logic for customers
            customers = customers.filter(function (customer) {
                return customer.id !== customerId;
            });
        },
        deletePharmacist: function (pharmacistId) {
            // Delete logic for pharmacists
            pharmacists = pharmacists.filter(function (pharmacist) {
                return pharmacist.id !== pharmacistId;
            });
        },
        updateCustomer: function (customer) {
            // Update logic for customers
            customers.forEach(function (c) {
                if (c.id === customer.id) {
                    c.name = customer.name; // Update name or other properties
                }
            });
        },
        updatePharmacist: function (pharmacist) {
            // Update logic for pharmacists
            pharmacists.forEach(function (p) {
                if (p.id === pharmacist.id) {
                    p.name = pharmacist.name; // Update name or other properties
                }
            });
        }
    };
});
