<?php
<?php
	$n= Readline("Enter Number of rows::");
	$m=$n;
	for($i=0;$i<$n;$i++)
	{
		if($i%2==0)
		{
		for($k=0;$k<($m/2);$k++)
		{
			echo(" ");
		}
		$m=$m-2;
		for($j=0;$j<=$i;$j++)
		{
			echo("*");
		}
		echo("\n");
		}
	}
	for($x=($n-2);$x>=0;$x--)
	{
		if($x%2==0)
		{
			$m=$m+2;
			for($k=0;$k<=($m/2) ;$k++)
			{
				echo(" ");
			}
			echo(" ");
			for($j=0;$j<=$x;$j++)
			{
				echo("*");
			}
		echo("\n");
		}
	}
?>
?>