function my_function(message) {
    console.log("from utilies" + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("Movie_Application.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript" + result);
        });
}