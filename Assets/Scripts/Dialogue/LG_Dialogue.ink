VAR count = 0

Hi, Karimah. #portrait: LastGirl_Default

I love all the origami you've made for me. 

My favourite is... 

Wait, guess which animal is my favourite.

+ [Bunny.] -> Why_Bunny
+ [Swan.] -> Why_Swan
+ [Cat] -> Why_Cat

== Why_Cat == 
Yes, I love cats! Can you guess my favourite breed?

+ [Ragdoll.]
Wrong! I do love how fluffy Ragdoll Cats are, though.
Talk to me when you want to guess again, Karimah.
-> DONE

+ [Bengal]
Correct! You're really good at this. I love Bengal Cats' big eyes and markings!
-> DONE

+ [Ragamuffin]
Wrong. But I do like them. Ragamuffins are so playful and elegant cats.
Talk to me when you want to guess again, Karimah.
-> DONE


== Why_Swan == 
Wrong answer.
I do like swans though. 
Guess which fact is true about them.

+ [They don't mate for life.] Nope, still wrong.
~ count = 3
-> Wrong

+ [They are territorial.] Correct!
~ count = 4
-> Right

+ [Their wingspans reach up to 5 feet.] Nope, still wrong.
~ count = 5
-> Wrong

== Why_Bunny == 
Wrong answer. Bunnies are cute and all, but they're not my favourite. 
Can you guess why?
+ [They have big families.] Nope, still wrong.
~ count = 1
-> Wrong

+ [They are only active at night.] Nope, still wrong.
~ count = 2
-> Wrong

+ [They eat their own waste.] Correct!
~ count = 6
-> Right

== Wrong ==
{(count == 1): But I can imagine caring for a big family of bunnies would be too much.}

{(count == 2): I find the night to be very beautiful and calm.}

{(count == 3): Most swans mate for life, and even do special rituals to identify each other. Very cute.}

{(count == 5): It's actually double that!}

Talk to me again if you want to guess again.
-> DONE

== Right ==

{(count == 4): They can be super aggressive when it comes to defending their offspring, or even mates.}

{(count == 6): They are cute animals, but that fact really grossed me out.}
-> DONE