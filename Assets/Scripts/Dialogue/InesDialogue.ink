EXTERNAL LoadScene(PaintingPicture)

Hello, Karimah. #portrait:Ines_Default

You're back again today. You don't look too well. Are you alright?

->My_Choices

== My_Choices ==
* [ I'm fine! ] Oh? #portrait:Ines_Surprise
    I see.
    -> Favour
* [ ... ] Hmm...
    If you are feeling bad, don't hesitate to let me know.
    -> Favour

== Favour ==
Karimah, I have a small favour to ask of you... #portrait:Ines_Default

I'd love a small painting from you.

You see all these beautiful surroundings you've painted for us... I'd really love it if you did one for me!
-> My_Choices2

== My_Choices2 ==
* [ Hehe thanks! I'd be happy to do that!] -> Ask_Help1
* [ Do I really have to? ] -> Ask_Help2

== Ask_Help1 ==
Would you like to start now?
{Ask_Help2 >= 1:
Oh, you're back!
}

+ [ Of course!] -> YES
+ [ Give me a minute. ] -> NO

== Ask_Help2 ==
I see. #portrait:Ines_Surprise

I won't force you but it would be nice. #portrait:Ines_Default

Could you talk to me when you feel like it? 
->DONE
-> Ask_Help1

== YES ==
// ~ LoadScene("PaintingPicture") //YAY! //Trigger minigame
-> DONE

== NO == 
-> Ask_Help2
// add quest here 
-> DONE

== After ==
-> Ask_Help1
