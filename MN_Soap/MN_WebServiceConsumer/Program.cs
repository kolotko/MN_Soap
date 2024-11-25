using static ServiceReference1.ExampleServiceSoapClient;

var calculateRequest = new ServiceReference1.CalculateRequest();
calculateRequest.A = 5;
calculateRequest.B = 10;

var client = new ServiceReference1.ExampleServiceSoapClient(EndpointConfiguration.ExampleServiceSoap12);
var result = await client.CalculateAsync(calculateRequest);
Console.WriteLine(result.Result);
