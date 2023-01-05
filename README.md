# 0x03. Unity - UI

#### How to play

Use WASD or the arrow keys to move the player around the map collecting coins, avoiding traps and reaching the goal.
There are a total of 20 coins on the map, every time you collect one your score will add up to one point.
The player has a total of 5 health points, every time you interact with a trap your health will drop, once you lose all points the game will display "Game Over!" and automatically restart.
Once you reach the goal the message "You win!" will be displayed.

## Project Tasks

### 0. Scoreboard

Create a new Canvas GameObject:

-   Render Mode:  `Screen Space - Overlay`
-   Pixel Perfect: Yes
-   UI Scale Mode:  `Scale With Screen Size`

Inside the Canvas, create a new UI Image GameObject and name it  `ScoreBG`. Anchor it to the top right of the game window using Anchor Presets.

-   Pos X:  `-80`
-   Pos Y:  `-40`
-   Width:  `100`
-   Height:  `30`
-   Image color:  `#000000`
-   Alpha:  `200`

Create a new Text GameObject named  `ScoreText`. Make  `ScoreText`  a child of  `ScoreBG`. Anchor  `ScoreText`  to the middle of  `ScoreBG`  using Anchor Presets.

-   Width:  `100`
-   Height:  `30`
-   Text:  `Score: 0`
-   Font size:  `18`
-   Alignment:  `Center`  +  `Middle`
-   Horizontal Overflow:  `Overflow`
-   Font color:  `#FFFFFF`

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/0.png)


-   File:  [`Assets/maze.unity`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/maze.unity)

### 1. What does "new high score" mean? Is that bad? Did I break it?

Edit the  `PlayerController.cs`  script. Create a new  `public Text scoreText`  variable. In the Inspector, set the value of the  `scoreText`  field to your  `ScoreText`  GameObject.

Create a new method  `void SetScoreText()`.

-   When called, this method should update the  `ScoreText`  object with the  `Player`‘s current score.
-   Remove or comment out your  `Debug.Log`  line printing  `score`  to the Console.

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/1.gif)

-   File:  [`Assets/maze.unity`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/maze.unity)

### 2. HP

Inside the existing Canvas GameObject, create a new UI Image GameObject and name it  `HealthBG`. Anchor it to the top left of the game window using Anchor Presets.

-   Pos X:  `80`
-   Pos Y:  `-40`
-   Width:  `100`
-   Height:  `30`
-   Image color:  `#FF0000`
-   Alpha:  `230`

Inside the existing Canvas GameObject, create a new Text GameObject called  `HealthText`. Make  `HealthText`  a child of  `HealthBG`. Anchor  `HealthText`  to the middle of  `HealthBG`  using Anchor Presets.

-   Width:  `100`
-   Height:  `30`
-   Text:  `Health: 5`
-   Font size:  `18`
-   Alignment:  `Center`  +  `Middle`
-   Horizontal Overflow:  `Overflow`
-   Font color:  `#FFFFFF`

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/2.png)

-   File:  [`Assets/maze.unity`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/maze.unity)

### 3. Health inspection

Edit the  `PlayerController.cs`  script. Create a new  `public Text healthText`  variable. In the Inspector, set the value of the  `healthText`  field to your  `HealthText`  GameObject.

Create a new method  `void SetHealthText()`.

-   When called, this method should update the  `HealthText`  object with the  `Player`‘s current  `health`
-   Remove or comment out your  `Debug.Log`  line printing  `health`  to the Console

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/3.gif)

-   File:  [`Assets/maze.unity`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/maze.unity)

### 4. Win, lose, or draw

Inside the existing Canvas GameObject, create a new UI Image GameObject and name it  `WinLoseBG`. Anchor it to the center of the game window using Anchor Presets.

-   Pos X:  `0`
-   Pos Y:  `70`
-   Width:  `200`
-   Height:  `60`
-   Image color:  `#FF0000`

Inside the existing Canvas GameObject, create a new Text GameObject called  `WinLoseText`. Make  `WinLoseText`  a child of  `WinLoseBG`. Anchor  `WinLoseText`  to the middle of  `WinLoseBG`  using Anchor Presets.

-   Width:  `160`
-   Height:  `30`
-   Text: Leave empty for now
-   Font size:  `14`
-   Alignment:  `Center`  +  `Middle`
-   Horizontal Overflow:  `Overflow`
-   Vertical Overflow:  `Truncate`
-   Best Fit: Yes
-   Font color:  `#FFFFFF`

Set  `WinLoseBG`  as inactive by unchecking the box next to the object’s name at the top of the Inspector.

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/4.png)

-   File:  [`Assets/maze.unity`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/maze.unity)

### 5. Chicken dinner

Edit the  `PlayerController.cs`  script so that when the  `Player`  touches the  `Goal`:

-   `You Win!`  displays in the  `WinLoseText`  UI element
-   `WinLoseText`‘s color changes to  `black`
-   `WinLoseBG`’s color changes to  `green`
-   Remove or comment out your  `Debug.Log`  line printing  `You Win!`  to the Console

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/5.gif)

-   File:  [`Assets/maze.unity`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/maze.unity)

### 6. Game over, man, game over

Edit the  `PlayerController.cs`  script so that when the  `Player`‘s  `health`  reaches  `0`:

-   `Game Over!`  displays in the  `WinLoseText`  UI element
-   `WinLoseText`’s color changes to  `white`
-   `WinLoseBG`’s color changes to  `red`
-   Remove or comment out your  `Debug.Log`  line printing  `Game Over!`  to the Console

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/6.gif)

### 7. Wait a second...

The transition from the  `Game Over!`  text and the scene reloading is very sudden and abrupt. Let’s use a  [coroutine](https://intranet.hbtn.io/rltoken/O5SHYPuhCBEmSmLzpnTUWA "coroutine")  and  `WaitForSeconds()`  to create a delay where once the  `Player`‘s  `health`  is  `0`  and the  `Game Over!`  text is displayed, the scene waits  `3`  seconds to reload.

Create a new method  `IEnumerator LoadScene(float seconds)`:

-   This method should call  `WaitForSeconds`  before reloading the current scene
-   To utilize this method as a coroutine, call it with  `StartCoroutine()`  (ex.  `StartCoroutine(LoadScene(3))`)

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/7a.gif)

Let’s also use this method when the player wins to restart the game. Call  `LoadScene()`  when  `Player`  reaches the  `Goal`.

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/7b.gif)

-   File:  [`Assets/maze.unity`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/maze.unity)
### 8. What's on the menu

Create a new scene called  `menu`  in the Project window. Add a new UI Panel GameObject called  `MenuBG`:

-   Color:  `#313131`
-   Alpha:  `200`

Inside the existing Canvas GameObject, create an empty GameObject called  `MainMenu`. Anchor it to the center of the game window with Anchor Presets.

-   Width:  `250`
-   Height:  `200`

Inside  `MainMenu`, create three UI Button GameObjects  `PlayButton`,  `OptionsButton`,  `QuitButton`. Anchor them to the center of the game window using Anchor Presets.

-   `PlayButton`  Pos Y:  `60`
-   `OptionsButton`  Pos Y:  `0`
-   `QuitButton`  Pos Y:  `-60`
-   Width:  `180`
-   Height:  `40`
-   Normal Color:  `#FFFFFF`
-   Highlighted Color:  `#9EECBC`
-   Pressed Color:  `#A9A9A9`

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/8.png)
-   File:  [`Assets/menu.unity`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/menu.unity)
### 9. Let's play

Create a new C# script  `MainMenu.cs`. Create a new method  `public void PlayMaze()`.

-   This method should load the  `maze`  scene when the  `Play`  button is pressed.
-   Under  `File`  >  `Build Settings`, add your  `menu`  and  `maze`  scenes to the build.

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/9.gif)

Inside the  `PlayerController.cs`  script, update the  `Update()`  script to check if the player presses the  `Esc`  key. If the  `Esc`  key is pressed, load the  `menu`  scene.

-   File:   [`Assets/Scripts/MainMenu.cs`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/Scripts/MainMenu.cs)

### 10. We're not retreating, we're advancing! Toward future victory!

Inside the  `MainMenu.cs`  script, create a new method  `public void QuitMaze()`.

-   This method should close the game window when the  `Quit`  button is pressed.
-   Since this will not work in the Unity editor preview, add a  `Debug.Log()`  message that writes  `Quit Game`  to the Console when the  `Quit`  button is pressed.

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/10.gif)

-   File:   [`Assets/Scripts/MainMenu.cs`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/Scripts/MainMenu.cs)

### 11. A narrow variety of options

Inside the existing Canvas GameObject, create an empty GameObject called  `OptionsMenu`. Anchor it to the center of the game window with Anchor Presets.

-   Width:  `250`
-   Height:  `200`

Create a new UI Text GameObject called  `OptionsTitle`  and anchor it to the top center of the  `OptionsMenu`  GameObject using Anchor Presets.

-   Width:  `160`
-   Height:  `30`
-   Text:  `OPTIONS`
-   Font Style:  `Bold`
-   Font Size:  `24`
-   Alignment:  `Center`  +  `Middle`
-   Horizontal Overflow:  `Overflow`
-   Color:  `#FFFFFF`

Duplicate one of the buttons from the  `MainMenu`  and rename it to  `BackButton`. Change the text to  `Back`. Anchor it to the bottom center of the  `Options`  Menu GameObject using Anchor Presets.

Set the  `OptionsMenu`  GameObject to inactive by unchecking the box next to the object’s name at the top of the Inspector.

Now, instead of creating a script to switch between the  `MainMenu`  and  `OptionsMenu`, use the UI Button’s built-in  `OnClick()`  event instead.

-   `MainMenu`  >  `OptionsButton`: Create  `OnClick()`  events so that when this button is pressed, it sets  `OptionsMenu`  as active and  `MainMenu`  as inactive
-   `OptionsMenu`  >  `BackButton`: Create  `OnClick()`  events so that when this button is pressed, it sets  `MainMenu`  as active and  `OptionsMenu`  as inactive

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/11a.png)

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/11b.gif)

-   File:   [`Assets/Scripts/MainMenu.cs`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/Scripts/MainMenu.cs)

### 12. Accessibility

Having red traps and a green goal isn’t very accessible design for certain types of  [colorblindness](https://intranet.hbtn.io/rltoken/0zQvwmazM5Q6fmuHZE8tzw "colorblindness"). Ideally in game design, it would be better to avoid color coding important mechanics or objects entirely. For the sake of this UI project, we’ll add a Colorblind Mode option for our maze.

Add a UI Toggle GameObject called  `ColorblindMode`  to the  `OptionsMenu`  GameObject.

-   Toggle Label:  `Colorblind Mode`
-   Label Text Alignment:  `Left`  +  `Middle`
-   Position the checkbox on the right of the label as shown in the screenshots below

Edit the  `MainMenu.cs`  script and add three new variables:

-   `public Material trapMat`
-   `public Material goalMat`
-   `public Toggle colorblindMode`

In the Inspector, assign the materials  `trap`  and  `goal`  and the toggle  `ColorblindMode`  to their respective variables.

Within  `PlayMaze()`, check if  `colorblindMode`  is toggled on. If it is, change the  `trap`  and  `goal`  material colors:

-   `trap`  material color:  `new Color32(255, 112, 0, 1)` 
-   `goal`  material color:  `Color.blue`

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/12b.gif)

Otherwise, the maze should load with materials as their original red and green colors.

![](https://s3.eu-west-3.amazonaws.com/hbtn.intranet.project.files/holbertonschool-cs-unity/422/12a.gif)

-   File:   [`Assets/Scripts/MainMenu.cs`](https://github.com/Titania792/holbertonschool-0x03-unity-ui/blob/main/Assets/Scripts/MainMenu.cs)