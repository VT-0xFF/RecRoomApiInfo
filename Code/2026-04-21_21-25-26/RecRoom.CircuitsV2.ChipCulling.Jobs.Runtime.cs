using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.CircuitsV2.ChipCulling.Data;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.CircuitsV2.ChipCulling.Jobs.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public struct SetUpSortingArrayJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public ProfilerMarker ProfilerMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[WriteOnly]
		public NativeArray<int> IndexMap;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98ACBC0", Offset = "0x98AB5C0", VA = "0x1898ACBC0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public struct FrustumCullJob : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public ProfilerMarker ProfilerMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[ReadOnly]
		public NativeArray<float4> SpheresX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[ReadOnly]
		public NativeArray<float4> SpheresY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[ReadOnly]
		public NativeArray<float4> SpheresZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[ReadOnly]
		public NativeArray<float4> SpheresR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[WriteOnly]
		public NativeArray<float4> Distances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CullingCameraInfo CullingCameraInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float MaxDistSq;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98ABBC0", Offset = "0x98AA5C0", VA = "0x1898ABBC0", Slot = "4")]
		public void Execute(int i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98AB920", Offset = "0x98AA320", VA = "0x1898AB920")]
		private float4 BDGCOOUNBFW(float4 a, float4 b, float4 c, float4 d, float4 e, float4 f)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98ABA80", Offset = "0x98AA480", VA = "0x1898ABA80")]
		private float4 BDGCOOUNBFW(float4 a, float4 b, float4 c, float d, float e, float f)
		{
			return default(float4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[BurstCompile]
	public struct SyncPositionsJob : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public ProfilerMarker ProfilerMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[WriteOnly]
		public NativeArray<float> SphereX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[WriteOnly]
		public NativeArray<float> SphereY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[WriteOnly]
		public NativeArray<float> SphereZ;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98ACC50", Offset = "0x98AB650", VA = "0x1898ACC50", Slot = "4")]
		public void Execute(int i, TransformAccess transform)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[BurstCompile]
	public struct MakeVisibilitySettingsJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ProfilerMarker ProfilerMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[ReadOnly]
		public NativeArray<float> SortedDistances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[ReadOnly]
		public NativeArray<int> IndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ReadOnly]
		public NativeArray<bool> InScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[WriteOnly]
		public NativeArray<ChipVisibilitySettings> VisibilitySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool ShowCV2OutOfScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public bool IsObjectModelEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public bool IsCurrentEditScopeNonCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public ChipVisibilityConfig VisibilityConfig;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98AC700", Offset = "0x98AB100", VA = "0x1898AC700", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98AC510", Offset = "0x98AAF10", VA = "0x1898AC510")]
		private static ChipVisibilitySettings DNBZYPZHJKO([In] ChipVisibilityConfig visibilityConfig, float a, int b, bool c, bool d, bool e, bool f)
		{
			return default(ChipVisibilitySettings);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[BurstCompile]
	public struct RadixJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NativeArray<int> Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NativeArray<int> Map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ProfilerMarker FullProcessMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ProfilerMarker GetCountsMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ProfilerMarker MakeHistogramsMarker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ProfilerMarker SortMarker;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98AC820", Offset = "0x98AB220", VA = "0x1898AC820", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98ABB90", Offset = "0x98AA590", VA = "0x1898ABB90")]
		private static int YLLEACYDUMM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98ABBB0", Offset = "0x98AA5B0", VA = "0x1898ABBB0")]
		private static int YMAYRXFVWUN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98ABBA0", Offset = "0x98AA5A0", VA = "0x1898ABBA0")]
		private static int YLVRUQLYNJE(int a)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1392726525
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x98ACCC0", Offset = "0x98AB6C0", VA = "0x1898ACCC0")]
	public static void HARHJNMTRDT()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x98ACCB0", Offset = "0x98AB6B0", VA = "0x1898ACCB0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
