(function (angular) {
    'use strict';

    angular
        .module('app')
        .factory('dictionary', service);

    service.$inject = ['$dictionary'];

    function service($dictionary) {

        var table = {
            {
            'name' : 'kljenj',
            'description' : 'kvbejiobneriovbrnvbier'
             },
             {
            'name' : 'njedogjer',
            'description': 'klnbbbolmoebenrobvrnme'
            },
            {
            'name' : 'nejvne',
            'description': 'lkvnmoblerkn'
            },
        }

        return {
           getDictionary: table
        };
    }

}(angular));