# CryptoApi

Detta projekt kör ett enkelt API genom och använder en CI/CD pipeline kopplat till aws. När något mergas till main branchen så buildas
C# .NET projektet och körs i AWS. 

I Detta exempel är två endpoints skapade för en enkel encrypt och decrypt där cesar chiper används. Som parameter skickas en sträng som ska krypteras samt hur många steg som shiftas i cesar chipern. Det samma gäller dekrypteringen.

URL till endpoints är :

http://encryptionanddecryptionapi-env.eba-9ni2neg3.eu-north-1.elasticbeanstalk.com/api/crypto/encrypt

http://encryptionanddecryptionapi-env.eba-9ni2neg3.eu-north-1.elasticbeanstalk.com/api/crypto/decrypt

Swagger är också konfigurerad i .NET och man kan använda UI för att testa API:n

http://encryptionanddecryptionapi-env.eba-9ni2neg3.eu-north-1.elasticbeanstalk.com/swagger/index.html

