﻿var RTOFormService =  function ($http) {

 //   this.getInfo = function (id) {
 //     var req = $http.get('/api/PersonInformationAPI/' + id);
 //     return req;
 //   };

 //    this.getAppInfo = function () {
 //       var req = $http.get('/api/PersonInformationAPI');
 //     return req;
 //   }
    this.SellSubmitInfo = function (Details) {
        $http.post('/Form/SellSubmit', Details);
    };

    this.ExtraSubmitInfo = function (Details) {
        $http.post('/Form/ExtraSubmit', Details);
    };
    this.BuySubmitInfo = function (Details) {
        $http.post('/Form/BuySubmit', Details);
    };

    this.postInfo = function (Details) {

        
        
        

        if (Details[0] == 'Seller') {
            if (Details[1] == Details[2]) {
                $http.post('/Form/Form_29', Details);

            }

            if (Details[1] != Details[2]) {
                $http.post('/Form/Form_28', Details);

            }

        }


        if (Details[0] == 'Buyer') {
            if (Details[1] == Details[2]) {
                $http.post('/Form/Form_30', Details);

            }

            if (Details[1] != Details[2]) {
                $http.post('/Form/Form_28', Details);

            }
        }


    };

};

RTOFormService.$inject = ['$http'];