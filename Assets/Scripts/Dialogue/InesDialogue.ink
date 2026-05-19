VAR restart = false
EXTERNAL changeScene(sceneName)

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

I'd love a small painting from you. #portrait:Ines_Default

You see all these beautiful surroundings you've painted for us... I'd really love it if you did one for me! #portrait:Ines_Default
-> My_Choices2

== My_Choices2 ==
* [ Hehe thanks! I'd be happy to do that!] -> Ask_Help1
* [ Do I really have to? ] -> Ask_Help2

== Ask_Help1 ==
Thanks! #portrait:Ines_Default

{Ask_Help2 or Ask_Help1 > 1:
Oh, you're back!
}

You are so generous as always. #portrait:Ines_Default

Would you like to start now?


+ [ Of course!] -> YES
+ [ Nope. ] -> NO

== Ask_Help2 ==
You're very blunt today, it seems. #portrait:Ines_Surprise

I won't force you but it would be nice. #portrait:Ines_Default

Could you talk to me when you feel like it? #portrait:Ines_Default
-> DONE

== YES ==
~ changeScene("PaintingPicture") 
-> DONE

== NO == 
-> Ask_Help2
// add quest here 
-> DONE

== After ==
-> Ask_Help1

=== function changeScene(sceneName) ===
    // Fallback: Inky will run this, but Unity will override it
    ~ return