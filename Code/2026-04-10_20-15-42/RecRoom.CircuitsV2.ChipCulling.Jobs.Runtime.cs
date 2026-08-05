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
		[Cpp2IlInjected.Address(RVA = "0x98E5E90", Offset = "0x98E4E90", VA = "0x1898E5E90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x98E4E90", Offset = "0x98E3E90", VA = "0x1898E4E90", Slot = "4")]
		public void Execute(int i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98E4BF0", Offset = "0x98E3BF0", VA = "0x1898E4BF0")]
		private float4 HSFWFIOUVTV(float4 a, float4 b, float4 c, float4 d, float4 e, float4 f)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98E4D50", Offset = "0x98E3D50", VA = "0x1898E4D50")]
		private float4 HSFWFIOUVTV(float4 a, float4 b, float4 c, float d, float e, float f)
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
		[Cpp2IlInjected.Address(RVA = "0x98E5F20", Offset = "0x98E4F20", VA = "0x1898E5F20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x98E57E0", Offset = "0x98E47E0", VA = "0x1898E57E0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98E5900", Offset = "0x98E4900", VA = "0x1898E5900")]
		private static ChipVisibilitySettings KPQHAAVHCBF([In] ChipVisibilityConfig visibilityConfig, float a, int b, bool c, bool d, bool e, bool f)
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
		[Cpp2IlInjected.Address(RVA = "0x98E5AF0", Offset = "0x98E4AF0", VA = "0x1898E5AF0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98E4E80", Offset = "0x98E3E80", VA = "0x1898E4E80")]
		private static int GJPISKIXSAZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98E4E60", Offset = "0x98E3E60", VA = "0x1898E4E60")]
		private static int GIZOAQBFPSY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98E4E70", Offset = "0x98E3E70", VA = "0x1898E4E70")]
		private static int GJEUXWVCZEH(int a)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3818929681
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x98E5F90", Offset = "0x98E4F90", VA = "0x1898E5F90")]
	public static void JUZPHBOHHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x98E5F80", Offset = "0x98E4F80", VA = "0x1898E5F80")]
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
