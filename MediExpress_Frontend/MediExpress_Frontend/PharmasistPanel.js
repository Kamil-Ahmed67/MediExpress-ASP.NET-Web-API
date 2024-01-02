var pharmacistPanelApp = angular.module('pharmacistPanelApp', ['ngRoute']);

// Configure routes
pharmacistPanelApp.config(function ($routeProvider) {
    $routeProvider
        .when('/orders', {
            templateUrl: 'views/orders.html',
            controller: 'OrderController'
        })
        .otherwise({
            redirectTo: '/orders'
        });
});

// Order Controller
pharmacistPanelApp.controller('OrderController', function ($scope, OrderService) {
    $scope.orders = OrderService.getOrders();

    $scope.viewOrderDetails = function (order) {
        // Implement logic to view order details
    };

    $scope.cancelOrder = function (order) {
        OrderService.cancelOrder(order);
        // Implement logic for canceling an order
    };

    $scope.confirmOrder = function (order) {
        OrderService.confirmOrder(order);
        // Implement logic for confirming an order
    };
});

// Order Service
pharmacistPanelApp.factory('OrderService', function () {
    var orders = [
        { id: 1, customer: 'Customer 1', prescription: 'Prescription details 1', status: 'Pending' },
        { id: 2, customer: 'Customer 2', prescription: 'Prescription details 2', status: 'Confirmed' },
        // Add more orders
    ];

    return {
        getOrders: function () {
            return orders;
        },
        cancelOrder: function (order) {
            order.status = 'Cancelled';
            // Implement backend logic for cancelling the order
        },
        confirmOrder: function (order) {
            order.status = 'Confirmed';
            // Implement backend logic for confirming the order
        }
    };
});
