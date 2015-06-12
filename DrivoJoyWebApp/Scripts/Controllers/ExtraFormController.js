var SellFormController = function ($scope, RTOFormService) {

    $scope.submitForm = function () {


        var Details = [];

        //Make the Details.Transaction ID if needed
        Details[0] = $scope.BuyerFullName;
        Details[1] = $scope.SellerFullName;
        Details[2] = $scope.Seller_Son_Wife_Daughter_Of;
        Details[3] = $scope.VehicleNumber;
        Details[4] = $scope.EngineNumber;
        Details[5] = $scope.ChassisNumber;
        Details[6] = $scope.PeriodOfStayInState;
        Details[7] = $scope.PeriodUptoWhichVehicleTaxPaid;

        if ($scope.ImportantDetails.PendingTaxDetails.$pristine)
            Details[8] = "null";
        else
            Details[8] = $scope.ImportantDetails.PendingTaxDetails;

        if ($scope.ImportantDetails.IsInvolvedInTheft.$pristine)
            Details[9] = "null";
        else
            Details[9] = $scope.ImportantDetails.IsInvolvedInTheft;

        if ($scope.ImportantDetails.IsSection53_54_55Pending.$pristine)
            Details[10] = "null";
        else
            Details[10] = $scope.ImportantDetails.IsSection53_54_55Pending;

        if ($scope.ImportantDetails.IsInvolvedInProhibitedGoods.$pristine)
            Details[11] = "null";
        else
            Details[12] = $scope.ImportantDetails.IsInvolvedInProhibitedGoods;


        if ($scope.ImportantDetails.IsUnderAgreement.$pristine)
            Details[13] = "null";
        else
            Details[13] = $scope.ImportantDetails.IsUnderAgreement;
        


        RTOFormService.ExtraSubmitInfo(Details);
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