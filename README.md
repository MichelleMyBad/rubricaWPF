# rubricaWPF
## Descrizione
#### Esercizio WPF che si occupa della gestione di contatti all'interno di una rubrica, creando due classi contenenti attributi e metodi capaci di gestire le diverse operazioni da eseguire.

## Soluzione utilizzata
Ecco qui di sotto la spiegazione sulla creazione della classe <i>Contatto</i> e <i>Rubrica</i>.

### Guide utili 
 
<details>
<summary><a name="classe"></a>Creazione di una classe in Visual Studio</summary>
Per prima cosa facciamo click destro sul nostro progetto.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/90dde1a8-f3ab-4e0a-abbd-09eb3e3f90bd" width="195" height="120">
<br><br>
Proseguiamo poi col cliccare su <i>Aggiungi</i>,<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/d67374b4-925f-4153-893c-012d22463c1d" width="165" height="195">
<br><br>
Poi su <i>Classe</i>.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/52117758-a2d3-4526-9d43-bfed6adc5d45" width="180" height="195">
<br><br>
Continuiamo selezionando <i>Classe</i>, per poi darle un nome ed infine aggiungerla al nostro progetto.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/55e9a6b4-06e8-4289-914e-717fe44921b7" width="500" height="300">
<br><br>
Troveremo ora la nuova classe all'interno del nostro progetto.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/0f0b970f-558d-47cf-92cb-2a0c3f78965a" width="220" height="175">
<br><br>
</details>

<details>
 <summary><a name="property"></a>Creazione di una property</summary>
 Iniziamo col fare click destro sul nome del nostro attributo per poi cliccare su <i>Azioni Rapide e Refactoring</i>.
 <br>
 <img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/4ca7e889-ce60-43a6-add1-9a138c0d7e31">
 <br><br>
 Concludiamo cliccando su <i>Incapsula il campo: nomeAttributo (e usa lo proprietà)</i>
 <br>
 <img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/5ba0aee3-3a57-4f86-b813-a52baa9c996d">
 <br><br>
</details>

<details>
<summary><a name="Window_Loaded"></a>Creazione veloce metodo Window_Loaded</summary>
Per la creazione del metodo <b><i>Window_Loaded</i></b> basterà semplicemente iniziare a scrivere la <i>property</i> <b><i>Loaded</i></b> e ci verrà automaticamente consigliato un <i>New Event Handler</i>, basterà quindi cliccare sull'opzione proposta ed il metodo verrà creato automaticamente anche all'interno del nostro <i>MainWindow.xaml.cs</i>
<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/3f66689b-9938-4a22-8251-e93d378c20ac">
<br><br>
</details>

<details>
<summary><a name="LoadingRow"></a>Creazione veloce metodo dgDati_LoadingRow</summary>
Facciamo click sinistro sulla nostra <i>DataGrid</i> per poi andare a controllarne le <i>properties</i>.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/7d03c312-1408-426a-963c-e1152a149d40"><br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/01f15468-8753-4139-a145-d70599b4f767" width="275" height="395">
<br><br>
Cerchiamo ora la <i>LoadingRow</i>, per poi fare doppio click sullo spazio subito a destra, di modo da creare automaticamente il metodo <b><i>dgDati_LoadingRow</i></b>.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/d779fb4a-5aa1-4817-84fd-c8384f46d95d" width="275" height="395">
</details>

<details>
<summary><a name="csv"></a>Creazione file .csv</summary>
Iniziamo col fare click destro sul nostro progetto.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/90dde1a8-f3ab-4e0a-abbd-09eb3e3f90bd" width="195" height="120">
<br><br>
Clicchiamo su <i>Aggiungi</i>.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/d67374b4-925f-4153-893c-012d22463c1d" width="165" height="195">
<br><br>
Click su <i>Nuovo oggetto</i>. <br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/48792af7-e7c5-432e-8a19-03c350217580" width="305" height="335">
<br><br>
Creiamo infine il nostro file con estensione .csv. <br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/078dfba4-4826-433e-ad77-2095513f63e2">
<br><br>
Ricordiamoci infine di selezionare <i>Copy Always</i> all'interno delle proprietà del sostro file .csv per permettergli di creare il file nella stessa cartella del programma compilato, passaggio essenziale in quanto, se dimenticato, in caso si voglia richiamare il file all'interno del codice risulterà inesistente.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/816e2f29-0f64-48dd-b8c4-21c1a58cf9ce">
<br><br>
</details>





### Creazione della classe Contatto
Guide utilizzate :<br>
["creazione di una classe in Visual Studio"](#classe) <br>
["creazione di una property"](#property)
<details>
<summary>Contatto</summary>
La prima cosa da fare sarà creare la classe <i>Contatto</i> con i suoi attributi e metodi.
<details>
<summary>Attributi</summary>
    
```c#
internal class Contatto
{
    private string _numero;
    private string _cognome;
    private int _telefono;
```

Iniziamo col creare gli attributi necessari : <b><i>_numero</i></b>, <b><i>_cognome</i></b> e <b><i>_telefono</i></b>. Li dichiariamo come privati, di modo che non siano direttamente modificabili, rispettando così l'incapsulamento.<br>
<br>

```c#
    public string Nome { get; set; } // crea l'attributo senza esplicitarla
    public string Cognome { get => _cognome; set => _cognome = value; }
    public int Telefono { get => _telefono; set => _telefono = value; }
```    


Proseguiamo poi col creare una <i>property</i> per attributo, di modo da poterci accedere al di fuori della nostra classe. Per l'attributo <b><i>_nome</i></b> proviamo ad utilizzare una <i>property</i> che si occuperà di creare l'attributo senza esplicitarlo.
<br>
<br>

```c#
public int Numero {
    get {
        return _numero;
    }
    set {
        if (value < 0 || value > 100)
            throw new ArgumentOutOfRangeException();

        _numero = value; // value è il valore che gli passiamo, parola di c# che funziona in automatico  
        
    }
}
```
Per la creazione della <i>property</i> per il nostro attributo <b><i>_numero</i></b> la situazione sarà un po' più complicata, dato che per il <i>set</i> sarà necessario controllare che il valore non sfori dal nostro range di 100 elementi.
</details>


<details>
<summary>Costruttori</summary>



```c#
public Contatto() { }
```
Creiamo per prima cosa il costruttore di default.
<br><br>

```c#
public Contatto(int numero, string nome, string cognome, string telefono)
{
    Numero = numero;
    Nome = nome;
    Cognome = cognome;
    Telefono = telefono;
}
```
Proseguiamo con il creare un costruttore da utilizzare in caso si vogliano preimpostare i valori di tutti gli attributi.
<br><br>

```c#
public Contatto (string riga)
{
    string[] campi = riga.Split(';');


    if (campi.Length >= 4)
    {
        int pk=0; //chiave identificativa
        int.TryParse(campi[0], out pk);// prova a convertire la variabile e metterla in pk, se non è un intero mette 0  
        this.Numero = pk;
        this.Nome = campi[1];
        this.Cognome = campi[2];
        this.Telefono = campi[3];
    }


}

```
Concludiamo col creare un costruttore che si occupa di ricavare da una <i>stringa</i> i dati necessare ad inizzializzare il nostro oggetto.


</details>

</details>
<br>

### XAML
Guide utilizzate :<br> 
["creazione veloce del metodo Window_Loaded"](#Window_Loaded) <br>
["creazione veloce del metodo dgDati_LoadingRow"](#LoadingRow)


<details>
<summary>XAML</summary>

Occupiamoci ora di alcuni accorgimenti necessari nel nostro <i>MainWindow.xaml</i>.

```xml
<Window x:Class="Rubrica.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Rubrica"
        mc:Ignorable="d"
        Title="Rubrica" 
        Height="450" Width="800"
        WindowStartupLocation="CenterScreen" 
        Loaded="Window_Loaded"
        >
```
Oggiungiamo le <i>property</i> <b><i>WindowStartupLocation="CenterScreen"</i></b>, per fare in modo che il nostro programma venga visualizzato al centro dello schermo, e  <b><i>Loaded="Window_Loaded"</i></b> per fare in modo di avere una funzione che viene chiamata una volta caricata la parte grafica del programma.
<br><br>

```xml
<Grid>
    <DataGrid x:Name="dgDati" LoadingRow="dgDati_LoadingRow"></DataGrid>
</Grid>
```
Creaiamo poi una griglia, all'interno della quale inserire una <b><i>DataGrid</i></b> nella quale andare poi a mostrare graficamente la nostra lista di contatti. Ricordiamoci di creare il metodo <i><b>dsDati_LoadingRow</b></i> tramite <i>property</i>, il quale si occupera di gestire operazioni al caricamento di ogni riga.

</details>
<br>

### Creazione del file .csv
Guide utilizzate :<br>
[Creazione file .csv](#csv)
<details>
<summary>Dati.csv</summary>

Proseguiamo col creare un file csv nel quale inserire i dati da andare a leggere per la creazione dei contatti.
<br>

```csv
PK;Nome;Cognome;Telefono
```
Seguiamo questa struttura per la scrittura dei diversi contatti, con PK facente da chiave identificativa per il singolo contatto.
</details>
<br>

### Creazione della Rubrica
<details>
<summary>Rubrica</summary>
Proseguiamo ora con la creazione della nostra rubrica, che dovrà essere in grado di gestire fino a 100 oggetti di tipo <i>Contatto</i>. <br><br>

```c#
public partial class MainWindow : Window
{
    Brush background;
    public MainWindow() 
    {
        InitializeComponent(); 
        background = dgDati.Background;
    }
```
Prima di tutto creaiamo un <i>Brush</i> nel quale immagazzinare il colore di default da mettere come sfondo per le righe contenenti un contatto valido.

<details>
<summary>Window_Loaded</summary>

```c#
private void Window_Loaded(object sender, RoutedEventArgs e) //fa tutto dopo che viene caricata la grafica
{
    int idx = 0;
```
Iniziamo col creare un indice che ci permetta di riempire il nostro vettore di <i><b>Contatto</b></i>.<br><br>

```c#
    try
    {
        const int MAX = 100;

        StreamReader fin = new StreamReader("Dati.csv");
        fin.ReadLine();

        Contatto[] contatti = new Contatto[MAX];

        while (!fin.EndOfStream)
        {
            if (idx < MAX) // metto le parti del csv finchè ci stanno, se sono più di 100 non ci stanno più quindi smettere di inserirle se no va in errore
            {
                string riga = fin.ReadLine();
                Contatto c = new Contatto(riga);
                contatti[idx++] = c;
            }
            else { break; }
        }

        for (; idx < MAX; idx++) // creo i contatti vuoti se c'è ancora spazio
        {
            Contatto c = new Contatto();
            contatti[idx] = c;
        }

        dgDati.ItemsSource = contatti;
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Nono\n {ex.Message} alla riga numero {idx}");
    }
}
```
Proseguiamo con un <i><b>try-catch</b></i>, all'interno del quale creare un array di <i><b>Contatto</b></i> nel quale inserire, finchè dsponibile, contatti presi dal file <i>Dati.csv</i>, per poi finire di riempire il vettore con contatti vuoti.

</details>
<details>
<summary>dsDati_LoadingRow</summary>

```c#
private void dgDati_LoadingRow(object sender, DataGridRowEventArgs e)
{
    Contatto c = e.Row.Item as Contatto;//as ti mette l'item in c solo se è un contatto
    if (c != null) {

        if (c.Numero != 0 && c.Telefono[0] == '3') { 
        
            e.Row.Background = Brushes.Yellow;

        }
        else if (c.Numero == 0)
        {
            e.Row.Background= Brushes.Red;
        }
        else
        {
            e.Row.Background= background;
        }
    }
}
```
All'interno del metodo <i><b>dgDati_LoadingRow</b></i> ci occuperemo invece di inserire in ogni rriga della <i>Grid</i> un contatto che, in caso sia vuoto o presenti una chiave identificativa invalida, verrà colorato interamente di rosso, in caso abbia un numero di telefono che inizi per <i>3</i> verrà colorato in giallo, altrimenti sarà colorato con il colore di default salvato in precedenza (vedi immagine).<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/242c6cd2-b0a1-47ea-9e8c-2eba0e2878cd" width="750" height="450">
</details>
</details>







