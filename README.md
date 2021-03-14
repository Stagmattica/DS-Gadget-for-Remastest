## This version of DS Gadget has been created for InfernoPlus' "Remastest" mod and contains various changes to item lists. 
## Based on DS-Gadget 3.0 by JKAnderson.

### **Download the latest Release here:** https://github.com/Stagmattica/DS-Gadget-for-Remastest/releases

# Changelog (Prerelease 0.5):
* **Disabled** the version indicator turning orange to avoid confusion.

# Changelog (Prerelease 0.4):
* Various bug fixes
* **Removed** the _Master Key_ Key item, due to it having lost its purpose.
* **Moved** _Eye of Death_ and _Cracked Red Eye Orb_ consumables to _Usable Items_ tab for consistency.
* **Renamed** the _Cat Covenant Ring_ to _Bandit Ring_.

# Changelog (Prerelease 0.3):
* Bug fixes
* Some changes from _Prerelease 1.1_ did not function properly: **Rename** of _Black Eye Orb(s)_ did not function properly due to character limit, name shortened; **Fix** of _Skull Lantern bug_ not working due to restrictions within item category definitions. _Skull Lantern_ has been **moved** to _Melee Weapons_ item category.


# Changelog (Prerelease 0.2):
* **Fixed** title bar version counter
* **Fixed** a target mismatch between the Bonfires _Ash Lake (Bonfire)_ and _Ash Lake (Stone Dragon)_
* **Fixed** a bug that caused the _Skull Lantern_ item to not spawn for some players
* **Renamed** the unused _Gwynevere Talisman_ and _Miracle: Escape Death_ descriptors
* **Renamed** _Black Eye Orb_ to _Black Eye Orb (Target: Lautrec of Carim)_ and _Black Eye Orb (Shiva)_ to _Black Eye Orb (Target: Shiva of the East) (Cut Content)_
* **Renamed** _Sunlight Spear_ spell to _Sunlight Slam_
* **Moved** _Black Eye Orb (Target: Shiva of the East) (Cut Content)_ from _Key Items_ to _Usable Items_


# Changelog (Prerelease 0.1):
* **Removed** version indicator on main window title bar (will be added back in future releases)
* **Removed** _Mystery Armor_, _Mystery Weapons_ and Mystery Goods_ item lists
* **Moved** _Elite Cleric_ and _Mage Smith_ Armor sets to _Armor_ item list
* **Moved** all _Estus Flask_ entries to _Consumables_ item list, **removed** _Empty Estus Flask_ entries
* **Moved** _Black Eye Orb (Shiva)_ cut content item to _Key Items_ item list (functionality missing)
* **Moved** _Escape Death_ cut content spell to _Spells_ item list (works, has identical function to Rare Ring of Sactifice, uses _Magic Revival_ death message instead of _Ring Revival_)
* **Moved** _Gwynevere's Talisman_ cut content spell tool to _Spell Tools_ item list (does not work properly, usage in Arena+ strongly discouraged)
* **Moved** _Skull Lantern_ from _Spell Tools_ to _Usable Items_ item list due to its placement in _Spell Tools_ item list having caused confusion
* **Renamed** the following Magic-based Spells (located under _Spells_ item list): _Soul Arrow_ spell to _Soul Ray_, _Great Soul Arrow_ to _Soul Arrow_, _Heavy Soul Arrow_ to _Heavy Soul Ray_, _Great Heavy Soul Arrow_ to _Heavy Soul Arrow_, _Homing Crystal Soulmass_ to _Crystal Mass_, 
_Crystal Soul Spear_ to _Crystal Storm_, _Magic Weapon_ to _Soul Weapon_, _Great Magic Weapon_ to _Soul Dart_, _Crystal Magic Weapon_ to _Crystalize Weapon_, _Magic Shield_ to _Soul Shield_, _Strong Magic Shield_ to _Deflection_, _Cast Light_ to _Light_, _Hush_ to _Conversion_, _Aural Decoy_ to _Distract_, 
_Fall Control_ to _Soul Roots_, _Resist Curse_ to _Break Curse_ and _White Dragon Breath_ to _Crystal Ray_
* **Renamed** the following Pyromancies (located under Spells item list): _Fire Orb_ to _Eruption_ and _Firestorm_ to _Warmth_
* **Renamed** the following Miracles (located under Spells_ item list): _Gravelord Sword Dance_ to _Gravelord Sword Strike_, _Gravelord Greatsword Dance_ to _Gravelord Sword Strike_, _Seek Guidance_ to _Sacred Oath_, _Great Lightning Spear_ to _Lightning Storm_ and _Karmic Justice_ to _Karmic Balance_
* **Added** _Bear_ cut content Armor set to _Armor_ item list
* **Added** the Pyromancies _Flame Swathe_ (ID: 4120) and _Black Fissure_ (ID: 4560) to _Spells_ item list
* **Added** the Miracles _Intervention_ (ID: 5315) and _Projected Heal_ (ID: 5330) to _Spells_ item list
* **Added** the Spell IDs 5920, 5930, 5940 and 5959 to _Spells_ item list (as requested by InfernoPLus; these are IDs for potential future spells. Judging by the ID prefix "5", these will most likely be populated by Miracles, if at all)

--------------------------------------------------------------------------------------------------------------------------------------
### Original readme:

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
