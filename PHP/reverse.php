<?php
	$size= readline("Enter length of array: ");
	for($i=0;$i<$size;$i++)
	{
		$array[$i] = readline("Enter: ");
	}
	for($j=0;$j<$size;$j++)
	{		
		$res[$j] = $array[($size-1)-$j]; 
	}
	echo "output \n";
	for($i=0;$i<$size;$i++)
	{
		echo $res[$i];
	}
?>