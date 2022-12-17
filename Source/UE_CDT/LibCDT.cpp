#include "LibCDT.h"


#include "CDT.h"


namespace LibCDT
{
	void GenConstrained(TArray<FVector> Points, float Z, TArray<FVector>& Vertices, TArray<int32>& Triangles)
	{
		using Triangulation = CDT::Triangulation<float>;
		using V2d           = CDT::V2d<float>;

		Triangulation Triangulator;

		std::vector<V2d> PointVectorSTD;
		for (const FVector Point : Points)
		{
			PointVectorSTD.push_back( V2d::make( Point.X, Point.Y ) );
		}

		Triangulator.insertVertices( PointVectorSTD );
		Triangulator.eraseOuterTriangles();

		for (auto Vertex : Triangulator.vertices)
		{
			Vertices.Add( FVector( Vertex.x, Vertex.y, Z ) );
		}

		for (auto Triangle : Triangulator.triangles)
		{
			Triangles.Add( Triangle.vertices[ 0 ] );
			Triangles.Add( Triangle.vertices[ 1 ] );
			Triangles.Add( Triangle.vertices[ 2 ] );
		}
	}
}
