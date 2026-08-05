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
internal class WTBFLPCTUEB
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
	[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
	public WTBFLPCTUEB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LRRPZMRIAGL : DBLHGMFSBRD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MJIFDMROOCN.PhysicsMode OVKCXRERQWL;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString XDCPIWWBYBX;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString KAZJQYUYBWM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override MJIFDMROOCN.PhysicsMode DDZDNVTVBRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10", Slot = "13")]
			get
			{
				return default(MJIFDMROOCN.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84C1330", Offset = "0x84C0130", VA = "0x1884C1330")]
		public bool ISHZFDLCNSZ(PALJQNQKVVN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84C13D0", Offset = "0x84C01D0", VA = "0x1884C13D0")]
		private static bool PMHVCBPIRSK(PALJQNQKVVN a, [Out] MJIFDMROOCN.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public LRRPZMRIAGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LAWYZGVQFJI : RDHQOABQIXY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected PALJQNQKVVN UYWTCISFGKT;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual PALJQNQKVVN JGQJHTLYZSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HLAYYGEVEFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x84C1300", Offset = "0x84C0100", VA = "0x1884C1300", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool YOPDCNKPYER
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84C1240", Offset = "0x84C0040", VA = "0x1884C1240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PHAXFUBLPLT
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84C12A0", Offset = "0x84C00A0", VA = "0x1884C12A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool CABFOIKWLXL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84C1270", Offset = "0x84C0070", VA = "0x1884C1270", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool VNEYJPENXRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x84C12D0", Offset = "0x84C00D0", VA = "0x1884C12D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public LAWYZGVQFJI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BEXEGCCQWXL : SWIFGIVWYIT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper UYWTCISFGKT;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84C0530", Offset = "0x84BF330", VA = "0x1884C0530")]
		public BEXEGCCQWXL(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84C0410", Offset = "0x84BF210", VA = "0x1884C0410", Slot = "4")]
		public bool ZIQGXPGHEKY(MJIFDMROOCN a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84C02B0", Offset = "0x84BF0B0", VA = "0x1884C02B0", Slot = "5")]
		public bool VFAOJJOLQLR(MJIFDMROOCN a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84C0100", Offset = "0x84BEF00", VA = "0x1884C0100", Slot = "6")]
		public bool LVQCIVKFXLA(PLYDLUYJJIN a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84BFF50", Offset = "0x84BED50", VA = "0x1884BFF50")]
		private IReadOnlyList<PALJQNQKVVN> AKDVWFYAWNT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84BFFC0", Offset = "0x84BEDC0", VA = "0x1884BFFC0")]
		private bool HCKRNBZOQSX(int a, [Out][NotNullWhen(true)] PALJQNQKVVN containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class GEBACEAQIWA : DBLHGMFSBRD, WYFPEOUAZWM, MJIFDMROOCN, RDHQOABQIXY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<AZRTLPQBHZS> DMXUBDWNEXD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override PALJQNQKVVN JGQJHTLYZSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x84C0D40", Offset = "0x84BFB40", VA = "0x1884C0D40", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MJIFDMROOCN.PhysicsMode DDZDNVTVBRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84C0DA0", Offset = "0x84BFBA0", VA = "0x1884C0DA0", Slot = "13")]
			get
			{
				return default(MJIFDMROOCN.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int QXSWVNCIDBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x84C0F00", Offset = "0x84BFD00", VA = "0x1884C0F00", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84C0DD0", Offset = "0x84BFBD0", VA = "0x1884C0DD0", Slot = "15")]
		public void GQBLFSCVOES(SIUACBBGKDX a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public GEBACEAQIWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class DBLHGMFSBRD : LAWYZGVQFJI, MJIFDMROOCN, RDHQOABQIXY
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract MJIFDMROOCN.PhysicsMode DDZDNVTVBRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool NXKQYXKSHLM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x84C05E0", Offset = "0x84BF3E0", VA = "0x1884C05E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FVOCCRPVMGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x84C05B0", Offset = "0x84BF3B0", VA = "0x1884C05B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IAYPKVFRFGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84C0580", Offset = "0x84BF380", VA = "0x1884C0580", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected DBLHGMFSBRD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class FUNOGYIJLAV : SIUACBBGKDX, YAPOOVQTPOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private AZRTLPQBHZS UYWTCISFGKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<TGIIRPBAFAS> UPYTRRMKJXS;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AZRTLPQBHZS JGQJHTLYZSP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x84C0620", Offset = "0x84BF420", VA = "0x1884C0620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NQTKZFVRHFU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x84C0B60", Offset = "0x84BF960", VA = "0x1884C0B60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType PDFGLUDZODS
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xB4B2C0", Offset = "0xB4A0C0", VA = "0x180B4B2C0", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public YAPOOVQTPOB OAXEFAJYGCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x84C0740", Offset = "0x84BF540", VA = "0x1884C0740", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 YJGZPHQQOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x84C0C40", Offset = "0x84BFA40", VA = "0x1884C0C40", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion BSVMTQBEROR
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x84C0780", Offset = "0x84BF580", VA = "0x1884C0780", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 XQMDWVHUFRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84C0800", Offset = "0x84BF600", VA = "0x1884C0800", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial WJLHLFEXSUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x325F7D0", Offset = "0x325E5D0", VA = "0x18325F7D0", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor MWRAFFHLWBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x132E2B0", Offset = "0x132D0B0", VA = "0x18132E2B0", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float DRFDTBANQIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x84C07E0", Offset = "0x84BF5E0", VA = "0x1884C07E0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 IQFWDUSEDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x84C0680", Offset = "0x84BF480", VA = "0x1884C0680", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float VDVLLMLQWVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x84C0720", Offset = "0x84BF520", VA = "0x1884C0720", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags BQKKHFWCSBS
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6007DB0", Offset = "0x6006BB0", VA = "0x186007DB0", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int DSSTOCXMMII
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x84C0B80", Offset = "0x84BF980", VA = "0x1884C0B80", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool XSIIHIYTHYU
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x84C06F0", Offset = "0x84BF4F0", VA = "0x1884C06F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool EDXOGKZZQXR
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84C0CB0", Offset = "0x84BFAB0", VA = "0x1884C0CB0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float WBVMCIWXHYM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84C0BC0", Offset = "0x84BF9C0", VA = "0x1884C0BC0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool HRZTJMPZFTR
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84C0C20", Offset = "0x84BFA20", VA = "0x1884C0C20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int ABTAWEJHBZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x84C0CE0", Offset = "0x84BFAE0", VA = "0x1884C0CE0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84C0970", Offset = "0x84BF770", VA = "0x1884C0970", Slot = "22")]
		public void SOLVGZUEQVD(RHZQJLKECEZ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public FUNOGYIJLAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class KYIIWZOYPMN : RHZQJLKECEZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (TGIIRPBAFAS curr, TGIIRPBAFAS next, ShapeConfigFlags flags) UYWTCISFGKT;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (TGIIRPBAFAS curr, TGIIRPBAFAS next, ShapeConfigFlags flags) JGQJHTLYZSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5B21C50", Offset = "0x5B20A50", VA = "0x185B21C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 NRXBGDQQKDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x84C11D0", Offset = "0x84BFFD0", VA = "0x1884C11D0", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 PTARJHDNMWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84C11A0", Offset = "0x84BFFA0", VA = "0x1884C11A0", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84C0F40", Offset = "0x84BFD40", VA = "0x1884C0F40", Slot = "6")]
		public quaternion DUUGNUNLWMC(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KYIIWZOYPMN()
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
