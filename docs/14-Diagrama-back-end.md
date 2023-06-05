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
