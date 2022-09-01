# estagio-estudos

### Tópicos para estudos 🎫

#### 1️⃣ Decimal no SQL Server:
##### Decimais são usados quando precisamos utilizar números com extrema precisão. A sintaxe do Decimal no SQL é a seguinte:

### decimal [(p, [,s])]
##### onde:
##### P representa Precisão, o total de dígitos no valor em ambos lados da vírgula
##### S representa Scale, número de dígitos depois da vírgula

#### O valor default para a precisão é 18 e pra scale é 0 e para estes dois valores o mínimo é 1 e o máximo é 38.
#### Por exemplo, a instância ' decimal (4,2) indica que o número vai ter 2 dígitos antes e depois da vírgula com a precisão de 4 números, sendo algo como ##.##

#### Decimal (15,9) : 6 antes + 9 após 
#### Decimal (12,8) : 4 antes + 8 após
#### Decimal (13,5) : 8 antes + 5 após ...
