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
internal class XABYAYWDHUK
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
	[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
	public XABYAYWDHUK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class GPLSRISIHKQ : TYUUSAGBRIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private JXABPWXHREW.PhysicsMode TPAFNWGWBFQ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString WMORUEPOIDW;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString FLPEPRHADXZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override JXABPWXHREW.PhysicsMode GKUBMVOLFNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAD4260", Offset = "0xAD3060", VA = "0x180AD4260", Slot = "13")]
			get
			{
				return default(JXABPWXHREW.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8563920", Offset = "0x8562720", VA = "0x188563920")]
		public bool HPEENFWMCDC(TFJYNGUFQVY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85639C0", Offset = "0x85627C0", VA = "0x1885639C0")]
		private static bool HTVMPKLQJAX(TFJYNGUFQVY a, [Out] JXABPWXHREW.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public GPLSRISIHKQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AWCXOQYMKFB : SVVXEDKXPTZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected TFJYNGUFQVY TMXKQREQIYA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual TFJYNGUFQVY FFDULGKWPQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ITSJIVIARYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x85638C0", Offset = "0x85626C0", VA = "0x1885638C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool SOBWNHWOEQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x85638F0", Offset = "0x85626F0", VA = "0x1885638F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool YAQRBVDXNEG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8563890", Offset = "0x8562690", VA = "0x188563890", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool YLYQVLWYJQE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8563860", Offset = "0x8562660", VA = "0x188563860", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool OXFIUEBEFDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8563830", Offset = "0x8562630", VA = "0x188563830", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AWCXOQYMKFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HUVJDUJQQLS : NQFGYVGAKZI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper TMXKQREQIYA;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85646B0", Offset = "0x85634B0", VA = "0x1885646B0")]
		public HUVJDUJQQLS(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8564590", Offset = "0x8563390", VA = "0x188564590", Slot = "4")]
		public bool YOFAJBAIXWL(JXABPWXHREW a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8564150", Offset = "0x8562F50", VA = "0x188564150", Slot = "5")]
		public bool LTSFAUNUZTM(JXABPWXHREW a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85642B0", Offset = "0x85630B0", VA = "0x1885642B0", Slot = "6")]
		public bool VTWKSVVSQWD(ZDFYJFRUVSG a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85640E0", Offset = "0x8562EE0", VA = "0x1885640E0")]
		private IReadOnlyList<TFJYNGUFQVY> KVMIZSAKSBU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8564460", Offset = "0x8563260", VA = "0x188564460")]
		private bool YGIQITSEDYS(int a, [Out][NotNullWhen(true)] TFJYNGUFQVY containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NHRBCKCCPCB : TYUUSAGBRIU, KJTTBNNJGGF, JXABPWXHREW, SVVXEDKXPTZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<HRFZWVJYPLT> FPZDUTBRAJI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override TFJYNGUFQVY FFDULGKWPQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8564E60", Offset = "0x8563C60", VA = "0x188564E60", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override JXABPWXHREW.PhysicsMode GKUBMVOLFNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8564FF0", Offset = "0x8563DF0", VA = "0x188564FF0", Slot = "13")]
			get
			{
				return default(JXABPWXHREW.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int KVYCKWYTBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8564E20", Offset = "0x8563C20", VA = "0x188564E20", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8564EC0", Offset = "0x8563CC0", VA = "0x188564EC0", Slot = "15")]
		public void VWZZRTFUJGZ(XWGAZIOTZPQ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public NHRBCKCCPCB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class TYUUSAGBRIU : AWCXOQYMKFB, JXABPWXHREW, SVVXEDKXPTZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract JXABPWXHREW.PhysicsMode GKUBMVOLFNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PRSIMWSVBSF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8565050", Offset = "0x8563E50", VA = "0x188565050", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KDTYLIEAOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8565090", Offset = "0x8563E90", VA = "0x188565090", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JMWMHZMIHKU
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8565020", Offset = "0x8563E20", VA = "0x188565020", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected TYUUSAGBRIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class JRSMUONAWBE : XWGAZIOTZPQ, QHPIBHIWSNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private HRFZWVJYPLT TMXKQREQIYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<LYVDMMZZPSR> DPKFSKYWCOT;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HRFZWVJYPLT FFDULGKWPQE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8564A40", Offset = "0x8563840", VA = "0x188564A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool YNPPAABIMQR
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8564E00", Offset = "0x8563C00", VA = "0x188564E00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType GJSKXMDDYHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x25F6910", Offset = "0x25F5710", VA = "0x1825F6910", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public QHPIBHIWSNC NIHKTBZKBQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8564BD0", Offset = "0x85639D0", VA = "0x188564BD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 IIYQCROBXLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x85649A0", Offset = "0x85637A0", VA = "0x1885649A0", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion LPLELFIJVOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8564AE0", Offset = "0x85638E0", VA = "0x188564AE0", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 ZMJUOEPVXPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8564C10", Offset = "0x8563A10", VA = "0x188564C10", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial IFHTWVDKOER
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3087B60", Offset = "0x3086960", VA = "0x183087B60", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor GUSTJUYBAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x10F5C50", Offset = "0x10F4A50", VA = "0x1810F5C50", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float DMFYQERYOGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8564DE0", Offset = "0x8563BE0", VA = "0x188564DE0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 NJGOFOGKRUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8564B40", Offset = "0x8563940", VA = "0x188564B40", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float ITWHTKNWJFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8564BB0", Offset = "0x85639B0", VA = "0x188564BB0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags SREKYBTSWGN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x597C5A0", Offset = "0x597B3A0", VA = "0x18597C5A0", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int KGLEHGCVSLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8564AA0", Offset = "0x85638A0", VA = "0x188564AA0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool OSTLDJTNTFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8564A10", Offset = "0x8563810", VA = "0x188564A10", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool UZXVJFCEJHW
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8564700", Offset = "0x8563500", VA = "0x188564700", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IDJPMLSKNPL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8564D80", Offset = "0x8563B80", VA = "0x188564D80", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool VLPUKRJGGXK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8564730", Offset = "0x8563530", VA = "0x188564730", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int YJWGQFYVBGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8564940", Offset = "0x8563740", VA = "0x188564940", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8564750", Offset = "0x8563550", VA = "0x188564750", Slot = "22")]
		public void CQAIZDSZDJM(AXVYRSCXWTU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public JRSMUONAWBE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class GVLHEBNOHOW : AXVYRSCXWTU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (LYVDMMZZPSR curr, LYVDMMZZPSR next, ShapeConfigFlags flags) TMXKQREQIYA;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (LYVDMMZZPSR curr, LYVDMMZZPSR next, ShapeConfigFlags flags) FFDULGKWPQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5AF37D0", Offset = "0x5AF25D0", VA = "0x185AF37D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 QPBSZOXKJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8563DE0", Offset = "0x8562BE0", VA = "0x188563DE0", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 RDYBBZSLBGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85640B0", Offset = "0x8562EB0", VA = "0x1885640B0", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8563E50", Offset = "0x8562C50", VA = "0x188563E50", Slot = "6")]
		public quaternion QVNWRMNUZBT(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public GVLHEBNOHOW()
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
