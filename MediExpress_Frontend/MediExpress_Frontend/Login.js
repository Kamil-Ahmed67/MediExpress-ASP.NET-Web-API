var loginApp = angular.module('loginApp', []);

loginApp.controller('LoginController', function ($scope, $window) {
    $scope.credentials = {
        username: '',
        password: ''
    };

    $scope.selectedUserType = 'admin'; // Default user type

    $scope.loginError = '';

    $scope.login = function () {
        // Perform authentication logic here
        var userType = $scope.selectedUserType;
        var username = $scope.credentials.username;
        var password = $scope.credentials.password;

        // Mock authentication logic (replace with actual authentication logic)
        if (userType === 'admin' && username === 'admin' && password === 'admin') {
            $window.location.href = 'admin_panel.html'; // Redirect to admin panel
        } else if (userType === 'pharmacist' && username === 'pharmacist' && password === 'pharmacist') {
            $window.location.href = 'pharmacist_panel.html'; // Redirect to pharmacist panel
        } else if (userType === 'customer' && username === 'customer' && password === 'customer') {
            $window.location.href = 'customer_panel.html'; // Redirect to customer panel
        } else {
            $scope.loginError = 'Invalid credentials';
        }
    };
});
