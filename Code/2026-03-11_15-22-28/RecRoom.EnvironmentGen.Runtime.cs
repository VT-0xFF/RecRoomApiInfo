using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.EnvironmentGen.Noise;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x847A340", Offset = "0x8479340", VA = "0x18847A340")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_EnvironmentGen_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x847A180", Offset = "0x8479180", VA = "0x18847A180", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.EnvironmentGen.Terrain
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class QOKVDGRRHUX : TPPYNKEKCVK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile]
		private struct BlendJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			[ReadOnly]
			public NativeArray<float> Layer2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			[ReadOnly]
			public NativeArray<float> Blend;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public NativeArray<float> Layer1AndOutput;

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84764F0", Offset = "0x84754F0", VA = "0x1884764F0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private TPPYNKEKCVK MYIYHFUWFXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private TPPYNKEKCVK MYOFEMOTPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private TPPYNKEKCVK TCCDNHWNFSO;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB525B0", Offset = "0xB515B0", VA = "0x180B525B0")]
		public QOKVDGRRHUX(TPPYNKEKCVK a, TPPYNKEKCVK b, TPPYNKEKCVK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x847A4B0", Offset = "0x84794B0", VA = "0x18847A4B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MPHJORVQSEL : TPPYNKEKCVK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[BurstCompile]
		public struct ErodeJob : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private struct CellToFall
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public float diff;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public int2 cell;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public NativeArray<float> Terrain;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public NativeArray<float> Water;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int2 cells;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int steps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float erodability;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8476BB0", Offset = "0x8475BB0", VA = "0x188476BB0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8476730", Offset = "0x8475730", VA = "0x188476730")]
			private void DQPJQYSCUWZ(NativeArray<float> a, NativeArray<float> b, NativeList<CellToFall> c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TPPYNKEKCVK SHXQOKDYQKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TPPYNKEKCVK HIMLYRCSGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int VPPAICDQELE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float SPRXPBFCKWX;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x847A2A0", Offset = "0x84792A0", VA = "0x18847A2A0")]
		public MPHJORVQSEL(TPPYNKEKCVK a, TPPYNKEKCVK b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x847A240", Offset = "0x8479240", VA = "0x18847A240", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface TPPYNKEKCVK : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class IGGJNIPDGSW : TPPYNKEKCVK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile]
		private struct SumManyJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			[ReadOnly]
			public NativeArray<float> layer0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ReadOnly]
			public NativeArray<float> layer1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[ReadOnly]
			public NativeArray<float> layer2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[ReadOnly]
			public NativeArray<float> layer3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[ReadOnly]
			public NativeArray<float> layer4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			[ReadOnly]
			public NativeArray<float> layer5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			[ReadOnly]
			public NativeArray<float> layer6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			[ReadOnly]
			public NativeArray<float> layer7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public NativeArray<float> result;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float persistence;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x847C2F0", Offset = "0x847B2F0", VA = "0x18847C2F0", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84754A0", Offset = "0x84744A0", VA = "0x1884754A0")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TPPYNKEKCVK KCPUZIJEJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float2 FQCAELQMWSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float ZDVIXREKMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int UIKHWINDYKU;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84775A0", Offset = "0x84765A0", VA = "0x1884775A0")]
		public IGGJNIPDGSW(TPPYNKEKCVK a, float2 b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8477550", Offset = "0x8476550", VA = "0x188477550", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EXDCBOYSUYY : TPPYNKEKCVK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile]
		private struct MultiplyJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[ReadOnly]
			public NativeArray<float> Layer2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public NativeArray<float> Layer1AndOutput;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x847A310", Offset = "0x8479310", VA = "0x18847A310", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TPPYNKEKCVK MYIYHFUWFXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TPPYNKEKCVK MYOFEMOTPJA;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xACA870", Offset = "0xAC9870", VA = "0x180ACA870")]
		public EXDCBOYSUYY(TPPYNKEKCVK a, TPPYNKEKCVK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84766D0", Offset = "0x84756D0", VA = "0x1884766D0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ZMYWPJJTJYB : TPPYNKEKCVK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[BurstCompile]
		private struct RemapLayerJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public NativeArray<float> Layer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public float2 rangeFrom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public float2 rangeTo;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x847A530", Offset = "0x8479530", VA = "0x18847A530", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TPPYNKEKCVK KCPUZIJEJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private float2 YXNNHNLTTMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private float2 NUAAEUXMMIV;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x847CC10", Offset = "0x847BC10", VA = "0x18847CC10")]
		public ZMYWPJJTJYB(TPPYNKEKCVK a, float2 b, float2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x847CBC0", Offset = "0x847BBC0", VA = "0x18847CBC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class OCAJPXUAZCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile]
		private struct SumManyJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			[ReadOnly]
			public NativeArray<float> layer0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			[ReadOnly]
			public NativeArray<float> layer1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			[ReadOnly]
			public NativeArray<float> layer2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			[ReadOnly]
			public NativeArray<float> layer3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			[ReadOnly]
			public NativeArray<float> layer4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			[ReadOnly]
			public NativeArray<float> layer5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			[ReadOnly]
			public NativeArray<float> layer6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			[ReadOnly]
			public NativeArray<float> layer7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public NativeArray<float> result;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float persistence;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x847C100", Offset = "0x847B100", VA = "0x18847C100", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x84754C0", Offset = "0x84744C0", VA = "0x1884754C0")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class QJUDLBDGGKE : TPPYNKEKCVK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private SimplexState QEFCAGVVPNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float2 TCUGKQZBFOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float XUVSQZVZGJG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x847A3D0", Offset = "0x84793D0", VA = "0x18847A3D0")]
		public QJUDLBDGGKE(uint a, float2 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x847A3C0", Offset = "0x84793C0", VA = "0x18847A3C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CreateAssetMenu(menuName = "RecRoom/EnvironmentGen/TestTerrain")]
	public class TestTerrainAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float t1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float t2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float t3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float t4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float t5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AnimationCurve x1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AnimationCurve y1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AnimationCurve r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AnimationCurve x2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AnimationCurve y2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AnimationCurve r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int2 cells;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public float2 frequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int octaves;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x847C4E0", Offset = "0x847B4E0", VA = "0x18847C4E0")]
		public TPPYNKEKCVK GetTerrainGenerator(uint seed)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x847C940", Offset = "0x847B940", VA = "0x18847C940")]
		public TestTerrainAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class FYRPLMBKBWA : TPPYNKEKCVK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[BurstCompile]
		private struct CurveLayerJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			[ReadOnly]
			public NativeArray<float> CurveX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			[ReadOnly]
			public NativeArray<float> CurveY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			[ReadOnly]
			public NativeArray<float> CurveR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public NativeArray<float> Output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float2 scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float2 normalizedCenterPos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public int2 cells;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8476530", Offset = "0x8475530", VA = "0x188476530", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8475270", Offset = "0x8474270", VA = "0x188475270")]
			private float XZBXAXHJGYG(NativeArray<float> a, float b)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NativeArray<float> HICWKYQSLHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NativeArray<float> HIIDIFKPUTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NativeArray<float> HGCFMIZSUYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float2 NHLOAPVPNZU;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8476E20", Offset = "0x8475E20", VA = "0x188476E20")]
		public FYRPLMBKBWA(AnimationCurve a, float b, AnimationCurve c, float d, AnimationCurve e, float f, int g, float2 h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8476CD0", Offset = "0x8475CD0", VA = "0x188476CD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8476D30", Offset = "0x8475D30", VA = "0x188476D30")]
		private NativeArray<float> SSYPCRNSMZQ(AnimationCurve curve, float a, int b)
		{
			return default(NativeArray<float>);
		}
	}
}
namespace RecRoom.EnvironmentGen.Noise
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class YKAELEMDWHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[BurstCompile]
		public struct FillNoiseJob : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[ReadOnly]
			public SimplexState StateRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[ReadOnly]
			public SimplexParameters ParamsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public int Width;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int Height;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[NativeDisableParallelForRestriction]
			public NativeArray<float> HeightWO;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x84770B0", Offset = "0x84760B0", VA = "0x1884770B0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly float KKAWWHFLDMX;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly float DKETMPYXZNY;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x847CA80", Offset = "0x847BA80", VA = "0x18847CA80")]
		public static SimplexState BGVYMSLSNGY(uint a)
		{
			return default(SimplexState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SimplexParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float2 Frequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float Amplitude;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct SimplexState : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly NativeArray<int> Perm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly NativeArray<int> PermMod12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly NativeArray<float3> Grad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly float2 Offset;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x847BC30", Offset = "0x847AC30", VA = "0x18847BC30")]
		public SimplexState(uint seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x847BBA0", Offset = "0x847ABA0", VA = "0x18847BBA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.EnvironmentGen.LSystem
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class LSystemSymbol
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public List<float2> Scales;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float Length;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float3 AngleChange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LSystemStackAction StackAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public char Symbol;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x847A0E0", Offset = "0x84790E0", VA = "0x18847A0E0")]
		public LSystemSymbol()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class DeterministicLSystemRule
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public char FromSymbol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public string ToSymbols;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8476670", Offset = "0x8475670", VA = "0x188476670")]
		public DeterministicLSystemRule()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class StochasticChoice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float Chance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public string ToSymbols;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x847C030", Offset = "0x847B030", VA = "0x18847C030")]
		public StochasticChoice()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class StochasticLSystemRule
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public char FromSymbol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public List<StochasticChoice> Choices;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x847C080", Offset = "0x847B080", VA = "0x18847C080")]
		public StochasticLSystemRule()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CreateAssetMenu(fileName = "NewLSystem", menuName = "RecRoom/EnvironmentGen/LSystem")]
	public class LSystemAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public List<LSystemSymbol> Symbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public List<DeterministicLSystemRule> DeterministicRules;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public List<StochasticLSystemRule> StochasticRules;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public string InitialString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int PreviewIterations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int PreviewDetailLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public uint PreviewSeed;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8477600", Offset = "0x8476600", VA = "0x188477600")]
		public LSystemDefinition ToRuntimeDefinition()
		{
			return default(LSystemDefinition);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84783E0", Offset = "0x84773E0", VA = "0x1884783E0")]
		public LSystemAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum LSystemStackAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Push,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Pop
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct LSystemSymbolDefinition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public FixedList512Bytes<float2> Scales;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float Length;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public quaternion AngleChange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LSystemStackAction StackAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Color32 Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public char Symbol;
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct LSystemRule
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public char FromSymbol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FixedString64Bytes ToSymbols;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct LSystemStochasticRuleInfo : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NativeList<LSystemRule> StochasticRules;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NativeList<float> StochasticRuleChances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NativeList<int> StochasticRuleOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public NativeList<int> StochasticRuleLengths;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8479950", Offset = "0x8478950", VA = "0x188479950")]
		public LSystemStochasticRuleInfo(int initialCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84798C0", Offset = "0x84788C0", VA = "0x1884798C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct LSystemRulePerCharacterIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int RuleIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool Deterministic;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct LSystemDefinition : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NativeParallelHashMap<char, LSystemSymbolDefinition> Symbols;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NativeList<LSystemRule> DeterministicRules;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LSystemStochasticRuleInfo StochasticRules;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NativeArray<LSystemRulePerCharacterIndex> RulePerCharacterIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NativeList<char> StartingString;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8478F80", Offset = "0x8477F80", VA = "0x188478F80")]
		public LSystemDefinition(int symbolCapacity, int ruleCapacity, int startingStringCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8478EE0", Offset = "0x8477EE0", VA = "0x188478EE0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct LSystemBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private LSystemDefinition definition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private bool isFaulted;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8478E70", Offset = "0x8477E70", VA = "0x188478E70")]
		public LSystemBuilder(int symbolCapacity = 8, int ruleCapacity = 8, int startingStringCapacity = 16)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8478AD0", Offset = "0x8477AD0", VA = "0x188478AD0")]
		public LSystemBuilder IYGARHSTQMH(LSystemSymbolBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8478520", Offset = "0x8477520", VA = "0x188478520")]
		public LSystemBuilder CCLGNNUMXEB(char a, string b)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8478690", Offset = "0x8477690", VA = "0x188478690")]
		public LSystemBuilder DYXDQBHVVPO(LSystemStochasticRuleBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8478C70", Offset = "0x8477C70", VA = "0x188478C70")]
		public LSystemBuilder XHVSMSZSLIS(string a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8478D80", Offset = "0x8477D80", VA = "0x188478D80")]
		public bool YKIIYYHAQIT([Out] LSystemDefinition a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct LSystemSymbolBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private char symbol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private float2[]? scales;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private float? length;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private quaternion? angleChange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private LSystemStackAction? stackAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private Color32? color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool isFaulted;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x847A0A0", Offset = "0x84790A0", VA = "0x18847A0A0")]
		public LSystemSymbolBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8479D20", Offset = "0x8478D20", VA = "0x188479D20")]
		public LSystemSymbolBuilder GRFHLQXFPYA(float2[] a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8479F00", Offset = "0x8478F00", VA = "0x188479F00")]
		public LSystemSymbolBuilder PNOHLPCGCCD(float a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8479DC0", Offset = "0x8478DC0", VA = "0x188479DC0")]
		public LSystemSymbolBuilder KLCPMTFUQVQ(quaternion a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8479E70", Offset = "0x8478E70", VA = "0x188479E70")]
		public LSystemSymbolBuilder LSLBTJEIWNZ(LSystemStackAction a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8479F90", Offset = "0x8478F90", VA = "0x188479F90")]
		public LSystemSymbolBuilder TWVMWXDZIIG(Color32 a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8479A70", Offset = "0x8478A70", VA = "0x188479A70")]
		internal bool GQHYBKMVKHN([Out] LSystemSymbolDefinition a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LSystemStochasticRuleBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private char symbol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private List<(float, string)> rules;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8479840", Offset = "0x8478840", VA = "0x188479840")]
		public LSystemStochasticRuleBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84796C0", Offset = "0x84786C0", VA = "0x1884796C0")]
		public LSystemStochasticRuleBuilder DFBACFEXZBL(float a, string b)
		{
			return default(LSystemStochasticRuleBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84797E0", Offset = "0x84787E0", VA = "0x1884797E0")]
		internal (char, List<(float, string)>) LWYWLWEDKGZ()
		{
			return default((char, List<(float, string)>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class PNKYDFYNQXP
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[BurstCompile]
		private struct LSystemExecutorJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			[ReadOnly]
			public LSystemDefinition Definition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public int Iterations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public Unity.Mathematics.Random Random;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public NativeList<char> Result;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8479410", Offset = "0x8478410", VA = "0x188479410", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8479440", Offset = "0x8478440", VA = "0x188479440")]
			private void GXJXVXHNUGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8479180", Offset = "0x8478180", VA = "0x188479180")]
			private void AZOCROBWPAD(int a, LSystemRule b)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class VSOWATMWACF
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[BurstCompile]
		private struct RendererJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			[ReadOnly]
			public LSystemDefinition DefinitionRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[ReadOnly]
			public NativeArray<char> LSystemResultRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public NativeList<float3> VerticesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public NativeList<float3> NormalsRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public NativeList<Color32> ColorsRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public NativeList<int> IndicesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int LongitudinalDownResFactor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int TubePoints;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x847B250", Offset = "0x847A250", VA = "0x18847B250", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x847A6A0", Offset = "0x84796A0", VA = "0x18847A6A0")]
			private void DLVGSXFEXZZ(char a, NativeList<RigidTransform> b, RigidTransform c, NativeArray<float3> d, NativeArray<float3> e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x847B7C0", Offset = "0x847A7C0", VA = "0x18847B7C0")]
			private void UOODXWWLIBV([In] float3 basePos, [In] quaternion orientation, [In] float2 scale, [In] Color32 color, NativeArray<float3> a, NativeArray<float3> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x847A570", Offset = "0x8479570", VA = "0x18847A570")]
			private void DJJUKLLCZNH(int a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x847B6A0", Offset = "0x847A6A0", VA = "0x18847B6A0")]
			private void POAKRKXPTRS(int a, int b, int c, bool d)
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3001667561
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x847CC80", Offset = "0x847BC80", VA = "0x18847CC80")]
	public static void WGYJPSYGJZZ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x847CC70", Offset = "0x847BC70", VA = "0x18847CC70")]
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
