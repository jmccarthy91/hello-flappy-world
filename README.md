# hello-flappy-world
My first game! It's a flappy bird clone. You can play it in browser here: https://lfnt.itch.io/hello-flappy-world.


# Credits
GMTK for the excellent tutorial: https://www.youtube.com/watch?v=XtQMytORBmM
SR Studios Kerala for the bird sprites: https://assetstore.unity.com/packages/2d/characters/2d-cute-birds-4-in-1-mini-pack-237273
mk.matheusklein for the music and SFX: https://assetstore.unity.com/packages/audio/sound-fx/free-casual-pack-sfx-197054

# Dev Log & learnings

# Why Unity
I decided to learn in Unity for a few reasons. First, it’s free software. This was my first foray into game making as an adult and I wanted to test my hypothesis that I’d enjoy it without having to invest too much. Second, it’s been used to make a wide variety of commercially successful games and they don’t take a % cut (like Unreal Engine) of revenues. Though my initial goal isn’t to make money, I do like the idea of someday earning revenue from my games! Because I’m a complete noob, I don’t yet know what kind of games I enjoy making most so I wanted an engine that’d enable me to try creating from many genres. Third, it’s extremely well-documented. Not only does Unity have their own extensive online manual but just as importantly, there are tons of user-created tutorials and Q&A posts I can use to learn.

# What game dev looked like for me
After watching GMTK’s tutorial through, I decided to follow along using my weekends and evenings. I wasn’t in any particular rush.

On the first evening, I simply downloaded and set up unity then created an empty project. I didn’t have a lot of time so my intention was to reduce the friction to get started for future me.

During my second evening, I set up my character, pipes, and movement. The core gameplay loop was created! Since I was brand new, this largely looked like me typing exactly what GMTK typed line-by-line. I was learning a lot about how everything worked, but there were some core concepts I didn’t understand yet, like the purpose of classes. I was having a blast AND I now had a game I could watch my wife play after each session 😊

For my third evening, I dedicated myself to creating the scoring & death system plus the UI. My game now felt like an actual game! This was very felt very similar to my second evening – I learned so much but was painfully aware that I wasn’t yet understanding key fundamentals.

Then GMTK’s tutorial stopped holding my hand. He suggests a few iterations to work on like sound, animation, and bug fixes but only briefly shares advice on how to get started. Though this slowed my significantly, working through these challenges rapidly increased the pace of my learning. I was no longer being spoon-fed answers so I had to figure out how to learn for myself! After quickly fixing some simple gameplay bugs, I spent a frustrating but ultimately cathartic session and a half figuring out how to make SFX work. The feeling of accomplishment when I finally got them to work plus feeling how much more polished they made my game seem was incredible. I discovered the Unity Asset Store and Brackeys’ YouTube channel filled with stellar Unity tutorials. Though I was still following tutorials, I now had to figure out how to apply what I was seeing to my own game. As a result, I feel very confident in my ability to work through other challenges in the future!

I spent my last 2 sessions adding difficulty scaling (without tutorials!) and adding other polish, like a title screen. Another particularly valuable exercise I did was going back through all of my assets and code. In the end, I’m proud of what I created! I don’t feel like a game designer yet, but I am confident I could figure out how to create a prototype for many kinds of 2D games.

# What I learned
-How to solve dev challenges by googling
-The power of classes and the efficiency benefit of building personal libraries, for example the Sound class I created enabled a super clean sound manager and now that’s something I’ll be able to quickly re-use in all of my future games.
-How objects can link scripts, sprites, sounds, and interact with physics and other objects. I also learned how to properly work with public data from other scripts
-Why games can take so long to build, especially if I’ll be learning as you go. I’m now capable of taking on a bigger game project but I strongly suspect I’ll learn faster if I constrain my scope and create more projects.
-The cost of changing a design decision and the value of well-architected code. For example, to increase the difficulty of my game I had to pull data from 3 different scripts which was a less efficient way to use my time. Even if I didn’t have to look up every command, a more experienced engineer would’ve been able to make this game orders of magnitude faster & cleaner than me just by creating cleaner architecture.
-The importance of math in development. Every interesting movement or difficulty increase required thinking mathematically to implement my ideas.

# What I plan to do next
I have an initial dream game in mind that I’d love to build which involves rhythm, cards/power ups, and narrative. That’s an ambitious project for a complete beginner so I plan to build up to it. To do that I’ll develop a couple games that will teach me the fundamentals of each of those mechanics. Here’s a tentative roadmap:

-Next: Top-down shooter/action game to learn on movement (for rhythm) and power-ups (for card design). I plan to keep this scope intentionally minimal and learn to create my own sprites and animations. My goal is to add in a novel feature that makes the game fun.
-Then: Card-based RPG designed around a strong narrative theme. I plan to try my hand at sound design so I could potentially create, or at least recognize good SFX & music. My goal is to create a memorable experience so I’ll need to be extremely thoughtful about how to do this while maintaining a small scope.
-Finally: Initial dream game!
