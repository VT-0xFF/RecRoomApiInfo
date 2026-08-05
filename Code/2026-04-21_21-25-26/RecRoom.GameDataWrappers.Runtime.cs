using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using RecRoom.DataLayer;
using RecRoom.Protobuf;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class IXBFVIJSSFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	public IXBFVIJSSFJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LCQFMTZCBWZ : PIHWNWYMCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private YKTFRGXMAWL.PhysicsMode ZZMUXDLYRLT;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString XSYNNMXPZPB;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString CVUEDSVAFHU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override YKTFRGXMAWL.PhysicsMode FTKDMHHAFOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340", Slot = "13")]
			get
			{
				return default(YKTFRGXMAWL.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9A04B60", Offset = "0x9A03560", VA = "0x189A04B60")]
		public bool JEYLXKZSFBF(PBCTZJZFZQR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A04C00", Offset = "0x9A03600", VA = "0x189A04C00")]
		private static bool YAFMWCNUREU(PBCTZJZFZQR a, [Out] YKTFRGXMAWL.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public LCQFMTZCBWZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class BYDUALCODEY : ILYTVQGUCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected PBCTZJZFZQR WXWXNEHCUXD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual PBCTZJZFZQR PXUWVBIVPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SOKCFTGBVNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9A04AD0", Offset = "0x9A034D0", VA = "0x189A04AD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PRBFAYPQLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9A04AA0", Offset = "0x9A034A0", VA = "0x189A04AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool VMLLIVKIXUT
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9A04B30", Offset = "0x9A03530", VA = "0x189A04B30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MIBSYDJYQXR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9A04A70", Offset = "0x9A03470", VA = "0x189A04A70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ZEAGNSOGVYA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9A04B00", Offset = "0x9A03500", VA = "0x189A04B00", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public BYDUALCODEY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class QHZQHXPFUXF : RVHAFXMPWYR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper WXWXNEHCUXD;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A059B0", Offset = "0x9A043B0", VA = "0x189A059B0")]
		public QHZQHXPFUXF(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A05890", Offset = "0x9A04290", VA = "0x189A05890", Slot = "4")]
		public bool VYXOYXXHTZY(YKTFRGXMAWL a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A05730", Offset = "0x9A04130", VA = "0x189A05730", Slot = "5")]
		public bool VFVWWHUQWRL(YKTFRGXMAWL a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9A053D0", Offset = "0x9A03DD0", VA = "0x189A053D0", Slot = "6")]
		public bool GKGRFOBSIPC(UDENLYSHDTJ a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9A056C0", Offset = "0x9A040C0", VA = "0x189A056C0")]
		private IReadOnlyList<PBCTZJZFZQR> PZCCNNHDJPV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A05580", Offset = "0x9A03F80", VA = "0x189A05580")]
		private bool IFMCAVHDKZT(int a, [Out][NotNullWhen(true)] PBCTZJZFZQR containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class REPHFSZNDCC : PIHWNWYMCLJ, XQOYEERUQJE, YKTFRGXMAWL, ILYTVQGUCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<NMZHWQBYDOS> JWIMQSBXLXR;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override PBCTZJZFZQR PXUWVBIVPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9A05B90", Offset = "0x9A04590", VA = "0x189A05B90", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override YKTFRGXMAWL.PhysicsMode FTKDMHHAFOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9A05B20", Offset = "0x9A04520", VA = "0x189A05B20", Slot = "13")]
			get
			{
				return default(YKTFRGXMAWL.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MUUAXSBGLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9A05B50", Offset = "0x9A04550", VA = "0x189A05B50", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A05A00", Offset = "0x9A04400", VA = "0x189A05A00", Slot = "15")]
		public void DBVZMBQEZGE(UDZQAKBCYXR a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public REPHFSZNDCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class PIHWNWYMCLJ : BYDUALCODEY, YKTFRGXMAWL, ILYTVQGUCCM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract YKTFRGXMAWL.PhysicsMode FTKDMHHAFOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool EYODYHNEIUU
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9A05390", Offset = "0x9A03D90", VA = "0x189A05390", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool LQLSMRDOTLN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9A05330", Offset = "0x9A03D30", VA = "0x189A05330", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool EDZCJSHDRPR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9A05360", Offset = "0x9A03D60", VA = "0x189A05360", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected PIHWNWYMCLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class XSBMCMEUXLV : UDZQAKBCYXR, BOTRVVFZMKX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NMZHWQBYDOS WXWXNEHCUXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<FFBMFZKXNAA> DEWLTEOBNJM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NMZHWQBYDOS PXUWVBIVPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9A05F70", Offset = "0x9A04970", VA = "0x189A05F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool SAMYOGMGHZS
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9A062F0", Offset = "0x9A04CF0", VA = "0x189A062F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType ZJLUWLNZXKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x286DE80", Offset = "0x286C880", VA = "0x18286DE80", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public BOTRVVFZMKX DQGRBEWQNWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9A05C50", Offset = "0x9A04650", VA = "0x189A05C50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 TFRPHTUGTGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9A05E30", Offset = "0x9A04830", VA = "0x189A05E30", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion UPRTWCVGHDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9A06010", Offset = "0x9A04A10", VA = "0x189A06010", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 XGEMPETLZEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9A05C90", Offset = "0x9A04690", VA = "0x189A05C90", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial KOSKITVPIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3300B00", Offset = "0x32FF500", VA = "0x183300B00", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor RSXWRZLXIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1303350", Offset = "0x1301D50", VA = "0x181303350", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float GIMVRFFXQRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9A05C30", Offset = "0x9A04630", VA = "0x189A05C30", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 BUPNMEXUVLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9A05F00", Offset = "0x9A04900", VA = "0x189A05F00", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float AKGIVHGJEWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9A05FD0", Offset = "0x9A049D0", VA = "0x189A05FD0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags HEOPSLBTJHA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x50F64E0", Offset = "0x50F4EE0", VA = "0x1850F64E0", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int EOLIACYLULI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9A05BF0", Offset = "0x9A045F0", VA = "0x189A05BF0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool NNXOJDEQXZU
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9A05E00", Offset = "0x9A04800", VA = "0x189A05E00", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GSWFJWAUOKB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9A06070", Offset = "0x9A04A70", VA = "0x189A06070", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BPBFHBWLTHE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9A06290", Offset = "0x9A04C90", VA = "0x189A06290", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool JYRNGPRCFXT
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9A05FF0", Offset = "0x9A049F0", VA = "0x189A05FF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int PEPQNNFBYAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9A05EA0", Offset = "0x9A048A0", VA = "0x189A05EA0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A060A0", Offset = "0x9A04AA0", VA = "0x189A060A0", Slot = "22")]
		public void WGVYQXVVFFV(VJREOMKJXJR a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public XSBMCMEUXLV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class LNNPDGBGLDR : VJREOMKJXJR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (FFBMFZKXNAA curr, FFBMFZKXNAA next, ShapeConfigFlags flags) WXWXNEHCUXD;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (FFBMFZKXNAA curr, FFBMFZKXNAA next, ShapeConfigFlags flags) PXUWVBIVPWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7380DB0", Offset = "0x737F7B0", VA = "0x187380DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 RIRFUTNLMYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9A052C0", Offset = "0x9A03CC0", VA = "0x189A052C0", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 ZSBTDKWBKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9A05290", Offset = "0x9A03C90", VA = "0x189A05290", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9A05030", Offset = "0x9A03A30", VA = "0x189A05030", Slot = "6")]
		public quaternion VGIIXFJUUQY(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public LNNPDGBGLDR()
		{
		}
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
