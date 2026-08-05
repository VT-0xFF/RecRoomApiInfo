using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x255B610", Offset = "0x255A210", VA = "0x18255B610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CBHCLJBKLKC : HJOMFIPJJDB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x255B550", Offset = "0x255A150", VA = "0x18255B550", Slot = "7")]
	public override string CNPDCBKGCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x255B5D0", Offset = "0x255A1D0", VA = "0x18255B5D0")]
	private CBHCLJBKLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x255B580", Offset = "0x255A180", VA = "0x18255B580")]
	public static CBHCLJBKLKC JPHABLICNHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LHFPJNNGEAB<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, FPMBHMHGPLM.PCMEJEFLEAD<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PCDHBIICBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] JPDFPAMKHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int MGDIKLENOFF;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF8D040", Offset = "0xF8BC40", VA = "0x180F8D040")]
		private PCDHBIICBAI(TPartialAction[] GOGMGECFMBL, int JMFBNNGELOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x503CAA0", Offset = "0x503B6A0", VA = "0x18503CAA0")]
		public static LHFPJNNGEAB<TPartialAction, TPartialActionId, TFullAction, TDeps>.PCDHBIICBAI JPHABLICNHB(int CIEEJGBHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x503C950", Offset = "0x503B550", VA = "0x18503C950")]
		public AKMEDOPOELG<TFullAction> GBAOCLOFLJD(TPartialAction DEHKJKCLMJL, TDeps CJMMHNIMOJB)
		{
			return default(AKMEDOPOELG<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, PCDHBIICBAI>? NFEJAOGKEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps IHDBCEJNIED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, PCDHBIICBAI> HEGHPCNIOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B338A0", Offset = "0x4B324A0", VA = "0x184B338A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B341A0", Offset = "0x4B32DA0", VA = "0x184B341A0")]
	private LHFPJNNGEAB(Dictionary<TPartialActionId, PCDHBIICBAI>? MIALMNAGMBP, TDeps CJMMHNIMOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B34090", Offset = "0x4B32C90", VA = "0x184B34090")]
	public static LHFPJNNGEAB<TPartialAction, TPartialActionId, TFullAction, TDeps> JPHABLICNHB(TDeps CJMMHNIMOJB)
	{
		return default(LHFPJNNGEAB<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B339A0", Offset = "0x4B325A0", VA = "0x184B339A0")]
	public PNJEPLMEKHI<AKMEDOPOELG<TFullAction>, GEJJJMKDLKA> GBAOCLOFLJD(TPartialAction DEHKJKCLMJL)
	{
		return default(PNJEPLMEKHI<AKMEDOPOELG<TFullAction>, GEJJJMKDLKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B340E0", Offset = "0x4B32CE0", VA = "0x184B340E0")]
	public void PHCJJAEAFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FPMBHMHGPLM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface PCMEJEFLEAD<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NJHCAOAABOI([In] TPartialAction DEHKJKCLMJL);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int MAGPJKEHBKB([In] TPartialAction DEHKJKCLMJL);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId GCJGMAADACK([In] TPartialAction DEHKJKCLMJL);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction BJIAJNGDFCM(TPartialAction[] CGCHHAGOMMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FDCKFAKAFJO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : FAMOFOFFPLI.CIKKDBIIHDP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] LPGNJCBHJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int FAOLLDDBMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps IHDBCEJNIED;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x438DC50", Offset = "0x438C850", VA = "0x18438DC50")]
	internal FDCKFAKAFJO(TPartialSnapshot[] ODLDAPCDKEH, int JGMKNHILALE, TDeps CJMMHNIMOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x438DBF0", Offset = "0x438C7F0", VA = "0x18438DBF0")]
	public static FDCKFAKAFJO<TPartialSnapshot, TFullSnapshot, TDeps> JPHABLICNHB(TDeps CJMMHNIMOJB)
	{
		return default(FDCKFAKAFJO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FAMOFOFFPLI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface CIKKDBIIHDP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KNCNCIDABJG([In] TPartialSnapshot OFBAKBPDANK);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot PHHLKIHLMEJ(TPartialSnapshot[] FECBGLIKLHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x334E390", Offset = "0x334CF90", VA = "0x18334E390")]
	public static AKMEDOPOELG<TFullSnapshot> GBAOCLOFLJD<TFullSnapshot, TPartialSnapshot, TDeps>(this FDCKFAKAFJO<TPartialSnapshot, TFullSnapshot, TDeps> DKGDAEBOJKO, TPartialSnapshot OFBAKBPDANK) where TDeps : CIKKDBIIHDP<TPartialSnapshot, TFullSnapshot>
	{
		return default(AKMEDOPOELG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x334E780", Offset = "0x334D380", VA = "0x18334E780")]
	public static bool JGBPGCHNGEF<TPartialSnapshot, TFullSnapshot, TDeps>(this FDCKFAKAFJO<TPartialSnapshot, TFullSnapshot, TDeps> DKGDAEBOJKO, TPartialSnapshot OFBAKBPDANK) where TDeps : CIKKDBIIHDP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class DFGPKGKBEMP : HJOMFIPJJDB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x255B5E0", Offset = "0x255A1E0", VA = "0x18255B5E0", Slot = "7")]
	public override string CNPDCBKGCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x255B5D0", Offset = "0x255A1D0", VA = "0x18255B5D0")]
	public DFGPKGKBEMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BPPKDLJHBML<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : CCLOFBBKKLB.HMFLNPMMBHB<TAction, TNetSys> where TReceiverDeps : CCLOFBBKKLB.LGLKAJIIEPN<TAction, TReceiver> where TRootDeps : CCLOFBBKKLB.HEHGDFCJDDG<TMRequest, TAction, TRoot> where TDeps : CCLOFBBKKLB.JPNDDEDPLGK<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface MPMKNJLEIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GHJOIDFHEPL([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LCEAJJFDMOI();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PNJEPLMEKHI<object, GEJJJMKDLKA> JHDCPIHLKKD();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OCAKOOJKKEN(Exception COMMOGJDAGN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class GDAMIAJEOLN : MPMKNJLEIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<PNJEPLMEKHI<object, GEJJJMKDLKA>> CEBDLEOMBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<PNJEPLMEKHI<object, PKJJHJMDMCJ>> DPBLDOEBLCN;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x44BED90", Offset = "0x44BD990", VA = "0x1844BED90")]
		private GDAMIAJEOLN(TaskCompletionSource<PNJEPLMEKHI<object, GEJJJMKDLKA>> IDGIFCDJBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x44BEA30", Offset = "0x44BD630", VA = "0x1844BEA30")]
		public static GDAMIAJEOLN JPHABLICNHB(TaskCompletionSource<PNJEPLMEKHI<object, GEJJJMKDLKA>> IDGIFCDJBBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x44BE690", Offset = "0x44BD290", VA = "0x1844BE690")]
		public void GHJOIDFHEPL([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x44BEBF0", Offset = "0x44BD7F0", VA = "0x1844BEBF0", Slot = "5")]
		public void LCEAJJFDMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x44BE8D0", Offset = "0x44BD4D0", VA = "0x1844BE8D0", Slot = "6")]
		public PNJEPLMEKHI<object, GEJJJMKDLKA> JHDCPIHLKKD()
		{
			return default(PNJEPLMEKHI<object, GEJJJMKDLKA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x44BECD0", Offset = "0x44BD8D0", VA = "0x1844BECD0", Slot = "7")]
		public void OCAKOOJKKEN(Exception COMMOGJDAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x44BE650", Offset = "0x44BD250", VA = "0x1844BE650", Slot = "4")]
		private void DLJOKKNAGNO([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class AKLKEOECFED : MPMKNJLEIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<PNJEPLMEKHI<object, GEJJJMKDLKA>> CEBDLEOMBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PNJEPLMEKHI<object, GEJJJMKDLKA> PHEFPLIDHHI;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
		private AKLKEOECFED(TaskCompletionSource<PNJEPLMEKHI<object, GEJJJMKDLKA>> IDGIFCDJBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x44BEA30", Offset = "0x44BD630", VA = "0x1844BEA30")]
		public static AKLKEOECFED JPHABLICNHB(TaskCompletionSource<PNJEPLMEKHI<object, GEJJJMKDLKA>> IDGIFCDJBBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4673640", Offset = "0x4672240", VA = "0x184673640")]
		public void GHJOIDFHEPL([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x46736C0", Offset = "0x46722C0", VA = "0x1846736C0", Slot = "5")]
		public void LCEAJJFDMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F30", Offset = "0xAA5B30", VA = "0x180AA6F30", Slot = "6")]
		public PNJEPLMEKHI<object, GEJJJMKDLKA> JHDCPIHLKKD()
		{
			return default(PNJEPLMEKHI<object, GEJJJMKDLKA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4673720", Offset = "0x4672320", VA = "0x184673720", Slot = "7")]
		public void OCAKOOJKKEN(Exception COMMOGJDAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x44BE650", Offset = "0x44BD250", VA = "0x1844BE650", Slot = "4")]
		private void DLJOKKNAGNO([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class ACGJNJJBCIB : MPMKNJLEIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<PNJEPLMEKHI<object, GEJJJMKDLKA>> DPBLDOEBLCN;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4543160", Offset = "0x4541D60", VA = "0x184543160")]
		private ACGJNJJBCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4542F60", Offset = "0x4541B60", VA = "0x184542F60")]
		public static ACGJNJJBCIB JPHABLICNHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4542CE0", Offset = "0x45418E0", VA = "0x184542CE0")]
		public void GHJOIDFHEPL([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void LCEAJJFDMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4542F00", Offset = "0x4541B00", VA = "0x184542F00", Slot = "6")]
		public PNJEPLMEKHI<object, GEJJJMKDLKA> JHDCPIHLKKD()
		{
			return default(PNJEPLMEKHI<object, GEJJJMKDLKA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4543080", Offset = "0x4541C80", VA = "0x184543080", Slot = "7")]
		[LDOMFOOMHLM("This may be terminal and should probably do more than discarding the exception.")]
		public void OCAKOOJKKEN(Exception COMMOGJDAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x44BE650", Offset = "0x44BD250", VA = "0x1844BE650", Slot = "4")]
		private void DLJOKKNAGNO([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HDDKLGEJELO : MPMKNJLEIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private PNJEPLMEKHI<object, GEJJJMKDLKA> PHEFPLIDHHI;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		private HDDKLGEJELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4542F60", Offset = "0x4541B60", VA = "0x184542F60")]
		public static HDDKLGEJELO JPHABLICNHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2076CD0", Offset = "0x20758D0", VA = "0x182076CD0")]
		public void GHJOIDFHEPL([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void LCEAJJFDMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAD8DC0", Offset = "0xAD79C0", VA = "0x180AD8DC0", Slot = "6")]
		public PNJEPLMEKHI<object, GEJJJMKDLKA> JHDCPIHLKKD()
		{
			return default(PNJEPLMEKHI<object, GEJJJMKDLKA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x458A830", Offset = "0x4589430", VA = "0x18458A830", Slot = "7")]
		[LDOMFOOMHLM("This may be terminal and should probably do more than discarding the exception.")]
		public void OCAKOOJKKEN(Exception COMMOGJDAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x44BE650", Offset = "0x44BD250", VA = "0x1844BE650", Slot = "4")]
		private void DLJOKKNAGNO([In] PNJEPLMEKHI<object, GEJJJMKDLKA> HBANOBDOKBJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KMDNKBLDPAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BPPKDLJHBML<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ENBGACDEBPI<PMFEOFKHFCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<PNJEPLMEKHI<object, GEJJJMKDLKA>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4A79530", Offset = "0x4A78130", VA = "0x184A79530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4A79FE0", Offset = "0x4A78BE0", VA = "0x184A79FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct MJOGDHFOMJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BPPKDLJHBML<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public ENBGACDEBPI<PMFEOFKHFCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4D77AB0", Offset = "0x4D766B0", VA = "0x184D77AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4D783B0", Offset = "0x4D76FB0", VA = "0x184D783B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NJGNJNEKFHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public BPPKDLJHBML<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public ENBGACDEBPI<PMFEOFKHFCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ENBGACDEBPI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4E07970", Offset = "0x4E06570", VA = "0x184E07970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4E07CE0", Offset = "0x4E068E0", VA = "0x184E07CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KKMAMOFIGFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public BPPKDLJHBML<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ENBGACDEBPI<PMFEOFKHFCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public ENBGACDEBPI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private MPMKNJLEIFB <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4A72A20", Offset = "0x4A71620", VA = "0x184A72A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4A736E0", Offset = "0x4A722E0", VA = "0x184A736E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HLNFBGHNLNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public BPPKDLJHBML<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public MPMKNJLEIFB completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private MPMKNJLEIFB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4630E20", Offset = "0x462FA20", VA = "0x184630E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4634FB0", Offset = "0x4633BB0", VA = "0x184634FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct EMFIJMIDMDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public BPPKDLJHBML<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public ENBGACDEBPI<PMFEOFKHFCA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3FEBC20", Offset = "0x3FEA820", VA = "0x183FEBC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC010", Offset = "0x3FEAC10", VA = "0x183FEC010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps IHDBCEJNIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<ENBGACDEBPI<TMRequest>, TaskCompletionSource<PNJEPLMEKHI<object, GEJJJMKDLKA>>> PKPGIMAOMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HOCPMLLICFB<TMRequest> MHGPOCGPEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool CMGDAKDAIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int OODFEAKOAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task KGMIAGCOBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int MGPEKILBAOK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps BBKOHEBGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5872B30", Offset = "0x5871730", VA = "0x185872B30")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps JJAPLPJJNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5870920", Offset = "0x586F520", VA = "0x185870920")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps NNBEEPNMHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x58727C0", Offset = "0x58713C0", VA = "0x1858727C0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NOKBLBOEDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBBB5E0", Offset = "0xBBA1E0", VA = "0x180BBB5E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBBAE80", Offset = "0xBB9A80", VA = "0x180BBAE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CELEGGKLAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x95B840", Offset = "0x95A440", VA = "0x18095B840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int KCMLAAAKMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9766D0", Offset = "0x9752D0", VA = "0x1809766D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5872E10", Offset = "0x5871A10", VA = "0x185872E10")]
	public BPPKDLJHBML(TDeps CJMMHNIMOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5871920", Offset = "0x5870520", VA = "0x185871920")]
	public Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> LGCLGCHDADD(TRoot EBMDCHEPJIM, TNetSys NPGHKIMDPBM, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, TAction OAGMINHECCA, bool HECHFLLKKPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5871D70", Offset = "0x5870970", VA = "0x185871D70")]
	[AsyncStateMachine(typeof(BPPKDLJHBML<, , , , , , , , >.KMDNKBLDPAD))]
	private Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> LGCLGCHDADD(TRoot EBMDCHEPJIM, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, TAction OAGMINHECCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x58709A0", Offset = "0x586F5A0", VA = "0x1858709A0")]
	[AsyncStateMachine(typeof(BPPKDLJHBML<, , , , , , , , >.MJOGDHFOMJI))]
	private Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> CIFABIHIMAA(TRoot EBMDCHEPJIM, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, TAction[] KMELAGHIBII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x58727F0", Offset = "0x58713F0", VA = "0x1858727F0")]
	[AsyncStateMachine(typeof(BPPKDLJHBML<, , , , , , , , >.NJGNJNEKFHK))]
	public Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> NABGEEFFHOC(TRoot EBMDCHEPJIM, TNetSys GDPAJOEKMAH, TReceiver JHNAPAEKPAE, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, ENBGACDEBPI<TMRequest> LJGCIGNLJBK, TAction OAGMINHECCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5870EF0", Offset = "0x586FAF0", VA = "0x185870EF0")]
	[AsyncStateMachine(typeof(BPPKDLJHBML<, , , , , , , , >.KKMAMOFIGFA))]
	private Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> HBMBGNBMHBH(TRoot EBMDCHEPJIM, TNetSys GDPAJOEKMAH, TReceiver JHNAPAEKPAE, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, ENBGACDEBPI<TMRequest> LJGCIGNLJBK, TAction OAGMINHECCA, Task KJHAGCNNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5872CC0", Offset = "0x58718C0", VA = "0x185872CC0")]
	[AsyncStateMachine(typeof(BPPKDLJHBML<, , , , , , , , >.HLNFBGHNLNH))]
	private Task PIDPGDGOBLG(TRoot EBMDCHEPJIM, TNetSys GDPAJOEKMAH, TReceiver JHNAPAEKPAE, TAction OAGMINHECCA, MPMKNJLEIFB NJCOGLEDHHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5872630", Offset = "0x5871230", VA = "0x185872630")]
	private void MEBLEOKGAHO(TReceiver JHNAPAEKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5871200", Offset = "0x586FE00", VA = "0x185871200")]
	private void JGAPLGHOLNO(TRoot EBMDCHEPJIM, TNetSys GDPAJOEKMAH, TReceiver JHNAPAEKPAE, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, TAction OAGMINHECCA, bool CECIHKILMNA, bool HHILCJGPMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5870DB0", Offset = "0x586F9B0", VA = "0x185870DB0")]
	[AsyncStateMachine(typeof(BPPKDLJHBML<, , , , , , , , >.EMFIJMIDMDD))]
	public Task DKNNNOCGGFB(TRoot EBMDCHEPJIM, TNetSys GDPAJOEKMAH, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, TAction[] ICNPLAMEKGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CCLOFBBKKLB
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface HMFLNPMMBHB<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IJGOECDICEF(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction ENHMENIGJDI(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction OGEEDEIGACF(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> CIIBNENFMJM(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] GHOHABIEJDC(TNetSys DLFCNPDKING, TAction OAGMINHECCA, int OOPCBFMOOEE);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CCBJHOMCCMD(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NGKDMKBHDIM(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IMGEKPKKHDJ(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool GOOJDNGELNA(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool BKOIPLLADNC(TNetSys DLFCNPDKING, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool OGKCEJLJKHM(TNetSys DLFCNPDKING, TAction OAGMINHECCA);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface JPNDDEDPLGK<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps BBKOHEBGHAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps NNBEEPNMHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps JJAPLPJJNBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface LGLKAJIIEPN<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ENBGACDEBPI<PMFEOFKHFCA> GJMNAILNJGA(TReceiver JHNAPAEKPAE);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IOHKGDAEKFH(TReceiver JHNAPAEKPAE);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> NABGEEFFHOC(TReceiver JHNAPAEKPAE, TAction OAGMINHECCA);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] HEHDFCFLGLM(TReceiver JHNAPAEKPAE);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface HEHGDFCJDDG<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DLLLCEIDKPB(TRoot EBMDCHEPJIM);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int HAMGFAOKCIA(TRoot EBMDCHEPJIM);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int GCHNKGHDJCM(TRoot EBMDCHEPJIM);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PENCGKIOFKE(TRoot EBMDCHEPJIM);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KHILMBPDKCO(TRoot EBMDCHEPJIM);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GOOAGDGBJPM(TRoot EBMDCHEPJIM, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, TAction[] KMELAGHIBII);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task LGCLGCHDADD(TRoot EBMDCHEPJIM, ENBGACDEBPI<PMFEOFKHFCA> KEJOCEPAGCK, ENBGACDEBPI<TMRequest> LJGCIGNLJBK, TAction OAGMINHECCA, bool GNFIBDDAILE = true);
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
