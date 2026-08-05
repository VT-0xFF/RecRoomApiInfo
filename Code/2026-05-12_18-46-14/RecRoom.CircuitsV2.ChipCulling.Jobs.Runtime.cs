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
		[Cpp2IlInjected.Address(RVA = "0x988DD50", Offset = "0x988C750", VA = "0x18988DD50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x988CD50", Offset = "0x988B750", VA = "0x18988CD50", Slot = "4")]
		public void Execute(int i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x988CAB0", Offset = "0x988B4B0", VA = "0x18988CAB0")]
		private float4 OTXAJRERZXJ(float4 a, float4 b, float4 c, float4 d, float4 e, float4 f)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x988CC10", Offset = "0x988B610", VA = "0x18988CC10")]
		private float4 OTXAJRERZXJ(float4 a, float4 b, float4 c, float d, float e, float f)
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
		[Cpp2IlInjected.Address(RVA = "0x988DDE0", Offset = "0x988C7E0", VA = "0x18988DDE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x988D890", Offset = "0x988C290", VA = "0x18988D890", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x988D6A0", Offset = "0x988C0A0", VA = "0x18988D6A0")]
		private static ChipVisibilitySettings ELQAEIVTFZF([In] ChipVisibilityConfig visibilityConfig, float a, int b, bool c, bool d, bool e, bool f)
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
		[Cpp2IlInjected.Address(RVA = "0x988D9B0", Offset = "0x988C3B0", VA = "0x18988D9B0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x988CD40", Offset = "0x988B740", VA = "0x18988CD40")]
		private static int JVQSSDYAKZT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x988CD20", Offset = "0x988B720", VA = "0x18988CD20")]
		private static int JVAYAJQIIRS(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x988CD30", Offset = "0x988B730", VA = "0x18988CD30")]
		private static int JVGEXQKFSDB(int a)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3451824018
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x988DE40", Offset = "0x988C840", VA = "0x18988DE40")]
	public static void BNIWUCRKOYO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x988DF10", Offset = "0x988C910", VA = "0x18988DF10")]
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
