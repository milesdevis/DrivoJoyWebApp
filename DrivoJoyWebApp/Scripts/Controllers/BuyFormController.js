var BuyFormController = function ($scope, RTOFormService) {

    $scope.submitForm = function () {


        var Details = {};

        //Make the Details.Transaction ID if needed
        Details.SellerFullName = $scope.SellerFullName;
        Details.Seller_Son_Wife_Duaghter_Of = $scope.Seller_Son_Wife_Duaghter_Of;
        Details.BuyerFullName = $scope.BuyerFullName;
        Details.DateOfTransfer = $scope.DateOfTransfer;
        Details.RegistrationMark = $scope.RegistrationMark;
        Details.Buyer_Son_Wife_Duaghter_Of = $scope.Buyer_Son_Wife_Duaghter_Of;
        Details.BuyerAddress = $scope.BuyerAddress;
      


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
BuyFormController.$inject = ['$scope', 'RTOFormService'];