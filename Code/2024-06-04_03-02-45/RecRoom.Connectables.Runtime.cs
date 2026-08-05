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
	public class LogRegistrationIndex : IFEEDCBNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67A5530", Offset = "0x67A3D30", VA = "0x1867A5530", Slot = "4")]
		public override void MPPLGFJBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
	public class _AssemblyIndex : NDNGKAAFJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EOODGALFNHL bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EOODGALFNHL bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8474A0", Offset = "0x845CA0", VA = "0x1808474A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67A9720", Offset = "0x67A7F20", VA = "0x1867A9720", Slot = "5")]
		public override void NCCJLKGOOND(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67A9440", Offset = "0x67A7C40", VA = "0x1867A9440")]
		private void BFGJMJHNDBB(BHFHJLNFDOB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67A95B0", Offset = "0x67A7DB0", VA = "0x1867A95B0")]
		private void JCIOMNEPMLO(BHFHJLNFDOB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67A9100", Offset = "0x67A7900", VA = "0x1867A9100", Slot = "6")]
		public override void ADLANINFHKN(BHFHJLNFDOB registry, [In] AHOCCHEAOIJ filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "8")]
		public override void BJELADPEBKG(LJEINPAGHKF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67A9760", Offset = "0x67A7F60", VA = "0x1867A9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class HECIILDJFAF : LLBJMBBMIPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class CHBPOLBFPNL : IEnumerable<CNECBCEAJHF>, IEnumerable, IEnumerator<CNECBCEAJHF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CNECBCEAJHF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private PBDHGENIJKH localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PBDHGENIJKH <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HECIILDJFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KLGGLOMIJJG <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private IMJGNGJFNGC.EAKCOOGLGDI <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CNECBCEAJHF System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
		[DebuggerHidden]
		public CHBPOLBFPNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6796620", Offset = "0x6794E20", VA = "0x186796620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6796140", Offset = "0x6794940", VA = "0x186796140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6796500", Offset = "0x6794D00", VA = "0x186796500")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x67965D0", Offset = "0x6794DD0", VA = "0x1867965D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6796520", Offset = "0x6794D20", VA = "0x186796520", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CNECBCEAJHF> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6796520", Offset = "0x6794D20", VA = "0x186796520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GPHLAMKNJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public HECIILDJFAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AHHNIAPMJCH nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public GPHLAMKNJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x679ACB0", Offset = "0x67994B0", VA = "0x18679ACB0")]
		internal object PKBCLDHHHIF(AHHNIAPMJCH x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OLOJOGHHBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AHHNIAPMJCH child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GPHLAMKNJJJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OLOJOGHHBGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x67A6310", Offset = "0x67A4B10", VA = "0x1867A6310")]
		internal object DKLJBFMIGKO((AHHNIAPMJCH child, AHHNIAPMJCH nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly MMJHHDEPGMK MPDHIJEJKDD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly MMJHHDEPGMK PEIFALHMFFJ;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly MMJHHDEPGMK JCANMDGGLLP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly MMJHHDEPGMK HLMMKIFHGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private ALDDMJNLKBP CDFMICOCABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MKGBMLANGKF GPGBLFPGCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private OEOPDIPHJKO AIBOMANLLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private GOFGAJCKLFC NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private OHGOHIGMODC ABACPADKLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DFHBBMDAKPJ FOBEFOGAKJK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x854890", Offset = "0x853090", VA = "0x180854890", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x854510", Offset = "0x852D10", VA = "0x180854510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PGNIFFJHMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF> CPMCDHLCINC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x679DB20", Offset = "0x679C320", VA = "0x18679DB20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x679D350", Offset = "0x679BB50", VA = "0x18679D350", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF> JBEFAGKKOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x679C610", Offset = "0x679AE10", VA = "0x18679C610", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x679C6C0", Offset = "0x679AEC0", VA = "0x18679C6C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF, CNECBCEAJHF> IGOLAAEDFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x679CE20", Offset = "0x679B620", VA = "0x18679CE20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x679B310", Offset = "0x6799B10", VA = "0x18679B310", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x679F470", Offset = "0x679DC70", VA = "0x18679F470")]
	public HECIILDJFAF(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x679B940", Offset = "0x679A140", VA = "0x18679B940", Slot = "12")]
	public void DIHNAABPOCM(GameObject DLBGNHFNDNP, HLNNEGADJJO ODOHDKGFPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x679BBB0", Offset = "0x679A3B0", VA = "0x18679BBB0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x679E710", Offset = "0x679CF10", VA = "0x18679E710", Slot = "22")]
	public bool MNHDPDBLIKN(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x679EA70", Offset = "0x679D270", VA = "0x18679EA70")]
	private void NPCDGAAFPFB(PBDHGENIJKH LBAKOIOMFBB, PBDHGENIJKH CBEPEKFMPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x679D8C0", Offset = "0x679C0C0", VA = "0x18679D8C0")]
	private void KAGFJJADKJD(PBDHGENIJKH LBAKOIOMFBB, PBDHGENIJKH ONKPHDMCMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x679DBD0", Offset = "0x679C3D0", VA = "0x18679DBD0")]
	private void KMLGDALOPCH(PBDHGENIJKH LBAKOIOMFBB, PBDHGENIJKH ONKPHDMCMKL, PBDHGENIJKH CBEPEKFMPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x679EC80", Offset = "0x679D480", VA = "0x18679EC80")]
	private void OHJPPNKJDMK(PBDHGENIJKH LBAKOIOMFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "13")]
	public void EAHBMFPNBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x679E760", Offset = "0x679CF60", VA = "0x18679E760", Slot = "14")]
	public void MPPLGFJBDHC(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "15")]
	public void BBPOCOEOMDG(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x679CCC0", Offset = "0x679B4C0", VA = "0x18679CCC0", Slot = "17")]
	public void GBNLFAJCFEE(CNECBCEAJHF OGNAKNBDFIL, CNECBCEAJHF DINKJHKPJJC, Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x679CB80", Offset = "0x679B380", VA = "0x18679CB80")]
	public void GBNLFAJCFEE(PBDHGENIJKH CKKNFOBALJL, PBDHGENIJKH DINKJHKPJJC, Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x679B550", Offset = "0x6799D50", VA = "0x18679B550")]
	public void DAIICKMBGED(CNECBCEAJHF OGNAKNBDFIL, float OJLHODMLAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x679D5B0", Offset = "0x679BDB0", VA = "0x18679D5B0", Slot = "18")]
	public void INLMNKMKDIM(CNECBCEAJHF DBHJKHEHCKI, int LKALPFDMBDL, CNECBCEAJHF JDGGJJAANGA, int DILAKIHFOHM, Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x679E450", Offset = "0x679CC50", VA = "0x18679E450")]
	private float MKCOAIKENON(PBDHGENIJKH CKKNFOBALJL, PBDHGENIJKH GGJNHHDMGON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x679D420", Offset = "0x679BC20", VA = "0x18679D420")]
	public void INLMNKMKDIM(PBDHGENIJKH CKKNFOBALJL, PBDHGENIJKH GGJNHHDMGON, Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x679D550", Offset = "0x679BD50", VA = "0x18679D550")]
	public void INLMNKMKDIM(PBDHGENIJKH CKKNFOBALJL, PBDHGENIJKH GGJNHHDMGON, Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO, float OJLHODMLAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x679D170", Offset = "0x679B970", VA = "0x18679D170", Slot = "19")]
	public void HADIBIOENMC(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x679F090", Offset = "0x679D890", VA = "0x18679F090")]
	public bool PMJKONNMFFP(PBDHGENIJKH PHFFNGDOHAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x679E500", Offset = "0x679CD00", VA = "0x18679E500", Slot = "16")]
	public void MMEKMNEPLJI(CNECBCEAJHF OGNAKNBDFIL, HashSet<CNECBCEAJHF> FIOJAFONOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "20")]
	public MBKKCGPDFGI GOFONPNMFJF(bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "21")]
	public MBKKCGPDFGI FBPFCLDOJLA(HashSet<Guid> BNJKMOBMIIG, bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x679DE40", Offset = "0x679C640", VA = "0x18679DE40", Slot = "23")]
	public void LOKAJJKHPMF(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x679D7F0", Offset = "0x679BFF0", VA = "0x18679D7F0", Slot = "24")]
	public void JHAGIHFIPMB(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x679D400", Offset = "0x679BC00", VA = "0x18679D400", Slot = "25")]
	public void IEOPDLDPJBG(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x679B5E0", Offset = "0x6799DE0", VA = "0x18679B5E0")]
	private void DEJKKIHPAIG(PBDHGENIJKH CKKNFOBALJL, PBDHGENIJKH GGJNHHDMGON, Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO, float OJLHODMLAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x679AD20", Offset = "0x6799520", VA = "0x18679AD20")]
	private void BHDCNAECPLA(PBDHGENIJKH CKKNFOBALJL, PBDHGENIJKH OGAPKPCGEHM, Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x679D2E0", Offset = "0x679BAE0", VA = "0x18679D2E0")]
	private void HGDOKGFOGGH(PBDHGENIJKH CKKNFOBALJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x679CAF0", Offset = "0x679B2F0", VA = "0x18679CAF0")]
	[IteratorStateMachine(typeof(CHBPOLBFPNL))]
	public IEnumerable<CNECBCEAJHF> FBGDMJMDDKF(PBDHGENIJKH PHFFNGDOHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x679DF80", Offset = "0x679C780", VA = "0x18679DF80")]
	internal CNECBCEAJHF MGBHIPONJHC(PBDHGENIJKH PHFFNGDOHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x679DEB0", Offset = "0x679C6B0", VA = "0x18679DEB0")]
	internal PBDHGENIJKH LPBHPIOJCOG(CNECBCEAJHF OGNAKNBDFIL)
	{
		return default(PBDHGENIJKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x679BDA0", Offset = "0x679A5A0", VA = "0x18679BDA0")]
	private bool ECANIOKCIHG(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x679CA90", Offset = "0x679B290", VA = "0x18679CA90")]
	private bool FAKPLGJDKMG(AHHNIAPMJCH JDHFDNPAKDL, [Out] CNECBCEAJHF GGJNHHDMGON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x679E0C0", Offset = "0x679C8C0", VA = "0x18679E0C0")]
	private CNECBCEAJHF MGBHIPONJHC(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x679C770", Offset = "0x679AF70", VA = "0x18679C770")]
	private CNECBCEAJHF EMPOMPKLFCN(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x679B140", Offset = "0x6799940", VA = "0x18679B140")]
	private CNECBCEAJHF CHNDNGKMNMH(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x679DAE0", Offset = "0x679C2E0", VA = "0x18679DAE0")]
	private static Guid KIFEFJEEADL(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x679D700", Offset = "0x679BF00", VA = "0x18679D700")]
	private string JFGKGDDNLPD(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x679C900", Offset = "0x679B100", VA = "0x18679C900")]
	private void ENGCMNNBOPI(CNECBCEAJHF CKKNFOBALJL, CNECBCEAJHF OGAPKPCGEHM, RigidTransform JHDLHPHDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x679CFE0", Offset = "0x679B7E0", VA = "0x18679CFE0")]
	private void GNIMHPNPODB(CNECBCEAJHF OGAPKPCGEHM, CNECBCEAJHF CKKNFOBALJL, RigidTransform JHDLHPHDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x679D860", Offset = "0x679C060", VA = "0x18679D860")]
	private void JNHHDINBOLL(CNECBCEAJHF BHNOOIHFKDH, CNECBCEAJHF CKKNFOBALJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x679B3C0", Offset = "0x6799BC0", VA = "0x18679B3C0")]
	private void CNHFODNIMCK(CNECBCEAJHF CKKNFOBALJL, CNECBCEAJHF GGJNHHDMGON, RigidTransform JHDLHPHDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x679CED0", Offset = "0x679B6D0", VA = "0x18679CED0")]
	private void GDJMOILHIOG(PBDHGENIJKH PHFFNGDOHAF, CNECBCEAJHF OGNAKNBDFIL, PBDHGENIJKH ONKPHDMCMKL, PBDHGENIJKH CBEPEKFMPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x679C330", Offset = "0x679AB30", VA = "0x18679C330")]
	private void EGADNKMENNK(PBDHGENIJKH PHFFNGDOHAF, CNECBCEAJHF OGNAKNBDFIL, CNECBCEAJHF EDNNEPHDFLN, CNECBCEAJHF OFNOGOAIFKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OBABAEIJPEA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LKPLJKEDOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AANDDJDEEFL container;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LKPLJKEDOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x67A05B0", Offset = "0x679EDB0", VA = "0x1867A05B0")]
		internal HECIILDJFAF JEEOFOBKINE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x67A6190", Offset = "0x67A4990", VA = "0x1867A6190")]
	public static void PCMMPHHGAAG(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67A6140", Offset = "0x67A4940", VA = "0x1867A6140")]
	public static void JCHGOHAGCPB(AANDDJDEEFL KDCLBHAMNHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BJJFHGDJDEH : EBDKJGIIAJH, KPNOEIEFEHM
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx IBBECBMNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HECIILDJFAF IFJHPDBELOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DELFFCKABIM DMBCEPGEJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AOMLLLMFALD NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly OCBHACGPALA[] PIGJOCOAOLA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8474A0", Offset = "0x845CA0", VA = "0x1808474A0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(PBDHGENIJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CNECBCEAJHF KPIKINDGPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6795C50", Offset = "0x6794450", VA = "0x186795C50", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CNECBCEAJHF EPFAJMNKDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6794DF0", Offset = "0x67935F0", VA = "0x186794DF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 IHGHAFEEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6794D90", Offset = "0x6793590", VA = "0x186794D90", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion EKJELEDHCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6794EB0", Offset = "0x67936B0", VA = "0x186794EB0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DLLGBMFABGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6794A70", Offset = "0x6793270", VA = "0x186794A70", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<CNECBCEAJHF> PGAEKMPOGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x67946F0", Offset = "0x6792EF0", VA = "0x1867946F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool ILFEHIMMAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x991980", Offset = "0x990180", VA = "0x180991980", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x991AA0", Offset = "0x9902A0", VA = "0x180991AA0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6795E60", Offset = "0x6794660", VA = "0x186795E60", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject ADPKHONGLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2496390", Offset = "0x2494B90", VA = "0x182496390", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6795B80", Offset = "0x6794380", VA = "0x186795B80", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid NDOLPDIFIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6795CB0", Offset = "0x67944B0", VA = "0x186795CB0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LBJJNNFHOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6795D90", Offset = "0x6794590", VA = "0x186795D90", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OCEHPJACKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool PJBKPGJIAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6794130", Offset = "0x6792930", VA = "0x186794130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HNMNBPICDEO HAPABNJEFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6794180", Offset = "0x6792980", VA = "0x186794180", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67958D0", Offset = "0x67940D0", VA = "0x1867958D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HNMNBPICDEO KOMOKOEFIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6795930", Offset = "0x6794130", VA = "0x186795930", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67940D0", Offset = "0x67928D0", VA = "0x1867940D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HNMNBPICDEO NOOFODNMNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6795870", Offset = "0x6794070", VA = "0x186795870", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6794690", Offset = "0x6792E90", VA = "0x186794690", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EIBPKENKLBI AOJFMKGCAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6794FE0", Offset = "0x67937E0", VA = "0x186794FE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6794F40", Offset = "0x6793740", VA = "0x186794F40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6795A80", Offset = "0x6794280", VA = "0x186795A80")]
	public BJJFHGDJDEH(PBDHGENIJKH ACMFILFJLEL, RigidbodyEx IBBECBMNJMD, DELFFCKABIM DMBCEPGEJLO, OCBHACGPALA[] PIGJOCOAOLA, AOMLLLMFALD NALLEMLECHL, LLBJMBBMIPC IFJHPDBELOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6794F10", Offset = "0x6793710", VA = "0x186794F10", Slot = "19")]
	public void JGNDLDOBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "21")]
	public void GHAEDPLGBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6611DC0", Offset = "0x66105C0", VA = "0x186611DC0", Slot = "22")]
	public void DMCJJMEBFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6795990", Offset = "0x6794190", VA = "0x186795990", Slot = "20")]
	public void PPJONGAFJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6794B80", Offset = "0x6793380", VA = "0x186794B80", Slot = "25")]
	public void HOCNBEBGLMC(int HLIOKOODJMM, CNECBCEAJHF JDGGJJAANGA, int GCMCGBLLHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6794720", Offset = "0x6792F20", VA = "0x186794720", Slot = "26")]
	public void FANIAGNEACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6795280", Offset = "0x6793A80", VA = "0x186795280", Slot = "27")]
	public void NHKIMLJMNDP(int HLIOKOODJMM, CNECBCEAJHF DBHJKHEHCKI, int CMAJBPOKDAL, [Optional] Vector3? HOCCMCKAIFF, [Optional] Quaternion? GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x67947F0", Offset = "0x6792FF0", VA = "0x1867947F0", Slot = "28")]
	public void GKMPENKMPNO(CNECBCEAJHF DBHJKHEHCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6794280", Offset = "0x6792A80", VA = "0x186794280", Slot = "31")]
	public void ECNGILKJDAH(Vector3 KCPFEJMOFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6795560", Offset = "0x6793D60", VA = "0x186795560", Slot = "29")]
	public void NIINPKBEFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6795080", Offset = "0x6793880", VA = "0x186795080", Slot = "30")]
	public void MLOFOELFCCF(int JBDLDJOINOF, Vector3 DBPJNNMJCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67949A0", Offset = "0x67931A0", VA = "0x1867949A0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int HLIOKOODJMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6794870", Offset = "0x6793070", VA = "0x186794870", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int HLIOKOODJMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8AC650", Offset = "0x8AAE50", VA = "0x1808AC650", Slot = "42")]
	public Color GetConnectionSlotColor(int HLIOKOODJMM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x67941E0", Offset = "0x67929E0", VA = "0x1867941E0", Slot = "43")]
	public bool CanConnectTo(int HLIOKOODJMM, CNECBCEAJHF FLNNCEBDNNH, int AOACCDAJFGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "44")]
	public void ParentChanged(int HLIOKOODJMM, CNECBCEAJHF PAEKCLOMBBK, int BKBFLHFJIOD, Vector3 GMDHKKGABAB, Quaternion PAPCDHMBHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "45")]
	public void ChildAdded(int HLIOKOODJMM, CNECBCEAJHF EKPKHCOGNFC, int BNHKIMBMOOG, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "46")]
	public void ChildRemoved(int HLIOKOODJMM, CNECBCEAJHF CCNBMJPJPHM, int GDDIDJFMAKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "47")]
	public void ConnectionModified(int HLIOKOODJMM, CNECBCEAJHF JDGGJJAANGA, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x67959E0", Offset = "0x67941E0", VA = "0x1867959E0", Slot = "48")]
	public void RootChanged(CNECBCEAJHF BFDCNOLMDDM, CNECBCEAJHF LEJHKKFFEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6794E60", Offset = "0x6793660", VA = "0x186794E60", Slot = "23")]
	public void IPPDPKGNPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6794AE0", Offset = "0x67932E0", VA = "0x186794AE0", Slot = "24")]
	public void HCAJBEMEAHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6794B30", Offset = "0x6793330", VA = "0x186794B30")]
	private void HEILHPOOCHE(bool MCNBPAEAIBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[LBIGLGLDDJL(typeof(DOANDLGHKND), new string[] { })]
public class CCBHDHHFGFP : DOANDLGHKND, NNMHDEKAJII
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PLFDKBACBCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CCBHDHHFGFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IMJGNGJFNGC localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PLFDKBACBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x67A8E90", Offset = "0x67A7690", VA = "0x1867A8E90")]
		internal void MCHCFAADLFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[JBNAEHODHNL]
	private DDAOIPEKKCM FEIKIKEAPDP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object MNKGILBKIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6796040", Offset = "0x6794840", VA = "0x186796040", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6795FF0", Offset = "0x67947F0", VA = "0x186795FF0", Slot = "6")]
	public void InitReferences(CDDEGKNDPAN FOBEFOGAKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6795E80", Offset = "0x6794680", VA = "0x186795E80", Slot = "5")]
	public void HNFOPGCJFMA(IMJGNGJFNGC OPDFMPDAKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CCBHDHHFGFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[LBIGLGLDDJL(typeof(LLBJMBBMIPC), new string[] { "Ignore", "Mock" })]
public class NEADKONHMIJ : LLBJMBBMIPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PGNIFFJHMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF> CPMCDHLCINC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x67A5B80", Offset = "0x67A4380", VA = "0x1867A5B80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x67A5AD0", Offset = "0x67A42D0", VA = "0x1867A5AD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF> JBEFAGKKOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x67A58C0", Offset = "0x67A40C0", VA = "0x1867A58C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x67A5970", Offset = "0x67A4170", VA = "0x1867A5970", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF, CNECBCEAJHF> IGOLAAEDFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x67A5A20", Offset = "0x67A4220", VA = "0x1867A5A20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67A5810", Offset = "0x67A4010", VA = "0x1867A5810", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "12")]
	public void DIHNAABPOCM(GameObject DLBGNHFNDNP, HLNNEGADJJO ODOHDKGFPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "13")]
	public void EAHBMFPNBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "14")]
	public void MPPLGFJBDHC(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "15")]
	public void BBPOCOEOMDG(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "16")]
	public void MMEKMNEPLJI(CNECBCEAJHF OGNAKNBDFIL, HashSet<CNECBCEAJHF> FIOJAFONOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "17")]
	public void GBNLFAJCFEE(CNECBCEAJHF OGNAKNBDFIL, CNECBCEAJHF DINKJHKPJJC, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "18")]
	public void INLMNKMKDIM(CNECBCEAJHF OGNAKNBDFIL, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "19")]
	public void HADIBIOENMC(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "20")]
	public MBKKCGPDFGI GOFONPNMFJF(bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "21")]
	public MBKKCGPDFGI FBPFCLDOJLA(HashSet<Guid> BNJKMOBMIIG, bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "22")]
	public bool MNHDPDBLIKN(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "23")]
	public void LOKAJJKHPMF(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "24")]
	public void JHAGIHFIPMB(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "25")]
	public void IEOPDLDPJBG(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NEADKONHMIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CNECBCEAJHF : KPNOEIEFEHM, IEquatable<CNECBCEAJHF>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KPNOEIEFEHM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CNECBCEAJHF KPIKINDGPOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject ADPKHONGLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid NDOLPDIFIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int LBJJNNFHOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PBDHGENIJKH PLPBANMLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OCEHPJACKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int HLIOKOODJMM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int HLIOKOODJMM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int HLIOKOODJMM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int HLIOKOODJMM, CNECBCEAJHF FLNNCEBDNNH, int HHBGLCCPJBC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int HLIOKOODJMM, CNECBCEAJHF PAEKCLOMBBK, int BKBFLHFJIOD, Vector3 GMDHKKGABAB, Quaternion PAPCDHMBHLJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int HLIOKOODJMM, CNECBCEAJHF EKPKHCOGNFC, int BNHKIMBMOOG, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int HLIOKOODJMM, CNECBCEAJHF CCNBMJPJPHM, int GDDIDJFMAKC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int HLIOKOODJMM, CNECBCEAJHF JDGGJJAANGA, int LMNFANHPJCL, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(CNECBCEAJHF BFDCNOLMDDM, CNECBCEAJHF LEJHKKFFEHH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[FJKCFEHMPEG(KFOAJPDPBBE.OMRoom)]
public interface LLBJMBBMIPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PGNIFFJHMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CNECBCEAJHF, CNECBCEAJHF> CPMCDHLCINC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<CNECBCEAJHF, CNECBCEAJHF> JBEFAGKKOMN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<CNECBCEAJHF, CNECBCEAJHF, CNECBCEAJHF> IGOLAAEDFGN;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DIHNAABPOCM(GameObject DLBGNHFNDNP, HLNNEGADJJO ODOHDKGFPMH);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EAHBMFPNBAD();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MPPLGFJBDHC(CNECBCEAJHF OGNAKNBDFIL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BBPOCOEOMDG(CNECBCEAJHF OGNAKNBDFIL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MMEKMNEPLJI(CNECBCEAJHF OGNAKNBDFIL, HashSet<CNECBCEAJHF> FIOJAFONOGA);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GBNLFAJCFEE(CNECBCEAJHF OGNAKNBDFIL, CNECBCEAJHF DINKJHKPJJC, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void INLMNKMKDIM(CNECBCEAJHF OGNAKNBDFIL, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HADIBIOENMC(CNECBCEAJHF OGNAKNBDFIL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MBKKCGPDFGI GOFONPNMFJF(bool IMCCJPJLHJI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MBKKCGPDFGI FBPFCLDOJLA(HashSet<Guid> BNJKMOBMIIG, bool IMCCJPJLHJI);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MNHDPDBLIKN(AHHNIAPMJCH JDHFDNPAKDL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LOKAJJKHPMF(MBKKCGPDFGI NCNAHELFBKL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JHAGIHFIPMB(MBKKCGPDFGI NCNAHELFBKL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IEOPDLDPJBG(MBKKCGPDFGI NCNAHELFBKL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GOFGAJCKLFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PNENFEEBKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CNECBCEAJHF CHNDNGKMNMH(int PLFPHNIMIED);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CNECBCEAJHF EMPOMPKLFCN(Guid MPACGODHGMG);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PKIPLCJFJEK(CNECBCEAJHF OGNAKNBDFIL);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GFKOEKJOAMP();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCEEOIEGLEO(CNECBCEAJHF DMBCEPGEJLO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FJKCFEHMPEG(KFOAJPDPBBE.Application)]
public interface AOMLLLMFALD
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJBKPGJIAHJ(DELFFCKABIM DMBCEPGEJLO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EFONPEGAGKC(DELFFCKABIM DMBCEPGEJLO);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LOFDFJOKFOJ(DELFFCKABIM DMBCEPGEJLO);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PGJBHAPNGDM(DELFFCKABIM DMBCEPGEJLO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JPAEEDOKBOB(DELFFCKABIM DMBCEPGEJLO);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKEKBELMPBM(DELFFCKABIM DMBCEPGEJLO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void HNMNBPICDEO(CNECBCEAJHF DBHJKHEHCKI, int DBJDIBLIPMF, CNECBCEAJHF JDGGJJAANGA, int ODJCGJLIJJE, [Optional] Vector3? HOCCMCKAIFF, [Optional] Quaternion? GMDNLCFENCL);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void EIBPKENKLBI(CNECBCEAJHF BFDCNOLMDDM, CNECBCEAJHF LEJHKKFFEHH);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DELFFCKABIM : CNECBCEAJHF, KPNOEIEFEHM, IEquatable<CNECBCEAJHF>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EBDKJGIIAJH : KPNOEIEFEHM
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	CNECBCEAJHF EPFAJMNKDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<CNECBCEAJHF> PGAEKMPOGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 IHGHAFEEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion EKJELEDHCLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DLLGBMFABGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool ILFEHIMMAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event HNMNBPICDEO HAPABNJEFPM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event HNMNBPICDEO KOMOKOEFIEA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HNMNBPICDEO NOOFODNMNFD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event EIBPKENKLBI AOJFMKGCAJJ;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JGNDLDOBBPO();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PPJONGAFJGD();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GHAEDPLGBOL();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DMCJJMEBFMJ();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IPPDPKGNPLD();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HCAJBEMEAHG();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HOCNBEBGLMC(int HLIOKOODJMM, CNECBCEAJHF JDGGJJAANGA, int GCMCGBLLHAO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FANIAGNEACJ();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NHKIMLJMNDP(int HLIOKOODJMM, CNECBCEAJHF DBHJKHEHCKI, int CMAJBPOKDAL, [Optional] Vector3? HOCCMCKAIFF, [Optional] Quaternion? GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GKMPENKMPNO(CNECBCEAJHF DBHJKHEHCKI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NIINPKBEFNJ();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MLOFOELFCCF(int JBDLDJOINOF, Vector3 DBPJNNMJCKO);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ECNGILKJDAH(Vector3 KCPFEJMOFMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OCBHACGPALA
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 IIAOEAMCPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HLNNEGADJJO
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IGMLJMAACBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MAHBIIBDNME IBKHKHPCAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, HLNNEGADJJO
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
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8E2F40", Offset = "0x8E1740", VA = "0x1808E2F40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public MAHBIIBDNME LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6799BF0", Offset = "0x67983F0", VA = "0x186799BF0")]
		public static ConnectableConfigData ODCEDLIAACC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6799CB0", Offset = "0x67984B0", VA = "0x186799CB0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual NPBNAIILEDD, bool EMDFLFENGMK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DGGDEMGBIJH : IEquatable<DGGDEMGBIJH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public CNECBCEAJHF OGNAKNBDFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int MPGHECCBKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int LMNFANHPJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 HOCCMCKAIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion GMDNLCFENCL;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x679A2A0", Offset = "0x6798AA0", VA = "0x18679A2A0")]
	public DGGDEMGBIJH(CNECBCEAJHF OGNAKNBDFIL, int MPGHECCBKFA, int LMNFANHPJCL, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x679A200", Offset = "0x6798A00", VA = "0x18679A200")]
	public DGGDEMGBIJH(CNECBCEAJHF OGNAKNBDFIL, int MPGHECCBKFA, int LMNFANHPJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x679A180", Offset = "0x6798980", VA = "0x18679A180")]
	public DGGDEMGBIJH(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6799D00", Offset = "0x6798500", VA = "0x186799D00", Slot = "4")]
	public bool Equals(DGGDEMGBIJH OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6799DB0", Offset = "0x67985B0", VA = "0x186799DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class NENAGOFIJPI : FKBMFBOOPLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform MCHMJHAODPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private MAHBIIBDNME EABKDPBIGMG;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x62B9A70", Offset = "0x62B8270", VA = "0x1862B9A70", Slot = "4")]
	public void DIHNAABPOCM(Transform MCHMJHAODPL, MAHBIIBDNME EABKDPBIGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x67A5CA0", Offset = "0x67A44A0", VA = "0x1867A5CA0", Slot = "5")]
	public MAHBIIBDNME NLCAKPAFMLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x67A5C30", Offset = "0x67A4430", VA = "0x1867A5C30", Slot = "6")]
	public void AKKOBBBPJCA(MAHBIIBDNME DFPMJHFNAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NENAGOFIJPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CNEJCJDODHH : IDisposable, MINMOPCDOIF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ACHGEGACKNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CNECBCEAJHF oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CNECBCEAJHF newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ACHGEGACKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6793DB0", Offset = "0x67925B0", VA = "0x186793DB0")]
		internal bool JCBPNCDNJJA(KFBILOLPIOB node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly JAFLBJLALAB CAPMEAIGHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private GDMCNGLCPGM HKCDMFHCLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private AKGJINDLAOK NDMBDPLCDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool EMDFLFENGMK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly MMJHHDEPGMK CJOIIDHMBKD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KFBILOLPIOB BENFNHCGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6796FA0", Offset = "0x67957A0", VA = "0x186796FA0")]
	public bool GEELDKJBAHA([In] MHABDMMMLOA MLKNGAFFKGE, bool GIMPBMHHNGM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6797F40", Offset = "0x6796740", VA = "0x186797F40")]
	private bool JAELDKMPCME([In] MHABDMMMLOA MLKNGAFFKGE, bool GIMPBMHHNGM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6799A20", Offset = "0x6798220", VA = "0x186799A20")]
	public CNEJCJDODHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6797830", Offset = "0x6796030", VA = "0x186797830", Slot = "5")]
	public void DIHNAABPOCM(LLBJMBBMIPC KOFDOJONBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6798A00", Offset = "0x6797200", VA = "0x186798A00", Slot = "17")]
	public void MGOKMHKHJNJ(IMBHAMEFCKH GLJPAFELCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6797CE0", Offset = "0x67964E0", VA = "0x186797CE0", Slot = "12")]
	public void EPNBHFLNFJP(Func<CNECBCEAJHF, bool> EPLPLOFOLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6797BB0", Offset = "0x67963B0", VA = "0x186797BB0")]
	private void EPNBHFLNFJP(JAFLBJLALAB DDLCNKGIKEK, Func<CNECBCEAJHF, bool> EPLPLOFOLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x67989E0", Offset = "0x67971E0", VA = "0x1867989E0", Slot = "11")]
	public void LPGEILMBGPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6798740", Offset = "0x6796F40", VA = "0x186798740", Slot = "8")]
	public bool KCLEDEKMFLD(CNECBCEAJHF JCFEAPFHKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6797130", Offset = "0x6795930", VA = "0x186797130")]
	private bool DGPNDMJEADJ(CNECBCEAJHF FCIGJPDLJGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6796FB0", Offset = "0x67957B0", VA = "0x186796FB0")]
	private static bool CPNMPDHFCHD(CNECBCEAJHF FCIGJPDLJGB, JAFLBJLALAB MCCNFDFKHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6799570", Offset = "0x6797D70", VA = "0x186799570")]
	private void PKCIHMKBDOO(Transform ILBELMPPALG, JAFLBJLALAB AJOGODLHHLA, JAFLBJLALAB[] CCPCCLMBOGD, CNECBCEAJHF DPFHCDFJENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6799010", Offset = "0x6797810", VA = "0x186799010")]
	private DGGDEMGBIJH OIFEKJBPNOP(Transform GDFGFJKGOLP, DGGDEMGBIJH FEHPGBMIABP)
	{
		return default(DGGDEMGBIJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6796C30", Offset = "0x6795430", VA = "0x186796C30")]
	private static bool BGNKGFNIBMM(JAFLBJLALAB MCCNFDFKHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6797A30", Offset = "0x6796230", VA = "0x186797A30", Slot = "9")]
	public bool EIMMBDEOKEO(CNECBCEAJHF CHDDNFELDKE, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6798750", Offset = "0x6796F50", VA = "0x186798750")]
	private bool KEEIDOBGBNJ(CNECBCEAJHF CHDDNFELDKE, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6799290", Offset = "0x6797A90", VA = "0x186799290")]
	private static void PFAGEFFCEHI(CNECBCEAJHF CHDDNFELDKE, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL, JAFLBJLALAB IJLGJJGJDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6797A90", Offset = "0x6796290", VA = "0x186797A90")]
	private void ENGCMNNBOPI(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6798570", Offset = "0x6796D70", VA = "0x186798570")]
	private void JCOIMJECKKI(JAFLBJLALAB DDLCNKGIKEK, CNECBCEAJHF EDNNEPHDFLN, CNECBCEAJHF OFNOGOAIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6798500", Offset = "0x6796D00", VA = "0x186798500")]
	private void JCOIMJECKKI(CNECBCEAJHF OGNAKNBDFIL, CNECBCEAJHF EDNNEPHDFLN, CNECBCEAJHF OFNOGOAIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67978C0", Offset = "0x67960C0", VA = "0x1867978C0")]
	private void EGADNKMENNK(CNECBCEAJHF OGNAKNBDFIL, CNECBCEAJHF EDNNEPHDFLN, CNECBCEAJHF OFNOGOAIFKH, bool BKIPGDMDFMJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6797930", Offset = "0x6796130", VA = "0x186797930")]
	private void EGADNKMENNK(JAFLBJLALAB AHKBBGKKCNK, CNECBCEAJHF DPFHCDFJENP, CNECBCEAJHF LEJHKKFFEHH, bool BKIPGDMDFMJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6797DC0", Offset = "0x67965C0", VA = "0x186797DC0")]
	private void GNIMHPNPODB(CNECBCEAJHF CKKNFOBALJL, int CMAJBPOKDAL, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x67985E0", Offset = "0x6796DE0", VA = "0x1867985E0")]
	private void JNHHDINBOLL(KFBILOLPIOB GGJNHHDMGON, KFBILOLPIOB BINPDFJAIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6799410", Offset = "0x6797C10", VA = "0x186799410", Slot = "18")]
	public CNECBCEAJHF PIPGBFAECFP(CNECBCEAJHF OGNAKNBDFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6798A30", Offset = "0x6797230", VA = "0x186798A30", Slot = "13")]
	public void MMEKMNEPLJI(CNECBCEAJHF OGNAKNBDFIL, HashSet<CNECBCEAJHF> KNEGOBIHHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6798DD0", Offset = "0x67975D0", VA = "0x186798DD0", Slot = "14")]
	public List<CNECBCEAJHF> ODBGCJMBAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6797CF0", Offset = "0x67964F0", VA = "0x186797CF0")]
	protected KFBILOLPIOB GCINFAOJBIG(KFBILOLPIOB DDLCNKGIKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6796DF0", Offset = "0x67955F0", VA = "0x186796DF0")]
	protected JAFLBJLALAB[] BNFPIHEFIBD(JAFLBJLALAB MCCNFDFKHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6796E90", Offset = "0x6795690", VA = "0x186796E90")]
	protected bool COMKPAIINHK(CNECBCEAJHF OGNAKNBDFIL, [Out] JAFLBJLALAB DDLCNKGIKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6799160", Offset = "0x6797960", VA = "0x186799160", Slot = "15")]
	public bool OMMHIDDOFBF(CNECBCEAJHF OGNAKNBDFIL, [Out] DGGDEMGBIJH NOJEGEDJIHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67989A0", Offset = "0x67971A0", VA = "0x1867989A0")]
	protected JAFLBJLALAB KMLCGLAHECH(DGGDEMGBIJH IMCBAKJAOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6797EE0", Offset = "0x67966E0", VA = "0x186797EE0", Slot = "10")]
	public bool IOGAKFAKFHA(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6796680", Offset = "0x6794E80", VA = "0x186796680")]
	private bool APOIIOGFOJK(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6797060", Offset = "0x6795860", VA = "0x186797060")]
	private static bool DFIIOJCLGJN(JAFLBJLALAB EABIIENALIL, DGGDEMGBIJH LDCFFMFNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6796FA0", Offset = "0x67957A0", VA = "0x186796FA0", Slot = "7")]
	private bool CPEEKAJAONJ([In] MHABDMMMLOA MLKNGAFFKGE, bool GIMPBMHHNGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class OPFEPLLMPBN : LLBJMBBMIPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly AANDDJDEEFL KDCLBHAMNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly AKGJINDLAOK NDMBDPLCDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly NPFENLHLMIH FKGDOPBAEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly LMLCJCIEONK DPPNEDIKMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly MINMOPCDOIF NCNAHELFBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal OPKFAOOMOKK NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal FBMFFDNCHGL NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal GDMCNGLCPGM DIKBFHEAKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool EMDFLFENGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool BJGKNFADMJG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DNMBMOBJOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8E2380", Offset = "0x8E0B80", VA = "0x1808E2380")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x18CEBD0", Offset = "0x18CD3D0", VA = "0x1818CEBD0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8E2360", Offset = "0x8E0B60", VA = "0x1808E2360", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x18CEBC0", Offset = "0x18CD3C0", VA = "0x1818CEBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PGNIFFJHMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF> CPMCDHLCINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x67A78F0", Offset = "0x67A60F0", VA = "0x1867A78F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x67A7540", Offset = "0x67A5D40", VA = "0x1867A7540", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF> JBEFAGKKOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x67A6EC0", Offset = "0x67A56C0", VA = "0x1867A6EC0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x67A6F20", Offset = "0x67A5720", VA = "0x1867A6F20", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CNECBCEAJHF, CNECBCEAJHF, CNECBCEAJHF> IGOLAAEDFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x67A71B0", Offset = "0x67A59B0", VA = "0x1867A71B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x67A6650", Offset = "0x67A4E50", VA = "0x1867A6650", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x67A7E40", Offset = "0x67A6640", VA = "0x1867A7E40")]
	public OPFEPLLMPBN(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x67A6800", Offset = "0x67A5000", VA = "0x1867A6800", Slot = "12")]
	public void DIHNAABPOCM(GameObject DLBGNHFNDNP, HLNNEGADJJO ODOHDKGFPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x67A6DD0", Offset = "0x67A55D0", VA = "0x1867A6DD0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x67A6E70", Offset = "0x67A5670", VA = "0x1867A6E70", Slot = "13")]
	public void EAHBMFPNBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x67A7B30", Offset = "0x67A6330", VA = "0x1867A7B30", Slot = "14")]
	public void MPPLGFJBDHC(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x67A65F0", Offset = "0x67A4DF0", VA = "0x1867A65F0", Slot = "15")]
	public void BBPOCOEOMDG(CNECBCEAJHF OGNAKNBDFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x67A7AE0", Offset = "0x67A62E0", VA = "0x1867A7AE0", Slot = "22")]
	public bool MNHDPDBLIKN(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x67A7780", Offset = "0x67A5F80", VA = "0x1867A7780")]
	internal bool JAELDKMPCME([In] MHABDMMMLOA MLKNGAFFKGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x67A6560", Offset = "0x67A4D60", VA = "0x1867A6560")]
	internal bool APOIIOGFOJK([In] MHABDMMMLOA MLKNGAFFKGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x67A75A0", Offset = "0x67A5DA0", VA = "0x1867A75A0")]
	internal bool IBPPDEDKCNB([In] MHABDMMMLOA MLKNGAFFKGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x67A66B0", Offset = "0x67A4EB0", VA = "0x1867A66B0")]
	internal bool DFOIOJBCKAM([In] MHABDMMMLOA MLKNGAFFKGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x67A7B50", Offset = "0x67A6350", VA = "0x1867A7B50")]
	internal void PDLJNEHIDHO(CNECBCEAJHF OGNAKNBDFIL, int FDBDJJDIKOE, bool GIMPBMHHNGM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x67A65F0", Offset = "0x67A4DF0", VA = "0x1867A65F0")]
	internal bool DFADNOEFBGF(CNECBCEAJHF DEFBNMAALBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x67A7210", Offset = "0x67A5A10", VA = "0x1867A7210")]
	internal bool GHGOBNKPFEI(CNECBCEAJHF CHDDNFELDKE, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x67A79E0", Offset = "0x67A61E0", VA = "0x1867A79E0", Slot = "16")]
	public void MMEKMNEPLJI(CNECBCEAJHF OGNAKNBDFIL, HashSet<CNECBCEAJHF> FIOJAFONOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x67A6FA0", Offset = "0x67A57A0", VA = "0x1867A6FA0", Slot = "17")]
	public void GBNLFAJCFEE(CNECBCEAJHF CHDDNFELDKE, CNECBCEAJHF DINKJHKPJJC, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x67A7640", Offset = "0x67A5E40", VA = "0x1867A7640", Slot = "18")]
	public void INLMNKMKDIM(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x67A7370", Offset = "0x67A5B70", VA = "0x1867A7370", Slot = "19")]
	public void HADIBIOENMC(CNECBCEAJHF LMONFGCJEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x67A7D30", Offset = "0x67A6530", VA = "0x1867A7D30")]
	public void PHEPLHCAMNH([Optional] BBLEPGEDBMJ BNKBNFMGLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67A7950", Offset = "0x67A6150", VA = "0x1867A7950", Slot = "23")]
	public void LOKAJJKHPMF(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x67A7350", Offset = "0x67A5B50", VA = "0x1867A7350", Slot = "20")]
	public MBKKCGPDFGI GOFONPNMFJF(bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x67A6F80", Offset = "0x67A5780", VA = "0x1867A6F80", Slot = "21")]
	public MBKKCGPDFGI FBPFCLDOJLA(HashSet<Guid> BNJKMOBMIIG, bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x67A7600", Offset = "0x67A5E00", VA = "0x1867A7600", Slot = "25")]
	public void IEOPDLDPJBG(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x67A7840", Offset = "0x67A6040", VA = "0x1867A7840", Slot = "24")]
	public void JHAGIHFIPMB(MBKKCGPDFGI NCNAHELFBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class AKGJINDLAOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly FIPPODCNHJE<CNECBCEAJHF, CNECBCEAJHF> CPMCDHLCINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FIPPODCNHJE<CNECBCEAJHF, CNECBCEAJHF> JBEFAGKKOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly NIICELDHKHK<CNECBCEAJHF, CNECBCEAJHF, CNECBCEAJHF> IGOLAAEDFGN;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6793FB0", Offset = "0x67927B0", VA = "0x186793FB0")]
	public AKGJINDLAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	public void DIHNAABPOCM(OPFEPLLMPBN KOFDOJONBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6793EF0", Offset = "0x67926F0", VA = "0x186793EF0")]
	public void NBFOJCNECCG(CNECBCEAJHF GGJNHHDMGON, CNECBCEAJHF CKKNFOBALJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6793F50", Offset = "0x6792750", VA = "0x186793F50")]
	public void PEFGIHKNMKG(CNECBCEAJHF GGJNHHDMGON, CNECBCEAJHF CKKNFOBALJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6793E70", Offset = "0x6792670", VA = "0x186793E70")]
	public void AOBHOLNIBAO(CNECBCEAJHF BHNOOIHFKDH, CNECBCEAJHF OGAPKPCGEHM, CNECBCEAJHF CKKNFOBALJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NPFENLHLMIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private OPFEPLLMPBN KOFDOJONBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private FBMFFDNCHGL NEMGCIKNBKO;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NPFENLHLMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x67A5F70", Offset = "0x67A4770", VA = "0x1867A5F70")]
	public void DIHNAABPOCM(OPFEPLLMPBN KOFDOJONBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x67A60A0", Offset = "0x67A48A0", VA = "0x1867A60A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x67A6120", Offset = "0x67A4920", VA = "0x1867A6120")]
	private void NGGMGCDGAOK(BBLEPGEDBMJ PENGDIMNCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67A60B0", Offset = "0x67A48B0", VA = "0x1867A60B0")]
	private void HHFOJNKFMKP(BBLEPGEDBMJ FPDBDFEDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67A5D70", Offset = "0x67A4570", VA = "0x1867A5D70")]
	public void BEDMLIPHMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67A5E70", Offset = "0x67A4670", VA = "0x1867A5E70")]
	public void BGAHDOBBMGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HHAEMEGJCCP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FHFBPNGLBBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AANDDJDEEFL container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FHFBPNGLBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x679AC40", Offset = "0x6799440", VA = "0x18679AC40")]
		internal OPFEPLLMPBN JEEOFOBKINE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x679F560", Offset = "0x679DD60", VA = "0x18679F560")]
	public static void PCMMPHHGAAG(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x679F4E0", Offset = "0x679DCE0", VA = "0x18679F4E0")]
	public static void JCHGOHAGCPB(AANDDJDEEFL KDCLBHAMNHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class PDABGOIIIKL : IDisposable, GDMCNGLCPGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, MAHBIIBDNME> LNNMPBBMIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IMBHAMEFCKH IBPOGHJCNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private FKBMFBOOPLA LFPDEFCHPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private MINMOPCDOIF NCNAHELFBKL;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x67A8DB0", Offset = "0x67A75B0", VA = "0x1867A8DB0")]
	public PDABGOIIIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x67A8540", Offset = "0x67A6D40", VA = "0x1867A8540", Slot = "7")]
	public void DIHNAABPOCM(MINMOPCDOIF NCNAHELFBKL, FKBMFBOOPLA LFPDEFCHPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x67A8300", Offset = "0x67A6B00", VA = "0x1867A8300", Slot = "5")]
	public void DFGGOGPCCOG(KFBILOLPIOB HEHNIGBBHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x67A8580", Offset = "0x67A6D80", VA = "0x1867A8580", Slot = "9")]
	public void DIIBGMEOEOE(KFBILOLPIOB ICHGFJGOOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x67A86F0", Offset = "0x67A6EF0", VA = "0x1867A86F0", Slot = "8")]
	public void HGKBFPHKIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x67A88B0", Offset = "0x67A70B0", VA = "0x1867A88B0", Slot = "10")]
	public void NDFNGLGJHOK(KFBILOLPIOB FMDOBOEPGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x67A8230", Offset = "0x67A6A30", VA = "0x1867A8230", Slot = "11")]
	public void BAIMLLEFDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67A8C00", Offset = "0x67A7400", VA = "0x1867A8C00")]
	private bool PNKIFAJMMIC(KFBILOLPIOB FEGGJAIMAGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class LMLCJCIEONK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct EHJDMKNCAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly JAFLBJLALAB MIFFIKNPIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> BNJKMOBMIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly AHHNIAPMJCH KMBJGFLHOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly AHHNIAPMJCH LOAABNBLGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool IMCCJPJLHJI;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool GLNHNNGHIIH
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x679A4C0", Offset = "0x6798CC0", VA = "0x18679A4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x679ABD0", Offset = "0x67993D0", VA = "0x18679ABD0")]
		public EHJDMKNCAJO(JAFLBJLALAB MIFFIKNPIHJ, HashSet<Guid> BNJKMOBMIIG, bool IMCCJPJLHJI, [Optional] AHHNIAPMJCH KMBJGFLHOMB, [Optional] AHHNIAPMJCH LOAABNBLGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x679A6A0", Offset = "0x6798EA0", VA = "0x18679A6A0")]
		public AHHNIAPMJCH HNAIEAEAFJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x679A5E0", Offset = "0x6798DE0", VA = "0x18679A5E0")]
		private AHHNIAPMJCH FFOPDDJDABK([Out] AHHNIAPMJCH OHPIONCLCNI, [Out] AHHNIAPMJCH PPLJFANAFDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x679A840", Offset = "0x6799040", VA = "0x18679A840")]
		private AHHNIAPMJCH JNACIGDCPMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x679AA60", Offset = "0x6799260", VA = "0x18679AA60")]
		private void PBMOCPJPMOE(AHHNIAPMJCH GMHHFGCHONB, AHHNIAPMJCH HAHHEEOJNGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x679A300", Offset = "0x6798B00", VA = "0x18679A300")]
		private void AJEOEDAOBOG(AHHNIAPMJCH OHPIONCLCNI, AHHNIAPMJCH PPLJFANAFDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private OPFEPLLMPBN KOFDOJONBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private MINMOPCDOIF NCNAHELFBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private GDMCNGLCPGM HKCDMFHCLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private FBMFFDNCHGL NEMGCIKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool BNNMGEMOKNF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool MOJFNAJFFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x67A0A30", Offset = "0x679F230", VA = "0x1867A0A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DNMBMOBJOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x67A23D0", Offset = "0x67A0BD0", VA = "0x1867A23D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x67A2980", Offset = "0x67A1180", VA = "0x1867A2980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x67A0A80", Offset = "0x679F280", VA = "0x1867A0A80")]
	public void DIHNAABPOCM(OPFEPLLMPBN KOFDOJONBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x67A1CB0", Offset = "0x67A04B0", VA = "0x1867A1CB0")]
	public MBKKCGPDFGI GOFONPNMFJF(bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x67A1160", Offset = "0x679F960", VA = "0x1867A1160")]
	public MBKKCGPDFGI FBPFCLDOJLA(HashSet<Guid> BNJKMOBMIIG, bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x67A2B90", Offset = "0x67A1390", VA = "0x1867A2B90")]
	public void LOKAJJKHPMF(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x67A28C0", Offset = "0x67A10C0", VA = "0x1867A28C0")]
	public void JHAGIHFIPMB(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x67A33A0", Offset = "0x67A1BA0", VA = "0x1867A33A0")]
	public void OAOLPOJBLGE(MBKKCGPDFGI NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x67A29A0", Offset = "0x67A11A0", VA = "0x1867A29A0")]
	private void LJHKINAJHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x67A1A80", Offset = "0x67A0280", VA = "0x1867A1A80")]
	private AHHNIAPMJCH GFCEEPGFPKJ(JAFLBJLALAB DDLCNKGIKEK, bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x67A0660", Offset = "0x679EE60", VA = "0x1867A0660")]
	private static void AFMBFIGEKEL(JAFLBJLALAB DDLCNKGIKEK, bool IMCCJPJLHJI, AHHNIAPMJCH JDHFDNPAKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x67A33D0", Offset = "0x67A1BD0", VA = "0x1867A33D0")]
	private void PHAENOGPMOJ(JAFLBJLALAB DDLCNKGIKEK, bool IMCCJPJLHJI, AHHNIAPMJCH JDHFDNPAKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x67A2230", Offset = "0x67A0A30", VA = "0x1867A2230")]
	private AHHNIAPMJCH GPNONBBALAA(JAFLBJLALAB MIFFIKNPIHJ, HashSet<Guid> BNJKMOBMIIG, bool IMCCJPJLHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x67A17F0", Offset = "0x679FFF0", VA = "0x1867A17F0")]
	private bool FOBJLPNFDIP(MBKKCGPDFGI JMBGGMHEIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x67A0AF0", Offset = "0x679F2F0", VA = "0x1867A0AF0")]
	private bool ECANIOKCIHG(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x67A2960", Offset = "0x67A1160", VA = "0x1867A2960")]
	private bool JLOMFPKGPPH(MBKKCGPDFGI NCNAHELFBKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x67A22C0", Offset = "0x67A0AC0", VA = "0x1867A22C0")]
	private static bool HKCEGBHBFFB(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x67A3110", Offset = "0x67A1910", VA = "0x1867A3110")]
	public static bool MNHDPDBLIKN(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x67A2C20", Offset = "0x67A1420", VA = "0x1867A2C20")]
	private CNECBCEAJHF MGBHIPONJHC(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x67A08B0", Offset = "0x679F0B0", VA = "0x1867A08B0")]
	private CNECBCEAJHF CHNDNGKMNMH(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x67A2F80", Offset = "0x67A1780", VA = "0x1867A2F80")]
	private CNECBCEAJHF MMBLDDCBOJA(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x679DAE0", Offset = "0x679C2E0", VA = "0x18679DAE0")]
	private static Guid KIFEFJEEADL(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x67A27D0", Offset = "0x67A0FD0", VA = "0x1867A27D0")]
	private string JFGKGDDNLPD(AHHNIAPMJCH JDHFDNPAKDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x67A23F0", Offset = "0x67A0BF0", VA = "0x1867A23F0")]
	private bool INOEFMGADPE(JAFLBJLALAB DDLCNKGIKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x67A2570", Offset = "0x67A0D70", VA = "0x1867A2570")]
	private static void IPFLAACGEPA(JAFLBJLALAB MIFFIKNPIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public LMLCJCIEONK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct MHABDMMMLOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public CNECBCEAJHF CKKNFOBALJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public CNECBCEAJHF GGJNHHDMGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int CMAJBPOKDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int GCMCGBLLHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 HOCCMCKAIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion GMDNLCFENCL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DGGDEMGBIJH BJKBBFGCNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x67A56D0", Offset = "0x67A3ED0", VA = "0x1867A56D0")]
		get
		{
			return default(DGGDEMGBIJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DGGDEMGBIJH PKCMAINFCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x67A5770", Offset = "0x67A3F70", VA = "0x1867A5770")]
		get
		{
			return default(DGGDEMGBIJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67A57A0", Offset = "0x67A3FA0", VA = "0x1867A57A0")]
	public MHABDMMMLOA(CNECBCEAJHF CKKNFOBALJL, CNECBCEAJHF GGJNHHDMGON, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MINMOPCDOIF
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KFBILOLPIOB BENFNHCGCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIHNAABPOCM(LLBJMBBMIPC KOFDOJONBID);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEELDKJBAHA([In] MHABDMMMLOA MLKNGAFFKGE, bool GIMPBMHHNGM = true);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCLEDEKMFLD(CNECBCEAJHF JCFEAPFHKHG);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EIMMBDEOKEO(CNECBCEAJHF CHDDNFELDKE, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IOGAKFAKFHA(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LPGEILMBGPJ();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EPNBHFLNFJP(Func<CNECBCEAJHF, bool> EPLPLOFOLFF);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMEKMNEPLJI(CNECBCEAJHF OGNAKNBDFIL, HashSet<CNECBCEAJHF> KNEGOBIHHJO);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<CNECBCEAJHF> ODBGCJMBAOP();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OMMHIDDOFBF(CNECBCEAJHF OGNAKNBDFIL, [Out] DGGDEMGBIJH NOJEGEDJIHF);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MGOKMHKHJNJ(IMBHAMEFCKH GLJPAFELCNE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool IMBHAMEFCKH(KFBILOLPIOB DDLCNKGIKEK);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KFBILOLPIOB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CNECBCEAJHF EJHEEKHKOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KFBILOLPIOB GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DGGDEMGBIJH FCKAMFBBKID
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool AKJMJENJPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MAHBIIBDNME : JBOHHDKANFI.KMEKGKKHANP
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMDILLFIIGI(CNECBCEAJHF JDGGJJAANGA, DGGDEMGBIJH CKKNFOBALJL);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMGCIDAPJIE(CNECBCEAJHF JDGGJJAANGA, DGGDEMGBIJH CKKNFOBALJL);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOGFFNPHIIO(CNECBCEAJHF JDGGJJAANGA, DGGDEMGBIJH CKKNFOBALJL);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFMNBOKKFPB(CNECBCEAJHF JDGGJJAANGA, DGGDEMGBIJH CKKNFOBALJL);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MAHBIIBDNME Instantiate(Transform MCHMJHAODPL);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGFGBHFCFEG();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FKBMFBOOPLA
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIHNAABPOCM(Transform MCHMJHAODPL, MAHBIIBDNME EABKDPBIGMG);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MAHBIIBDNME NLCAKPAFMLC();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKKOBBBPJCA(MAHBIIBDNME DFPMJHFNAFG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface OPKFAOOMOKK : GOFGAJCKLFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEHHFLEFBLC(Guid IOLHOGJMOAK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GDMCNGLCPGM
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFGGOGPCCOG(KFBILOLPIOB HEHNIGBBHKB);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DIHNAABPOCM(MINMOPCDOIF NCNAHELFBKL, FKBMFBOOPLA AFJKIPPKCII);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HGKBFPHKIGO();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIIBGMEOEOE(KFBILOLPIOB ICHGFJGOOAC);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDFNGLGJHOK(KFBILOLPIOB FMDOBOEPGNL);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BAIMLLEFDCM();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class JAFLBJLALAB : KFBILOLPIOB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HJCJANAIIMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public DGGDEMGBIJH nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public JAFLBJLALAB foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HJCJANAIIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x679F760", Offset = "0x679DF60", VA = "0x18679F760")]
		internal bool KLAMGKFDAKI(KFBILOLPIOB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private DGGDEMGBIJH NOJEGEDJIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<JAFLBJLALAB> EHFDECEFDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private JAFLBJLALAB OHPEOBEPIPF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DGGDEMGBIJH FCKAMFBBKID
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x37C73C0", Offset = "0x37C5BC0", VA = "0x1837C73C0", Slot = "6")]
		get
		{
			return default(DGGDEMGBIJH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x67A04D0", Offset = "0x679ECD0", VA = "0x1867A04D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private JAFLBJLALAB GGJNHHDMGON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x679FA50", Offset = "0x679E250", VA = "0x18679FA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KFBILOLPIOB GFHKLHCNBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CNECBCEAJHF EJHEEKHKOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AKJMJENJPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x67A04C0", Offset = "0x679ECC0", VA = "0x1867A04C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OFBJGBBDHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x67A0180", Offset = "0x679E980", VA = "0x1867A0180", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected JAFLBJLALAB AHKBBGKKCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x67A0060", Offset = "0x679E860", VA = "0x1867A0060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x67A0500", Offset = "0x679ED00", VA = "0x1867A0500")]
	public JAFLBJLALAB(DGGDEMGBIJH FAHNMHMLBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x679FB30", Offset = "0x679E330", VA = "0x18679FB30")]
	public JAFLBJLALAB FMNJLOIFMNG(DGGDEMGBIJH MGEDDEHHNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x67A01D0", Offset = "0x679E9D0", VA = "0x1867A01D0")]
	public JAFLBJLALAB MAKKEJOHNLK(DGGDEMGBIJH BBBOLNPFBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x679FC80", Offset = "0x679E480", VA = "0x18679FC80")]
	public JAFLBJLALAB GALPDKBCKMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x679FF10", Offset = "0x679E710", VA = "0x18679FF10")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x679FE60", Offset = "0x679E660", VA = "0x18679FE60")]
	public JAFLBJLALAB GGHDDMBDJDG(DGGDEMGBIJH OGAPKPCGEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x67A0350", Offset = "0x679EB50", VA = "0x1867A0350")]
	private static void MGOKMHKHJNJ(JAFLBJLALAB HNHIDDLOEDA, IMBHAMEFCKH HPMMBJCHINM, bool BBGDAEHCHDJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x67A04B0", Offset = "0x679ECB0", VA = "0x1867A04B0", Slot = "9")]
	public void MGOKMHKHJNJ(IMBHAMEFCKH GLJPAFELCNE, bool BKIPGDMDFMJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x67A0080", Offset = "0x679E880", VA = "0x1867A0080")]
	public static JAFLBJLALAB KMLCGLAHECH(JAFLBJLALAB HNHIDDLOEDA, DGGDEMGBIJH GKIKPKJPPHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface FBMFFDNCHGL
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool MOJFNAJFFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PNENFEEBKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<BBLEPGEDBMJ> NGGMGCDGAOK;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<BBLEPGEDBMJ> HHFOJNKFMKP;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(OPFEPLLMPBN KOFDOJONBID);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(CNECBCEAJHF CHDDNFELDKE, CNECBCEAJHF DINKJHKPJJC, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(MBKKCGPDFGI GBHCHDNBKKK, [Optional] BBLEPGEDBMJ BNKBNFMGLKP);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, FBMFFDNCHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private OPFEPLLMPBN KOFDOJONBID;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool MOJFNAJFFGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x67A5350", Offset = "0x67A3B50", VA = "0x1867A5350", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool PNENFEEBKGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x67A53B0", Offset = "0x67A3BB0", VA = "0x1867A53B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<BBLEPGEDBMJ> NGGMGCDGAOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x67A52B0", Offset = "0x67A3AB0", VA = "0x1867A52B0", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x67A5490", Offset = "0x67A3C90", VA = "0x1867A5490", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<BBLEPGEDBMJ> HHFOJNKFMKP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x67A5210", Offset = "0x67A3A10", VA = "0x1867A5210", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x67A53F0", Offset = "0x67A3BF0", VA = "0x1867A53F0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x847500", Offset = "0x845D00", VA = "0x180847500", Slot = "19")]
		public void SetManager(OPFEPLLMPBN KOFDOJONBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x67A51E0", Offset = "0x67A39E0", VA = "0x1867A51E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x67A3F60", Offset = "0x67A2760", VA = "0x1867A3F60", Slot = "23")]
		public void RequestMasterConnectNodes(CNECBCEAJHF DBHJKHEHCKI, int CMAJBPOKDAL, CNECBCEAJHF JDGGJJAANGA, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x67A4090", Offset = "0x67A2890", VA = "0x1867A4090", Slot = "24")]
		public void RequestMasterDisconnectNode(CNECBCEAJHF JCFEAPFHKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x67A4150", Offset = "0x67A2950", VA = "0x1867A4150", Slot = "20")]
		public void RequestMasterModifyNode(CNECBCEAJHF CHDDNFELDKE, CNECBCEAJHF DINKJHKPJJC, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x67A4280", Offset = "0x67A2A80", VA = "0x1867A4280", Slot = "21")]
		public void RequestMasterReparentNodes(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x67A43B0", Offset = "0x67A2BB0", VA = "0x1867A43B0", Slot = "25")]
		public void RequestMasterReparentToRoot(CNECBCEAJHF LMONFGCJEDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x67A3E30", Offset = "0x67A2630", VA = "0x1867A3E30", Slot = "22")]
		public void RequestDeserializeConnectableGraph(MBKKCGPDFGI GBHCHDNBKKK, [Optional] BBLEPGEDBMJ BNKBNFMGLKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x67A4790", Offset = "0x67A2F90", VA = "0x1867A4790")]
		[IPACKMCBMLI]
		private void RpcMasterConnectNodes(CNECBCEAJHF DBHJKHEHCKI, int CMAJBPOKDAL, CNECBCEAJHF JDGGJJAANGA, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x67A4A50", Offset = "0x67A3250", VA = "0x1867A4A50")]
		[IPACKMCBMLI]
		private void RpcMasterDisconnectNode(CNECBCEAJHF JCFEAPFHKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x67A4D90", Offset = "0x67A3590", VA = "0x1867A4D90")]
		[IPACKMCBMLI]
		private void RpcMasterReparentNodes(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x67A4B90", Offset = "0x67A3390", VA = "0x1867A4B90")]
		[IPACKMCBMLI]
		private void RpcMasterModifyNode(CNECBCEAJHF CHDDNFELDKE, CNECBCEAJHF DINKJHKPJJC, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x67A4580", Offset = "0x67A2D80", VA = "0x1867A4580")]
		[IPACKMCBMLI]
		private void RpcConnectNodes(CNECBCEAJHF DBHJKHEHCKI, int CMAJBPOKDAL, CNECBCEAJHF JDGGJJAANGA, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL, MDADPIIMGIC HHINDHPOIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x67A4700", Offset = "0x67A2F00", VA = "0x1867A4700")]
		[IPACKMCBMLI]
		private void RpcDisconnectNode(CNECBCEAJHF JCFEAPFHKHG, MDADPIIMGIC HHINDHPOIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x67A50E0", Offset = "0x67A38E0", VA = "0x1867A50E0")]
		[IPACKMCBMLI]
		private void RpcReparentNodes(CNECBCEAJHF LMONFGCJEDG, int DKLDIFKKEFD, CNECBCEAJHF OGAPKPCGEHM, int BKBFLHFJIOD, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL, MDADPIIMGIC HHINDHPOIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x67A5020", Offset = "0x67A3820", VA = "0x1867A5020")]
		[IPACKMCBMLI]
		private void RpcModifyNode(CNECBCEAJHF CHDDNFELDKE, int CMAJBPOKDAL, int GCMCGBLLHAO, Vector3 HOCCMCKAIFF, Quaternion GMDNLCFENCL, MDADPIIMGIC HHINDHPOIPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x67A46C0", Offset = "0x67A2EC0", VA = "0x1867A46C0")]
		[IPACKMCBMLI]
		private void RpcDeserializeConnectableGraph(MBKKCGPDFGI NCNAHELFBKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x85F490", Offset = "0x85DC90", VA = "0x18085F490")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, MAHBIIBDNME, JBOHHDKANFI.KMEKGKKHANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x67A38C0", Offset = "0x67A20C0", VA = "0x1867A38C0", Slot = "4")]
		private void ALJOCDMJEBK(CNECBCEAJHF JDGGJJAANGA, DGGDEMGBIJH CKKNFOBALJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x67A3A40", Offset = "0x67A2240", VA = "0x1867A3A40", Slot = "5")]
		private void IKGDHABDFOG(CNECBCEAJHF JDGGJJAANGA, DGGDEMGBIJH CKKNFOBALJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x67A3CC0", Offset = "0x67A24C0", VA = "0x1867A3CC0", Slot = "6")]
		private void MCINDBEGFDC(CNECBCEAJHF JDGGJJAANGA, DGGDEMGBIJH CKKNFOBALJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x67A3660", Offset = "0x67A1E60", VA = "0x1867A3660", Slot = "7")]
		private void AAKBBKNFPMO(CNECBCEAJHF JDGGJJAANGA, DGGDEMGBIJH CKKNFOBALJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x67A3850", Offset = "0x67A2050", VA = "0x1867A3850", Slot = "8")]
		private MAHBIIBDNME ALBJAKCNBLJ(Transform MCHMJHAODPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x67A3DD0", Offset = "0x67A25D0", VA = "0x1867A3DD0", Slot = "9")]
		private void OGKJGJJDJFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IBLLAHGOFKD
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2AC5890", Offset = "0x2AC4090", VA = "0x182AC5890")]
	public static OONOOJONAJF<T> MHPGLNJHBCA<T>(this AANDDJDEEFL KDCLBHAMNHO)
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
