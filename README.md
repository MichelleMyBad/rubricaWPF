# rubricaWPF
## Descrizione
#### Esercizio WPF che si occupa della gestione di contatti all'interno di una rubrica, creando due classi contenenti attributi e metodi capaci di gestire le diverse operazioni da eseguire.

<details>
  <summary><h4>Contatto</h4></summary>
  La prima cosa da fare sarà creare la classe <b><i>Contatto</i></b> con i suoi attributi e metodi.
  <br>
  <details>
    <summary>Attributi</summary>
    Iniziamo col creare gli attributi

    ```c#
    internal class Contatto
    {
        private int numero;
        private string nome;
        private string cognome;
    ```
    
    Iniziamo col creare gli attributi necessari : <b><i>numero</i></b>, <b><i>nome</i></b> e <b><i>cognome</i></b>. Li dichiariamo come privati, di modo che non siano direttamente modificabili, rispettando così l'incapsulamento.<br>
 

    
        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        


    Proseguiamo poi col creare una property per attributo, di modo da poterci accedere al di fuori della nostra classe.
  </details>

  <details>
    <summary>Metodi</summary>
    Proseguiamo poi col creare i metodi necessari alla nostra classe <b><i>Contatto</i></b>
  </details>
</details>

<details>
  <summary><h4>Rubrica</h4></summary>
  Proseguiamo ora con la creazione della nostra classe rubrica, che dovrà essere in grado di gestire ino a 100 oggetti di tipo <b><i>Contatto</i></b>.
  <br>
  <details>
    <summary>Attributi</summary>
  </details>
    <details>
    <summary>Metodi</summary>
  </details>
</details>








