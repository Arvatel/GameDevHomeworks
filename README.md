# Game dew Homeworks

## Homework 1

1. Create Unity project (it will be used for the FPS game)
2. Compose scene similar to the one shown on the screen shot
	1. Floor (advised size 50x50)
	2. 4 external walls (advised height 4)
	3. 6 internal walls (advised height 3)
3. Add “Player” (“Capsule” object)
4. Add two simple structures of your choice (e.g., like “Fan” on the screenshot). Be creative!
5. Add lights
	1. Directional light angled from top-side (intensity 0.6)
	2. Four point lights at corners (adjust range and intensity)
	3. One point light in the middle above the scene (adjust range and intensity)
6. Create “HelloWorld” script and add it to some scene object (verify its peration in console tab)
7. Create a class called player with the following structure:
	a. Properties:
		i. Public Position : Vector3
		ii. Private Health : Int
	b. Functions:
		i. updateHealth( int delta)
		ii. This function updates health by taking the delta (change) to the health
		iii. Make it print “player died” in the console if health drops to 0
8. Make code that every 2 secs the following happens:
	a. Player’s position property is changed to a random value
	b. Player's health is decreased by a random value using the updateHealth function.
	c. (Comment: add script to a scene object, use “Update” method and “Time” object to track time.)

## Homework 2

1. Add to your FPS game project (started in HW1)
	a. “Player” object (adjust “Capsule” object that was added in HW1)
	b. “MouseLookX” script (for horizontal mouse look)
	c. “MouseLookY” script (for vertical mouse look)
	d. “FPSInput” script (for character movement using keyboard)
2. Add fixed axis rotation to some custom element of your scene
3. Add complex movement of some custom element of your scene (more complex than rotation
around a fixed axis)
4. Modify FPSInput script so that “Player” would move at double speed if “Left Shift” is pressed.
(Tip: you can use “Input.GetKey(KeyCode.LeftShift)” to check if the key is held down.)

## Homework 3

1. Add to your FPS game project (started in HW1 and HW2)
	a. “Enemy” object
	b. “WanderingAI” script (for enemy motion with obstacle avoidance)
	c. “RayShooter” script (to make possible for player to shoot enemy)
	d. “ReactiveTarget” script (for enemy to react on hits by player)
2. Add to your FPS game project (started in HW1 and HW2)
	a. Rework “Enemy” object into “Enemy” prefab
	b. “SceneController” script (to spawn new enemy upon death of old enemy)
	c. “Fireball” prefab
	d. “Fireball” script and “PlayerCharacter” script (to allow enemy shooting projectiles at the player)
3. Create alternative scripts for player to shoot projectiles (affected by gravity) at the enemy by pressing RMB (right mouse button)
4. Modify “WanderingAI” script to allow smooth rotation of the enemy on obstacle detection

## Homework 4

1. Add to your FPS game project (started in HW1, HW2 and HW3)
	a. Apply textures to 3D objects (floor, walls, enemy etc)
	b. Replace default skybox with a new skybox using external textures
2. Add to your FPS game project (started in HW1, HW2 and HW3)
	a. Compose in Blender new 3D model “table with 4 legs” (textures are not required, but you may add a texture if you want)
	b. Export this 3D model from Blender to Unity and place it on the scene
3. Add to your FPS game project (started in HW1, HW2 and HW3)
	a. Create “fire” particle effect and add it on top of the table (2b)
	b. Create “fire” particle effect and add it to the “fireball” projectile of the enemy
4. Create “smoke” particle effect and add it to the scene
5. Create a “water spot” (blue circle on floor) and add a script for enabling water spraying when the player walks through it using particle effect


## Homework 5

1. Add to your FPS game project (started in HW1 – HW4) a doorway with a door (e.g., a cube) that is controlled by player when pressing a chosen key on the keyboard (player must stand near the door looking roughly in the direction of the door).
2. Add to your FPS game project (started in HW1 – HW4) a doorway with a door (e.g., a cube) that is controlled by a zone around the door. The door opens when the player enters the zone. The door closes when the player exits the zone.
3. Create a fan that is controlled by a “console” (can be just cube). When player presses a chosen key on the keyboard standing near the “console”, the fan activates or deactivates. Make sure, that the fan speeds up and slows down gradually.
4. Create a “fountain” that gets activated when the player enters a round zone around the fountain and gets deactivated when the player exits the zone. Use particle system to represent the activated fountain.

## Homework 6

1. Add to your FPS game project (started in HW1 – HW5) floor and wall textures with normal maps (download such textures if you don’t have some).
2. Add to your FPS game project (started in HW1 – HW5) player ability to jump when pressing a key (e.g., “spacebar”) and to crouch when pressing another key (e.g., “C”). Crouch walking should be slower than normal. Crouching character can walk under obstacle (place such obstacle and demonstrate that walking character cannot go through and crouch walking character can go through).
3. Place 2-3 jump pads on the scene. When player walks into such jump pad, he will be thrown high in the air (like jump pad in “Quake” games). Add high locations that can be reachable only using jump pads.


## Homework 7

1. Create new 2D project in Unity (intended for a simple platformer game) and add
	a. 3 floors, 5-7 obstacles (can be jumped on), 2 sloped floors
	b. Player script to enable walking and jumping (adjust gravity so that player cannot just jump to upper floor)
2. Add 2 one-way moving platforms so that the player can jump to upper floor using these platforms (add scripts, so that the player can stand on a moving platform)
3. Add animation to the character (“idle” cycle and “walk” cycle, download sprites or draw yourself)
4. Add 4-5 vertical stairs to the scene between floors, so that the player can climb up or down (also add “climb” cycle to player animation)


## Homework 8

1. Add to your FPS game project (started in HW1 – HW6) GUI (in the form of Unity UI, uGUI).
	a. Add image and label for the score defeated enemies (upper left)
	b. Add button for Settings (upper right)
	c. Add Exit button below Settings button
	d. Add player Name label (upper middle)
	e. Add label for Health tracking (lower right)
	f. Add image for Popup Settings form
		i. Add to the form “Name” input field
		ii. Speed slider
		iii. Close button
2. Add scripts to enable tracking of defeated enemies and player health on corresponding GUI labels.
3. Enable mode of operation when in the beginning the cursor is disabled and Popup Settings form is disabled. The FPS game works as usual. On ESC key the FPS game is paused and mouse is enabled. On Settings button click the Settings Popup form is enabled (and disabled on Close button click). On another ESC button the cursor is disabled and the FPS game is unpaused.
4. For the Popup Settings form, enable player Name label update with the name entered in Input Field. On the change of slider, enable broadcasting of new speed to both Player and Enemy, so that movement speed of both would be adjusted appropriately (make sure that new enemy after respawn would have updated speed).

## Homework 9

1. Add to your FPS game project (started in HW1 – HW6, HW8) sound special effects.
	a. Looped sound attached to enemy
	b. Script activated sound for player shots (different sound if hit wall or enemy)
	c. Sound of footsteps (active when walking, no sound when crouch walking, louder and faster sound when running)
	d. Sound of player jumps
	e. Sound for enemy shooting at player
	f. Looped sound for the enemy’s projectile when flying
	g. Sound for clicking buttons in GUI
2. Add to your FPS game project (started in HW1 – HW6, HW8) 2-3 music tracks. Add controls on SettingsPopup form to start these music tracks (should be looped) and to stop music (e.g., buttons or some other control of your choice).
3. Add to your FPS game project (started in HW1 – HW6, HW8) on the SettingsPopup form 2 sliders to control music volume and to control mater sound volume.
4. Create WAV file with 5 seconds long sound according to the specification. You may use Audacity, Matlab/Octave or some other tool (like Python). Attach this WAV file to the Moodle submission.
	a. the frequency goes linearly from 440Hz to 1760Hz and the amplitude goes linearly from 0.3 to 0.6 for the beginning 3 seconds
	b. the frequency goes linearly from 1760Hz to 880Hz and the amplitude goes linearly from 0.6 to 0.1 for the last 2 seconds
