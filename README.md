# BattleMetricsAPI

Para rodar a solução você deve clonar a aplicação em uma pasta desejada usando git clone https://github.com/LucasJ-22/BattleMetricsAPI

Após isso ao baixar a solução e querer executa-la a partir do visual studio code você deve abrir o terminal do aplicativo e executar o comando
dotnet run
No terminal aparecerá a porta que está executando Ex.: http://localhost:5133/ e para acessar a aplicação deverá escrever na URL swagger ficando (http://localhost:5133/swagger)

Porém caso queira executar usando o visual studio é so executa-lo normalmente.


# Processo de desenvolvimento
Primeiramente acessei a documentação da api para entender como funciona e poder utiliza-la sem ter algum problema na hora de colocar no projeto.
Após isso pesquisei para definir a arquitetura a ser utilizada no projeto. Optei pela arquitetura em camadas, pois pelo projeto nao ser grande
quis evitar overengineering, mas o deixando preparado para escalabilidade caso o projeto cresça.
