// workoutController.js

(function () {

    "use strict";

    // Getting the existing module
    angular.module("workout-addWorkout")
    .controller("workoutController", workoutController);

    function workoutController($http)
    {
        var vm = this;
        
        vm.workouts = [];

        vm.newWorkout = {};

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("api/workouts")
        .then(function (response) {
            //Success
            angular.copy(response.data, vm.workouts);
        }, function (error) {
            //Failure
            // called asynchronously if an error occurs
            // or server returns response with an error status.
            vm.errorMessage = "Faild to load data: " + error;
        })
        .finally(function () {
            vm.isBusy = false;
        });

        vm.addWorkout = function () {         
            vm.isBusy = true;
            vm.errorMessage = "";

            $http.post("api/workouts", vm.newWorkout)
            .then(function (response) {
                //Success
                vm.workouts.push(response.data);
                vm.newWorkout = {};
            }, function () {
                // Failure
                vm.errorMessage = "Faild to save new workout";
            })
            .finally(function () {
                vm.isBusy = false;
            });
        };
    }

})();