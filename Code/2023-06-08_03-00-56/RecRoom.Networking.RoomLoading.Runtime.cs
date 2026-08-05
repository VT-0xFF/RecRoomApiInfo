using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LDNCPBAMPFL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PCAGCLDLODC : IEnumerable<AHPAHIFBAML>, IEnumerable, IEnumerator<AHPAHIFBAML>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private AHPAHIFBAML <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public LDNCPBAMPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public LDNCPBAMPFL <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private BGMKINHKNEE[] <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private BGMKINHKNEE <possibleSliceType>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int <index>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid <sliceTypeId>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private AHPAHIFBAML System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4189010", Offset = "0x4187E10", VA = "0x184189010", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(AHPAHIFBAML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6BBE820", Offset = "0x6BBD620", VA = "0x186BBE820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE6C450", Offset = "0xE6B250", VA = "0x180E6C450")]
		[DebuggerHidden]
		public PCAGCLDLODC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE530", Offset = "0x6BBD330", VA = "0x186BBE530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE7E0", Offset = "0x6BBD5E0", VA = "0x186BBE7E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE740", Offset = "0x6BBD540", VA = "0x186BBE740", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AHPAHIFBAML> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BBE740", Offset = "0x6BBD540", VA = "0x186BBE740", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly BGMKINHKNEE CFEKPCNNOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly Guid[] PPLHJACFFFD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB6C0", Offset = "0x6BBA4C0", VA = "0x186BBB6C0")]
	public static LDNCPBAMPFL HNIJFLMPPKA(BGMKINHKNEE EDCDLIMLKDF, Guid AMDHFIOMKAO)
	{
		return default(LDNCPBAMPFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB7D0", Offset = "0x6BBA5D0", VA = "0x186BBB7D0")]
	public static LDNCPBAMPFL IBLNPIKLMHK(List<AHPAHIFBAML> EPAPEGJBHPA)
	{
		return default(LDNCPBAMPFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB1D0", Offset = "0x6BB9FD0", VA = "0x186BBB1D0")]
	public static LDNCPBAMPFL EKOAFFHPAIL(BGMKINHKNEE GGPPGFKNHAC, Guid[] MIIMKODCDJN)
	{
		return default(LDNCPBAMPFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BBBD90", Offset = "0x6BBAB90", VA = "0x186BBBD90")]
	private LDNCPBAMPFL(BGMKINHKNEE GGPPGFKNHAC, Guid[] MIIMKODCDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB640", Offset = "0x6BBA440", VA = "0x186BBB640")]
	[IteratorStateMachine(typeof(PCAGCLDLODC))]
	public IEnumerable<AHPAHIFBAML> HANJNCKNPON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BBBC10", Offset = "0x6BBAA10", VA = "0x186BBBC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class PGKIBHJOKJO : FGFJBJIDPAC<LBFLBGDFHOI>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class NHEKFFEABLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NHEKFFEABLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD820", Offset = "0x6BBC620", VA = "0x186BBD820")]
		internal object IFOEGEADIIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal static readonly string[] DPLGFALKLHP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly PGKIBHJOKJO LNABDBHCENK;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE870", Offset = "0x6BBD670", VA = "0x186BBE870", Slot = "5")]
	protected override void JBENKCOBDEK(LBFLBGDFHOI CAJMIGKHKEC, IDictionary<object, object> FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BBECE0", Offset = "0x6BBDAE0", VA = "0x186BBECE0", Slot = "6")]
	public override LBFLBGDFHOI KMIKNNFPDOG(IDictionary<object, object> FAJCHBCCGOJ)
	{
		return default(LBFLBGDFHOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BBFAD0", Offset = "0x6BBE8D0", VA = "0x186BBFAD0")]
	public PGKIBHJOKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LGNNAFLEKCB : EOEAMOPIFBE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct AHABLILMCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly Guid BAOHCAPMGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly int KEKFIMLFLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly int BNOEJPFDJLI;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3540", Offset = "0x6BB2340", VA = "0x186BB3540")]
		public AHABLILMCLK(Guid APIKEGEJKFL, int ONLHGBINDIN, int EPBMGNKCPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB33E0", Offset = "0x6BB21E0", VA = "0x186BB33E0")]
		public static byte[] LKKGLINHIKF(AHABLILMCLK CAJMIGKHKEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3310", Offset = "0x6BB2110", VA = "0x186BB3310")]
		public static AHABLILMCLK KMIKNNFPDOG(byte[] KIIAPAPHICG)
		{
			return default(AHABLILMCLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB34C0", Offset = "0x6BB22C0", VA = "0x186BB34C0")]
		private static byte[] MEADPNABDOD(int EFGAFPEAGGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3260", Offset = "0x6BB2060", VA = "0x186BB3260")]
		private static int KEEOAPCDNOD(byte[] ECPPHHBIKAF, int FHOMILACEHB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Guid APIKEGEJKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GNGGHFBOLFG LIIFDCCNPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool DMLEBGFOIJC;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC560", Offset = "0x6BBB360", VA = "0x186BBC560")]
	public LGNNAFLEKCB(Guid APIKEGEJKFL, GNGGHFBOLFG LIIFDCCNPCF, GPJAEJFDPFA EAGOFGJABJP, CancellationToken HDKDIECCHLF, [Optional] NPGKCPICEBN JDFDKDAPJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC1F0", Offset = "0x6BBAFF0", VA = "0x186BBC1F0", Slot = "5")]
	protected override void GOMHEJJMBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC3C0", Offset = "0x6BBB1C0", VA = "0x186BBC3C0", Slot = "6")]
	protected override void OPBGJLPEBCD(int MFJFJFFNNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBBFD0", Offset = "0x6BBADD0", VA = "0x186BBBFD0")]
	private void BGHDIPHAMBD(LBFLBGDFHOI OCDMLMNNPLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class FGFJBJIDPAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4673670", Offset = "0x4672470", VA = "0x184673670", Slot = "4")]
	public void DFANEEANNME(T CAJMIGKHKEC, IDictionary<object, object> FAJCHBCCGOJ, bool BKFLGFMGNPE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void JBENKCOBDEK(T CAJMIGKHKEC, IDictionary<object, object> FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T KMIKNNFPDOG(IDictionary<object, object> FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
	protected FGFJBJIDPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EOEAMOPIFBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate bool NPGKCPICEBN(int MCJKALKCBHA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool GIFMINJHMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly GPJAEJFDPFA PHLNAAFPAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CancellationToken HDKDIECCHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CancellationToken AEIBOGKCIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NPGKCPICEBN JDFDKDAPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CancellationTokenSource CKFHPEGOEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CancellationTokenSource FNFAGOCFLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int HOKMCKDIBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool GFNLMIFIKCH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CancellationToken MKENDNJMHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6BB50D0", Offset = "0x6BB3ED0", VA = "0x186BB50D0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LPFDELJAOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5080", Offset = "0x6BB3E80", VA = "0x186BB5080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BB51B0", Offset = "0x6BB3FB0", VA = "0x186BB51B0")]
	public EOEAMOPIFBE(GPJAEJFDPFA EAGOFGJABJP, CancellationToken HDKDIECCHLF, [Optional] NPGKCPICEBN JDFDKDAPJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4F90", Offset = "0x6BB3D90", VA = "0x186BB4F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4FB0", Offset = "0x6BB3DB0", VA = "0x186BB4FB0", Slot = "5")]
	protected virtual void GOMHEJJMBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB50F0", Offset = "0x6BB3EF0", VA = "0x186BB50F0")]
	private void JELAIFHALAK(PMEFCBBKLLD DNPCKOKIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4F30", Offset = "0x6BB3D30", VA = "0x186BB4F30")]
	protected void DHPBCLCBCHF(int MFJFJFFNNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5190", Offset = "0x6BB3F90", VA = "0x186BB5190", Slot = "6")]
	protected virtual void OPBGJLPEBCD(int MFJFJFFNNPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LBFLBGDFHOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly LDNCPBAMPFL GKFDHLOIAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly byte PBGNJEBCOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly byte IBBMNIPPNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly bool AFNJMFPGOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly byte[] CMDEFNMIHDC;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB170", Offset = "0x6BB9F70", VA = "0x186BBB170")]
	public LBFLBGDFHOI(LDNCPBAMPFL MFAAHGPLINK, [CanBeNull] byte[] GNCDGJDGENH, bool CMMOCEDAAJF, byte CCNKNEHCDHC, byte NFAKCHOOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAFD0", Offset = "0x6BB9DD0", VA = "0x186BBAFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BBADE0", Offset = "0x6BB9BE0", VA = "0x186BBADE0")]
	private static void KEIBIDMKPLO(byte[] GNCDGJDGENH, StringBuilder JNOAENCPJNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct AHPAHIFBAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly BGMKINHKNEE OCIJJBNENOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly Guid NHHHKGHOEOF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2643E80", Offset = "0x2642C80", VA = "0x182643E80")]
	public AHPAHIFBAML(BGMKINHKNEE EDCDLIMLKDF, Guid MIKNHPHHOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3640", Offset = "0x6BB2440", VA = "0x186BB3640")]
	public bool OCABIOPIOAG(AHPAHIFBAML FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3550", Offset = "0x6BB2350", VA = "0x186BB3550", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3610", Offset = "0x6BB2410", VA = "0x186BB3610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Flags]
public enum BGMKINHKNEE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Operation = 1,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	RoomLoad = 2,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	MasterBlock = 4
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class MFGBDJFCEIP
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal static readonly BGMKINHKNEE[] BCINAAHHHPE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD0D0", Offset = "0x6BBBED0", VA = "0x186BBD0D0")]
	public static int ICEIGDBMLEO(BGMKINHKNEE EDCDLIMLKDF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GNGGHFBOLFG
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate string GMHNPCEGFKM([NotNull] byte[] GNCDGJDGENH);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct CAJKGCMIMBD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly LDNCPBAMPFL GKFDHLOIAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly bool AFNJMFPGOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly T CMDEFNMIHDC;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x486DBB0", Offset = "0x486C9B0", VA = "0x18486DBB0")]
		public static CAJKGCMIMBD<T> CAKCHOBKPKJ(LBFLBGDFHOI EIGCBJNCJGP, Func<byte[], T> CPNKJFMOFOF)
		{
			return default(CAJKGCMIMBD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x486DE90", Offset = "0x486CC90", VA = "0x18486DE90")]
		public CAJKGCMIMBD(LDNCPBAMPFL MFAAHGPLINK, T GNCDGJDGENH, bool CMMOCEDAAJF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x486DD60", Offset = "0x486CB60", VA = "0x18486DD60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class ECIMHNHIMNF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class KIKDGJNJJPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public TaskCompletionSource<LBFLBGDFHOI> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public ECIMHNHIMNF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public KIKDGJNJJPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6BBAC20", Offset = "0x6BB9A20", VA = "0x186BBAC20")]
			internal void PJPMHIPKOGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6BBA970", Offset = "0x6BB9770", VA = "0x186BBA970")]
			internal void HCDEIDPGAOH(LBFLBGDFHOI msg)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6BBA9E0", Offset = "0x6BB97E0", VA = "0x186BBA9E0")]
			internal void MCODJGOKOLO(IFHOBIJIHNL.HJGBNCKNOHC itemType, long totalStopwatchTicks)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6BBA890", Offset = "0x6BB9690", VA = "0x186BBA890")]
			internal NLGCGJCBEON BOHDPBILMCM(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GKEHENINDAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public IFHOBIJIHNL.HJGBNCKNOHC itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public GKEHENINDAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5600", Offset = "0x6BB4400", VA = "0x186BB5600")]
			internal object LIHENMEAFKD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class DDJODAOBBKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public AsyncTaskMethodBuilder<LBFLBGDFHOI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public ECIMHNHIMNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private KIKDGJNJJPG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int <lastIndex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private LBFLBGDFHOI <response>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private LBFLBGDFHOI <response>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private LBFLBGDFHOI <>s__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private TaskAwaiter<LBFLBGDFHOI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public DDJODAOBBKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3980", Offset = "0x6BB2780", VA = "0x186BB3980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class COIKAMAAKJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public BGMKINHKNEE sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public COIKAMAAKJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3820", Offset = "0x6BB2620", VA = "0x186BB3820")]
			internal bool OJNOIJNPHNK(LBFLBGDFHOI bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly NPIOPCGNODD BCEGHMDDJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly string FFDFOKFEDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly List<LBFLBGDFHOI> EHHBBNJGBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private List<(IFHOBIJIHNL.HJGBNCKNOHC itemType, long totalStopwatchTicks)> PHHIADCONGB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool AJPLDNGEMBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4920", Offset = "0x6BB3720", VA = "0x186BB4920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<LBFLBGDFHOI> BBFICJHKKDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4BB0", Offset = "0x6BB39B0", VA = "0x186BB4BB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4C50", Offset = "0x6BB3A50", VA = "0x186BB4C50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4E20", Offset = "0x6BB3C20", VA = "0x186BB4E20")]
		public ECIMHNHIMNF(NPIOPCGNODD BCEGHMDDJBO, string FFDFOKFEDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4A20", Offset = "0x6BB3820", VA = "0x186BB4A20")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DDJODAOBBKM))]
		public Task<LBFLBGDFHOI> LIOKGDEMOKM(CancellationToken KIMBGNGMOGB, TimeSpan HFKMHAHJMBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4970", Offset = "0x6BB3770", VA = "0x186BB4970")]
		public void FJJOGMBHDKK(LBFLBGDFHOI CAJMIGKHKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB48D0", Offset = "0x6BB36D0", VA = "0x186BB48D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4CF0", Offset = "0x6BB3AF0", VA = "0x186BB4CF0")]
		public void PHBEBAHBFFM(BGMKINHKNEE EDCDLIMLKDF, Guid PJCEAFJNLLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MDGAMGJINON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder<LBFLBGDFHOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public BHKGOMGGFIG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public BHKGOMGGFIG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private string <error>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TimeSpan <timeout>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private LBFLBGDFHOI <response>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private LBFLBGDFHOI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private IEnumerator<AHPAHIFBAML> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private AHPAHIFBAML <slice>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<LBFLBGDFHOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MDGAMGJINON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC680", Offset = "0x6BBB480", VA = "0x186BBC680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NCDBHDKADBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public BHKGOMGGFIG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BHKGOMGGFIG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private CAJKGCMIMBD<Guid> <msg>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CAJKGCMIMBD<Guid> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<CAJKGCMIMBD<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NCDBHDKADBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD220", Offset = "0x6BBC020", VA = "0x186BBD220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DABAAPMFJBP<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AsyncTaskMethodBuilder<CAJKGCMIMBD<T>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<T, byte[]> serializer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Func<byte[], T> deserializer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public BHKGOMGGFIG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public BHKGOMGGFIG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private byte[] <payloadBytes>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private LBFLBGDFHOI <bytesResponse>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private LBFLBGDFHOI <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter<LBFLBGDFHOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public DABAAPMFJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC2A0", Offset = "0x2ABB0A0", VA = "0x182ABC2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class POKMAFFDDGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<LBFLBGDFHOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BHKGOMGGFIG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BHKGOMGGFIG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool <insideMasterLockBlock>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private LBFLBGDFHOI <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private LBFLBGDFHOI <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private LBFLBGDFHOI <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<LBFLBGDFHOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public POKMAFFDDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BBFB10", Offset = "0x6BBE910", VA = "0x186BBFB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NELIHIBKAHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NELIHIBKAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD6B0", Offset = "0x6BBC4B0", VA = "0x186BBD6B0")]
		internal bool EFEMIOKGJOO(int currentAttempt, TimeSpan elapsed, TimeSpan globalTimeout)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD7C0", Offset = "0x6BBC5C0", VA = "0x186BBD7C0")]
		internal bool NNMIOECKOLF(int newMasterClientActorNumber)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NLJJJLBOGDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<LBFLBGDFHOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public BHKGOMGGFIG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BHKGOMGGFIG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private NELIHIBKAHI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private EOEAMOPIFBE <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private LBFLBGDFHOI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<LBFLBGDFHOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NLJJJLBOGDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD960", Offset = "0x6BBC760", VA = "0x186BBD960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DDKDNBKLGEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder<LBFLBGDFHOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public BHKGOMGGFIG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public BHKGOMGGFIG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private LBFLBGDFHOI <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<LBFLBGDFHOI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DDKDNBKLGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6BB42A0", Offset = "0x6BB30A0", VA = "0x186BB42A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KLPEHDOLMCI
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private sealed class <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public KLPEHDOLMCI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public <<MasterLockedBlock>b__0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6BC0310", Offset = "0x6BBF110", VA = "0x186BC0310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KLPEHDOLMCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6BBAC70", Offset = "0x6BB9A70", VA = "0x186BBAC70")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> KFDIPMKEHAD(CancellationToken token)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GEHJDOOGKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public BHKGOMGGFIG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BHKGOMGGFIG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private KLPEHDOLMCI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GEHJDOOGKBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5370", Offset = "0x6BB4170", VA = "0x186BB5370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NLMJKFIFLMG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public BHKGOMGGFIG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public BHKGOMGGFIG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Guid <sliceId>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Guid <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private T <result>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private (bool, T) <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private (bool, T) <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<Guid> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter<(bool, T)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public NLMJKFIFLMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4703130", Offset = "0x4701F30", VA = "0x184703130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HLMIAPKFBEM<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder<(bool, T)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Guid sliceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public GNGGHFBOLFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private bool <isRootMasterBlockSlice>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private LGNNAFLEKCB <masterSwitchTokenScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private T <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private T <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public HLMIAPKFBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B04A20", Offset = "0x3B03820", VA = "0x183B04A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DLNCICNPHDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DLNCICNPHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4830", Offset = "0x6BB3630", VA = "0x186BB4830")]
		internal object JHDOFBEOBFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6BB47E0", Offset = "0x6BB35E0", VA = "0x186BB47E0")]
		internal object HKCKJEPLDKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KCDCCBEIMBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public BGMKINHKNEE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KCDCCBEIMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA7F0", Offset = "0x6BB95F0", VA = "0x186BBA7F0")]
		internal object EJAKJOCHGGC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CDOMNCKKINN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public BGMKINHKNEE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CDOMNCKKINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3710", Offset = "0x6BB2510", VA = "0x186BB3710")]
		internal object DCJDMMCBMAM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BEBMCKFBNFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BEBMCKFBNFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6BB36A0", Offset = "0x6BB24A0", VA = "0x186BB36A0")]
		internal object LAMAGDHLFIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CFMHEIBMDFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CFMHEIBMDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BB37B0", Offset = "0x6BB25B0", VA = "0x186BB37B0")]
		internal object ENJBKGKCAON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class HJFEKCLDIML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HJFEKCLDIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA1F0", Offset = "0x6BB8FF0", VA = "0x186BBA1F0")]
		internal bool KCBKABCOHFB(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class GPGHKACLEND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GPGHKACLEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA160", Offset = "0x6BB8F60", VA = "0x186BBA160")]
		internal bool PLGHJLPMDMA(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class LOLAMGDBDNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Func<Guid, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LOLAMGDBDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC620", Offset = "0x6BBB420", VA = "0x186BBC620")]
		internal bool LNPJAOHHEGB(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC5C0", Offset = "0x6BBB3C0", VA = "0x186BBC5C0")]
		internal bool ALDKGFEDBOD(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DHAILHOAIPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DHAILHOAIPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4740", Offset = "0x6BB3540", VA = "0x186BB4740")]
		internal bool CAMMOCEOEFI(AHPAHIFBAML stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KABJGBBGAMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KABJGBBGAMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA2F0", Offset = "0x6BB90F0", VA = "0x186BBA2F0")]
		internal object EDJNPHIGBFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA570", Offset = "0x6BB9370", VA = "0x186BBA570")]
		internal object GEDMGDBCFGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6BBA280", Offset = "0x6BB9080", VA = "0x186BBA280")]
		internal object BHFOKJIMPGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly GMHNPCEGFKM OBDICFHADCB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly ExitGames.Client.Photon.Hashtable PPHCOCLPKJD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly AELHKNEAFGB PIDLCICAOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly ECIMHNHIMNF PEFEDBPBJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly NPIOPCGNODD BCEGHMDDJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly GICEHGBJPGJ MLLEAIDBEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly GPJAEJFDPFA LMHKMFBKHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GMHNPCEGFKM MEDEMNOMLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool BLMLHEIKNME;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly TimeSpan POIBFDHDHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly TimeSpan CNHPCGHPEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private byte IFIFAICJMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Guid>[] MJHFDBLIOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<AHPAHIFBAML> FBJCOACIIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private LDNCPBAMPFL? JAGADGBFKCN;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly AELHKNEAFGB OPEELPIBCHN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly AELHKNEAFGB CADLFEJABLB;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<LBFLBGDFHOI> BGHDIPHAMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5DB0", Offset = "0x6BB4BB0", VA = "0x186BB5DB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB89C0", Offset = "0x6BB77C0", VA = "0x186BB89C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9C50", Offset = "0x6BB8A50", VA = "0x186BB9C50")]
	public GNGGHFBOLFG(NPIOPCGNODD BCEGHMDDJBO, GICEHGBJPGJ MLLEAIDBEFP, GPJAEJFDPFA LMHKMFBKHNH, [Optional] TimeSpan? NMHPINLEOKA, [Optional] GMHNPCEGFKM BCOGPGFAEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x34711F0", Offset = "0x346FFF0", VA = "0x1834711F0")]
	public static GNGGHFBOLFG JGMHLFPNNJP<TNetworking>(TNetworking EAGOFGJABJP, [Optional] TimeSpan? NMHPINLEOKA, [Optional] GMHNPCEGFKM BCOGPGFAEJC) where TNetworking : NPIOPCGNODD, GICEHGBJPGJ, GPJAEJFDPFA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8FE0", Offset = "0x6BB7DE0", VA = "0x186BB8FE0")]
	public void LLJCJCMKKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8870", Offset = "0x6BB7670", VA = "0x186BB8870")]
	private byte KOBLMHDGFJB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BB90D0", Offset = "0x6BB7ED0", VA = "0x186BB90D0")]
	private TimeSpan NIFINEINDJA(TimeSpan? NMHPINLEOKA, int MIDDOGMBGFH = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3471290", Offset = "0x3470090", VA = "0x183471290")]
	public bool KBKCLCGNMFD<T>(T EPJFFKMLBOM, Func<T, byte[]> PGCOFMAGKKE, bool CMMOCEDAAJF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8270", Offset = "0x6BB7070", VA = "0x186BB8270")]
	public bool KBKCLCGNMFD(byte[] EPJFFKMLBOM, int HGBFHJPANMK, bool CMMOCEDAAJF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84A140", Offset = "0x848F40", VA = "0x18084A140")]
	private static string CNAFNONOBIN(string CAJMIGKHKEC, string OPEMNAAFCJM = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6020", Offset = "0x6BB4E20", VA = "0x186BB6020")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MDGAMGJINON))]
	public Task<LBFLBGDFHOI> EAOJNDDFEKM(CancellationToken KIMBGNGMOGB, [Optional] BHKGOMGGFIG PBJIBLBKDME, [Optional] BHKGOMGGFIG IGBFLHLICDC, [Optional] TimeSpan? NMHPINLEOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8070", Offset = "0x6BB6E70", VA = "0x186BB8070")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NCDBHDKADBN))]
	public Task<Guid> JGGMPFECHCF(Guid AIDILGIMKHN, CancellationToken KIMBGNGMOGB, [Optional] BHKGOMGGFIG PBJIBLBKDME, [Optional] BHKGOMGGFIG IGBFLHLICDC, [Optional] TimeSpan? HFKMHAHJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x34705C0", Offset = "0x346F3C0", VA = "0x1834705C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DABAAPMFJBP<>))]
	public Task<CAJKGCMIMBD<T>> EKFLPINMIDH<T>(T EPJFFKMLBOM, Func<T, byte[]> PGCOFMAGKKE, Func<byte[], T> CPNKJFMOFOF, CancellationToken KIMBGNGMOGB, [Optional] BHKGOMGGFIG PBJIBLBKDME, [Optional] BHKGOMGGFIG IGBFLHLICDC, [Optional] TimeSpan? HFKMHAHJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6200", Offset = "0x6BB5000", VA = "0x186BB6200")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(POKMAFFDDGK))]
	public Task<LBFLBGDFHOI> EKFLPINMIDH(byte[] EPJFFKMLBOM, CancellationToken KIMBGNGMOGB, [Optional] BHKGOMGGFIG PBJIBLBKDME, [Optional] BHKGOMGGFIG IGBFLHLICDC, [Optional] TimeSpan? HFKMHAHJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5B90", Offset = "0x6BB4990", VA = "0x186BB5B90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLJJJLBOGDI))]
	private Task<LBFLBGDFHOI> CFFBIJFJNDO(byte[] EPJFFKMLBOM, CancellationToken KIMBGNGMOGB, BHKGOMGGFIG PBJIBLBKDME, BHKGOMGGFIG IGBFLHLICDC, TimeSpan? NMHPINLEOKA, Stopwatch NGEIEGBALGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9300", Offset = "0x6BB8100", VA = "0x186BB9300")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDKDNBKLGEA))]
	private Task<LBFLBGDFHOI> OPEGIMFFEJM(byte[] EPJFFKMLBOM, CancellationToken KIMBGNGMOGB, [Optional] BHKGOMGGFIG PBJIBLBKDME, [Optional] BHKGOMGGFIG IGBFLHLICDC, [Optional] TimeSpan? HFKMHAHJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7960", Offset = "0x6BB6760", VA = "0x186BB7960")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GEHJDOOGKBK))]
	public Task ICNIINGDLCG(CancellationToken HDKDIECCHLF, Func<CancellationToken, Task> OEGHGKCBDEL, [Optional] BHKGOMGGFIG PBJIBLBKDME, [Optional] BHKGOMGGFIG IGBFLHLICDC, int AKABMJAGFLC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3470B00", Offset = "0x346F900", VA = "0x183470B00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLMJKFIFLMG<>))]
	public Task<T> ICNIINGDLCG<T>(CancellationToken HDKDIECCHLF, Func<CancellationToken, Task<T>> OEGHGKCBDEL, [Optional] BHKGOMGGFIG PBJIBLBKDME, [Optional] BHKGOMGGFIG IGBFLHLICDC, int AKABMJAGFLC = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3471340", Offset = "0x3470140", VA = "0x183471340")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HLMIAPKFBEM<>))]
	private Task<(bool, T)> LLLMMFAKBFN<T>(Guid MIKNHPHHOAH, CancellationToken HDKDIECCHLF, Func<CancellationToken, Task<T>> OEGHGKCBDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6DB0", Offset = "0x6BB5BB0", VA = "0x186BB6DB0")]
	public void HGMCGELAGND(byte JKHMMLHEFIB, int DOHJKGEIANH, object NHBJMKBMIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6400", Offset = "0x6BB5200", VA = "0x186BB6400")]
	public Guid EPHOKADPKNF(Guid HNFDKDJBKBB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8A60", Offset = "0x6BB7860", VA = "0x186BB8A60")]
	public bool LIDBKNEJJBN(BGMKINHKNEE EDCDLIMLKDF, Guid MIKNHPHHOAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5790", Offset = "0x6BB4590", VA = "0x186BB5790")]
	public void BOBKDCFIMGE(BGMKINHKNEE EDCDLIMLKDF, Guid MIKNHPHHOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5780", Offset = "0x6BB4580", VA = "0x186BB5780")]
	private void ANBAAAAIGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9900", Offset = "0x6BB8700", VA = "0x186BB9900")]
	internal LDNCPBAMPFL PJMMJBAPGOK(bool JEFDGPMIPGJ = false)
	{
		return default(LDNCPBAMPFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8880", Offset = "0x6BB7680", VA = "0x186BB8880")]
	private HashSet<Guid> LDBICAJLLOD(BGMKINHKNEE EDCDLIMLKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7790", Offset = "0x6BB6590", VA = "0x186BB7790")]
	private void HMJMNDEDOFA(BGMKINHKNEE EDCDLIMLKDF, Guid PJCEAFJNLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9500", Offset = "0x6BB8300", VA = "0x186BB9500")]
	private void PALGPDAOBID(BGMKINHKNEE EDCDLIMLKDF, Guid PJCEAFJNLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BB56D0", Offset = "0x6BB44D0", VA = "0x186BB56D0")]
	public static Func<Guid, bool> AADCEHPOKCJ(Guid PJCEAFJNLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5E50", Offset = "0x6BB4C50", VA = "0x186BB5E50")]
	public static Func<Guid, bool> DGKAGCDIIHH(Guid PJCEAFJNLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BB97F0", Offset = "0x6BB85F0", VA = "0x186BB97F0")]
	public void PHBEBAHBFFM(BGMKINHKNEE EDCDLIMLKDF, Guid JFKPNAODGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7B30", Offset = "0x6BB6930", VA = "0x186BB7B30")]
	public void IOFKGADAKBK(BGMKINHKNEE EDCDLIMLKDF, Func<Guid, bool> HEBJBDJAPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5F00", Offset = "0x6BB4D00", VA = "0x186BB5F00")]
	private static ExitGames.Client.Photon.Hashtable DHMAMAHKAPC(BGMKINHKNEE EDCDLIMLKDF, Guid JAEIMDOMKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6660", Offset = "0x6BB5460", VA = "0x186BB6660")]
	private void GBEMGEECCPO(BGMKINHKNEE EDCDLIMLKDF, Guid JAEIMDOMKAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NLGCGJCBEON : HAFDGGFJALO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private List<(IFHOBIJIHNL.HJGBNCKNOHC itemType, long totalStopwatchTicks)> ONHOJGIKJPC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyList<(IFHOBIJIHNL.HJGBNCKNOHC itemType, long totalStopwatchTicks)> KNIEBOBDNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921300", VA = "0x180922500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD8E0", Offset = "0x6BBC6E0", VA = "0x186BBD8E0")]
	public NLGCGJCBEON(TimeSpan HFKMHAHJMBO, List<(IFHOBIJIHNL.HJGBNCKNOHC itemType, long totalStopwatchTicks)> ONHOJGIKJPC)
	{
	}
}
namespace Cpp2IlInjected;

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
