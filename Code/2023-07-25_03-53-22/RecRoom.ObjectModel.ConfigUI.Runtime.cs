using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.CodeGen.Attributes;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal struct MLOPDOLLKJM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7170480", Offset = "0x716F480", VA = "0x187170480")]
	public static NativeList<int> FCEBEMCLLIF(FNOEBANGBJI LLGFHBBLPAM, OMMOOGKHFGK JHOOEMDNKAI)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71706A0", Offset = "0x716F6A0", VA = "0x1871706A0")]
	private static bool JOGJOJLICKK(JMDPFBBINKM LDJJMGJLECK, FNOEBANGBJI LLGFHBBLPAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal struct NBOKCGGNGPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int EKOLKHGLFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public int BJMBLNMHMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public int FGJNCOCMMCF;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class PBGHHPCIOLO : KAHEDNPEDKA, FLKIJOBAAMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private JMDPFBBINKM[] DJBAHDNCOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private JMDPFBBINKM[] GHPIBFPCDFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JMDPFBBINKM[] BALOKMJAKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JMDPFBBINKM[] HHDABJLPCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract NOJOLKBLHAF[] LICLAADBFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract NOJOLKBLHAF[] PPMFMAKHHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71711A0", Offset = "0x71701A0", VA = "0x1871711A0", Slot = "6")]
	public void HOCOANJGOKB(GJCFHGCFPIM ICJFJHAECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, FNOEBANGBJI LLGFHBBLPAM, OMMOOGKHFGK JHOOEMDNKAI, AIAMAMPCJBI IJGDOPEJJDL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29233D0", Offset = "0x29223D0", VA = "0x1829233D0")]
	protected static T PKEELEHBEFM<T>(FNOEBANGBJI LLGFHBBLPAM, JMDPFBBINKM LDJJMGJLECK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2923300", Offset = "0x2922300", VA = "0x182923300")]
	protected static void BFJGOIPOBPE<T>(FNOEBANGBJI LLGFHBBLPAM, JMDPFBBINKM LDJJMGJLECK, T CKDFGEALFAK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	protected PBGHHPCIOLO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct BBHBPCLCAIC : IComparer<NBOKCGGNGPN>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x716CB80", Offset = "0x716BB80", VA = "0x18716CB80", Slot = "4")]
	public int Compare(NBOKCGGNGPN LFEMLKHNBHE, NBOKCGGNGPN CNOAFMMFDKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x716CB30", Offset = "0x716BB30", VA = "0x18716CB30")]
	public static void BBDJIBMOAAJ(NativeList<NBOKCGGNGPN> CIIFHFKPFJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class COIEFONHCDI : CLFJGNGILEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JMDPFBBINKM LDJJMGJLECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OMMOOGKHFGK KNEFBFDLNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly FNOEBANGBJI LLGFHBBLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x716D4D0", Offset = "0x716C4D0", VA = "0x18716D4D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OAEPAJFJIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x716D2F0", Offset = "0x716C2F0", VA = "0x18716D2F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PJGCHGOPADA BEAEBEPNMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x716D270", Offset = "0x716C270", VA = "0x18716D270", Slot = "8")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Type HCKGHBENCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x716CCD0", Offset = "0x716BCD0", VA = "0x18716CCD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action LBGJMGKKDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x716D1D0", Offset = "0x716C1D0", VA = "0x18716D1D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x716D430", Offset = "0x716C430", VA = "0x18716D430", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x716D520", Offset = "0x716C520", VA = "0x18716D520")]
	public COIEFONHCDI(FNOEBANGBJI LLGFHBBLPAM, JMDPFBBINKM LDJJMGJLECK, OMMOOGKHFGK KNEFBFDLNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x716CED0", Offset = "0x716BED0", VA = "0x18716CED0")]
	private void DHBADFGEKKJ(EGBHOCHMGFB HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x716D0C0", Offset = "0x716C0C0", VA = "0x18716D0C0", Slot = "10")]
	public void FLFDNJDANPO(AEOEDAMJAAA CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x716CD20", Offset = "0x716BD20", VA = "0x18716CD20", Slot = "11")]
	public void DGLJBNFHKAF(LEMHKMBLBBH CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x716CFF0", Offset = "0x716BFF0", VA = "0x18716CFF0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BIPCKMHJLKL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x716CB90", Offset = "0x716BB90", VA = "0x18716CB90")]
	public static bool HHGHNOHKFEF(this JMDPFBBINKM LDJJMGJLECK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[KLBDHOMNNPJ(typeof(Vector3))]
internal class KABFLFNBKCL : JCCKAOCCJNI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PCECOCHAKJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CLFJGNGILEC property;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PCECOCHAKJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x71715F0", Offset = "0x71705F0", VA = "0x1871715F0")]
		internal float CLOHGKIHFOG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7171750", Offset = "0x7170750", VA = "0x187171750")]
		internal void LOAGINIMKOH(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7171640", Offset = "0x7170640", VA = "0x187171640")]
		internal float DJNIPPHFKJK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7171760", Offset = "0x7170760", VA = "0x187171760")]
		internal void NJAKDCCAIPC(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71715A0", Offset = "0x71705A0", VA = "0x1871715A0")]
		internal float AGEECNKJKNF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7171770", Offset = "0x7170770", VA = "0x187171770")]
		internal void OLEFCEKLONB(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7171690", Offset = "0x7170690", VA = "0x187171690")]
		internal void IDAHDGICIJL(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x716FA10", Offset = "0x716EA10", VA = "0x18716FA10", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x716FE30", Offset = "0x716EE30", VA = "0x18716FE30")]
	public KABFLFNBKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[KLBDHOMNNPJ(typeof(uint))]
internal class OHMOCGBCHFF : JCCKAOCCJNI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HGMMJKELBAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CLFJGNGILEC property;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HGMMJKELBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x716ED90", Offset = "0x716DD90", VA = "0x18716ED90")]
		internal int CLOHGKIHFOG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x716EDD0", Offset = "0x716DDD0", VA = "0x18716EDD0")]
		internal void LOAGINIMKOH(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7170EC0", Offset = "0x716FEC0", VA = "0x187170EC0", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7171080", Offset = "0x7170080", VA = "0x187171080")]
	public OHMOCGBCHFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Class)]
public class JAKDGDJHCIE : DAIELDCCMEM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x716F330", Offset = "0x716E330", VA = "0x18716F330")]
	public JAKDGDJHCIE(int GPOCBGFAAFK = 1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[JAKDGDJHCIE(1)]
internal sealed class GENBNDEIJBO : NKPILGJFGOH, NMJAJKOJPLB, FLKIJOBAAMB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MHLLAMEHFJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CLFJGNGILEC property;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MHLLAMEHFJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7170230", Offset = "0x716F230", VA = "0x187170230")]
		internal bool CLOHGKIHFOG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7170310", Offset = "0x716F310", VA = "0x187170310")]
		internal string LOAGINIMKOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7170280", Offset = "0x716F280", VA = "0x187170280")]
		internal void DJNIPPHFKJK(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7170390", Offset = "0x716F390", VA = "0x187170390")]
		internal string NJAKDCCAIPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x716ECE0", Offset = "0x716DCE0", VA = "0x18716ECE0", Slot = "4")]
	public int LPFDMEAGNKO(GJCFHGCFPIM KNEFBFDLNNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x716E890", Offset = "0x716D890", VA = "0x18716E890", Slot = "5")]
	public void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public GENBNDEIJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KLBDHOMNNPJ(typeof(FixedString64Bytes))]
internal class IKLMLLEBGAC : JCCKAOCCJNI<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NCIMNGLLLOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CLFJGNGILEC property;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NCIMNGLLLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7170890", Offset = "0x716F890", VA = "0x187170890")]
		internal string CLOHGKIHFOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7170910", Offset = "0x716F910", VA = "0x187170910")]
		internal void LOAGINIMKOH(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x716EFC0", Offset = "0x716DFC0", VA = "0x18716EFC0", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x716F180", Offset = "0x716E180", VA = "0x18716F180")]
	public IKLMLLEBGAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal struct EPNLGHBGMGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NativeBitArray FKPGAGKFCAH;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x716DF60", Offset = "0x716CF60", VA = "0x18716DF60")]
	public EPNLGHBGMGO(int LEOAEOJMCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x716DC70", Offset = "0x716CC70", VA = "0x18716DC70")]
	public static EPNLGHBGMGO GNGHIPBEFFJ(int OENKBEGLEDJ, NativeArray<int> GHDMEKEFFPC)
	{
		return default(EPNLGHBGMGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x716DC40", Offset = "0x716CC40", VA = "0x18716DC40")]
	public bool BKFGNHLHMDI(int CCELBNKPBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x716DC50", Offset = "0x716CC50", VA = "0x18716DC50")]
	public void DGLJBNFHKAF(int CCELBNKPBGB, bool CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x716DDE0", Offset = "0x716CDE0", VA = "0x18716DDE0")]
	public bool NGIPMEBKFJH(JMDPFBBINKM[] GHDMEKEFFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x716DEA0", Offset = "0x716CEA0", VA = "0x18716DEA0")]
	public bool OENEIFGKAME(JMDPFBBINKM[] GHDMEKEFFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x716DC60", Offset = "0x716CC60", VA = "0x18716DC60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class AHOGLMHFNPF
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OMMOOGKHFGK JHOOEMDNKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GJCFHGCFPIM ICJFJHAECPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<FLKIJOBAAMB> OFKCPKAAIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JFBCHBPBFJD CFCIDHHLIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeParallelMultiHashMap<int, int> LHOKMHGIHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> HMHMEAJDJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<FLKIJOBAAMB> MNMOCELMHBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x716BEF0", Offset = "0x716AEF0", VA = "0x18716BEF0")]
	public AHOGLMHFNPF(OMMOOGKHFGK JHOOEMDNKAI, GJCFHGCFPIM ICJFJHAECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x716BD90", Offset = "0x716AD90", VA = "0x18716BD90")]
	public void OJEHGLDDBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x716B110", Offset = "0x716A110", VA = "0x18716B110")]
	public void EMFGBDBPIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x716B2F0", Offset = "0x716A2F0", VA = "0x18716B2F0")]
	public NativeList<NBOKCGGNGPN> GAMDHICONLG(NativeArray<int> GHDMEKEFFPC)
	{
		return default(NativeList<NBOKCGGNGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x716BA10", Offset = "0x716AA10", VA = "0x18716BA10")]
	private bool GEEGOGLECFC(FLKIJOBAAMB MGPNLFOOFIA, EPNLGHBGMGO FIPGLFLHKJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x199F6A0", Offset = "0x199E6A0", VA = "0x18199F6A0")]
	private void PMKCHLCPCDK<TInterface, TAttribute>(Action<TInterface, TAttribute> EILJPFGBGMG) where TInterface : FLKIJOBAAMB where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x716BB80", Offset = "0x716AB80", VA = "0x18716BB80")]
	private void JKMGOFPAFDP(Type DPPJBLOOGOO, Type FBHGODLIGOB, Type HBELMHLCEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x199F640", Offset = "0x199E640", VA = "0x18199F640")]
	private TInterface BGCELJDEDFF<TInterface>(Type DPPJBLOOGOO)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x716BBB0", Offset = "0x716ABB0", VA = "0x18716BBB0")]
	private void MPLIEHHIBNG(FLKIJOBAAMB MGPNLFOOFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x716BAE0", Offset = "0x716AAE0", VA = "0x18716BAE0")]
	private int IIAMAENNKIM(FLKIJOBAAMB HCIFEDKFADL, int FGJNCOCMMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x716B770", Offset = "0x716A770", VA = "0x18716B770")]
	private void GBFDJIHFOAA(NMJAJKOJPLB MGPNLFOOFIA, KLBDHOMNNPJ CPJHNFIGLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x716AE50", Offset = "0x7169E50", VA = "0x18716AE50")]
	private void EBNNFMDDFNL(NOOIKFHBNCE MGPNLFOOFIA, HIGHABJMCHJ CPJHNFIGLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x716ACB0", Offset = "0x7169CB0", VA = "0x18716ACB0")]
	private void AGBHOFCCEIE(KAHEDNPEDKA MGPNLFOOFIA, LJEMBFMPKKC CPJHNFIGLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x716BC80", Offset = "0x716AC80", VA = "0x18716BC80")]
	private void NOGMMLKLDJB(NKPILGJFGOH MGPNLFOOFIA, JAKDGDJHCIE CPJHNFIGLGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KLBDHOMNNPJ(typeof(float))]
internal class DPNKEIDJMMC : JCCKAOCCJNI<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x716D620", Offset = "0x716C620", VA = "0x18716D620", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x716D6B0", Offset = "0x716C6B0", VA = "0x18716D6B0")]
	public DPNKEIDJMMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal abstract class JCCKAOCCJNI<T> : NMJAJKOJPLB, FLKIJOBAAMB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EEKDJLGEAGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CLFJGNGILEC property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public EEKDJLGEAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x321BDB0", Offset = "0x321ADB0", VA = "0x18321BDB0")]
		internal bool KKIBKCLMEEH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x36D3110", Offset = "0x36D2110", VA = "0x1836D3110")]
	protected JCCKAOCCJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x36D2820", Offset = "0x36D1820", VA = "0x1836D2820")]
	protected void LAINLNMGBNM(OCOCJMGNNAP DJGCJCMOFFD, CLFJGNGILEC LDJJMGJLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x36D1E20", Offset = "0x36D0E20", VA = "0x1836D1E20")]
	protected void JPMHDPLLFCE(IAELHNFMKLF<T> DJGCJCMOFFD, CLFJGNGILEC LDJJMGJLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KLBDHOMNNPJ(typeof(FixedString32Bytes))]
internal class LNMJPINEIMG : JCCKAOCCJNI<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NLNDFFHFPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CLFJGNGILEC property;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NLNDFFHFPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71709A0", Offset = "0x716F9A0", VA = "0x1871709A0")]
		internal string CLOHGKIHFOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7170A00", Offset = "0x716FA00", VA = "0x187170A00")]
		internal void LOAGINIMKOH(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x716FE70", Offset = "0x716EE70", VA = "0x18716FE70", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7170030", Offset = "0x716F030", VA = "0x187170030")]
	public LNMJPINEIMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KLBDHOMNNPJ(typeof(bool))]
internal class HNGJGPIMNPE : JCCKAOCCJNI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x716EE20", Offset = "0x716DE20", VA = "0x18716EE20", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x716EEB0", Offset = "0x716DEB0", VA = "0x18716EEB0")]
	public HNGJGPIMNPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal abstract class PDAIEGKGKGC : DADGKFFHFKC<Enum>, NOOIKFHBNCE, NMJAJKOJPLB, FLKIJOBAAMB
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool BEHEGJNLOBN(Type DPPJBLOOGOO);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x716E120", Offset = "0x716D120", VA = "0x18716E120")]
	protected PDAIEGKGKGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal abstract class DADGKFFHFKC<T> : NMJAJKOJPLB, FLKIJOBAAMB where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JDIJKFDIGAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CLFJGNGILEC property;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public JDIJKFDIGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x243BC50", Offset = "0x243AC50", VA = "0x18243BC50")]
		internal bool KKIBKCLMEEH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29F1650", Offset = "0x29F0650", VA = "0x1829F1650")]
	protected DADGKFFHFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29F1390", Offset = "0x29F0390", VA = "0x1829F1390")]
	protected void LAINLNMGBNM(OCOCJMGNNAP DJGCJCMOFFD, CLFJGNGILEC LDJJMGJLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29F0F80", Offset = "0x29EFF80", VA = "0x1829F0F80")]
	protected void JPMHDPLLFCE(IAELHNFMKLF<T> DJGCJCMOFFD, CLFJGNGILEC LDJJMGJLECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KLBDHOMNNPJ(typeof(PKFAMLPGILK), 1)]
internal class JDJBHPFMLKC : DADGKFFHFKC<PKFAMLPGILK>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x716F340", Offset = "0x716E340", VA = "0x18716F340", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x716F4B0", Offset = "0x716E4B0", VA = "0x18716F4B0")]
	public JDJBHPFMLKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[LJEMBFMPKKC(2)]
internal class EHPAIDDKCIK : PBGHHPCIOLO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MGCJHAOIDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FNOEBANGBJI targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EHPAIDDKCIK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MGCJHAOIDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7170070", Offset = "0x716F070", VA = "0x187170070")]
		internal (int, int) CLOHGKIHFOG()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x71701A0", Offset = "0x716F1A0", VA = "0x1871701A0")]
		internal void LOAGINIMKOH((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected override NOJOLKBLHAF[] PPMFMAKHHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x716D6F0", Offset = "0x716C6F0", VA = "0x18716D6F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected override NOJOLKBLHAF[] LICLAADBFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x716D7D0", Offset = "0x716C7D0", VA = "0x18716D7D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x716D8B0", Offset = "0x716C8B0", VA = "0x18716D8B0", Slot = "10")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, FNOEBANGBJI LLGFHBBLPAM, OMMOOGKHFGK JHOOEMDNKAI, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public EHPAIDDKCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[HIGHABJMCHJ(0)]
internal class IPFDPHLNLFJ : PDAIEGKGKGC
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x716F280", Offset = "0x716E280", VA = "0x18716F280", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x716F1C0", Offset = "0x716E1C0", VA = "0x18716F1C0", Slot = "7")]
	public override bool BEHEGJNLOBN(Type DPPJBLOOGOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x716E120", Offset = "0x716D120", VA = "0x18716E120")]
	public IPFDPHLNLFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class AKLJBEECDNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OMMOOGKHFGK JHOOEMDNKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly GJCFHGCFPIM ICJFJHAECPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly AIAMAMPCJBI IJGDOPEJJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Action<NBOKCGGNGPN> LLJIIOBELND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<KNOFKBKFPEC> OJNAMJKLCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<KNOFKBKFPEC, List<NBOKCGGNGPN>> OOMPMPNMIML;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x716CA10", Offset = "0x716BA10", VA = "0x18716CA10")]
	public AKLJBEECDNC(OMMOOGKHFGK JHOOEMDNKAI, GJCFHGCFPIM ICJFJHAECPJ, AIAMAMPCJBI IJGDOPEJJDL, Action<NBOKCGGNGPN> LLJIIOBELND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x716C270", Offset = "0x716B270", VA = "0x18716C270")]
	public void PCHKFCLMCDK(NativeList<NBOKCGGNGPN> CIIFHFKPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x716C050", Offset = "0x716B050", VA = "0x18716C050")]
	private void IOFAIEFFMME(KNOFKBKFPEC LEKGDNFBAFN, NBOKCGGNGPN NJDPMMMABHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x716C210", Offset = "0x716B210", VA = "0x18716C210")]
	public void MEJBFHMKPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x716C5F0", Offset = "0x716B5F0", VA = "0x18716C5F0")]
	private void PGLIEMDCJCF(KNOFKBKFPEC LEKGDNFBAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x716C170", Offset = "0x716B170", VA = "0x18716C170")]
	private void JNMDIIOIMNP(KNOFKBKFPEC LEKGDNFBAFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HCLCMACKFGM(typeof(NFLLHLMDNFH), new string[] { })]
internal class PFDIDHMENHL : NFLLHLMDNFH, ALCJCBIJLHN, PPOPGKOBAOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[AJHKPBPNKHI]
	private GJCFHGCFPIM ICJFJHAECPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[AJHKPBPNKHI]
	private OMMOOGKHFGK JHOOEMDNKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[AJHKPBPNKHI]
	private AIAMAMPCJBI ECDHGKAAKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private AHOGLMHFNPF LCMLAHBGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private FNOEBANGBJI LLGFHBBLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<CLFJGNGILEC> HCANPBAIEHL;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7171A40", Offset = "0x7170A40", VA = "0x187171A40", Slot = "5")]
	public void InitReferences(CNIJJDNAGNG HFACFBNIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71723D0", Offset = "0x71713D0", VA = "0x1871723D0", Slot = "6")]
	public void NJPNJGFBGID(CNIJJDNAGNG HFACFBNIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7171960", Offset = "0x7170960", VA = "0x187171960", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7171EC0", Offset = "0x7170EC0", VA = "0x187171EC0", Slot = "4")]
	public void NBIEAFAFDFE(FNOEBANGBJI OEHJLMFHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7171E40", Offset = "0x7170E40", VA = "0x187171E40")]
	private void MGHJICMFEHO(FNOEBANGBJI OEHJLMFHHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7171780", Offset = "0x7170780", VA = "0x187171780")]
	private void CPHNGMIKHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7171AD0", Offset = "0x7170AD0", VA = "0x187171AD0")]
	private void LAGEHOHCCGL(NBOKCGGNGPN NJDPMMMABHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71727D0", Offset = "0x71717D0", VA = "0x1871727D0")]
	public PFDIDHMENHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal struct FEPGMFMOGAK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly GJCFHGCFPIM ICJFJHAECPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly List<FLKIJOBAAMB> OFKCPKAAIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeList<NBOKCGGNGPN> EFDBBENHKOG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NativeList<NBOKCGGNGPN> EDBDCIKKCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA76DE0", Offset = "0xA75DE0", VA = "0x180A76DE0")]
		get
		{
			return default(NativeList<NBOKCGGNGPN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x716E810", Offset = "0x716D810", VA = "0x18716E810")]
	public FEPGMFMOGAK(GJCFHGCFPIM ICJFJHAECPJ, List<FLKIJOBAAMB> OFKCPKAAIPA, NativeArray<NBOKCGGNGPN> CIIFHFKPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x716E160", Offset = "0x716D160", VA = "0x18716E160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x716E270", Offset = "0x716D270", VA = "0x18716E270")]
	private NativeList<NBOKCGGNGPN> KJKFHHNECFN(NativeArray<NBOKCGGNGPN> NLDJJPHOBJA)
	{
		return default(NativeList<NBOKCGGNGPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x716E1A0", Offset = "0x716D1A0", VA = "0x18716E1A0")]
	private bool GDOCOBDFKPB(FLKIJOBAAMB MGPNLFOOFIA, EPNLGHBGMGO EEEAGOCIPHD, int BJMBLNMHMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x716E660", Offset = "0x716D660", VA = "0x18716E660")]
	private void KLLEFMEFNAJ(FLKIJOBAAMB MGPNLFOOFIA, EPNLGHBGMGO FKPGAGKFCAH, int BJMBLNMHMOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HIGHABJMCHJ(0)]
internal class FCOPDELNEKO : PDAIEGKGKGC
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x716E070", Offset = "0x716D070", VA = "0x18716E070", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x716DFC0", Offset = "0x716CFC0", VA = "0x18716DFC0", Slot = "7")]
	public override bool BEHEGJNLOBN(Type DPPJBLOOGOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x716E120", Offset = "0x716D120", VA = "0x18716E120")]
	public FCOPDELNEKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class JFBCHBPBFJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NNAMIOBGBLI : IEnumerable<JMDPFBBINKM>, IEnumerable, IEnumerator<JMDPFBBINKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private JMDPFBBINKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public JFBCHBPBFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private long <key>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private NativeParallelMultiHashMap<long, int>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <index>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private JMDPFBBINKM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
		[DebuggerHidden]
		public NNAMIOBGBLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7170E30", Offset = "0x716FE30", VA = "0x187170E30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7170AC0", Offset = "0x716FAC0", VA = "0x187170AC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7170A70", Offset = "0x716FA70", VA = "0x187170A70")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7170DF0", Offset = "0x716FDF0", VA = "0x187170DF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7170D40", Offset = "0x716FD40", VA = "0x187170D40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JMDPFBBINKM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7170D40", Offset = "0x716FD40", VA = "0x187170D40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly GJCFHGCFPIM ICJFJHAECPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeParallelMultiHashMap<long, int> CFCIDHHLIMK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x716F710", Offset = "0x716E710", VA = "0x18716F710")]
	public JFBCHBPBFJD(GJCFHGCFPIM ICJFJHAECPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x716F530", Offset = "0x716E530", VA = "0x18716F530")]
	[IteratorStateMachine(typeof(NNAMIOBGBLI))]
	public IEnumerable<JMDPFBBINKM> HBOJEHFHAAG(Type DPPJBLOOGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x716F4F0", Offset = "0x716E4F0", VA = "0x18716F4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x716F600", Offset = "0x716E600", VA = "0x18716F600")]
	private long LHKIJFPJGGC(JMDPFBBINKM LDJJMGJLECK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x716F5C0", Offset = "0x716E5C0", VA = "0x18716F5C0")]
	private long LHKIJFPJGGC(Type DPPJBLOOGOO)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[KLBDHOMNNPJ(typeof(int))]
internal class IIKKDHBKCPI : JCCKAOCCJNI<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x716EEF0", Offset = "0x716DEF0", VA = "0x18716EEF0", Slot = "5")]
	public override void LAGEHOHCCGL(CLFJGNGILEC LDJJMGJLECK, AIAMAMPCJBI IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x716EF80", Offset = "0x716DF80", VA = "0x18716EF80")]
	public IIKKDHBKCPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal static class OIGCEIECKNO
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x71710C0", Offset = "0x71700C0", VA = "0x1871710C0")]
	public static void JFFBMODOGPP(Type DGHDBPPCGKJ, Type ILBNHFGAMKM)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Preserve]
	internal class _RRAssemblyIndex : AINCPJMNCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7172850", Offset = "0x7171850", VA = "0x187172850", Slot = "6")]
		public sealed override void GKPMAKNFHGI(NBHPPJJIFEO ELHFOIEJAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7172940", Offset = "0x7171940", VA = "0x187172940", Slot = "4")]
		public sealed override void KNBCGPCIENC()
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
