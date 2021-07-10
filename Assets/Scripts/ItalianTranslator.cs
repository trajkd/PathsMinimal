﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItalianTranslator : MonoBehaviour
{
    static Dictionary<string, string> italianTranslations;
    void Start()
    {
        italianTranslations = new Dictionary<string, string>() {
            ["It’s Beatrice birthday. She is turning 16. She and her family are gathered in her grandparents’ livingroom to celebrate. She doesn’t seem very happy. She is unwrapping her gifts unwillingly."] = "È il compleanno di Beatrice. Oggi compie 16 anni. Lei e la sua famiglia sono riuniti per festeggiare l'occasione nel salotto della casa dei nonni. Beatrice, tuttavia, non sembra essere molto felice. Sta scartando i regali svogliatamente.",
            ["Come on, open it!"] = "Dai, aprilo!",
            ["Let's see what grandpa came up with this time."] = "Vediamo che cosa si è inventato il nonno questa volta.",
            ["Dad, I seriously hope it's nothing like the last one."] = "Papà, spero seriamente che non sia nulla di simile al tuo ultimo regalo per i ragazzi.",
            ["Tommy and Nicholas made a mess with it."] = "Tommy e Nicholas hanno combinato un disastro.",
            ["It took the housekeeper three hours to clean it up."] = "Alla donna delle pulizie ci sono volute tre ore per pulire tutto.",
            ["What was it?"] = "Che cos'era?",
            ["Was it a chemistry set?"] = "Era un set per gli esperimenti chimici, se non sbaglio.",
            ["Yeah. An homemade one."] = "Sì. Uno fatto in casa, addirittura.",
            ["Beatrice rolls her eyes."] = "Beatrice rotea gli occhi.",
            ["Will it ever come a day a conversation won't end up being about the evilspawn?"] = "Arriverà mai un giorno in cui una conversazione non finirà per riguardare i Figli del Male?",
            ["Well, the only way to find out is opening it, so..."] = "Beh, l'unico modo per scoprire cosa c'è dentro è aprirlo, quindi...",
            ["Beatrice opens the present. It’s a novel: THE WHISPERS."] = "Beatrice apre il regalo. È un romanzo: I SUSSURRI.",
            ["Oh, thank God it's just a book."] = "Oh, grazie a Dio è solo un libro.",
            ["Nothing that might explode, or melt, or...worse."] = "Nulla che possa esplodere, o sciogliersi o...peggio.",
            ["Although I'm not sure Bea will know what to do with it."] = "Anche se non sono sicura che Beatrice sappia cosa farci.",
            ["I'm not an idiot"] = "Non sono un'idiota",
            ["You're so kind, mom"] = "Sempre così gentile, mamma...",
            ["I'm not an idiot."] = "Non sono un'idiota.",
            ["You're so kind, mom."] = "Sempre così gentile, mamma...",
            ["Interesting"] = "Interessante",
            ["A little bit... old school. But...okay"] = "Un pò...vecchia scuola. Ma...va bene",
            ["Interesting."] = "Interessante.",
            ["A little bit... old school. But...okay."] = "Un pò...vecchia scuola. Ma...va bene.",
            ["Well, anyways..."] = "Beh, comunque...",
            ["Thank you, grandpa..."] = "Grazie, nonno.",
            ["It’s... ehm..."] = "È...ehm...",
            ["Amazing"] = "Meraviglioso!",
            ["So...cute"] = "Davvero...carino",
            ["Amazing!"] = "Meraviglioso!",
            ["So...cute."] = "Davvero...carino.",
            ["I know you like to read on your smartphone."] = "So che ti piace usare il tuo smartphone per leggere.",
            ["Smartphones are great."] = "Gli smartphone sono fantastici.",
            ["But I think there’s always something romantic about an actual book you can hold."] = "Però io penso che ci sia qualcosa di romantico nel poter tenere in mano un vero libro.",
            ["Grandpa, we have many books!"] = "Nonno, noi abbiamo un sacco di libri!",
            ["Yes!"] = "Sì!",
            ["Tons and tons of them!"] = "Tantissimi!",
            ["We love reading."] = "Leggere ci piace molto.",
            ["Reading is the key to success!"] = "La lettura è la chiave per il successo!",
            ["Well said, Nic."] = "Ben detto, Nic.",
            ["I know, darlings."] = "Lo so, tesori miei.",
            ["You are so clever."] = "Siete davvero intelligenti.",
            ["Aren’t they?"] = "Vero?",
            ["Everytime I come back home, I find them busy learning something new."] = "Ogni volta che torno a casa dal lavoro, li trovo impegnati ad imparare qualcosa di nuovo.",
            ["They're so curious about everything."] = "Sono così curiosi di tutto.",
            ["I wish Bea was more like that..."] = "Vorrei che anche Bea fosse così...",
            ["That's impossible, mom."] = "È impossibile, mamma.",
            ["I don't think she can do much more than stare at her phone."] = "Non penso che Bea sappia fare molto di più che fissare il suo telefono.",
            ["Mom seems amused. She gives Tommy a small smirk."] = "La mamma sembra divertita. Lei e Tommy si scambiano un sorrisetto ironico.",
            ["Don't be too hard on her, Tommy."] = "Non essere troppo duro con lei, Tommy.",
            ["Not everyone can be as smart as you."] = "Non tutti possono essere brillanti come te.",
            ["And of course they take the spotlight..."] = "E ovviamente eccoli che rubano la scena...",
            ["And Bea's public shaming begins."] = "E l'umiliazione pubblica di Bea ricomincia.",
            ["Even today."] = "Persino oggi.",
            ["On my 16th birthday."] = "Il giorno del mio sedicesimo compleanno.",
            ["Hey, don’t forget it’s Beatrice’s special day today."] = "Hey, non dimenticatevi che oggi è il giorno speciale di Bea.",
            ["Grandma looks at Beatrice and smiles, understanding."] = "La nonna lancia uno sguardo comprensivo a Beatrice e le sorride.",
            ["Here, my love, open this."] = "Ecco, amore mio, apri questo.",
            ["What is it?"] = "Che cos'è?",
            ["Let me see!"] = "Voglio vedere anche io!",
            ["Beatrice opens the present. It’s a necklace with a hourglass shaped pendant."] = "Beatrice apre il regalo della nonna. È una collana con un ciondolo a forma di clessidra.",
            ["Wow, Grandma! It’s..."] = "Wow, nonna! È...",
            ["Heartless"] = "Senza cuore",
            ["Materialistic"] = "Materialista",
            ["Come on, wear it!"] = "Dai, fammi vedere come ti sta!",
            ["Bea tries it on."] = "Beatrice indossa la collanna.",
            ["I’m glad you liked it."] = "Sono contenta che ti piaccia.",
            ["It's a beautiful necklace, mom."] = "È una collana stupenda, mamma.",
            ["I think I've seen that pendant before..."] = "Quel ciondolo mi sembra familiare...",
            ["You probably did, yes."] = "Probabilmente l'hai già visto, sì.",
            ["It used to be mine."] = "Era mio.",
            ["But I think it's time for Bea to have it."] = "Ma penso che sia giunto il momento che diventi di Beatrice.",
            ["To remind her she's always in my heart and in my thoughts."] = "Per ricordarle che la tengo sempre nel mio cuore e nei miei pensieri.",
            ["That's poetic."] = "Molto poetico.",
            ["I wonder why I never got that sort of gift from you."] = "Mi chiedo perchè io non abbia mai ricevuto questo genere di doni da te.",
            ["You wouldn't have appreciated it."] = "Non lo avresti apprezzato.",
            ["You've always been a little bit more..."] = "Sei sempre stata un pò più...",
            ["Heartless?"] = "Senza cuore?",
            ["Materialistic?"] = "Materialista?",
            ["Math...I guess"] = "La matematica...credo",
            ["History...I guess"] = "La storia...credo",
            ["Neither of them. They are both useless"] = "Nessuna delle due! Sono entrambe inutili",
            ["Math...I guess."] = "La matematica...credo.",
            ["History...I guess."] = "La storia...credo.",
            ["Neither of them. They are both useless."] = "Nessuna delle due! Sono entrambe inutili.",
            ["Excuse me?"] = "Come scusa?",
            ["You kinda need to have a soul to appreciate this type of gifts."] = "Sai, ti serve avere un'anima per apprezzare questo tipo di regalo.",
            ["That's not what I meant, Bea."] = "Non è questo che intendevo, Bea.",
            ["What?"] = "In che senso?",
            ["You're not really into sentimental stuff, mom."] = "Non ti interessano molto gli aspetti sentimentali delle cose, mamma.",
            ["You're more...pragmatic."] = "Tu sei più...pragmatica, direi.",
            ["Thank you, Bea."] = "Grazie, Bea.",
            ["It's exactly what I meant."] = "È esattamente questo che intendevo.",
            ["Anyways, I've arranged the guest rooms for you."] = "In ogni caso, ho preparato le stanze degli ospiti per voi.",
            ["You shouldn't travel back home with this weather."] = "Non c'è bisogno che torniate a casa con questo tempo.",
            ["It's dangerous to drive when it's so snowy and foggy."] = "È pericoloso guidare quando nevica e c'è così tanta nebbia.",
            ["Thank you, Charlotte."] = "Grazie, Charlotte.",
            ["That is a great idea."] = "È davvero una buona idea.",
            ["Cool!"] = "Che bello!",
            ["A sleepover party!"] = "Un pigiama party!",
            ["But hey, since we've talked about gifts, isn’t it time to give us something for our reports?"] = "Hey, visto che parliamo di regali... Non è ora ci diate un premio per le nostre pagelle?",
            ["We've earned it!"] = "Ce lo siamo meritato!",
            ["Tommy, we’ve already given you that videogame you liked."] = "Tommy, vi abbiamo già comprato quel videogame che volevate.",
            ["Yes, but this year I got an A+ in history."] = "È vero, però quest'anno ho preso A+ in storia!",
            ["Hey!"] = "Hey!",
            ["I got one as well, in Maths!"] = "Anche io ho preso A+, però in matematica.",
            ["Oh, come on! Everybody knows history is way more important than Maths."] = "Ma dai! Tutti sanno che la storia è molto più importante della matematica.",
            ["Are you kidding, right?"] = "Stai scherzando, vero?",
            ["Oh Gosh, who cares? Are they really this desperate for attention?"] = "Oddio, a chi importa? Hanno davvero così tanto bisogno di attenzioni?",
            ["Guys..."] = "Ragazzi...",
            ["Every subject is important."] = "Tutte le materie sono importanti.",
            ["You have to try to be the best in each of them."] = "Dovete cercare di eccellere in ognuna.",
            ["So you'll have many paths to choose."] = "Così avrete molte strade tra cui poter scegliere.",
            ["I've always preferred Maths."] = "A me è sempre piaciuta di più la matematica.",
            ["That's not the point I'm trying to make here."] = "Non è questo il punto del mio discorso.",
            ["Okay, so dad's on my team!"] = "Ok, quindi papà è dalla mia parte!",
            ["And so is grandma, I'm sure."] = "E anche la nonna, ne sono siucro.",
            ["And grandpa is on mine."] = "E il nonno è dalla mia!",
            ["He was a literature professor after all."] = "Era un professore di letteratura, dopo tutto.",
            ["Bea, what do you think? Which one is better?"] = "Bea, tu che ne pensi? Qual è più importante?",
            ["Seriously? You are always on his side."] = "Fai sul serio? Sei sempre dalla sua parte!",
            ["No, I'm on my side."] = "No, sono dalla mia parte.",
            ["It's my birthday!"] = "È il mio compleanno!",
            ["And you two are ruining it!"] = "E voi due lo state rovinando!",
            ["What? "] = "Cosa?",
            ["There she is."] = "Eccola qui.",
            ["Always playing the victim of the family."] = "Come al solito comincia a fare la vittima della famiglia.",
            ["Bea, can't you leave them alone?"] = "Bea, non puoi lasciarli stare?",
            ["Are you incapable of sharing the spotlight for just a minute?"] = "Non sei capace di condividere il centro dell'attenzione per un minuto?",
            ["Ah... You can’t be serious, right? Why do you always defend him?"] = "Ah...non puoi essere seria, vero? Perchè difendi sempre lui?",
            ["No, I defend myself."] = "No, io difendo me stessa!",
            ["Of course this is your opinion, Beatrice."] = "Non mi sorprende che questa sia la tua opinione, Beatrice.",
            ["But, you know..."] = "Ma sai...",
            ["For some of us life is a little bit more than parties and selfies."] = "Per alcuni di noi la vita è un pò di più che feste e selfie.",
            ["Yes, I am!"] = "No, non sono capace! Perchè voi non riuscite mai a smettere di parlare di quanto perfetti siano, anche oggi!",
            ["Yes, I am. It's my day!"] = "No, non sono capace! Perchè voi non riuscite mai a smettere di parlare di quanto perfetti siano, anche oggi!",
            ["Because it's never just a minute."] = "Perchè non si tratta mai solo di un minuto!",
            ["It's all day, every day!"] = "Succede tutto il giorno, tutti i giorni!",
            ["You can't stop yourself from reminding me constantly of how good they are!"] = "Non riuscite a trattenervi dal ricordarmi costantemente di quanto siano bravi!",
            ["Even today!"] = "Persino oggi!",
            ["Then maybe you should try to improve yourself instead of wasting time and energy being resentful and jealous."] = "Allora forse dovresti cercare di migliorare te stessa, piuttosto che sprecare tempo ed energia ad essere piena di rancore e gelosa.",
            ["Your brothers are focused."] = "I tuoi fratelli sono concentrati.",
            ["It's not a fault, it's a merit."] = "Non è una colpa, è un merito.",
            ["I used to be the same."] = "Anche io ero così alla loro età.",
            ["For some of us life is a little bit more than parties and selfies."] = "Per alcuni di noi la vita è un pò di più che feste e selfie.",
            ["Whatever..."] = "Se lo dici tu...",
            ["You just don't get it."] = "Non riuscite proprio a capire.",
            ["They're all you see."] = "Loro sono tutto quello che vedete.",
            ["Not everybody is perfect like you"] = "Non tutti sono perfetti come te",
            ["Not everybody is perfect like you."] = "Non tutti sono perfetti come te.",
            ["What's wrong with that? I'm 16!"] = "E cosa c'è di male nelle feste e nei selfie? Ho 16 anni!",
            ["You never look at the bigger picture."] = "Non guardi mai le cose in prospettiva, Beatrice.",
            ["Sometimes it seems to me that your brothers are more mature than you are."] = "A volte mi sembra che i tuoi frateli siano più maturi di te.",
            ["At least they have interests."] = "Almeno hanno degli interessi.",
            ["Being 16 doesn't mean you get to be a frivolous person."] = "Avere 16 anni non significa potersi permettere di essere frivoli.",
            ["It seems to me you have no clue about what you want to do in life."] = "Mi pare che tu non abbia idea di che cosa vorresti fare nella vita.",
            ["She seemed to have found her life goal..."] = "Sembrava aver trovato una vocazione, un obbiettivo di vita...",
            ["Don't start again with..."] = "Per favore, non ricominciare con...",
            ["I'm bringing hockey up again, yes, Beatrice."] = "Sì, Beatrice, sto parlando dell'hockey.",
            ["You were a quite good athlete and you quit."] = "Eri un'atleta piuttosto promettente e hai mollato.",
            ["And whose fault is that?"] = "E di chi è la colpa?",
            ["Yours, of course."] = "Tua, ovviamente.",
            ["You can't handle competition."] = "Non riesci a reggere la competizione.",
            ["You're weak."] = "Sei debole.",
            ["Stop it."] = "Smettetela.",
            ["Alyssa, that's rude and not fair."] = "Alyssa, quello che hai detto è scortese ed ingiusto.",
            ["You did the same at her age."] = "Alla sua età, tu facevi le stesse cose.",
            ["Oh, that's true."] = "Oh, è vero.",
            ["I remember."] = "Ricordo bene.",
            ["You were always sneaking out at night to..."] = "Uscivi sempre di nascosto di notte...",
            ["No, you are."] = "No, tu sei debole.",
            ["You feel the need to terrorize people."] = "Senti il bisogno di terrorizzare le persone.",
            ["Look at those two!"] = "Guarda quei due!",
            ["You don't have sons, you have obedient minions!"] = "Non hai dei figli, hai due schiavetti obbedienti!",
            ["We're not!"] = "Non siamo schiavetti!",
            ["You're just being mean as usual."] = "Stai solo dicendo cattiverie, come sempre.",
            ["Being mean is all you can do."] = "Sai solo essere cattiva.",
            ["Please, let's stop this."] = "Per favore, non continuate.",
            ["We're here to celebrate, not to fight."] = "Siamo qui per festeggiare, non per litigare.",
            ["There's nothing to celebrate."] = "Non c'è nulla da festeggiare.",
            ["Those two always ruin everything."] = "Quei due rovinano sempre tutto.",
            ["And you all let them!"] = "E voi tutti li lasciate fare!",
            ["Beatrice, listen to yourself."] = "Beatrice, ascolta quello che stai dicendo.",
            ["You are overreacting, as usual."] = "Stai avendo una reazione esagerata, come sempre.",
            ["Can you please be kind to your brothers?"] = "Per piacere, puoi cercare di essere gentile con i tuoi fratelli?",
            ["Yes, of course! I'm so proud of them!"] = "Ma certo! Sono così fiera di loro!",
            ["Yes, of course! I'm so proud that you are the geniuses of this family and I'm just worthless. Wow, that's so amazing!"] = "Ma certo! Sono così fiera che loro siano i geni di questa famiglia mentre io non valgo nulla. Wow, è meraviglioso!",
            ["Of course, I'll do whatever you want me to do, as I always do."] = "Certo, farò quello che volete che faccia, come al solito.",
            ["Yes, of course!"] = "Ma certo!",
            ["I'm so proud that they are the geniuses of this family and I'm just worthless to you."] = "Sono così fiera che loro siano i geni della famiglia, mentre io non valgo nulla.",
            ["Wow, that's so amazing!"] = "Wow, è meraviglioso!",
            ["Of course, I'll do whatever you want me to do"] = "Certo, farò quello che volete che faccia",
            ["Nobody ever said such a thing, Beatrice."] = "Nessuno ha detto questo, Beatrice.",
            ["Beatrice, enough!"] = "Beatrice, basta!",
            ["Enough!"] = "Smettila!",
            ["You are making a scene for no reason."] = "Stai facendo una scenata senza motivo.",
            ["There is a reason!"] = "C'è un motivo!",
            ["It’s you two who can’t see it!"] = "Ma voi non riuscite a capirlo!",
            ["Then, tell us."] = "Allora spiegacelo.",
            ["It’s them!"] = "Il motivo sono loro!",
            ["It’s always them!"] = "Sono sempre loro!",
            ["You treat me like I’m this mediocre mistake that came before the perfect score!"] = "Mi trattate come se fossi un errore mediocre fatto prima di raggiungere il risultato perfetto.",
            ["Beatrice holds back the tears."] = "Beatrice trattiene le lacrime.",
            ["Stop it. Stop it now!"] = "Basta così. Vi prego, basta!",
            ["Bea, no."] = "Bea, no.",
            ["Don’t say that."] = "Non dire così.",
            ["It’s not true."] = "Non è vero.",
            ["Well, it's not our fault you are the dumb one."] = "Beh, non è colpa nostra se tu sei quella stupida in famiglia.",
            ["Thomas!"] = "Thomas!",
            ["Mom shakes her head, holding back a snicker."] = "La mamma scuote la testa, cercando di trattenere una risatina.",
            ["At least you are pretty!"] = "Almeno sei carina!",
            ["And I'll become just like them."] = "E diventerò proprio come loro.",
            ["So maybe you'll finally like me!"] = "Così magari finalmente mi apprezzerete!",
            ["Nobody asked you to do that, Beatrice."] = "Nessuno ti ha chiesto di farlo, Beatrice.",
            ["Oh, really?"] = "Oh, davvero?",
            ["You're such an hypocrite!"] = "Sei proprio un'ipocrita!",
            ["So you used to be a normal person once, not a robot."] = "Quindi una volta eri una persona normale, non un robot.",
            ["It doesn't matter now. Just..."] = "Non importa ora. Solo...",
            ["Dad, Mom, stay out of her scene! Don't undermine my authority in front of the kids."] = "Papà, mamma, non datele corda. E non sminuite la mia autorità di fronte ai ragazzi.",
            ["You've been preaching about success and focus ever since I can remember..."] = "Predichi riguardo al successo e alla concentrazione da sempre...",
            ["and yet when you were my age you used to do the same things I want to do."] = "Eppure quando avevi la mia età facevi le stesse cose che voglio fare io.",
            ["Be with my friends and have fun with people who understand me."] = "Stare con i miei amici e divertirmi con delle persone che mi capiscono.",
            ["No, I'd really like to know more about it..."] = "No, vorrei davvero saperne di più...",
            ["There's nothing to say."] = "Non c'è nulla da dire.",
            ["Your grandpa was exaggerating, as usual."] = "Tuo nonno stava esagerando, come al solito.",
            ["Well..."] = "Beh...",
            ["I don't think he was."] = "Io non penso che stesse esagerando.",
            ["It looks like you were not as different from me as you claim you were."] = "Mi sembra che, al contrario di quello che dici sempre, tu non fossi così diversa da me.",
            ["Listen, young lady!"] = "Senti, ragazzina!",
            ["You might think you are similar to me, but at your age I had ambitions and dreams."] = "Puoi pensare di assomigliarmi, ma alla tua età io avevo ambizioni e sogni.",
            ["I already knew what I wanted to do with my life."] = "Sapevo già cosa volevo fare con la mia vita.",
            ["That's how I built my career."] = "È così che ho costruito la mia carriera.",
            ["That's how I got what I have now."] = "Ed è così che ho ottenuto quello che ho ora.",
            ["And what is that?"] = "E che cosa avresti ottenuto?",
            ["People who stay with you because they fear you like dad?"] = "Delle persone che ti stanno accanto solo perchè hanno paura di te come papà?",
            ["Beatrice!"] = "Beatrice!",
            ["A job that sucks away all of your humanity?"] = "Un lavoro che succhia via tutta la tua umanità?",
            ["Bea, please, let's not do this."] = "Bea, per favore, cerchiamo di non litigare.",
            ["Mom is staring at Beatrice, impassible."] = "La mamma fissa Beatrice, impassibile.",
            ["No, let her continue."] = "No, lasci che continui.",
            ["Two obeying minions with no personality as sons?"] = "Due schiavetti obbedienti senza personalità come figli?",
            ["A daughter who hates you?"] = "Una figlia che ti odia?",
            ["Silence falls over the room. No one dares to speak."] = "Un silenzio imbarazzato avvolge la stanza. Nessuno si azzarda a parlare.",
            ["I let you continue so everyone would see you as you are."] = "Ho permesso che continuassi così che tutti potessero vederti per come sei.",
            ["You humiliate people because you have no self esteem."] = "Umili le persone perchè non hai alcuna autostima.",
            ["What you call fear is respect, something that you so desperately want but that you'll never have."] = "Quella che tu chiami paura è rispetto, qualcosa che vuoi disperatamente ma che non avrai mai.",
            ["Because you are mean to everyone and you push them away."] = "Perchè sei crudele con tutti e allontani le persone.",
            ["Either you change, or you'll end up alone and worthless."] = "O cambi, o finirai per diventare una persona sola e senza valore.",
            ["Beatrice holds back the tears, angry and hurt."] = "Beatrice cerca di trattenere le lacrime, arrabbiata e ferita.",
            ["Yeah, it's not our fault you are just dumb."] = "Già, non è colpa nostra se sei stupida.",
            ["Slap Tommy"] = "Schiaffeggia Tommy",
            ["Slap Nicholas"] = "Schiaffeggia Nicholas",
            ["Throw your Grandpa's gift at them"] = "Lancia il regalo del nonno contro i gemelli",
            ["*slaps Tommy*"] = "*schiaffeggia Tommy*",
            ["*slaps Nicholas*"] = "*schiaffeggia Nicholas*",
            ["*throws her Grandpa's gift at them*"] = "*lancia il regalo del nonno contro i gemelli*",
            ["Grandma leaves the room."] = "La nonna si alza e lascia la stanza.",
            ["Nicholas immediately starts to cry."] = "Nicholas scoppia immediatamente a piangere.",
            ["Tommy immediately starts to cry."] = "Tommy scoppia immediatamente a piangere.",
            ["Fantastic."] = "Fantastico.",
            ["Thank you, Beatrice."] = "Grazie, Beatrice.",
            ["Another lovely day we can add to our collection."] = "Un'altra giornata adorabile da aggiungere alla nostra collezione.",
            ["Beatrice misses them and the book hits the family photo portrait."] = "Beatrice manca il bersaglio e il libro colpisce il ritratto di famiglia appeso al muro.",
            ["No!"] = "No!",
            ["The photo we took today!"] = "La foto che abbiamo scattato oggi!",
            ["I've just hung it there!"] = "L'avevo appena appesa lì!",
            ["You are the usual disaster, B."] = "Sei il solito disastro, B.",
            ["Typical."] = "Tipico.",
            ["Get out of the house"] = "Esci di casa",
            ["Go to another room and cry"] = "Piangi e corri in un'altra stanza",
            ["Beatrice gets out of the house. She slams the front door as hard as she can."] = "Beatrice esce di casa. Sbatte la porta di ingresso più forte che può.",
            ["Beatrice runs to another room and starts crying."] = "Piangendo, Beatrice scappa in un'altra stanza.",
            ["It's dark and foggy. It's snowing. She doesn't know where to go, but she knows she doesn't want to stay there."] = "Fuori è buio e nebbioso. Sta nevicando. Beatrice non sa dove andare, ma sa che non vuole restare lì.",
            ["Beatrice can't see anything in front of her."] = "Non riesce a vedere nulla davanti a lei.",
            ["I can't believe they ruined my day!"] = "Non riesco a credere che abbiano rovinato la mia giornata!",
            ["Why do I keep letting them do this to me?"] = "Perchè continuo a permettere loro di farmi questo?",
            ["I swear this is the last year I spend my birthday with them!"] = "Giuro che questa è stata l'ultima volta che passo il mio compleanno con loro!",
            ["I hate them, I hate them!"] = "Li odio, li odio!",
            ["Shut up! Shut up!"] = "State zitti! State zitti!",
            ["I hate you, I hate you all."] = "Vi odio, vi odio tutti.",
            ["Oh, of course. The crocodile tears."] = "Ah, ma certo. Le lacrime del coccodrillo.",
            ["Run"] = "Corri",
            ["Continue to Chapter 1"] = "Vai al Capitolo 1",
            ["She starts running. She is now lost in the fog, the house is just a faded light behind her. Suddently, she hears a voice calling for her."] = "Beatrice comincia a correrre. Ora è persa nella nebbia, la casa è solo una luce fioca dietro di lei. All'improvviso, sente una voce che la sta chiamando.",
            ["Did they?"] = "Mi hanno...?",
            ["Did they follow me here?"] = "Mi hanno seguita?",
            ["Turn around"] = "Girati",
            ["Keep going"] = "Prosegui",
            ["Beatrice! Move!"] = "Beatrice! Spostati!",
            ["The voice gets louder."] = "La voce diventa sempre più forte.",
            ["Beatrice turns and sees a car coming in her direction."] = "Beatrice si gira e vede una macchina che sfreccia verso di lei.",
            ["She is pushed away from the road by her grandma."] = "Viene spinta via dalla strada dalla nonna.",
            ["There's a CRASH."] = "C'è uno schianto."
        };
    }
    public static void Translate(Transform textField, string stringToTranslate) {
        if (TextLocalizer.CurrentLanguage == "Italiano" && italianTranslations.ContainsKey(stringToTranslate.Substring(0, stringToTranslate.Length - 1))) {
            textField.GetComponent<TMP_Text>().text = italianTranslations[stringToTranslate.Substring(0, stringToTranslate.Length - 1)];
        }
    }
}
