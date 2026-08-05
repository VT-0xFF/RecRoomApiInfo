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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FE000", Offset = "0x86FD000", VA = "0x1886FE000")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FDE20", Offset = "0x86FCE20", VA = "0x1886FDE20", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.EnvironmentGen.Terrain
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HGCJMXFDKGN : RKRCMOBPJVU, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x86FA3D0", Offset = "0x86F93D0", VA = "0x1886FA3D0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private RKRCMOBPJVU PWOIGIOEZXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RKRCMOBPJVU PVYNOOGMXPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private RKRCMOBPJVU OYDTJCBJRHK;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE84FF0", Offset = "0xE83FF0", VA = "0x180E84FF0")]
		public HGCJMXFDKGN(RKRCMOBPJVU a, RKRCMOBPJVU b, RKRCMOBPJVU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86FB130", Offset = "0x86FA130", VA = "0x1886FB130", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class IPPDWLVGAXD : RKRCMOBPJVU, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x86FA5B0", Offset = "0x86F95B0", VA = "0x1886FA5B0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x86FA6D0", Offset = "0x86F96D0", VA = "0x1886FA6D0")]
			private void QHYLCFHJWMD(NativeArray<float> a, NativeArray<float> b, NativeList<CellToFall> c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private RKRCMOBPJVU HVLGXOKVSUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private RKRCMOBPJVU UTVNLFMBTRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int EBRCTEZPUJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float NTXWDSOJPJH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86FB210", Offset = "0x86FA210", VA = "0x1886FB210")]
		public IPPDWLVGAXD(RKRCMOBPJVU a, RKRCMOBPJVU b, int c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86FB1B0", Offset = "0x86FA1B0", VA = "0x1886FB1B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface RKRCMOBPJVU : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class QNUMBGDUEDS : RKRCMOBPJVU, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x86FFF50", Offset = "0x86FEF50", VA = "0x1886FFF50", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x86F8EF0", Offset = "0x86F7EF0", VA = "0x1886F8EF0")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private RKRCMOBPJVU AOLYLPESHIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float2 URNAAIMVOXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private float HKTJTSVVNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int HLYSSQNPXCW;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86FE0D0", Offset = "0x86FD0D0", VA = "0x1886FE0D0")]
		public QNUMBGDUEDS(RKRCMOBPJVU a, float2 b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86FE080", Offset = "0x86FD080", VA = "0x1886FE080", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RRIZXXIAEVA : RKRCMOBPJVU, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x86FDFD0", Offset = "0x86FCFD0", VA = "0x1886FDFD0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private RKRCMOBPJVU PWOIGIOEZXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private RKRCMOBPJVU PVYNOOGMXPW;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAD9FF0", Offset = "0xAD8FF0", VA = "0x180AD9FF0")]
		public RRIZXXIAEVA(RKRCMOBPJVU a, RKRCMOBPJVU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86FE130", Offset = "0x86FD130", VA = "0x1886FE130", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class BZIYANBOLSH : RKRCMOBPJVU, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x86FE190", Offset = "0x86FD190", VA = "0x1886FE190", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private RKRCMOBPJVU AOLYLPESHIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private float2 YHLURMMNBDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private float2 CXFRAOTCWVZ;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86FA370", Offset = "0x86F9370", VA = "0x1886FA370")]
		public BZIYANBOLSH(RKRCMOBPJVU a, float2 b, float2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86FA320", Offset = "0x86F9320", VA = "0x1886FA320", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HMONIRLDNHL
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
			[Cpp2IlInjected.Address(RVA = "0x86FFD60", Offset = "0x86FED60", VA = "0x1886FFD60", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x86F8F10", Offset = "0x86F7F10", VA = "0x1886F8F10")]
			private float Get(NativeArray<float> layer, int index, float magnitude)
			{
				return default(float);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class MGWKHRKNVLA : RKRCMOBPJVU, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private SimplexState JGOOKRUQTHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float2 AQLAQPLSJYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float TVYMPEWPCNU;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86FDEF0", Offset = "0x86FCEF0", VA = "0x1886FDEF0")]
		public MGWKHRKNVLA(uint a, float2 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86FDEE0", Offset = "0x86FCEE0", VA = "0x1886FDEE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8700140", Offset = "0x86FF140", VA = "0x188700140")]
		public RKRCMOBPJVU GetTerrainGenerator(uint seed)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x87005A0", Offset = "0x86FF5A0", VA = "0x1887005A0")]
		public TestTerrainAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BYJPZWIQQTE : RKRCMOBPJVU, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x86FA410", Offset = "0x86F9410", VA = "0x1886FA410", Slot = "4")]
			public void Execute(int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x86F8CC0", Offset = "0x86F7CC0", VA = "0x1886F8CC0")]
			private float WPULGVFJPEE(NativeArray<float> a, float b)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NativeArray<float> FLNNUQAQZLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NativeArray<float> FLSURWUOIXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NativeArray<float> FKHYLBLGUVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float2 HUWKYCPVHCI;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86FA090", Offset = "0x86F9090", VA = "0x1886FA090")]
		public BYJPZWIQQTE(AnimationCurve a, float b, AnimationCurve c, float d, AnimationCurve e, float f, int g, float2 h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86F9F40", Offset = "0x86F8F40", VA = "0x1886F9F40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86F9FA0", Offset = "0x86F8FA0", VA = "0x1886F9FA0")]
		private NativeArray<float> USPHPNGIFHC(AnimationCurve curve, float a, int b)
		{
			return default(NativeArray<float>);
		}
	}
}
namespace RecRoom.EnvironmentGen.Noise
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class GVNNIZMKGIV
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
			[Cpp2IlInjected.Address(RVA = "0x86FAB50", Offset = "0x86F9B50", VA = "0x1886FAB50", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly float BOYRWYCICKJ;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly float UNMLJESQAYQ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86FAFF0", Offset = "0x86F9FF0", VA = "0x1886FAFF0")]
		public static SimplexState DTJQLGSZJNE(uint a)
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
		[Cpp2IlInjected.Address(RVA = "0x86FF890", Offset = "0x86FE890", VA = "0x1886FF890")]
		public SimplexState(uint seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86FF800", Offset = "0x86FE800", VA = "0x1886FF800", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FDD80", Offset = "0x86FCD80", VA = "0x1886FDD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FA550", Offset = "0x86F9550", VA = "0x1886FA550")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FFC90", Offset = "0x86FEC90", VA = "0x1886FFC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FFCE0", Offset = "0x86FECE0", VA = "0x1886FFCE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FB280", Offset = "0x86FA280", VA = "0x1886FB280")]
		public LSystemDefinition ToRuntimeDefinition()
		{
			return default(LSystemDefinition);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86FC060", Offset = "0x86FB060", VA = "0x1886FC060")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FD5E0", Offset = "0x86FC5E0", VA = "0x1886FD5E0")]
		public LSystemStochasticRuleInfo(int initialCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86FD550", Offset = "0x86FC550", VA = "0x1886FD550", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FCC10", Offset = "0x86FBC10", VA = "0x1886FCC10")]
		public LSystemDefinition(int symbolCapacity, int ruleCapacity, int startingStringCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86FCB70", Offset = "0x86FBB70", VA = "0x1886FCB70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86FCB00", Offset = "0x86FBB00", VA = "0x1886FCB00")]
		public LSystemBuilder(int symbolCapacity = 8, int ruleCapacity = 8, int startingStringCapacity = 16)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86FC860", Offset = "0x86FB860", VA = "0x1886FC860")]
		public LSystemBuilder TKGOWXJHUIZ(LSystemSymbolBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86FC5E0", Offset = "0x86FB5E0", VA = "0x1886FC5E0")]
		public LSystemBuilder IQKEZCOQVLJ(char a, string b)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86FC1A0", Offset = "0x86FB1A0", VA = "0x1886FC1A0")]
		public LSystemBuilder CZHTCITGONM(LSystemStochasticRuleBuilder a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86FC750", Offset = "0x86FB750", VA = "0x1886FC750")]
		public LSystemBuilder KZEYCKLOEEM(string a)
		{
			return default(LSystemBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86FCA00", Offset = "0x86FBA00", VA = "0x1886FCA00")]
		public bool ZFVAHVRCGAB([Out] LSystemDefinition a)
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
		[Cpp2IlInjected.Address(RVA = "0x86FDD40", Offset = "0x86FCD40", VA = "0x1886FDD40")]
		public LSystemSymbolBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86FDB80", Offset = "0x86FCB80", VA = "0x1886FDB80")]
		public LSystemSymbolBuilder ZFQVCHNEIKC(float2[] a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86FD9B0", Offset = "0x86FC9B0", VA = "0x1886FD9B0")]
		public LSystemSymbolBuilder HMLWVRWPEUV(float a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86FDA40", Offset = "0x86FCA40", VA = "0x1886FDA40")]
		public LSystemSymbolBuilder MGOQNZHSQEY(quaternion a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86FDC20", Offset = "0x86FCC20", VA = "0x1886FDC20")]
		public LSystemSymbolBuilder ZZCZVWMEMQF(LSystemStackAction a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86FDAF0", Offset = "0x86FCAF0", VA = "0x1886FDAF0")]
		public LSystemSymbolBuilder TCYJAHEMMMA(Color32 a)
		{
			return default(LSystemSymbolBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86FD700", Offset = "0x86FC700", VA = "0x1886FD700")]
		internal bool DNCJNDDSGYF([Out] LSystemSymbolDefinition a)
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
		[Cpp2IlInjected.Address(RVA = "0x86FD4D0", Offset = "0x86FC4D0", VA = "0x1886FD4D0")]
		public LSystemStochasticRuleBuilder(char symbol)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86FD3B0", Offset = "0x86FC3B0", VA = "0x1886FD3B0")]
		public LSystemStochasticRuleBuilder TDTDJMOJSDF(float a, string b)
		{
			return default(LSystemStochasticRuleBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86FD350", Offset = "0x86FC350", VA = "0x1886FD350")]
		internal (char, List<(float, string)>) DOLHACCSKSP()
		{
			return default((char, List<(float, string)>));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class MWWKSQBGMFN
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
			[Cpp2IlInjected.Address(RVA = "0x86FCE10", Offset = "0x86FBE10", VA = "0x1886FCE10", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x86FCE40", Offset = "0x86FBE40", VA = "0x1886FCE40")]
			private void RELKISPDHPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x86FD0C0", Offset = "0x86FC0C0", VA = "0x1886FD0C0")]
			private void UDQEPSQQNIV(int a, LSystemRule b)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class RGHLAAPIIQL
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
			[Cpp2IlInjected.Address(RVA = "0x86FE5B0", Offset = "0x86FD5B0", VA = "0x1886FE5B0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x86FEC50", Offset = "0x86FDC50", VA = "0x1886FEC50")]
			private void SOADVOQHFHH(char a, NativeList<RigidTransform> b, RigidTransform c, NativeArray<float3> d, NativeArray<float3> e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x86FE1D0", Offset = "0x86FD1D0", VA = "0x1886FE1D0")]
			private void ASYQFLFFVCR([In] float3 basePos, [In] quaternion orientation, [In] float2 scale, [In] Color32 color, NativeArray<float3> a, NativeArray<float3> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x86FEB20", Offset = "0x86FDB20", VA = "0x1886FEB20")]
			private void MXTAXTOWGWH(int a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x86FEA00", Offset = "0x86FDA00", VA = "0x1886FEA00")]
			private void JJQTGTWMHHI(int a, int b, int c, bool d)
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3149417424
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x87006F0", Offset = "0x86FF6F0", VA = "0x1887006F0")]
	public static void YCMHZVKAXHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x87006E0", Offset = "0x86FF6E0", VA = "0x1887006E0")]
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
