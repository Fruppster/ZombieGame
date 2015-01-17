using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ZombieGame
{


    //                                 .$$$b                     ...                
    //                                4$$$$be...                  9$b               
    //                              zd$$$$$$$$$$$$$e    .z$$$$$$$$$$$               
    //                           J$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$c             
    //                     d$- z$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$.           
    //                    $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$L          
    //                    $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$.         
    //                    $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$b 4       
    //                    4$$$$$$$$$$P""   '$$F$**$$$$$$$$$$$$$$**$$$$$$$$$L.F      
    //                    $$$$$$$$$$F .     ^""    ^*$$$$$*     %e$$P*$$$$$$$%      
    //                   4$$$$$$$$$$$$                *%"              $$$$$        
    //                   $$$$$$$P           d$$b             d$$c       $$$$        
    //                   $$$$$$$          .$"  ^                "L    $$$$$F        
    //                $.d$$$$$$F .        P                      ^F    "*$$%        
    //                *$$$$$$$$$e$       $                        ^c     $$.zF      
    //                 "$$$$$$$$$$"    ."   4  .                      z 4$$$P       
    //                   ^$$$$$$"        ^r J  $               z .f   '$$P          
    //                    *$$$$$       3.z$$$*$L.F          4$$$$$ z   '$"          
    //                     $$$$$$. 3$.  3$$$$  'P          $$$$F 3$"   $%.          
    //                      *$$$$$$$$b  $$$     4         .$$$F   'F4$$$e$          
    //                   .. 4$$$$$$$$P  $""     4         d$$P     F^$$$$F          
    //                    $$$$$$$$$$"   4.      $         ^.      d" 3$$%           
    //                    ^"$$$$$ *      $e...z$"          *c    $$   L4F           
    //                      4P$ $ 4       ""$"F^            "**P"-    $ $           
    //                      4r4$%.F                    P              $ $           
    //                       $be$*$e                                .$Ld%           
    //                        ^    *$.               4$$F          JP**"            
    //                              .$*$$bec.  ...z$$$$$P$$$bee$$**%                
    //                             d"                 ""            ^*c             
    //                            d                                    "c           
    //                           $                                       "e.        
    //                          J"            ..       ....   $            "b       
    //                          $          d$$$$$$$  e$$$$$$b$*$.            *c     
    //                         4"         d$$$$$$$$$$$$$$$$$$$  "$c           ^$    
    //                         $      4$% $$$$$$$$$$$$$$$$$$$$    ^"b.          b   
    //                        JF      $L  $$$$$$$$$$$$$$$$$$$F       ^$e..z      b  
    //                       4$      J"*k ^$$$$$$$$$$$$$$$$$P           ^P       4  
    //                      .$      ^P  *b 4$$$$$$$$$$$$$$$F           .P        P  
    //                     .@       d"   $$$$$$$$$$$$$$$$$$            P        J"  
    //                    z$"      JF     $$$$$$$$$$$$$$$$$           $        .%   
    //                   J*       -$       $$$$$$$$$$$$$$$$r         d"       d%    
    //                  dF       .$         $$$$$$$$$$$$$$$$$c.     J%       d"     
    //                 $"        $"         $$$$$$$$$$$$$$$$$P*$e$$$%      zP       
    //                d"        $          d$$$$$$$$$$$$$$**"   ^$r^r    e"         
    //               4F       .$          d$$$$$$$$$$$$$$$$r      3r4..$"           
    //              J$       4$"        .$$$$$$$$$$$$$$$$$$$$      $ $"             
    //          .$$$$b.     J$         :$$$$$$$$$$$$$$$$$$$$P.de.zd$ $              
    //     ..eue$$$$$(*   z$"         .$$$$$$$$$$$$$$$$$$$$$$$$$$$C$ $              
    //  z$P*""""    $$ $d$*           $$$$$$$$$$$$$$$$$$$$$$$$$$$$$"JF              
    //d$$  $$*"     $$ $"            :$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$"               
    //^$P  ^#*$$- .$"3 $             $$$$$$$$$$$$$$$$$$$$$$$$$$$$$E                 
    //$$$$eb zeee$$$$F4F             $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$L  4$.           
    //^ ""#$$""   *$$$"              $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$b           
    //    *"                         $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$P           
    //                               $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$            
    //                          4F  4$$$$$$$$$$$$$$$$$$"4$"""""  $$$$P"             
    //                          $$$$$$$$$$$$P"*$$$$*"   4"    .. $                  
    //                          '$$$$$$$$$$F            4$$$e$ 3$P                  
    //                           3$$$$$$$$"             4$$$$$.d$F                  
    //                            ^*$$*"*%              J       .                   
    //                                   b              F       $                   
    //                                   *.             F      4F                   
    //                                    $                    J                    
    //                                     b           4       L                    
    //                                     4b          $      J-                    
    //                                      $          %     .F                     
    //                                     $"         d      $                      
    //                                    $"         :F      F                      
    //                                   $          .$      4-                      
    //                                  d"          d"      3                       
    //                                 4P          d"       $                       
    //                                <$          d"        $                       
    //                                d%         J$         $                       
    //                                $         4$$        4F                       
    //                               4F        4" $        4                        
    //                               $        :#  $        P                        
    //                               $       4P   *        F                        
    //                              4F      4F    4r      d                         
    //                              $      4*      $      $                         
    //                              P     d"       $     4F                         
    //                             4"    d%        4     J                          
    //                             $    J%         4    .F                          
    //                             $   4%          J    4%                          
    //                            d"  .$           F    $                           
    //                           dF   P           d"    F                           
    //                          J$               $$     F                           
    //                         dP    J           $$b    L                           
    //                        4P    ^F           $$$$F  *     Posted by   
    //                       .$    .$            $$$$$$edF    mchatfield             
    //                       4$$c.d$"                $$$$$r                         
    //                       4$$$$$"                  "**$P

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime _gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            base.Update(_gameTime);
        }

        protected override void Draw(GameTime _gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            base.Draw(_gameTime);
        }
    }
}
