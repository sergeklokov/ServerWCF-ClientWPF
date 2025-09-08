Playing with WCF Server - WPF Client in older .NET Framework 4.7.2

Used:
1. MS Tuturial
https://learn.microsoft.com/en-us/dotnet/framework/wcf/getting-started-tutorial

============ WCF Library ============
1. Default command line argumetns to run WCF Test Client:
	/client:"WcfTestClient.exe"

============ WCF Self hosting Console app ============
1. add reference the System.ServiceModel assembly in your project.
2. add Reference → select your WCF Service Library project
3. Grant URL reservation to your user:
	- open cmd as Administrator
	- run the command below (change DOMAIN\username to your user)
	- more info: https://learn.microsoft.com/en-us/dotnet/framework/wcf/feature-details/how-to-configure-a-windows-service-to-host-a-wcf-service

	netsh http add urlacl url=http://+:8080/Service1/ user=azuread\sergeklokov

	Note: if error happens:
	System.ServiceModel.AddressAccessDeniedException: 'HTTP could not register URL http://+:8080/Service1/. 
	Your process does not have access rights to this namespace (see http://go.microsoft.com/fwlink/?LinkId=70353 for details).'


4. Get your user name:
	- open cmd
	- run command: whoami

5. Run WCF Test client in CMD:
"C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\IDE\WcfTestClient.exe"

	Add service:
	http://localhost:8733/Design_Time_Addresses/ServerWCF/Service1/
	http://localhost:8733/Design_Time_Addresses/ServerWCF/Service1/mex


============ WPF ============