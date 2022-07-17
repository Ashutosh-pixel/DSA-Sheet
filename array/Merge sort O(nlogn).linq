<Query Kind="Program" />

void Main()
{
	int[] array = new int[] {};
	Divide(array);
	foreach (var element in array)
	{
		Console.WriteLine(element);
	}
}


static void Divide(int[] array){
	
	if(array.Length<2){
		return ;
	}

	int middle = array.Length/2;
	int[] left = new int[middle];
	for (int i = 0; i < middle; i++)
	{
		left[i] = array[i];
	}

	int[] right = new int[array.Length-middle];
	
	for (int j = middle; j < array.Length; j++)
	{
		right[j-middle] = array[j];
	}
	
	Divide(left);
	Divide(right);
	Merge(left,right,array);
}

static void Merge(int[] left,int[] right, int[] arr){
	int i =0, j =0, k =0;
	
	while(i<left.Length && j<right.Length){
		if(left[i] <= right[j]){
			arr[k] = left[i];
			k++;
			i++;
		}
		else{
			arr[k] = right[j];
			j++;
			k++;
		}	
	}
	
	while(i<left.Length){
		arr[k] = left[i];
		i++;
		k++;
	}
	while (j < right.Length)
	{
		arr[k] = right[j];
		j++;
		k++;
	}
}

