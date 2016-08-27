// workoutEditorController.js
(function () {
    "use strict";

    angular.module("workout-addWorkout")
        .controller("workoutEditorController", workoutEditorController);

    function workoutEditorController($routeParams, $http) {

        var vm = this;

        vm.workoutId = $routeParams.workoutId;
        vm.workout = [];
        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("api/workouts/" + vm.workoutId + "/type")
        .then(function (response) {
            // Succsess
            angular.copy(response.data, vm.workout);
        }, function (err) {
            // Failure
            vm.errorMessage = "Faild to load stops";
        })
        .finally(function () {
            vm.isBusy = false;
        });
    }
})();