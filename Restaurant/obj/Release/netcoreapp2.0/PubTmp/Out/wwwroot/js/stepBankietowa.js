﻿(function () {
    'use strict';

    angular
        .module('app')
        .controller('BankietowaModalCtrl', BankietowaModalCtrl);

    BankietowaModalCtrl.$inject = ['$scope', '$modalInstance', 'data'];

    function BankietowaModalCtrl($scope, $modalInstance, data) {
        $scope.data = data;
       
        $scope.steps = [
            { number: 1 },
            { number: 2 },
            { number: 3 },
            { number: 4 },
            { number: 5 },
            { number: 6 },
            { number: 7 },
            { number: 8 },
            { number: 9 },
            { number: 10 }
           

        ];

        $scope.currentStep = angular.copy($scope.steps[0]);

        $scope.cancel = function () {
            $modalInstance.dismiss('cancel');
        };
        
       
        var $lokal = '';
        var $przyjecie = '';
        var $iloscGosci = '';
        var $rodzajKuchni = '';
        var $bezalkoholowe = '';
        var $wnoszenieAlkoholu = false;
        var $alkohol = '';
        var $oczekiwania = '';
        var $uslugi = '';
        var $miejscowosc = '';
        var $termin = '';
        var $klimat = '';
        var $budzet = '';
        var $email = '';
        var $wiadomosc = '';
        var $uwagi = '';
        $scope.restauracja = function () {
            var $lokal = 'sala bankietowa';
            $email = $('input[name=email]').val();
            
            $.ajax({
                url: "/Home/Bankietowa",
                type: "POST",
                data: { email: $email, lokal: $lokal, iloscGosci: $iloscGosci, bezalkoholowe: $bezalkoholowe, alkohol: $alkohol, oczekiwania: $oczekiwania, uslugi: $uslugi, miejscowosc: $miejscowosc,  budzet: $budzet },
            success: function (response) {
               
            },
        error: function (response) {

        }
    });

        };

        $scope.nextStep = function () {
            // Perform current step actions and show next step:
            // E.g. save form data
            var $val = '';
            var nextNumber = $scope.currentStep.number;
            if (nextNumber == 1) {
               
                    $("input:checkbox[name=przyjecie]:checked").each(function () {
                        $val =$val+ " "+ $(this).val();
                    });
                   
                    $przyjecie = $('input[name=przyjecie2]').val() + $val;
                   
            }
            if (nextNumber == 2)
            {
                if ($("input[name=goscie2]").val() == '')
                {
                    //$("input[name=goscie]:checked").each(function () {
                    //    $val =  $(this).val();
                    //});

                    $iloscGosci = $('input[name=goscie]:checked').val();
                }
                else {
                    $iloscGosci = $('input[name=goscie2]').val();
                }
                //alert($iloscGosci);
                
               
            }
            if (nextNumber == 3) {
                $("input:checkbox[name=rodzajKuchni]:checked").each(function () {
                    $val = $val + " " + $(this).val();
                });

                $rodzajKuchni = $('input[name=rodzajKuchni2]').val() + $val;
                //alert($rodzajKuchni);
              
            }
            if (nextNumber == 4) {


                $miejscowosc = $('input[name=miejscowosc]').val() + $val;
                //alert($miejscowosc);
            }
            
            if (nextNumber == 5) {
                $("input:checkbox[name=oczekiwania]:checked").each(function () {
                    $val = $val + " " + $(this).val();
                });

                $oczekiwania = $('input[name=oczekiwania2]').val() + $val;
                //alert($oczekiwania);
            }
            if (nextNumber == 6) {
                $("input:checkbox[name=uslugi]:checked").each(function () {
                    $val = $val + " " + $(this).val();
                });

                $uslugi = $('input[name=uslugi2]').val() + $val;
                //alert($uslugi);
            }
            
          
            if (nextNumber == 7) {
                $("input:checkbox[name=klimat]:checked").each(function () {
                    $val = $val + " " + $(this).val();
                });

                $klimat = $('input[name=klimat2]').val() + $val;
               
               
            }
            if (nextNumber == 8) {
                if ($("input[name=budzet2]").val() == '') {
                  

                    $budzet = $('input[name=budzet]:checked').val();


                }
                else {
                    $budzet = $('input[name=budzet2]').val();
                }
               
               
            }
            if (nextNumber == 9) {
               
                $uwagi = $('textarea[name=uwagi]').val();
               
                
            }
            

            if ( nextNumber == 10) {
                $modalInstance.dismiss('cancel');
            }
            $scope.currentStep = angular.copy($scope.steps[nextNumber]);
        };

        $scope.prevStep = function () {
          
           
            var prevNumber = $scope.currentStep.number;
            prevNumber = prevNumber - 2;
            $scope.currentStep = angular.copy($scope.steps[prevNumber]);
        };

    }

})();