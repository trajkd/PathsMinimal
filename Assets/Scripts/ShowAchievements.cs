using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class ShowAchievements : MonoBehaviour
{
    [SerializeField]GameObject simpleImage;
    [SerializeField]GameObject popupBackground;
    [SerializeField]GameObject achievementPopup;
    static string[] achievementsNames;
    Dictionary<string, Dictionary<string, Tuple<string, string>>> achievementsTitlesAndDescriptions;
    void Awake() {
        if (!PlayerPrefs.HasKey("achievements")) {
            PlayerPrefs.SetString("achievements", "");
        }
        achievementsNames = PlayerPrefs.GetString("achievements").Split('|');
    }
    public void Start() {
        achievementsTitlesAndDescriptions = new Dictionary<string, Dictionary<string, Tuple<string, string>>>() {
            ["English"] = new Dictionary<string, Tuple<string, string>>() {
                ["mathematicalmind"] = new Tuple <string, string>("Mathematical mind", "Choose Maths instead of History"),
                ["historiansoul"] = new Tuple <string, string>("Historian soul", "Choose History instead of Maths"),
                ["toocoolforschool"] = new Tuple <string, string>("Too cool for school", "State that History and Maths are useless"),
                ["cultureisaweapon"] = new Tuple <string, string>("Culture is a weapon", "Destroy the family photo with Grandpa's book"),
                ["grankiller"] = new Tuple <string, string>("Gran killer", "Let grandma die"),
                ["imsingleandidontmingle"] = new Tuple <string, string>("I'm single and I don't mingle", "Say no to Dave"),
                ["itsadate"] = new Tuple <string, string>("It's a date", "Say yes to Dave"),
                ["queenofsass"] = new Tuple <string, string>("Queen of Sass!", "Select all sarcastic options in the dialogue in the car"),
                ["foreshadowing"] = new Tuple <string, string>("Foreshadowing", "Wish to bring Grandma back"),
                ["greenthumb"] = new Tuple <string, string>("Green thumb", "You figured out that grandpa’s project is a vegetable garden"),
                ["grandpaschild"] = new Tuple <string, string>("Grandpa's child", "You decided to talk to Grandpa before talking to Grandma"),
                ["lonewolf"] = new Tuple <string, string>("Lone wolf", "You left before Grandpa could see you"),
                ["nosyparker"] = new Tuple <string, string>("Nosy Parker", "You entered the dark room without knocking"),
                ["framedmemories"] = new Tuple <string, string>("Framed memories", "You think that grandma’s habit is cool."),
                ["dramaticexits"] = new Tuple <string, string>("Dramatic exits", "It’s the second time you’ve left dramatically."),
                ["babymonitor"] = new Tuple <string, string>("Baby monitor", "You decided to go check on your brothers"),
                ["memyselfandi"] = new Tuple <string, string>("Me, myself and I", "You stayed in your room and you looked for something to do there alone"),
                ["snowballwar"] = new Tuple <string, string>("Snowball war", "You joined the twins in a snowball fight"),
                ["atrulythoughtfulsister"] = new Tuple <string, string>("A TRULY thoughtful sister", "You ignored your brothers twice"),
                ["tommywalksonthinice"] = new Tuple <string, string>("Tommy walks on thin ice!", "Tommy died"),
                ["nicsleepswithfishes"] = new Tuple <string, string>("Nic sleeps with fishes!", "Nic died"),
                ["smartone"] = new Tuple <string, string>("Smart one", "You understood immediately that you are in the past"),
                ["wisetimetraveller"] = new Tuple <string, string>("Wise Time-Traveller", "You weren’t interested in opening the hospital door"),
                ["notsosmartafterall"] = new Tuple <string, string>("Not so smart, after all", "You stated that the butterfly effect is related to the animal kingdom"),
                ["hideandseek"] = new Tuple <string, string>("Hide and seek", "You hid under the table"),
                ["kleptomaniac"] = new Tuple <string, string>("Kleptomaniac", "You stole a car model"),
                ["beavsbea"] = new Tuple <string, string>("Bea VS Bea", "You made past Beatrice mad"),
                ["averyunmerrychristmas"] = new Tuple <string, string>("A very unmerry Christmas", "You chose the Christmas memory"),
                ["theyaretwins"] = new Tuple <string, string>("They are twins!", "You chose the memory of your brothers’ birth"),
                ["oopsididitagain"] = new Tuple <string, string>("Oops I did it again", "You chose to hide under the table...again"),
                ["timebreaker"] = new Tuple <string, string>("Time Breaker", "You were recognized by past Beatrice"),
                ["aletterforyou"] = new Tuple <string, string>("A letter for you", "You've completed your first travel perfectly"),
                ["santacametotown"] = new Tuple <string, string>("Santa came to town", "You've completed your first travel perfectly"),
                ["strikethree"] = new Tuple <string, string>("Strike Three", "It's the third time you've left dramatically. It's an habit."),
                ["alittlepartyneverkillednobody"] = new Tuple <string, string>("A little party never killed nobody", "You completed your second travel perfectly"),
                ["mothersdaughter"] = new Tuple <string, string>("Mother's daughter", "You dressed up as mom"),
                ["mindhunter"] = new Tuple <string, string>("Mindhunter", "You dressed up as a recruiter"),
                ["brightimagination"] = new Tuple <string, string>("Bright Imagination", "You came up with a name for an imaginary university"),
                ["youshallnotbully"] = new Tuple <string, string>("You shall not bully!", "You completed your third travel perfectly"),
                ["naturaltalent"] = new Tuple <string, string>("Natural talent", "You completed all three travels perfectly"),
                ["secrettreasure"] = new Tuple <string, string>("Secret Treasure", "Grandpa gave you the mysterious chest"),
                ["multiverse"] = new Tuple <string, string>("Multiverse?", "You entered the alternate reality"),
                ["thatwasclose"] = new Tuple <string, string>("That was close!", "You managed to escape from little Beatrice"),
                ["over"] = new Tuple <string, string>("Over", "You were absorbed by little Beatrice"),
                ["anactofselflessness"] = new Tuple <string, string>("An act of selflessness", "You sacrificed yourself to save your past self"),
                ["averysadstory"] = new Tuple <string, string>("A very sad story", "You didn't manage to save anyone and you came back to your life"),
                ["ontherun"] = new Tuple <string, string>("On the run", "You ran away from your family"),
                ["bigsister"] = new Tuple <string, string>("Big sister", "You saved your brothers!"),
                ["gransaver"] = new Tuple <string, string>("Gran Saver", "You saved grandma!"),
                ["stuckinthepast"] = new Tuple <string, string>("Stuck in the past", "You got stuck in the past"),
                ["happiestending"] = new Tuple <string, string>("Happiest ending", "Everybody is alive!"),
                ["atrueheroine"] = new Tuple <string, string>("A true heroine", "You sacrificed yourself to save your brothers"),
                ["meandtime"] = new Tuple <string, string>("Me and time", "You chose to become a time traveller"),
                ["asplitupfamily"] = new Tuple <string, string>("A split up family", "You abandoned everyone and left with Grandma")
            },
            ["Italiano"] = new Dictionary<string, Tuple<string, string>>() {
                ["mathematicalmind"] = new Tuple <string, string>("Mente matematica", "Scegli matematica invece che storia"),
                ["historiansoul"] = new Tuple <string, string>("Spirito storico", "Scegli storia invece che matematica"),
                ["toocoolforschool"] = new Tuple <string, string>("Troppo cool per la scuola", "Dichiara che storia e matematica sono inutili"),
                ["cultureisaweapon"] = new Tuple <string, string>("La cultura è un'arma", "Distruggi la foto di famiglia con il libro del nonno"),
                ["grankiller"] = new Tuple <string, string>("Gran killer", "Fai morire la nonna"),
                ["imsingleandidontmingle"] = new Tuple <string, string>("Single e fiera", "Dì no a Dave"),
                ["itsadate"] = new Tuple <string, string>("Abbiamo un appuntamento", "Dì sì a Dave"),
                ["queenofsass"] = new Tuple <string, string>("Regina dell'Insolenza!", "Seleziona le opzioni sarcastiche nel dialogo nella macchina"),
                ["foreshadowing"] = new Tuple <string, string>("Premonizione", "Augura il ritorno della nonna"),
                ["greenthumb"] = new Tuple <string, string>("Pollice verde", "Indovina che il progetto del nonno è un orto"),
                ["grandpaschild"] = new Tuple <string, string>("Cocca del nonno", "Hai deciso di parlare con il nonno prima della nonna"),
                ["lonewolf"] = new Tuple <string, string>("Lupo solitario", "Te ne sei andata prima che il nonno ti vedesse"),
                ["nosyparker"] = new Tuple <string, string>("Impicciona", "Sei entrata nella dark room senza bussare"),
                ["framedmemories"] = new Tuple <string, string>("Memorie incorniciate", "Pensi che l’abitudine della nonna sia forte"),
                ["dramaticexits"] = new Tuple <string, string>("Uscite drammatiche", "È la seconda volta che te ne vai drammaticamente"),
                ["babymonitor"] = new Tuple <string, string>("Baby monitor", "Hai deciso di controllare i tuoi fratelli"),
                ["memyselfandi"] = new Tuple <string, string>("Sola con me stessa", "Sei rimasta in camera tua ed hai cercato qualcosa da fare da sola"),
                ["snowballwar"] = new Tuple <string, string>("Battaglia di neve", "Hai partecipato alla battaglia di palle di neve"),
                ["atrulythoughtfulsister"] = new Tuple <string, string>("Una sorella VERAMENTE premurosa", "Hai ignorato i tuoi fratelli due volte."),
                ["tommywalksonthinice"] = new Tuple <string, string>("Tommy è sul filo del rasoio!", "Tommy è morto"),
                ["nicsleepswithfishes"] = new Tuple <string, string>("Nic dorme con i pesci!", "Nic è morto"),
                ["smartone"] = new Tuple <string, string>("Sapientona", "Hai capito subito che sei nel passato"),
                ["wisetimetraveller"] = new Tuple <string, string>("Viaggiatrice saggia", "Non sei interessata ad aprire la porta dell’ospedale"),
                ["notsosmartafterall"] = new Tuple <string, string>("Non così intelligente, dopotutto", "Hai sostenuto che l’effetto farfalla sia relativo al regno animale"),
                ["hideandseek"] = new Tuple <string, string>("Nascondino", "Ti sei nascosta sotto al tavolo"),
                ["kleptomaniac"] = new Tuple <string, string>("Cleptomane", "Hai rubato il giocattolo dalla casa dei nonni"),
                ["beavsbea"] = new Tuple <string, string>("Bea contro Bea", "Fai arrabbiare la Beatrice del passato"),
                ["averyunmerrychristmas"] = new Tuple <string, string>("Un Natale terribile", "Hai scelto il ricordo natalizio"),
                ["theyaretwins"] = new Tuple <string, string>("Sono gemelli!", "Hai scelto il ricordo della nascita dei tuoi fratelli"),
                ["oopsididitagain"] = new Tuple <string, string>("Mannaggia, l’ho fatto di nuovo", "Hai deciso di nasconderti sotto al tavolo...di nuovo"),
                ["timebreaker"] = new Tuple <string, string>("Hai rotto il tempo", "La Beatrice del passato ti ha riconosciuto"),
                ["aletterforyou"] = new Tuple <string, string>("C'è posta per te", "Primo viaggio completato alla perfezione"),
                ["santacametotown"] = new Tuple <string, string>("È arrivato Babbo Natale", "Primo viaggio completato alla perfezione"),
                ["strikethree"] = new Tuple <string, string>("E con questo sono tre", "È la terza volta che esci in modo drammatico. È un'abitudine."),
                ["alittlepartyneverkillednobody"] = new Tuple <string, string>("Aria di festa", "Hai completato il secondo viaggio alla perfezione"),
                ["mothersdaughter"] = new Tuple <string, string>("Tale madre, tale figlia", "Ti sei travestita da mamma"),
                ["mindhunter"] = new Tuple <string, string>("A caccia di cervelli", "Ti sei travestita da recruiter"),
                ["brightimagination"] = new Tuple <string, string>("Grande immaginazione", "Hai inventato un nome per un'università immaginaria"),
                ["youshallnotbully"] = new Tuple <string, string>("Tu non puoi bullizzare!", "Hai completato il tuo terzo viaggio perfettamente"),
                ["naturaltalent"] = new Tuple <string, string>("Un talento naturale", "Hai completato tutti e tre i viaggi alla perfezione"),
                ["secrettreasure"] = new Tuple <string, string>("Tesoro segreto", "Il nonno ti ha dato lo scrigno"),
                ["multiverse"] = new Tuple <string, string>("Multiverso?", "Sei entrata nella realtà alternativa"),
                ["thatwasclose"] = new Tuple <string, string>("C’è mancato poco!", "Sei riuscita a scappare dalla piccola Beatrice"),
                ["over"] = new Tuple <string, string>("Fine", "Sei stata assorbita dalla piccola Beatrice"),
                ["anactofselflessness"] = new Tuple <string, string>("Un atto di altruismo", "Ti sei sacrificata per salvare la versione passata di te stessa"),
                ["averysadstory"] = new Tuple <string, string>("Una storia molto triste", "Non sei riuscita a salvare nessuno e sei tornata alla tua vita"),
                ["ontherun"] = new Tuple <string, string>("In fuga", "Sei scappata dalla tua famiglia"),
                ["bigsister"] = new Tuple <string, string>("Sorella maggiore", "Hai salvato i tuoi fratelli!"),
                ["gransaver"] = new Tuple <string, string>("Salvatrice di Nonne", "Hai salvato la nonna!"),
                ["stuckinthepast"] = new Tuple <string, string>("Bloccata nel passato", "Sei rimasta intrappolata nel passato"),
                ["happiestending"] = new Tuple <string, string>("Finale più felice", "Sono tutti vivi!"),
                ["atrueheroine"] = new Tuple <string, string>("Una vera eroina", "Ti sei sacrificata per salvare i tuoi fratelli"),
                ["meandtime"] = new Tuple <string, string>("Io e il tempo", "Hai deciso di diventare una viaggiatrice del tempo"),
                ["asplitupfamily"] = new Tuple <string, string>("Una famiglia divisa", "Hai abbandonato tutti e te ne sei andata insieme alla nonna")
            }
        };
        for (int i = 0; i < this.gameObject.transform.childCount; i++) {
            for (int j = 0; j < this.gameObject.transform.GetChild(i).transform.childCount; j++) {
                if(achievementsNames.Contains(this.gameObject.transform.GetChild(i).transform.GetChild(j).GetComponent<BadgePositionIdentifier>().id)) {
                    this.gameObject.transform.GetChild(i).transform.GetChild(j).GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Badges/"+this.gameObject.transform.GetChild(i).transform.GetChild(j).GetComponent<BadgePositionIdentifier>().id);
                    string achievementId = this.gameObject.transform.GetChild(i).transform.GetChild(j).GetComponent<BadgePositionIdentifier>().id;
                    this.gameObject.transform.GetChild(i).transform.GetChild(j).GetComponent<Button>().onClick.AddListener(() => OpenAchievementPopup(achievementId));
                }
            }
        }
    }
    public void OpenAchievementPopup(string achievementName) {
        popupBackground.SetActive(true);
        GameObject ap = Instantiate(achievementPopup) as GameObject;
        ap.SetActive(false);
        ap.transform.parent = GameObject.Find("Profile Main Panel").transform;
        ap.GetComponent<RectTransform>().localPosition = new Vector3(0, -140, 0);
        Transform achievementBadgeImage = ap.transform.Find("Achievement badge image");
        Transform achievementTitle = ap.transform.Find("Achievement title");
        Transform achievementDescription = ap.transform.Find("Achievement description");
        GameObject closeButton = ap.transform.Find("Close button").gameObject;
        achievementBadgeImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Badges/"+achievementName);
        achievementTitle.GetComponent<TMP_Text>().text = achievementsTitlesAndDescriptions[TextLocalizer.CurrentLanguage][achievementName].Item1;
        achievementDescription.GetComponent<TMP_Text>().text = achievementsTitlesAndDescriptions[TextLocalizer.CurrentLanguage][achievementName].Item2;
        closeButton.GetComponent<Button>().onClick.AddListener(() => CloseAchievementPopup(ap));
        ap.SetActive(true);
    }
    void CloseAchievementPopup(GameObject popupToClose) {
        popupBackground.SetActive(false);
        Destroy(popupToClose);
    }
}