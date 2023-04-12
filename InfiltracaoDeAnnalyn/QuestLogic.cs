public static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
            return false;
        }
        return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || prisonerIsAwake || archerIsAwake)
        {
            return true;
        }
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent && !archerIsAwake)
        {
            return true;
        }
        else
        {
            if (prisonerIsAwake && !archerIsAwake && !knightIsAwake)
            {
                return true;
            }
            return false;
        }
    }
}