var SellFormController = function ($scope, RTOFormService) {

    $scope.submitForm = function () {


        var Details = {};

        //Make the Details.Transaction ID if needed
        Details.SellerFullName = $scope.SellerFullName;
        Details.Buyer_Son_Wife_Duaghter_Of = $scope.Buyer_Son_Wife_Duaghter_Of;
        Details.BuyerFullName = $scope.BuyerFullName;
        Details.DateOfTransfer = $scope.DateOfTransfer;
        Details.VehicleNumber = $scope.VehicleNumber;
        Details.ChassisNumber = $scope.ChassisNumber;
        Details.EngineNumber = $scope.EngineNumber;
        Details.SellerAddress = $scope.SellerAddress;
        Details.BuyerAddress = $scope.BuyerAddress;
        Details.Make = $scope.Make;


        RTOFormService.SubmitInfo(Details);
        /* promisePost.then(function (d) {
             $scope.PersonId = d.data.TransactionId; //Remember to increment transactionid somehow later at the backend
         }, function (err) {
             alert("Some Error Occured ");
         });
         */
    };

};

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
SellFormController.$inject = ['$scope', 'RTOFormService'];