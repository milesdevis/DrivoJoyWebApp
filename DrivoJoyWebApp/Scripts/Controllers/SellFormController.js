var SellFormController = function ($scope, RTOFormService) {

   $scope.submitForm = function () {


       var Details = [];

       //Make the Details.Transaction ID if needed
        Details[0] = $scope.SellerFullName;
        Details[1] = $scope.Buyer_Son_Wife_Daughter_Of;
        Details[2] = $scope.BuyerFullName;
        Details[3] = $scope.DateOfTransfer;
        Details[4] = $scope.VehicleNumber;
        Details[5] = $scope.ChassisNumber;
        Details[6] = $scope.EngineNumber;
        Details[7] = $scope.SellerAddress;
        Details[8] = $scope.BuyerAddress;
       


         RTOFormService.SellSubmitInfo(Details);
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