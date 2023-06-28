using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Lecture : MonoBehaviour
{
    public TMP_Text title;
    public TMP_Text context;
    public Button nextButton;
    public Button backButton;

    private int i = 0;

    public int planetIndex = 0;

    private string[] jupiterTitlesString = { "", "1) Pianeta simile al Sole", "2) Giove rispetto alla Terra", "3) Così lontano, così vicino", "4) Pianeta di Lune", "5) Primato anche nel campo magnetico",
                                       "6) Il pianeta più grande ma anche il più veloce", "7) Pianeta degli anelli", "8) Temporali simili a quelli terrestri", "9) Piovono diamanti", "10) La temperatura di Giove"  };
    private string[] jupiterContextsString = {
        "Giove è il più grande pianeta del Sistema Solare. È il quinto pianeta rispetto al Sole, ed è collocato tra Marte e Saturno. A causa delle sue eccezionali dimensioni tra tutti i corpi celesti che ruotano intorno alla nostra stella, è conosciuto fin dall’antichità. I Romani gli diedero infatti questo nome, quello del padre degli dei, in nome della sua grandezza.\n\nClicca 'Avanti' per leggere 10 affascinanti curiosità sul pianeta più grande del Sistema Solare!",
        "Giove è un pianeta simile al sole poiché dalla sua composizione interna risulta essere un pianeta gassoso, costituito principalmente da idrogeno ed elio (proprio come la nostra stella), con piccole quantità di altri composti come ammoniaca, metano ed acqua.\nAl telescopio, la sua atmosfera appare come una nuvola con strisce e macchie colorate. La formazione colorata più grande, chiamata Grande Macchia Rossa, è una gigantesca tempesta, grande diverse volte più della Terra, che si manifesta ininterrottamente da più di 300 anni.",
        "Sono necessarie 122 Terre per eguagliare la superficie del grosso pianeta, che potrebbe ospitare al suo interno fino a 1300 copie del nostro. Se invece si parla di massa, quella di Giove è 317 volte quella della Terra e due volte e mezzo quella di tutti gli altri pianeti del Sistema Solare combinate insieme. Ciò implica che la gravità del gigante è due volte e mezzo quella della Terra, e che quindi una persona che qui pesa 100 Kg, lì ne pesa 250.",
        "Nonostante la distanza minima di Giove dalla Terra sia 588 milioni di chilometri, il gigante del Sistema Solare è visibile ad occhio nudo, essendo il terzo corpo celeste più brillante nella porzione di Universo che orbita intorno alla nostra stella, dopo la Luna e Venere. Con un buon binocolo o un piccolo telescopio, Giove appare come un piccolo disco bianco e risultano visibili anche le sue quattro lune più luminose.",
        "Giove è un pianeta circondato da lune: sono più di 60. Quattro di queste furono scoperte nel 1610 da Galileo Galilei, ovvero Io, Europa, Callisto e Ganimede.\nEuropa, è consideratada da alcuni esperti come la probabile candidata più vicina a noi ad ospitare la vita, per via della presenza di acqua liquida sotto la sua superficie.\nA causa dell’enorme forza di gravità esercitata da Giove, la maggior parte delle lune non si sono formate attorno al pianeta, ma sono state catturate da questo nella sua orbita.",
        "Giove è il pianeta con il campo magnetico più forte, quattordici volte quello della Terra. Alcuni astronomi ritengono che questo sia dovuto al movimento dell’idrogeno metallico che si trova in profondità all’interno del pianeta. Il campo magnetico cattura particelle ionizzate dal vento solare accelerando ad una velocità prossima a quella della luce e generando radiazioni che lo circondano. Questo provoca danni a qualsiasi veicolo spaziale che tenti di avvicinarsi al pianeta. Infatti , Giove è storicamente studiato solamente da remoto via telescopio.",
        "Nonostante la sua incredibile massa il gigante è anche il pianeta con il più veloce moto rotatorio intorno al proprio asse. Una giornata, su Giove, dura infatti appena 10 ore. Questo contribuisce ad aumentare il suo campo magnetico. Non così, tuttavia, per il moto di rivoluzione: Giove infatti impiega 12 dei nostri anni per compiere un’intera orbita intorno al Sole.",
        "Giove ha tre anelli, anche se molto sottili, il principale dei quali è il risultato della scia di polvere lasciata dalla collisione di meteoriti con le sue quattro lune più interne (Tebe, Metis, Adrastea e Almathea).",
        "Giove è profondamente differente dalla Terra, per dimensioni, distanza dal Sole, velocità, condizioni climatiche e tanto altro, ma i suoi temporali hanno somiglianze con quelli che si verificano sul nostro pianeta. La loro durata media è di circa 3-4 giorni, ma in alcuni casi possono durare anche mesi. Quelli su Giove, tuttavia, sono molto più rari: i più potenti, infatti, si verificano in media ogni 15-17 anni.",
        "Seconda uno studio della Nasa, su Giove e su Saturno piovono diamanti, ciò dipende dalla reazione chimica tra i violenti fulmini ed il metano presente in questi pianeti",
        "Giove è cinque volte più distante dal Sole rispetto alla Terra, perciò la temperatura sulla sua superficie è molto bassa, attorno ai –145°C. Ogni 13 mesi circa si avvicina alla Terra e diventa molto luminoso nel cielo notturno."
    };

    private string[] neptuneTitlesString = {
        "", "1) Un nome 'sbagliato'", "2) Il pianeta dalla 'Grande Macchia Scura'", "3) Il pianeta blu", "4) Il pianeta 'disturbatore'", "5) Il pianeta multipolare", "6) Un campo magnetico rovesciato",
        "7) Il pianeta dagli anelli disomogenei", "8) Lune in continua scoperta", "9) Tritone, la luna retrograda", "10) Piogge di diamanti"};
    private string[] neptuneContextsString = {
        "L’ottavo pianeta del Sistema Solare, il quarto per diametro e il terzo per massa. Gelato e continuamente colpito da venti supersonici, il pianeta è l’ultimo dei giganti gassosi fatti di idrogeno ed elio. Nettuno è di colore blu brillante. Impiega quasi 165 anni terrestri per compiere un moto di rivoluzione completo. Nettuno è più grande della Terra, ma gira piuttosto velocemente, considerando che un giorno dura solo 16 ore e 7 minuti. Il pianeta è normalmente invisibile a occhio nudo dalla Terra.\nClicca 'Avanti' per leggere 10 affascinanti curiosità sul pianeta Nettuno.",
        "Nettuno è il dio dei mari, ma il pianeta che porta il suo nome è in realtà il Signore dei Venti. Il corpo celeste possiede infatti i venti più forti di ogni altro pianeta nel Sistema Solare. Sono state misurate raffiche a velocità superiori ai 2 mila km/h, quasi il doppio della velocità del suono (1191,60 Km/h), tre volte più forti di quelli di Giove e nove volte quelli terrestri.\nUn nome mitologico più adeguato forse sarebbe stato 'Eolo'.",
        "Non solo venti. Nettuno è caratterizzato anche da terribili tempeste. Nel 1989 fu scoperta dalla sonda Voyager 2 la Grande Macchia Scura, un sistema di tempeste anticiclonico delle dimensioni di 13000 × 6600 km, che ricordava la Grande Macchia Rossa di Giove.",
        "Nettuno è noto come 'pianeta blu', ma perché questa singolare colorazione? Nelle regioni più profonde sono stati rilevati ammoniaca, acqua e metano, che, interagendo con la luce del Sole, gli conferiscono il caratteristico colore. L’intensità del blu fa comunque sospettare che ci sia anche un’altra componente, attualmente sconosciuta.",
        "Nettuno non fu scoperto, ma cercato. La sua enorme distanza lo rende invisibile ad occhio nudo, e in realtà nemmeno i telescopi più antichi avevano inizialmente inquadrato questo freddissimo pianeta gassoso. Ma qualcosa 'disturbava' l’orbita di Urano, scoperto da William Herschel nel 1781. Dopo aver ipotizzato degli errori nella legge di gravitazione universale, il 23 settembre 1846 Johann Gottfried Galle scoprì il pianeta ipotizzato l'anno prima da Urbain Le Verrier.\nE Newton fu salvo.",
        "Mentre sulla Terra (come su altri pianeti) esistono un polo nord e un polo sud magnetici, il gigante gassoso ha invece molteplici poli, in questo simile solo a Urano. Un recente studio pubblicato su Nature Communication mostra la possibilità che sul pianeta esista un nuovo stato della materia, il ghiaccio superionico, possibile causa di questa singolarità.",
        "Nettuno non è solo multipolare. Il campo magnetico complessivo, infatti, circa 27 volte più potente di quello della Terra, è rovesciato di circa 47 gradi rispetto all’asse di rotazione del pianeta. Per questo la magnetosfera del gigante pianeta subisce fortissime variazioni durante ogni rotazione.",
        "Nettuno ha sei anelli conosciuti, deboli rispetto al Signore degli Anelli Saturno, ma particolari. Osservazioni della Voyager 2, l’unica sonda che ha sorvolato da vicino il remoto pianeta, hanno confermato infatti che questi anelli insoliti non sono uniformi, ma hanno quattro grosse regioni più 'dense' chiamate archi. Si ritiene che tali formazioni siano relativamente giovani e di breve vita.",
        "Nettuno ha 13 satelliti attualmente noti, ma, essendo un pianeta più “sconosciuto” di altri del nostro Sistema Solare, non si può affermare con certezza che siano veramente tutte. Uno di questi satelliti ha un diametro di circa 15 km e si classifica come il più piccolo satellite naturale del sistema nettuniano.",
        "Tritone, la più grande luna di Nettuno, orbita in direzione opposta rispetto alle sue compagne, suggerendo che potrebbe essere stata catturata da Nettuno in un lontano passato. Gelida (-235° C in superficie), emette geyser di materia ghiacciata fino a più di 8 km. Cosa ancora più curiosa, la sua atmosfera si sta surriscaldando, ma gli scienziati ancora non sanno perché. Nel 2012, inoltre, si ipotizzò che il satellite potesse contenere un oceano sotterraneo.",
        "Su Nettuno non c’è acqua (almeno non in quantità significativa) ma piove. E data l’altissima concentrazione di carbonio è probabile che le gocce abbiano la stessa composizione dei diamanti.\nQuindi perché non trasferirci tutti lì ?!"
    };

    private string[] saturnTitlesString = { "", "1) Un pianeta mitologico", "2) Ti basterebbe passarci il lunedì per sentirti più giovane", "3) Anelli", "4) Un’atmosfera a colori e non solo", "5) Satelliti naturali",
        "6) Può galleggiare sull'acqua", "7) Un clima non troppo piacevole", "8) Mille modi per morire", "9) Vivere su titanio", "10) Saturno nella Divina Commedia" };
    private string[] saturnContextsString = {
        "È il sesto pianeta del sistema solare in ordine di distanza dal Sole e il secondo pianeta più massiccio dopo Giove assieme a Giove compone il 92% della massa planetaria totale del sistema solare. Ha un raggio medio 9,48 volte quello della Terra e una massa 95 volte superiore a quella terrestre. Saturno, con Giove, Urano e Nettuno, è classificato come gigante gassoso poiché gli strati esterni sono costituiti prevalentemente da gas e manca di una superficie definita, anche se potrebbe avere un nucleo solido. Saturno appare visibilmente schiacciato ai poli.\nClicca 'Avanti' per leggere 10 affascinanti curiosità su Saturno.",
        "Nell'antica mitologia romana il dio Saturno, da cui il pianeta prende il nome,  era  dell'agricoltura. Nella mitologia romana corrispondeva alla divinità greca Crono. Il suo simbolo astronomico (♄) è una rappresentazione stilizzata della falce del dio dell'agricoltura. Saturno è composto per il 95% da idrogeno e per il 3% da elio a cui seguono gli altri elementi.",
        "Saturno ha il secondo giorno più corto nel sistema solare: un giorno su Saturno si stima duri solo 10 ore 32 minuti e 35 secondi. Invece compie un’orbita completa attorno al Sole (un anno nel tempo di Saturno) in circa 29.458 anni (sulla Terra). Un'ottima soluzione se le vostre giornate al lavoro non passano mai e se volete convincervi di compiere gli anni più lentamente!",
        "Saturno ha un esteso e vistoso sistema di anelli che consistono principalmente in particelle di ghiaccio e polveri di silicati. Non tutti gli anelli sono statici, però. Nonostante le immagini che arrivano dallo spazio mostrino un sistema apparentemente immobile nei suoi moti di rotazione e di rivoluzione, in realtà un anello in particolare, indicato con la lettera F, è in continua evoluzione. L'origine degli anelli è sconosciuta. Ci sono due ipotesi principali al riguardo: che siano il risultato della distruzione di un satellite di Saturno, provocata da una collisione con una cometa o con un altro satellite, oppure che siano un 'avanzo' del materiale da cui si formò Saturno che non è riuscito ad assemblarsi in un corpo unico.",
        "L’atmosfera di Saturno si manifesta sottoforma di fasce di differente colore ma soltanto all’equatore queste diventano facilmente individuabili, ma cosa ancora più attraente è il contenuto di acqua.",
        "Saturno possiede un elevato numero di satelliti naturali, infatti detiene il primato per il maggior numero di satelliti del sistema solare. Tra queste, Titano è la maggiore ed anche l'unica luna del sistema solare ad avere un'atmosfera significativa È difficile quantificare con precisione il loro numero, perché tecnicamente tutti i minuscoli corpi ghiacciati che compongono gli anelli di Saturno sono da considerarsi satelliti.",
        "La densità media di Saturno è inferiore a quella dell’acqua (0,69 g/cm³), tale da renderlo l’unico pianeta del nostro sistema solare che potrebbe galleggiare in una vasca da bagno (se ne esistesse una cosa così grande da poterlo contenere e non considerassimo altri effetti!).",
        "Saturno è ricoperto di nuvole, con diverse sfumature di giallo, marrone e grigio. I venti nell’alta atmosfera raggiungono i 500 metri al secondo nella regione equatoriale, 5 volte di più degli uragani più forti sul nostro pianeta!  Il polo nord di Saturno ha una particolare forma esagonale che si estende per 30.000 km.",
        "Saturno non ha quella che noi definiamo una “superficie”. Se una navicella spaziale volesse raggiungere il pianeta non avrebbe un posto dove atterrare su Saturno e non sarebbe nemmeno in grado di attraversarlo indenne. Le pressioni e le temperature estreme nelle profondità del pianeta schiacciano, sciolgono e vaporizzano chiunque provi ad entrare. Come avrete già capito, Saturno non possiede le condizioni favorevoli allo sviluppo della vita come la conosciamo a causa di temperature e pressioni troppo estreme affinché la vita si adatti ad esse.",
        "Saturno non soddisfa le condizioni necessarie per la vita come la conosciamo noi. Tuttavia, alcuni satelliti del pianeta ad anelli, in particolare Titano ed Encelado, potrebbero essere in grado di sostenere la vita. La superficie di Titano è uno dei luoghi più simili alla Terra di tutto il sistema solare.",
        "Il pianeta compare nella Divina Commedia, e in particolare nel Canto ventunesimo del Paradiso, dove rappresenta il settimo Cielo, caratterizzato dalla meditazione e dalla contemplazione."
    };

    public void Next()
    {
        if(i < 10) i++;
        string titleString = "";
        string contextString = "";
        if(planetIndex == 0)
        {
            titleString = jupiterTitlesString[i];
            contextString = jupiterContextsString[i];
        } else if (planetIndex == 1)
        {
            titleString = saturnTitlesString[i];
            contextString = saturnContextsString[i];
        } else
        {
            titleString = neptuneTitlesString[i];
            contextString = neptuneContextsString[i];
        }
        title.SetText(titleString);
        context.SetText(contextString);
        if (i == 10) nextButton.interactable = false;
        else nextButton.interactable = true;
        if (i > 0) backButton.interactable = true;
    }

    public void Back()
    {
        if (i > 0) i--;
        string titleString = "";
        string contextString = "";
        if (planetIndex == 0)
        {
            titleString = jupiterTitlesString[i];
            contextString = jupiterContextsString[i];
        }
        else if (planetIndex == 1)
        {
            titleString = saturnTitlesString[i];
            contextString = saturnContextsString[i];
        }
        else
        {
            titleString = neptuneTitlesString[i];
            contextString = neptuneContextsString[i];
        }
        title.SetText(titleString);
        context.SetText(contextString);
        if (i == 0) backButton.interactable = false;
        else backButton.interactable = true;
        if (i < 10) nextButton.interactable = true;
    }
}
