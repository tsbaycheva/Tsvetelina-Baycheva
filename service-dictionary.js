(function (angular) {
    'use strict';

    angular
        .module('app')
        .factory('dictionary', service);

    service.$inject = ["$http"];

    function service($http) {


       

        var current = {};

        var data = [];

        return {
           data: data,
           add: add,
           edit: edit,
           save: save,
           remove: remove,
           cancel: cancel,
           current: current,
           whatIDo: whatIDo,
           get: get
        };

        function get() {
             return $http({
                method: 'GET',
                url: 'http://localhost:3001/dictionary'
             })
            .then(function (res) {
                //console.log(res.data)
                _.each(res.data, function (d) {
                    data.push(d);
                })
            })
        }

        function put () {
            return $http({
                method: 'PUT',
                url: 'http://localhost:3001/dictionary'
             })
        }

        function add(name, description) {
            data.push({name: name, description: description});

        }

        function edit(x) {
            current = angular.copy(x);
            x.editMode = true;
        };

         function save(x) {
                x.editMode = false;
            };

         function remove(index) {
            data.splice(index, 1);
        };

         function cancel(x) {
            x.editMode = false;
            x.name = current.name;
            x.description = current.description;
        }

        function whatIDo() {
            return ['Add Exercise', 'Edit Exercise', 'Delete Exercise'];
        }
    }

}(angular));
