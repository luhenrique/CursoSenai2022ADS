/*
    PROGAMAÇÃO ORIENTADA A OBJETOS 
        CLASSES 
        OBJETOS 
        ESTADOS
-----------PILARES DO POO-------------
    1 - ABSTRAÇÃO 
    2 - ENCAPSULAMENTO
            public -> todo mundo pode acessar
            private -> apenas a propria classe
            protected -> herdeiros
*/
Baralho b4 = new Baralho();
Baralho b3 = new Baralho("Aviator","poker size", "preto");
Baralho b1 = new Baralho("bicycle", "bridge", "vermelho"); //instanciar -> criar um objeto a partir de uma classe
Baralho b2 = new Baralho("Talihoo", "poker", "azul");
b2.Abrir();
b2.JogarTruco();
