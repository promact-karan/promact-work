<?php
		//echo "Enter Number of Rows:";
		$x = 11;
		$y=$x/2;
		$z=$y;
		$no=1;
		$k=$x;
		/*for($i=1;$i<=$y;$i++)
		{
			for($k=1;$k<($z/2);$k++)
			{
				echo(" ");
			}
			$z=$z-1;
			for($j=1;$j<=$i;$j++)
			{
				echo("*");
			}
			echo("\n");
		}
		$z=$y;
		for($i=1;$i<=$y;$i++)
		{
			for($k=1;$k<($z/2);$k++)
			{
				echo(" ");
			}
			$z=$z-1;
			for($j=$y;$j>=$i;$j--)
			{
				echo("*");
			}
			echo("\n");
		}
		*/
		/*for($i=1;$i<=$x;$i++)
		{
			
			if($i%2!=0)
			{
			echo($no++);
				for($k=0;$k<=$z;$k++)
				{
					echo (" ");
				}
				$z--;
				for($j=1;$j<=$i;$j++)
				{	
					echo("*");
				}
			}
			echo("\n");
		}
		for($i=1;$i<=$x;$i++)
		{
			
			if($i%2==0)
			{
			echo($no++);
				for($k=x;$k>=$z;$k--)
				{
					echo (" ");
				}
				$z++;
				for($j=x;$j<=$i;$j--)
				{	
					echo("*");
				}
			}
			echo("\n");
		}*/
		function read_stdin(){
    
    $give=fopen("php://stdin","r");
    $input=fgets($give,100);
    $input=rtrim($input);
    fclose($give);
    return $input;

}
echo "Enter Number of Rows::";
$input= read_stdin();
$temp=$input;

for($i=0;$i<$input;$i++)
{
	if($i/2!=0)
	{
		for($j=0;$j<=$i;$j++)
	{
	echo "*";	
	}
	echo " \n";
	}
	
}	
for($i=$input;$i>=0;$i--)
{
	
	for($j=$i;$j>=0;$j--)
	{
	echo "*";	
	}
	echo " \n";
}
		
	?>