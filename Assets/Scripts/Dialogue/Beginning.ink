EXTERNAL changeScene(sceneName)

You hear a woman's voice addressing you. It is slightly shrill, like she is on the verge of tears.

It unsettles you.

Woman: "Karimah"? //Knock knock

Woman: "Kari, lovely?"
 
The door rattles, the person on the other side desperate to get your attention. -> My_Choices2
 
 == My_Choices2 ==
* [ Do nothing. ] -> Do_Nothing
* [ Say something.] -> Speak

== Do_Nothing ==
You stay silent. As usual.

You don't want to open the door.

They're arguing again. About you.
-> Argument

== Speak ==
You try to speak, but your voice croaks way before they could hear any word.

You don't want to open the door.

They're arguing again. About you.
-> Argument

== Argument == 
Woman: "Her door's locked. She's hiding from me again."

Woman: "Because of you."

A man's voice is heard. He seems uninterested and rather unkind.

Man: "Don't start again. I don't have time for this right now."

The woman starts to cry very loudly. It rings in your ears like always, even through the door.

Woman: "HOW AM I SUPPOSED TO STAY CALM WHEN EVERYTHING IS GOING TO $^&*???"
//~ changeScene("MainWorld")
-> DONE

=== function changeScene(sceneName) ===
    // Fallback: Inky will run this, but Unity will override it
    ~ return