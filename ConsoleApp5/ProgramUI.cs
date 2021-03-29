﻿using Cafe_Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ProgramUI
    {
        private Menu_Repository _menuRepo = new Menu_Repository();
        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("What do you want to do:\n" +
                    "1: Add item\n" +
                    "2: Delete item\n" +
                    "3: See menu\n" +
                    "4: Exit\n" +
                    "5: Dont Press");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        AddToList();
                        break;
                    case "2":
                        DeleteFromList();
                        break;
                    case "3":
                        PrintMenu();
                        break;
                    case "4":
                        keepRunning = false;
                        break;
                    case "5":
                        Console.WriteLine("WHY DID YOU PRESS FIVE WHAT WAS THE POINT??? YOU WERe ASKED NOT TO PRESS FIVE!!!! SO WHY DID YOU PRESS FIVE??? DONT DO THAT AGAIN GEEZEHabitasse nisl maecenas ante nam penatibus nullam sed taciti hymenaeos erat per sit ullamcorper vulputate mollis.Rhoncus, senectus quam eleifend interdum phasellus ullamcorper sem aliquet sollicitudin suscipit.Vulputate, elementum in nisi quisque tristique magna metus nam orci curabitur A litora habitasse.Nascetur molestie accumsan bibendum magna commodo laoreet conubia primis magnis arcu dictumst ad donec diam auctor curae; nibh augue. Auctor potenti urna ac nostra.Per hendrerit enim lacinia. Dictumst quisque ridiculus dapibus. Vehicula tempor. Dictumst primis, accumsan donec.Dis enim risus commodo. Venenatis a ullamcorper aptent rutrum fringilla dictum.Placerat per Torquent fames fusce class ridiculus enim nec volutpat tortor ultricies semper hac lorem platea nostra velit leo lacinia fusce ac torquent primis posuere tortor conubia placerat convallis nascetur habitasse aliquam.Cras diam egestas semper torquent, amet blandit praesent hymenaeos sapien accumsan eget orci scelerisque imperdiet habitasse sollicitudin et taciti habitasse.Tempus lacinia condimentum blandit vulputate ad habitasse, nulla orci duis tincidunt dui.Arcu suscipit libero ante mauris facilisi lorem tortor mus.Porttitor purus dis nascetur condimentum nec morbi nascetur class vulputate. Eleifend.Elit eleifend aliquet consectetuer ligula ullamcorper tristique.Ac erat rutrum amet venenatis nulla.Mi, elit fermentum purus Suscipit penatibus habitasse luctus vivamus potenti.Proin sit sem nonummy suscipit nonummy dolor dignissim tincidunt quisque imperdiet adipiscing sodales non lorem convallis auctor ultrices nullam vitae lectus duis nascetur habitant inceptos.Adipiscing nulla sagittis litora nonummy Consequat parturient.Varius habitasse vitae ultricies platea sed mus Nibh urna cum commodo nec placerat, per duis Placerat lorem per ullamcorper parturient pede parturient hac. Dapibus curabitur scelerisque ante elementum tellus mattis dapibus lacinia pellentesque rhoncus facilisis nibh litora metus, eu.Quis ante dui consequat consequat tempus varius dignissim leo odio, dis.Gravida dignissim rutrum nisi imperdiet adipiscing pharetra imperdiet fermentum, hymenaeos lacus laoreet ultrices cursus sociis venenatis.Aliquam dictum luctus fusce. Facilisi.Nisi metus rhoncus.Quis.Commodo nunc at elementum varius felis, porttitor.Quam tempor dictumst eleifend dapibus.Hendrerit massa pellentesque accumsan convallis eget sit posuere. Aliquet.Quam nascetur at suspendisse donec et pulvinar elit turpis ante donec, luctus fusce. Lectus leo curae; erat ultricies Nam hendrerit ipsum ut dis varius ut odio ultrices placerat sed fames varius et.Porta natoque rutrum, diam.Fringilla non porta congue bibendum elit. Torquent diam blandit.Orci fusce suspendisse.Porta litora tristique, dapibus integer litora leo Pretium.Enim interdum. Laoreet class commodo tortor non ligula.Facilisi molestie nisl quisque eget.Neque hymenaeos porta.Lectus nec.Eu platea iaculis magnis diam dictumst quisque consequat condimentum dictum fames. Tempor molestie risus hac. Rhoncus.Dis venenatis turpis felis congue venenatis. Ad facilisi. Justo duis porttitor sapien lacinia integer nam volutpat litora aenean sem consectetuer Pretium placerat. Sociosqu.Fringilla aptent tristique libero risus congue placerat vivamus parturient morbi dui integer taciti magnis quam risus quam ridiculus aliquet, cubilia fusce scelerisque Feugiat ultrices platea porttitor fringilla lorem.Integer eros. Erat.Ornare sagittis tristique interdum pharetra dapibus lectus ad ullamcorper, et molestie, proin.Vehicula phasellus habitasse magna aptent nascetur est velit torquent hac torquent eleifend conubia venenatis ornare nibh aliquam taciti suspendisse.Non.Etiam suspendisse pede penatibus. Magnis tempus augue nisl nisi sodales libero etiam feugiat laoreet venenatis.Dictumst.Fames habitasse, enim quam. Penatibus, et at arcu risus interdum elit nec dictumst amet libero rutrum vitae duis imperdiet molestie aliquet felis vehicula. Morbi nisl elementum semper magnis a adipiscing nullam porta hendrerit sed ligula montes congue porta lorem malesuada magna hac felis litora gravida. Scelerisque euismod montes ligula. Ornare cras donec Mus cubilia porttitor sodales suspendisse risus, per praesent fermentum ullamcorper class venenatis lectus dignissim.A rutrum nascetur malesuada faucibus malesuada tempus habitant nonummy a rutrum venenatis integer. Ad pellentesque nec nostra commodo.Ultricies fermentum tellus metus bibendum hymenaeos. Parturient nostra varius per aliquam urna lacus viverra, lobortis fames. Sapien netus iaculis posuere. Integer justo. Dictum convallis nec morbi rhoncus erat magnis.Etiam mauris ullamcorper natoque bibendum, potenti senectus faucibus litora nonummy Facilisi ornare inceptos dolor neque. Tortor convallis conubia scelerisque. Vestibulum nam ut vulputate mi, interdum sollicitudin accumsan mattis laoreet, mauris.Lacus consectetuer et.Nascetur cum accumsan, aptent imperdiet condimentum.Aliquet.Velit massa rutrum auctor odio ultricies class blandit aptent Accumsan, egestas inceptos duis eleifend montes quam integer aliquet aliquam semper felis conubia egestas blandit.Sed sagittis, purus at lacus ad etiam faucibus facilisi a.Praesent porta vulputate metus, auctor penatibus nulla montes sollicitudin class orci, posuere.Inceptos auctor cubilia mauris venenatis sollicitudin dolor metus vulputate cursus.Nunc quisque luctus etiam eget rhoncus nibh suscipit potenti proin aptent ipsum adipiscing, netus ac, lacinia etiam, inceptos elit lacinia class nonummy sed ullamcorper Pulvinar neque mauris nisl elit pulvinar.Ornare posuere fames, mi mattis turpis nisi potenti erat nisi lacinia leo inceptos nostra ac quis ad porta parturient rhoncus tempus euismod accumsan tincidunt montes, turpis habitasse a phasellus tortor ante tincidunt augue ante metus risus ad vestibulum porta hendrerit.A.Dui gravida pulvinar.Per integer senectus.Justo.Vel dictum dis mattis. Felis bibendum, mi nec dictumst suscipit libero velit, metus rutrum feugiat proin leo aliquam sed pede primis nonummy. Dis ridiculus vulputate primis. Aptent interdum, orci diam dictumst dis suspendisse luctus gravida imperdiet placerat egestas orci curae; sociis.Rhoncus felis ridiculus at gravida, vulputate habitant rhoncus faucibus fermentum et euismod mattis ligula nunc dui massa porttitor.Accumsan a ligula ligula feugiat malesuada id placerat, vehicula vulputate sit dolor sociosqu penatibus per ipsum ac molestie cras at nibh pede fringilla sem egestas cursus curabitur nec quis per luctus feugiat tortor viverra nibh semper egestas nunc porta amet aliquam facilisi.At fringilla tincidunt torquent aliquam justo justo dictumst suscipit netus convallis inceptos justo dignissim venenatis sociosqu morbi sagittis luctus, pulvinar sociosqu felis dictumst interdum metus.Commodo.Eleifend duis fringilla feugiat habitant odio convallis sagittis non. Dapibus vivamus arcu curae; praesent.Convallis.Penatibus dolor mattis quisque nec.Curae; tellus lectus conubia maecenas commodo ut viverra hendrerit.Feugiat consequat ultricies torquent potenti porttitor porta penatibus pharetra donec etiam vulputate.Per hymenaeos vel magna dis.Sociis donec vehicula netus nulla sociis lorem aptent mus malesuada interdum, eleifend habitant senectus tincidunt nascetur tincidunt fames diam semper netus, urna auctor. Suspendisse.Etiam dignissim aenean erat imperdiet at velit posuere sapien eu quisque felis lobortis.Non montes praesent justo varius eros dictum metus integer parturient nullam interdum pretium sociosqu neque mollis ante eleifend massa vivamus bibendum dictumst nibh nibh. Fermentum odio ridiculus lacinia pede enim dignissim tempor cras massa iaculis.Lectus eu sodales nascetur gravida proin arcu gravida pellentesque habitasse. Diam cubilia tristique.Sapien.Ornare sodales mollis arcu montes risus. Mattis vulputate faucibus per. Sit aliquet. Nulla lacus mauris nunc eleifend rutrum, torquent.Scelerisque, vel suspendisse tristique tempor lobortis curae; torquent interdum cursus Tincidunt pede ad suscipit praesent adipiscing phasellus aliquam vitae tincidunt adipiscing fringilla.Nullam mollis hac commodo commodo tempus.In tempus maecenas ad nisi habitasse, metus consectetuer mi luctus ipsum torquent faucibus nisi dapibus fringilla fusce suspendisse aptent ante ipsum habitasse suscipit.Odio congue quisque quam donec eget lectus amet Magnis, dignissim.Suscipit ullamcorper placerat penatibus natoque hymenaeos feugiat.Phasellus dignissim. Praesent gravida id aptent ligula sapien vivamus neque integer ullamcorper. Parturient pharetra ultrices pretium orci arcu fermentum tempus risus id maecenas eget. Massa ridiculus cum felis quis sed parturient tellus lectus litora. Vestibulum.Mollis cubilia nostra sodales, sociis primis facilisis quam convallis nonummy venenatis dictumst habitasse, pulvinar class, id Malesuada accumsan sodales purus urna justo, hendrerit sit est adipiscing felis felis orci ante quis habitasse.Fermentum aenean lorem vehicula pulvinar fermentum.Montes sapien gravida tristique rutrum ornare fermentum magnis cubilia gravida vehicula nulla tempor, facilisis diam. Euismod pretium enim hymenaeos tristique odio. Id.Mollis, libero turpis elementum blandit velit platea dui aliquam. Aenean, molestie quisque orci hac, posuere ipsum eros Hac integer per diam hymenaeos ridiculus.Suspendisse turpis parturient ornare ac curae; sit suspendisse nostra natoque congue iaculis sit rhoncus auctor ante porta vulputate blandit facilisis morbi at suspendisse etiam maecenas iaculis hymenaeos mollis ridiculus cum.Elit odio, rhoncus faucibus ultrices curabitur odio in mollis mattis leo volutpat. Cursus nec bibendum lectus tortor purus lacinia, vel cum lectus luctus mattis Viverra ut habitasse parturient venenatis natoque class semper tristique metus ad potenti.Sociis suspendisse.Hendrerit montes porta.Vitae placerat erat dictum nonummy natoque. Praesent dictum vulputate pede malesuada lectus praesent vulputate bibendum auctor fermentum consectetuer dolor nostra ad habitant fermentum erat. Parturient cursus consequat aenean facilisis porttitor odio dictum Torquent.Semper, varius.Aliquam morbi sit laoreet Volutpat nisi ut imperdiet inceptos feugiat magna.Enim odio egestas netus nascetur semper est turpis pharetra sed rhoncus non. Habitant tempus maecenas Felis tellus placerat rutrum ligula porta libero per, dignissim nam habitant porttitor vitae a fames lectus habitasse duis, neque eros Ornare, semper.Luctus habitasse vel Donec egestas taciti sapien purus, arcu.Ultricies nascetur nulla.Aliquet tincidunt velit posuere, mattis.Volutpat nam mollis at sodales sociosqu sollicitudin dis mauris curae; gravida per lobortis suscipit hymenaeos dapibus cum, sollicitudin sodales eleifend habitant parturient fames.Leo dis etiam, posuere, erat dolor. Hac facilisi vivamus ligula, curae;. Ad pede egestas.Dignissim dis enim sociosqu sollicitudin per a massa neque non quis rhoncus dolor hendrerit nec auctor cum accumsan tortor faucibus malesuada adipiscing aliquet volutpat.Imperdiet euismod sem fermentum natoque nascetur aliquam ultricies senectus Fringilla duis eu in. Integer senectus. Quisque scelerisque felis consequat Nascetur justo ullamcorper posuere sem.Imperdiet rutrum at lacus nascetur tempor pharetra.Magnis sodales convallis ornare, mattis parturient eget.Donec nam maecenas.Ultrices mus sed.Ac elit. In parturient primis pellentesque integer, class nunc aptent quisque sociosqu vestibulum auctor et nam.Vivamus.At commodo libero taciti quisque.Sagittis quisque Lacinia accumsan commodo et elementum ante justo dignissim lectus ridiculus.Molestie, at nisi dignissim diam. Pretium cubilia pharetra fusce facilisi potenti parturient Torquent pulvinar.Montes dolor hac, ridiculus nec litora eget nisi phasellus sociis fusce nonummy natoque integer dictumst cursus.Maecenas litora parturient libero hendrerit pulvinar netus, luctus facilisi faucibus est dictumst dui at ipsum at imperdiet accumsan habitasse commodo pulvinar tellus natoque dictum nisl amet laoreet praesent ligula orci placerat Aptent erat curae; felis suscipit sollicitudin primis tristique litora erat, sollicitudin fames elit, bibendum scelerisque netus class suscipit litora pellentesque.Ligula ac non hymenaeos.Metus.Curae; facilisi.Suspendisse blandit rhoncus elementum habitasse sollicitudin.Curabitur vulputate purus justo duis a ad vehicula a, ligula eleifend, pharetra sociis. Dis curae; tempus massa aenean aliquet ante facilisis platea suspendisse posuere nam nullam magnis tristique.Volutpat nisi mollis ligula ullamcorper in id libero eros congue donec laoreet varius feugiat egestas amet congue porttitor lacinia arcu taciti platea duis sociis consequat felis mus montes.Pede nascetur luctus magna massa molestie vulputate nec mi lobortis dis ut fusce lacus proin blandit proin, nullam pharetra viverra aliquam. Mi ante curabitur montes cursus taciti eros integer dignissim urna litora imperdiet scelerisque dis consequat molestie quisque.Tempus sodales quis.Vitae.Euismod proin fames euismod nec ultricies ullamcorper auctor. Nonummy aptent faucibus felis habitant at, tristique pulvinar quis inceptos ullamcorper sollicitudin dis metus hac rhoncus pretium mattis nam tempus mauris pharetra. Rhoncus at cubilia habitant, donec velit scelerisque mus. Iaculis blandit consequat imperdiet interdum pede volutpat varius mattis Venenatis blandit.Potenti dapibus, ornare luctus pulvinar imperdiet nibh.At vitae Laoreet cras sodales dolor mus.Dis tincidunt cubilia pede mi Lacus egestas felis feugiat duis faucibus tortor fames ridiculus eu euismod urna.Tempus blandit. Praesent leo enim tincidunt cursus eget condimentum ante. Lacus gravida, natoque ut amet orci luctus, morbi consectetuer senectus, dictum placerat quam cubilia magnis sed justo dictumst facilisi.Suspendisse accumsan et gravida, tellus vivamus porttitor platea massa quam Cursus condimentum semper nibh ipsum elit, cras tristique maecenas amet sollicitudin tristique phasellus adipiscing ultrices class class sollicitudin semper neque in fringilla ut habitant porttitor Nisi senectus, sagittis mattis consequat varius.Consectetuer scelerisque metus vestibulum phasellus per consequat venenatis fringilla sociosqu habitasse amet est facilisis nec quis Sodales suspendisse, tempor adipiscing malesuada metus conubia blandit eleifend Felis nisl erat morbi rhoncus mauris nunc feugiat ad nostra nibh ullamcorper.Sed morbi a. Et erat pellentesque varius et gravida elementum netus consequat sit viverra orci luctus class leo tortor.Quisque.Magna curae; ante fringilla nonummy malesuada parturient neque dis conubia.Netus convallis lorem tempus imperdiet, scelerisque adipiscing dapibus quam cursus class rhoncus dictumst.");

                        break;
                    default:
                        Console.WriteLine("TRY AGAIN DO WHAT YOU'RE ASKED NEXT TIME JEEZEE........");
                        break;

                }
            }
            void AddToList()
            {
                Menu menu = new Menu();
                Console.Clear();

                Console.WriteLine("Enter the menu number of the meal:");
                menu.MealNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the name of the meal:");
                menu.MealName = Console.ReadLine();

                Console.WriteLine("Enter a description of the meal:");
                menu.Description = Console.ReadLine();

                Console.WriteLine("Enter the ingredients of the meal(Seperate ingredients with a comma):");
                string ingredientsAsString = Console.ReadLine();
                menu.Ingredients = ingredientsAsString.Split(',').ToList();

                Console.WriteLine("Enter the price of the meal:");
                string priceAsString = Console.ReadLine();
                menu.Price = double.Parse(priceAsString);

                _menuRepo.AddItemToMenu(menu);
            }
            void DeleteFromList()
            {
                Console.Clear();

                PrintMenu();

                Console.WriteLine("Enter the menu number of the meal you would like to delete from the menu.");
                int response = Convert.ToInt32(Console.ReadLine());
                bool wasDeleted = _menuRepo.DeleteFromMenu(response);

                if (wasDeleted)
                {
                    Console.WriteLine("The meal was successfully deleted.");
                }
                else
                {
                    Console.WriteLine("The meal could not be deleted.");
                }


            }
            void PrintMenu()
            {
                Console.Clear();

                List<Menu> menuItems = _menuRepo.GetMenuItems();

                foreach (Menu item in menuItems)
                {
                    Console.WriteLine($"Meal number: {item.MealNum}\n" +
                        $"Meal name: {item.MealName}\n" +
                        $"Description: {item.Description}\n" +
                        $"Ingredients:");
                    foreach (string ingredient in item.Ingredients)
                    {
                        Console.WriteLine(ingredient);
                    }
                    Console.WriteLine($"Price: ${item.Price}");

                }


            }
        }
    }
}
