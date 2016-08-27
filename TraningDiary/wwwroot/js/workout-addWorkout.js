// workout-addWorkout.js

(function () {
    
    "use strict";

    // Creating the module. [] = defines where you can put the dependencies.
    angular.module("workout-addWorkout", ["simpleControls", "ngRoute"])
    .config(function ($routeProvider) {

        $routeProvider.when("/", {
            controller: "workoutController",
            controllerAs: "vm",
            templateUrl: "/views/addWorkoutView.html"
        });

        $routeProvider.when("/editor/:workoutId", {
            controller: "workoutEditorController",
            controllerAs: "vm",
            templateUrl: "views/workoutEditorView.html"
        });

        $routeProvider.otherwise({ redirectTo: "/" });
    });

})();