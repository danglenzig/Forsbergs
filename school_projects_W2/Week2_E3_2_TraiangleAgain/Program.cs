Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

DrawTri(rows);

void DrawTri(int triRows)
{
    if (triRows >= 0)
    {
        
        int offset = (rows - triRows) / 2;

        for (int j = 1; j <= offset; j++)
        {
            Console.Write(" ");
        }
        
        for (int i = 0; i <= triRows; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
        DrawTri(triRows - 1);
    }
}