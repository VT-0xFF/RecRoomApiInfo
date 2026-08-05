using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Creation;
using RecRoom.Foundation.Transforms;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.MCluster.Types;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MCluster_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x850E410", Offset = "0x850D410", VA = "0x18850E410", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.MCluster
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct Constants
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly int[] CULLING_LAYER_ARG_OFFSETS;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly uint[] CULLING_LAYER_MASK;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly string[] SHADER_KEYWORD_ARRAY;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAEA0", Offset = "0x1AA9EA0", VA = "0x181AAAEA0")]
		public static int UWJDSDCWTGK(CullingLayer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x850BB80", Offset = "0x850AB80", VA = "0x18850BB80")]
		public static int RWBGRUMNXXP(CullingLayer a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PZSSJXNJZRP
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int WUAHNZSZLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LTRVZKPCBOJ LAGJBHZMEXP(int a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Hash128 LWJFMZVLCGB(int a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RRTransform ZVYIFLMKWYP();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MaterialInfo XMQPBARPCCM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class BKODBFQCJEQ : HUWUZMKNOKC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RRTransform PBSPRLEJMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Transform EDWBFAREJSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<WUAJKXDHHPM> BRGIABTBFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private FPWLVEVMXTA PFDFEHUDGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ComputeHandle QMZIUOVRAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool TFREUNDLZPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PZSSJXNJZRP PIPRIBJSEAI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float QUSJKKRMUOL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAFB160", Offset = "0xAFA160", VA = "0x180AFB160")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAFAF40", Offset = "0xAF9F40", VA = "0x180AFAF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool WNXGZQWIIYD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCEB8E0", Offset = "0xCEA8E0", VA = "0x180CEB8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCEB480", Offset = "0xCEA480", VA = "0x180CEB480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool WIOSRJMUOVR
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x133E1F0", Offset = "0x133D1F0", VA = "0x18133E1F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x133E1E0", Offset = "0x133D1E0", VA = "0x18133E1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OZFZDJKYTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x78B9C30", Offset = "0x78B8C30", VA = "0x1878B9C30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1EBCA00", Offset = "0x1EBBA00", VA = "0x181EBCA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NVERIYBEWTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x75C6060", Offset = "0x75C5060", VA = "0x1875C6060", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x850B220", Offset = "0x850A220", VA = "0x18850B220")]
		public BKODBFQCJEQ(PZSSJXNJZRP a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x850AC00", Offset = "0x8509C00", VA = "0x18850AC00")]
		private bool BPTNUNZLUTM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8509FB0", Offset = "0x8508FB0", VA = "0x188509FB0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x850B050", Offset = "0x850A050", VA = "0x18850B050", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x850AE30", Offset = "0x8509E30", VA = "0x18850AE30", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x850AE20", Offset = "0x8509E20", VA = "0x18850AE20", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface AZBEPLYSAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XVIROKQFZFY(CommandBuffer a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct TexturePropertyData : AZBEPLYSAGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public readonly RenderTargetIdentifier Texture
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x55083B0", Offset = "0x55073B0", VA = "0x1855083B0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8517660", Offset = "0x8516660", VA = "0x188517660")]
		public TexturePropertyData(int id, RenderTargetIdentifier data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8517610", Offset = "0x8516610", VA = "0x188517610", Slot = "4")]
		public void XVIROKQFZFY(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct VectorArrayPropertyData : AZBEPLYSAGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly Vector4[] VectorArray
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xCC4250", Offset = "0xCC3250", VA = "0x180CC4250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x171EEC0", Offset = "0x171DEC0", VA = "0x18171EEC0")]
		public VectorArrayPropertyData(int id, Vector4[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8517680", Offset = "0x8516680", VA = "0x188517680", Slot = "4")]
		public void XVIROKQFZFY(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct FloatArrayPropertyData : AZBEPLYSAGC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly float[] FloatArray
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xCC4250", Offset = "0xCC3250", VA = "0x180CC4250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x171EEC0", Offset = "0x171DEC0", VA = "0x18171EEC0")]
		public FloatArrayPropertyData(int id, float[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x850D160", Offset = "0x850C160", VA = "0x18850D160", Slot = "4")]
		public void XVIROKQFZFY(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KeywordPropertyData : AZBEPLYSAGC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xC41C30", Offset = "0xC40C30", VA = "0x180C41C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC41C40", Offset = "0xC40C40", VA = "0x180C41C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1887C40", Offset = "0x1886C40", VA = "0x181887C40")]
		public KeywordPropertyData(string name, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x850D190", Offset = "0x850C190", VA = "0x18850D190", Slot = "4")]
		public void XVIROKQFZFY(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MaterialInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Hash128 Hash
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x104DA70", Offset = "0x104CA70", VA = "0x18104DA70")]
			[CompilerGenerated]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float4 BaseColorLinear
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xC9D7C0", Offset = "0xC9C7C0", VA = "0x180C9D7C0")]
			[CompilerGenerated]
			get
			{
				return default(float4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int ColorIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int TypeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAF3A00", Offset = "0xAF2A00", VA = "0x180AF3A00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float DetailScale
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xE4D6C0", Offset = "0xE4C6C0", VA = "0x180E4D6C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x850F8F0", Offset = "0x850E8F0", VA = "0x18850F8F0")]
		public MaterialInfo(Color color, int colorIndex, int typeIndex, float detailScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA00", Offset = "0x10DEA00", VA = "0x1810DFA00")]
		private static float4 LXJXVWFIKKF(Color a)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x850F860", Offset = "0x850E860", VA = "0x18850F860")]
		private static Hash128 POJVRTZJHHX(MaterialInfo a)
		{
			return default(Hash128);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FPWLVEVMXTA : HUWUZMKNOKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly string CNCSTOTHWSM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly string IYILUPKCXUD;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly string SOKKJBBZJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private MaterialInfo BWHQCZWQXIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ClusterMaterial VTXKGTHGTSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Hash128 ASQHZIMVQWH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ComputeHandle XYAYFFWFHUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1026460", Offset = "0x1025460", VA = "0x181026460")]
			[CompilerGenerated]
			get
			{
				return default(ComputeHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15C6560", Offset = "0x15C5560", VA = "0x1815C6560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool WNXGZQWIIYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x10BC780", Offset = "0x10BB780", VA = "0x1810BC780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x732B420", Offset = "0x732A420", VA = "0x18732B420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool WIOSRJMUOVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x10BC7B0", Offset = "0x10BB7B0", VA = "0x1810BC7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x846BA30", Offset = "0x846AA30", VA = "0x18846BA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NVERIYBEWTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool OZFZDJKYTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x10BC7C0", Offset = "0x10BB7C0", VA = "0x1810BC7C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x850CF30", Offset = "0x850BF30", VA = "0x18850CF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int RFMSXMRTOHH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x850CF40", Offset = "0x850BF40", VA = "0x18850CF40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x850D070", Offset = "0x850C070", VA = "0x18850D070")]
		public FPWLVEVMXTA(MaterialInfo a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x850CB40", Offset = "0x850BB40", VA = "0x18850CB40")]
		private bool BPTNUNZLUTM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x850C9F0", Offset = "0x850B9F0", VA = "0x18850C9F0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x850CD40", Offset = "0x850BD40", VA = "0x18850CD40")]
		private static ClusterMaterial UIBKNPSSCRU(MaterialInfo a)
		{
			return default(ClusterMaterial);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x850CD80", Offset = "0x850BD80", VA = "0x18850CD80", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x850CC40", Offset = "0x850BC40", VA = "0x18850CC40", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x850E490", Offset = "0x850D490", VA = "0x18850E490", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x850E690", Offset = "0x850D690", VA = "0x18850E690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC31D60", Offset = "0xC30D60", VA = "0x180C31D60")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private NZBEXABFQHH opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static RenderPipeline BDLZQLTWJYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x850EF70", Offset = "0x850DF70", VA = "0x18850EF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x850ECB0", Offset = "0x850DCB0", VA = "0x18850ECB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x850E770", Offset = "0x850D770", VA = "0x18850E770", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x850E740", Offset = "0x850D740", VA = "0x18850E740", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x850ED20", Offset = "0x850DD20", VA = "0x18850ED20")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x172A820", Offset = "0x1729820", VA = "0x18172A820")]
		public MClusterRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class YRYGDPKKATD<a> : IDisposable where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private EUUFFSOTBPK ONQRLKFXCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private EUUFFSOTBPK GMTQKGDZGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ComputeBuffer UDINPUJUNQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private RenderTexture LVMAMTZVKDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int IZGGUQHHGQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int KTJMPXYPDLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private string BIXLVPOZOMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string LWBCAZARFHE;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAD6FE0", Offset = "0xAD5FE0", VA = "0x180AD6FE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int ZYUKMZRJNQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xB1B470", Offset = "0xB1A470", VA = "0x180B1B470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int UESRVOMQATN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAFB170", Offset = "0xAFA170", VA = "0x180AFB170")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DF70", Offset = "0x3F2CF70", VA = "0x183F2DF70")]
		public YRYGDPKKATD(string a, int b, [Optional] RenderTextureFormat? c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D200", Offset = "0x3F2C200", VA = "0x183F2D200")]
		public void Update(CommandBuffer cmd, NativeArray<a> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BBF0", Offset = "0x3F2ABF0", VA = "0x183F2BBF0")]
		public void Bind(CommandBuffer cmd, ComputeShader computeShader, int kernel, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B220", Offset = "0x3F2A220", VA = "0x183F2B220")]
		public void Bind(Material material, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CDB0", Offset = "0x3F2BDB0", VA = "0x183F2CDB0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface MJPSKWJNVKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Bind(Material mat);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class MEMPYSPFXBJ<a, b> : MJPSKWJNVKO, IDisposable where a : struct where b : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		protected bool[] DRNZDXZGTRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected EUUFFSOTBPK IILCYENGEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected EUUFFSOTBPK BGOOQDVZOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		protected NativeArray<int> NNAIDGIQAUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected NativeArray<a> LOIKLNPQJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected int TESIVZANWMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected int EVPIRUNZWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected YRYGDPKKATD<int> EMWGAPZZMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected YRYGDPKKATD<a> GUVRRIGOQGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected YRYGDPKKATD<b> OPGGTAUMZHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected ComputeShader OVTPIGSFTVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected int VKCPDNXHLNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected int DISESVTVMWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		protected int DIXLQCNSWHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected int DJCSNJHQFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected int SPQTDJESWIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected int ZHAKBUYULVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int NVGVWWSFMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int BRQHVEKDMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected int NNGHQEKATXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int ZMZJBESPBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected int IFREDSNSUIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected int OHEBTKIPNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected string FXDISIKGUJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected float[] TDJHCMZAZCA;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int MPXWEKMJUVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5A83190", Offset = "0x5A82190", VA = "0x185A83190")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string MJVTIZDGYIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5A82C10", Offset = "0x5A81C10", VA = "0x185A82C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5A85490", Offset = "0x5A84490", VA = "0x185A85490")]
		public MEMPYSPFXBJ(string a, int b, int c, RenderTextureFormat d, ComputeShader e, int f = 0, int g = 0, int h = 0, int i = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5A831A0", Offset = "0x5A821A0", VA = "0x185A831A0")]
		public int MIEKHQGBWVG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5A7F640", Offset = "0x5A7E640", VA = "0x185A7F640")]
		protected void BNAQKGDBBLT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5A7F460", Offset = "0x5A7E460", VA = "0x185A7F460")]
		public ComputeHandle Add(a data)
		{
			return default(ComputeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5A839C0", Offset = "0x5A829C0", VA = "0x185A839C0")]
		public bool Update(ComputeHandle handle, a data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5A83290", Offset = "0x5A82290", VA = "0x185A83290")]
		public bool Remove(ComputeHandle handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "6")]
		protected virtual void HQXKTKSYDDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5A81500", Offset = "0x5A80500", VA = "0x185A81500", Slot = "7")]
		public void GUFVSJSIKBC(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5A80AF0", Offset = "0x5A7FAF0", VA = "0x185A80AF0", Slot = "8")]
		public void GUFVSJSIKBC(CommandBuffer a, ComputeShader b, int c = -1, int d = -1, int e = -1, int f = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5A7FDA0", Offset = "0x5A7EDA0", VA = "0x185A7FDA0", Slot = "9")]
		public void Bind(CommandBuffer cmd, ComputeShader shader, int kernelIndex = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5A80180", Offset = "0x5A7F180", VA = "0x185A80180", Slot = "4")]
		public void Bind(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5A803A0", Offset = "0x5A7F3A0", VA = "0x185A803A0", Slot = "10")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface EUUFFSOTBPK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ulong SizeInMemoryCPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ulong SizeInMemoryGPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class MUCXNRYMVOS
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ResourceHandle : EUUFFSOTBPK, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private IDisposable resource;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xCC4250", Offset = "0xCC3250", VA = "0x180CC4250", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2B25EA0", Offset = "0x2B24EA0", VA = "0x182B25EA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xC231D0", Offset = "0xC221D0", VA = "0x180C231D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8517410", Offset = "0x8516410", VA = "0x188517410")]
			internal ResourceHandle(IDisposable createdResource, ulong cpuMemorySize, ulong gpuMemorySize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8517390", Offset = "0x8516390", VA = "0x188517390", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct RenderTextureHandle : EUUFFSOTBPK, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private RenderTexture renderTexture;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xCC4250", Offset = "0xCC3250", VA = "0x180CC4250", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2B25EA0", Offset = "0x2B24EA0", VA = "0x182B25EA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xC231D0", Offset = "0xC221D0", VA = "0x180C231D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8517360", Offset = "0x8516360", VA = "0x188517360")]
			public RenderTextureHandle(RenderTexture texture, ulong gpuSize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x85172C0", Offset = "0x85162C0", VA = "0x1885172C0", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static ulong MFRSYAIUVHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x850F820", Offset = "0x850E820", VA = "0x18850F820")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x850F000", Offset = "0x850E000", VA = "0x18850F000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static ulong GYKGBAIZGUP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x850EFC0", Offset = "0x850DFC0", VA = "0x18850EFC0")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x850F7E0", Offset = "0x850E7E0", VA = "0x18850F7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x850F040", Offset = "0x850E040", VA = "0x18850F040")]
		public static ComputeBuffer Create(int count, int stride, ComputeBufferType type, [Out] EUUFFSOTBPK handle, ComputeBufferMode mode = ComputeBufferMode.Immutable)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x850F200", Offset = "0x850E200", VA = "0x18850F200")]
		public static RenderTexture Create(int height, int width, int depth, RenderTextureFormat format, [Out] EUUFFSOTBPK handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x38576E0", Offset = "0x38566E0", VA = "0x1838576E0")]
		public static NativeArray<a> PIODQDPFRAI<a>(NativeArray<a> a, ulong b, [Out] EUUFFSOTBPK c) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3856AC0", Offset = "0x3855AC0", VA = "0x183856AC0")]
		public static NativeArray<T> Create<T>(int length, Allocator allocator, [Out] EUUFFSOTBPK handle, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x850F590", Offset = "0x850E590", VA = "0x18850F590")]
		public static void Destroy(EUUFFSOTBPK resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x850F6D0", Offset = "0x850E6D0", VA = "0x18850F6D0")]
		public static uint KMXQBIODXDZ(RenderTextureFormat a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class EPYPCRNVLAX : MEMPYSPFXBJ<ClusterTransform, ClusterTransform>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[BurstCompile]
		public struct SampleTransformData : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[ReadOnly]
			private NativeArray<int> indexArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[ReadOnly]
			private NativeArray<float> extentArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[WriteOnly]
			private NativeArray<float4x4> sampledTransformDst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[WriteOnly]
			private NativeArray<float4> sampledScaleExtentDst;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x850BFD0", Offset = "0x850AFD0", VA = "0x18850BFD0")]
			public SampleTransformData(NativeArray<int> indexSrc, NativeArray<float> extentSrc, NativeArray<float4x4> transformDst, NativeArray<float4> scaleExtentDst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8517450", Offset = "0x8516450", VA = "0x188517450", Slot = "4")]
			public void Execute(int index, TransformAccess transform)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[BurstCompile]
		public struct CreateClusterTransformUpdateData : IJobParallelFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[ReadOnly]
			private NativeArray<int> indexArray;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			[ReadOnly]
			private NativeArray<float4x4> sampledTransformData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			[ReadOnly]
			private NativeArray<float4> sampledScaleExtentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			[WriteOnly]
			private NativeArray<ClusterTransform> transformUpdateDst;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x850BFD0", Offset = "0x850AFD0", VA = "0x18850BFD0")]
			public CreateClusterTransformUpdateData(NativeArray<int> indexSrc, NativeArray<float4x4> transformData, NativeArray<float4> scaleExtentSrc, NativeArray<ClusterTransform> dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x850BF60", Offset = "0x850AF60", VA = "0x18850BF60", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private const byte CQOCFGSODRE = 255;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TransformAccessArray JQWRDIZFWSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> VGQRHADEWNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NativeArray<float4x4> IMGGCZPIZNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NativeArray<float4> HLGOKQSFMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private NativeArray<int> HWUCGBDEUTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NativeArray<int> PEQHOLYRDCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private EUUFFSOTBPK ASATBQEOQRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private EUUFFSOTBPK SCFTQTSDUPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private EUUFFSOTBPK DSOCPATDNYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private EUUFFSOTBPK SCMQDVPMEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private EUUFFSOTBPK RNKLYEOKNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Transform YUVZKCCYLOK;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x850C660", Offset = "0x850B660", VA = "0x18850C660")]
		public EPYPCRNVLAX(int a, int b, ComputeShader c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x850C200", Offset = "0x850B200", VA = "0x18850C200", Slot = "6")]
		protected override void HQXKTKSYDDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x850C4C0", Offset = "0x850B4C0", VA = "0x18850C4C0")]
		private void UHUCWKPKMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x850C000", Offset = "0x850B000", VA = "0x18850C000")]
		public bool AJRSKRGKZCJ(ComputeHandle a, Transform b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x850C580", Offset = "0x850B580", VA = "0x18850C580")]
		public void UMBGYNMZGHO(ComputeHandle a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x850C410", Offset = "0x850B410", VA = "0x18850C410")]
		public void PQJFUXRHKRD(ComputeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x850C160", Offset = "0x850B160", VA = "0x18850C160", Slot = "10")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface LTRVZKPCBOJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeMesh Complete();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface PLFULIOMZTM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		Hash128 EXVTLHZYFJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int RKOMNSUPLNG
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int JWEMRTCABPG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		NativeArray<float3> IOKXNPAKEHO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		NativeArray<float3> EXBTDCFUXFS
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		NativeArray<float4> GPITLYBTGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		NativeArray<int> RTUPUVBLATH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		NativeArray<float2> MMATVGIXFRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		NativeArray<float4> VJUDPYHWVPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		int HIDXPVMYRUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int CVBHRBXBQLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		int CWDRELMPVOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		bool XGSSWAIFYJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void GUFVSJSIKBC();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class XQJCVNSOPGJ : PLFULIOMZTM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private LTRVZKPCBOJ IQQJSHIALBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NativeMesh CLCVLYVAFDY;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Hash128 EXVTLHZYFJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xC9D7C0", Offset = "0xC9C7C0", VA = "0x180C9D7C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Hash128);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xC9D7E0", Offset = "0xC9C7E0", VA = "0x180C9D7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool WAJDRIOPDQO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAD3550", Offset = "0xAD2550", VA = "0x180AD3550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int RKOMNSUPLNG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAF3A00", Offset = "0xAF2A00", VA = "0x180AF3A00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xCA39E0", Offset = "0xCA29E0", VA = "0x180CA39E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int JWEMRTCABPG
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAD05D0", Offset = "0xACF5D0", VA = "0x180AD05D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAD0600", Offset = "0xACF600", VA = "0x180AD0600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private int BTNSKJHEIPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1B76860", Offset = "0x1B75860", VA = "0x181B76860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public NativeArray<float3> IOKXNPAKEHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8519670", Offset = "0x8518670", VA = "0x188519670", Slot = "7")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public NativeArray<float3> EXBTDCFUXFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x85194A0", Offset = "0x85184A0", VA = "0x1885194A0", Slot = "8")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public NativeArray<float4> GPITLYBTGOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8519750", Offset = "0x8518750", VA = "0x188519750", Slot = "9")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public NativeArray<int> RTUPUVBLATH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x85196E0", Offset = "0x85186E0", VA = "0x1885196E0", Slot = "10")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public NativeArray<float2> MMATVGIXFRK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8519630", Offset = "0x8518630", VA = "0x188519630", Slot = "11")]
			get
			{
				return default(NativeArray<float2>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public NativeArray<float4> VJUDPYHWVPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x85193E0", Offset = "0x85183E0", VA = "0x1885193E0", Slot = "12")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool XGSSWAIFYJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB25890", Offset = "0xB24890", VA = "0x180B25890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int HIDXPVMYRUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8519660", Offset = "0x8518660", VA = "0x188519660", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int CVBHRBXBQLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8519610", Offset = "0x8518610", VA = "0x188519610", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int CWDRELMPVOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x85195F0", Offset = "0x85185F0", VA = "0x1885195F0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8519780", Offset = "0x8518780", VA = "0x188519780")]
		public XQJCVNSOPGJ(Hash128 a, LTRVZKPCBOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85194D0", Offset = "0x85184D0", VA = "0x1885194D0", Slot = "16")]
		public void GUFVSJSIKBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8519410", Offset = "0x8518410", VA = "0x188519410", Slot = "18")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct ComputeHandle : IEquatable<ComputeHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly ComputeHandle Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public readonly int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x134CE70", Offset = "0x134BE70", VA = "0x18134CE70")]
		public ComputeHandle(int index = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x850B9D0", Offset = "0x850A9D0", VA = "0x18850B9D0", Slot = "4")]
		public bool Equals(ComputeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x850BA20", Offset = "0x850AA20", VA = "0x18850BA20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x850BAF0", Offset = "0x850AAF0", VA = "0x18850BAF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class WUAJKXDHHPM : HUWUZMKNOKC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool TFREUNDLZPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private PLFULIOMZTM YNNKFNBTPNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private List<ComputeHandle> MDVQYKPMTIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private List<ComputeHandle> BMIANYPEOQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<ComputeHandle> OETFLUVNLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Dictionary<int, uint> YIEQZWZTIVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int LLSGQPEFTYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int JLISYNNHCCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int LPKSGQKNGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int EVCZDDRZKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int SUXZRCWANKS;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int RFMSXMRTOHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x85191F0", Offset = "0x85181F0", VA = "0x1885191F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8518350", Offset = "0x8517350", VA = "0x188518350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool WNXGZQWIIYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xB21140", Offset = "0xB20140", VA = "0x180B21140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xBA8E20", Offset = "0xBA7E20", VA = "0x180BA8E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool WIOSRJMUOVR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xBA7FC0", Offset = "0xBA6FC0", VA = "0x180BA7FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xBA8680", Offset = "0xBA7680", VA = "0x180BA8680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool NVERIYBEWTL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool OZFZDJKYTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x28B0AD0", Offset = "0x28AFAD0", VA = "0x1828B0AD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2612FF0", Offset = "0x2611FF0", VA = "0x182612FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float QUSJKKRMUOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xE23B00", Offset = "0xE22B00", VA = "0x180E23B00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xE23B20", Offset = "0xE22B20", VA = "0x180E23B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85192A0", Offset = "0x85182A0", VA = "0x1885192A0")]
		public WUAJKXDHHPM(PLFULIOMZTM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8518390", Offset = "0x8517390", VA = "0x188518390")]
		private void OHMABDYYHNE(PLFULIOMZTM a, int b, int c, int d, int e, VertexData f, float g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8518860", Offset = "0x8517860", VA = "0x188518860")]
		private void OJMRHPKATWY(PLFULIOMZTM a, int b, int c, uint3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8518050", Offset = "0x8517050", VA = "0x188518050")]
		private bool BPTNUNZLUTM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85176B0", Offset = "0x85166B0", VA = "0x1885176B0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8519170", Offset = "0x8518170", VA = "0x188519170", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8518B20", Offset = "0x8517B20", VA = "0x188518B20", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85182F0", Offset = "0x85172F0", VA = "0x1885182F0")]
		public void GNOYZNNAWNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85182F0", Offset = "0x85172F0", VA = "0x1885182F0", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface HUWUZMKNOKC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool NVERIYBEWTL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool OZFZDJKYTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Add();

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Update();

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class LAMRHOLRKRN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly float DBWYLAJISBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Dictionary<Hash128, WUAJKXDHHPM> XELPCLTRJBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Dictionary<Hash128, FPWLVEVMXTA> MGLXCOZTFOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Queue<HUWUZMKNOKC> MWHWDLWHEUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Queue<HUWUZMKNOKC> KVJNAMEZBJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Queue<HUWUZMKNOKC> KEMNTRYYAXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int QTCSKZTOVGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int IUTRUWTKOTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private float JNXYKAYUFWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool DCWTAVHFDOE;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool LCCDZWLLBBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x173AAE0", Offset = "0x1739AE0", VA = "0x18173AAE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x173AC20", Offset = "0x1739C20", VA = "0x18173AC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool HXWBRQZGXTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x850E120", Offset = "0x850D120", VA = "0x18850E120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string MJVTIZDGYIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x850DD50", Offset = "0x850CD50", VA = "0x18850DD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x850E110", Offset = "0x850D110", VA = "0x18850E110")]
		public void JIJNNBYXSJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x22092E0", Offset = "0x22082E0", VA = "0x1822092E0")]
		public void EPBTSOJKEAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x850E2A0", Offset = "0x850D2A0", VA = "0x18850E2A0")]
		public LAMRHOLRKRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x850D1D0", Offset = "0x850C1D0", VA = "0x18850D1D0")]
		public BKODBFQCJEQ BPSMAKIBARY(PZSSJXNJZRP a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x850D2F0", Offset = "0x850C2F0", VA = "0x18850D2F0")]
		public FPWLVEVMXTA BPSMAKIBARY(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x850E170", Offset = "0x850D170", VA = "0x18850E170")]
		public bool TROJGMYQEIC(Hash128 a, [Out] WUAJKXDHHPM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x850D420", Offset = "0x850C420", VA = "0x18850D420")]
		public WUAJKXDHHPM BPSMAKIBARY(PLFULIOMZTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x850E0F0", Offset = "0x850D0F0", VA = "0x18850E0F0")]
		private void HRIZLYGSZOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x850E1E0", Offset = "0x850D1E0", VA = "0x18850E1E0")]
		private bool VIQFNZZLOAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x850D8A0", Offset = "0x850C8A0", VA = "0x18850D8A0")]
		public void GUFVSJSIKBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x850D790", Offset = "0x850C790", VA = "0x18850D790", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x850D6E0", Offset = "0x850C6E0", VA = "0x18850D6E0")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class PTCAPRMWXNC : MEMPYSPFXBJ<ObjectInfo, ObjectInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85103A0", Offset = "0x850F3A0", VA = "0x1885103A0")]
		public PTCAPRMWXNC(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class FZGQREDCMKO : MEMPYSPFXBJ<ClusterMaterial, ClusterMaterial>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x850D0B0", Offset = "0x850C0B0", VA = "0x18850D0B0")]
		public FZGQREDCMKO(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class FEQOPOIEZCR : MEMPYSPFXBJ<ClusterInfo, ClusterInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x850C940", Offset = "0x850B940", VA = "0x18850C940")]
		public FEQOPOIEZCR(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class RYZPHXYIMVZ : MEMPYSPFXBJ<ClusterVertexData, ClusterCompressedVertexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8510450", Offset = "0x850F450", VA = "0x188510450")]
		public RYZPHXYIMVZ(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class NNTEMDNJGGD : MEMPYSPFXBJ<ClusterIndexData, ClusterIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x850FA20", Offset = "0x850EA20", VA = "0x18850FA20")]
		public NNTEMDNJGGD(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class NZBEXABFQHH : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private RenderPipeline YRMYQVYTEKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool TFLXLCDIAPW;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static bool UJYNUGSSMSG;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x850FF80", Offset = "0x850EF80", VA = "0x18850FF80")]
		public NZBEXABFQHH(RenderPipeline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x850FE60", Offset = "0x850EE60", VA = "0x18850FE60", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x850FAD0", Offset = "0x850EAD0", VA = "0x18850FAD0", Slot = "6")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x850FB10", Offset = "0x850EB10", VA = "0x18850FB10", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class YHDTRWCAOOG
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public readonly struct RenderPassContext : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private readonly string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private readonly CommandBuffer cmd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private readonly ScriptableRenderContext context;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x85105B0", Offset = "0x850F5B0", VA = "0x1885105B0")]
			public RenderPassContext(string passName, ScriptableRenderContext currentContext, [Out] CommandBuffer externCmd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8510500", Offset = "0x850F500", VA = "0x188510500", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85199C0", Offset = "0x85189C0", VA = "0x1885199C0")]
		public static bool UVOCTGSTWXM(RenderingData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85197D0", Offset = "0x85187D0", VA = "0x1885197D0")]
		public static void KAZDLQVYCWS(CommandBuffer a, ScriptableRenderContext b, ShadowDrawingSettings c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RenderPipeline : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class OSHMYQYIHMK
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly int DNKPHPIMDIQ;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly int QWYVKMDLMHT;
		}

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static YRYGDPKKATD<ClusterReference> CVIJPQIBBFH;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static YRYGDPKKATD<uint> LPTCLHZQRKY;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static EUUFFSOTBPK QNFATRPQQDY;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static ComputeBuffer YJENIOWUSDW;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static List<MJPSKWJNVKO> RJKSKITFIFL;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static int SCRXULSMIIZ;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int KCGBYUFMADH;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int ZIBTJINXYIO;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int UYTLUPSURSK;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static int[] XHKXTHIHWKA;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static Material[] IHLVJBSEWNN;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static AZBEPLYSAGC[][] PZLOQJFEDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Plane[] UIENLPGJVRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int JAEXSGJCUFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int FFZSVMPYBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int YQNJHDHEONU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int BQCHCJIOPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int GONZCTUUPMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int BTOTBJLVSCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int TPPYHAUIFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int OQZUOHIPEKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int AWYVIYJNPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int MDGWSZHAEVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int UNPALTFFAQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int VEAUTIHHMTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int UUCFNHOZVTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int QFBYYJBOJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int AIYOBAHZKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int AJAILVDOFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int TKXFEJLZMUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int MIFIZZPAMXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private float[] GIDEJSOWAIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private LAMRHOLRKRN EPEOOHDQGCL;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static bool FLJXKGTTOBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x85158B0", Offset = "0x85148B0", VA = "0x1885158B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8512F70", Offset = "0x8511F70", VA = "0x188512F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static bool FYKLRMBXSAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x85136E0", Offset = "0x85126E0", VA = "0x1885136E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8510B70", Offset = "0x850FB70", VA = "0x188510B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static MClusterData TNFSBSIRYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8512BC0", Offset = "0x8511BC0", VA = "0x188512BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x85153D0", Offset = "0x85143D0", VA = "0x1885153D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static EPYPCRNVLAX EPYPCRNVLAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8515AA0", Offset = "0x8514AA0", VA = "0x188515AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8515280", Offset = "0x8514280", VA = "0x188515280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static PTCAPRMWXNC PTCAPRMWXNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8515B40", Offset = "0x8514B40", VA = "0x188515B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8512B50", Offset = "0x8511B50", VA = "0x188512B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static FZGQREDCMKO FZGQREDCMKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x85110C0", Offset = "0x85100C0", VA = "0x1885110C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8516850", Offset = "0x8515850", VA = "0x188516850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static FEQOPOIEZCR FEQOPOIEZCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8516F30", Offset = "0x8515F30", VA = "0x188516F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8511510", Offset = "0x8510510", VA = "0x188511510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static RYZPHXYIMVZ RYZPHXYIMVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8510B20", Offset = "0x850FB20", VA = "0x188510B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8515520", Offset = "0x8514520", VA = "0x188515520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static NNTEMDNJGGD NNTEMDNJGGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8513730", Offset = "0x8512730", VA = "0x188513730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8515A30", Offset = "0x8514A30", VA = "0x188515A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static Material TFARFZLQEDX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8515860", Offset = "0x8514860", VA = "0x188515860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8511AC0", Offset = "0x8510AC0", VA = "0x188511AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static Material IJCWWSSPWPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8512C10", Offset = "0x8511C10", VA = "0x188512C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x85154B0", Offset = "0x85144B0", VA = "0x1885154B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static Material QACKBOMTTNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8516E90", Offset = "0x8515E90", VA = "0x188516E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8511050", Offset = "0x8510050", VA = "0x188511050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static Material MFDQOKBGFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8515900", Offset = "0x8514900", VA = "0x188515900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8513670", Offset = "0x8512670", VA = "0x188513670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static bool QFKBEMABUGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8516EE0", Offset = "0x8515EE0", VA = "0x188516EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8516F80", Offset = "0x8515F80", VA = "0x188516F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HXWBRQZGXTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8515760", Offset = "0x8514760", VA = "0x188515760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string MJVTIZDGYIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8512FD0", Offset = "0x8511FD0", VA = "0x188512FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8517070", Offset = "0x8516070", VA = "0x188517070")]
		internal RenderPipeline([Optional] MClusterData dataData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8513780", Offset = "0x8512780", VA = "0x188513780")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85157C0", Offset = "0x85147C0", VA = "0x1885157C0")]
		public void MVNBNXSVDVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8511110", Offset = "0x8510110", VA = "0x188511110")]
		public void DHABYMWOERO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8515B90", Offset = "0x8514B90", VA = "0x188515B90")]
		public bool SQWYBNUTNBF(Hash128 a, [Out] WUAJKXDHHPM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8510870", Offset = "0x850F870", VA = "0x188510870")]
		public WUAJKXDHHPM BPSMAKIBARY(PLFULIOMZTM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8510930", Offset = "0x850F930", VA = "0x188510930")]
		public FPWLVEVMXTA BPSMAKIBARY(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x85106C0", Offset = "0x850F6C0", VA = "0x1885106C0")]
		public BKODBFQCJEQ BPSMAKIBARY(PZSSJXNJZRP a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8515AF0", Offset = "0x8514AF0", VA = "0x188515AF0")]
		public void Remove(HUWUZMKNOKC element)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x85152F0", Offset = "0x85142F0", VA = "0x1885152F0")]
		public static void JLWNAAAKDXO(CullingLayer a, AZBEPLYSAGC[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x85149B0", Offset = "0x85139B0", VA = "0x1885149B0")]
		private void JDGAPIDOVVP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8515C30", Offset = "0x8514C30", VA = "0x188515C30")]
		private static void UFMSJLVYYEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8512C60", Offset = "0x8511C60", VA = "0x188512C60")]
		public void GAETUNIAIDU(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8515590", Offset = "0x8514590", VA = "0x188515590")]
		public void KXTTJXMUXHQ([Optional] ScriptableRenderContext? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85112C0", Offset = "0x85102C0", VA = "0x1885112C0")]
		public void DHZLFHLIQUV(CommandBuffer a, ShadowSplitData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8511120", Offset = "0x8510120", VA = "0x188511120")]
		public void DHZLFHLIQUV(CommandBuffer a, CameraData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8511580", Offset = "0x8510580", VA = "0x188511580")]
		public void DUOMANJNMWE(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8515440", Offset = "0x8514440", VA = "0x188515440")]
		public void JREKVITRJMV(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8510BD0", Offset = "0x850FBD0", VA = "0x188510BD0")]
		public void BYCIUVDBWDK(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x85168C0", Offset = "0x85158C0", VA = "0x1885168C0")]
		public void WDLKXLEKRNL(CommandBuffer a, CullingLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8515950", Offset = "0x8514950", VA = "0x188515950")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8511B30", Offset = "0x8510B30", VA = "0x188511B30")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8512A40", Offset = "0x8511A40", VA = "0x188512A40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ADQETKYAKMV
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2821B40", Offset = "0x2820B40", VA = "0x182821B40")]
		public static int VEKJITRKPKP(int a, int b)
		{
			return default(int);
		}
	}
}
namespace RecRoom.MCluster.Types
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ClusterTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float4x4 RotationTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public float4 NonUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly ClusterTransform Zero;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly ClusterTransform Invalid;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x850B9A0", Offset = "0x850A9A0", VA = "0x18850B9A0")]
		public ClusterTransform(float4x4 rotationTranslation, float4 scaleExtent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x850B840", Offset = "0x850A840", VA = "0x18850B840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct VertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public float4 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public float4 normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float4 tangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float4 uvCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float4 uvCoord1;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct CompressedVertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float4 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public half4 normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public half4 tangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public half4 uvCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public half4 uvCoord1;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct ClusterCompressedVertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CompressedVertexData vert00;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CompressedVertexData vert01;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CompressedVertexData vert02;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CompressedVertexData vert03;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public CompressedVertexData vert04;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public CompressedVertexData vert05;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public CompressedVertexData vert06;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CompressedVertexData vert07;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct ClusterVertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public VertexData vert00;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public VertexData vert01;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public VertexData vert02;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public VertexData vert03;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public VertexData vert04;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public VertexData vert05;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public VertexData vert06;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public VertexData vert07;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct ClusterMaterial
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public float4 baseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public uint colorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public uint typeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float detailScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public uint pad0;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x850B770", Offset = "0x850A770", VA = "0x18850B770")]
		public ClusterMaterial(MaterialInfo material)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct ClusterReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public uint objectIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public uint cullingResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public uint clusterIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public uint pad0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x850B7A0", Offset = "0x850A7A0", VA = "0x18850B7A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct ClusterInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public uint vertexOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public uint indexOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public uint indexCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public uint pad0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x850B6D0", Offset = "0x850A6D0", VA = "0x18850B6D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct ObjectInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public uint materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public uint lod0ClusterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public uint lod0ClusterCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public uint lod1ClusterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public uint lod1ClusterCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public uint lod2ClusterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public uint lod2ClusterCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public uint pad0;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8510070", Offset = "0x850F070", VA = "0x188510070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct ClusterIndexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public uint3 index0;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public uint3 index1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public uint3 index2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public uint3 index3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public uint3 index4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public uint3 index5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public uint3 index6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public uint3 index7;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x850B2D0", Offset = "0x850A2D0", VA = "0x18850B2D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public enum CullingLayer
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Opaque,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		DepthOnly,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Transparent,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Shadow
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1659379656
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8519AB0", Offset = "0x8518AB0", VA = "0x188519AB0")]
	public static void WGYJPSYGJZZ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8519AA0", Offset = "0x8518AA0", VA = "0x188519AA0")]
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
