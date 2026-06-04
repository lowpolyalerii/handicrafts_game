EXTERNAL changeScene(sceneName)

Hey, Karimah. #portrait:Ines_Surprise

I won't ask.

Do...

Do you want to paint a little picture to take your mind off it? #portrait:Ines_Default

-> Choices1

== Choices1 ==
+ [Okay...] -> YES
+ [No, not right now.] -> NO
-> DONE

== YES ==
Have fun! #portrait:Ines_Surprise 
~ changeScene("PaintingPicture") 
-> DONE

== NO == 
Okay! 

Talk to me again if you'd like to paint. #portrait:Ines_Default
// add quest here 
-> DONE

=== function changeScene(sceneName) ===
    // Fallback: Inky will run this, but Unity will override it
    ~ return