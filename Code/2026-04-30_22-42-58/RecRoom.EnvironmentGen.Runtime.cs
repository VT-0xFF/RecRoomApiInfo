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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x976C9B0", Offset = "0x976BDB0", VA = "0x18976C9B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x976C790", Offset = "0x976BB90", VA = "0x18976C790", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.EnvironmentGen.Terrain
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class QWXPOHHXITQ : RTUOWFGJPTZ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9768D50", Offset = "0x9768150", VA = "0x189768D50", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private RTUOWFGJPTZ AVWUIFWZJYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RTUOWFGJPTZ AVRNKZDCAMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private RTUOWFGJPTZ GSXMPQIEGYN;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xDE3B70", Offset = "0xDE2F70", VA = "0x180DE3B70")]
		public QWXPOHHXITQ(RTUOWFGJPTZ a, RTUOWFGJPTZ b, RTUOWFGJPTZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x976CE10", Offset = "0x976C210", VA = "0x18976CE10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MNFSYBZGMWS : RTUOWFGJPTZ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9768FE0", Offset = "0x97683E0", VA = "0x189768FE0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9769100", Offset = "0x9768500", VA = "0x189769100")]
			private void KTKHQIFJPDY(NativeArray<float> a, NativeArray<float> b, NativeList<CellToFall> c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private RTUOWFGJPTZ RNBASCBQNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private RTUOWFGJPTZ MZAXTGNLEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int DQKIFBOATWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float KQUFTBZCFUE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x976C8B0", Offset = "0x976BCB0", VA = "0x18976C8B0")]
		public MNFSYBZGMWS(RTUOWFGJPTZ a, RTUOWFGJPTZ b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x976C850", Offset = "0x976BC50", VA = "0x18976C850", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface RTUOWFGJPTZ : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class CRNCXPYBAEJ : RTUOWFGJPTZ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x976EC50", Offset = "0x976E050", VA = "0x18976EC50", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9767D00", Offset = "0x9767100", VA = "0x189767D00")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private RTUOWFGJPTZ TFBOAYWZJTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float2 DLUUBEMTCRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float MDINOCCXADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int OAGGSSXKTYP;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9768DE0", Offset = "0x97681E0", VA = "0x189768DE0")]
		public CRNCXPYBAEJ(RTUOWFGJPTZ a, float2 b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9768D90", Offset = "0x9768190", VA = "0x189768D90", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class NLHGUEVQUXN : RTUOWFGJPTZ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x976C920", Offset = "0x976BD20", VA = "0x18976C920", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private RTUOWFGJPTZ AVWUIFWZJYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private RTUOWFGJPTZ AVRNKZDCAMT;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCFB220", Offset = "0xCFA620", VA = "0x180CFB220")]
		public NLHGUEVQUXN(RTUOWFGJPTZ a, RTUOWFGJPTZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x976C950", Offset = "0x976BD50", VA = "0x18976C950", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class JUYRLOMEMDW : RTUOWFGJPTZ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x976CE90", Offset = "0x976C290", VA = "0x18976CE90", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private RTUOWFGJPTZ TFBOAYWZJTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private float2 HDWAWWZWTYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private float2 TKDGIAOIIJE;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9769BB0", Offset = "0x9768FB0", VA = "0x189769BB0")]
		public JUYRLOMEMDW(RTUOWFGJPTZ a, float2 b, float2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9769B60", Offset = "0x9768F60", VA = "0x189769B60", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CRAVPDYLLIY
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
			[Cpp2IlInjected.Address(RVA = "0x976EA60", Offset = "0x976DE60", VA = "0x18976EA60", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9767D20", Offset = "0x9767120", VA = "0x189767D20")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class VHBLNALEHLP : RTUOWFGJPTZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private SimplexState OWGWIMZRHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float2 GKHWJRJEMKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float FDHTSWPWYLJ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x976F3F0", Offset = "0x976E7F0", VA = "0x18976F3F0")]
		public VHBLNALEHLP(uint a, float2 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x976F3E0", Offset = "0x976E7E0", VA = "0x18976F3E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x976EE40", Offset = "0x976E240", VA = "0x18976EE40")]
		public RTUOWFGJPTZ GetTerrainGenerator(uint seed)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x976F2A0", Offset = "0x976E6A0", VA = "0x18976F2A0")]
		public TestTerrainAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class OSITBJQCDVZ : RTUOWFGJPTZ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9768E40", Offset = "0x9768240", VA = "0x189768E40", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9767AD0", Offset = "0x9766ED0", VA = "0x189767AD0")]
			private float QDJMXPISWZH(NativeArray<float> a, float b)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NativeArray<float> LIKYLTCTUSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NativeArray<float> LIFROMIWLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NativeArray<float> LKLPKITTLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float2 BMSARKMPINR;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x976CB80", Offset = "0x976BF80", VA = "0x18976CB80")]
		public OSITBJQCDVZ(AnimationCurve a, float b, AnimationCurve c, float d, AnimationCurve e, float f, int g, float2 h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x976CB20", Offset = "0x976BF20", VA = "0x18976CB20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x976CA30", Offset = "0x976BE30", VA = "0x18976CA30")]
		private NativeArray<float> AGWMBGQYSNJ(AnimationCurve curve, float a, int b)
		{
			return default(NativeArray<float>);
		}
	}
}
namespace RecRoom.EnvironmentGen.Noise
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class GLAVUJRUFCW
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
			[Cpp2IlInjected.Address(RVA = "0x9769580", Offset = "0x9768980", VA = "0x189769580", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly float UBGSKFDCLCG;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly float BBCVTWJPPBF;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9769A20", Offset = "0x9768E20", VA = "0x189769A20")]
		public static SimplexState TVNHJJBPFLT(uint a)
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
		[Cpp2IlInjected.Address(RVA = "0x976E590", Offset = "0x976D990", VA = "0x18976E590")]
		public SimplexState(uint seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x976E500", Offset = "0x976D900", VA = "0x18976E500", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x976C6F0", Offset = "0x976BAF0", VA = "0x18976C6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9768F80", Offset = "0x9768380", VA = "0x189768F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x976E990", Offset = "0x976DD90", VA = "0x18976E990")]
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
		[Cpp2IlInjected.Address(RVA = "0x976E9E0", Offset = "0x976DDE0", VA = "0x18976E9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9769C10", Offset = "0x9769010", VA = "0x189769C10")]
		public LSystemDefinition ToRuntimeDefinition()
		{
			return default(LSystemDefinition);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x976A9F0", Offset = "0x9769DF0", VA = "0x18976A9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x976BF60", Offset = "0x976B360", VA = "0x18976BF60")]
		public LSystemStochasticRuleInfo(int initialCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x976BED0", Offset = "0x976B2D0", VA = "0x18976BED0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x976B590", Offset = "0x976A990", VA = "0x18976B590")]
		public LSystemDefinition(int symbolCapacity, int ruleCapacity, int startingStringCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x976B4F0", Offset = "0x976A8F0", VA = "0x18976B4F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x976B480", Offset = "0x976A880", VA = "0x18976B480")]
		public LSystemBuilder(int symbolCapacity = 8, int ruleCapacity = 8, int startingStringCapacity = 16)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x976AFE0", Offset = "0x976A3E0", VA = "0x18976AFE0")]
		public LSystemBuilder HSAHIFYTZKC(LSystemSymbolBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x976B290", Offset = "0x976A690", VA = "0x18976B290")]
		public LSystemBuilder RASDNRYGYIG(char a, string b)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x976ABA0", Offset = "0x9769FA0", VA = "0x18976ABA0")]
		public LSystemBuilder HKKYZEVWYGT(LSystemStochasticRuleBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x976B180", Offset = "0x976A580", VA = "0x18976B180")]
		public LSystemBuilder OVURNCNQPBB(string a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x976AB30", Offset = "0x9769F30", VA = "0x18976AB30")]
		public bool DERBJQTKHPY([Out] LSystemDefinition a)
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
		[Cpp2IlInjected.Address(RVA = "0x976C6B0", Offset = "0x976BAB0", VA = "0x18976C6B0")]
		public LSystemSymbolBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x976C590", Offset = "0x976B990", VA = "0x18976C590")]
		public LSystemSymbolBuilder XCFGJNXPISF(float2[] a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x976C500", Offset = "0x976B900", VA = "0x18976C500")]
		public LSystemSymbolBuilder SNVZGOGXKXQ(float a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x976C3C0", Offset = "0x976B7C0", VA = "0x18976C3C0")]
		public LSystemSymbolBuilder PASDPGPMKLL(quaternion a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x976C470", Offset = "0x976B870", VA = "0x18976C470")]
		public LSystemSymbolBuilder QTZCEAKOSDK(LSystemStackAction a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x976C080", Offset = "0x976B480", VA = "0x18976C080")]
		public LSystemSymbolBuilder CWSFOVQWKPH(Color32 a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x976C110", Offset = "0x976B510", VA = "0x18976C110")]
		internal bool OXQQIBRJYYA([Out] LSystemSymbolDefinition a)
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
		[Cpp2IlInjected.Address(RVA = "0x976BE50", Offset = "0x976B250", VA = "0x18976BE50")]
		public LSystemStochasticRuleBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x976BD30", Offset = "0x976B130", VA = "0x18976BD30")]
		public LSystemStochasticRuleBuilder KVEGLERWCEE(float a, string b)
		{
			return default(LSystemStochasticRuleBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x976BCD0", Offset = "0x976B0D0", VA = "0x18976BCD0")]
		internal (char, List<(float, string)>) DNLPUVDOSYS()
		{
			return default((char, List<(float, string)>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class UBBYZRIDNRM
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
			[Cpp2IlInjected.Address(RVA = "0x976BA20", Offset = "0x976AE20", VA = "0x18976BA20", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x976BA50", Offset = "0x976AE50", VA = "0x18976BA50")]
			private void VEZVZTUGFFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x976B790", Offset = "0x976AB90", VA = "0x18976B790")]
			private void BVNDMHSNQTC(int a, LSystemRule b)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class GERZSJIRYZE
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
			[Cpp2IlInjected.Address(RVA = "0x976CED0", Offset = "0x976C2D0", VA = "0x18976CED0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x976D950", Offset = "0x976CD50", VA = "0x18976D950")]
			private void WNIPHHFFARC(char a, NativeList<RigidTransform> b, RigidTransform c, NativeArray<float3> d, NativeArray<float3> e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x976D320", Offset = "0x976C720", VA = "0x18976D320")]
			private void GVKBTLHQZLS([In] float3 basePos, [In] quaternion orientation, [In] float2 scale, [In] Color32 color, NativeArray<float3> a, NativeArray<float3> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x976D700", Offset = "0x976CB00", VA = "0x18976D700")]
			private void NZSSWPTNNHK(int a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x976D830", Offset = "0x976CC30", VA = "0x18976D830")]
			private void PFMRCDMBZFV(int a, int b, int c, bool d)
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3377407584
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x976F4E0", Offset = "0x976E8E0", VA = "0x18976F4E0")]
	public static void ZGEXVVNGJIY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x976F4D0", Offset = "0x976E8D0", VA = "0x18976F4D0")]
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
