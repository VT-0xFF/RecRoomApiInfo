using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D11B00", Offset = "0x6D10F00", VA = "0x186D11B00", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private PKJBAPOINDL bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PKJBAPOINDL bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D12DF0", Offset = "0x6D121F0", VA = "0x186D12DF0", Slot = "5")]
		public override void CJONANIIMOP(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D12FA0", Offset = "0x6D123A0", VA = "0x186D12FA0")]
		private void FHJEABGIEGC(DCLDPENAHIJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D12E30", Offset = "0x6D12230", VA = "0x186D12E30")]
		private void EKHKDLPPHJC(DCLDPENAHIJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D12AB0", Offset = "0x6D11EB0", VA = "0x186D12AB0", Slot = "6")]
		public override void AHJCDOHADEI(DCLDPENAHIJ registry, [In] NBLNAJMJFFC filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D13110", Offset = "0x6D12510", VA = "0x186D13110")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class CMFLHPKGHBP : HNNPDPLDLKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class LCNOICDGLBC : IEnumerable<MHFMFIBEDGP>, IEnumerable, IEnumerator<MHFMFIBEDGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private MHFMFIBEDGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private AGLPGLMEACF localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AGLPGLMEACF <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CMFLHPKGHBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LKGAMHHAMKI <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private BLJMICDPKDA.FCBKPFOJNCF <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private MHFMFIBEDGP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public LCNOICDGLBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F2E0", Offset = "0x6D0E6E0", VA = "0x186D0F2E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D0EE20", Offset = "0x6D0E220", VA = "0x186D0EE20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D0EE00", Offset = "0x6D0E200", VA = "0x186D0EE00")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F290", Offset = "0x6D0E690", VA = "0x186D0F290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F1E0", Offset = "0x6D0E5E0", VA = "0x186D0F1E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MHFMFIBEDGP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F1E0", Offset = "0x6D0E5E0", VA = "0x186D0F1E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LODACNLKDDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CMFLHPKGHBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MHHNEENHAHF nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LODACNLKDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FBB0", Offset = "0x6D0EFB0", VA = "0x186D0FBB0")]
		internal object JNABJIOOPMM(MHHNEENHAHF x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FJJJPDPMKEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MHHNEENHAHF child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LODACNLKDDJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FJJJPDPMKEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D06DB0", Offset = "0x6D061B0", VA = "0x186D06DB0")]
		internal object OKIEJLIIIGA((MHHNEENHAHF child, MHHNEENHAHF nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly FLILHMOBPPM DACOFKKIBFE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly FLILHMOBPPM FINLJPBLGIH;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly FLILHMOBPPM NPFIGMPADEO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly FLILHMOBPPM NPIGEMDCPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HJAHHCBGNIN OMLHOFBHOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IJHAGBMDOFM HNGCDAAKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private BGBCLBMHAOP LBJEFOHAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JAAJPBJINJK BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CDNMCPCLAEP HMJBIBCMEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OIMJMIILKDI JGADEBKHJGJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB400", Offset = "0x8BA800", VA = "0x1808BB400", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8BA3F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KBJOGKGELOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP> BIFDFFLDFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D015B0", Offset = "0x6D009B0", VA = "0x186D015B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D023E0", Offset = "0x6D017E0", VA = "0x186D023E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP> FFJBJJKJHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D02BD0", Offset = "0x6D01FD0", VA = "0x186D02BD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D00CA0", Offset = "0x6D000A0", VA = "0x186D00CA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP, MHFMFIBEDGP> LJIABJLPCID
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D00550", Offset = "0x6CFF950", VA = "0x186D00550", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6CFEEC0", Offset = "0x6CFE2C0", VA = "0x186CFEEC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D03030", Offset = "0x6D02430", VA = "0x186D03030")]
	public CMFLHPKGHBP(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CFF5A0", Offset = "0x6CFE9A0", VA = "0x186CFF5A0", Slot = "12")]
	public void CGCFJDLGJFP(GameObject BCDDMHHPJBD, LDGCIJKCDMC CEHGJOALFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D00060", Offset = "0x6CFF460", VA = "0x186D00060", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D01160", Offset = "0x6D00560", VA = "0x186D01160", Slot = "22")]
	public bool GKPGKOADIFF(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D01D40", Offset = "0x6D01140", VA = "0x186D01D40")]
	private void LEOBAPKHDKH(AGLPGLMEACF GIPGHPNGPMC, AGLPGLMEACF HELLNACODKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D012C0", Offset = "0x6D006C0", VA = "0x186D012C0")]
	private void HNFBKFJGAAI(AGLPGLMEACF GIPGHPNGPMC, AGLPGLMEACF CFDHIGDKHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D02C80", Offset = "0x6D02080", VA = "0x186D02C80")]
	private void PKJONGHGIMJ(AGLPGLMEACF GIPGHPNGPMC, AGLPGLMEACF CFDHIGDKHCO, AGLPGLMEACF HELLNACODKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D00D50", Offset = "0x6D00150", VA = "0x186D00D50")]
	private void FNMJBBLGFCN(AGLPGLMEACF GIPGHPNGPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "13")]
	public void PPNDJIMKPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D020E0", Offset = "0x6D014E0", VA = "0x186D020E0", Slot = "14")]
	public void MHJHNBDIMHP(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "15")]
	public void AMMAKBKKNOC(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D01A60", Offset = "0x6D00E60", VA = "0x186D01A60", Slot = "17")]
	public void KPFCPFCCFBH(MHFMFIBEDGP MLKBGAPFGJD, MHFMFIBEDGP HDPNHEJKJDI, Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D01BC0", Offset = "0x6D00FC0", VA = "0x186D01BC0")]
	public void KPFCPFCCFBH(AGLPGLMEACF KADEDLJJJFO, AGLPGLMEACF HDPNHEJKJDI, Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D02B40", Offset = "0x6D01F40", VA = "0x186D02B40")]
	public void OMHMEICDLPM(MHFMFIBEDGP MLKBGAPFGJD, float ABBNOLDJHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6CFF320", Offset = "0x6CFE720", VA = "0x186CFF320", Slot = "18")]
	public void BPOBNHECHGK(MHFMFIBEDGP KDOFJEODKKP, int JBHGDGDHJKL, MHFMFIBEDGP DBLFFCCLGAO, int GGFAJOIGHKC, Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D004A0", Offset = "0x6CFF8A0", VA = "0x186D004A0")]
	private float EPKMEPFMOPO(AGLPGLMEACF KADEDLJJJFO, AGLPGLMEACF DEDHJMDEEIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6CFF470", Offset = "0x6CFE870", VA = "0x186CFF470")]
	public void BPOBNHECHGK(AGLPGLMEACF KADEDLJJJFO, AGLPGLMEACF DEDHJMDEEIE, Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6CFF2C0", Offset = "0x6CFE6C0", VA = "0x186CFF2C0")]
	public void BPOBNHECHGK(AGLPGLMEACF KADEDLJJJFO, AGLPGLMEACF DEDHJMDEEIE, Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD, float ABBNOLDJHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D00B30", Offset = "0x6CFFF30", VA = "0x186D00B30", Slot = "19")]
	public void FJKBEFHEAFF(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D02490", Offset = "0x6D01890", VA = "0x186D02490")]
	public bool OHKICLAMLDL(AGLPGLMEACF IMMJHCFALCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6CFFE50", Offset = "0x6CFF250", VA = "0x186CFFE50", Slot = "16")]
	public void DJJDAGGOONE(MHFMFIBEDGP MLKBGAPFGJD, HashSet<MHFMFIBEDGP> NOGPEGFAHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "20")]
	public NIAGJEFLEEM LFBMMMDOJLP(bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "21")]
	public NIAGJEFLEEM HMFKCJPBMKB(HashSet<Guid> ACBILMIDCHP, bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D00AC0", Offset = "0x6CFFEC0", VA = "0x186D00AC0", Slot = "23")]
	public void FHJLAABAKHM(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CFFC50", Offset = "0x6CFF050", VA = "0x186CFFC50", Slot = "24")]
	public void DDJKLODKOGG(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D002B0", Offset = "0x6CFF6B0", VA = "0x186D002B0", Slot = "25")]
	public void EIPHANDBOMO(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CFF870", Offset = "0x6CFEC70", VA = "0x186CFF870")]
	private void DAHPBGFBNHN(AGLPGLMEACF KADEDLJJJFO, AGLPGLMEACF DEDHJMDEEIE, Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD, float ABBNOLDJHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D02720", Offset = "0x6D01B20", VA = "0x186D02720")]
	private void OLDGEEAFKPO(AGLPGLMEACF KADEDLJJJFO, AGLPGLMEACF LNNICEPGDAG, Vector3 OGHPOADGEMG, Quaternion MHGGNDLFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CFEF70", Offset = "0x6CFE370", VA = "0x186CFEF70")]
	private void BAHNGNOGLGO(AGLPGLMEACF KADEDLJJJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CFFBC0", Offset = "0x6CFEFC0", VA = "0x186CFFBC0")]
	[IteratorStateMachine(typeof(LCNOICDGLBC))]
	public IEnumerable<MHFMFIBEDGP> DBJEECGBDIO(AGLPGLMEACF IMMJHCFALCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D00990", Offset = "0x6CFFD90", VA = "0x186D00990")]
	internal MHFMFIBEDGP FGDHNCDBHCD(AGLPGLMEACF IMMJHCFALCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D014E0", Offset = "0x6D008E0", VA = "0x186D014E0")]
	internal AGLPGLMEACF IFFBBEMKAOP(MHFMFIBEDGP MLKBGAPFGJD)
	{
		return default(AGLPGLMEACF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE930", Offset = "0x6CFDD30", VA = "0x186CFE930")]
	private bool AAOEAJMOLHL(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D00250", Offset = "0x6CFF650", VA = "0x186D00250")]
	private bool EDGALDEJMDI(MHHNEENHAHF BDAAIBDOCNE, [Out] MHFMFIBEDGP DEDHJMDEEIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D00600", Offset = "0x6CFFA00", VA = "0x186D00600")]
	private MHFMFIBEDGP FGDHNCDBHCD(MHHNEENHAHF BDAAIBDOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D018E0", Offset = "0x6D00CE0", VA = "0x186D018E0")]
	private MHFMFIBEDGP KDPKNAKPODB(MHHNEENHAHF BDAAIBDOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D002D0", Offset = "0x6CFF6D0", VA = "0x186D002D0")]
	private MHFMFIBEDGP ENBPFBKCPAC(MHHNEENHAHF BDAAIBDOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D01D00", Offset = "0x6D01100", VA = "0x186D01D00")]
	private static Guid LEFNPGENILK(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D01660", Offset = "0x6D00A60", VA = "0x186D01660")]
	private string JHFDKOFHEII(MHHNEENHAHF BDAAIBDOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D01F50", Offset = "0x6D01350", VA = "0x186D01F50")]
	private void LPICECGBCCJ(MHFMFIBEDGP KADEDLJJJFO, MHFMFIBEDGP LNNICEPGDAG, RigidTransform DGLIIEKJOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6CFFCC0", Offset = "0x6CFF0C0", VA = "0x186CFFCC0")]
	private void DDLCIFJMHIN(MHFMFIBEDGP LNNICEPGDAG, MHFMFIBEDGP KADEDLJJJFO, RigidTransform DGLIIEKJOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6CFF810", Offset = "0x6CFEC10", VA = "0x186CFF810")]
	private void CMFNMINGDJA(MHFMFIBEDGP JHFMLMDHLPE, MHFMFIBEDGP KADEDLJJJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D01750", Offset = "0x6D00B50", VA = "0x186D01750")]
	private void JOPCOEPKGPP(MHFMFIBEDGP KADEDLJJJFO, MHFMFIBEDGP DEDHJMDEEIE, RigidTransform DGLIIEKJOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D011B0", Offset = "0x6D005B0", VA = "0x186D011B0")]
	private void HDFABLDBBPG(AGLPGLMEACF IMMJHCFALCP, MHFMFIBEDGP MLKBGAPFGJD, AGLPGLMEACF CFDHIGDKHCO, AGLPGLMEACF HELLNACODKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6CFEFE0", Offset = "0x6CFE3E0", VA = "0x186CFEFE0")]
	private void BKBIDILAPLO(AGLPGLMEACF IMMJHCFALCP, MHFMFIBEDGP MLKBGAPFGJD, MHFMFIBEDGP EOEPCFKLPNA, MHFMFIBEDGP CLHCMALLCMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LJIPEMOGFJC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BFBPKBMKPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public LBNNADLFMIK container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BFBPKBMKPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE350", Offset = "0x6CFD750", VA = "0x186CFE350")]
		internal CMFLHPKGHBP HBEPANEJJPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F5C0", Offset = "0x6D0E9C0", VA = "0x186D0F5C0")]
	public static void FEHLMOFHDJL(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F740", Offset = "0x6D0EB40", VA = "0x186D0F740")]
	public static void HACMEGJEBAN(LBNNADLFMIK FKEBHAJCLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JNNOGMIAIPF : FMKONDJAELK, DNLIBMGMIGF
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly CMFLHPKGHBP OHDKFPAEHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JICPPIPELKJ LIMGNAPKHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly CPAMJEIEEBJ BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly KAOAPGGNHHE[] HPPGMLFOJMI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MHFMFIBEDGP APEGJBDPCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C520", Offset = "0x6D0B920", VA = "0x186D0C520", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MHFMFIBEDGP CNMHJMNGFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B130", Offset = "0x6D0A530", VA = "0x186D0B130", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 BLJOPCFNNAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B580", Offset = "0x6D0A980", VA = "0x186D0B580", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion JHIFHCLMBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B900", Offset = "0x6D0AD00", VA = "0x186D0B900", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AJDOCLKPGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B890", Offset = "0x6D0AC90", VA = "0x186D0B890", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<MHFMFIBEDGP> PGIPENDPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AE80", Offset = "0x6D0A280", VA = "0x186D0AE80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool EDHEGCAMICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9D2310", Offset = "0x9D1710", VA = "0x1809D2310", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCD6FE0", Offset = "0xCD63E0", VA = "0x180CD6FE0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C720", Offset = "0x6D0BB20", VA = "0x186D0C720", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject HAIKDHHODMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x27E66F0", Offset = "0x27E5AF0", VA = "0x1827E66F0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C460", Offset = "0x6D0B860", VA = "0x186D0C460", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid NKGNIHBAPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C580", Offset = "0x6D0B980", VA = "0x186D0C580", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LAFIFABEHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C660", Offset = "0x6D0BA60", VA = "0x186D0C660", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FKAJAIFILMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JMMKHOAHEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D0ADD0", Offset = "0x6D0A1D0", VA = "0x186D0ADD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FBALJPCBKOD LOPNGHJEPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AE20", Offset = "0x6D0A220", VA = "0x186D0AE20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B5E0", Offset = "0x6D0A9E0", VA = "0x186D0B5E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FBALJPCBKOD CHDDFLPBIKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AF10", Offset = "0x6D0A310", VA = "0x186D0AF10", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B2C0", Offset = "0x6D0A6C0", VA = "0x186D0B2C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FBALJPCBKOD NHPNMPEOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AEB0", Offset = "0x6D0A2B0", VA = "0x186D0AEB0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BEB0", Offset = "0x6D0B2B0", VA = "0x186D0BEB0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event AIHNIOLALAD HFGMOKBEENI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BF10", Offset = "0x6D0B310", VA = "0x186D0BF10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B090", Offset = "0x6D0A490", VA = "0x186D0B090", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C360", Offset = "0x6D0B760", VA = "0x186D0C360")]
	public JNNOGMIAIPF(AGLPGLMEACF KDHECHILKME, RigidbodyEx GJHPLGMALIK, JICPPIPELKJ LIMGNAPKHFE, KAOAPGGNHHE[] HPPGMLFOJMI, CPAMJEIEEBJ BLDEOEOIGBD, HNNPDPLDLKK OHDKFPAEHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BE80", Offset = "0x6D0B280", VA = "0x186D0BE80", Slot = "19")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "21")]
	public void KPNPEPLHGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B4D2A0", Offset = "0x6B4C6A0", VA = "0x186B4D2A0", Slot = "22")]
	public void BBKABCIEMMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B530", Offset = "0x6D0A930", VA = "0x186D0B530", Slot = "20")]
	public void FMHCNCBOPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B320", Offset = "0x6D0A720", VA = "0x186D0B320", Slot = "25")]
	public void FKANIGGAIJI(int IAFMPAIKJAF, MHFMFIBEDGP DBLFFCCLGAO, int HLDBNDACCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B1F0", Offset = "0x6D0A5F0", VA = "0x186D0B1F0", Slot = "26")]
	public void EBHHGMDIEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B960", Offset = "0x6D0AD60", VA = "0x186D0B960", Slot = "27")]
	public void NHNACAICNOA(int IAFMPAIKJAF, MHFMFIBEDGP KDOFJEODKKP, int AOOKJIKEMDK, [Optional] Vector3? JHPPMCAFCJC, [Optional] Quaternion? CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B010", Offset = "0x6D0A410", VA = "0x186D0B010", Slot = "28")]
	public void DHKELEOJHNF(MHFMFIBEDGP KDOFJEODKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A9C0", Offset = "0x6D09DC0", VA = "0x186D0A9C0", Slot = "31")]
	public void BCMMKGHECEO(Vector3 NLLOJFNEKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BFB0", Offset = "0x6D0B3B0", VA = "0x186D0BFB0", Slot = "29")]
	public void PNKDPILPLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BC40", Offset = "0x6D0B040", VA = "0x186D0BC40", Slot = "30")]
	public void NOLAPJPEGOM(int HAJICDLBEKC, Vector3 GOGKCFACHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B770", Offset = "0x6D0AB70", VA = "0x186D0B770", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int IAFMPAIKJAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B640", Offset = "0x6D0AA40", VA = "0x186D0B640", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int IAFMPAIKJAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x97F3D0", Offset = "0x97E7D0", VA = "0x18097F3D0", Slot = "42")]
	public Color GetConnectionSlotColor(int IAFMPAIKJAF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0AF70", Offset = "0x6D0A370", VA = "0x186D0AF70", Slot = "43")]
	public bool CanConnectTo(int IAFMPAIKJAF, MHFMFIBEDGP FAJLEBJDMPD, int FPBIDLDPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "44")]
	public void ParentChanged(int IAFMPAIKJAF, MHFMFIBEDGP LOCNJBEEEII, int GMFEBEKKHKC, Vector3 INBLPDLHPKE, Quaternion JPKJBOODDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "45")]
	public void ChildAdded(int IAFMPAIKJAF, MHFMFIBEDGP HIPLKBODBHE, int EGLBGCPGIEC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "46")]
	public void ChildRemoved(int IAFMPAIKJAF, MHFMFIBEDGP LNDOPJCOENM, int OOHJCIBEOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "47")]
	public void ConnectionModified(int IAFMPAIKJAF, MHFMFIBEDGP DBLFFCCLGAO, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C2C0", Offset = "0x6D0B6C0", VA = "0x186D0C2C0", Slot = "48")]
	public void RootChanged(MHFMFIBEDGP PMEPCGEAPCL, MHFMFIBEDGP IHOHCLBEPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BE30", Offset = "0x6D0B230", VA = "0x186D0BE30", Slot = "23")]
	public void OBKLKCHGAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A970", Offset = "0x6D09D70", VA = "0x186D0A970", Slot = "24")]
	public void AMHFGKAFDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D0B840", Offset = "0x6D0AC40", VA = "0x186D0B840")]
	private void IGJAILKDKIA(bool DCIHNODGDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[MEMFFHBLAMF(typeof(DJEOLAGMMAK), new string[] { })]
public class BFDEOFIHHFL : DJEOLAGMMAK, PCLMMJFGOJL
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EJDJCPHPLMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public BFDEOFIHHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public BLJMICDPKDA localIds;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EJDJCPHPLMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6D06B00", Offset = "0x6D05F00", VA = "0x186D06B00")]
		internal void EKABDDAPGJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[NDELBDNLDHE]
	private IJLGCDDOACP DAOJAMKOACA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object BAPJBABIMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE400", Offset = "0x6CFD800", VA = "0x186CFE400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE490", Offset = "0x6CFD890", VA = "0x186CFE490", Slot = "6")]
	public void InitReferences(MLIFIICJDOD JGADEBKHJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE4E0", Offset = "0x6CFD8E0", VA = "0x186CFE4E0", Slot = "5")]
	public void NNDOMJKBNEK(BLJMICDPKDA CCBEIEEDJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public BFDEOFIHHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[MEMFFHBLAMF(typeof(HNNPDPLDLKK), new string[] { "Ignore", "Mock" })]
public class LLAEKKPMGMI : HNNPDPLDLKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool KBJOGKGELOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP> BIFDFFLDFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F9A0", Offset = "0x6D0EDA0", VA = "0x186D0F9A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FA50", Offset = "0x6D0EE50", VA = "0x186D0FA50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP> FFJBJJKJHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FB00", Offset = "0x6D0EF00", VA = "0x186D0FB00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F8F0", Offset = "0x6D0ECF0", VA = "0x186D0F8F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP, MHFMFIBEDGP> LJIABJLPCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F840", Offset = "0x6D0EC40", VA = "0x186D0F840", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F790", Offset = "0x6D0EB90", VA = "0x186D0F790", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "12")]
	public void CGCFJDLGJFP(GameObject BCDDMHHPJBD, LDGCIJKCDMC CEHGJOALFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "13")]
	public void PPNDJIMKPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "14")]
	public void MHJHNBDIMHP(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "15")]
	public void AMMAKBKKNOC(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "16")]
	public void DJJDAGGOONE(MHFMFIBEDGP MLKBGAPFGJD, HashSet<MHFMFIBEDGP> NOGPEGFAHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "17")]
	public void KPFCPFCCFBH(MHFMFIBEDGP MLKBGAPFGJD, MHFMFIBEDGP HDPNHEJKJDI, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "18")]
	public void BPOBNHECHGK(MHFMFIBEDGP MLKBGAPFGJD, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "19")]
	public void FJKBEFHEAFF(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "20")]
	public NIAGJEFLEEM LFBMMMDOJLP(bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "21")]
	public NIAGJEFLEEM HMFKCJPBMKB(HashSet<Guid> ACBILMIDCHP, bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "22")]
	public bool GKPGKOADIFF(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "23")]
	public void FHJLAABAKHM(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "24")]
	public void DDJKLODKOGG(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "25")]
	public void EIPHANDBOMO(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public LLAEKKPMGMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MHFMFIBEDGP : DNLIBMGMIGF, IEquatable<MHFMFIBEDGP>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DNLIBMGMIGF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MHFMFIBEDGP APEGJBDPCMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject HAIKDHHODMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid NKGNIHBAPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int LAFIFABEHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FKAJAIFILMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int IAFMPAIKJAF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int IAFMPAIKJAF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int IAFMPAIKJAF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int IAFMPAIKJAF, MHFMFIBEDGP FAJLEBJDMPD, int LLBJAGFIODD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int IAFMPAIKJAF, MHFMFIBEDGP LOCNJBEEEII, int GMFEBEKKHKC, Vector3 INBLPDLHPKE, Quaternion JPKJBOODDCM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int IAFMPAIKJAF, MHFMFIBEDGP HIPLKBODBHE, int EGLBGCPGIEC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int IAFMPAIKJAF, MHFMFIBEDGP LNDOPJCOENM, int OOHJCIBEOAA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int IAFMPAIKJAF, MHFMFIBEDGP DBLFFCCLGAO, int CHAPDMFBKOC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(MHFMFIBEDGP PMEPCGEAPCL, MHFMFIBEDGP IHOHCLBEPJH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AEODNGLJNOH(HNNAHENHILF.OMRoom)]
public interface HNNPDPLDLKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool KBJOGKGELOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MHFMFIBEDGP, MHFMFIBEDGP> BIFDFFLDFAB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<MHFMFIBEDGP, MHFMFIBEDGP> FFJBJJKJHLP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<MHFMFIBEDGP, MHFMFIBEDGP, MHFMFIBEDGP> LJIABJLPCID;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CGCFJDLGJFP(GameObject BCDDMHHPJBD, LDGCIJKCDMC CEHGJOALFGN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPNDJIMKPLE();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MHJHNBDIMHP(MHFMFIBEDGP MLKBGAPFGJD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AMMAKBKKNOC(MHFMFIBEDGP MLKBGAPFGJD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DJJDAGGOONE(MHFMFIBEDGP MLKBGAPFGJD, HashSet<MHFMFIBEDGP> NOGPEGFAHIE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KPFCPFCCFBH(MHFMFIBEDGP MLKBGAPFGJD, MHFMFIBEDGP HDPNHEJKJDI, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BPOBNHECHGK(MHFMFIBEDGP MLKBGAPFGJD, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FJKBEFHEAFF(MHFMFIBEDGP MLKBGAPFGJD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NIAGJEFLEEM LFBMMMDOJLP(bool IOCDEOOEOIG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NIAGJEFLEEM HMFKCJPBMKB(HashSet<Guid> ACBILMIDCHP, bool IOCDEOOEOIG);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GKPGKOADIFF(MHHNEENHAHF BDAAIBDOCNE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FHJLAABAKHM(NIAGJEFLEEM CGOGNBPFMJH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DDJKLODKOGG(NIAGJEFLEEM CGOGNBPFMJH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EIPHANDBOMO(NIAGJEFLEEM CGOGNBPFMJH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JAAJPBJINJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NIGDGGKMOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MHFMFIBEDGP ENBPFBKCPAC(int KKFLCOAGHIL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHFMFIBEDGP KDPKNAKPODB(Guid KCNAECEPAKJ);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EJPMBLMOLBD(MHFMFIBEDGP MLKBGAPFGJD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HEOFGIPMNEF();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIJLGEOJKOO(MHFMFIBEDGP LIMGNAPKHFE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface CPAMJEIEEBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMMKHOAHEJJ(JICPPIPELKJ LIMGNAPKHFE);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FINOOGFBKFD(JICPPIPELKJ LIMGNAPKHFE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string DCILBBKJMHI(JICPPIPELKJ LIMGNAPKHFE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OGIAIBGMKMD(JICPPIPELKJ LIMGNAPKHFE);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PANDMGFGNHL(JICPPIPELKJ LIMGNAPKHFE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MGGGBPKLAAJ(JICPPIPELKJ LIMGNAPKHFE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void FBALJPCBKOD(MHFMFIBEDGP KDOFJEODKKP, int GFEFBKAMGAP, MHFMFIBEDGP DBLFFCCLGAO, int LFFKFCNFCOB, [Optional] Vector3? JHPPMCAFCJC, [Optional] Quaternion? CJIJHFNGEPG);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void AIHNIOLALAD(MHFMFIBEDGP PMEPCGEAPCL, MHFMFIBEDGP IHOHCLBEPJH);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JICPPIPELKJ : MHFMFIBEDGP, DNLIBMGMIGF, IEquatable<MHFMFIBEDGP>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FMKONDJAELK : DNLIBMGMIGF
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MHFMFIBEDGP CNMHJMNGFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<MHFMFIBEDGP> PGIPENDPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 BLJOPCFNNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion JHIFHCLMBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AJDOCLKPGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool EDHEGCAMICG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event FBALJPCBKOD LOPNGHJEPKJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event FBALJPCBKOD CHDDFLPBIKD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event FBALJPCBKOD NHPNMPEOJMH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event AIHNIOLALAD HFGMOKBEENI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OICKCJAMCMG();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FMHCNCBOPAE();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KPNPEPLHGOJ();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BBKABCIEMMP();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OBKLKCHGAAE();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AMHFGKAFDOD();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FKANIGGAIJI(int IAFMPAIKJAF, MHFMFIBEDGP DBLFFCCLGAO, int HLDBNDACCID);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EBHHGMDIEKJ();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NHNACAICNOA(int IAFMPAIKJAF, MHFMFIBEDGP KDOFJEODKKP, int AOOKJIKEMDK, [Optional] Vector3? JHPPMCAFCJC, [Optional] Quaternion? CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DHKELEOJHNF(MHFMFIBEDGP KDOFJEODKKP);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PNKDPILPLGF();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NOLAPJPEGOM(int HAJICDLBEKC, Vector3 GOGKCFACHGD);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BCMMKGHECEO(Vector3 NLLOJFNEKLK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KAOAPGGNHHE
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 AANGOGILCFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LDGCIJKCDMC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DMGLLJHPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AFAADNOLNCK CLDDAADGHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, LDGCIJKCDMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xB47470", Offset = "0xB46870", VA = "0x180B47470", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public AFAADNOLNCK LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D06620", Offset = "0x6D05A20", VA = "0x186D06620")]
		public static ConnectableConfigData MNFKJHCJLKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D066E0", Offset = "0x6D05AE0", VA = "0x186D066E0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual NBDEFDHIGGH, bool BPNHJKBLFGB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AMNOOLBKNHH : IEquatable<AMNOOLBKNHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public MHFMFIBEDGP MLKBGAPFGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int OFIAEKGDMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int CHAPDMFBKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 JHPPMCAFCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion CJIJHFNGEPG;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE270", Offset = "0x6CFD670", VA = "0x186CFE270")]
	public AMNOOLBKNHH(MHFMFIBEDGP MLKBGAPFGJD, int OFIAEKGDMFK, int CHAPDMFBKOC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE1D0", Offset = "0x6CFD5D0", VA = "0x186CFE1D0")]
	public AMNOOLBKNHH(MHFMFIBEDGP MLKBGAPFGJD, int OFIAEKGDMFK, int CHAPDMFBKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE2D0", Offset = "0x6CFD6D0", VA = "0x186CFE2D0")]
	public AMNOOLBKNHH(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6CFDD50", Offset = "0x6CFD150", VA = "0x186CFDD50", Slot = "4")]
	public bool Equals(AMNOOLBKNHH KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6CFDE00", Offset = "0x6CFD200", VA = "0x186CFDE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class NENDAJFKBBJ : GKKGAMCOKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform HGENDDPKHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private AFAADNOLNCK IBDBALELHCA;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x67F4910", Offset = "0x67F3D10", VA = "0x1867F4910", Slot = "4")]
	public void CGCFJDLGJFP(Transform HGENDDPKHHK, AFAADNOLNCK IBDBALELHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6D12800", Offset = "0x6D11C00", VA = "0x186D12800", Slot = "5")]
	public AFAADNOLNCK ABPIGLPPIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6D128C0", Offset = "0x6D11CC0", VA = "0x186D128C0", Slot = "6")]
	public void FEOEEHBMCMD(AFAADNOLNCK ABHIKGKLOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public NENDAJFKBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class COBGLOMAGDJ : IDisposable, DFLKANKOBLC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JIALPGHGEDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public MHFMFIBEDGP oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public MHFMFIBEDGP newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JIALPGHGEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A8B0", Offset = "0x6D09CB0", VA = "0x186D0A8B0")]
		internal bool PBDOMDPKBBD(DLGJFNEDNBK node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly MAJJKPEEOIE ICMIFGECNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private KEHFJHLDMEH NIDIDCAGEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private FMPPGEIPCKK EMOLLDGONPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool BPNHJKBLFGB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly FLILHMOBPPM PFHBIHBBMIF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public DLGJFNEDNBK PAGLAEHKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6D036B0", Offset = "0x6D02AB0", VA = "0x186D036B0")]
	public bool DFNNIBDAGMM([In] CBCPBMNKFMH AIKOCCMKKAE, bool BMNJNPAJFGI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D05480", Offset = "0x6D04880", VA = "0x186D05480")]
	private bool OMLLCBDBDPI([In] CBCPBMNKFMH AIKOCCMKKAE, bool BMNJNPAJFGI = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D06450", Offset = "0x6D05850", VA = "0x186D06450")]
	public COBGLOMAGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D03380", Offset = "0x6D02780", VA = "0x186D03380", Slot = "5")]
	public void CGCFJDLGJFP(HNNPDPLDLKK BLMJILKGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D03350", Offset = "0x6D02750", VA = "0x186D03350", Slot = "17")]
	public void BPLHJKPGNNL(MMDHLNCNOEI JMKLCPOKHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6D030A0", Offset = "0x6D024A0", VA = "0x186D030A0", Slot = "12")]
	public void BCNEEPIHCLP(Func<MHFMFIBEDGP, bool> AOEKMABCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6D030B0", Offset = "0x6D024B0", VA = "0x186D030B0")]
	private void BCNEEPIHCLP(MAJJKPEEOIE EKHCANKHNFM, Func<MHFMFIBEDGP, bool> AOEKMABCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6D053B0", Offset = "0x6D047B0", VA = "0x186D053B0", Slot = "11")]
	public void NHCENGLFJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6D04B40", Offset = "0x6D03F40", VA = "0x186D04B40", Slot = "8")]
	public bool HGKDEJDFHNM(MHFMFIBEDGP JCEFBEGIOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D05C90", Offset = "0x6D05090", VA = "0x186D05C90")]
	private bool PAOCDHIPMPJ(MHFMFIBEDGP EMGOKJONMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6D053D0", Offset = "0x6D047D0", VA = "0x186D053D0")]
	private static bool NIBIAEGJIPM(MHFMFIBEDGP EMGOKJONMJJ, MAJJKPEEOIE KMJEDKNLDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6D04330", Offset = "0x6D03730", VA = "0x186D04330")]
	private void GCIKGHBMJMI(Transform OJBLCBHPJAH, MAJJKPEEOIE MNDOGDEKOLH, MAJJKPEEOIE[] NCILNIEJKLO, MHFMFIBEDGP EJHMJKPJALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D04EF0", Offset = "0x6D042F0", VA = "0x186D04EF0")]
	private AMNOOLBKNHH JPHPBNEFEKF(Transform OJIAEBOGIDE, AMNOOLBKNHH MGKJBFCPANG)
	{
		return default(AMNOOLBKNHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D04D30", Offset = "0x6D04130", VA = "0x186D04D30")]
	private static bool JMNDHDGDACL(MAJJKPEEOIE KMJEDKNLDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D04B50", Offset = "0x6D03F50", VA = "0x186D04B50", Slot = "9")]
	public bool JCDHBHDLKON(MHFMFIBEDGP BGOMPOHAHHG, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D05A40", Offset = "0x6D04E40", VA = "0x186D05A40")]
	private bool ONMILCHIBFK(MHFMFIBEDGP BGOMPOHAHHG, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6D04BB0", Offset = "0x6D03FB0", VA = "0x186D04BB0")]
	private static void JHDEGMOEPBN(MHFMFIBEDGP BGOMPOHAHHG, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG, MAJJKPEEOIE GMBFMKLBNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6D050E0", Offset = "0x6D044E0", VA = "0x186D050E0")]
	private void LPICECGBCCJ(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6D05200", Offset = "0x6D04600", VA = "0x186D05200")]
	private void MBGNMFILEBK(MAJJKPEEOIE EKHCANKHNFM, MHFMFIBEDGP EOEPCFKLPNA, MHFMFIBEDGP CLHCMALLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D05270", Offset = "0x6D04670", VA = "0x186D05270")]
	private void MBGNMFILEBK(MHFMFIBEDGP MLKBGAPFGJD, MHFMFIBEDGP EOEPCFKLPNA, MHFMFIBEDGP CLHCMALLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D031E0", Offset = "0x6D025E0", VA = "0x186D031E0")]
	private void BKBIDILAPLO(MHFMFIBEDGP MLKBGAPFGJD, MHFMFIBEDGP EOEPCFKLPNA, MHFMFIBEDGP CLHCMALLCMJ, bool AFMNJIEOBHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D03250", Offset = "0x6D02650", VA = "0x186D03250")]
	private void BKBIDILAPLO(MAJJKPEEOIE KCFGMPGPMFA, MHFMFIBEDGP EJHMJKPJALP, MHFMFIBEDGP IHOHCLBEPJH, bool AFMNJIEOBHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D03590", Offset = "0x6D02990", VA = "0x186D03590")]
	private void DDLCIFJMHIN(MHFMFIBEDGP KADEDLJJJFO, int AOOKJIKEMDK, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6D03430", Offset = "0x6D02830", VA = "0x186D03430")]
	private void CMFNMINGDJA(DLGJFNEDNBK DEDHJMDEEIE, DLGJFNEDNBK AKAEPHNFKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6D041D0", Offset = "0x6D035D0", VA = "0x186D041D0", Slot = "18")]
	public MHFMFIBEDGP FNOMIEMANMM(MHFMFIBEDGP MLKBGAPFGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6D036C0", Offset = "0x6D02AC0", VA = "0x186D036C0", Slot = "13")]
	public void DJJDAGGOONE(MHFMFIBEDGP MLKBGAPFGJD, HashSet<MHFMFIBEDGP> DCPBKNKOPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6D047F0", Offset = "0x6D03BF0", VA = "0x186D047F0", Slot = "14")]
	public List<MHFMFIBEDGP> HBOEPJOHNDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6D04720", Offset = "0x6D03B20", VA = "0x186D04720")]
	protected DLGJFNEDNBK GJEAGFHCCBF(DLGJFNEDNBK EKHCANKHNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D05040", Offset = "0x6D04440", VA = "0x186D05040")]
	protected MAJJKPEEOIE[] KPEACJDHGBD(MAJJKPEEOIE KMJEDKNLDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D04A30", Offset = "0x6D03E30", VA = "0x186D04A30")]
	protected bool HCKFDECNIOD(MHFMFIBEDGP MLKBGAPFGJD, [Out] MAJJKPEEOIE EKHCANKHNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D04000", Offset = "0x6D03400", VA = "0x186D04000", Slot = "15")]
	public bool EINOEDMFCAN(MHFMFIBEDGP MLKBGAPFGJD, [Out] AMNOOLBKNHH DPBEKDONHPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D04130", Offset = "0x6D03530", VA = "0x186D04130")]
	protected MAJJKPEEOIE FGALKPODABM(AMNOOLBKNHH JKCNLHHJIAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D04170", Offset = "0x6D03570", VA = "0x186D04170", Slot = "10")]
	public bool FHMNHNLFPBA(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D03A60", Offset = "0x6D02E60", VA = "0x186D03A60")]
	private bool EEOEMAIHCEH(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D052E0", Offset = "0x6D046E0", VA = "0x186D052E0")]
	private static bool MOABMMMKPPA(MAJJKPEEOIE HMJODKFFDED, AMNOOLBKNHH MDELKPMAPFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6D036B0", Offset = "0x6D02AB0", VA = "0x186D036B0", Slot = "7")]
	private bool IMJEEMFDJPF([In] CBCPBMNKFMH AIKOCCMKKAE, bool BMNJNPAJFGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class GHMCIMJFALI : HNNPDPLDLKK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly LBNNADLFMIK FKEBHAJCLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly FMPPGEIPCKK EMOLLDGONPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly DNFBGKFLCIA IODLDHIFEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly KAEEBGDIFLE CEJJKNLLALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly DFLKANKOBLC CGOGNBPFMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal MLFCJAMJMEA BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal MJMIIHIEFJC BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal KEHFJHLDMEH MMNHKAOFPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool BPNHJKBLFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool LHCGJLFDBAH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool AHIBKAKFLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xBE31E0", Offset = "0xBE25E0", VA = "0x180BE31E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1E04D50", Offset = "0x1E04150", VA = "0x181E04D50")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xBE31D0", Offset = "0xBE25D0", VA = "0x180BE31D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1E04D40", Offset = "0x1E04140", VA = "0x181E04D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool KBJOGKGELOH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP> BIFDFFLDFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6D08530", Offset = "0x6D07930", VA = "0x186D08530", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6D08D70", Offset = "0x6D08170", VA = "0x186D08D70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP> FFJBJJKJHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D08E90", Offset = "0x6D08290", VA = "0x186D08E90", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D08130", Offset = "0x6D07530", VA = "0x186D08130", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MHFMFIBEDGP, MHFMFIBEDGP, MHFMFIBEDGP> LJIABJLPCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6D07E80", Offset = "0x6D07280", VA = "0x186D07E80", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6D07260", Offset = "0x6D06660", VA = "0x186D07260", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6D08F40", Offset = "0x6D08340", VA = "0x186D08F40")]
	public GHMCIMJFALI(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6D07460", Offset = "0x6D06860", VA = "0x186D07460", Slot = "12")]
	public void CGCFJDLGJFP(GameObject BCDDMHHPJBD, LDGCIJKCDMC CEHGJOALFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6D07D10", Offset = "0x6D07110", VA = "0x186D07D10", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D08EF0", Offset = "0x6D082F0", VA = "0x186D08EF0", Slot = "13")]
	public void PPNDJIMKPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6D08D50", Offset = "0x6D08150", VA = "0x186D08D50", Slot = "14")]
	public void MHJHNBDIMHP(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D072C0", Offset = "0x6D066C0", VA = "0x186D072C0", Slot = "15")]
	public void AMMAKBKKNOC(MHFMFIBEDGP MLKBGAPFGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6D081F0", Offset = "0x6D075F0", VA = "0x186D081F0", Slot = "22")]
	public bool GKPGKOADIFF(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D08DD0", Offset = "0x6D081D0", VA = "0x186D08DD0")]
	internal bool OMLLCBDBDPI([In] CBCPBMNKFMH AIKOCCMKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6D07DB0", Offset = "0x6D071B0", VA = "0x186D07DB0")]
	internal bool EEOEMAIHCEH([In] CBCPBMNKFMH AIKOCCMKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6D08190", Offset = "0x6D07590", VA = "0x186D08190")]
	internal bool GJFDGEPBJLE([In] CBCPBMNKFMH AIKOCCMKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D083E0", Offset = "0x6D077E0", VA = "0x186D083E0")]
	internal bool IJCIPACIEHD([In] CBCPBMNKFMH AIKOCCMKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6D08920", Offset = "0x6D07D20", VA = "0x186D08920")]
	internal void MDIFNDPADBJ(MHFMFIBEDGP MLKBGAPFGJD, int OEGFNFHJEDE, bool BMNJNPAJFGI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6D072C0", Offset = "0x6D066C0", VA = "0x186D072C0")]
	internal bool PFBFGEAECMO(MHFMFIBEDGP PGCBCKPANDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D07AE0", Offset = "0x6D06EE0", VA = "0x186D07AE0")]
	internal bool DINLMDGLDEL(MHFMFIBEDGP BGOMPOHAHHG, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D07C20", Offset = "0x6D07020", VA = "0x186D07C20", Slot = "16")]
	public void DJJDAGGOONE(MHFMFIBEDGP MLKBGAPFGJD, HashSet<MHFMFIBEDGP> NOGPEGFAHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6D08590", Offset = "0x6D07990", VA = "0x186D08590", Slot = "17")]
	public void KPFCPFCCFBH(MHFMFIBEDGP BGOMPOHAHHG, MHFMFIBEDGP HDPNHEJKJDI, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D07320", Offset = "0x6D06720", VA = "0x186D07320", Slot = "18")]
	public void BPOBNHECHGK(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D07F70", Offset = "0x6D07370", VA = "0x186D07F70", Slot = "19")]
	public void FJKBEFHEAFF(MHFMFIBEDGP MGBEIAEPAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D08B00", Offset = "0x6D07F00", VA = "0x186D08B00")]
	public void MDJGENDKBHO([Optional] JHOFFOJEGKC PHBCPKDLNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6D07EE0", Offset = "0x6D072E0", VA = "0x186D07EE0", Slot = "23")]
	public void FHJLAABAKHM(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D087A0", Offset = "0x6D07BA0", VA = "0x186D087A0", Slot = "20")]
	public NIAGJEFLEEM LFBMMMDOJLP(bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6D08240", Offset = "0x6D07640", VA = "0x186D08240", Slot = "21")]
	public NIAGJEFLEEM HMFKCJPBMKB(HashSet<Guid> ACBILMIDCHP, bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D07E40", Offset = "0x6D07240", VA = "0x186D07E40", Slot = "25")]
	public void EIPHANDBOMO(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6D07A30", Offset = "0x6D06E30", VA = "0x186D07A30", Slot = "24")]
	public void DDJKLODKOGG(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class FMPPGEIPCKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly HBLLMAEIFAH<MHFMFIBEDGP, MHFMFIBEDGP> BIFDFFLDFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly HBLLMAEIFAH<MHFMFIBEDGP, MHFMFIBEDGP> FFJBJJKJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly AOBPLAOOIGJ<MHFMFIBEDGP, MHFMFIBEDGP, MHFMFIBEDGP> LJIABJLPCID;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D07140", Offset = "0x6D06540", VA = "0x186D07140")]
	public FMPPGEIPCKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public void CGCFJDLGJFP(GHMCIMJFALI BLMJILKGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6D07000", Offset = "0x6D06400", VA = "0x186D07000")]
	public void AKOMLHOIJHH(MHFMFIBEDGP DEDHJMDEEIE, MHFMFIBEDGP KADEDLJJJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D070E0", Offset = "0x6D064E0", VA = "0x186D070E0")]
	public void PKKKFIOONHG(MHFMFIBEDGP DEDHJMDEEIE, MHFMFIBEDGP KADEDLJJJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6D07060", Offset = "0x6D06460", VA = "0x186D07060")]
	public void CHHJHDNBFCN(MHFMFIBEDGP JHFMLMDHLPE, MHFMFIBEDGP LNNICEPGDAG, MHFMFIBEDGP KADEDLJJJFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class DNFBGKFLCIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private GHMCIMJFALI BLMJILKGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private MJMIIHIEFJC BHLNPLGEMCN;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public DNFBGKFLCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D06730", Offset = "0x6D05B30", VA = "0x186D06730")]
	public void CGCFJDLGJFP(GHMCIMJFALI BLMJILKGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D06860", Offset = "0x6D05C60", VA = "0x186D06860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D06870", Offset = "0x6D05C70", VA = "0x186D06870")]
	private void IIBHGDMAOKO(JHOFFOJEGKC PEIJBHPINLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D06A90", Offset = "0x6D05E90", VA = "0x186D06A90")]
	private void NJNAIEFMOLJ(JHOFFOJEGKC JBMGMBPEPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D06990", Offset = "0x6D05D90", VA = "0x186D06990")]
	public void NCFJIOFCKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D06890", Offset = "0x6D05C90", VA = "0x186D06890")]
	public void KJHCENNPOEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LEGLMBDIHKL
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KDNFBGOIJGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LBNNADLFMIK container;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KDNFBGOIJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6D0ED90", Offset = "0x6D0E190", VA = "0x186D0ED90")]
		internal GHMCIMJFALI HBEPANEJJPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F340", Offset = "0x6D0E740", VA = "0x186D0F340")]
	public static void FEHLMOFHDJL(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D0F540", Offset = "0x6D0E940", VA = "0x186D0F540")]
	public static void HACMEGJEBAN(LBNNADLFMIK FKEBHAJCLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class GMKJPMMGNAD : IDisposable, KEHFJHLDMEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, AFAADNOLNCK> DDHNNENIGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MMDHLNCNOEI PEIOBHNHPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private GKKGAMCOKCK HFHPAEEBEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private DFLKANKOBLC CGOGNBPFMJH;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6D09EA0", Offset = "0x6D092A0", VA = "0x186D09EA0")]
	public GMKJPMMGNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6D094A0", Offset = "0x6D088A0", VA = "0x186D094A0", Slot = "7")]
	public void CGCFJDLGJFP(DFLKANKOBLC CGOGNBPFMJH, GKKGAMCOKCK HFHPAEEBEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6D09750", Offset = "0x6D08B50", VA = "0x186D09750", Slot = "5")]
	public void IGFGDPDGCEA(DLGJFNEDNBK FJPHEILLGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6D09330", Offset = "0x6D08730", VA = "0x186D09330", Slot = "9")]
	public void BEDONBIDKME(DLGJFNEDNBK NCIJPBILOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6D09990", Offset = "0x6D08D90", VA = "0x186D09990", Slot = "8")]
	public void INKFEHMNOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D09B50", Offset = "0x6D08F50", VA = "0x186D09B50", Slot = "10")]
	public void NGKGLJMPLLD(DLGJFNEDNBK CMDNBLLJEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6D094E0", Offset = "0x6D088E0", VA = "0x186D094E0", Slot = "11")]
	public void FBJLEBGEPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6D095A0", Offset = "0x6D089A0", VA = "0x186D095A0")]
	private bool FHIHMDBABIF(DLGJFNEDNBK AFMDDDNOHPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class KAEEBGDIFLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct IAPANHHGLMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly MAJJKPEEOIE NIAPECBICHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> ACBILMIDCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly MHHNEENHAHF CFJAMIDHDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly MHHNEENHAHF ELNDNFCEEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool IOCDEOOEOIG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool JEKCKIDNJIA
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0A360", Offset = "0x6D09760", VA = "0x186D0A360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A840", Offset = "0x6D09C40", VA = "0x186D0A840")]
		public IAPANHHGLMN(MAJJKPEEOIE NIAPECBICHO, HashSet<Guid> ACBILMIDCHP, bool IOCDEOOEOIG, [Optional] MHHNEENHAHF CFJAMIDHDNC, [Optional] MHHNEENHAHF ELNDNFCEEKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A470", Offset = "0x6D09870", VA = "0x186D0A470")]
		public MHHNEENHAHF IFDLICGNEEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A610", Offset = "0x6D09A10", VA = "0x186D0A610")]
		private MHHNEENHAHF MLHACINFIMA([Out] MHHNEENHAHF LNBFEEGLEEJ, [Out] MHHNEENHAHF MGMIHIOCNCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A140", Offset = "0x6D09540", VA = "0x186D0A140")]
		private MHHNEENHAHF HJMCGCOHFPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A6D0", Offset = "0x6D09AD0", VA = "0x186D0A6D0")]
		private void NLLJOPJCHOH(MHHNEENHAHF PCOELBPOEBB, MHHNEENHAHF PLODCEKOMGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6D09F80", Offset = "0x6D09380", VA = "0x186D09F80")]
		private void CKIJCPBIBLD(MHHNEENHAHF LNBFEEGLEEJ, MHHNEENHAHF MGMIHIOCNCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private GHMCIMJFALI BLMJILKGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private DFLKANKOBLC CGOGNBPFMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private KEHFJHLDMEH NIDIDCAGEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private MJMIIHIEFJC BHLNPLGEMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool CCGMLPPCPJN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool EPPJGCCEMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6D0ECB0", Offset = "0x6D0E0B0", VA = "0x186D0ECB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool AHIBKAKFLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CDB0", Offset = "0x6D0C1B0", VA = "0x186D0CDB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6D0ED00", Offset = "0x6D0E100", VA = "0x186D0ED00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CEE0", Offset = "0x6D0C2E0", VA = "0x186D0CEE0")]
	public void CGCFJDLGJFP(GHMCIMJFALI BLMJILKGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E810", Offset = "0x6D0DC10", VA = "0x186D0E810")]
	public NIAGJEFLEEM LFBMMMDOJLP(bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E550", Offset = "0x6D0D950", VA = "0x186D0E550")]
	public NIAGJEFLEEM HMFKCJPBMKB(HashSet<Guid> ACBILMIDCHP, bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E010", Offset = "0x6D0D410", VA = "0x186D0E010")]
	public void FHJLAABAKHM(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D4D0", Offset = "0x6D0C8D0", VA = "0x186D0D4D0")]
	public void DDJKLODKOGG(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E6F0", Offset = "0x6D0DAF0", VA = "0x186D0E6F0")]
	public void IBGKELEPGPB(NIAGJEFLEEM CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D2F0", Offset = "0x6D0C6F0", VA = "0x186D0D2F0")]
	private void DANFCHNEFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D200", Offset = "0x6D0C600", VA = "0x186D0D200")]
	private MHHNEENHAHF CPJBBKKNFJB(MAJJKPEEOIE EKHCANKHNFM, bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CF50", Offset = "0x6D0C350", VA = "0x186D0CF50")]
	private static void CJNPJJMCFMB(MAJJKPEEOIE EKHCANKHNFM, bool IOCDEOOEOIG, MHHNEENHAHF BDAAIBDOCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E330", Offset = "0x6D0D730", VA = "0x186D0E330")]
	private void HFFDIKMMNFB(MAJJKPEEOIE EKHCANKHNFM, bool IOCDEOOEOIG, MHHNEENHAHF BDAAIBDOCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E980", Offset = "0x6D0DD80", VA = "0x186D0E980")]
	private MHHNEENHAHF MLAPGOBINIP(MAJJKPEEOIE NIAPECBICHO, HashSet<Guid> ACBILMIDCHP, bool IOCDEOOEOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EA10", Offset = "0x6D0DE10", VA = "0x186D0EA10")]
	private bool NIJIAKMKIMH(NIAGJEFLEEM LCLICNNKDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C740", Offset = "0x6D0BB40", VA = "0x186D0C740")]
	private bool AAOEAJMOLHL(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6D0EC90", Offset = "0x6D0E090", VA = "0x186D0EC90")]
	private bool OHLDFPIFPAJ(NIAGJEFLEEM CGOGNBPFMJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6D0CDD0", Offset = "0x6D0C1D0", VA = "0x186D0CDD0")]
	private static bool CAAAMDBINBM(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E0A0", Offset = "0x6D0D4A0", VA = "0x186D0E0A0")]
	public static bool GKPGKOADIFF(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DCC0", Offset = "0x6D0D0C0", VA = "0x186D0DCC0")]
	private MHFMFIBEDGP FGDHNCDBHCD(MHHNEENHAHF BDAAIBDOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D9B0", Offset = "0x6D0CDB0", VA = "0x186D0D9B0")]
	private MHFMFIBEDGP ENBPFBKCPAC(MHHNEENHAHF BDAAIBDOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DB30", Offset = "0x6D0CF30", VA = "0x186D0DB30")]
	private MHFMFIBEDGP FFCOKMHPAHF(MHHNEENHAHF BDAAIBDOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6D01D00", Offset = "0x6D01100", VA = "0x186D01D00")]
	private static Guid LEFNPGENILK(MHHNEENHAHF BDAAIBDOCNE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E720", Offset = "0x6D0DB20", VA = "0x186D0E720")]
	private string JHFDKOFHEII(MHHNEENHAHF BDAAIBDOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D7D0", Offset = "0x6D0CBD0", VA = "0x186D0D7D0")]
	private bool EBEPFNLHAEB(MAJJKPEEOIE EKHCANKHNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6D0D570", Offset = "0x6D0C970", VA = "0x186D0D570")]
	private static void DNHAFDPCKAO(MAJJKPEEOIE NIAPECBICHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public KAEEBGDIFLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct CBCPBMNKFMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public MHFMFIBEDGP KADEDLJJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public MHFMFIBEDGP DEDHJMDEEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int AOOKJIKEMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int HLDBNDACCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 JHPPMCAFCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion CJIJHFNGEPG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public AMNOOLBKNHH MNGHAJMEPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE7F0", Offset = "0x6CFDBF0", VA = "0x186CFE7F0")]
		get
		{
			return default(AMNOOLBKNHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public AMNOOLBKNHH JCJKCBKOMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE890", Offset = "0x6CFDC90", VA = "0x186CFE890")]
		get
		{
			return default(AMNOOLBKNHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE8C0", Offset = "0x6CFDCC0", VA = "0x186CFE8C0")]
	public CBCPBMNKFMH(MHFMFIBEDGP KADEDLJJJFO, MHFMFIBEDGP DEDHJMDEEIE, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface DFLKANKOBLC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DLGJFNEDNBK PAGLAEHKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGCFJDLGJFP(HNNPDPLDLKK BLMJILKGBHG);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DFNNIBDAGMM([In] CBCPBMNKFMH AIKOCCMKKAE, bool BMNJNPAJFGI = true);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HGKDEJDFHNM(MHFMFIBEDGP JCEFBEGIOHN);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JCDHBHDLKON(MHFMFIBEDGP BGOMPOHAHHG, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FHMNHNLFPBA(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHCENGLFJHE();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCNEEPIHCLP(Func<MHFMFIBEDGP, bool> AOEKMABCBKB);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DJJDAGGOONE(MHFMFIBEDGP MLKBGAPFGJD, HashSet<MHFMFIBEDGP> DCPBKNKOPEN);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<MHFMFIBEDGP> HBOEPJOHNDK();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EINOEDMFCAN(MHFMFIBEDGP MLKBGAPFGJD, [Out] AMNOOLBKNHH DPBEKDONHPB);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BPLHJKPGNNL(MMDHLNCNOEI JMKLCPOKHHP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool MMDHLNCNOEI(DLGJFNEDNBK EKHCANKHNFM);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface DLGJFNEDNBK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MHFMFIBEDGP CKGIMIMCAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DLGJFNEDNBK CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AMNOOLBKNHH LGEDJDEJOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KBNMNHHOMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface AFAADNOLNCK : ANOOAILMLAC.EJKBPOBBLJI
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPNPHEKPPLJ(MHFMFIBEDGP DBLFFCCLGAO, AMNOOLBKNHH KADEDLJJJFO);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFIPJIHJJEB(MHFMFIBEDGP DBLFFCCLGAO, AMNOOLBKNHH KADEDLJJJFO);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADAMMKJADEO(MHFMFIBEDGP DBLFFCCLGAO, AMNOOLBKNHH KADEDLJJJFO);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBBEILPIDLN(MHFMFIBEDGP DBLFFCCLGAO, AMNOOLBKNHH KADEDLJJJFO);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AFAADNOLNCK Instantiate(Transform HGENDDPKHHK);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJDEEDGEPIJ();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GKKGAMCOKCK
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGCFJDLGJFP(Transform HGENDDPKHHK, AFAADNOLNCK IBDBALELHCA);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AFAADNOLNCK ABPIGLPPIHH();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEOEEHBMCMD(AFAADNOLNCK ABHIKGKLOEM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface MLFCJAMJMEA : JAAJPBJINJK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGFACEKGOFE(Guid COHJIHMFNCH);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KEHFJHLDMEH
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGFGDPDGCEA(DLGJFNEDNBK FJPHEILLGPC);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGCFJDLGJFP(DFLKANKOBLC CGOGNBPFMJH, GKKGAMCOKCK OELMCLBMPAK);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INKFEHMNOPI();

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BEDONBIDKME(DLGJFNEDNBK NCIJPBILOKH);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGKGLJMPLLD(DLGJFNEDNBK CMDNBLLJEIB);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FBJLEBGEPJL();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class MAJJKPEEOIE : DLGJFNEDNBK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BOEDIMJPJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AMNOOLBKNHH nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public MAJJKPEEOIE foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public BOEDIMJPJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CFE6B0", Offset = "0x6CFDAB0", VA = "0x186CFE6B0")]
		internal bool PCPHFJFJGFH(DLGJFNEDNBK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private AMNOOLBKNHH DPBEKDONHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<MAJJKPEEOIE> BGJNHCEFIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private MAJJKPEEOIE ONIHOMHDFIL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public AMNOOLBKNHH LGEDJDEJOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C14090", Offset = "0x3C13490", VA = "0x183C14090", Slot = "6")]
		get
		{
			return default(AMNOOLBKNHH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D12140", Offset = "0x6D11540", VA = "0x186D12140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private MAJJKPEEOIE DEDHJMDEEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D12670", Offset = "0x6D11A70", VA = "0x186D12670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DLGJFNEDNBK CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MHFMFIBEDGP CKGIMIMCAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KBNMNHHOMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D124A0", Offset = "0x6D118A0", VA = "0x186D124A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JCOOFLEKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D124B0", Offset = "0x6D118B0", VA = "0x186D124B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected MAJJKPEEOIE KCFGMPGPMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D12500", Offset = "0x6D11900", VA = "0x186D12500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D12750", Offset = "0x6D11B50", VA = "0x186D12750")]
	public MAJJKPEEOIE(AMNOOLBKNHH DHFBOJMOENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D11CA0", Offset = "0x6D110A0", VA = "0x186D11CA0")]
	public MAJJKPEEOIE BHKAAHKPFIE(AMNOOLBKNHH NEEKFDCFCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D12170", Offset = "0x6D11570", VA = "0x186D12170")]
	public MAJJKPEEOIE DPPJDLALLMM(AMNOOLBKNHH COADEBBKJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D11DF0", Offset = "0x6D111F0", VA = "0x186D11DF0")]
	public MAJJKPEEOIE BJFEGIDGDBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D12520", Offset = "0x6D11920", VA = "0x186D12520")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D122F0", Offset = "0x6D116F0", VA = "0x186D122F0")]
	public MAJJKPEEOIE EGGLPBMAIAL(AMNOOLBKNHH LNNICEPGDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D11FD0", Offset = "0x6D113D0", VA = "0x186D11FD0")]
	private static void BPLHJKPGNNL(MAJJKPEEOIE LHFEDHOEGBF, MMDHLNCNOEI DJJCJPCNFNK, bool KNCJKLBMGCP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D12130", Offset = "0x6D11530", VA = "0x186D12130", Slot = "9")]
	public void BPLHJKPGNNL(MMDHLNCNOEI JMKLCPOKHHP, bool AFMNJIEOBHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D123A0", Offset = "0x6D117A0", VA = "0x186D123A0")]
	public static MAJJKPEEOIE FGALKPODABM(MAJJKPEEOIE LHFEDHOEGBF, AMNOOLBKNHH NMECDBLNIBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface MJMIIHIEFJC
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool EPPJGCCEMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool NIGDGGKMOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<JHOFFOJEGKC> IIBHGDMAOKO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<JHOFFOJEGKC> NJNAIEFMOLJ;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(GHMCIMJFALI BLMJILKGBHG);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(MHFMFIBEDGP BGOMPOHAHHG, MHFMFIBEDGP HDPNHEJKJDI, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(NIAGJEFLEEM JMCFNDKGEAE, [Optional] JHOFFOJEGKC PHBCPKDLNMK);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, MJMIIHIEFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private GHMCIMJFALI BLMJILKGBHG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool EPPJGCCEMHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x6D11920", Offset = "0x6D10D20", VA = "0x186D11920", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool NIGDGGKMOFO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6D11980", Offset = "0x6D10D80", VA = "0x186D11980", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<JHOFFOJEGKC> IIBHGDMAOKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6D11880", Offset = "0x6D10C80", VA = "0x186D11880", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6D11A60", Offset = "0x6D10E60", VA = "0x186D11A60", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JHOFFOJEGKC> NJNAIEFMOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6D117E0", Offset = "0x6D10BE0", VA = "0x186D117E0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6D119C0", Offset = "0x6D10DC0", VA = "0x186D119C0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C20", Offset = "0x8B2020", VA = "0x1808B2C20", Slot = "19")]
		public void SetManager(GHMCIMJFALI BLMJILKGBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D117B0", Offset = "0x6D10BB0", VA = "0x186D117B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D10530", Offset = "0x6D0F930", VA = "0x186D10530", Slot = "23")]
		public void RequestMasterConnectNodes(MHFMFIBEDGP KDOFJEODKKP, int AOOKJIKEMDK, MHFMFIBEDGP DBLFFCCLGAO, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D10660", Offset = "0x6D0FA60", VA = "0x186D10660", Slot = "24")]
		public void RequestMasterDisconnectNode(MHFMFIBEDGP JCEFBEGIOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D10720", Offset = "0x6D0FB20", VA = "0x186D10720", Slot = "20")]
		public void RequestMasterModifyNode(MHFMFIBEDGP BGOMPOHAHHG, MHFMFIBEDGP HDPNHEJKJDI, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D10850", Offset = "0x6D0FC50", VA = "0x186D10850", Slot = "21")]
		public void RequestMasterReparentNodes(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D10980", Offset = "0x6D0FD80", VA = "0x186D10980", Slot = "25")]
		public void RequestMasterReparentToRoot(MHFMFIBEDGP MGBEIAEPAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D10400", Offset = "0x6D0F800", VA = "0x186D10400", Slot = "22")]
		public void RequestDeserializeConnectableGraph(NIAGJEFLEEM JMCFNDKGEAE, [Optional] JHOFFOJEGKC PHBCPKDLNMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D10D60", Offset = "0x6D10160", VA = "0x186D10D60")]
		[CILBKHLOPBL]
		private void RpcMasterConnectNodes(MHFMFIBEDGP KDOFJEODKKP, int AOOKJIKEMDK, MHFMFIBEDGP DBLFFCCLGAO, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D11020", Offset = "0x6D10420", VA = "0x186D11020")]
		[CILBKHLOPBL]
		private void RpcMasterDisconnectNode(MHFMFIBEDGP JCEFBEGIOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D11360", Offset = "0x6D10760", VA = "0x186D11360")]
		[CILBKHLOPBL]
		private void RpcMasterReparentNodes(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D11160", Offset = "0x6D10560", VA = "0x186D11160")]
		[CILBKHLOPBL]
		private void RpcMasterModifyNode(MHFMFIBEDGP BGOMPOHAHHG, MHFMFIBEDGP HDPNHEJKJDI, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6D10B50", Offset = "0x6D0FF50", VA = "0x186D10B50")]
		[CILBKHLOPBL]
		private void RpcConnectNodes(MHFMFIBEDGP KDOFJEODKKP, int AOOKJIKEMDK, MHFMFIBEDGP DBLFFCCLGAO, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG, COMNAFNIIMP FLNBJPBEJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6D10CD0", Offset = "0x6D100D0", VA = "0x186D10CD0")]
		[CILBKHLOPBL]
		private void RpcDisconnectNode(MHFMFIBEDGP JCEFBEGIOHN, COMNAFNIIMP FLNBJPBEJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D116B0", Offset = "0x6D10AB0", VA = "0x186D116B0")]
		[CILBKHLOPBL]
		private void RpcReparentNodes(MHFMFIBEDGP MGBEIAEPAIM, int KKKLECEBEOH, MHFMFIBEDGP LNNICEPGDAG, int GMFEBEKKHKC, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG, COMNAFNIIMP FLNBJPBEJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D115F0", Offset = "0x6D109F0", VA = "0x186D115F0")]
		[CILBKHLOPBL]
		private void RpcModifyNode(MHFMFIBEDGP BGOMPOHAHHG, int AOOKJIKEMDK, int HLDBNDACCID, Vector3 JHPPMCAFCJC, Quaternion CJIJHFNGEPG, COMNAFNIIMP FLNBJPBEJNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D10C90", Offset = "0x6D10090", VA = "0x186D10C90")]
		[CILBKHLOPBL]
		private void RpcDeserializeConnectableGraph(NIAGJEFLEEM CGOGNBPFMJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C62D0", Offset = "0x8C56D0", VA = "0x1808C62D0")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, AFAADNOLNCK, ANOOAILMLAC.EJKBPOBBLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FC20", Offset = "0x6D0F020", VA = "0x186D0FC20", Slot = "4")]
		private void EMGBAHACJNK(MHFMFIBEDGP DBLFFCCLGAO, AMNOOLBKNHH KADEDLJJJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D10180", Offset = "0x6D0F580", VA = "0x186D10180", Slot = "5")]
		private void PELLMFDBMGD(MHFMFIBEDGP DBLFFCCLGAO, AMNOOLBKNHH KADEDLJJJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FDA0", Offset = "0x6D0F1A0", VA = "0x186D0FDA0", Slot = "6")]
		private void IDDBBJOJKCN(MHFMFIBEDGP DBLFFCCLGAO, AMNOOLBKNHH KADEDLJJJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FF30", Offset = "0x6D0F330", VA = "0x186D0FF30", Slot = "7")]
		private void KIEONFBHLOC(MHFMFIBEDGP DBLFFCCLGAO, AMNOOLBKNHH KADEDLJJJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D0FEC0", Offset = "0x6D0F2C0", VA = "0x186D0FEC0", Slot = "8")]
		private AFAADNOLNCK JNCIBEKKDMP(Transform HGENDDPKHHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D10120", Offset = "0x6D0F520", VA = "0x186D10120", Slot = "9")]
		private void LIHMFIKIHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DEMOHECFJPM
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0CF0", Offset = "0x2CA00F0", VA = "0x182CA0CF0")]
	public static AANOAKMGCHK<T> BAPBKJDGKPN<T>(this LBNNADLFMIK FKEBHAJCLGD)
	{
		return null;
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
