using pooEx1;
/*
-------------PROGRAMAÇÃO ORIENTADA A OBJETOS(POO)----------------

POO -> PARADIGMA DE PROGRAMAÇÃO
    OBJETO -> É ALGO MATERIAL OU ABSTRATO QUE PODE SER DESCRITO POR
    CARACTERISTICAS, COMPORTAMENTOS E ESTADOS.

    PRIMEIRO PILAR -> ABSTRAÇÃO SELECINAR O QUE INTERESSA NO MOMENTO
    
    CARACTERISCAS -> ATRIBUTOS
    COMPORTAMENTOS -> MÉTODOS
    ESTADOS -> ESTADO (COMO O OBJETO ESTÁ NO MOMENTO)

    CLASSE -> MOLDE DOS OBJETOS

    VISIBILIDADE DE CLASSE, ATRIBUTO E METODOS
        PUBLIC (PUBLICA) -> todos os arquivos(classes) podem visualizar/acessar os dados
        PRIVATE (PRIVADA) -> apenas a classe pode acessar os metodos/atributos internos
        PROTECTED (PROTEGIDA) -> pode ser utilizada apenas por classes filhas ou mesmo pacote
*/
Celular c1 = new Celular(); // instanciar -> gerar um objeto a partir de uma classe
c1.cor = "azul";
c1.tamTela = 8;
c1.memoria = 4;
c1.armazenamento = 16;
c1.processador = "snapdragon 886";
c1.numCameras = 3;
c1.ligado = true;
Celular c2 = new Celular();
c2.cor = "preto";
c2.tamTela = 12;
c2.memoria = 16;
c2.armazenamento = 1000;
c2.processador = "snapdragon 886";
c2.numCameras = 5;
c2.ligado = true;
c2.bateria = 100;

c2.MostrarBateria();
c2.TirarFoto();
c2.MostrarBateria();
c2.Telefonar();
c2.MandarMsg();
c2.MandarMsg();
c2.MostrarBateria();
c2.Carregar();
c2.TirarFoto();
c2.ligado = false;
c2.Mostrar();



