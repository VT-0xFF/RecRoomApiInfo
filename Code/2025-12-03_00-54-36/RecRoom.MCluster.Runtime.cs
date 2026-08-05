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
		[Cpp2IlInjected.Address(RVA = "0x8241800", Offset = "0x8240400", VA = "0x188241800", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A639C0", Offset = "0x1A625C0", VA = "0x181A639C0")]
		public static int HRUXOQGKEZI(CullingLayer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x823E640", Offset = "0x823D240", VA = "0x18823E640")]
		public static int SPUODYZJNBT(CullingLayer a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface DXVMAPFNXLD
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int HYCDBKBBBVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FKJMZHBHNMV ALCHIVIIXZP(int a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Hash128 LWRDPTCPTMB(int a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RRTransform HEAQBMVFEFN();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MaterialInfo KSNIIORCXVC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CUBFASBWDAQ : MDIMTSZUPFI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RRTransform DLNTDGFNFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Transform AFFSIRAXTZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<MRBFVUHMMDY> EUMLUCTSMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private DVVVFJXEJYG KGNTBMJYHIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ComputeHandle CSXBMCYXVHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool HZZSPHJMTIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DXVMAPFNXLD ZIMFBBLFHDG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float ZWGDBTOREEH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAC5FD0", Offset = "0xAC4BD0", VA = "0x180AC5FD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAC5DA0", Offset = "0xAC49A0", VA = "0x180AC5DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JZDXRXECOJR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xC6C260", Offset = "0xC6AE60", VA = "0x180C6C260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC6BBC0", Offset = "0xC6A7C0", VA = "0x180C6BBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool WIRILZBZCDN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x12B2CB0", Offset = "0x12B18B0", VA = "0x1812B2CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x12B2CA0", Offset = "0x12B18A0", VA = "0x1812B2CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GIQRQJOOIBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7638520", Offset = "0x7637120", VA = "0x187638520", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1DFACD0", Offset = "0x1DF98D0", VA = "0x181DFACD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool TEWLXQXNSKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7340C20", Offset = "0x733F820", VA = "0x187340C20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x823DCC0", Offset = "0x823C8C0", VA = "0x18823DCC0")]
		public CUBFASBWDAQ(DXVMAPFNXLD a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x823D6A0", Offset = "0x823C2A0", VA = "0x18823D6A0")]
		private bool FKVDXWZDKFQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x823CA40", Offset = "0x823B640", VA = "0x18823CA40", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x823DAF0", Offset = "0x823C6F0", VA = "0x18823DAF0", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x823D8C0", Offset = "0x823C4C0", VA = "0x18823D8C0", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x823D690", Offset = "0x823C290", VA = "0x18823D690", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface OEZUSSOJXPU
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FXBLWRQNDRI(CommandBuffer a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct TexturePropertyData : OEZUSSOJXPU
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xC6CF70", Offset = "0xC6BB70", VA = "0x180C6CF70")]
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
			[Cpp2IlInjected.Address(RVA = "0x523AC50", Offset = "0x5239850", VA = "0x18523AC50")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x824BE40", Offset = "0x824AA40", VA = "0x18824BE40")]
		public TexturePropertyData(int id, RenderTargetIdentifier data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x824BDF0", Offset = "0x824A9F0", VA = "0x18824BDF0", Slot = "4")]
		public void FXBLWRQNDRI(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct VectorArrayPropertyData : OEZUSSOJXPU
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xC6CF70", Offset = "0xC6BB70", VA = "0x180C6CF70")]
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
			[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1688A10", Offset = "0x1687610", VA = "0x181688A10")]
		public VectorArrayPropertyData(int id, Vector4[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x824BF10", Offset = "0x824AB10", VA = "0x18824BF10", Slot = "4")]
		public void FXBLWRQNDRI(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct FloatArrayPropertyData : OEZUSSOJXPU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xC6CF70", Offset = "0xC6BB70", VA = "0x180C6CF70")]
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
			[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1688A10", Offset = "0x1687610", VA = "0x181688A10")]
		public FloatArrayPropertyData(int id, float[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x823FB40", Offset = "0x823E740", VA = "0x18823FB40", Slot = "4")]
		public void FXBLWRQNDRI(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KeywordPropertyData : OEZUSSOJXPU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xBB8ED0", Offset = "0xBB7AD0", VA = "0x180BB8ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBB8EE0", Offset = "0xBB7AE0", VA = "0x180BB8EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x17F74B0", Offset = "0x17F60B0", VA = "0x1817F74B0")]
		public KeywordPropertyData(string name, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82417C0", Offset = "0x82403C0", VA = "0x1882417C0", Slot = "4")]
		public void FXBLWRQNDRI(CommandBuffer a)
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
			[Cpp2IlInjected.Address(RVA = "0xFC1670", Offset = "0xFC0270", VA = "0x180FC1670")]
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
			[Cpp2IlInjected.Address(RVA = "0xBB0FE0", Offset = "0xBAFBE0", VA = "0x180BB0FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABDF90", Offset = "0xABCB90", VA = "0x180ABDF90")]
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
			[Cpp2IlInjected.Address(RVA = "0xDBE310", Offset = "0xDBCF10", VA = "0x180DBE310")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82441D0", Offset = "0x8242DD0", VA = "0x1882441D0")]
		public MaterialInfo(Color color, int colorIndex, int typeIndex, float detailScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1047B80", Offset = "0x1046780", VA = "0x181047B80")]
		private static float4 SNPDAPGZXKJ(Color a)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8244140", Offset = "0x8242D40", VA = "0x188244140")]
		private static Hash128 ULLBUXMRSTT(MaterialInfo a)
		{
			return default(Hash128);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DVVVFJXEJYG : MDIMTSZUPFI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly string WFZJSREDVAE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly string AZKMAPCZFBR;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly string DFNNHEWIDKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private MaterialInfo RRCCGWYAMXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ClusterMaterial ZIRCVGCKKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Hash128 KVFNSQSLDVV;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ComputeHandle CZVTNGVIREM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xF98A30", Offset = "0xF97630", VA = "0x180F98A30")]
			[CompilerGenerated]
			get
			{
				return default(ComputeHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1535020", Offset = "0x1533C20", VA = "0x181535020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool JZDXRXECOJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x102BF10", Offset = "0x102AB10", VA = "0x18102BF10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70998E0", Offset = "0x70984E0", VA = "0x1870998E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool WIRILZBZCDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x102BF40", Offset = "0x102AB40", VA = "0x18102BF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x81924D0", Offset = "0x81910D0", VA = "0x1881924D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool TEWLXQXNSKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool GIQRQJOOIBL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x102BF50", Offset = "0x102AB50", VA = "0x18102BF50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x823EE80", Offset = "0x823DA80", VA = "0x18823EE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int QXRFMZXOYOB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x823EE90", Offset = "0x823DA90", VA = "0x18823EE90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x823F180", Offset = "0x823DD80", VA = "0x18823F180")]
		public DVVVFJXEJYG(MaterialInfo a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x823EC20", Offset = "0x823D820", VA = "0x18823EC20")]
		private bool FKVDXWZDKFQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x823EAD0", Offset = "0x823D6D0", VA = "0x18823EAD0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x823ED30", Offset = "0x823D930", VA = "0x18823ED30")]
		private static ClusterMaterial IGTZFBTMFFQ(MaterialInfo a)
		{
			return default(ClusterMaterial);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x823EEE0", Offset = "0x823DAE0", VA = "0x18823EEE0", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x823ED70", Offset = "0x823D970", VA = "0x18823ED70", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8241880", Offset = "0x8240480", VA = "0x188241880", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8241A80", Offset = "0x8240680", VA = "0x188241A80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB904D0", Offset = "0xB8F0D0", VA = "0x180B904D0")]
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
		private FBLMDBCTNIJ opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static RenderPipeline FMVACFRXZEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8242390", Offset = "0x8240F90", VA = "0x188242390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8241B30", Offset = "0x8240730", VA = "0x188241B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8241BD0", Offset = "0x82407D0", VA = "0x188241BD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8241BA0", Offset = "0x82407A0", VA = "0x188241BA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8242130", Offset = "0x8240D30", VA = "0x188242130")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1694EF0", Offset = "0x1693AF0", VA = "0x181694EF0")]
		public MClusterRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ZQGZTWUGTYF<a> : IDisposable where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private XNBFZNLRLTK NDGFDDVZCTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private XNBFZNLRLTK PLPVFBHYRKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ComputeBuffer QBCFEZNCDBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private RenderTexture AWBVITZAJXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int KITJWILWNLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int AFTMABPSHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private string SILJVQCTUAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string EBMRCWUCOJU;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int PAZVGVVRFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA3860", Offset = "0xAA2460", VA = "0x180AA3860")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int YQQACBJSQNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAE4AB0", Offset = "0xAE36B0", VA = "0x180AE4AB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int LNDHISUWGZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAC5FE0", Offset = "0xAC4BE0", VA = "0x180AC5FE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2400", Offset = "0x3EA1000", VA = "0x183EA2400")]
		public ZQGZTWUGTYF(string a, int b, [Optional] RenderTextureFormat? c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1D00", Offset = "0x3EA0900", VA = "0x183EA1D00")]
		public void Update(CommandBuffer cmd, NativeArray<a> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FAF0", Offset = "0x3E9E6F0", VA = "0x183E9FAF0")]
		public void Bind(CommandBuffer cmd, ComputeShader computeShader, int kernel, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0280", Offset = "0x3E9EE80", VA = "0x183EA0280")]
		public void Bind(Material material, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3EA14B0", Offset = "0x3EA00B0", VA = "0x183EA14B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface YRCAMNKMXLU
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Bind(Material mat);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class NDAPRBUZXYT<a, b> : YRCAMNKMXLU, IDisposable where a : struct where b : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		protected bool[] ZROLFPVMIOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected XNBFZNLRLTK LYQHKFAZOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected XNBFZNLRLTK INNXDURRWRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		protected NativeArray<int> NZUKGUVWTMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected NativeArray<a> EGUDWDUJWNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected int LDAEAGJIMTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected int OTKCOGWVHSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected ZQGZTWUGTYF<int> DFAEGNWREGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected ZQGZTWUGTYF<a> XMAVBVAJNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected ZQGZTWUGTYF<b> ZNVWODIJQBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected ComputeShader YKWWJPRTBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected int BZCBSPEHUWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected int TRQZACCZQNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		protected int TRWFXIWWZYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected int TSBMUPQUJJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected int FHYMNOOEEXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected int HMPDJSRWXOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int WQXGXPGSGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int DXGUOZJACWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected int SIHYZDWXWWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int HARFVLYBDQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected int AXGZMXYLSVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected int CTRHEUTUFGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected string HLVUSMOZLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected float[] YPIUMBKUFOY;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int MTHWVAROHSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x577A6F0", Offset = "0x57792F0", VA = "0x18577A6F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string NSHFCNPGDTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x577B5B0", Offset = "0x577A1B0", VA = "0x18577B5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x577F8B0", Offset = "0x577E4B0", VA = "0x18577F8B0")]
		public NDAPRBUZXYT(string a, int b, int c, RenderTextureFormat d, ComputeShader e, int f = 0, int g = 0, int h = 0, int i = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x577BEF0", Offset = "0x577AAF0", VA = "0x18577BEF0")]
		public int SLZLANENCAI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x577A700", Offset = "0x5779300", VA = "0x18577A700")]
		protected void PZAIVBQKWZL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x57789E0", Offset = "0x57775E0", VA = "0x1857789E0")]
		public ComputeHandle Add(a data)
		{
			return default(ComputeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x577DEB0", Offset = "0x577CAB0", VA = "0x18577DEB0")]
		public bool Update(ComputeHandle handle, a data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x577BD70", Offset = "0x577A970", VA = "0x18577BD70")]
		public bool Remove(ComputeHandle handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "6")]
		protected virtual void RHJVFNDIEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x577C520", Offset = "0x577B120", VA = "0x18577C520", Slot = "7")]
		public void SXSZQJETNHS(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x577CF00", Offset = "0x577BB00", VA = "0x18577CF00", Slot = "8")]
		public void SXSZQJETNHS(CommandBuffer a, ComputeShader b, int c = -1, int d = -1, int e = -1, int f = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5779700", Offset = "0x5778300", VA = "0x185779700", Slot = "9")]
		public void Bind(CommandBuffer cmd, ComputeShader shader, int kernelIndex = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5779840", Offset = "0x5778440", VA = "0x185779840", Slot = "4")]
		public void Bind(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x577A220", Offset = "0x5778E20", VA = "0x18577A220", Slot = "10")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface XNBFZNLRLTK : IDisposable
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
	public static class ATAQQDEQCKW
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ResourceHandle : XNBFZNLRLTK, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private IDisposable resource;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2AAFBF0", Offset = "0x2AAE7F0", VA = "0x182AAFBF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xB99200", Offset = "0xB97E00", VA = "0x180B99200")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x824BBF0", Offset = "0x824A7F0", VA = "0x18824BBF0")]
			internal ResourceHandle(IDisposable createdResource, ulong cpuMemorySize, ulong gpuMemorySize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x824BB70", Offset = "0x824A770", VA = "0x18824BB70", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct RenderTextureHandle : XNBFZNLRLTK, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private RenderTexture renderTexture;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xC3E6B0", Offset = "0xC3D2B0", VA = "0x180C3E6B0", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2AAFBF0", Offset = "0x2AAE7F0", VA = "0x182AAFBF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xB99200", Offset = "0xB97E00", VA = "0x180B99200")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x824BB40", Offset = "0x824A740", VA = "0x18824BB40")]
			public RenderTextureHandle(RenderTexture texture, ulong gpuSize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x824BAA0", Offset = "0x824A6A0", VA = "0x18824BAA0", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static ulong KLJGMKODSIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x823C6F0", Offset = "0x823B2F0", VA = "0x18823C6F0")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x823C6B0", Offset = "0x823B2B0", VA = "0x18823C6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static ulong XVOUSXBLZDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x823BEC0", Offset = "0x823AAC0", VA = "0x18823BEC0")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x823C730", Offset = "0x823B330", VA = "0x18823C730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x823BF00", Offset = "0x823AB00", VA = "0x18823BF00")]
		public static ComputeBuffer Create(int count, int stride, ComputeBufferType type, [Out] XNBFZNLRLTK handle, ComputeBufferMode mode = ComputeBufferMode.Immutable)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x823C0C0", Offset = "0x823ACC0", VA = "0x18823C0C0")]
		public static RenderTexture Create(int height, int width, int depth, RenderTextureFormat format, [Out] XNBFZNLRLTK handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x304CF70", Offset = "0x304BB70", VA = "0x18304CF70")]
		public static NativeArray<a> UYCDGYYLARC<a>(NativeArray<a> a, ulong b, [Out] XNBFZNLRLTK c) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x304C320", Offset = "0x304AF20", VA = "0x18304C320")]
		public static NativeArray<T> Create<T>(int length, Allocator allocator, [Out] XNBFZNLRLTK handle, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x823C570", Offset = "0x823B170", VA = "0x18823C570")]
		public static void Destroy(XNBFZNLRLTK resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x823C460", Offset = "0x823B060", VA = "0x18823C460")]
		public static uint DWQREDKSGYT(RenderTextureFormat a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class GMUWNNENNPJ : NDAPRBUZXYT<ClusterTransform, ClusterTransform>
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
			[Cpp2IlInjected.Address(RVA = "0x823EAA0", Offset = "0x823D6A0", VA = "0x18823EAA0")]
			public SampleTransformData(NativeArray<int> indexSrc, NativeArray<float> extentSrc, NativeArray<float4x4> transformDst, NativeArray<float4> scaleExtentDst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x824BC30", Offset = "0x824A830", VA = "0x18824BC30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x823EAA0", Offset = "0x823D6A0", VA = "0x18823EAA0")]
			public CreateClusterTransformUpdateData(NativeArray<int> indexSrc, NativeArray<float4x4> transformData, NativeArray<float4> scaleExtentSrc, NativeArray<ClusterTransform> dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x823EA30", Offset = "0x823D630", VA = "0x18823EA30", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private const byte WDVLPKDHPWK = 255;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TransformAccessArray HGDBFKKIWNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> NJWRIQKDLXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NativeArray<float4x4> PTARAXLFEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NativeArray<float4> WQYGIJFHSIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private NativeArray<int> FDLAEIPEAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NativeArray<int> KRTSPIQNRKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private XNBFZNLRLTK XYBIRCVOGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private XNBFZNLRLTK JCENSCFQXSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private XNBFZNLRLTK OKACPRAACBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private XNBFZNLRLTK PBBVDATWFEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private XNBFZNLRLTK LRJIXVYOHDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Transform WYRUWBPVRJM;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82401D0", Offset = "0x823EDD0", VA = "0x1882401D0")]
		public GMUWNNENNPJ(int a, int b, ComputeShader c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x823FF00", Offset = "0x823EB00", VA = "0x18823FF00", Slot = "6")]
		protected override void RHJVFNDIEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8240110", Offset = "0x823ED10", VA = "0x188240110")]
		private void RVLVACLSTFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x823FDA0", Offset = "0x823E9A0", VA = "0x18823FDA0")]
		public bool KJMGCBNYIYB(ComputeHandle a, Transform b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x823FCC0", Offset = "0x823E8C0", VA = "0x18823FCC0")]
		public void GFWRETXIJNO(ComputeHandle a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x823FB70", Offset = "0x823E770", VA = "0x18823FB70")]
		public void BKSGJJMSUKZ(ComputeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x823FC20", Offset = "0x823E820", VA = "0x18823FC20", Slot = "10")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface FKJMZHBHNMV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeMesh Complete();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface SYEYXVRFJJI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		Hash128 IJJPZIQYCFN
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int ZKGAVFQCKFS
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int UCAWPJNZHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		NativeArray<float3> PWGDLGZEIQE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		NativeArray<float3> EZYPVJXJZEM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		NativeArray<float4> WDIHCQXRKOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		NativeArray<int> OTSFNNAKEMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		NativeArray<float2> JWIGHKZYQAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		NativeArray<float4> JUKHYUOPSZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		int KMPUPHQSZUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int MLVHZKHJUXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		int MHESMUEBRVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		bool LCZBHESAJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void SXSZQJETNHS();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class FWANZMQEWVH : SYEYXVRFJJI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private FKJMZHBHNMV VHXZREZMKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NativeMesh BRLIEEDOGGG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Hash128 IJJPZIQYCFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xBB0FE0", Offset = "0xBAFBE0", VA = "0x180BB0FE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Hash128);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xBB1000", Offset = "0xBAFC00", VA = "0x180BB1000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool SBCKUPVAREG
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA98890", Offset = "0xA97490", VA = "0x180A98890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int ZKGAVFQCKFS
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xABDF90", Offset = "0xABCB90", VA = "0x180ABDF90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xBE2E80", Offset = "0xBE1A80", VA = "0x180BE2E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int UCAWPJNZHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8F0", Offset = "0xA9E4F0", VA = "0x180A9F8F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8E0", Offset = "0xA9E4E0", VA = "0x180A9F8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private int LGXOCVPZCKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1AEEC00", Offset = "0x1AED800", VA = "0x181AEEC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public NativeArray<float3> PWGDLGZEIQE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x823F8C0", Offset = "0x823E4C0", VA = "0x18823F8C0", Slot = "7")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public NativeArray<float3> EZYPVJXJZEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x823FAC0", Offset = "0x823E6C0", VA = "0x18823FAC0", Slot = "8")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public NativeArray<float4> WDIHCQXRKOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x823F870", Offset = "0x823E470", VA = "0x18823F870", Slot = "9")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public NativeArray<int> OTSFNNAKEMV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x823F940", Offset = "0x823E540", VA = "0x18823F940", Slot = "10")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public NativeArray<float2> JWIGHKZYQAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x823F760", Offset = "0x823E360", VA = "0x18823F760", Slot = "11")]
			get
			{
				return default(NativeArray<float2>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public NativeArray<float4> JUKHYUOPSZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x823F7B0", Offset = "0x823E3B0", VA = "0x18823F7B0", Slot = "12")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool LCZBHESAJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAF8F90", Offset = "0xAF7B90", VA = "0x180AF8F90", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAF9300", Offset = "0xAF7F00", VA = "0x180AF9300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int KMPUPHQSZUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x823F930", Offset = "0x823E530", VA = "0x18823F930", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int MLVHZKHJUXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x823F790", Offset = "0x823E390", VA = "0x18823F790", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int MHESMUEBRVM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x823F8A0", Offset = "0x823E4A0", VA = "0x18823F8A0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x823FAF0", Offset = "0x823E6F0", VA = "0x18823FAF0")]
		public FWANZMQEWVH(Hash128 a, FKJMZHBHNMV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x823F9B0", Offset = "0x823E5B0", VA = "0x18823F9B0", Slot = "16")]
		public void SXSZQJETNHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x823F7E0", Offset = "0x823E3E0", VA = "0x18823F7E0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xC6CF70", Offset = "0xC6BB70", VA = "0x180C6CF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
		public ComputeHandle(int index = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x823E490", Offset = "0x823D090", VA = "0x18823E490", Slot = "4")]
		public bool Equals(ComputeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x823E4E0", Offset = "0x823D0E0", VA = "0x18823E4E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x823E5B0", Offset = "0x823D1B0", VA = "0x18823E5B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MRBFVUHMMDY : MDIMTSZUPFI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool HZZSPHJMTIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private SYEYXVRFJJI ULWBIBIWNAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private List<ComputeHandle> HQOHHMPWNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private List<ComputeHandle> FHMQKSCZXQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<ComputeHandle> TUNYAMNSNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Dictionary<int, uint> GAWJAJEHEQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int GKOLXYNDMWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int YWGBQXHMMQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int XFMMACSPVEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int JVTLOTCEVPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int UAOFROIXTNE;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int QXRFMZXOYOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x82436F0", Offset = "0x82422F0", VA = "0x1882436F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int PAZVGVVRFWW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8243FC0", Offset = "0x8242BC0", VA = "0x188243FC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool JZDXRXECOJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAE9750", Offset = "0xAE8350", VA = "0x180AE9750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAFCD80", Offset = "0xAFB980", VA = "0x180AFCD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool WIRILZBZCDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAFC0F0", Offset = "0xAFACF0", VA = "0x180AFC0F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAFC7B0", Offset = "0xAFB3B0", VA = "0x180AFC7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool TEWLXQXNSKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool GIQRQJOOIBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x283A0B0", Offset = "0x2838CB0", VA = "0x18283A0B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x25499E0", Offset = "0x25485E0", VA = "0x1825499E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float ZWGDBTOREEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD98440", Offset = "0xD97040", VA = "0x180D98440")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD98470", Offset = "0xD97070", VA = "0x180D98470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8244000", Offset = "0x8242C00", VA = "0x188244000")]
		public MRBFVUHMMDY(SYEYXVRFJJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8243AE0", Offset = "0x82426E0", VA = "0x188243AE0")]
		private void WDRBAXARANI(SYEYXVRFJJI a, int b, int c, int d, int e, VertexData f, float g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8243820", Offset = "0x8242420", VA = "0x188243820")]
		private void VYOZJRXTVYE(SYEYXVRFJJI a, int b, int c, uint3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8242DE0", Offset = "0x82419E0", VA = "0x188242DE0")]
		private bool FKVDXWZDKFQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x82423E0", Offset = "0x8240FE0", VA = "0x1882423E0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x82437A0", Offset = "0x82423A0", VA = "0x1882437A0", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8243080", Offset = "0x8241C80", VA = "0x188243080", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8242D80", Offset = "0x8241980", VA = "0x188242D80")]
		public void MEXUGZVUWGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8242D80", Offset = "0x8241980", VA = "0x188242D80", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface MDIMTSZUPFI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool TEWLXQXNSKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool GIQRQJOOIBL
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
	public class IFPUBLVJBVZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly float BJVFWSFAGIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Dictionary<Hash128, MRBFVUHMMDY> FBXQDMBOCWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Dictionary<Hash128, DVVVFJXEJYG> KZHYBALYWUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Queue<MDIMTSZUPFI> PRDJZEFQAZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Queue<MDIMTSZUPFI> KIWTYSOFJRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Queue<MDIMTSZUPFI> VOINKBKEQMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int CQBGUMSETZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int FWTTOBRZWNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private float YZZOYFTPAOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool PHQGQFXSJLC;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool LDHAWJSENKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x16B3750", Offset = "0x16B2350", VA = "0x1816B3750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x16B3890", Offset = "0x16B2490", VA = "0x1816B3890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool WHSDOZMRDMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8240670", Offset = "0x823F270", VA = "0x188240670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string NSHFCNPGDTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8240C40", Offset = "0x823F840", VA = "0x188240C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8241530", Offset = "0x8240130", VA = "0x188241530")]
		public void TQFJWQKPRKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x212C660", Offset = "0x212B260", VA = "0x18212C660")]
		public void OGFIIQFJLCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x82415A0", Offset = "0x82401A0", VA = "0x1882415A0")]
		public IFPUBLVJBVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8240980", Offset = "0x823F580", VA = "0x188240980")]
		public CUBFASBWDAQ OGBNJYRINGK(DXVMAPFNXLD a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8240AA0", Offset = "0x823F6A0", VA = "0x188240AA0")]
		public DVVVFJXEJYG OGBNJYRINGK(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8240BD0", Offset = "0x823F7D0", VA = "0x188240BD0")]
		public bool QPPYKECJTWC(Hash128 a, [Out] MRBFVUHMMDY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x82406C0", Offset = "0x823F2C0", VA = "0x1882406C0")]
		public MRBFVUHMMDY OGBNJYRINGK(SYEYXVRFJJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8241540", Offset = "0x8240140", VA = "0x188241540")]
		private void YQKZLYNENWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x82414A0", Offset = "0x82400A0", VA = "0x1882414A0")]
		private bool TGPNSJZJVUC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8240FF0", Offset = "0x823FBF0", VA = "0x188240FF0")]
		public void SXSZQJETNHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8240560", Offset = "0x823F160", VA = "0x188240560", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x82404B0", Offset = "0x823F0B0", VA = "0x1882404B0")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ULUPTVCZNNC : NDAPRBUZXYT<ObjectInfo, ObjectInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x824BE60", Offset = "0x824AA60", VA = "0x18824BE60")]
		public ULUPTVCZNNC(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ZMREUVZFXUW : NDAPRBUZXYT<ClusterMaterial, ClusterMaterial>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x824BF40", Offset = "0x824AB40", VA = "0x18824BF40")]
		public ZMREUVZFXUW(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class KIXAFVYQMKF : NDAPRBUZXYT<ClusterInfo, ClusterInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8241710", Offset = "0x8240310", VA = "0x188241710")]
		public KIXAFVYQMKF(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NJYKYSIKSWH : NDAPRBUZXYT<ClusterVertexData, ClusterCompressedVertexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8244300", Offset = "0x8242F00", VA = "0x188244300")]
		public NJYKYSIKSWH(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class QTKAYVEEQUX : NDAPRBUZXYT<ClusterIndexData, ClusterIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x82446F0", Offset = "0x82432F0", VA = "0x1882446F0")]
		public QTKAYVEEQUX(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class FBLMDBCTNIJ : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private RenderPipeline PTESONDKPLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool KCICXOOTVYA;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static bool DQVFMVKEVHA;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x823F670", Offset = "0x823E270", VA = "0x18823F670")]
		public FBLMDBCTNIJ(RenderPipeline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x823F550", Offset = "0x823E150", VA = "0x18823F550", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x823F1C0", Offset = "0x823DDC0", VA = "0x18823F1C0", Slot = "6")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x823F200", Offset = "0x823DE00", VA = "0x18823F200", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class CEFDGCYOGEK
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
			[Cpp2IlInjected.Address(RVA = "0x8244850", Offset = "0x8243450", VA = "0x188244850")]
			public RenderPassContext(string passName, ScriptableRenderContext currentContext, [Out] CommandBuffer externCmd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x82447A0", Offset = "0x82433A0", VA = "0x1882447A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x823C770", Offset = "0x823B370", VA = "0x18823C770")]
		public static bool GXKRFXHQVTQ(RenderingData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x823C850", Offset = "0x823B450", VA = "0x18823C850")]
		public static void NWMNZNHWHTM(CommandBuffer a, ScriptableRenderContext b, ShadowDrawingSettings c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RenderPipeline : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class FKUCVRJLLDM
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly int HBRCFABDYWY;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly int ENYGDOKVFKR;
		}

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static ZQGZTWUGTYF<ClusterReference> UVOLOWDQWYN;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static ZQGZTWUGTYF<uint> VQKQFOUDQCU;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static XNBFZNLRLTK ZPCPIGXHKUO;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static ComputeBuffer YKZQZCTPHVW;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static List<YRCAMNKMXLU> EYZDUIRQBCN;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static int DJOPQRHVCON;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int IRTVTJKUSPH;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int XUDOIAMHJVY;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int LFCPUCWBWFQ;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static int[] VLLMZKJSJNO;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static Material[] XRKTPDTIXFZ;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static OEZUSSOJXPU[][] FATPOZUBOIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Plane[] GZZGJJCDCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int IZNRJXWDGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int XIBWNHVPDTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int YPNTGPTXIAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int FHPSSDCRHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int VBCJCAWVJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int NIZUJRXKXWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int YJCTOQUUAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int QHEBQKQOORM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int KCBYJTEWFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int JGFJTYWNRBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int BACCPYKLYOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int OWUHMDMYJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int XBJZNXAKNRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int EAZILUCAIKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int QCOATGQCFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int GRWEMODEZOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int MOZKOWMQQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int FFNUEXCKBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private float[] TAXHAWYKNJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private IFPUBLVJBVZ XVXUUFSCDFZ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static bool SBXCGAGFKXF
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x824A4C0", Offset = "0x82490C0", VA = "0x18824A4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8248720", Offset = "0x8247320", VA = "0x188248720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static bool UDHNTKDDSNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8244960", Offset = "0x8243560", VA = "0x188244960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x824B260", Offset = "0x8249E60", VA = "0x18824B260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static MClusterData TBBLLJEYAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x824B370", Offset = "0x8249F70", VA = "0x18824B370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x824B5F0", Offset = "0x824A1F0", VA = "0x18824B5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static GMUWNNENNPJ GMUWNNENNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8244A20", Offset = "0x8243620", VA = "0x188244A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8246730", Offset = "0x8245330", VA = "0x188246730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static ULUPTVCZNNC ULUPTVCZNNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x824B210", Offset = "0x8249E10", VA = "0x18824B210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x82449B0", Offset = "0x82435B0", VA = "0x1882449B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static ZMREUVZFXUW ZMREUVZFXUW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x824B320", Offset = "0x8249F20", VA = "0x18824B320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8246600", Offset = "0x8245200", VA = "0x188246600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static KIXAFVYQMKF KIXAFVYQMKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x824A360", Offset = "0x8248F60", VA = "0x18824A360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8248800", Offset = "0x8247400", VA = "0x188248800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static NJYKYSIKSWH NJYKYSIKSWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x824B750", Offset = "0x824A350", VA = "0x18824B750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x824A3C0", Offset = "0x8248FC0", VA = "0x18824A3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static QTKAYVEEQUX QTKAYVEEQUX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x824B2C0", Offset = "0x8249EC0", VA = "0x18824B2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x824A440", Offset = "0x8249040", VA = "0x18824A440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static Material VEHATUDNFMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x824B590", Offset = "0x824A190", VA = "0x18824B590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8248780", Offset = "0x8247380", VA = "0x188248780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static Material RYGGZHTPZXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x82461A0", Offset = "0x8244DA0", VA = "0x1882461A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8244A70", Offset = "0x8243670", VA = "0x188244A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static Material QKLMVSQJBHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8246670", Offset = "0x8245270", VA = "0x188246670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8248DD0", Offset = "0x82479D0", VA = "0x188248DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static Material LXRABJWLGSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8247100", Offset = "0x8245D00", VA = "0x188247100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x82486A0", Offset = "0x82472A0", VA = "0x1882486A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static bool YEGYTKETTSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8248640", Offset = "0x8247240", VA = "0x188248640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x82466D0", Offset = "0x82452D0", VA = "0x1882466D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool WHSDOZMRDMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x82470A0", Offset = "0x8245CA0", VA = "0x1882470A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string NSHFCNPGDTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x824A9B0", Offset = "0x82495B0", VA = "0x18824A9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x824B840", Offset = "0x824A440", VA = "0x18824B840")]
		internal RenderPipeline([Optional] MClusterData dataData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8247160", Offset = "0x8245D60", VA = "0x188247160")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x824B080", Offset = "0x8249C80", VA = "0x18824B080")]
		public void ROAGHQSOSHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x824A3B0", Offset = "0x8248FB0", VA = "0x18824A3B0")]
		public void QOGURDDMGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x824B170", Offset = "0x8249D70", VA = "0x18824B170")]
		public bool TBOITQWIFDZ(Hash128 a, [Out] MRBFVUHMMDY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x824A1C0", Offset = "0x8248DC0", VA = "0x18824A1C0")]
		public MRBFVUHMMDY OGBNJYRINGK(SYEYXVRFJJI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8249E20", Offset = "0x8248A20", VA = "0x188249E20")]
		public DVVVFJXEJYG OGBNJYRINGK(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x824A010", Offset = "0x8248C10", VA = "0x18824A010")]
		public CUBFASBWDAQ OGBNJYRINGK(DXVMAPFNXLD a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x824B120", Offset = "0x8249D20", VA = "0x18824B120")]
		public void Remove(MDIMTSZUPFI element)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x824B660", Offset = "0x824A260", VA = "0x18824B660")]
		public static void YGICPPVRPWA(CullingLayer a, OEZUSSOJXPU[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x82467A0", Offset = "0x82453A0", VA = "0x1882467A0")]
		private void HYLGIGBYAIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8249170", Offset = "0x8247D70", VA = "0x188249170")]
		private static void MRAGPKKPYNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8248E50", Offset = "0x8247A50", VA = "0x188248E50")]
		public void LZOJNLUYMQC(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x824B3C0", Offset = "0x8249FC0", VA = "0x18824B3C0")]
		public void UVTMTFFJQHE([Optional] ScriptableRenderContext? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x82463B0", Offset = "0x8244FB0", VA = "0x1882463B0")]
		public void FPWDDQFSPRH(CommandBuffer a, ShadowSplitData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8246200", Offset = "0x8244E00", VA = "0x188246200")]
		public void FPWDDQFSPRH(CommandBuffer a, CameraData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8248870", Offset = "0x8247470", VA = "0x188248870")]
		public void KWPWUSACNZK(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x82485D0", Offset = "0x82471D0", VA = "0x1882485D0")]
		public void JCIJMBVSXIN(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x824A510", Offset = "0x8249110", VA = "0x18824A510")]
		public void RHAIHYPPRMU(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8245BB0", Offset = "0x82447B0", VA = "0x188245BB0")]
		public void EHMNYVNLHGB(CommandBuffer a, CullingLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x824A280", Offset = "0x8248E80", VA = "0x18824A280")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8244AF0", Offset = "0x82436F0", VA = "0x188244AF0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8245AA0", Offset = "0x82446A0", VA = "0x188245AA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class EJCDPGLFDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x27A7650", Offset = "0x27A6250", VA = "0x1827A7650")]
		public static int VNADFWBDTHV(int a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x823E460", Offset = "0x823D060", VA = "0x18823E460")]
		public ClusterTransform(float4x4 rotationTranslation, float4 scaleExtent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x823E2F0", Offset = "0x823CEF0", VA = "0x18823E2F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x823E220", Offset = "0x823CE20", VA = "0x18823E220")]
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
		[Cpp2IlInjected.Address(RVA = "0x823E250", Offset = "0x823CE50", VA = "0x18823E250", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x823E180", Offset = "0x823CD80", VA = "0x18823E180", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x82443B0", Offset = "0x8242FB0", VA = "0x1882443B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x823DD70", Offset = "0x823C970", VA = "0x18823DD70", Slot = "3")]
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
internal class __JobReflectionRegistrationOutput__1460342847
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x824BFF0", Offset = "0x824ABF0", VA = "0x18824BFF0")]
	public static void ERMADPSHGQX()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x824C070", Offset = "0x824AC70", VA = "0x18824C070")]
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
