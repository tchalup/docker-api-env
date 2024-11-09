# Docker-Api-Env
Implementação de API com docker e variáveis de ambiente.

## Docker run

`docker run --name=docker-api-env --env=ASPNETCORE_ENVIRONMENT=Development --env=custom__parameter=env-teste -p 8080:8080 -p 8081:8081 -d dockerapi:latest`
- **--name**:
  Nome do container
- **--env**:
  Variáveis de ambiente.
- **-p**:
  Mapeamento das portas expostas no container.
- **-d (*detached*)**:
  O terminal é liberado para você executar outros comandos, enquanto o container continua rodando em background
