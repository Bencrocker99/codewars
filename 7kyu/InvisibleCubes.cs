//Imagine there's a big cube consisting of n cubed small cubes. Calculate, how many small cubes are not visible from outside.

//For example, if we have a cube which has 4 cubes in a row, then the function should return 8, because there are 8 cubes inside our cube (2 cubes in each dimension)

//For a visual representation: --> https://imgur.com/a/AN8A5DJ


//My Solution

public class InvisibleCubesProblem
{
    public static int NotVisibleCubes(int n)
    {

        int middleCubes = (n - 2) * (n - 2) * (n - 2);
        if (middleCubes < 0)
        {
            middleCubes = 0;
        }
        return middleCubes;
    }
}