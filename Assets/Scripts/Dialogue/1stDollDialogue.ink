VAR alreadychosen = 0

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
Oh... I'm sorry to hear that. Hopefully, I can cheer you up! #portrait:M_HairDownSad

I know you're here a lot anyway, but I wish I saw you even more. #portrait:M_HairDownDefault
-> My_Choices2

== My_Choices2 ==
* [ My parents say I have to go to school. ] -> Ask_Help1
* [ I wish I could too. ] -> Ask_Help2

== Ask_Help1 ==
School... you've never told me about that. #portrait:M_HairDownSurprise

Well, anyway. I urgently need your help! Like MAJOR help!

I'm getting super bored of my hairstyle... I want something fun or cute.

Could you choose from a selection of these hairstyles for me?
->Interact

== Ask_Help2 ==
Then what's the wait for? #portrait:M_HairDownSurprise

Well, anyway. I urgently need your help! Like MAJOR help!

I'm getting super bored of my hairstyle...

Which one sounds the coolest?
->Interact

== Interact ==
#portrait:M_HairDownDefault
+ [A hairstyle with a heart notif.] -> Heart
+ [A hairstyle that extudes "fabulous".] -> Regal
+ [A hairstyle with a girly flair.] -> Playful


//////////////////////////////////////////////////////////////////////////////////////
== Heart ==
Oh my, how cutesy! I feel like a butterfly! #hair:DefaultHairIcon #portrait:M_Default

Is this the one you wanted?
-> YES_OR_NO

== Regal == 
Oh wow, how regal! I feel like an extravagant princess talking to my subjects! #hair:HairCrownIcon #portrait:M_HairCrownDefault

Is this the one you wanted?
-> YES_OR_NO

== Playful == 
Hehe, so playful! I want to keep swinging my hair! #hair:HairUpIcon #portrait:M_HairUpDefault

Is this the one you wanted?
-> YES_OR_NO


//////////////////////////////////////////////////////////////////////////////////////


== YES_OR_NO ==
+ [Yep, you look great!] -> PickedHair
+ [No, this doesn't suit you.] -> Unsure
-> DONE

== Unsure ==
Oh! Uh, could you pick another one for me then?
~ alreadychosen++
-> Interact

=== Upset
{alreadychosen == 3:
->-> Indecisive
}

=== Indecisive
Are you always this mean? 
...
Can you just choose one that looks good?

-> Interact

// add quest here 

== PickedHair ==
lksajkas
-> DONE


