using System;
namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Choose Your Own Adventure!");
            Print("Short Story!");
            Print("Original Story by Bryce Coffman");
            Print("2023");

            Print("You awaken in a darkened room.");
            Print("You look around and notice it is some kind of inn");
            Print("Suddenly!");
            Print("A grey bearded, average height man walks in through the door!");
            Print("He speaks with a strange, but familiar accent.");
            Print("Mysterious Man: Ahh, I see yous has awoken! I hope I did notst wake you.");
            Console.WriteLine("Yes or No");
            string resQ1a = Console.ReadLine();

            if (resQ1a == "Yes")
            {
                Print("Mysterious Man: Oh I am so's very sorry! I do promise to not disturb yous again! I am sorry, and please forgive me and my rudeness, but what is your name?");
            }
            else
            {
                Print("Mysterious Man: I am glad I didn't wakes yous.  Please, forgive me, but what is your name?");
            }

            string userName = Console.ReadLine();

            Print("Mysterious Man: So your name is " + userName);
            Print("Jacob: Well nice toos meets yous, my name is Jacob, and I am the inn keeper around heres.");
            Print("Jacob: I hope yous is feeling better " + userName);
            Print("Jacob: So what do yous do? What is yous profession? (Case Sensitive)");
            Console.WriteLine("Warrior");
            Console.WriteLine("Mage");
            Console.WriteLine("Rogue");
            string uClass = Console.ReadLine();
            //User will select from the classes listed.
            if (uClass == "Warrior")
            {
                Print("Jacob: Oh an ol' fasion warrior huh?  Well that is good. We can never have too many of yous around here. Not with what has been going on as of late.");
            }
            else if (uClass == "Mage")
                {
                Print("Jacob: Oh's you are a master of the mystic arts!? That is cool! Maybe you can be of some use to the townsfolks, we's always in need of strong magic users!");
            }
            else
            {
                Print("Jacob: Oh a rogue yous say!? I hope you prefer to operate inside the laws. /n Either way, I am sure someone with yous set of skills could be of use within the town.");
            }
            Print("Jacob: Well yous should probably make yous way to see the Commander of the camp. They are up to the north, just past the Church.");
            Print("Good luck and takes cares of yousself " + userName);

            //This is where the story will start to take off.
            Print("You get out of bed, and stretch.");
            Print("After stretching you, move slowly towards the door and make your way through the mostly dead inn.");
            Print("You see the door leading to the outside.");
            Print("You push the door open, and are presented with a blinding light. Though, it is night time out. The light isn't that of the sun's but of a giant fire in the distance");
            Print("You shield your eyes from the light briefly, but quickly become acclimated to the brightness.");
            Print("You look around to the left (South) and to the right (North)");
            Console.WriteLine("Which way do you go?");
            Console.WriteLine("North");
            Console.WriteLine("South");

            string dFInn = Console.ReadLine();
            if (dFInn == "North")
            {
                Print("You decide to heed Jacobs words and go north, and head towards the Commander of the camp.");
            }
            else
            {
                Print("You think about going south, but then you remember Jacob mentioning that the Commander of the camp is located to the north.  They could probably help you.");
            }

            Print("You walk up to the camp slowly and with caution.  You hear yelling in the distance with some Soldiers running by.");
            Print("You see a man dressed in heavy armor, shiny and battle worn at the same time.");
            Print("They are barking orders, and standing, towering over a table with a map sprawled out all over it.");
            Print("You approach the man, but before you can get a word out, they speak to you.");
            Print("Commander: Ahh you've awoken. About damn time.  You have been asleep for about a fortnite.");
            Print("Commander: Word spreads quickly around here " + userName);
            Print("Commander: I have taken the liberty to round up some basic armor and a weapon for you.");
            Print("You walk over and grab your gear.");
            //I am attempting to give gear to specific classes here.
            if (uClass == "Warrior")
            {
                Print("You acquire a worn long sword, a cracked wooden round shield, and a rusted knights garb.");
                Print("You stand there for a second and stare at the equipment and seriously dread having to put all this on.");
                Print("After about fourty-five minutes, you finally get all of the knights garb on.");
                Print("You stop and weeze a tiny bit.  You realize that you are seriously out of shape.");
                Print("You grab your sword and shield, and hobble over to the Commander to see if there is anything you can do to aid the camp.");
            }
            else if (uClass == "Mage")
            {
                Print("You acquire a Cloak of the Mage's Guild, a cracked wooden staff, and a mage's satchel.");
                Print("You quickly take your overcoat off, and throw the Cloak over your shoulders and fasten it tightly.");
                Print("Surprisingly light, the satchel, almost weightless.  It levitates its way over your head and onto your shoulder");
                Print("You reach for the staff with your right hand, this staff was nothing special, but suddenly a surge of power pulses between you and the staff.");
                Print("Lightning pours from your fingers, into the staff.  You pick up the staff and everything  becomes quiet.");
                Print("Feeling powerful and satisfied, you turn back around and head back to the Commander to see if there is anything you can do.");
            }
            else
            {
                Print("You acquire a wooden short bow, a worn quiver, and a leather jerkin");
                Print("You attach your quiver to your hip, and slide the jerkin over your shoulders. Noticing that it's a loose fit, maybe being unconcious for a those days helped you lose some weight.");
                Print("Finally you grip onto the bow, and lightly grab the draw string to test the weight. The bow is surprisingly light, but sturdy.");
                Print("Satisfied, you move back to the Commander to see if there is anything you can do to help.");

            }

            Print("Commander: Look at you, you look poised and ready for battle.  Don't get too hasty though, let us start small.  I don't want to thrust you straight into battle.");
            Print("Commander: What if you aren't fully back to health? It is just better that we go easy.");
            Print("Commander: Firstly, do you remember anything? Do you know what is going on here?");
            Console.WriteLine("Yes or No?");
            string resQ2a = Console.ReadLine();
          
            if (resQ2a == "Yes")
            {
                Print("Commander: Oh? Well good, that saves me the trouble of having to go over things with you.");
                Print("Commander: There are reports of a bandit roaming the streets at night, and taking the townspeople's crap.");
                Print("Commander: I am going to be honest, I don't have time for this, and you seem like a perfect candidate to handle such a meanial task.");
                Print("Commander: Take care of this and we will talk about something more difficult.");
            }
            else
            {
                Print("I figured as much, do you want the long or short explanation?");
                Console.WriteLine("Long or Short?");
                string resQ3a = Console.ReadLine();
                if (resQ3a == "Long")
                {
                    Print("Commander: Really? Oh alright. Twenty-five years ago the Emmond Empire and the Varrick Empire were at war.");
                    Print("Commander: We we are right on the edge of the two kingdoms.");
                    Print("Commander: This made our town, a prime location to hold.");
                    Print("Commander: This obviously led to tons of bloodshed, most of our townsfolk were either killed, recruited, or forced to work for either side.");
                    Print("Commander: We were trapped, no where to run.");
                    Print("Commander: We just kept our heads down, we did what we needed to, just to survive.");
                    Print("Commander: Eventually, the war would die down.  The Emmond Empire would go on to win by some less than flavorful methods.");
                    Print("Commander: With the Varrick's out of the way, Emmond was able to unleash his wrath upon the land.");
                    Print("Commander: This resulted in an all out war, not just against the Varrick Military, but the citizens as well.");
                    Print("Commander: They took up arms, and have been waging a personal war against Emperor Emmond for the last twelve years.");
                    Print("Commander: Though, we don't really have a side, we are often forced to get involved in this war.");
                    Print("Commander: I have lost a lot of good men because of this war, hopefully it ends sometime soon.");
                    Print("Commander: But let us get down to business.  I am strapped and you are almost useless.  I need you to investigate a string of roberies in the town");
                    Print("Commander: If you can successfully do this, I might give you a more difficult task.");

                }
                else
                {
                    Print("Commander: There was a war between two empires.  We just so happened to be in a very strategic spot.");
                    Print("Commander: After the war ended, the citizens of the fallen empire took up arms against the victor.");
                    Print("Commander: We have lost a lot of good men because of this war. I hope it ends soon.");
                    Print("Commander: But let us get down to business.  I am strapped and you are almost useless.  I need you to investigate a string of roberies in the town");
                    Print("Commander: If you can successfully do this, I might give you a more difficult task.");
                }

            }
            Print("Do you have any questions?");
            Console.WriteLine("Yes or No");
            string resQ4a = Console.ReadLine();
            if (resQ4a == "Yes")
            {
                Print("Commander:(Sighs) What, what is your question?");
                Console.WriteLine("Please type the number to make a selection:");
                Console.WriteLine("1. What do you need me to do again?");
                Console.WriteLine("2. Could you tell me about the history, I wasn't paying attention the first time.");
                Console.WriteLine("3. Nevermind");
                int resQ4aa = Convert.ToInt32(Console.ReadLine());
                if (resQ4aa == 1)
                {
                    Print("Commander: Oh, you are useless. Okay.");
                    Print("Commander: Investigate robberies in the town.  That's it, that is all.");
                }
                else if (resQ4aa == 2)
                {
                    Print("Commander: There was a war between two empires.  We just so happened to be in a very strategic spot.");
                    Print("Commander: After the war ended, the citizens of the fallen empire took up arms against the victor.");
                    Print("Commander: We have lost a lot of good men because of this war. I hope it ends soon.");
                }
                else
                {
                    Print("Get out of my face.");
                }


            }
            else
            {
                Print("Good, be on your way! Bring be good news and I will have good news for you.");
            }

            Print("You turn around and exit out the tent.");
            Print("You take a look around, it's dark out, and it's the perfect time for a theif to be out and about.");
            Print("You make your way for the town center, when all of a SUDDEN!");
            Print("BAM!");
            Print("A stray arrow flies through the arrow and strikes you right in the chest.");
            Print("You collapse to the ground. Trying to scream, but you can't.");
            Print("The light fades, and everything goes black.");



        }

        public static void Print(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
        

    }

}