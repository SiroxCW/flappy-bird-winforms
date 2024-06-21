## Flappy Bird Winforms
I recreated Flappy Bird for fun in C# Winforms.

### Config
The default config looks like this:<br>
<pre>
0     -->  fallPhysic:      will determine the starting fall speed. +10 makes it fall down fast at the start, -10 makes it jump at the start for example.
0     -->  score:           will determine the starting score. This doesnt affect the speed.
0     -->  randomWidthDown: will be overwritten by maxDistance and minDistance.
0     -->  randomWidthUp:   will be overwritten by maxDistance and minDistance.
180   -->  maxDistance:     will determine the maximum length of the pipes (for every score ingame, this increments by one).
120   -->  minDistance:     will determine the minimum length of the pipes.
553   --> upHeight:         will determine the spawn height on the pipes facing up. (use this if the pipes are not where they should be).
-8    --> jumpHeight:       will determine the jump height.
</pre>

### Build
If you want to build it yourself, create a new C# Winforms Projects and copy the code. Before building it, you need to include the resources folder contents in the projects resources so it will be used by Winforms.
