//LOGIN FB
//[1] Load các thành phần cần thiết
window.fbAsyncInit = function () {
    FB.init({
        appId: '3062992443809180',
        cookie: true,
        xfbml: true,
        version: 'v8.0'
    });

    FB.AppEvents.logPageView();
    
    FB.getLoginStatus(function (response) {
        statusChangeCallback(response);
    });

};

(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement(s); js.id = id;
    js.src = "https://connect.facebook.net/en_US/sdk.js";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));


//[2] Xử lý trạng thái đăng nhập
function statusChangeCallback(response) {  
    console.log('statusChangeCallback');
    console.log(response);                   
    if (response.status === 'connected') {
        testAPI();
    } else {
        alert('login di');
    }
}

//[3] Yêu cầu đăng nhập FB
function RequestLoginFB() {
    window.location = 'https://graph.facebook.com/oauth/authorize?client_id=3062992443809180&scope=public_profile,email&redirect_uri=https://localhost:44336/'
}

//[4] API
function testAPI() {
    FB.api(
        '/me',
        'GET',
        { "fields": "id,name,email" },
        function (response) {
            alert('Hello  ' + response.name + ' Email: ' + response.email + ' ID:  ' + response.id);
        }
    );
}


//END LOGIN FB------------------------------------

//Login Google====================
function onSignIn(googleUser) {
    var profile = googleUser.getBasicProfile();
    console.log('ID: ' + profile.getId()); // Do not send to your backend! Use an ID token instead.
    console.log('Name: ' + profile.getName());
    console.log('Image URL: ' + profile.getImageUrl());
    console.log('Email: ' + profile.getEmail()); // This is null if the 'email' scope is not present.
    alert('Email: ' + profile.getEmail());
}

    //button G