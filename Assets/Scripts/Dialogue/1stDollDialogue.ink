EXTERNAL showing(enabled)

Oh? You're already back? Nice to see you again! #portrait:M_HairDownSurprise

I get sad when you're gone for too long. #portrait:M_HairDownSad

Are you doing anything in particular today? #portrait:M_HairDownDefault

->My_Choices

== My_Choices ==
* [ This world is so much better than the other one. ] -> ThisWorld
* [ I don't feel so good today. ] -> Dot

== ThisWorld ==
Wow, yeah! You can be with us all the time, right? Why aren't you here more? #portrait:M_HairDownSurprise
-> My_Choices2

== Dot ==
Oh... I'm sorry to hear that. What's a parent? #portrait:M_HairDownSad

I know you're here a lot anyway, but I wish I saw you even more. #portrait:M_HairDownDefault
-> My_Choices2

== My_Choices2 ==
* [ My parents say I have to go to school. ] -> Ask_Help1
* [ I wish I could too. ] -> Ask_Help2

== Ask_Help1 ==
School? Parents? I don't know what that is. #portrait:M_HairDownSurprise

But, anyway. I urgently need your help, Kari! Like MAJOR help!

I'm getting super bored of my hairstyle... but your magical glitter pen can help me!

Tell me what style I should change it to, and the pen will change it for me!
->Interact

== Ask_Help2 ==
Then what's the wait for? #portrait:M_HairDownSurprise

Well, anyway. I urgently need your help! Like MAJOR help!

I'm getting super bored of my hairstyle...

->Interact

//////////////////////////////////////////////////////////////////

== Interact ==
#portrait:M_HairDownDefault
Okay, which one is the one for me?
+ [A hairstyle with a heart notif.] -> Heart
+ [A hairstyle that extudes "fabulous".] -> Regal
+ [A hairstyle with a girly flair.] -> Playful

== Interact2 ==
#portrait:M_HairDownSurprise
Sorry...
{HiddenUpset >= 2:
Karimah... you look like you're about to cry. 

I'm sorry for upsetting you.

W-we can change topic!

Do you mind... choosing a style?
}

* [A hairstyle with a heart notif.] -> Heart
* [A hairstyle that extudes "fabulous".] -> Regal
* [A hairstyle with a girly flair.] -> Playful


//////////////////////////////////////////////////////////////////////////////////////
== Heart ==
Oh my, how cutesy! I feel like a butterfly blissfully flapping its wings! #hair:DefaultHairIcon #portrait:M_Default

Is this the one you wanted?
{Unsure > 3: ///if youre indecisive
-> YES_OR_NO2
}

-> YES_OR_NO /// normal

== Regal == 
Oh wow, how regal! I feel like an extravagant princess talking to my subjects! #hair:HairCrownIcon #portrait:M_HairCrownDefault

Is this the one you wanted?

{Unsure > 3: ///if youre indecisive
-> YES_OR_NO2
}

-> YES_OR_NO /// normal

== Playful == 
Hehe, so playful! I want to keep swinging my hair around! #hair:HairUpIcon #portrait:M_HairUpDefault
Does this suit me?

{Unsure > 3: ///if youre indecisive
-> YES_OR_NO2
}

-> YES_OR_NO /// normal


//////////////////////////////////////////////////////////////////////////////////////


/// if karimah chooses normally
== YES_OR_NO ==
+ [Yep, you look great!] -> PickedHair
+ [Nope.] -> Unsure

///if karimah was indecisive
== YES_OR_NO2 ==
* [Looks great...] -> PickedHair2


/// levels of unsureness based on previous choices
== Unsure ==
Um...

{Unsure == 2:
Oh! Haha, Kari. Please pick one!
-> Interact
}

{Unsure < 3:
Could you pick another one for me then?
-> Interact
}

{Unsure == 3:
You're quite... picky today. #hair:default2
Unusual...
Can you just *please* choose one that looks good?
-> Interact
} 

{Unsure > 3:
Karimah.  #hair:default2 #portrait:M_HairDownSad
Just.
Choose.
One.
The loud voices outside can't decide either. //glass crack
Wait. #portrait:M_HairDownSurprise
Sorry. I'm super sorry. #portrait:M_HairDownSad
I don't think I should have said that.
-> HiddenUpset
} 


== HiddenUpset ==
* [ It's okay. I'll choose. I don't want to think about that. ] -> Interact2
* [ Why would you say that? Don't talk about them. ] -> KariUpset
* {HiddenUpset == 2} [NO-ONE. THEY ARE NOTHING.] -> Interact2


== KariUpset == 
Karimah, I always hear them arguing outside your room... // hidden fact learnt
Are they bothering you?
Who are-
-> HiddenUpset


== PickedHair ==
Thanks soooo much!! Now I look super cute.
Thanks to your Magical glitter pen, I can change my look however I want!
Maybe next time, I'll let you braid it from scratch.
It took 8 hours on and off though so... 
-> DONE

// change idle into chosen hairstyle, play cheer sound

== PickedHair2 ==
This style looks so cute. Thanks again, Karimah!!

{HiddenUpset < 2:
I won't talk about it again.
}

{HiddenUpset >= 2:
I... won't ask about it again.
}

// change idle into chosen hairstyle, play cheer sound
-> DONE


