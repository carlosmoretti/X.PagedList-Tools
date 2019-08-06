# Objetivo
Recentemente utilizei a biblioteca X.PagedList, um fork da nativa PagedList, muito utilizada em projetos MVC baseados em .NET e encontrei alguns problemas na versão 5 do MVC. Algumas soluções dadas são alterações na versão do assembly do MVC, porém no meu caso continuou sem funcionar.


# Solução
Desenvolvi a solução abaixo para solucionar este problema e ainda assim, facilitar e permitir que o uso da biblioteca seja padronizado, visto que os métodos necessários para aplicação estão expostos no código.

# Como usar?
A source encontra-se disponível neste repositório, você pode gerar a DLL e importar no seu projeto ou importar o próprio projeto para que possa customiza-lo.

## Links de apoio criados no repo oficial.
https://github.com/dncuug/X.PagedList/issues/107
https://github.com/dncuug/X.PagedList/issues/12
https://stackoverflow.com/questions/27842517/version-conflict-with-system-web-mvc
