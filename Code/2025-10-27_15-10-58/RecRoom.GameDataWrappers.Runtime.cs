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
internal class MZHUOFNWOZJ
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
	[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
	public MZHUOFNWOZJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class OCUMQTBHWMZ : IRKKNMUJYDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private TFDVGFVFNOH.PhysicsMode ADDMUWDPEQV;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString ACEATHQAXWT;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString SZGGJOCQQSC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override TFDVGFVFNOH.PhysicsMode JYILPNTLVFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0", Slot = "13")]
			get
			{
				return default(TFDVGFVFNOH.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x875EFE0", Offset = "0x875DFE0", VA = "0x18875EFE0")]
		public bool UMJYNDVKHDR(MQHFFIUQXTL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x875ECB0", Offset = "0x875DCB0", VA = "0x18875ECB0")]
		private static bool NSHUYSFRRMU(MQHFFIUQXTL a, [Out] TFDVGFVFNOH.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public OCUMQTBHWMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class QJRGFCUCXHC : XLXNEZROHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected MQHFFIUQXTL UMFUZCETKJH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual MQHFFIUQXTL JBMRVYMFEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool UZIRMRWRGRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x875F1E0", Offset = "0x875E1E0", VA = "0x18875F1E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PSURHLXQVUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x875F1B0", Offset = "0x875E1B0", VA = "0x18875F1B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CGOLYVODOKL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x875F240", Offset = "0x875E240", VA = "0x18875F240", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool YKXQPNRNHZR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x875F180", Offset = "0x875E180", VA = "0x18875F180", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NLCOVXNMAUU
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x875F210", Offset = "0x875E210", VA = "0x18875F210", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public QJRGFCUCXHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class SWUJTSAHIVR : AWLPWIZGIAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper UMFUZCETKJH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x875F840", Offset = "0x875E840", VA = "0x18875F840")]
		public SWUJTSAHIVR(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x875F270", Offset = "0x875E270", VA = "0x18875F270", Slot = "4")]
		public bool BUJGEMIUHRI(TFDVGFVFNOH a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x875F530", Offset = "0x875E530", VA = "0x18875F530", Slot = "5")]
		public bool NLEUIDGITRP(TFDVGFVFNOH a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x875F690", Offset = "0x875E690", VA = "0x18875F690", Slot = "6")]
		public bool WUJMLJQRKAA(QHAVIDQXMFJ a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x875F390", Offset = "0x875E390", VA = "0x18875F390")]
		private IReadOnlyList<MQHFFIUQXTL> GBNVRBCHDUT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x875F400", Offset = "0x875E400", VA = "0x18875F400")]
		private bool MTQASAGVFMB(int a, [Out][NotNullWhen(true)] MQHFFIUQXTL containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MSXPZQEGAVQ : IRKKNMUJYDB, ALJUEYFXCMO, TFDVGFVFNOH, XLXNEZROHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<TCJEGAKVZDI> DEAHIFZQFBV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override MQHFFIUQXTL JBMRVYMFEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x875EC50", Offset = "0x875DC50", VA = "0x18875EC50", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override TFDVGFVFNOH.PhysicsMode JYILPNTLVFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x875EC20", Offset = "0x875DC20", VA = "0x18875EC20", Slot = "13")]
			get
			{
				return default(TFDVGFVFNOH.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int SXRUNBBWFCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x875EAC0", Offset = "0x875DAC0", VA = "0x18875EAC0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x875EB00", Offset = "0x875DB00", VA = "0x18875EB00", Slot = "15")]
		public void FSXHEYZXKWQ(WQYEWUSTMPB a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public MSXPZQEGAVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class IRKKNMUJYDB : QJRGFCUCXHC, TFDVGFVFNOH, XLXNEZROHAE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract TFDVGFVFNOH.PhysicsMode JYILPNTLVFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool XIGVXTDAZZG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x875EA80", Offset = "0x875DA80", VA = "0x18875EA80", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool WKAGTEAZWLR
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x875EA50", Offset = "0x875DA50", VA = "0x18875EA50", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool LMBPNLZIAZB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x875EA20", Offset = "0x875DA20", VA = "0x18875EA20", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected IRKKNMUJYDB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class USOGNGPXHQD : WQYEWUSTMPB, GSZRWLVBZSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private TCJEGAKVZDI UMFUZCETKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<ZWKWRAGJKPO> ROKFSKUMXHY;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TCJEGAKVZDI JBMRVYMFEKV
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x875FF50", Offset = "0x875EF50", VA = "0x18875FF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LAEUESANWKM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x875FD40", Offset = "0x875ED40", VA = "0x18875FD40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType SCVJMVMNVDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xBBC890", Offset = "0xBBB890", VA = "0x180BBC890", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GSZRWLVBZSL VZQAPLHWOLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x875FBE0", Offset = "0x875EBE0", VA = "0x18875FBE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 YBRWHKCLDBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x875FB40", Offset = "0x875EB40", VA = "0x18875FB40", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion FHLSGNVNLMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x875FAE0", Offset = "0x875EAE0", VA = "0x18875FAE0", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 XJDRLPXJKUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x875FDA0", Offset = "0x875EDA0", VA = "0x18875FDA0", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial RYWLXOHWOOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x32B0DD0", Offset = "0x32AFDD0", VA = "0x1832B0DD0", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor LRBYOOMORPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x13F1F60", Offset = "0x13F0F60", VA = "0x1813F1F60", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float ICYUYVRKVEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x875FF30", Offset = "0x875EF30", VA = "0x18875FF30", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 DJIZJXXFOXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x875FC50", Offset = "0x875EC50", VA = "0x18875FC50", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float GHODAHXSJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x875FF10", Offset = "0x875EF10", VA = "0x18875FF10", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags CBGTSQAFPNE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x630FA90", Offset = "0x630EA90", VA = "0x18630FA90", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int JDOYFRVPLNA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x875FD60", Offset = "0x875ED60", VA = "0x18875FD60", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool AJLJNOPHYXE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x875FBB0", Offset = "0x875EBB0", VA = "0x18875FBB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool QUJUZTKLXIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x875FC20", Offset = "0x875EC20", VA = "0x18875FC20", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float CYNSUSHZHSO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x875F890", Offset = "0x875E890", VA = "0x18875F890", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool RJDEJIDPMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x875FCC0", Offset = "0x875ECC0", VA = "0x18875FCC0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int XHKTLPXWDPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x875FCE0", Offset = "0x875ECE0", VA = "0x18875FCE0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x875F8F0", Offset = "0x875E8F0", VA = "0x18875F8F0", Slot = "22")]
		public void BFOVCESCEOP(ORUTIZRDLHN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public USOGNGPXHQD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ETAKSNJCKLN : ORUTIZRDLHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (ZWKWRAGJKPO curr, ZWKWRAGJKPO next, ShapeConfigFlags flags) UMFUZCETKJH;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (ZWKWRAGJKPO curr, ZWKWRAGJKPO next, ShapeConfigFlags flags) JBMRVYMFEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5C79670", Offset = "0x5C78670", VA = "0x185C79670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 FZEZTVXHVQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x875E9B0", Offset = "0x875D9B0", VA = "0x18875E9B0", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 YNFIJJPKKDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x875E720", Offset = "0x875D720", VA = "0x18875E720", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x875E750", Offset = "0x875D750", VA = "0x18875E750", Slot = "6")]
		public quaternion QETINBZISHC(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public ETAKSNJCKLN()
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
