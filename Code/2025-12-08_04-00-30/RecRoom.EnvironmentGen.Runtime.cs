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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82228C0", Offset = "0x82210C0", VA = "0x1882228C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8222770", Offset = "0x8220F70", VA = "0x188222770", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.EnvironmentGen.Terrain
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class QLETRJWBFQT : JMWEVQVQECM, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x821ECF0", Offset = "0x821D4F0", VA = "0x18821ECF0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private JMWEVQVQECM DUUWLAGIUST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private JMWEVQVQECM DVADIHAGEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private JMWEVQVQECM VBRPUIEXFKS;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB28F10", Offset = "0xB27710", VA = "0x180B28F10")]
		public QLETRJWBFQT(JMWEVQVQECM a, JMWEVQVQECM b, JMWEVQVQECM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8222940", Offset = "0x8221140", VA = "0x188222940", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AEQNHWXIVBJ : JMWEVQVQECM, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x821EF80", Offset = "0x821D780", VA = "0x18821EF80", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x821F0A0", Offset = "0x821D8A0", VA = "0x18821F0A0")]
			private void RSCBVPGMCNP(NativeArray<float> a, NativeArray<float> b, NativeList<CellToFall> c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private JMWEVQVQECM ZFCZAFCSUOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private JMWEVQVQECM UITRDMPICFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int NRNODHQLFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float LTDRKVFGUGL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x821EBD0", Offset = "0x821D3D0", VA = "0x18821EBD0")]
		public AEQNHWXIVBJ(JMWEVQVQECM a, JMWEVQVQECM b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x821EB70", Offset = "0x821D370", VA = "0x18821EB70", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface JMWEVQVQECM : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class CPAAYXUPOHA : JMWEVQVQECM, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8224590", Offset = "0x8222D90", VA = "0x188224590", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x821DB20", Offset = "0x821C320", VA = "0x18821DB20")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private JMWEVQVQECM IUEEIFBKKQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float2 WULMFUHKRET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float ZKVUJZEDYLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int BODROOBCMOI;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x821ED80", Offset = "0x821D580", VA = "0x18821ED80")]
		public CPAAYXUPOHA(JMWEVQVQECM a, float2 b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x821ED30", Offset = "0x821D530", VA = "0x18821ED30", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class NJPMVISPITO : JMWEVQVQECM, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8222830", Offset = "0x8221030", VA = "0x188222830", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private JMWEVQVQECM DUUWLAGIUST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private JMWEVQVQECM DVADIHAGEEC;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA71B0", Offset = "0xAA59B0", VA = "0x180AA71B0")]
		public NJPMVISPITO(JMWEVQVQECM a, JMWEVQVQECM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8222860", Offset = "0x8221060", VA = "0x188222860", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class BVEMRQUPMEZ : JMWEVQVQECM, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x82229C0", Offset = "0x82211C0", VA = "0x1882229C0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private JMWEVQVQECM IUEEIFBKKQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private float2 PBKFIELIFSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private float2 COILMRVARRT;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x821EC90", Offset = "0x821D490", VA = "0x18821EC90")]
		public BVEMRQUPMEZ(JMWEVQVQECM a, float2 b, float2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x821EC40", Offset = "0x821D440", VA = "0x18821EC40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PUDVVKDONHN
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
			[Cpp2IlInjected.Address(RVA = "0x8224780", Offset = "0x8222F80", VA = "0x188224780", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x821DB40", Offset = "0x821C340", VA = "0x18821DB40")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class GIAYEVSDHGE : JMWEVQVQECM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private SimplexState TCCKWBWQIRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float2 LAUJZWDCWOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float QSLWSGWXKQE;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x821FB10", Offset = "0x821E310", VA = "0x18821FB10")]
		public GIAYEVSDHGE(uint a, float2 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x821FB00", Offset = "0x821E300", VA = "0x18821FB00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8224970", Offset = "0x8223170", VA = "0x188224970")]
		public JMWEVQVQECM GetTerrainGenerator(uint seed)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8224DD0", Offset = "0x82235D0", VA = "0x188224DD0")]
		public TestTerrainAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class UYOXPDDWJGE : JMWEVQVQECM, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x821EDE0", Offset = "0x821D5E0", VA = "0x18821EDE0", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x821D8F0", Offset = "0x821C0F0", VA = "0x18821D8F0")]
			private float LCUTCLFFCRY(NativeArray<float> a, float b)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NativeArray<float> CTUTQAVOWLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NativeArray<float> CUAANHPMFXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NativeArray<float> CRUCRLEPGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float2 XYAQQFYTUBU;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8225060", Offset = "0x8223860", VA = "0x188225060")]
		public UYOXPDDWJGE(AnimationCurve a, float b, AnimationCurve c, float d, AnimationCurve e, float f, int g, float2 h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8224F10", Offset = "0x8223710", VA = "0x188224F10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8224F70", Offset = "0x8223770", VA = "0x188224F70")]
		private NativeArray<float> PRQAKYMVSOC(AnimationCurve curve, float a, int b)
		{
			return default(NativeArray<float>);
		}
	}
}
namespace RecRoom.EnvironmentGen.Noise
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class GFHTEMSBQAP
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
			[Cpp2IlInjected.Address(RVA = "0x821F520", Offset = "0x821DD20", VA = "0x18821F520", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly float VRINUPQGPFZ;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly float ORMKKYJTLHA;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x821F9C0", Offset = "0x821E1C0", VA = "0x18821F9C0")]
		public static SimplexState DCXYIGLUHNO(uint a)
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
		[Cpp2IlInjected.Address(RVA = "0x82240C0", Offset = "0x82228C0", VA = "0x1882240C0")]
		public SimplexState(uint seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8224030", Offset = "0x8222830", VA = "0x188224030", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x82226D0", Offset = "0x8220ED0", VA = "0x1882226D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x821EF20", Offset = "0x821D720", VA = "0x18821EF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x82244C0", Offset = "0x8222CC0", VA = "0x1882244C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8224510", Offset = "0x8222D10", VA = "0x188224510")]
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
		[Cpp2IlInjected.Address(RVA = "0x821FBF0", Offset = "0x821E3F0", VA = "0x18821FBF0")]
		public LSystemDefinition ToRuntimeDefinition()
		{
			return default(LSystemDefinition);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82209D0", Offset = "0x821F1D0", VA = "0x1882209D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8221F40", Offset = "0x8220740", VA = "0x188221F40")]
		public LSystemStochasticRuleInfo(int initialCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8221EB0", Offset = "0x82206B0", VA = "0x188221EB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8221570", Offset = "0x821FD70", VA = "0x188221570")]
		public LSystemDefinition(int symbolCapacity, int ruleCapacity, int startingStringCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82214D0", Offset = "0x821FCD0", VA = "0x1882214D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8221460", Offset = "0x821FC60", VA = "0x188221460")]
		public LSystemBuilder(int symbolCapacity = 8, int ruleCapacity = 8, int startingStringCapacity = 16)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82211D0", Offset = "0x821F9D0", VA = "0x1882211D0")]
		public LSystemBuilder KBXDYZTKYMT(LSystemSymbolBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8220F50", Offset = "0x821F750", VA = "0x188220F50")]
		public LSystemBuilder DFMXCVZIFBL(char a, string b)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8220B10", Offset = "0x821F310", VA = "0x188220B10")]
		public LSystemBuilder AZESPCRGSME(LSystemStochasticRuleBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82210C0", Offset = "0x821F8C0", VA = "0x1882210C0")]
		public LSystemBuilder DRHDRLQVTCK(string a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8221370", Offset = "0x821FB70", VA = "0x188221370")]
		public bool VPFWIIDEGVF([Out] LSystemDefinition a)
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
		[Cpp2IlInjected.Address(RVA = "0x8222690", Offset = "0x8220E90", VA = "0x188222690")]
		public LSystemSymbolBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8222060", Offset = "0x8220860", VA = "0x188222060")]
		public LSystemSymbolBuilder FQTVBMKFROI(float2[] a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8222580", Offset = "0x8220D80", VA = "0x188222580")]
		public LSystemSymbolBuilder XTJJGIKGHCT(float a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8222190", Offset = "0x8220990", VA = "0x188222190")]
		public LSystemSymbolBuilder KWEYGEQLQQG(quaternion a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82224F0", Offset = "0x8220CF0", VA = "0x1882224F0")]
		public LSystemSymbolBuilder OOLMXOBPGHB(LSystemStackAction a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8222100", Offset = "0x8220900", VA = "0x188222100")]
		public LSystemSymbolBuilder KTWTKULXLWK(Color32 a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8222240", Offset = "0x8220A40", VA = "0x188222240")]
		internal bool LYFVVQFYHTV([Out] LSystemSymbolDefinition a)
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
		[Cpp2IlInjected.Address(RVA = "0x8221E30", Offset = "0x8220630", VA = "0x188221E30")]
		public LSystemStochasticRuleBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8221D10", Offset = "0x8220510", VA = "0x188221D10")]
		public LSystemStochasticRuleBuilder NVHWTSSBRUR(float a, string b)
		{
			return default(LSystemStochasticRuleBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8221CB0", Offset = "0x82204B0", VA = "0x188221CB0")]
		internal (char, List<(float, string)>) FTRAESWLGER()
		{
			return default((char, List<(float, string)>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class QSQJJESKZEN
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
			[Cpp2IlInjected.Address(RVA = "0x8221C80", Offset = "0x8220480", VA = "0x188221C80", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8221A00", Offset = "0x8220200", VA = "0x188221A00")]
			private void CLHFWBKDFVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8221770", Offset = "0x821FF70", VA = "0x188221770")]
			private void BPDCWEIXXIP(int a, LSystemRule b)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class EZPJMBWPJZX
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
			[Cpp2IlInjected.Address(RVA = "0x8222A00", Offset = "0x8221200", VA = "0x188222A00", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8223480", Offset = "0x8221C80", VA = "0x188223480")]
			private void ZCIQKYZBZEP(char a, NativeList<RigidTransform> b, RigidTransform c, NativeArray<float3> d, NativeArray<float3> e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8222F80", Offset = "0x8221780", VA = "0x188222F80")]
			private void NHKTOOIJRDR([In] float3 basePos, [In] quaternion orientation, [In] float2 scale, [In] Color32 color, NativeArray<float3> a, NativeArray<float3> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8222E50", Offset = "0x8221650", VA = "0x188222E50")]
			private void HRIYTPXUYUZ(int a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8223360", Offset = "0x8221B60", VA = "0x188223360")]
			private void QZSSIGGASLO(int a, int b, int c, bool d)
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2843929758
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8225300", Offset = "0x8223B00", VA = "0x188225300")]
	public static void JTEJSBRAGJR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82252F0", Offset = "0x8223AF0", VA = "0x1882252F0")]
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
