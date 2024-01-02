var medicineShopApp = angular.module('medicineShopApp', []);

medicineShopApp.controller('HomeController', function ($scope) {
    $scope.products = [
        { name: 'Medicine A', price: 10 },
        { name: 'Medicine B', price: 15 },
        { name: 'Medicine C', price: 20 }
    ];

    $scope.cart = [];
$scope.searchQuery = ''; // Initialize search query

    $scope.searchProducts = function () {
        // Filter products based on search query
        if ($scope.searchQuery) {
            $scope.filteredProducts = $scope.products.filter(function (product) {
                return product.name.toLowerCase().includes($scope.searchQuery.toLowerCase());
            });
        } else {
            $scope.filteredProducts = $scope.products; // If no search query, show all products
        }
    };

    // Initially, show all products
    $scope.filteredProducts = $scope.products;
    $scope.addToCart = function (product) {
        $scope.cart.push(product);
    };
});
