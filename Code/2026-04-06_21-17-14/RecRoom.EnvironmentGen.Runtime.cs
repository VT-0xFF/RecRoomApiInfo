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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x9989800", Offset = "0x9988800", VA = "0x189989800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9989330", Offset = "0x9988330", VA = "0x189989330", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.EnvironmentGen.Terrain
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KNQGCYDKDYC : WXBUPFEMUJJ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9985AF0", Offset = "0x9984AF0", VA = "0x189985AF0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WXBUPFEMUJJ IUMFCYIQVGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private WXBUPFEMUJJ IUGYFROTLUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private WXBUPFEMUJJ JHSXONRLCMV;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xDDB9F0", Offset = "0xDDA9F0", VA = "0x180DDB9F0")]
		public KNQGCYDKDYC(WXBUPFEMUJJ a, WXBUPFEMUJJ b, WXBUPFEMUJJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9986710", Offset = "0x9985710", VA = "0x189986710", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ZPFMHOCFCQW : WXBUPFEMUJJ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9986150", Offset = "0x9985150", VA = "0x189986150", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9985CD0", Offset = "0x9984CD0", VA = "0x189985CD0")]
			private void DHXYSMJEPRM(NativeArray<float> a, NativeArray<float> b, NativeList<CellToFall> c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private WXBUPFEMUJJ CNCEAMEXUFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private WXBUPFEMUJJ CKQYVQHGBTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int APRIDOHMJCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float YWYSYTVNOWM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x998C220", Offset = "0x998B220", VA = "0x18998C220")]
		public ZPFMHOCFCQW(WXBUPFEMUJJ a, WXBUPFEMUJJ b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x998C1C0", Offset = "0x998B1C0", VA = "0x18998C1C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface WXBUPFEMUJJ : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class YVAWEEJBQBP : WXBUPFEMUJJ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x998B5F0", Offset = "0x998A5F0", VA = "0x18998B5F0", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9984AA0", Offset = "0x9983AA0", VA = "0x189984AA0")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private WXBUPFEMUJJ XKBEDRMVPRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float2 IOXHNIBKKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float PYBGLNMQUOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int NQOUEAIHMYL;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x998C0B0", Offset = "0x998B0B0", VA = "0x18998C0B0")]
		public YVAWEEJBQBP(WXBUPFEMUJJ a, float2 b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x998C060", Offset = "0x998B060", VA = "0x18998C060", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class REYHKVKYJTJ : WXBUPFEMUJJ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x99893F0", Offset = "0x99883F0", VA = "0x1899893F0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private WXBUPFEMUJJ IUMFCYIQVGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private WXBUPFEMUJJ IUGYFROTLUX;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		public REYHKVKYJTJ(WXBUPFEMUJJ a, WXBUPFEMUJJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9989880", Offset = "0x9988880", VA = "0x189989880", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ZOWAKBZCLLS : WXBUPFEMUJJ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9989A20", Offset = "0x9988A20", VA = "0x189989A20", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private WXBUPFEMUJJ XKBEDRMVPRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private float2 MNOAZZIFFPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private float2 JFSINFRYCHI;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x998C160", Offset = "0x998B160", VA = "0x18998C160")]
		public ZOWAKBZCLLS(WXBUPFEMUJJ a, float2 b, float2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x998C110", Offset = "0x998B110", VA = "0x18998C110", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class WEHUTZYIOWQ
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
			[Cpp2IlInjected.Address(RVA = "0x998B7E0", Offset = "0x998A7E0", VA = "0x18998B7E0", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9984AC0", Offset = "0x9983AC0", VA = "0x189984AC0")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class USZLSSDJEEB : WXBUPFEMUJJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private SimplexState UXUXFKMYEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float2 KUDZUUUHJDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float YHKAABCLMHB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x998BF80", Offset = "0x998AF80", VA = "0x18998BF80")]
		public USZLSSDJEEB(uint a, float2 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x998BF70", Offset = "0x998AF70", VA = "0x18998BF70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x998B9D0", Offset = "0x998A9D0", VA = "0x18998B9D0")]
		public WXBUPFEMUJJ GetTerrainGenerator(uint seed)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x998BE30", Offset = "0x998AE30", VA = "0x18998BE30")]
		public TestTerrainAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class NZCWTPYBVAT : WXBUPFEMUJJ, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9985B30", Offset = "0x9984B30", VA = "0x189985B30", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9984870", Offset = "0x9983870", VA = "0x189984870")]
			private float JTUZFXXRDOB(NativeArray<float> a, float b)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NativeArray<float> JOQLUGDLRAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NativeArray<float> JOLEWZJOHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NativeArray<float> JNKWKROBMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float2 AQDYEGOWAGX;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9989570", Offset = "0x9988570", VA = "0x189989570")]
		public NZCWTPYBVAT(AnimationCurve a, float b, AnimationCurve c, float d, AnimationCurve e, float f, int g, float2 h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9989420", Offset = "0x9988420", VA = "0x189989420", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9989480", Offset = "0x9988480", VA = "0x189989480")]
		private NativeArray<float> FDLTWWDMWID(AnimationCurve curve, float a, int b)
		{
			return default(NativeArray<float>);
		}
	}
}
namespace RecRoom.EnvironmentGen.Noise
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class RJAJQHINHLU
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
			[Cpp2IlInjected.Address(RVA = "0x9986270", Offset = "0x9985270", VA = "0x189986270", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly float VKVKRTMNQTI;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly float CKROBKTAUSH;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99898E0", Offset = "0x99888E0", VA = "0x1899898E0")]
		public static SimplexState GBTUROFTQMF(uint a)
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
		[Cpp2IlInjected.Address(RVA = "0x998B120", Offset = "0x998A120", VA = "0x18998B120")]
		public SimplexState(uint seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x998B090", Offset = "0x998A090", VA = "0x18998B090", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9989290", Offset = "0x9988290", VA = "0x189989290")]
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
		[Cpp2IlInjected.Address(RVA = "0x9985C70", Offset = "0x9984C70", VA = "0x189985C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x998B520", Offset = "0x998A520", VA = "0x18998B520")]
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
		[Cpp2IlInjected.Address(RVA = "0x998B570", Offset = "0x998A570", VA = "0x18998B570")]
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
		[Cpp2IlInjected.Address(RVA = "0x9986790", Offset = "0x9985790", VA = "0x189986790")]
		public LSystemDefinition ToRuntimeDefinition()
		{
			return default(LSystemDefinition);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9987570", Offset = "0x9986570", VA = "0x189987570")]
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
		[Cpp2IlInjected.Address(RVA = "0x9988AF0", Offset = "0x9987AF0", VA = "0x189988AF0")]
		public LSystemStochasticRuleInfo(int initialCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9988A60", Offset = "0x9987A60", VA = "0x189988A60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9988120", Offset = "0x9987120", VA = "0x189988120")]
		public LSystemDefinition(int symbolCapacity, int ruleCapacity, int startingStringCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9988080", Offset = "0x9987080", VA = "0x189988080", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9988010", Offset = "0x9987010", VA = "0x189988010")]
		public LSystemBuilder(int symbolCapacity = 8, int ruleCapacity = 8, int startingStringCapacity = 16)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9987830", Offset = "0x9986830", VA = "0x189987830")]
		public LSystemBuilder EWSQKNKIPDQ(LSystemSymbolBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9987E10", Offset = "0x9986E10", VA = "0x189987E10")]
		public LSystemBuilder RYNVTXZKYDA(char a, string b)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99879D0", Offset = "0x99869D0", VA = "0x1899879D0")]
		public LSystemBuilder LBOOPMDNYIP(LSystemStochasticRuleBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99876B0", Offset = "0x99866B0", VA = "0x1899876B0")]
		public LSystemBuilder BFSQMOZENTN(string a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99877C0", Offset = "0x99867C0", VA = "0x1899877C0")]
		public bool DABAVPDWOAK([Out] LSystemDefinition a)
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
		[Cpp2IlInjected.Address(RVA = "0x9989250", Offset = "0x9988250", VA = "0x189989250")]
		public LSystemSymbolBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9988FE0", Offset = "0x9987FE0", VA = "0x189988FE0")]
		public LSystemSymbolBuilder UWDTSRCAXHX(float2[] a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9988CA0", Offset = "0x9987CA0", VA = "0x189988CA0")]
		public LSystemSymbolBuilder OIELVYPNNGG(float a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9989110", Offset = "0x9988110", VA = "0x189989110")]
		public LSystemSymbolBuilder ZZEWLARTPAF(quaternion a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9989080", Offset = "0x9988080", VA = "0x189989080")]
		public LSystemSymbolBuilder WBXRTNFQTPW(LSystemStackAction a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9988C10", Offset = "0x9987C10", VA = "0x189988C10")]
		public LSystemSymbolBuilder JLVLHZTSABD(Color32 a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9988D30", Offset = "0x9987D30", VA = "0x189988D30")]
		internal bool PSMFBXVSOMA([Out] LSystemSymbolDefinition a)
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
		[Cpp2IlInjected.Address(RVA = "0x99889E0", Offset = "0x99879E0", VA = "0x1899889E0")]
		public LSystemStochasticRuleBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x99888C0", Offset = "0x99878C0", VA = "0x1899888C0")]
		public LSystemStochasticRuleBuilder EDOXCIDVQDW(float a, string b)
		{
			return default(LSystemStochasticRuleBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9988860", Offset = "0x9987860", VA = "0x189988860")]
		internal (char, List<(float, string)>) AGHJCLARBYG()
		{
			return default((char, List<(float, string)>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class BIMADUESNWK
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
			[Cpp2IlInjected.Address(RVA = "0x9988320", Offset = "0x9987320", VA = "0x189988320", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x99885E0", Offset = "0x99875E0", VA = "0x1899885E0")]
			private void WJWWMFNLTGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9988350", Offset = "0x9987350", VA = "0x189988350")]
			private void RTGDTURGULC(int a, LSystemRule b)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class QEHTORBMIXY
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
			[Cpp2IlInjected.Address(RVA = "0x9989A60", Offset = "0x9988A60", VA = "0x189989A60", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x998A4E0", Offset = "0x99894E0", VA = "0x18998A4E0")]
			private void ZAMQFITYMKI(char a, NativeList<RigidTransform> b, RigidTransform c, NativeArray<float3> d, NativeArray<float3> e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9989EB0", Offset = "0x9988EB0", VA = "0x189989EB0")]
			private void LAVOVYTTXXC([In] float3 basePos, [In] quaternion orientation, [In] float2 scale, [In] Color32 color, NativeArray<float3> a, NativeArray<float3> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x998A290", Offset = "0x9989290", VA = "0x18998A290")]
			private void LZSRRWIXUKI(int a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x998A3C0", Offset = "0x99893C0", VA = "0x18998A3C0")]
			private void RFRILQEHHTJ(int a, int b, int c, bool d)
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3305695765
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x998C2A0", Offset = "0x998B2A0", VA = "0x18998C2A0")]
	public static void PQMGTAMPKVS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x998C290", Offset = "0x998B290", VA = "0x18998C290")]
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
