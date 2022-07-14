<Query Kind="Program" />

void Main()
{
	int[] nums = new int[] {1,2,3,4,5};
	int sum1 = 0;
	int sum2 = 0;
	
	for (int i = 0; i < nums.Length; i++)
	{
		sum1 += nums[i];
		sum2 += i;
		
		if(i == nums.Length-1){
			sum2 += nums.Length;
		}
	}
	
	Console.WriteLine(sum2-sum1);
	
}

