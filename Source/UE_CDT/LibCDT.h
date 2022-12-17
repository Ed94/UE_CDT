#pragma once

#include "Kismet/BlueprintFunctionLibrary.h"


#include "LibCDT.generated.h"


namespace LibCDT
{
	void GenConstrained(TArray< FVector> Points, float Z, TArray< FVector>& Vertices, TArray< int32>& Triangles);
}


UCLASS()
class UE_CDT_API ULibCDT : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()

public:

	
};