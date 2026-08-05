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
		[Cpp2IlInjected.Address(RVA = "0x813E900", Offset = "0x813D100", VA = "0x18813E900", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x813D900", Offset = "0x813C100", VA = "0x18813D900", Slot = "4")]
		public void Execute(int i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x813D770", Offset = "0x813BF70", VA = "0x18813D770")]
		private float4 NMUILQMMYZE(float4 a, float4 b, float4 c, float4 d, float4 e, float4 f)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x813D660", Offset = "0x813BE60", VA = "0x18813D660")]
		private float4 NMUILQMMYZE(float4 a, float4 b, float4 c, float d, float e, float f)
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
		[Cpp2IlInjected.Address(RVA = "0x813E990", Offset = "0x813D190", VA = "0x18813E990", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x813E250", Offset = "0x813CA50", VA = "0x18813E250", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x813E370", Offset = "0x813CB70", VA = "0x18813E370")]
		private static ChipVisibilitySettings NSMHKZXGZRO([In] ChipVisibilityConfig visibilityConfig, float a, int b, bool c, bool d, bool e, bool f)
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
		[Cpp2IlInjected.Address(RVA = "0x813E560", Offset = "0x813CD60", VA = "0x18813E560", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x813D8F0", Offset = "0x813C0F0", VA = "0x18813D8F0")]
		private static int JPOEDWQSUXE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x813D8E0", Offset = "0x813C0E0", VA = "0x18813D8E0")]
		private static int JPIXGPWVLLV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x813D8D0", Offset = "0x813C0D0", VA = "0x18813D8D0")]
		private static int JPDQJJCYCAM(int a)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2876924792
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x813EA00", Offset = "0x813D200", VA = "0x18813EA00")]
	public static void JTEJSBRAGJR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x813E9F0", Offset = "0x813D1F0", VA = "0x18813E9F0")]
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
