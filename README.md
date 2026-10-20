# in-class-activities

## Devlogs

### W1

Hello World

When moving the Camera off of the Cat Game Object, the camera remains stationary and no longer follows the player Cat Game Object. This is because of the camera no longer being a child of the Cat Game Object which means its not attached to a player controller.



**Itch Page:** https://blucyko.itch.io/gdim-33-week-1-activity

### W2
**1. Why are the r, g, and b variables floats instead of ints, bools, or strings?**  
The r, g, and b variables are floats instead of ints, bools, or strings because rgb values involve fractional values, which floats represent.

**2. Why is the _bounce variable an int instead of a float, bool, or string?**  
The \_bounce variable is an int instead of a float, bool, or string because this value will always use whole numbers which int represents.

**3.The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?**  
The error I got after Step 4 of Part 2 said Assets\\W2\\Scripts\\Ball.cs(67,18): error CS1002: ; expected. This indicated that this line was missing a ; to end the line of code indicating a syntax error.

### W3
## Activity 1: method discussion
**1. You’re building a visual novel, and you’re writing a method named GetResponse that gives you a character’s text response to a player’s dialogue choice. The relevant data for the dialogue choice are the player’s current friendship level with the character and a flag that tells you whether or not the player knows the character’s secret.**  
I would make the parameters of GetResponse use the int type based on the player's current friendship level with the character, and the return type use the string type to give a character's text response. The return type of the flag indicating whether or not the player knows the character's secret should be a bool.
**Code:** String GetResponse(int choice, int friendshipLevel, bool secret)

**2. You’re building a horror game, and you’re writing a method named SetLightDimness that makes the room’s lights brighter or darker based on the player’s current sanity level. The player’s sanity level is a number that goes from 0% - 100%. The method changes the light itself, so it doesn’t need any output.**  
I would make the parameters of SetLightDimness use an int based on the player's sanity level and the return type would be void since it doesn't need any output.
**Code:** void SetLightDimness(int sanityLevel)

**3. You’re building a rhythm game, and you’re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.**  
I would make the parameters of DidPlayerHitBeat use a float based on the time they pressed a key and the return type a bool as a flag whether or not the beat was accurately hit.
**Code:** bool DidPlayerHitBeat(float accuracy)

## Activity 2: Components & classes metaphor
**With your table mates, come up with a metaphor to explain the relationship between classes and Components with a metaphor. Also describe how methods and member variables factor into that metaphor.  Remember that classes are templates that can become Components; member variables are traits of each class; and methods are things the class can do.**  
With my table mates, we decided that a metaphor to explain the relationship between classes and components would be 

**Class:** Taco shell  
**Component:** Full taco (from Taco Bell)  
**Member variables:** Ingredients  
**Methods:** How you want the taco  

## Activity 3 methods coding activity
**1. Why do you think the balls get extremely bright, especially in the Scene, if they bounce too many times?**  
I think the balls get extremely bright if they bounce too many times due to ballRenderer.color in step 9 being affected by the color multiplier, which goes to a higher value when the ball moves at a certain speed.

### W4
Table #4  
**1. What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?**  
We added the Rigidbodies to the Cat and SoccerBall game objects since those objects require physics interactions. We also checked IsTrigger on the Goal game object since the goal detects whether the SoccerBall collider enters the Goal's collider.

**IF your game did not work perfectly the first time you tested it, talk about what you had to fix.**
The first time I tested it, the Cat started rotating out of place. To fix this, I set the rotation to freeze on the X and Z axes.

## Open-Source Assets

### W1

* Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727
* Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153

