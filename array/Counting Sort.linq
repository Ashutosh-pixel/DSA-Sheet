<Query Kind="Program" />

void Main()
{
	int[] array = new int[] {1};
	Counting(array);
}

static void Counting(int[] array)
{
	var size = array.Max();
	int[] frequency = new int[size+1];
	
	foreach (var element in array)
	{
		frequency[element] += 1;
	}
	
	int k =0;
	for (int i = 0; i < frequency.Length; i++)
	{
		if(frequency[i] != 0){
			for (int j = 0; j < frequency[i]; j++)
			{
				array[k] = i;
				k++;
			}
		}
	}
	
	
}

