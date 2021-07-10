VAR grandma_dead = 0
VAR portrait_broken = 0
VAR materialistic_or_heartless = "NONE"
VAR math_or_history = "NONE"
VAR slap_tommy_or_nicholas = "NONE"
VAR dramaticexits_counter = "NONE"
VAR no_to_grandpa = 0
It’s Beatrice's birthday. She is turning 16. She and her family are gathered in her grandparents’ livingroom to celebrate. She doesn’t seem very happy. She is unwrapping her gifts unwillingly. #narrator #first

prologo1 #narratorwithimage #slow

Come on, open it! #grandpa

Let's see what grandpa came up with this time. #dad

Dad, I seriously hope it's nothing like the last one. #mom
Tommy and Nicholas made a mess with it. #mom
It took the housekeeper three hours to clean it up. #mom

What was it? #dad
Was it a chemistry set? #dad

Yeah. A homemade one. #mom

Beatrice rolls her eyes. #narrator

Will it ever come a day a conversation won't end up being about the evilspawn? #beatricevoiceover

Well, the only way to find out is opening it, so... #beatrice

Beatrice opens the present. It’s a novel: THE WHISPERS. #narrator

Oh, thank God it's just a book. #mom
Nothing that might explode, or melt, or...worse. #mom
Although I'm not sure Bea will know what to do with it. #mom

+ [I'm not an idiot] 
  I'm not an idiot. #beatrice #first
  \-1 #mom #affinity
+ [You're so kind, mom]
  You're so kind, mom. #beatrice #first

- Well, anyways... #beatrice
Thank you, grandpa... #beatrice
It’s... ehm... #beatrice

+ [Interesting]
  Interesting. #beatrice #first
  1 #grandpa #affinity
  -> Continue
+ [A little bit... old school. But...okay]
  ~no_to_grandpa = 1
  A little bit... old school. But...okay. #beatrice #first
  -> Continue

=== Continue ===
I know you like to read on your smartphone. #grandpa
Smartphones are great. #grandpa
But I think there’s always something romantic about an actual book you can hold. #grandpa 

Grandpa, we have many books! #nicholas

Yes! #tommy
Tons and tons of them! #tommy
We love reading. #tommy

Reading is the key to success! #nicholas

Well said, Nic. #mom

I know, darlings. #grandpa
You are so clever. #grandpa

Aren’t they? #mom
Everytime I come back home, I find them busy learning something new. #mom
They're so curious about everything. #mom
I wish Bea was more like that... #mom

That's impossible, mom. #tommy
I don't think she can do much more than stare at her phone. #tommy

Mom seems amused. She gives Tommy a small smirk. #narrator

Don't be too hard on her, Tommy. #mom
Not everyone can be as smart as you. #mom

And of course they take the spotlight... #beatricevoiceover
And Bea's public shaming begins. #beatricevoiceover
Even today. #beatricevoiceover
On my 16th birthday. #beatricevoiceover

Hey, don’t forget it’s Beatrice’s special day today. #grandma

Grandma looks at Beatrice and smiles, understanding. #narrator

Here, my love, open this. #grandma

What is it? #tommy

Let me see! #nicholas

prologo2 #narratorwithimage

Beatrice opens the present. It’s a necklace with a hourglass shaped pendant. #narrator 

Wow, Grandma! It’s... #beatrice

+ [Amazing]
  Amazing! #beatrice #first
  1 #grandma #affinity

+ [So...cute]
  So...cute. #beatrice #first

- Come on, wear it! #grandma

Bea tries it on. #narrator

I’m glad you liked it. #grandma

It's a beautiful necklace, mom. #mom
I think I've seen that pendant before... #mom

You probably did, yes. #grandma
It used to be mine. #grandma
But I think it's time for Bea to have it. #grandma
To remind her she's always in my heart and in my thoughts. #grandma

That's poetic. #mom
I wonder why I never got that sort of gift from you. #mom

You wouldn't have appreciated it. #grandma
You've always been a little bit more... #grandma

+ [Heartless]
  ~materialistic_or_heartless = "You think mom is heartless"
  Heartless? #beatrice #first
  \-1 #grandma #affinity
  \-1 #mom #affinity
  
  Excuse me? #mom

  You kinda need to have a soul to appreciate this type of gifts. #beatrice

  That's not what I meant, Bea. #grandma

+ [Materialistic]
  ~materialistic_or_heartless = "You think mom is materialistic"
  Materialistic? #beatrice #first
  1 #grandma #affinity

  What? #mom

  You're not really into sentimental stuff, mom. #beatrice
  You're more...pragmatic. #beatrice

  Thank you, Bea. #grandma
  It's exactly what I meant. #grandma

- Anyways, I've arranged the guest rooms for you. #grandma
You shouldn't travel back home with this weather. #grandma
It's dangerous to drive when it's so snowy and foggy. #grandma

Thank you, Charlotte. #dad
That is a great idea. #dad

Cool! #tommy
A sleepover party! #tommy
But hey, since we've talked about gifts, isn’t it time to give us something for our reports? #tommy
We've earned it! #tommy #slow

Tommy, we’ve already given you that videogame you liked. #dad

Yes, but this year I got an A+ in history. #nicholas

Hey! #tommy
I got one as well, in Maths! #tommy

Oh, come on! Everybody knows history is way more important than Maths. #nicholas

Are you kidding, right? #tommy

Oh Gosh, who cares? Are they really this desperate for attention? #beatricevoiceover

Guys... #mom
Every subject is important. #mom
You have to try to be the best in each of them. #mom
So you'll have many paths to choose. #mom

I've always preferred Maths. #dad

That's not the point I'm trying to make here. #mom

Okay, so dad's on my team! #tommy
And so is grandma, I'm sure. #tommy

And grandpa is on mine. #nicholas
He was a literature professor after all. #nicholas
Bea, what do you think? Which one is better? #nicholas

+ [Math...I guess]
  ~math_or_history = "You like maths more than history"
  Math...I guess. #beatrice #first
  mathematicalmind #achievement
  1 #tommy #affinity
  \-1 #nicholas #affinity
  -> Math

+ [History...I guess]
  ~math_or_history = "You like history more than maths"
  History...I guess. #beatrice #first
  historiansoul #achievement
  1 #nicholas #affinity
  \-1 #tommy #affinity
  -> History

+ [Neither of them. They are both useless]
  ~math_or_history = "You neither like maths nor history"
  Neither of them. They are both useless. #beatrice #first
  toocoolforschool #achievement
  \-1 #nicholas #affinity
  \-1 #tommy #affinity
  -> Neither
  
=== Math ===
Seriously? You are always on his side. #nicholas

No, I'm on my side. #beatrice
It's my birthday! #beatrice
And you two are ruining it! #beatrice

What?\ \  #nicholas

There she is. #mom
Always playing the victim of the family. #mom
Bea, can't you leave them alone? #mom
Are you incapable of sharing the spotlight for just a minute? #mom

+ [Yes, I am!]
  Yes, I am! #beatrice #first
  -> Incapable

+ [Whatever...]
  Whatever... #beatrice #first
  -> Whatever

=== History ===
Ah... You can’t be serious, right? Why do you always defend him? #tommy

No, I defend myself. #beatrice
It's my birthday! #beatrice
And you two are ruining it! #beatrice

What?2 #tommy

There she is. #mom
Always playing the victim of the family. #mom
Bea, can't you leave them alone? #mom
Are you incapable of sharing the spotlight for just a minute? #mom

+ [Yes, I am. It's my day!]
  Yes, I am. It's my day! #beatrice #first
  -> Incapable
+ [Whatever...]
  Whatever... #beatrice #first
  -> Whatever

=== Neither ===
Of course this is your opinion, Beatrice. #mom
But, you know... #mom
For some of us life is a little bit more than parties and selfies. #mom

+ [Not everybody is perfect like you]
  Not everybody is perfect like you. #beatrice #first
+ [What's wrong with that? I'm 16!]
  What's wrong with that? I'm 16! #beatrice #first
  \-1 #mom #affinity

- You never look at the bigger picture. #dad
Sometimes it seems to me that your brothers are more mature than you are. #dad
At least they have interests. #dad
Being 16 doesn't mean you get to be a frivolous person. #dad
It seems to me you have no clue about what you want to do in life. #dad

She seemed to have found her life goal... #mom

Don't start again with... #beatrice

I'm bringing hockey up again, yes, Beatrice. #mom
You were a quite good athlete and you quit. #mom

And whose fault is that? #beatrice 

Yours, of course. #mom
You can't handle competition. #mom
You're weak. #mom

Stop it. #grandma
Alyssa, that's rude and not fair. #grandma
You did the same at her age. #grandma

Oh, that's true. #grandpa 
I remember. #grandpa
You were always sneaking out at night to... #grandpa

+ [Oh, really?]
  Oh, really? #beatrice #first
  -> Really
+ [You're such an hypocrite!]
  You're such an hypocrite! #beatrice #first
  \-1 #mom #affinity
  -> Hypocrite

=== Whatever ===
You just don't get it. #beatrice
They're all you see. #beatrice

Then maybe you should try to improve yourself instead of wasting time and energy being resentful and jealous. #mom
Your brothers are focused. #mom
It's not a fault, it's a merit. #mom
I used to be the same. #mom
For some of us life is a little bit more than parties and selfies. #mom 

+ [Not everybody is perfect like you]
  Not everybody is perfect like you. #beatrice #first
+ [What's wrong with that? I'm 16!]
  What's wrong with that? I'm 16! #beatrice #first
  \-1 #mom #affinity

- You never look at the bigger picture. #dad
Sometimes it seems to me that your brothers are more mature than you are. #dad
At least they have interests. #dad
Being 16 doesn't mean you get to be a frivolous person. #dad
It seems to me you have no clue about what you want to do in life. #dad

She seemed to have found her life goal... #mom

Don't start again with... #beatrice

I'm bringing hockey up again, yes, Beatrice. #mom
You were a quite good athlete and you quit. #mom

And whose fault is that? #beatrice

Yours, of course. #mom
You can't handle competition. #mom
You're weak. #mom

No, you are. #beatrice
You feel the need to terrorize people. #beatrice
Look at those two! #beatrice
You don't have sons, you have obedient minions! #beatrice

We're not! #tommy
You're just being mean as usual. #tommy

Being mean is all you can do. #nicholas

Please, let's stop this. #grandma
We're here to celebrate, not to fight. #grandma

There's nothing to celebrate. #beatrice
Those two always ruin everything. #beatrice
And you all let them! #beatrice

Beatrice, listen to yourself. #dad
You are overreacting, as usual. #dad
Can you please be kind to your brothers? #dad


+ [Yes, of course! I'm so proud of them!]
  Yes, of course! #beatrice #first
  I'm so proud that they are the geniuses of this family and I'm just worthless to you. #beatrice
  Wow, that's so amazing! #beatrice
  -> Geniuses

+ [Of course, I'll do whatever you want me to do]
  Of course, I'll do whatever you want me to do, as I always do. #beatrice #first
  -> Just_like_them

=== Incapable ===
Because it's never just a minute. #beatrice
It's all day, every day! #beatrice
You can't stop yourself from reminding me constantly of how good they are! #beatrice
Even today! #beatrice

Then maybe you should try to improve yourself instead of wasting time and energy being resentful and jealous. #mom
Your brothers are focused. #mom
It's not a fault, it's a merit. #mom
I used to be the same. #mom
For some of us life is a little bit more than parties and selfies. #mom

+ [Not everybody is perfect like you]
  Not everybody is perfect like you. #beatrice #first
+ [What's wrong with that? I'm 16!]
  What's wrong with that? I'm 16! #beatrice #first
  \-1 #mom #affinity

- You never look at the bigger picture. #dad
Sometimes it seems to me that your brothers are more mature than you are. #dad
At least they have interests. #dad
Being 16 doesn't mean you get to be a frivolous person. #dad
It seems to me you have no clue about what you want to do in life. #dad

She seemed to have found her life goal... #mom

Don't start again with... #beatrice

I'm bringing hockey up again, yes, Beatrice. #mom
You were a quite good athlete and you quit. #mom

And whose fault is that? #beatrice

Yours, of course. #mom
You can't handle competition. #mom
You're weak. #mom

No, you are. #beatrice
You feel the need to terrorize people. #beatrice
Look at those two! #beatrice
You don't have sons, you have obedient minions! #beatrice

We're not! #tommy
You're just being mean as usual. #tommy

Being mean is all you can do. #nicholas

Please, let's stop this. #grandma
We're here to celebrate, not to fight. #grandma

There's nothing to celebrate. #beatrice
Those two always ruin everything. #beatrice
And you all let them! #beatrice


Beatrice, listen to yourself. #dad
You are overreacting, as usual. #dad
Can you please be kind to your brothers? #dad

+ [Yes, of course! I'm so proud of them!]
  Yes, of course! #beatrice #first
  I'm so proud that they are the geniuses of this family and I'm just worthless to you. #beatrice
  Wow, that's so amazing! #beatrice
  -> Geniuses

+ [Of course, I'll do whatever you want me to do]
  Of course, I'll do whatever you want me to do, as I always do. #beatrice #first
  -> Just_like_them

=== Really ===

So you used to be a normal person once, not a robot. #beatrice

It doesn't matter now. Just... #grandma

Dad, Mom, stay out of her scene! Don't undermine my authority in front of the kids. #mom

+ [No, I'd really like to know more about it...]
  No, I'd really like to know more about it... #beatrice #first
  -> Know_more_about_it

=== Hypocrite ===
You've been preaching about success and focus ever since I can remember... #beatrice
and yet when you were my age you used to do the same things I want to do. #beatrice
Be with my friends and have fun with people who understand me. #beatrice

It doesn't matter now. Just... #grandma

Dad, Mom, stay out of her scene! Don't undermine my authority in front of the kids. #mom

+ [No, I'd really like to know more about it...]
  No, I'd really like to know more about it... #beatrice #first
  -> Know_more_about_it
  
=== Know_more_about_it ===
There's nothing to say. #mom
Your grandpa was exaggerating, as usual. #mom

Well... #grandpa

I don't think he was. #beatrice
It looks like you were not as different from me as you claim you were. #beatrice

Listen, young lady! #mom
You might think you are similar to me, but at your age I had ambitions and dreams. #mom
I already knew what I wanted to do with my life. #mom
That's how I built my career. #mom
That's how I got what I have now. #mom

And what is that? #beatrice
People who stay with you because they fear you like dad? #beatrice

Beatrice! #dad

A job that sucks away all of your humanity? #beatrice

Bea, please, let's not do this. #grandma

Mom is staring at Beatrice, impassible. #narrator

No, let her continue. #mom

Two obeying minions with no personality as sons? #beatrice
A daughter who hates you? #beatrice

Silence falls over the room. No one dares to speak. #narrator

I let you continue so everyone would see you as you are. #mom
You humiliate people because you have no self esteem. #mom
What you call fear is respect, something that you so desperately want but that you'll never have. #mom
Because you are mean to everyone and you push them away. #mom #slow
Either you change, or you'll end up alone and worthless. #mom

Beatrice holds back the tears, angry and hurt. #narrator

Yeah, it's not our fault you are just dumb. #tommy

At least you are pretty! #nicholas

+ [Slap Tommy]
  ~slap_tommy_or_nicholas = "You slapped Tommy"
  prologo3-2 #narratorwithimage #first
  \-1 #tommy #affinity
  -> Slap_Tommy
  
+ [Slap Nicholas]
  ~slap_tommy_or_nicholas = "You slapped Nicholas"
  prologo3-1 #narratorwithimage #first
  \-1 #nicholas #affinity
  -> Slap_Nicholas
  
+ [Throw your Grandpa's gift at them]
  ~slap_tommy_or_nicholas = "You broke the family photo portrait"
  ~portrait_broken = 1
  cultureisaweapon #achievement
  Beatrice misses them and the book hits the family photo portrait. #narrator #first
  prologo3-3 #narratorwithimage
  -> Throw_gift
  
=== Geniuses ===
Nobody ever said such a thing, Beatrice. #dad

Beatrice, enough! #mom
Enough! #mom
You are making a scene for no reason. #mom

There is a reason! #beatrice
It’s you two who can’t see it! #beatrice

Then, tell us. #dad

It’s them! #beatrice
It’s always them! #beatrice
You treat me like I’m this mediocre mistake that came before the perfect score! #beatrice

Beatrice holds back the tears. #narrator

Stop it. Stop it now! #grandma

Bea, no. #grandpa
Don’t say that. #grandpa
It’s not true. #grandpa

Well, it's not our fault you are the dumb one. #tommy

Thomas! #grandma

Mom shakes her head, holding back a snicker. #narrator

At least you are pretty! #nicholas

+ [Slap Tommy]
  ~slap_tommy_or_nicholas = "You slapped Tommy"
  prologo3-2 #narratorwithimage #first
  \-1 #tommy #affinity
  -> Slap_Tommy
  
+ [Slap Nicholas]
  ~slap_tommy_or_nicholas = "You slapped Nicholas"
  prologo3-1 #narratorwithimage #first
  \-1 #nicholas #affinity
  -> Slap_Nicholas
  
+ [Throw your Grandpa's gift at them]
  ~slap_tommy_or_nicholas = "You broke the family photo portrait"
  ~portrait_broken = 1
  cultureisaweapon #achievement
  Beatrice misses them and the book hits the family photo portrait. #narrator #first
  prologo3-3 #narratorwithimage
  -> Throw_gift

=== Just_like_them ===
And I'll become just like them. #beatrice
So maybe you'll finally like me! #beatrice

Nobody asked you to do that, Beatrice. #dad

Beatrice, enough! #mom
Enough! #mom
You are making a scene for no reason. #mom

There is a reason! #beatrice
It’s you two who can’t see it! #beatrice

Then, tell us. #dad

It’s them! #beatrice
It’s always them! #beatrice
You treat me like I’m this mediocre mistake that came before the perfect score! #beatrice

Beatrice holds back the tears. #narrator

Stop it. Stop it now! #grandma

Bea, no. #grandpa
Don’t say that. #grandpa
It’s not true. #grandpa

Well, it's not our fault you are the dumb one. #tommy

Thomas! #grandma

Mom shakes her head, holding back a snicker. #narrator

At least you are pretty! #nicholas

+ [Slap Tommy]
  ~slap_tommy_or_nicholas = "You slapped Tommy"
  prologo3-2 #narratorwithimage #first
  \-1 #tommy #affinity
  -> Slap_Tommy
  
+ [Slap Nicholas]
  ~slap_tommy_or_nicholas = "You slapped Nicholas"
  prologo3-1 #narratorwithimage #first
  \-1 #nicholas #affinity
  -> Slap_Nicholas
  
+ [Throw your Grandpa's gift at them]
  ~slap_tommy_or_nicholas = "You broke the family photo portrait"
  ~portrait_broken = 1
  cultureisaweapon #achievement
  Beatrice misses them and the book hits the family photo portrait. #narrator #first
  prologo3-3 #narratorwithimage
  -> Throw_gift
  
=== Slap_Tommy ===
Grandma leaves the room. #narrator

Tommy immediately starts to cry. #narrator

Fantastic. #mom
Thank you, Beatrice. #mom
Another lovely day we can add to our collection. #mom

+ [Get out of the house] -> Get_out_of_the_house

+ [Go to another room and cry] -> Cry

=== Slap_Nicholas ===
Grandma leaves the room. #narrator

Nicholas immediately starts to cry. #narrator

Fantastic. #mom
Thank you, Beatrice. #mom
Another lovely day we can add to our collection. #mom

+ [Get out of the house] -> Get_out_of_the_house

+ [Go to another room and cry] -> Cry

=== Throw_gift ===
No! #nicholas
The photo we took today! #nicholas

I've just hung it there! #grandpa

You are the usual disaster, B. #tommy

Grandma leaves the room. #narrator

Typical. #mom
Thank you, Beatrice. #mom
Another lovely day we can add to our collection. #mom

+ [Get out of the house] -> Get_out_of_the_house

+ [Go to another room and cry] -> Cry

=== Cry ===
Beatrice runs to another room and starts crying. #narrator #first

Shut up! Shut up! #beatrice
I hate you, I hate you all. #beatrice

Oh, of course. The crocodile tears. #mom

prologo4-2 #narratorwithimage

+ [Continue to Chapter 1] -> END

=== Get_out_of_the_house ===
~dramaticexits_counter = "1"
Beatrice gets out of the house. She slams the front door as hard as she can. #narrator #first

prologo4-1 #narratorwithimage

It's dark and foggy. It's snowing. She doesn't know where to go, but she knows she doesn't want to stay there. #narrator
Beatrice can't see anything in front of her. #narrator #slow

I can't believe they ruined my day! #beatricevoiceover
Why do I keep letting them do this to me? #beatricevoiceover
I swear this is the last year I spend my birthday with them! #beatricevoiceover
I hate them, I hate them! #beatricevoiceover


+ [Run] -> Run

=== Run ===
She starts running. She is now lost in the fog, the house is just a faded light behind her. Suddently, she hears a voice calling for her. #narrator #first

Did they? #beatricevoiceover #slow
Did they follow me here? #beatricevoiceover

+ [Turn around] -> Turn_around

+ [Keep going] -> Keep_going

=== Turn_around ===
Beatrice! Move! #grandma #first

prologo5 #narratorwithimage

Beatrice turns and sees a car coming in her direction. #narrator
She is pushed away from the road by her grandma. #narrator
There's a CRASH. #narrator

grankiller #achievement
~grandma_dead = 1

+ [Continue to Chapter 1] -> END

=== Keep_going ===
The voice gets louder. #narrator #first

Beatrice! Move! #grandma

prologo5 #narratorwithimage

Beatrice turns and sees a car coming in her direction. #narrator
She is pushed away from the road by her grandma. #narrator
There's a CRASH. #narrator

grankiller #achievement
~grandma_dead = 1

+ [Continue to Chapter 1] -> END