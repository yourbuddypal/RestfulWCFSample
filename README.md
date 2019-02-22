# RestfulWCFSample
A simple sample WCF service that has a REST endpoint.

When run with IIS Express, you can hit it similar to this: (note, port may vary)
http://localhost:59843/SampleService.svc/GetSomeData?param1=Hello%20Web

Which will return :
    "You sent 'Hello Web'"

If you attempt to hit the PostSomeData endpoint from the web browser (which would use an HTTP Get operation), it won't work!
http://localhost:59843/SampleService.svc/PostSomeData?param1=Input&param2=OtherInput
    Method not allowed.

	
Alternatively, you can use a rest client like Postman to interact with the service.

You can do an HTTP Get:

![Postman Http Get](https://user-images.githubusercontent.com/7199097/53203943-1909b300-35f0-11e9-9dbc-79f343962570.png)


An HTTP Post with query string parameters:

![Postman Query String](https://user-images.githubusercontent.com/7199097/53203947-1ad37680-35f0-11e9-9cb9-0b235148af8d.png)


Or an HTTP Post with the content in the request body:

![Postman body content](https://user-images.githubusercontent.com/7199097/53204071-5ec67b80-35f0-11e9-90ab-e699bde10182.png)
