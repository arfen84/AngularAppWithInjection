(function () {
    'use strict';

    angular
        .module('app', ['ui.bootstrap'])
        .controller('HotelCtrl', HotelCtrl)
        .controller('WeselnyCtrl', WeselnyCtrl)
        .controller('ApartCtrl', ApartCtrl)
        .controller('BankietowaCtrl', BankietowaCtrl)
        .controller('SPACtrl', SPACtrl)
        .controller('KlubCtrl', KlubCtrl)
        .controller('KarczmaCtrl', KarczmaCtrl)
        .controller('PubCtrl', PubCtrl)
        .controller('KawiarniaCtrl', KawiarniaCtrl)
        .controller('EscapeCtrl', EscapeCtrl)
        .controller('AgroCtrl', AgroCtrl)
        .controller('ZabawCtrl', ZabawCtrl)
        .controller('WspinaczkowaCtrl', WspinaczkowaCtrl)
        .controller('DomCtrl', DomCtrl)
        .controller('DomkiCtrl', DomkiCtrl)
        .controller('RekreacjaCtrl', RekreacjaCtrl)
        .controller('EventowaCtrl', EventowaCtrl)
        .controller('RestCtrl', RestCtrl);

    RestCtrl.$inject = ['$scope', '$modal'];

    function RestCtrl($scope, $modal) {
        
            $scope.openModal = function (data) {

                var modalInstance = $modal.open({
                    templateUrl: 'mainRestauracja.html',
                    controller: 'RestModalCtrl',
                  
                    resolve: {
                        data: function () {
                            return data === null ? {} : data;
                        }
                    }
                });

                modalInstance.result.then(function (result) {

                    if (result) {
                        // ...do something on modal close result
                    }
                }, function () {
                    //$log.info('Modal dismissed at: ' + new Date());
                });
            };
    }

    HotelCtrl.$inject = ['$scope', '$modal'];

    function HotelCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainHotel.html',
                controller: 'HotelModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    WeselnyCtrl.$inject = ['$scope', '$modal'];

    function WeselnyCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainWeselny.html',
                controller: 'WeselnyModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    ApartCtrl.$inject = ['$scope', '$modal'];

    function ApartCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainApart.html',
                controller: 'ApartModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    BankietowaCtrl.$inject = ['$scope', '$modal'];

    function BankietowaCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainBankietowa.html',
                controller: 'BankietowaModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }
    BankietowaCtrl.$inject = ['$scope', '$modal'];

    function SPACtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainSPA.html',
                controller: 'SPAModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    KlubCtrl.$inject = ['$scope', '$modal'];

    function KlubCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainKlub.html',
                controller: 'KlubModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    KarczmaCtrl.$inject = ['$scope', '$modal'];

    function KarczmaCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainKarczma.html',
                controller: 'KarczmaModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    PubCtrl.$inject = ['$scope', '$modal'];

    function PubCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainPub.html',
                controller: 'PubModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    KawiarniaCtrl.$inject = ['$scope', '$modal'];

    function KawiarniaCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainKawiarnia.html',
                controller: 'KawiarniaModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    EscapeCtrl.$inject = ['$scope', '$modal'];

    function EscapeCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainEscape.html',
                controller: 'EscapeModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    AgroCtrl.$inject = ['$scope', '$modal'];

    function AgroCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainAgro.html',
                controller: 'AgroModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }
    ZabawCtrl.$inject = ['$scope', '$modal'];

    function ZabawCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainZabaw.html',
                controller: 'ZabawModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }
    WspinaczkowaCtrl.$inject = ['$scope', '$modal'];

    function WspinaczkowaCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainWspinaczkowa.html',
                controller: 'WspinaczkowaModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }
    DomCtrl.$inject = ['$scope', '$modal'];

    function DomCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainDom.html',
                controller: 'DomModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    DomkiCtrl.$inject = ['$scope', '$modal'];

    function DomkiCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainDomki.html',
                controller: 'DomkiModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }
    RekreacjaCtrl.$inject = ['$scope', '$modal'];

    function RekreacjaCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainRekreacja.html',
                controller: 'RekreacjaModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }

    EventowaCtrl.$inject = ['$scope', '$modal'];

    function EventowaCtrl($scope, $modal) {

        $scope.openModal = function (data) {

            var modalInstance = $modal.open({
                templateUrl: 'mainEventowa.html',
                controller: 'EventowaModalCtrl',

                resolve: {
                    data: function () {
                        return data === null ? {} : data;
                    }
                }
            });

            modalInstance.result.then(function (result) {

                if (result) {
                    // ...do something on modal close result
                }
            }, function () {
                //$log.info('Modal dismissed at: ' + new Date());
            });
        };
    }



})();




