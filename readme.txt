# This version of DS Gadget has been created for InfernoPlus' "Remastest" mod and contains various changes to item lists. 
# Based on DS-Gadget 3.0 by JKAnderson.

Changelog (Prerelease 1.1):
• Fixed title bar version counter
• Fixed a target mismatch between the Bonfires "Ash Lake (Bonfire)" and "Ash Lake (Stone Dragon)"
• Fixed a bug that caused the "Skull Lantern" item to not spawn for some players
• Renamed the unused "Gwynevere Talisman" and "Miracle: Escape Death" descriptors
• Renamed "Black Eye Orb" to "Black Eye Orb (Target: Lautrec of Carim)" and "Black Eye Orb (Shiva)" to "Black Eye Orb (Target: Shiva of the East) (Cut Content)"
• Renamed "Sunlight Spear" spell to "Sunlight Slam"
• Moved "Black Eye Orb (Target: Shiva of the East) (Cut Content)" from "Key Items" to "Usable Items_


Changelog (initial release):
• Removed version indicator on main window title bar (will be added back in future releases)
• Removed "Mystery Armor", "Mystery Weapons" and "Mystery Goods" item lists
• Moved "Elite Cleric" and "Mage Smith" Armor sets to "Armor" item list
• Moved all "Estus Flask" entries to "Consumables" item list, removed "Empty Estus Flask" entries
• Moved "Black Eye Orb (Shiva)" cut content item to "Key Items" item list (functionality missing)
• Moved "Escape Death" cut content spell to "Spells" item list (works, has identical function to Rare Ring of Sactifice, uses "Magic Revival" death message instead of "Ring Revival")
• Moved "Gwynevere's Talisman" cut content spell tool to "Spell Tools" item list (does not work properly, usage in Arena+ strongly discouraged)
• Moved "Skull Lantern" from "Spell Tools" to "Usable Items" item list due to its placement in "Spell Tools" item list having caused confusion
• Renamed the following Magic-based Spells (located under "Spells" item list): "Soul Arrow" spell to "Soul Ray", "Great Soul Arrow" to "Soul Arrow", "Heavy Soul Arrow" to "Heavy Soul Ray", "Great Heavy Soul Arrow" to "Heavy Soul Arrow", "Homing Crystal Soulmass" to "Crystal Mass", 
"Crystal Soul Spear" to "Crystal Storm", "Magic Weapon" to "Soul Weapon", "Great Magic Weapon" to "Soul Dart", "Crystal Magic Weapon" to "Crystalize Weapon", "Magic Shield" to "Soul Shield", "Strong Magic Shield" to "Deflection", "Cast Light" to "Light", "Hush" to "Conversion", "Aural Decoy" to "Distract", 
"Fall Control" to "Soul Roots", "Resist Curse" to "Break Curse" and "White Dragon Breath" to "Crystal Ray"
• Renamed the following Pyromancies (located under "Spells item list): "Fire Orb" to "Eruption" and "Firestorm" to "Warmth"
• Renamed the following Miracles (located under "Spells" item list): "Gravelord Sword Dance" to "Gravelord Sword Strike", "Gravelord Greatsword Dance" to "Gravelord Sword Strike", "Seek Guidance" to "Sacred Oath", "Great Lightning Spear" to "Lightning Storm" and "Karmic Justice" to "Karmic Balance"
• Added "Bear" cut content Armor set to "Armor" item list
• Added the Pyromancies "Flame Swathe" (ID: 4120) and "Black Fissure" (ID: 4560) to "Spells" item list
• Added the Miracles "Intervention" (ID: 5315) and "Projected Heal" (ID: 5330) to "Spells" item list
• Added the Spell IDs 5920, 5930, 5940 and 5959 to "Spells" item list (as requested by InfernoPLus; these are IDs for potential future spells. Judging by the ID prefix "5", these will most likely be populated by Miracles, if at all)

--------------------------------------------------------------------------------------------------------------------------------------
Original readme:

# DS Gadget
A multi-purpose testing tool for Dark Souls: Prepare to Die Edition. Compatible with the current Steam and debug versions as well as, in theory, everything else.  
Requires [.NET 4.6.2](https://www.microsoft.com/net/download/thank-you/net462) and [VC Redist 2012 x86](https://www.microsoft.com/en-us/download/details.aspx?id=30679)  
You probably already have both.

# Instructions 
Extract the entire Gadget folder to wherever you want, and run DS Gadget.exe.  
Once the game is running, Gadget will automatically attach; if the Version is displayed in green everything should work correctly.  
If it's orange, your game version isn't fully supported and some things may not work. I recommend finding a newer one.  
All features are disabled until you load a character (indicated by the Loaded text).  
When you shut down Gadget, active modifications like cheats and filters will be reset.

If you get the following error when using certain features, uninstall and reinstall the VC Redist linked above:  
`System.IO.FileNotFoundException: Could not load file or assembly 'Fasm.NET.dll' or one of its dependencies.`

# Credits
[Fasm.NET](https://github.com/ZenLulz/Fasm.NET) by Jämes Ménétrey

[LowLevelHooking](https://github.com/jnm2/LowLevelHooking) by Joseph N. Musser II

[Octokit](https://github.com/octokit/octokit.net) by GitHub

[PropertyHook](https://github.com/JKAnderson/PropertyHook) by Me

[Semver](https://github.com/maxhauser/semver) by Max Hauser

# Special Thanks
**Wulf2k**, for writing Gizmo and memlocs.ods, without which I would be nothing.

**AndrovT**, for figuring out how the heck event flags work.

**Meowmaritus**, for MeowDSIO, which was used to build the item lists.

**Pav**, for spoonfeeding me so many function pointers.

And all of the other wonderful people in the SpeedSouls discord.

# Changelog
### 3.0
* AOB scanning instead of hardcoded offsets, aka support for unofficial versions
* Play region editable for PVPfriends
* Character name, sex, and physique editable for debug elitists
* Covenant stuff editable
* Hair slot directly editable
* Bonfire names are less obtuse
* Hotkeys don't lag typing as much

### 2.3
* Add create item hotkey
* Search for game by window title, not filename
* Allow stamina editing
* Fix gestures button
* Fix filters

### 2.2
* Added a button to warp to last bonfire (like a bone, but a button)
* Options will only be reapplied when they're not in the default state (so if you leave them off, they won't conflict with Debug)
* Item spawner improvements
	* Spawned items now go straight into your inventory
	* You can spawn upgraded pyromancy flames
	* You can no longer infuse shields and crossbows with infusions they can't be infused with
	* Removed some items that didn't actually exist

### 2.1
* Added a button to unlock all gestures to Misc tab
* Added a very awkwardly-placed button to reset your hair slot to Internals tab, because flexing permanently hecks it up
* Added stored quantity (for quantity storage ^:) to Internals tab
* Fixed (probably) problems with aiming bows while No Death was on
* Fixed some misconfigured items

### 2.0
* Gadget now supports the debug version
* Fixed window seemingly disappearing forever sometimes
* Editing your stats will now update health and stamina properly
* New tab: Internals, with readouts for some random technical things you don't care about
* Added basic event flag reading and writing to the Misc tab

### 1.6
* Added new hotkeys: Quit to Menu, Move Up, Move Down, Toggle No Death
* Option to store HP with position now includes stamina and death cam state
* Said option is now in the Players tab where it should have been anyways
* Closing the app should no longer require quitting and loading to completely clear modifications
* Fix no death and speed being overwritten in some cases (heck off Manus)
* Fix crash if not connected to internet

### 1.5
* Camera state is now stored along with position
* Fixed body type being overwritten

### 1.4
* HP can now be edited
* Added option to store and restore HP along with position (ur welcome Milt :V)
* Fixed missing bonfire ID for Seath's prison (again)

### 1.3
* Hotkeys can be globally enabled or disabled
* Hotkeys can be passed to the game as well or not
* Hotkeys can be unbound with escape
* Cheats have tooltips now
* Fixed filter turning on when you close the app

### 1.2
* Permanent changes are now cleaned up on app exit; quit out to clear the rest
* App indicates if there's an update available
* Window position is saved
* Settings actually work now
* Ambiguous items like Firekeeper Souls are no longer ambiguous

### 1.1
* Fixed maxing your stats against your will

### 1.0
* Reorganized and expanded cheats
* Added phantom and team type
* Added missing Painted World respawn
