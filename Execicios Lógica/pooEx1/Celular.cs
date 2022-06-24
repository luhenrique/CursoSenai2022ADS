namespace pooEx1{

    public class Celular{

    //ATRIBUTOS (CARACTERISTICAS)
        public string cor = "";
        public int tamTela;
        public int memoria;
        public int armazenamento;
        public string processador = "";
        public int numCameras;
        public int bateria {get;  set; }
        public bool ligado; //estado
        
    //METODOS
        public void Telefonar(){

            this.Descarregar();
            if(this.ligado == false){
                Console.WriteLine("Não posso telefonar, pois estou desligado");
            }else{
                Console.WriteLine("Estou telefonando para alguem");
            }
        }
        public void TirarFoto(){
            this.Descarregar();
            if(this.ligado == false){
                Console.WriteLine("Não posso tirar foto, pois estou desligado");
            }else{
                Console.WriteLine("Tirando foto");
            }
        }
        public void MandarMsg(){
            this.Descarregar();         
            if(this.ligado == false){
                Console.WriteLine("Não posso mandar mensagem, pois estou desligado");
            }else{
                Console.WriteLine("Estou mandando mensagem para alguem");
               
            }
        }
        public void MostrarBateria(){
            Console.WriteLine($"A bateria esta em {this.bateria}%");
        }
        public void Descarregar(){
            this.bateria -= 10;
            if(this.bateria == 0){
                Console.WriteLine("Desligando");
                this.ligado = false;
            }
        }
        public void Carregar(){
            this.bateria = 100;
            this.ligado = true;
            Console.WriteLine("Carregando");
            for(int i = 0; i < 10; i++){
                Console.Write("=");
                Thread.Sleep(250);
            }
            Console.WriteLine("\nBateria carregada");
        }
        public void Mostrar(){
            Console.Write($"A cor do celular é {this.cor}\n" +
                              $"A memoria é de {this.memoria}\n" +
                              $"A bateria está com {this.bateria}%\n" +
                              "O celular está ");
            Console.WriteLine(this.ligado ? "Ligado" : "Desligado" );
        }
    }

}

