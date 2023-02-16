using Solid.DIP.DIP_Aderente;

var connection = new MySqlConnection();

RecuperarSenha recuperarSenha = new RecuperarSenha(connection);
recuperarSenha.ConnectioDb();

