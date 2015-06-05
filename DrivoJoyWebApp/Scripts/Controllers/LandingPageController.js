var LandingPageController = function ($scope, RTOFormService) {
 
    $scope.SellRTOList = ["WakeField", "KRPuram", "Domlur", "WhiteField"];
    $scope.BuyRTOList = ["WakeField", "KRPuram", "Domlur", "WhiteField"];
    $scope.Choice = ['Seller', 'Buyer'];

   
    $scope.submitForm = function () {
         
       
        var Details = {};

        //Make the Details.Transaction ID if required
        Details.FormSelected = $scope.FormSelected;
        Details.SellerRTO = $scope.SellerRTO;
        Details.BuyerRTO = $scope.BuyerRTO;
      

        var promisePost = RTOFormService.postInfo(Details);
        promisePost.then(function (d) {
            $scope.PersonId = d.data.TransactionId; //Remember to increment transactionid somehow later at the backend
        }, function (err) {
            alert("Some Error Occured ");
        });
    };

};

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
LandingPageController.$inject = ['$scope', 'RTOFormService'];