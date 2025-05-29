<?php
//CONEXÃO COM O BANCO DE DADOS
include('conectadb.php');

//ATIVA A VARIÁVEL E USO DA SESSÃO
session_start();

if($_SERVER['REQUEST_METHOD']=='POST'){
    //COLETA OS DADOS DO CAMPO DE TEXTO DO HTML
    $login = $_POST['txtlogin'];
    $senha = $_POST['txtsenha'];

    //PESQUISA NO BANCO CONTANDO USUARIOS
    $sql = "SELECT COUNT(usu_login) FROM usuarios WHERE usu_login = '$login'";

    //ENVIANDO A QUERY PARA O BANCO
    $enviaquery = mysqli_query($link, $sql);

    //RETORNO DO QUE VEM DO BANCO
    $retorno = mysqli_fetch_array($enviaquery) [0];

    //VALIDAÇÃO DO RETORNO
    if($retorno == 0){

        $sql = "INSERT INTO usuarios (USU_LOGIN, USU_SENHA) VALUES('$login', '$senha')";

        //ENVIA A QUERY PARA O BANCO
        $enviaquery = mysqli_query($link, $sql); 

        echo("<script>window.alert('USUÁRIO CADASTRADO!');</script>");
        echo"<script>window.location.href='login.php';</script>";

    }
    else{
        echo"<script>window.alert('USUÁRIO JÁ CADASTRADO');</script>";
    }   

}

?>


<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="estilo.css">
    <title>CADASTRO</title>
</head>
<body>

<div class="global">
    <div class="formulario">
        
    <form id='cadastra' action="cadastra.php" method="post">
        <label>CADASTRO</label>
        <br>
        <input type='text' name='txtlogin' placeholder='Crie seu usuário' required>
        <br>
        <label>SENHA</label>
        <br>
        <input type='password' name='txtsenha' placeholder=' Crie sua senha' required>

        <br>
        <input type='submit' value='CADASTRAR'>
        
</form>

<br>
<a href='login.php'>JÁ TEM CADASTRO? FAÇA SEU LOGIN</a>


</div>

</div>

    
</body>
</html>

