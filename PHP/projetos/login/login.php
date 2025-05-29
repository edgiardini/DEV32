<?php
//CONEXÃO COM O BANCO DE DADOS
include('conectadb.php');

//ATIVA A VARIÁVEL E USO DA SESSÃO
session_start();

if($_SERVER['REQUEST_METHOD']=='POST'){
    //COLETA OS DADOS DO CAMPO DE TEXTO DO HTML
    $login = $_POST['txtlogin'];
    $senha = $_POST['txtsenha'];

    //COMUNICA COM O BANCO MONTANDO AS QUERIES
    $sql = "SELECT COUNT(usu_id) FROM usuarios WHERE usu_login = '$login' AND USU_SENHA = '$senha'";

    //ENVIANDO A QUERY PARA O BANCO
    $enviaquery = mysqli_query($link, $sql);

    //RETORNO DO QUE VEM DO BANCO
    $retorno = mysqli_fetch_array($enviaquery) [0];

    //VALIDAÇÃO DO RETORNO
    if($retorno == 1){

        $sql = "INSERT INTO usuario (USU_LOGIN, USU_SENHA) VALUES('$login', '$senha')";

        $_SESSION['nomeusuario'] = $login;


        Header("Location: home.php");
    }
    else{
        echo"<script>window.alert('USUÁRIO OU SENHA INCORRETOS');</script>";
    }   

}

?>


<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="estilo.css">
    <title>LOGIN</title>
</head>
<body>

<div class="global">
    <div class="formulario">
        
    <form id='login' action="login.php" method="post">
        <label>LOGIN</label>
        <br>
        <input type='text' name='txtlogin' placeholder='Digite seu login'>
        <label></label>
        <br>
        <input type='password' name='txtsenha' placeholder='Senha aqui'>

        <br>
        <input type='submit' value='LOGIN'>
        
</form>

<br>
<a href='cadastra.php'>NÃO TEM CONTA? CLIQUE AQUI</a>


</div>

</div>

    
</body>
</html>

