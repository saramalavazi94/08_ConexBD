// See https://aka.ms/new-console-template for more information
using _08_ConexBD;

//ConexaoSimples conexaoSimples = new ConexaoSimples();
ConexaoFlexivel conexaoFlexivel = new ConexaoFlexivel();

conexaoFlexivel.executaQuery( "SELECT * FROM tarefas;");
conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE id = 16;");
conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE descricao LIKE '%tud%';");

