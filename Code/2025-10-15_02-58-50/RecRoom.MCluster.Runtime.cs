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
		[Cpp2IlInjected.Address(RVA = "0x84F43A0", Offset = "0x84F31A0", VA = "0x1884F43A0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x21F3750", Offset = "0x21F2550", VA = "0x1821F3750")]
		public static int DPWRPRUQAKW(CullingLayer a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84F0DD0", Offset = "0x84EFBD0", VA = "0x1884F0DD0")]
		public static int BCKOPKXZOWV(CullingLayer a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface XOYHIORCOKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int SIATAIHWZIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LCAYVKFEEAR TBVFQPARAYV(int a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Hash128 DUPHYCIRWJL(int a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RRTransform SDCDJWIRJHN();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MaterialInfo MHPGQFUUGTS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLPNBATXLWU : NRGHGHLEQHI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RRTransform QWGFNDFIQDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Transform RVSMXZIWTRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<YOQJQQKEULQ> OXJHNXNMTHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SYAQEQSTTHY OEYTZRQTMWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ComputeHandle YWJBJNFAPFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool PLUIVKUFXDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private XOYHIORCOKB FMWQUQYKCYI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float ZBUMVUFVZYD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xACE7C0", Offset = "0xACD5C0", VA = "0x180ACE7C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xACE670", Offset = "0xACD470", VA = "0x180ACE670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KZCQTSKDXWL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xFCD270", Offset = "0xFCC070", VA = "0x180FCD270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xFCCCB0", Offset = "0xFCBAB0", VA = "0x180FCCCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CFWZZBBZILN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1602B60", Offset = "0x1601960", VA = "0x181602B60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x1602830", Offset = "0x1601630", VA = "0x181602830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UGUWUTTUJCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x792A730", Offset = "0x7929530", VA = "0x18792A730", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2347E30", Offset = "0x2346C30", VA = "0x182347E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool VJOBSLJQDZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x755EA60", Offset = "0x755D860", VA = "0x18755EA60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84F2E60", Offset = "0x84F1C60", VA = "0x1884F2E60")]
		public GLPNBATXLWU(XOYHIORCOKB a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84F2840", Offset = "0x84F1640", VA = "0x1884F2840")]
		private bool OUDFRHNPREG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84F1BD0", Offset = "0x84F09D0", VA = "0x1884F1BD0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84F2C90", Offset = "0x84F1A90", VA = "0x1884F2C90", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84F2A60", Offset = "0x84F1860", VA = "0x1884F2A60", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84F2830", Offset = "0x84F1630", VA = "0x1884F2830", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface LSXKSQZBJSG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AUYVDWPNFAS(CommandBuffer a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct TexturePropertyData : LSXKSQZBJSG
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD93760", Offset = "0xD92560", VA = "0x180D93760")]
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
			[Cpp2IlInjected.Address(RVA = "0x546B240", Offset = "0x546A040", VA = "0x18546B240")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84FE1C0", Offset = "0x84FCFC0", VA = "0x1884FE1C0")]
		public TexturePropertyData(int id, RenderTargetIdentifier data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84FE170", Offset = "0x84FCF70", VA = "0x1884FE170", Slot = "4")]
		public void AUYVDWPNFAS(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct VectorArrayPropertyData : LSXKSQZBJSG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xD93760", Offset = "0xD92560", VA = "0x180D93760")]
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
			[Cpp2IlInjected.Address(RVA = "0xBB6880", Offset = "0xBB5680", VA = "0x180BB6880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x19C77A0", Offset = "0x19C65A0", VA = "0x1819C77A0")]
		public VectorArrayPropertyData(int id, Vector4[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84FE1E0", Offset = "0x84FCFE0", VA = "0x1884FE1E0", Slot = "4")]
		public void AUYVDWPNFAS(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct FloatArrayPropertyData : LSXKSQZBJSG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD93760", Offset = "0xD92560", VA = "0x180D93760")]
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
			[Cpp2IlInjected.Address(RVA = "0xBB6880", Offset = "0xBB5680", VA = "0x180BB6880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x19C77A0", Offset = "0x19C65A0", VA = "0x1819C77A0")]
		public FloatArrayPropertyData(int id, float[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84F1BA0", Offset = "0x84F09A0", VA = "0x1884F1BA0", Slot = "4")]
		public void AUYVDWPNFAS(CommandBuffer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct KeywordPropertyData : LSXKSQZBJSG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xBB6870", Offset = "0xBB5670", VA = "0x180BB6870")]
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
			[Cpp2IlInjected.Address(RVA = "0xF3B1B0", Offset = "0xF39FB0", VA = "0x180F3B1B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1B29B00", Offset = "0x1B28900", VA = "0x181B29B00")]
		public KeywordPropertyData(string name, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84F4360", Offset = "0x84F3160", VA = "0x1884F4360", Slot = "4")]
		public void AUYVDWPNFAS(CommandBuffer a)
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
			[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF319E0", Offset = "0xF307E0", VA = "0x180F319E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC5E20", Offset = "0xAC4C20", VA = "0x180AC5E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x1119700", Offset = "0x1118500", VA = "0x181119700")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84F50C0", Offset = "0x84F3EC0", VA = "0x1884F50C0")]
		public MaterialInfo(Color color, int colorIndex, int typeIndex, float detailScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x13B5EB0", Offset = "0x13B4CB0", VA = "0x1813B5EB0")]
		private static float4 YBZUUXOQLNL(Color a)
		{
			return default(float4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84F5030", Offset = "0x84F3E30", VA = "0x1884F5030")]
		private static Hash128 WJXFHKVUAIJ(MaterialInfo a)
		{
			return default(Hash128);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SYAQEQSTTHY : NRGHGHLEQHI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly string BAKRDSSNBOQ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly string JDTJLHLAGIX;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly string VAUSHJHBSFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private MaterialInfo ANATFUDVWIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ClusterMaterial CNRMIMONWVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Hash128 UAYYAMOGCLN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ComputeHandle JCBWFDLZJNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x12D31D0", Offset = "0x12D1FD0", VA = "0x1812D31D0")]
			[CompilerGenerated]
			get
			{
				return default(ComputeHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1869430", Offset = "0x1868230", VA = "0x181869430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool KZCQTSKDXWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x13890B0", Offset = "0x1387EB0", VA = "0x1813890B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1AAFEC0", Offset = "0x1AAECC0", VA = "0x181AAFEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool CFWZZBBZILN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x13890E0", Offset = "0x1387EE0", VA = "0x1813890E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8456450", Offset = "0x8455250", VA = "0x188456450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool VJOBSLJQDZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool UGUWUTTUJCV
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x13890F0", Offset = "0x1387EF0", VA = "0x1813890F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84FDE70", Offset = "0x84FCC70", VA = "0x1884FDE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int XYUGDAJCILX
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84FDA50", Offset = "0x84FC850", VA = "0x1884FDA50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84FDF70", Offset = "0x84FCD70", VA = "0x1884FDF70")]
		public SYAQEQSTTHY(MaterialInfo a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84FDAA0", Offset = "0x84FC8A0", VA = "0x1884FDAA0")]
		private bool OUDFRHNPREG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84FD8C0", Offset = "0x84FC6C0", VA = "0x1884FD8C0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84FDA10", Offset = "0x84FC810", VA = "0x1884FDA10")]
		private static ClusterMaterial FQUYETCARHU(MaterialInfo a)
		{
			return default(ClusterMaterial);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84FDCC0", Offset = "0x84FCAC0", VA = "0x1884FDCC0", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84FDBB0", Offset = "0x84FC9B0", VA = "0x1884FDBB0", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84F4420", Offset = "0x84F3220", VA = "0x1884F4420", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84F4620", Offset = "0x84F3420", VA = "0x1884F4620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
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
		private QBLZXNQGHMJ opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static RenderPipeline CZOOIFEIJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84F4F30", Offset = "0x84F3D30", VA = "0x1884F4F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84F4C60", Offset = "0x84F3A60", VA = "0x1884F4C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84F4700", Offset = "0x84F3500", VA = "0x1884F4700", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84F46D0", Offset = "0x84F34D0", VA = "0x1884F46D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84F4CD0", Offset = "0x84F3AD0", VA = "0x1884F4CD0")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x19DB410", Offset = "0x19DA210", VA = "0x1819DB410")]
		public MClusterRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class VYGPFLWICRH<a> : IDisposable where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private YAYJHRRBOEM PRDMCPYTHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private YAYJHRRBOEM SCVVFMHXYNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ComputeBuffer UYHBSUOVGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private RenderTexture IHNUBUHGZUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int QFYDSBMCTMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int DNPFRMDYXQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private string TQRBVKXIHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string JEAZEBRDRWW;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int DODEZUTZSIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA4060", Offset = "0xAA2E60", VA = "0x180AA4060")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int HZKSYSZHYAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAEC640", Offset = "0xAEB440", VA = "0x180AEC640")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int IXPXEDNZYSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xACE7D0", Offset = "0xACD5D0", VA = "0x180ACE7D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x641F140", Offset = "0x641DF40", VA = "0x18641F140")]
		public VYGPFLWICRH(string a, int b, [Optional] RenderTextureFormat? c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x641DA10", Offset = "0x641C810", VA = "0x18641DA10")]
		public void Update(CommandBuffer cmd, NativeArray<a> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x641C960", Offset = "0x641B760", VA = "0x18641C960")]
		public void Bind(CommandBuffer cmd, ComputeShader computeShader, int kernel, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x641C100", Offset = "0x641AF00", VA = "0x18641C100")]
		public void Bind(Material material, int shaderPropertyID = -1, int shaderPropertyTextureID = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x641D6A0", Offset = "0x641C4A0", VA = "0x18641D6A0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface IEKJTLQTWKS
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Bind(Material mat);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class VBYHXLKJWBF<a, b> : IEKJTLQTWKS, IDisposable where a : struct where b : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		protected bool[] PROWSYXPSJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected YAYJHRRBOEM ZVLHQZILBSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected YAYJHRRBOEM VGZQOENOLKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		protected NativeArray<int> HJIYRUFAVCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected NativeArray<a> CKJNZNOCNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected int ZCOTDGVDGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected int AZVPXZKRSQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected VYGPFLWICRH<int> KVDBZQGPREI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected VYGPFLWICRH<a> IQMLDMCWYNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected VYGPFLWICRH<b> BKRJUSHJJLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected ComputeShader PVQXOSSEVUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected int ZUJYREFARJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected int QTPGIAUQPZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		protected int QTUNFHONZKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected int QTZUCOILIWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected int JDHIYHZMNRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected int UIIEICIONJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int RUQJONVXRPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int TFLHKPJRKSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected int GRLBFDOFNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int OLANINXOSJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected int LDHDODZMSMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected int EWUMVKPTHFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected string XMGGISQLPTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected float[] GDVEUXQYPTG;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int NGFGTGYDNVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x63F8CE0", Offset = "0x63F7AE0", VA = "0x1863F8CE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string WBOISBYEASV
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x63FBBA0", Offset = "0x63FA9A0", VA = "0x1863FBBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x63FD3F0", Offset = "0x63FC1F0", VA = "0x1863FD3F0")]
		public VBYHXLKJWBF(string a, int b, int c, RenderTextureFormat d, ComputeShader e, int f = 0, int g = 0, int h = 0, int i = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63F6F70", Offset = "0x63F5D70", VA = "0x1863F6F70")]
		public int AZYREXIFBDG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63F8CF0", Offset = "0x63F7AF0", VA = "0x1863F8CF0")]
		protected void LPHTWFMEWVL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63F6FE0", Offset = "0x63F5DE0", VA = "0x1863F6FE0")]
		public ComputeHandle Add(a data)
		{
			return default(ComputeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x63FADB0", Offset = "0x63F9BB0", VA = "0x1863FADB0")]
		public bool Update(ComputeHandle handle, a data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x63FA4D0", Offset = "0x63F92D0", VA = "0x1863FA4D0")]
		public bool Remove(ComputeHandle handle)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "6")]
		protected virtual void XMFITUNCOQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63F9440", Offset = "0x63F8240", VA = "0x1863F9440", Slot = "7")]
		public void OICXGKKNCXW(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63F9120", Offset = "0x63F7F20", VA = "0x1863F9120", Slot = "8")]
		public void OICXGKKNCXW(CommandBuffer a, ComputeShader b, int c = -1, int d = -1, int e = -1, int f = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63F83D0", Offset = "0x63F71D0", VA = "0x1863F83D0", Slot = "9")]
		public void Bind(CommandBuffer cmd, ComputeShader shader, int kernelIndex = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63F7F80", Offset = "0x63F6D80", VA = "0x1863F7F80", Slot = "4")]
		public void Bind(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x63F8810", Offset = "0x63F7610", VA = "0x1863F8810", Slot = "10")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface YAYJHRRBOEM : IDisposable
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
	public static class QBABFQCFFOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ResourceHandle : YAYJHRRBOEM, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private IDisposable resource;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xBB6880", Offset = "0xBB5680", VA = "0x180BB6880", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x2D1D8D0", Offset = "0x2D1C6D0", VA = "0x182D1D8D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xF18790", Offset = "0xF17590", VA = "0x180F18790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x84FD880", Offset = "0x84FC680", VA = "0x1884FD880")]
			internal ResourceHandle(IDisposable createdResource, ulong cpuMemorySize, ulong gpuMemorySize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x84FD800", Offset = "0x84FC600", VA = "0x1884FD800", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct RenderTextureHandle : YAYJHRRBOEM, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private RenderTexture renderTexture;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public ulong SizeInMemoryCPU
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xBB6880", Offset = "0xBB5680", VA = "0x180BB6880", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x2D1D8D0", Offset = "0x2D1C6D0", VA = "0x182D1D8D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public ulong SizeInMemoryGPU
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xF18790", Offset = "0xF17590", VA = "0x180F18790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x84FD7D0", Offset = "0x84FC5D0", VA = "0x1884FD7D0")]
			public RenderTextureHandle(RenderTexture texture, ulong gpuSize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x84FD730", Offset = "0x84FC530", VA = "0x1884FD730", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static ulong HQFGZLPDMXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x84F5E40", Offset = "0x84F4C40", VA = "0x1884F5E40")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x84F5CF0", Offset = "0x84F4AF0", VA = "0x1884F5CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static ulong LESIKNWJQDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x84F55D0", Offset = "0x84F43D0", VA = "0x1884F55D0")]
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x84F5CB0", Offset = "0x84F4AB0", VA = "0x1884F5CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84F5610", Offset = "0x84F4410", VA = "0x1884F5610")]
		public static ComputeBuffer Create(int count, int stride, ComputeBufferType type, [Out] YAYJHRRBOEM handle, ComputeBufferMode mode = ComputeBufferMode.Immutable)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x84F57D0", Offset = "0x84F45D0", VA = "0x1884F57D0")]
		public static RenderTexture Create(int height, int width, int depth, RenderTextureFormat format, [Out] YAYJHRRBOEM handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3C26DE0", Offset = "0x3C25BE0", VA = "0x183C26DE0")]
		public static NativeArray<a> RBTXAFADKDO<a>(NativeArray<a> a, ulong b, [Out] YAYJHRRBOEM c) where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3C26190", Offset = "0x3C24F90", VA = "0x183C26190")]
		public static NativeArray<T> Create<T>(int length, Allocator allocator, [Out] YAYJHRRBOEM handle, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84F5B70", Offset = "0x84F4970", VA = "0x1884F5B70")]
		public static void Destroy(YAYJHRRBOEM resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84F5D30", Offset = "0x84F4B30", VA = "0x1884F5D30")]
		public static uint OFEEDVFPVLJ(RenderTextureFormat a)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ECQQGNRXTJF : VBYHXLKJWBF<ClusterTransform, ClusterTransform>
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
			[Cpp2IlInjected.Address(RVA = "0x84F1230", Offset = "0x84F0030", VA = "0x1884F1230")]
			public SampleTransformData(NativeArray<int> indexSrc, NativeArray<float> extentSrc, NativeArray<float4x4> transformDst, NativeArray<float4> scaleExtentDst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84FDFB0", Offset = "0x84FCDB0", VA = "0x1884FDFB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84F1230", Offset = "0x84F0030", VA = "0x1884F1230")]
			public CreateClusterTransformUpdateData(NativeArray<int> indexSrc, NativeArray<float4x4> transformData, NativeArray<float4> scaleExtentSrc, NativeArray<ClusterTransform> dst)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x84F11C0", Offset = "0x84EFFC0", VA = "0x1884F11C0", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private const byte AIJOKYENTTQ = 255;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TransformAccessArray AGDKRXFQLQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> XRKUGRVYAXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NativeArray<float4x4> FMSDDTYZOXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NativeArray<float4> CKMWXQBPPGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private NativeArray<int> KYJNDJPRURG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NativeArray<int> KHIMEZHVOPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private YAYJHRRBOEM SQYRHELRYHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private YAYJHRRBOEM EFDISMTZXHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private YAYJHRRBOEM SCSFTLBZNNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private YAYJHRRBOEM SDRSJOAZJBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private YAYJHRRBOEM BXQADSWHKQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Transform BDNMJSHRGOO;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84F18C0", Offset = "0x84F06C0", VA = "0x1884F18C0")]
		public ECQQGNRXTJF(int a, int b, ComputeShader c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84F1600", Offset = "0x84F0400", VA = "0x1884F1600", Slot = "6")]
		protected override void XMFITUNCOQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84F1300", Offset = "0x84F0100", VA = "0x1884F1300")]
		private void EKOYXDDOMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84F13C0", Offset = "0x84F01C0", VA = "0x1884F13C0")]
		public bool GHIHYWFZKER(ComputeHandle a, Transform b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84F1520", Offset = "0x84F0320", VA = "0x1884F1520")]
		public void PVASKVEYOBK(ComputeHandle a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84F1810", Offset = "0x84F0610", VA = "0x1884F1810")]
		public void ZGMRPRHERFP(ComputeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84F1260", Offset = "0x84F0060", VA = "0x1884F1260", Slot = "10")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface LCAYVKFEEAR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeMesh Complete();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface OEWVQPXDGKC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		Hash128 CAGDNKYEFHV
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		int QRLICLCFEGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int LLZOEXKSKLS
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		NativeArray<float3> YJGZPHQQOPO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		NativeArray<float3> LKYCNSPWAZO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		NativeArray<float4> UXYKSKDAAWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		NativeArray<int> TIVBFEJDHWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		NativeArray<float2> BWZWSOYTUNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		NativeArray<float4> HQZZTXBFZXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		int UHPAYIVOBDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int NEIIMGULTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		int GZGZVMUZXNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		bool QPHCWKLJAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OICXGKKNCXW();
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class XMUBIHCOVZL : OEWVQPXDGKC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private LCAYVKFEEAR BRSEXZZVYGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private NativeMesh YAQHUCUSNHI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Hash128 CAGDNKYEFHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xF319E0", Offset = "0xF307E0", VA = "0x180F319E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Hash128);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xF31A00", Offset = "0xF30800", VA = "0x180F31A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool JNNHXWUSETM
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0940", Offset = "0xA9F740", VA = "0x180AA0940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int QRLICLCFEGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAC5E20", Offset = "0xAC4C20", VA = "0x180AC5E20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xF654B0", Offset = "0xF642B0", VA = "0x180F654B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int LLZOEXKSKLS
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAA7140", Offset = "0xAA5F40", VA = "0x180AA7140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private int PLQKDHGAZQO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1DF42E0", Offset = "0x1DF30E0", VA = "0x181DF42E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public NativeArray<float3> YJGZPHQQOPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x84FE530", Offset = "0x84FD330", VA = "0x1884FE530", Slot = "7")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public NativeArray<float3> LKYCNSPWAZO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x84FE2A0", Offset = "0x84FD0A0", VA = "0x1884FE2A0", Slot = "8")]
			get
			{
				return default(NativeArray<float3>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public NativeArray<float4> UXYKSKDAAWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x84FE4C0", Offset = "0x84FD2C0", VA = "0x1884FE4C0", Slot = "9")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public NativeArray<int> TIVBFEJDHWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x84FE300", Offset = "0x84FD100", VA = "0x1884FE300", Slot = "10")]
			get
			{
				return default(NativeArray<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public NativeArray<float2> BWZWSOYTUNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x84FE490", Offset = "0x84FD290", VA = "0x1884FE490", Slot = "11")]
			get
			{
				return default(NativeArray<float2>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public NativeArray<float4> HQZZTXBFZXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x84FE2D0", Offset = "0x84FD0D0", VA = "0x1884FE2D0", Slot = "12")]
			get
			{
				return default(NativeArray<float4>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool QPHCWKLJAFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB009E0", Offset = "0xAFF7E0", VA = "0x180B009E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB01120", Offset = "0xAFFF20", VA = "0x180B01120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int UHPAYIVOBDS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x84FE370", Offset = "0x84FD170", VA = "0x1884FE370", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int NEIIMGULTGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x84FE4F0", Offset = "0x84FD2F0", VA = "0x1884FE4F0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int GZGZVMUZXNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x84FE510", Offset = "0x84FD310", VA = "0x1884FE510", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84FE5A0", Offset = "0x84FD3A0", VA = "0x1884FE5A0")]
		public XMUBIHCOVZL(Hash128 a, LCAYVKFEEAR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x84FE380", Offset = "0x84FD180", VA = "0x1884FE380", Slot = "16")]
		public void OICXGKKNCXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84FE210", Offset = "0x84FD010", VA = "0x1884FE210", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xD93760", Offset = "0xD92560", VA = "0x180D93760")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x15F7750", Offset = "0x15F6550", VA = "0x1815F7750")]
		public ComputeHandle(int index = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x84F0C20", Offset = "0x84EFA20", VA = "0x1884F0C20", Slot = "4")]
		public bool Equals(ComputeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84F0C70", Offset = "0x84EFA70", VA = "0x1884F0C70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84F0D40", Offset = "0x84EFB40", VA = "0x1884F0D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class YOQJQQKEULQ : NRGHGHLEQHI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool PLUIVKUFXDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private OEWVQPXDGKC AQVFYEYBLWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private List<ComputeHandle> LUOBTKTZZCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private List<ComputeHandle> VIRXAVEPFQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<ComputeHandle> GCILUYONGPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Dictionary<int, uint> POKUVVKKWXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int PKNCIBRNADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int YUEFTAMGVHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int LUZVEXBSRCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int PWKMITGTSGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int VPJROIQOCJA;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int XYUGDAJCILX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x84FF2C0", Offset = "0x84FE0C0", VA = "0x1884FF2C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int DODEZUTZSIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x84FF370", Offset = "0x84FE170", VA = "0x1884FF370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool KZCQTSKDXWL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAF1380", Offset = "0xAF0180", VA = "0x180AF1380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xBF7410", Offset = "0xBF6210", VA = "0x180BF7410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool CFWZZBBZILN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xBF7480", Offset = "0xBF6280", VA = "0x180BF7480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xBF7400", Offset = "0xBF6200", VA = "0x180BF7400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool VJOBSLJQDZT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool UGUWUTTUJCV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2AA7610", Offset = "0x2AA6410", VA = "0x182AA7610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xBF7470", Offset = "0xBF6270", VA = "0x180BF7470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float ZBUMVUFVZYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x10F17C0", Offset = "0x10F05C0", VA = "0x1810F17C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x10F1900", Offset = "0x10F0700", VA = "0x1810F1900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8500230", Offset = "0x84FF030", VA = "0x188500230")]
		public YOQJQQKEULQ(OEWVQPXDGKC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84FF3B0", Offset = "0x84FE1B0", VA = "0x1884FF3B0")]
		private void MLZMXMMSIAK(OEWVQPXDGKC a, int b, int c, int d, int e, VertexData f, float g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84FEFF0", Offset = "0x84FDDF0", VA = "0x1884FEFF0")]
		private void FQORYAOJIIA(OEWVQPXDGKC a, int b, int c, uint3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x84FF8A0", Offset = "0x84FE6A0", VA = "0x1884FF8A0")]
		private bool OUDFRHNPREG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84FE5F0", Offset = "0x84FD3F0", VA = "0x1884FE5F0", Slot = "4")]
		public bool Add()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85001B0", Offset = "0x84FEFB0", VA = "0x1885001B0", Slot = "5")]
		public bool Update()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x84FFB40", Offset = "0x84FE940", VA = "0x1884FFB40", Slot = "6")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84FEF90", Offset = "0x84FDD90", VA = "0x1884FEF90")]
		public void MABTICPUFCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x84FEF90", Offset = "0x84FDD90", VA = "0x1884FEF90", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface NRGHGHLEQHI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool VJOBSLJQDZT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool UGUWUTTUJCV
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
	public class HBUETEOHKSL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly float EEIGAKHHAVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Dictionary<Hash128, YOQJQQKEULQ> HZOULAUAGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private Dictionary<Hash128, SYAQEQSTTHY> OKUFPKZFCYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Queue<NRGHGHLEQHI> NWRRZIBGAZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Queue<NRGHGHLEQHI> KNBMLSBQCSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private Queue<NRGHGHLEQHI> YQQANAWTZHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int AEYZRPLJHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int MQXHWRUSBXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private float LJHJBMYVRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool SHBSYZNKDRG;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool GWYNVVPNJVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1A11620", Offset = "0x1A10420", VA = "0x181A11620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x1A116B0", Offset = "0x1A104B0", VA = "0x181A116B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool MQODKWLTPUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x84F3F80", Offset = "0x84F2D80", VA = "0x1884F3F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string WBOISBYEASV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x84F3BE0", Offset = "0x84F29E0", VA = "0x1884F3BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84F3690", Offset = "0x84F2490", VA = "0x1884F3690")]
		public void LAVYOBIXGUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2672BA0", Offset = "0x26719A0", VA = "0x182672BA0")]
		public void WVWLHCVTASV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84F4010", Offset = "0x84F2E10", VA = "0x1884F4010")]
		public HBUETEOHKSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84F30F0", Offset = "0x84F1EF0", VA = "0x1884F30F0")]
		public GLPNBATXLWU IPFDCTVTWHM(XOYHIORCOKB a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84F3210", Offset = "0x84F2010", VA = "0x1884F3210")]
		public SYAQEQSTTHY IPFDCTVTWHM(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x84F3B70", Offset = "0x84F2970", VA = "0x1884F3B70")]
		public bool PENVFMVTIGG(Hash128 a, [Out] YOQJQQKEULQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84F3340", Offset = "0x84F2140", VA = "0x1884F3340")]
		public YOQJQQKEULQ IPFDCTVTWHM(OEWVQPXDGKC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x84F30D0", Offset = "0x84F1ED0", VA = "0x1884F30D0")]
		private void HDQJPKEDTET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x84F3600", Offset = "0x84F2400", VA = "0x1884F3600")]
		private bool JKKGLBERRHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x84F36A0", Offset = "0x84F24A0", VA = "0x1884F36A0")]
		public void OICXGKKNCXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x84F2FC0", Offset = "0x84F1DC0", VA = "0x1884F2FC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84F2F10", Offset = "0x84F1D10", VA = "0x1884F2F10")]
		public void Cleanup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class OYZKIUDGLWA : VBYHXLKJWBF<ObjectInfo, ObjectInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84F51F0", Offset = "0x84F3FF0", VA = "0x1884F51F0")]
		public OYZKIUDGLWA(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class IZRMZDFVJIO : VBYHXLKJWBF<ClusterMaterial, ClusterMaterial>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84F42B0", Offset = "0x84F30B0", VA = "0x1884F42B0")]
		public IZRMZDFVJIO(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class MLHSGOCUPDH : VBYHXLKJWBF<ClusterInfo, ClusterInfo>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x84F4F80", Offset = "0x84F3D80", VA = "0x1884F4F80")]
		public MLHSGOCUPDH(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class QITSXMHOQQD : VBYHXLKJWBF<ClusterVertexData, ClusterCompressedVertexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x84F63A0", Offset = "0x84F51A0", VA = "0x1884F63A0")]
		public QITSXMHOQQD(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class HMAQUMVJSDJ : VBYHXLKJWBF<ClusterIndexData, ClusterIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x84F4180", Offset = "0x84F2F80", VA = "0x1884F4180")]
		public HMAQUMVJSDJ(int a, int b, ComputeShader c, int d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class QBLZXNQGHMJ : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private RenderPipeline GUQSHCZBRRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool LSVCMPLGLCU;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static bool ZIMZXCYRGBY;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84F6330", Offset = "0x84F5130", VA = "0x1884F6330")]
		public QBLZXNQGHMJ(RenderPipeline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x84F6210", Offset = "0x84F5010", VA = "0x1884F6210", Slot = "5")]
		public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x84F5E80", Offset = "0x84F4C80", VA = "0x1884F5E80", Slot = "6")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x84F5EC0", Offset = "0x84F4CC0", VA = "0x1884F5EC0", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class BQLREEHBFXQ
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
			[Cpp2IlInjected.Address(RVA = "0x84F6500", Offset = "0x84F5300", VA = "0x1884F6500")]
			public RenderPassContext(string passName, ScriptableRenderContext currentContext, [Out] CommandBuffer externCmd)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x84F6450", Offset = "0x84F5250", VA = "0x1884F6450", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x84F0430", Offset = "0x84EF230", VA = "0x1884F0430")]
		public static bool MRQZRCUOUDM(RenderingData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x84F0240", Offset = "0x84EF040", VA = "0x1884F0240")]
		public static void FHGMNKXTJOW(CommandBuffer a, ScriptableRenderContext b, ShadowDrawingSettings c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class RenderPipeline : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class IZOZUFZJZPU
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly int XZKHFITTESY;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly int BXXSBQDHLFD;
		}

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static VYGPFLWICRH<ClusterReference> VSMNFDABJPL;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static VYGPFLWICRH<uint> HDCWYDAKLFK;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static YAYJHRRBOEM PVTTGUFCWQW;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static ComputeBuffer PULNOVPWROU;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static List<IEKJTLQTWKS> KECLVTSBZCN;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static int SGXXSECHVSR;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int VQACYSRRSCJ;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int EMRHIEVVYKC;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int PAUHOEBBPHA;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static int[] FXRWOKDPTQI;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static Material[] GRUCPUPQXDF;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static LSXKSQZBJSG[][] ENITMHLRKDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Plane[] JQWXRATSUME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int EUSNOQCLXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int HPAWQPSPZAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int TWKWPFKSWWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int UVPKUJLIMZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int NDFFBJDARJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int NWJQDJXCMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int NJJZMMEHOOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int YMTNMOWSEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int IZBOECIHQBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int JYORAUDAXPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int RHKLNZSKNRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int FYJQUQYVUTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int JAYQTNLLKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int QMXNZAREESB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int HPRKGPQISWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int MSFLWJPVIVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int YGWHQMZDWUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int UEPHMOAZFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private float[] GOEXVFWHVDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private HBUETEOHKSL HADYMJQBZWX;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static bool CEUTKOAAMIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x84F8E50", Offset = "0x84F7C50", VA = "0x1884F8E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x84FD160", Offset = "0x84FBF60", VA = "0x1884FD160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static bool UJAKGXSDNXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x84F9C20", Offset = "0x84F8A20", VA = "0x1884F9C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x84FC480", Offset = "0x84FB280", VA = "0x1884FC480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static MClusterData JGQJHTLYZSP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x84F9AD0", Offset = "0x84F88D0", VA = "0x1884F9AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x84F6610", Offset = "0x84F5410", VA = "0x1884F6610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static ECQQGNRXTJF ECQQGNRXTJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x84F9C70", Offset = "0x84F8A70", VA = "0x1884F9C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x84FBE30", Offset = "0x84FAC30", VA = "0x1884FBE30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static OYZKIUDGLWA OYZKIUDGLWA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x84FC3B0", Offset = "0x84FB1B0", VA = "0x1884FC3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x84F6680", Offset = "0x84F5480", VA = "0x1884F6680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static IZRMZDFVJIO IZRMZDFVJIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x84FBDE0", Offset = "0x84FABE0", VA = "0x1884FBDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x84FCA40", Offset = "0x84FB840", VA = "0x1884FCA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static MLHSGOCUPDH MLHSGOCUPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x84FD1C0", Offset = "0x84FBFC0", VA = "0x1884FD1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x84FBCF0", Offset = "0x84FAAF0", VA = "0x1884FBCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static QITSXMHOQQD QITSXMHOQQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x84F7D30", Offset = "0x84F6B30", VA = "0x1884F7D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x84FBC70", Offset = "0x84FAA70", VA = "0x1884FBC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static HMAQUMVJSDJ HMAQUMVJSDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x84F9B20", Offset = "0x84F8920", VA = "0x1884F9B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x84FBF00", Offset = "0x84FAD00", VA = "0x1884FBF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static Material UZEMGOFXUWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x84FC350", Offset = "0x84FB150", VA = "0x1884FC350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x84FC130", Offset = "0x84FAF30", VA = "0x1884FC130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static Material PWHTVHSUEXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x84FBEA0", Offset = "0x84FACA0", VA = "0x1884FBEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x84FC400", Offset = "0x84FB200", VA = "0x1884FC400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static Material JZXAKBJAIPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x84F7030", Offset = "0x84F5E30", VA = "0x1884F7030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x84FBD60", Offset = "0x84FAB60", VA = "0x1884FBD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static Material QCQSKYHCQRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x84FC2F0", Offset = "0x84FB0F0", VA = "0x1884FC2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x84FA180", Offset = "0x84F8F80", VA = "0x1884FA180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static bool PGYNARZPXDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x84F9CC0", Offset = "0x84F8AC0", VA = "0x1884F9CC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x84FBF80", Offset = "0x84FAD80", VA = "0x1884FBF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool MQODKWLTPUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x84FD3E0", Offset = "0x84FC1E0", VA = "0x1884FD3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string WBOISBYEASV
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x84FCAB0", Offset = "0x84FB8B0", VA = "0x1884FCAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84FD4D0", Offset = "0x84FC2D0", VA = "0x1884FD4D0")]
		internal RenderPipeline([Optional] MClusterData dataData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84FA800", Offset = "0x84F9600", VA = "0x1884FA800")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84F9B80", Offset = "0x84F8980", VA = "0x1884F9B80")]
		public void GDJMKFHJPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x84F8EA0", Offset = "0x84F7CA0", VA = "0x1884F8EA0")]
		public void EFYZDYNARBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x84F6B90", Offset = "0x84F5990", VA = "0x1884F6B90")]
		public bool BJDNTIXHCVB(Hash128 a, [Out] YOQJQQKEULQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84FA0C0", Offset = "0x84F8EC0", VA = "0x1884FA0C0")]
		public YOQJQQKEULQ IPFDCTVTWHM(OEWVQPXDGKC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84F9ED0", Offset = "0x84F8CD0", VA = "0x1884F9ED0")]
		public SYAQEQSTTHY IPFDCTVTWHM(MaterialInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84F9D20", Offset = "0x84F8B20", VA = "0x1884F9D20")]
		public GLPNBATXLWU IPFDCTVTWHM(XOYHIORCOKB a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84FC1B0", Offset = "0x84FAFB0", VA = "0x1884FC1B0")]
		public void Remove(NRGHGHLEQHI element)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x84FC200", Offset = "0x84FB000", VA = "0x1884FC200")]
		public static void SQBIQFOZTAE(CullingLayer a, LSXKSQZBJSG[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x84F8EB0", Offset = "0x84F7CB0", VA = "0x1884F8EB0")]
		private void EGSSRSOWTQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84F7090", Offset = "0x84F5E90", VA = "0x1884F7090")]
		private static void DQMVGSDICXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x84F97B0", Offset = "0x84F85B0", VA = "0x1884F97B0")]
		public void EOMNCXARDXA(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x84FD210", Offset = "0x84FC010", VA = "0x1884FD210")]
		public void YEITSCZSZWK([Optional] ScriptableRenderContext? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x84F6C30", Offset = "0x84F5A30", VA = "0x1884F6C30")]
		public void CHGPKWXJPXL(CommandBuffer a, ShadowSplitData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x84F6E80", Offset = "0x84F5C80", VA = "0x1884F6E80")]
		public void CHGPKWXJPXL(CommandBuffer a, CameraData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x84FC4E0", Offset = "0x84FB2E0", VA = "0x1884FC4E0")]
		public void VCNMTEHBPPW(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x84FC0C0", Offset = "0x84FAEC0", VA = "0x1884FC0C0")]
		public void PECYDSMBNYV(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x84F66F0", Offset = "0x84F54F0", VA = "0x1884F66F0")]
		public void AXGGARSQGAI(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x84FA200", Offset = "0x84F9000", VA = "0x1884FA200")]
		public void ISLUBNNSAUB(CommandBuffer a, CullingLayer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x84FBFE0", Offset = "0x84FADE0", VA = "0x1884FBFE0")]
		public void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x84F7D90", Offset = "0x84F6B90", VA = "0x1884F7D90")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x84F8D40", Offset = "0x84F7B40", VA = "0x1884F8D40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class JKDMLFVIGQV
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2A194E0", Offset = "0x2A182E0", VA = "0x182A194E0")]
		public static int PHUKRSPXXID(int a, int b)
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
		[Cpp2IlInjected.Address(RVA = "0x84F0BF0", Offset = "0x84EF9F0", VA = "0x1884F0BF0")]
		public ClusterTransform(float4x4 rotationTranslation, float4 scaleExtent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x84F0A80", Offset = "0x84EF880", VA = "0x1884F0A80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F09B0", Offset = "0x84EF7B0", VA = "0x1884F09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F09E0", Offset = "0x84EF7E0", VA = "0x1884F09E0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F0910", Offset = "0x84EF710", VA = "0x1884F0910", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F52A0", Offset = "0x84F40A0", VA = "0x1884F52A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F0510", Offset = "0x84EF310", VA = "0x1884F0510", Slot = "3")]
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
internal class __JobReflectionRegistrationOutput__1433128138
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8500380", Offset = "0x84FF180", VA = "0x188500380")]
	public static void JFMNTDRBNOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x8500370", Offset = "0x84FF170", VA = "0x188500370")]
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
