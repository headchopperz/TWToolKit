<?php

$arr = array(
    array(
        "ID" => 0,
        "Name" => "Improving your infrastructure",
        "Dsc" => "It appears you are using an older version of Internet Explorer. Your villagers would greatly appreciate it if you could upgrade your browser or switch to a different one. ",
        "Sections" => array(
            array(
                "Title" => "Upgrade or change your browser ",
                "Desc" => "Upgrade or change your internet browser for a better Tribal Wars experience. For an overview of the latest browsers, click here.",
            )
        ),
        "Reward" => null,
        "Required" => null,
        "WorldType" => "All"
    ),
    array(
        "ID" => 1,
        "Name" => "Welcome!",
        "Dsc" => "Welcome to the Quest System. Follow its instructions to learn about game functionality, fighting and expanding. For now, your first task is to select and view your Headquarters.",
        "Sections" => array(
            array(
                "Title" => "Go to the Headquarters.",
                "Desc" => "Open the Headquarters by selecting it from the village.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 50
        ),
        "Required" => null,
        "WorldType" => "All"
    ),
    array(
        "ID" => 2,
        "Name" => "Improving production",
        "Dsc" => "Every kingdom needs a healthy economy. To ensure that your village will grow and thrive, you should begin building the foundations of one as soon as possible. Construct a Timber Camp and Clay Pit.",
        "Sections" => array(
            array(
                "Title" => "Build your Timber Camp",
                "Desc" => "Build your Timber Camp by issuing a \"Construct\" order in the Headquarters.",
            ),
            array(
                "Title" => "Build your Clay Pit",
                "Desc" => "Expand your Clay Pit by one level.",
            )
        ),
        "Reward" => array(
            "Wood" => 100,
            "Clay" => 100,
            "Iron" => 120
        ),
        "Required" => array(
            1
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 3,
        "Name" => "A worthy name",
        "Dsc" => "It is time to give your village a bit more of individuality. Even though you could consider it an honor that the village is currently named after you, you should now give it a new name that your enemies will soon learn to fear!",
        "Sections" => array(
            array(
                "Title" => "Change the name of your village",
                "Desc" => "Change the name of your village at the bottom of the Headquarters screen.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 70
        ),
        "Required" => array(
            1
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 4,
        "Name" => "Looks matter",
        "Dsc" => "Your player profile is the image you project to other players. A nicely filled-out profile can be a great advantage when you are working on your network of contacts in the world of Tribal Wars.",
        "Sections" => array(
            array(
                "Title" => "Change your profile text",
                "Desc" => "Access and change your profile from the Profile option in the main menu.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 50
        ),
        "Required" => array(
            3
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 5,
        "Name" => "Making contacts",
        "Dsc" => "The map is home to not only Barbarian villages, but also the villages of other players. It is wise to maintain friendly neighborly relations so that you are in a better position to judge the actions of your competitors and possible allies.",
        "Sections" => array(
            array(
                "Title" => "Making contacts",
                "Desc" => "Find another player on the Map and write them a message.",
            )
        ),
        "Reward" => array(
            "Wood" => 100,
            "Clay" => 100,
            "Iron" => 50
        ),
        "Required" => array(
            3
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 6,
        "Name" => "A worthy monument",
        "Dsc" => "To recruit one of the most powerful units in the game, we're going to need a Statue. It will allow us to recruit a Paladin.",
        "Sections" => array(
            array(
                "Title" => "Construct a Statue",
                "Desc" => "Construct a Statue in the Headquarters to be able to appoint a Paladin",
            )
        ),
        "Reward" => array(
            "Wood" => 220,
            "Clay" => 220,
            "Iron" => 220
        ),
        "Required" => array(
            2
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 7,
        "Name" => "The strongest warrior",
        "Dsc" => "The Paladin is an especially strong unit and can improve the performance of any army he is sent along with when he is equipped with special Paladin Items. You can only have one Paladin at a time.",
        "Sections" => array(
            array(
                "Title" => "Appoint a Paladin",
                "Desc" => "Use your Statue to appoint a Paladin.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 50
        ),
        "Required" => array(
            6
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 8,
        "Name" => "Military infrastructure",
        "Dsc" => "To thrive in the long-term, we're going to need troops to both defend against our enemies and supplement the production of our mines with loot from other villages. Before we can start troop recruitment though, we're going to need a Barracks.",
        "Sections" => array(
            array(
                "Title" => "Build your Headquarters",
                "Desc" => "Expand your Headquarters to level 3 to meet the requirements to construct a Barracks.",
            ),
            array(
                "Title" => "Construct a Barracks",
                "Desc" => "Construct a Barracks so that we can recruit troops. Your Headquarters will first need to be level 3.",
            )
        ),
        "Reward" => array(
            "Spear" => 10,
            "Sword" => 10,
            "Def Str" => "2%"
        ),
        "Required" => array(
            2
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 9,
        "Name" => "Ensuring production",
        "Dsc" => "We've laid the foundation for a solid economy but we're going to need to keep expanding. To have enough resources to get us started on a small army, we should expand our resource production buildings.",
        "Sections" => array(
            array(
                "Title" => "Build your Timber Camp",
                "Desc" => "Expand your Timber Camp to level 4.",
            ),
            array(
                "Title" => "Build your Clay Pit",
                "Desc" => "Expand your Clay Pit to level 3.",
            ),
            array(
                "Title" => "Build your Iron Mine",
                "Desc" => "Construct your first Iron Mine.",
            )
        ),
        "Reward" => array(
            "Wood" => 200,
            "Clay" => 200,
            "Iron" => 200
        ),
        "Required" => array(
            2
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 9,
        "Name" => "Making friends",
        "Dsc" => "One snowflake is weak, and yet an avalanche can destroy entire forests. If we are going to extend our influence, we're going to need a bit of help. Look around on the map to see what kind of tribes you have in your area and join the one you like best.",
        "Sections" => array(
            array(
                "Title" => "Join a tribe",
                "Desc" => "Become a member of a promising tribe in your area.",
            )
        ),
        "Reward" => array(
            "Wood" => 100,
            "Clay" => 100,
            "Iron" => 100
        ),
        "Required" => array(
            5
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 10,
        "Name" => "Fighting alone is hard",
        "Dsc" => "Your village will soon need to defend against other players. It would be wise to gather friends to aid you in battle.",
        "Sections" => array(
            array(
                "Title" => "Invite a friend via email",
                "Desc" => "Click on \"Invite Players\" in the bottom menu to access the invitations screen. You can have them join near your village!",
            )
        ),
        "Reward" => array(
            "Wood" => 150,
            "Clay" => 150,
            "Iron" => 150
        ),
        "Required" => array(
            5
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 11,
        "Name" => "The burden of leadership",
        "Dsc" => "The first step on the path to fame has been made - you are now the duke of a tribe. You as leader of your tribe are not only responsible for how things go internally, but also for the image you present to outsiders.",
        "Sections" => array(
            array(
                "Title" => "Change the Description of your Tribe",
                "Desc" => "Change the Description of your Tribe in the tribe's Properties screen.",
            )
        ),
        "Reward" => null,
        "Required" => array(
            9
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 12,
        "Name" => "Welcome",
        "Dsc" => "Your tribe members will look up to you as the Duke, and it is your responsibility to lead them well. When a player first joins a tribe, they will be sent a mail with the tribe's Welcome Message, which should include important information about how the tribe will be run and what you intend to achieve.",
        "Sections" => array(
            array(
                "Title" => "Change Welcome message",
                "Desc" => "Create a Welcome message for new tribe members.",
            )
        ),
        "Reward" => null,
        "Required" => array(
            11
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 13,
        "Name" => "Strengthening the lines",
        "Dsc" => "Tribes need active and enthusiastic tribe members to get them ahead of enemies and competitors. It's up to you to find worthy candidates to fill your ranks.",
        "Sections" => array(
            array(
                "Title" => "Invite players to the tribe",
                "Desc" => "Invite local and active players to your tribe.",
            )
        ),
        "Reward" => null,
        "Required" => array(
            12
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 14,
        "Name" => "Community service",
        "Dsc" => "The tribal forum is a place where you can comment on and influence tribal developments, wars and diplomacy.",
        "Sections" => array(
            array(
                "Title" => "Go to your Tribal Forum",
                "Desc" => "Have a look at your tribe's forum - it can be found in the Tribe pages.",
            )
        ),
        "Reward" => null,
        "Required" => array(
            9
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 15,
        "Name" => "Mobilisation",
        "Dsc" => "Now that we have finished the necessary preparation we can get started on one of the most important tasks of a ruler: raising an army. Troops are very important because it is only with their help that you can loot resources from surrounding villages and defend your own walls against would-be enemies. ",
        "Sections" => array(
            array(
                "Title" => "Recruit Spear fighters",
                "Desc" => "Recruit Spear fighters in the Barracks. 20 total would be a good first step.",
            )
        ),
        "Reward" => array(
            "Spear" => 10,
            "Axe" => 10
        ),
        "Required" => array(
            8
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 16,
        "Name" => "More capacity",
        "Dsc" => "Our production is now running smoothly. To ensure that we can keep up with the increased amount of resources flowing in, we should increase the amount of storage space by expanding our warehouse.",
        "Sections" => array(
            array(
                "Title" => "Build your Warehouse",
                "Desc" => "Expand your Warehouse to level 3",
            )
        ),
        "Reward" => array(
            "Wood" => 500,
            "Clay" => 300,
            "Iron" => 200
        ),
        "Required" => array(
            9
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 17,
        "Name" => "Outfitting the armory",
        "Dsc" => "Your Paladin is a tough one, but he can be so much more when properly equipped. Your chance to find a Paladin item goes up by a few percentage points per day, and you can increase your chances by defeating enemy units. ",
        "Sections" => array(
            array(
                "Title" => "Find a weapon for your paladin",
                "Desc" => "Find a weapon for your paladin and equip it.",
            )
        ),
        "Reward" => array(
            "Wood" => 200,
            "Clay" => 200,
            "Iron" => 200
        ),
        "Required" => array(
            7
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 18,
        "Name" => "Alternative income",
        "Dsc" => "Unfortunately, our mines can only produce a limited number of resources per hour. Success in the long-term will likely be dictated by how much we can gain from external sources. Now that we have troops at our disposal, we could get started on milking the most lucrative external source available - other villages. ",
        "Sections" => array(
            array(
                "Title" => "Attack another village",
                "Desc" => "Use your troops to attack a Barbarian (shown in gray on the map) village on the map. Make sure to send as many troops as possible to minimize possible losses.",
            ),
            array(
                "Title" => "Loot resources",
                "Desc" => "Wait for your troops to arrive and plunder your resources!",
            )
        ),
        "Reward" => array(
            "Special" => "You can use the Farm Assistant feature free of charge for 10 days."
        ),
        "Required" => array(
            15
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 19,
        "Name" => "Knowledge is power",
        "Dsc" => "To be able to survive in a harsh world, we will need to expand our knowledge. Build a smithy so that you can research new types of units. ",
        "Sections" => array(
            array(
                "Title" => "Build your Headquarters",
                "Desc" => "Expand your Headquarters to level 5 to meet the requirements to construct a Smithy.",
            ),
            array(
                "Title" => "Construct a Smithy",
                "Desc" => "Construct your first Smithy in the Headquarters to be able to research units. You will need your Headquarters to be on level 5.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 50
        ),
        "Required" => array(
            15
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 20,
        "Name" => "Strengthening the economy",
        "Dsc" => "We could invest a bit in our mine production. Even though the plundering of neighboring villages is a profitable form of income, we shouldn't neglect our local economy in case our looting parties come back empty-handed. Remember to always keep an eye on your mines. ",
        "Sections" => array(
            array(
                "Title" => "Expand your Timber Camp",
                "Desc" => "Expand your Timber Camp to level 9.",
            ),
            array(
                "Title" => "Expand your Clay Pit ",
                "Desc" => "Expand your Clay Pit to level 8.",
            ),
            array(
                "Title" => "Expand the Iron Mine",
                "Desc" => "Expand your Iron Mine to level 6.",
            )
        ),
        "Reward" => array(
            "Wood" => 300,
            "Clay" => 300,
            "Iron" => 200
        ),
        "Required" => array(
            16
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 20,
        "Name" => "Flying the colours",
        "Dsc" => "The flag you received as a reward for completing the previous quest can be assigned to your village to provide it with a certain bonuses.",
        "Sections" => array(
            array(
                "Title" => "Assign a flag to your village",
                "Desc" => "Access the flag screen from your village overview to assign a flag.",
            )
        ),
        "Reward" => array(
            "Special" => "Level 1 flag"
        ),
        "Required" => array(
            8
        ),
        "WorldType" => "Flag"
    ),
    array(
        "ID" => 21,
        "Name" => "Securing the borders",
        "Dsc" => "We're going to need a wall to help keep potential enemies away. It doesn't quite replace troops in terms of raw defense power, but it certainly gives them a significant advantage when they're fighting to defend their homes.",
        "Sections" => array(
            array(
                "Title" => "Construct a Wall.",
                "Desc" => "Construct a wall in the Headquarters.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 100,
            "Iron" => 50
        ),
        "Required" => array(
            8
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 22,
        "Name" => "Judging the situation",
        "Dsc" => "Reports informing you of the results of fights are generated whenever and wherever your troops are involved in battle. These reports contain vital intelligence such as the strength of your enemy's army that can help you decide about how to fight future battles. ",
        "Sections" => array(
            array(
                "Title" => "Read a Report",
                "Desc" => "Read one of your battle reports.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 50
        ),
        "Required" => array(
            18
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 23,
        "Name" => "Conducting trade",
        "Dsc" => "Besides the resources gained from local production and what we can loot from other villages, resources can also be gained through peaceful trade with other players. To allow us to do this, construct a Market. ",
        "Sections" => array(
            array(
                "Title" => "Construct a Market",
                "Desc" => "Construct your first Market in the Headquarters.",
            )
        ),
        "Reward" => array(
            "Wood" => 100,
            "Clay" => 100,
            "Iron" => 100
        ),
        "Required" => array(
            19
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 24,
        "Name" => "City Guard",
        "Dsc" => "Units can be divided up into offensive and defensive troops. So far, you've got Spear fighters for cavalry defense, Swordsmen for infantry defense and Axemen for offense. ",
        "Sections" => array(
            array(
                "Title" => "Recruit Swordsmen",
                "Desc" => "To be able to defend yourself more effectively against infantry, you should recruit Swordsmen until you have 20 total.",
            )
        ),
        "Reward" => array(
            "Sword" => 10
        ),
        "Required" => array(
            19
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 25,
        "Name" => "The cavalry is coming",
        "Dsc" => "Feet aren't our troops' only method of transportation. Cavalry units can also be recruited. Construct a stable so that we can get our hands on some horses. ",
        "Sections" => array(
            array(
                "Title" => "Construct a Stable",
                "Desc" => "Construct a Stable to allow us to recruit cavalry. You will need a level 10 Headquarters, level 5 Barracks and a level 5 Smithy.",
            )
        ),
        "Reward" => array(
            "Wood" => 300,
            "Clay" => 300,
            "Iron" => 300
        ),
        "Required" => array(
            19
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 26,
        "Name" => "Deciding factors",
        "Dsc" => "You might have noticed while reading a report that there are several factors that can influence the results of battles. These include the randomly chosen Luck value as well as Morale, which is based on a calculation which makes use of the point difference between you and your opponent. ",
        "Sections" => array(
            array(
                "Title" => "Simulator",
                "Desc" => "Test the Simulator to become familiar with how Luck or Morale can influence success. You can find it in your Rally Point building.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 50,
            "Special" => "Level 1 flag"
        ),
        "Required" => array(
            22
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 27,
        "Name" => "Looting made easy",
        "Dsc" => "The Farm Assistant is a Premium Feature that makes farming/plundering significantly easier. Try it out by creating and using a template to attack a barbarian village. ",
        "Sections" => array(
            array(
                "Title" => "Easy farming",
                "Desc" => "Create a Template in the Farm Assistant and use it to attack a Barbarian village.",
            )
        ),
        "Reward" => null,
        "Required" => array(
            18
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 28,
        "Name" => "Burning and looting",
        "Dsc" => "To supplement your own production, you should fill your warehouse with the resources produced by other villages by attacking and looting them. In total, you should try to plunder 10 villages as soon as possible. ",
        "Sections" => array(
            array(
                "Title" => "Achieve the following achievement: Plunderer ",
                "Desc" => "To achieve the achievement: Plunder other villages 10 times!",
            )
        ),
        "Reward" => null,
        "Required" => array(
            27
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 29,
        "Name" => "Wheat from the chaff",
        "Dsc" => "You'll always need to keep an eye on your warehouse capacity - there's little point in allowing production to grind to halt. If you notice that your storage capacity of a certain resource is almost full, you could put it up for trade in the Market in an attempt to exchange it for a resource you need more of. ",
        "Sections" => array(
            array(
                "Title" => "Create offer",
                "Desc" => "Create a resource trade Offer in the Market.",
            )
        ),
        "Reward" => null,
        "Required" => array(
            23
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 30,
        "Name" => "Evacuation",
        "Dsc" => "You will often need to react quickly when you get attacked. If the strength of an incoming army is unknown, it can often be a good strategy to spend the resources you have in the village and evacuate your troops to save them for another day. This way, the attacker will have not gained anything, and there will be little reason to attack you again in the future. ",
        "Sections" => array(
            array(
                "Title" => "Support another village",
                "Desc" => "Send your troops to safety by sending them as Support to a foreign village. They will be defensively stationed there until you call them back from your Rally Point.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 50
        ),
        "Required" => array(
            24
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 31,
        "Name" => "To arms",
        "Dsc" => "You can rely on your local population to aid the defense of their homes when your village gets attacked. To call them to arms, you would need to go to your Farm and Summon the Militia. Calling your population away from their tasks will unfortunately negatively affect your resource production rate for a while. ",
        "Sections" => array(
            array(
                "Title" => "Militia",
                "Desc" => "Go to your Farm building to find out how the Militia works.",
            )
        ),
        "Reward" => array(
            "Wood" => 50,
            "Clay" => 50,
            "Iron" => 50
        ),
        "Required" => array(
            30
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 32,
        "Name" => "A safe haven",
        "Dsc" => "We should expand your Hiding Place to prevent your enemies from looting your hard-earned resources. ",
        "Sections" => array(
            array(
                "Title" => "Expand your Hiding Place.",
                "Desc" => "Expand your Hiding Place to level 2.",
            )
        ),
        "Reward" => array(
            "Wood" => 70,
            "Clay" => 80,
            "Iron" => 70
        ),
        "Required" => array(
            30
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 33,
        "Name" => "The thirst for knowledge",
        "Dsc" => "We are finally at a point where we can conduct our first research into additional types of troops. We should never go into battle without a sufficient amount of information about our enemy's capabilities, so it would be wise to now research Scouts in your smithy. ",
        "Sections" => array(
            array(
                "Title" => "Research",
                "Desc" => "Research Scout in the Smithy.",
            )
        ),
        "Reward" => array(
            "Scouts" => 10
        ),
        "Required" => array(
            25
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 34,
        "Name" => "Homeland Security",
        "Dsc" => "The wall is one of your strongest defensive assets, and requires regular maintenance. ",
        "Sections" => array(
            array(
                "Title" => "Raise the level of your wall",
                "Desc" => "Expand your wall to level 8.",
            )
        ),
        "Reward" => array(
            "Wood" => 300,
            "Clay" => 300,
            "Iron" => 300
        ),
        "Required" => array(
            25
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 35,
        "Name" => "War games",
        "Dsc" => "Intelligence about the location and disposition of the enemy forces is of vital importance when conducting any campaign. Scouts will avoid battle with regular units, and report back their findings about the state of the village they scouted. Only other scouts can stop them! ",
        "Sections" => array(
            array(
                "Title" => "Scout a barbarian village",
                "Desc" => "Attack a nearby barbarian village with only your scout units.",
            )
        ),
        "Reward" => array(
            "Wood" => 100,
            "Clay" => 100,
            "Iron" => 100
        ),
        "Required" => array(
            33
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 36,
        "Name" => "Cavalry",
        "Dsc" => "It pays off to make the effort of always including a few Scouts in any looting runs you send to increase the efficiency of any future raids you make on that village with the information they retrieve for you. Another way to increase the efficiency of your farming attacks is to send faster units that can carry more. ",
        "Sections" => array(
            array(
                "Title" => "Recruit",
                "Desc" => "Research and recruit at least one Light Cavalry unit. You will need a level 3 Stable.",
            )
        ),
        "Reward" => array(
            "LC" => 4
        ),
        "Required" => array(
            33
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 37,
        "Name" => "Conquer new land",
        "Dsc" => "We're going to need an academy to be able to increase our area of influence. As this is a long term task you will still need to keep building your army and expanding your resource income.  ",
        "Sections" => array(
            array(
                "Title" => "Expand your Headquarters",
                "Desc" => "Your Headquarters will need to be level 20. It would be wise to start with this requirement because higher Headquarters levels will increase the building speed of the others.",
            ), 
            array(
                "Title" => "Expand your Smithy",
                "Desc" => "Expand your Smithy to level 20.",
            ),
            array(
                "Title" => "Expand your Market",
                "Desc" => "Expand your Market to level 10.",
            )
        ),
        "Reward" => null,
        "Required" => array(
            36
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 38,
        "Name" => "The Engine",
        "Dsc" => "The engine of your economy is rumbling onwards and upwards. Be sure to not let it come to a halt! ",
        "Sections" => array(
            array(
                "Title" => "Build your Timber Camp",
                "Desc" => "Expand your Timber Camp to level 15.",
            ), 
            array(
                "Title" => "Build your Clay Pit",
                "Desc" => "Expand your Clay Pit to level 15.",
            ),
            array(
                "Title" => "Build your Iron Mine",
                "Desc" => "Expand your Iron Mine to level 15.",
            )
        ),
        "Reward" => array(
            "Wood" => 5000,
            "Clay" => 5000,
            "Iron" => 5000
        ),
        "Required" => array(
            36
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 39,
        "Name" => "Loyal Followers",
        "Dsc" => "A standing army is a necessity for a growing village - be it for defending or attacking.",
        "Sections" => array(
            array(
                "Title" => "Recruit additional troops",
                "Desc" => "Recruit additional troops until you have an army built from at least 2000 population.",
            )
        ),
        "Reward" => array(
            "Wood" => 5000,
            "Clay" => 5000,
            "Iron" => 5000
        ),
        "Required" => array(
            36
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 40,
        "Name" => "Boom times ahead",
        "Dsc" => "The final push to maximise your local resource production.",
        "Sections" => array(
            array(
                "Title" => "Build your Timber Camp",
                "Desc" => "Expand your Timber Camp to level 30.",
            ), 
            array(
                "Title" => "Build your Clay Pit",
                "Desc" => "Expand your Clay Pit to level 30.",
            ),
            array(
                "Title" => "Build your Iron Mine ",
                "Desc" => "Expand your Iron Mine to level 30.",
            )
        ),
        "Reward" => array(
            "Wood" => 20000,
            "Clay" => 20000,
            "Iron" => 20000
        ),
        "Required" => array(
            37
        ),
        "WorldType" => "All"
    ),
    array(
        "ID" => 41,
        "Name" => "Conquering a village",
        "Dsc" => "We've fulfilled the requirements for the Academy and can now educate a Nobleman. Send your Nobleman along with attacking troops to a foreign village to lower that village's Loyalty. When the Loyalty reaches 0 or lower, the village will be yours. ",
        "Sections" => array(
            array(
                "Title" => "Construct an Academy",
                "Desc" => "Construct an Academy so that we can educate a Nobleman.",
            ), 
            array(
                "Title" => "Conquer a village",
                "Desc" => "Send your Nobleman along with your troops to conquer a foreign village.",
            )
        ),
        "Reward" => null,
        "Required" => array(
            37
        ),
        "WorldType" => "All"
    ),
);

echo json_encode($arr);
?>