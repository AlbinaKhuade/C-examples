int count = 0;
int dist = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int Friend = 2;
int time = 0;

while (dist > 10)
{
    if (Friend == 1)
    {
        time = dist / (FirstFriendSpeed + DogSpeed);
        Friend = 2;
    }
    else
    {
        time = dist / (SecondFriendSpeed + DogSpeed);
        Friend = 1;
    }
    dist = dist - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");
