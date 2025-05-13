int[] nums = { 0, 1, 0, 3, 12 };
MoveZeroes(nums);
Console.WriteLine(string.Join(", ", nums));
int[] MoveZeroes(int[] nums)
{
    Stack<int> numStack = new Stack<int>();
    for (int i = nums.Length - 1; i > 0; i--)
    {
        if (nums[i] != 0)
        {
            numStack.Push(nums[i]);
        }
    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (numStack.Count > 0)
        {
            nums[i] = numStack.Pop();
        }
        else
        {
            nums[i] = 0;
        }
        
    }
    return nums;
}