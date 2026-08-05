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
internal class YKXBFGPKFMQ
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
	[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
	public YKXBFGPKFMQ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RHVUQWQLDAS : EWCEDEYIQEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BQCQIEQQHBG.PhysicsMode VCTFHTSFJSA;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString NPUKYITATEO;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString DRMVWMHXVKJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override BQCQIEQQHBG.PhysicsMode JFHGJCNHULR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420", Slot = "13")]
			get
			{
				return default(BQCQIEQQHBG.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D1D0", Offset = "0x9A0BBD0", VA = "0x189A0D1D0")]
		public bool NZNUPPGPNZQ(FKWMEATAMCU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D270", Offset = "0x9A0BC70", VA = "0x189A0D270")]
		private static bool UKCSJUMBLON(FKWMEATAMCU a, [Out] BQCQIEQQHBG.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public RHVUQWQLDAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class UCBTEJCTUXH : NZLOMSJGHUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected FKWMEATAMCU WWGTSSQWUTA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual FKWMEATAMCU IONDNHXDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool UGPHNKPSBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D6D0", Offset = "0x9A0C0D0", VA = "0x189A0D6D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool SOGCMBSBNQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D6A0", Offset = "0x9A0C0A0", VA = "0x189A0D6A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PNQOCNKRJDW
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D730", Offset = "0x9A0C130", VA = "0x189A0D730", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JCSPEICNNRY
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D760", Offset = "0x9A0C160", VA = "0x189A0D760", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NZPXTGICYFF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D700", Offset = "0x9A0C100", VA = "0x189A0D700", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public UCBTEJCTUXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HNIIHZNBEXA : GKRLFCBIQQM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper WWGTSSQWUTA;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C760", Offset = "0x9A0B160", VA = "0x189A0C760")]
		public HNIIHZNBEXA(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C350", Offset = "0x9A0AD50", VA = "0x189A0C350", Slot = "4")]
		public bool SHYNFVAHWEZ(BQCQIEQQHBG a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C1F0", Offset = "0x9A0ABF0", VA = "0x189A0C1F0", Slot = "5")]
		public bool SBUGKXEHSIA(BQCQIEQQHBG a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C470", Offset = "0x9A0AE70", VA = "0x189A0C470", Slot = "6")]
		public bool WADXQGRYWXL(QXNTSGUTMLW a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C180", Offset = "0x9A0AB80", VA = "0x189A0C180")]
		private IReadOnlyList<FKWMEATAMCU> CZCMHXQTXAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C620", Offset = "0x9A0B020", VA = "0x189A0C620")]
		private bool YXTZBGFZKJC(int a, [Out][NotNullWhen(true)] FKWMEATAMCU containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ELTZXLKMBJV : EWCEDEYIQEC, BZZSBJMTFFZ, BQCQIEQQHBG, NZLOMSJGHUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<XJUIWVCTZYH> IZCQSECXPLW;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override FKWMEATAMCU IONDNHXDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C050", Offset = "0x9A0AA50", VA = "0x189A0C050", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override BQCQIEQQHBG.PhysicsMode JFHGJCNHULR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C0B0", Offset = "0x9A0AAB0", VA = "0x189A0C0B0", Slot = "13")]
			get
			{
				return default(BQCQIEQQHBG.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int OPBGGQWVVDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BEF0", Offset = "0x9A0A8F0", VA = "0x189A0BEF0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A0BF30", Offset = "0x9A0A930", VA = "0x189A0BF30", Slot = "15")]
		public void OCNDPNZNXNR(MOXEGPGHWBO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ELTZXLKMBJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class EWCEDEYIQEC : UCBTEJCTUXH, BQCQIEQQHBG, NZLOMSJGHUN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract BQCQIEQQHBG.PhysicsMode JFHGJCNHULR
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool LHFAHHUXBPN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C0E0", Offset = "0x9A0AAE0", VA = "0x189A0C0E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool YSRMUKMIEPO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C120", Offset = "0x9A0AB20", VA = "0x189A0C120", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HXGULLOEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C150", Offset = "0x9A0AB50", VA = "0x189A0C150", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected EWCEDEYIQEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HVSISIOGHWI : MOXEGPGHWBO, TDDTWDMRUTM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private XJUIWVCTZYH WWGTSSQWUTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<BEYGGOWQRXZ> GRDRXHFACWV;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public XJUIWVCTZYH IONDNHXDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CAF0", Offset = "0x9A0B4F0", VA = "0x189A0CAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EQNRKEBFTAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C800", Offset = "0x9A0B200", VA = "0x189A0C800", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType NOGLLPAQGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x286EF10", Offset = "0x286D910", VA = "0x18286EF10", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public TDDTWDMRUTM ZAEFRPYFJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CBD0", Offset = "0x9A0B5D0", VA = "0x189A0CBD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 XTMYEBRZEWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CA50", Offset = "0x9A0B450", VA = "0x189A0CA50", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion MNYYIPRVPAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CE00", Offset = "0x9A0B800", VA = "0x189A0CE00", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 OHFXQNDZZMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CC70", Offset = "0x9A0B670", VA = "0x189A0CC70", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial HSIUGFJSEDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3305EC0", Offset = "0x33048C0", VA = "0x183305EC0", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor SBTEGNBQFBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1306270", Offset = "0x1304C70", VA = "0x181306270", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float OUBFYJHONHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CDE0", Offset = "0x9A0B7E0", VA = "0x189A0CDE0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 FJEILVRDWXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CE60", Offset = "0x9A0B860", VA = "0x189A0CE60", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NLSRQAWSTXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C7B0", Offset = "0x9A0B1B0", VA = "0x189A0C7B0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags HGDNOHWTBJF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x645C380", Offset = "0x645AD80", VA = "0x18645C380", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int WOLNFORPTWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C820", Offset = "0x9A0B220", VA = "0x189A0C820", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool PQHUVSTATUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CAC0", Offset = "0x9A0B4C0", VA = "0x189A0CAC0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool DFLNFXPFZOK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9A0C7D0", Offset = "0x9A0B1D0", VA = "0x189A0C7D0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float FRWZYCNVRNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CB70", Offset = "0x9A0B570", VA = "0x189A0CB70", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool DHISKTIMNHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CB50", Offset = "0x9A0B550", VA = "0x189A0CB50", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int ASZTYJXMHWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CC10", Offset = "0x9A0B610", VA = "0x189A0CC10", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C860", Offset = "0x9A0B260", VA = "0x189A0C860", Slot = "22")]
		public void LPZWEEQMIRS(OBCARAYPFUA a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public HVSISIOGHWI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class IERADEYLPHS : OBCARAYPFUA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (BEYGGOWQRXZ curr, BEYGGOWQRXZ next, ShapeConfigFlags flags) WWGTSSQWUTA;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (BEYGGOWQRXZ curr, BEYGGOWQRXZ next, ShapeConfigFlags flags) IONDNHXDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7297020", Offset = "0x7295A20", VA = "0x187297020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 UAQIHVSIKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D160", Offset = "0x9A0BB60", VA = "0x189A0D160", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 VRHJFIVLQON
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D130", Offset = "0x9A0BB30", VA = "0x189A0D130", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CED0", Offset = "0x9A0B8D0", VA = "0x189A0CED0", Slot = "6")]
		public quaternion HZWVKZRXQGP(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public IERADEYLPHS()
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
