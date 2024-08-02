module AnnalynsInfiltration

let canFastAttack (knightIsAwake: bool) : bool = not knightIsAwake

let canSpy (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) : bool =
    (knightIsAwake && archerIsAwake && prisonerIsAwake)
    || (not knightIsAwake && archerIsAwake && not prisonerIsAwake)
    || (knightIsAwake && not archerIsAwake && not prisonerIsAwake)
    || (not knightIsAwake && not archerIsAwake && prisonerIsAwake)
    || (knightIsAwake && not archerIsAwake && prisonerIsAwake)
    || (not knightIsAwake && archerIsAwake && prisonerIsAwake)
    || (knightIsAwake && archerIsAwake && not prisonerIsAwake)

let canSignalPrisoner (archerIsAwake: bool) (prisonerIsAwake: bool) : bool =
    (not archerIsAwake && prisonerIsAwake)

let canFreePrisoner (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool) : bool =
    (knightIsAwake
     && archerIsAwake
     && prisonerIsAwake
     && petDogIsPresent
     && not archerIsAwake)
    || (prisonerIsAwake && not petDogIsPresent && not knightIsAwake && not archerIsAwake)
    || (not prisonerIsAwake && petDogIsPresent && not knightIsAwake && not archerIsAwake)
    || (prisonerIsAwake && petDogIsPresent && knightIsAwake && not archerIsAwake)
    || (not prisonerIsAwake && petDogIsPresent && knightIsAwake && not archerIsAwake)
    || (prisonerIsAwake && petDogIsPresent && not knightIsAwake && not archerIsAwake)
