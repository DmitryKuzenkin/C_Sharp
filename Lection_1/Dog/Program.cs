int count = 0;
double distance = 1000;
int FirstFriendSpeed = 2;
int SecondFriendSpeed = 3;
int DogSpeed = 10;
int Friend = 2;
double Time = 0;

while (distance > 10)
{

    if (Friend == 1)
    {
        Time = distance/(FirstFriendSpeed+DogSpeed);
        Friend = 2;
    }
    else
    {
        Time = distance/(SecondFriendSpeed+DogSpeed);
        Friend = 1;
    }

    distance = distance - (FirstFriendSpeed+SecondFriendSpeed)*Time;
    count++;
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз");


