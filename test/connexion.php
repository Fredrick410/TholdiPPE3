<?php 
    session_start();
    require_once '_gestionBase_inc.php';
    include_once "_head_inc.php";
?>


<!DOCTYPE html>
    <html lang="fr">
        <head>
            <meta charset="UTF-8">
            <meta name="viewport" content="width=device-width, initial-scale=1.0">
            <meta name="author" content="NoS1gnal"/>

            <link href="https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/magnific-popup.min.css" rel="stylesheet" />
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
            <title>Connexion</title>
        </head>
        <body>
        
        <div class="login-form">
             
                            <div class="alert alert-danger">
                                <strong>Erreur</strong> mot de passe incorrect
                            </div>
                        
                            <div class="alert alert-danger">
                                <strong>Erreur</strong> email incorrect
                            </div>
                     
                            <div class="alert alert-danger">
                                <strong>Erreur</strong> compte non existant
                            </div>
                       
            
            <form method="post" action="connexion_traitement.php">
                <h2 class="text-center">Connexion</h2>       
                <div class="form-group">
                    <input type="login" name="login" class="form-control" placeholder="login" required="required" autocomplete="off">
                </div>
                <div class="form-group">
                    <input type="mdp" name="mdp" class="form-control" placeholder="mdp" required="required" autocomplete="off">
                </div>
                <div class="form-group">
                    <button type="submit" class="btn btn-primary btn-block">Connexion</button>
                </div>   
            </form>
            <p class="text-center"><a href="inscription.php">Inscription</a></p>
        </div>

        <style>
            .login-form {
                width: 340px;
                margin: 50px auto;
            }
            .login-form form {
                margin-bottom: 15px;
                background: #f7f7f7;
                box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
                padding: 30px;
            }
            .login-form h2 {
                margin: 0 0 15px;
            }
            .form-control, .btn {
                min-height: 38px;
                border-radius: 2px;
            }
            .btn {        
                font-size: 15px;
                font-weight: bold;
            }

            body
            {
                background-color: #4169E1;
            }
            
        </style>
        </body>
</html>