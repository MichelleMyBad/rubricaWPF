# rubricaWPF
## Descrizione
#### Esercizio WPF che si occupa della gestione di contatti all'interno di una rubrica, creando due classi contenenti attributi e metodi capaci di gestire le diverse operazioni da eseguire.

## Soluzione utilizzata
Ecco qui di sotto la spiegazione sulla creazione della classe <b><i>Contatto</i></b> e <b><i>Rubrica</i></b>.

### Guide utili 
 
<details>
<summary>Creazione di una classe in Visual Studio</summary>
Per prima cosa sarà necessario capire come preare una nuova classe all'interno del nostro progetto, ecco qui di sotto una semplice guida.
<br><br>
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
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/55e9a6b4-06e8-4289-914e-717fe44921b7" width="500" height="290">
<br><br>
Troveremo ora la nuova classe all'interno del nostro progetto.<br>
<img src="https://github.com/MichelleMyBad/rubricaWPF/assets/127590227/0f0b970f-558d-47cf-92cb-2a0c3f78965a" width="185" height="180">
<br>
</details>

### Creazione delle classi
 
<details>
<summary>Contatto</summary>
La prima cosa da fare sarà creare la classe <b><i>Contatto</i></b> con i suoi attributi e metodi.
<details>
<summary>Attributi</summary>
    
```c#
internal class Contatto
{
    private int numero;
    private string nome;
    private string cognome;
```

Iniziamo col creare gli attributi necessari : <b><i>numero</i></b>, <b><i>nome</i></b> e <b><i>cognome</i></b>. Li dichiariamo come privati, di modo che non siano direttamente modificabili, rispettando così l'incapsulamento.<br>
<br>

```c#
    public int Numero { get => numero; set => numero = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Cognome { get => cognome; set => cognome = value; }
```    


Proseguiamo poi col creare una property per attributo, di modo da poterci accedere al di fuori della nostra classe.
</details>

<details>
<summary>Metodi</summary>

</details>
<br>
</details>

<details>
<summary>Rubrica</summary>
Proseguiamo ora con la creazione della nostra classe rubrica, che dovrà essere in grado di gestire ino a 100 oggetti di tipo <b><i>Contatto</i></b>.
<details>
<summary>Attributi</summary>
</details>
<details>
<summary>Metodi</summary>
</details>
</details>

### Sperimentazione con le classi 







