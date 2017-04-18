Welcome to Avenon, the world that lives in my head (or close to).
W,A,S,D to move, SPACE to jump, hold L-Shift to dash
Combat: Attack, Defend, Spell, Combat Manuever
Combat Manuevers: Bull Rush, Trip, Disarm (may not be implemented yet)
The combat system is currently a simulated style, intended to be
free world exploration and a turn based strategy combat system.
You will have to adjust the camera after player creation, it comes in at
his feet, scroll out and left mouse button to move the camera. The camera
should stay behing the player avatar at all times.

All assets are from the unity store.

The game is loosly based on Paizo's Pathfinder game rules converted to code.
The game needs a skill structure and a spell structure.
The item structure still needs work.


******************ASSET LIST*********************
Character Creation screen by: JJcanvas
http://jjcanvas.deviantart.com/art/The-ruins-in-the-lake-186159239

Intro Screen found on: BlogSpot
http://wallpapers-xs.blogspot.com/2012/07/fantasy-art-wallpapers.html

Music Composed by: Adrian Von Ziegler
		BattleScene: Arch Rivals
		IntroScene:  Part of the Pack
		CreateScene: Moonsong
		Exploration: Immortal
Youtube Channel: https://www.youtube.com/channel/UCSeJA6az0GrNM4_-pl3HQSQ
Converted to .mp3 using WavePad Sound Editor


Terrain Supplied by: Unity Technologies;
	    Created by: Christine Jordan;
Animated Character by: Unity Technologies;
3d Goblins by: PolyNext;

Notes:
Unfortunately by the time I started playing around with the 
animated character I could not get my movement script to work 
with the animations, I have included the script I wrote for 
it, however the current game uses the one that came with the
Unity animated character. Currently health/energy reset for 
each battle;

I intend to add more stats and clean up the existing stats;
I also think that I can use the infor manager class to do 
more stuff in the game rather than creating variable in 
individual classes and I intend this when I clean up the 
code;

I used functions OnGUI for testing purposes, will make those 
into a more refined GUI later on.

I thoroughly commented as much as I could although I could have
missed a few things.

Currently after battle I just reload the exploration level without 
keeping the player in the position it was in when combat started

*TO DO*
Working on eliminating as many if else statements as possible;
Build xml databases for items and abilities;
Change ALL Getters & Setters from implicit BACK to explicit;
Need to add health/energy calculations to character creation;
Need to add curent/max health/energy variables for stat storage;
Calculate health/energy at character creation;
Enemy Databases;
Still need to declare a main stat for each class since we are only
using 2 classes the main stat is embedded in an if else where needed;
