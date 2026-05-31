EXTERNAL changeScene(sceneName)

And again, you're back in the darkness.

Perhaps you could call it your "limbo".

The voices.

How many hours has it been?

You know they care for you, but it feels like these days you don't even matter.

It's ridiculous. It's so ridiculous. In the other world, these arguments cease to exist. 

...

There's you. 
-> YourChoice

== YourChoice ==
{(Stay == 0) && (Confront == 0):
Your mind is frazzled. 

Should you stay in your world? Should you try to understand what's going on?
}

{(Stay == 3) && (Confront == 3):
You're conflicted. Your mind is saying you should do both.

You know you can't do both. 

You need to pick one.
}

{(Stay == 4):
-> Final_Stay
}

{(Confront == 4):
-> Final_Confront
}

+ [STAY] -> Stay 

+ [CONFRONT] -> Confront

== Final_Stay == 
You've decided to stay. You don't need to know what's going on out there.

In the comfort of your own room, you can keep playing forever, and ever, and...

Ever.

* [STAY] -> GoBack 

* [STAY] -> GoBack

//You've chose to stay. Is ignorance really bliss?
-> DONE


==GoBack==
Yay, you can keep playing with your toys!
~ changeScene("MainWorld_Stay") 
-> DONE

== Final_Confront == 
You have to find out. 

You decided to confront your situation. You want to know what has happened.

You don't know where it could go from here, but maybe it's best to not stay in the dark forever...

Thank you for playing Karimah's Paracosm. We hope you enjoyed it.

//You've chosen to leave. Do you really want to know the truth?
-> DONE

== Stay == 
...
{That's right. There's no reason you should exit this room. | Leaving would make you sad. You don't want to be sad, do you? | You should never leave this room. Your friends care for you, more than anyone else ever will. You have to stay. | Exactly.}
-> YourChoice
-> DONE

== Confront ==
...
{You feel like you need to know the truth. | You really feel like this is something you should know. | The truth has been grating you for years now. You deserve to know, don't you? | Exactly.}
-> YourChoice
-> DONE

=== function changeScene(sceneName) ===
    // Fallback: Inky will run this, but Unity will override it
    ~ return