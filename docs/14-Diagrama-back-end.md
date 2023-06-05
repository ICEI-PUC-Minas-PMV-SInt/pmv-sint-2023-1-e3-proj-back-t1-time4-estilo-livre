+-----------------+       +-----------------+
|     Cliente     |       |      Usuário    |
+-----------------+       +-----------------+
| - idCliente     |       | - idUsuário     |
| - nome          |       | - nome          |
| - sobrenome     |       | - email         |
| - endereco      |       | - senha         |
| - telefone      |       |                 |
+-----------------+       +-----------------+
       |                          |
       |                          |
       |                          |
       |                          |
       |                          |
       v                          v
+-----------------+       +-----------------+
|    ClienteDAO   |       |   UsuárioDAO    |
+-----------------+       +-----------------+
| + cadastrar()   |       | + cadastrar()   |
| + atualizar()   |       | + atualizar()   |
| + excluir()     |       | + excluir()     |
| + buscarPorId() |       | + buscarPorId() |
| + buscarTodos() |       | + buscarTodos() |
+-----------------+       +-----------------+
![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-1-e3-proj-back-t1-time4-estilo-livre/assets/80776887/214018c7-79db-4e83-a94a-01a1c7b2db7e)
