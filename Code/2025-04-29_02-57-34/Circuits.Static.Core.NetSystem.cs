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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x2721160", Offset = "0x2720560", VA = "0x182721160")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PADCCGKBOME : BCMJKIOOIBO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27211E0", Offset = "0x27205E0", VA = "0x1827211E0", Slot = "7")]
	public override string CPMOFLNCDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2721150", Offset = "0x2720550", VA = "0x182721150")]
	private PADCCGKBOME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2721210", Offset = "0x2720610", VA = "0x182721210")]
	public static PADCCGKBOME FABCCGGAHMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IBIKIEPHJIL<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, IGPHAPJJMCK.ECHECMPNIPL<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LBOACDBAKBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] FDBMPCHNMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int JBBCJCPDDNB;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1117350", Offset = "0x1116750", VA = "0x181117350")]
		private LBOACDBAKBJ(TPartialAction[] ADCEPKADCKP, int MPOIDBMPEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B700", Offset = "0x4E8AB00", VA = "0x184E8B700")]
		public static IBIKIEPHJIL<TPartialAction, TPartialActionId, TFullAction, TDeps>.LBOACDBAKBJ FABCCGGAHMJ(int OMIFGMJCODN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4E8B830", Offset = "0x4E8AC30", VA = "0x184E8B830")]
		public JCEPLOKMLCO<TFullAction> FCPEJJJJLFM(TPartialAction NHMLIICCBOF, TDeps BGLHIFBEGOD)
		{
			return default(JCEPLOKMLCO<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, LBOACDBAKBJ>? HMOBCPBIFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps DGDPNOACCCN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, LBOACDBAKBJ> ACIBHKBELNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4A46DC0", Offset = "0x4A461C0", VA = "0x184A46DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A46EC0", Offset = "0x4A462C0", VA = "0x184A46EC0")]
	private IBIKIEPHJIL(Dictionary<TPartialActionId, LBOACDBAKBJ>? IDGDCGNEMEB, TDeps BGLHIFBEGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A45D40", Offset = "0x4A45140", VA = "0x184A45D40")]
	public static IBIKIEPHJIL<TPartialAction, TPartialActionId, TFullAction, TDeps> FABCCGGAHMJ(TDeps BGLHIFBEGOD)
	{
		return default(IBIKIEPHJIL<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A45D90", Offset = "0x4A45190", VA = "0x184A45D90")]
	public BECHBBIPIFM<JCEPLOKMLCO<TFullAction>, FFKOEKDBPON> FCPEJJJJLFM(TPartialAction NHMLIICCBOF)
	{
		return default(BECHBBIPIFM<JCEPLOKMLCO<TFullAction>, FFKOEKDBPON>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A46D00", Offset = "0x4A46100", VA = "0x184A46D00")]
	public void HHEMCPDCJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IGPHAPJJMCK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ECHECMPNIPL<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DAPFEGNMAOL([In] TPartialAction NHMLIICCBOF);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int NOKGMIJHIHD([In] TPartialAction NHMLIICCBOF);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId GAPCOFLNMCD([In] TPartialAction NHMLIICCBOF);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction HDDHPOGAHPH(TPartialAction[] OMLJGBHCBHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BLCKOBFDCMD<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : FLADPBFHJKD.LLCPBBEMNEI<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] LGJAENGBONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int FDEOIONJGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps DGDPNOACCCN;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6078DC0", Offset = "0x60781C0", VA = "0x186078DC0")]
	internal BLCKOBFDCMD(TPartialSnapshot[] FBEPLFLEDFE, int FCPGFFKEDKA, TDeps BGLHIFBEGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6078CF0", Offset = "0x60780F0", VA = "0x186078CF0")]
	public static BLCKOBFDCMD<TPartialSnapshot, TFullSnapshot, TDeps> FABCCGGAHMJ(TDeps BGLHIFBEGOD)
	{
		return default(BLCKOBFDCMD<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FLADPBFHJKD
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LLCPBBEMNEI<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CPGADLGLFKB([In] TPartialSnapshot PHIAMLHMBEL);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot GGEACLDPBPM(TPartialSnapshot[] CCDAOIBKEJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3690C10", Offset = "0x3690010", VA = "0x183690C10")]
	public static JCEPLOKMLCO<TFullSnapshot> FCPEJJJJLFM<TFullSnapshot, TPartialSnapshot, TDeps>(this BLCKOBFDCMD<TPartialSnapshot, TFullSnapshot, TDeps> KBBJDOAJMAF, TPartialSnapshot PHIAMLHMBEL) where TDeps : LLCPBBEMNEI<TPartialSnapshot, TFullSnapshot>
	{
		return default(JCEPLOKMLCO<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3690AC0", Offset = "0x368FEC0", VA = "0x183690AC0")]
	public static bool BFFHELJDHLF<TPartialSnapshot, TFullSnapshot, TDeps>(this BLCKOBFDCMD<TPartialSnapshot, TFullSnapshot, TDeps> KBBJDOAJMAF, TPartialSnapshot PHIAMLHMBEL) where TDeps : LLCPBBEMNEI<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HALJMKEFAOB : BCMJKIOOIBO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2721120", Offset = "0x2720520", VA = "0x182721120", Slot = "7")]
	public override string CPMOFLNCDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2721150", Offset = "0x2720550", VA = "0x182721150")]
	public HALJMKEFAOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EACIBEBLPLM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FIOMGIHMKCL.KCPOPCNCDEG<TAction, TNetSys> where TReceiverDeps : FIOMGIHMKCL.AFCAGPJONCB<TAction, TReceiver> where TRootDeps : FIOMGIHMKCL.DHOFDEDMLBM<TMRequest, TAction, TRoot> where TDeps : FIOMGIHMKCL.DNHNBBMOOBA<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface FCMDCGKAFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KBMBJJHNCFN([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BGEAOGGPKMD();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BECHBBIPIFM<object, FFKOEKDBPON> CFKLDNMJEPB();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MNONPBKJAII(Exception CCEMNOMFFKG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class CGDAECIHLKI : FCMDCGKAFIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<BECHBBIPIFM<object, FFKOEKDBPON>> ALELNPKBMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<BECHBBIPIFM<object, HAPFLJDLPEC>> NKAJBCHDMJP;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6473830", Offset = "0x6472C30", VA = "0x186473830")]
		private CGDAECIHLKI(TaskCompletionSource<BECHBBIPIFM<object, FFKOEKDBPON>> CHBGNALCGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x48AE810", Offset = "0x48ADC10", VA = "0x1848AE810")]
		public static CGDAECIHLKI FABCCGGAHMJ(TaskCompletionSource<BECHBBIPIFM<object, FFKOEKDBPON>> CHBGNALCGDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6473530", Offset = "0x6472930", VA = "0x186473530")]
		public void KBMBJJHNCFN([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x64732F0", Offset = "0x64726F0", VA = "0x1864732F0", Slot = "5")]
		public void BGEAOGGPKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6473480", Offset = "0x6472880", VA = "0x186473480", Slot = "6")]
		public BECHBBIPIFM<object, FFKOEKDBPON> CFKLDNMJEPB()
		{
			return default(BECHBBIPIFM<object, FFKOEKDBPON>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x64737D0", Offset = "0x6472BD0", VA = "0x1864737D0", Slot = "7")]
		public void MNONPBKJAII(Exception CCEMNOMFFKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43AA570", Offset = "0x43A9970", VA = "0x1843AA570", Slot = "4")]
		private void GPJLMPICJHM([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class IGDECABOHGN : FCMDCGKAFIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<BECHBBIPIFM<object, FFKOEKDBPON>> ALELNPKBMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private BECHBBIPIFM<object, FFKOEKDBPON> KBNCDCAMGMM;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
		private IGDECABOHGN(TaskCompletionSource<BECHBBIPIFM<object, FFKOEKDBPON>> CHBGNALCGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x48AE810", Offset = "0x48ADC10", VA = "0x1848AE810")]
		public static IGDECABOHGN FABCCGGAHMJ(TaskCompletionSource<BECHBBIPIFM<object, FFKOEKDBPON>> CHBGNALCGDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD74870", Offset = "0xD73C70", VA = "0x180D74870")]
		public void KBMBJJHNCFN([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4A542F0", Offset = "0x4A536F0", VA = "0x184A542F0", Slot = "5")]
		public void BGEAOGGPKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBD93B0", Offset = "0xBD87B0", VA = "0x180BD93B0", Slot = "6")]
		public BECHBBIPIFM<object, FFKOEKDBPON> CFKLDNMJEPB()
		{
			return default(BECHBBIPIFM<object, FFKOEKDBPON>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4A54350", Offset = "0x4A53750", VA = "0x184A54350", Slot = "7")]
		public void MNONPBKJAII(Exception CCEMNOMFFKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x43AA570", Offset = "0x43A9970", VA = "0x1843AA570", Slot = "4")]
		private void GPJLMPICJHM([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AGAONCKJOGA : FCMDCGKAFIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<BECHBBIPIFM<object, FFKOEKDBPON>> NKAJBCHDMJP;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4BB7790", Offset = "0x4BB6B90", VA = "0x184BB7790")]
		private AGAONCKJOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x43AA4A0", Offset = "0x43A98A0", VA = "0x1843AA4A0")]
		public static AGAONCKJOGA FABCCGGAHMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4BB74A0", Offset = "0x4BB68A0", VA = "0x184BB74A0")]
		public void KBMBJJHNCFN([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void BGEAOGGPKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4BB73E0", Offset = "0x4BB67E0", VA = "0x184BB73E0", Slot = "6")]
		public BECHBBIPIFM<object, FFKOEKDBPON> CFKLDNMJEPB()
		{
			return default(BECHBBIPIFM<object, FFKOEKDBPON>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4BB76B0", Offset = "0x4BB6AB0", VA = "0x184BB76B0", Slot = "7")]
		[CBPMGKHNHGF("This may be terminal and should probably do more than discarding the exception.")]
		public void MNONPBKJAII(Exception CCEMNOMFFKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x43AA570", Offset = "0x43A9970", VA = "0x1843AA570", Slot = "4")]
		private void GPJLMPICJHM([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class EIOKKOFFDOE : FCMDCGKAFIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private BECHBBIPIFM<object, FFKOEKDBPON> KBNCDCAMGMM;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		private EIOKKOFFDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x43AA4A0", Offset = "0x43A98A0", VA = "0x1843AA4A0")]
		public static EIOKKOFFDOE FABCCGGAHMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2293550", Offset = "0x2292950", VA = "0x182293550")]
		public void KBMBJJHNCFN([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void BGEAOGGPKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0", Slot = "6")]
		public BECHBBIPIFM<object, FFKOEKDBPON> CFKLDNMJEPB()
		{
			return default(BECHBBIPIFM<object, FFKOEKDBPON>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x43AA600", Offset = "0x43A9A00", VA = "0x1843AA600", Slot = "7")]
		[CBPMGKHNHGF("This may be terminal and should probably do more than discarding the exception.")]
		public void MNONPBKJAII(Exception CCEMNOMFFKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x43AA570", Offset = "0x43A9970", VA = "0x1843AA570", Slot = "4")]
		private void GPJLMPICJHM([In] BECHBBIPIFM<object, FFKOEKDBPON> APLCGCDLEGH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct LPKEKOICDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EACIBEBLPLM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JHLAGGIINPD<FFKEAHELAHD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<BECHBBIPIFM<object, FFKOEKDBPON>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4ED60F0", Offset = "0x4ED54F0", VA = "0x184ED60F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6C10", Offset = "0x4ED6010", VA = "0x184ED6C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct DDGDBEIECIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public EACIBEBLPLM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JHLAGGIINPD<FFKEAHELAHD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6885030", Offset = "0x6884430", VA = "0x186885030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6885930", Offset = "0x6884D30", VA = "0x186885930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KIDFMLAKDAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public EACIBEBLPLM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JHLAGGIINPD<FFKEAHELAHD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public JHLAGGIINPD<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4DF4E10", Offset = "0x4DF4210", VA = "0x184DF4E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4DF5200", Offset = "0x4DF4600", VA = "0x184DF5200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct PIIIJCLLICJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public EACIBEBLPLM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JHLAGGIINPD<FFKEAHELAHD> senderId;

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
		public JHLAGGIINPD<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private FCMDCGKAFIN <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x54A54F0", Offset = "0x54A48F0", VA = "0x1854A54F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x54A6F90", Offset = "0x54A6390", VA = "0x1854A6F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BMDJHHPNDPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EACIBEBLPLM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FCMDCGKAFIN completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FCMDCGKAFIN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<BECHBBIPIFM<object?, FFKOEKDBPON>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6080520", Offset = "0x607F920", VA = "0x186080520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6082410", Offset = "0x6081810", VA = "0x186082410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct OCBHBBCGFCD : IAsyncStateMachine
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
		public EACIBEBLPLM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JHLAGGIINPD<FFKEAHELAHD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5330510", Offset = "0x532F910", VA = "0x185330510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5330C00", Offset = "0x5330000", VA = "0x185330C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps DGDPNOACCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<JHLAGGIINPD<TMRequest>, TaskCompletionSource<BECHBBIPIFM<object, FFKOEKDBPON>>> PDCEHLNONJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BALCNHBCGCF<TMRequest> PJPCCPCNGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BIFNJFDMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int HMMCLPEIEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task MAOGLCOGIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int OBFKCAJCFBJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps JOKICLLEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x437D940", Offset = "0x437CD40", VA = "0x18437D940")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps MONCLJGHPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x437D610", Offset = "0x437CA10", VA = "0x18437D610")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps IOKJHCFCLIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x437F120", Offset = "0x437E520", VA = "0x18437F120")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JKIEOFLJFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xCE78D0", Offset = "0xCE6CD0", VA = "0x180CE78D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCE74F0", Offset = "0xCE68F0", VA = "0x180CE74F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MIBEOFMGANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCD0", Offset = "0x9CF0D0", VA = "0x1809CFCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int AMEGGLGNEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9E8570", Offset = "0x9E7970", VA = "0x1809E8570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x437FA20", Offset = "0x437EE20", VA = "0x18437FA20")]
	public EACIBEBLPLM(TDeps BGLHIFBEGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x437EC80", Offset = "0x437E080", VA = "0x18437EC80")]
	public Task<BECHBBIPIFM<object, FFKOEKDBPON>> HBAEHBBEEFK(TRoot DGFFJNKGDJD, TNetSys MPMCOICPJEN, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, TAction PDHMHKIHKPF, bool HCKGLDGPPOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x437E3B0", Offset = "0x437D7B0", VA = "0x18437E3B0")]
	[AsyncStateMachine(typeof(EACIBEBLPLM<, , , , , , , , >.LPKEKOICDMF))]
	private Task<BECHBBIPIFM<object, FFKOEKDBPON>> HBAEHBBEEFK(TRoot DGFFJNKGDJD, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, TAction PDHMHKIHKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x437D9C0", Offset = "0x437CDC0", VA = "0x18437D9C0")]
	[AsyncStateMachine(typeof(EACIBEBLPLM<, , , , , , , , >.DDGDBEIECIN))]
	private Task<BECHBBIPIFM<object, FFKOEKDBPON>> EKNIANMNODJ(TRoot DGFFJNKGDJD, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, TAction[] BJHPHPBLMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x437F150", Offset = "0x437E550", VA = "0x18437F150")]
	[AsyncStateMachine(typeof(EACIBEBLPLM<, , , , , , , , >.KIDFMLAKDAL))]
	public Task<BECHBBIPIFM<object, FFKOEKDBPON>> KNJOFGLIDKC(TRoot DGFFJNKGDJD, TNetSys LONBIICBEKP, TReceiver JKOBGLOJMAJ, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, JHLAGGIINPD<TMRequest> KPPBBAKFPGO, TAction PDHMHKIHKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x437F5D0", Offset = "0x437E9D0", VA = "0x18437F5D0")]
	[AsyncStateMachine(typeof(EACIBEBLPLM<, , , , , , , , >.PIIIJCLLICJ))]
	private Task<BECHBBIPIFM<object, FFKOEKDBPON>> MGNGILGFNIH(TRoot DGFFJNKGDJD, TNetSys LONBIICBEKP, TReceiver JKOBGLOJMAJ, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, JHLAGGIINPD<TMRequest> KPPBBAKFPGO, TAction PDHMHKIHKPF, Task OJHHLGOCELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x437D690", Offset = "0x437CA90", VA = "0x18437D690")]
	[AsyncStateMachine(typeof(EACIBEBLPLM<, , , , , , , , >.BMDJHHPNDPM))]
	private Task CJLMAHJPBIF(TRoot DGFFJNKGDJD, TNetSys LONBIICBEKP, TReceiver JKOBGLOJMAJ, TAction PDHMHKIHKPF, FCMDCGKAFIN BBEJBPOCNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x437F800", Offset = "0x437EC00", VA = "0x18437F800")]
	private void MPIBFJENHPB(TReceiver JKOBGLOJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x437DC80", Offset = "0x437D080", VA = "0x18437DC80")]
	private void FHBPHCENOLK(TRoot DGFFJNKGDJD, TNetSys LONBIICBEKP, TReceiver JKOBGLOJMAJ, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, TAction PDHMHKIHKPF, bool PKDBOEDHHEE, bool EDIAFHPHKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x437D380", Offset = "0x437C780", VA = "0x18437D380")]
	[AsyncStateMachine(typeof(EACIBEBLPLM<, , , , , , , , >.OCBHBBCGFCD))]
	public Task BCDLJKHHFLI(TRoot DGFFJNKGDJD, TNetSys LONBIICBEKP, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, TAction[] BCJPIELKCPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FIOMGIHMKCL
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface KCPOPCNCDEG<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ENHCPDBNFOG(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction CAPMJHFNDJN(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction DGEEHBBAMMH(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> KJHINEIAANH(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] IGAJMCBOMAG(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF, int PMDHKOOLGDN);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HLOPEPBBFMP(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KPPINIILGHF(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool JNDBCHGEMJO(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool ACLODAKJLCL(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FCAHJNPGMCE(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool OBBFMODNIKD(TNetSys DJDKBDCCAEC, TAction PDHMHKIHKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface DNHNBBMOOBA<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps JOKICLLEHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps IOKJHCFCLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps MONCLJGHPKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface AFCAGPJONCB<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JHLAGGIINPD<FFKEAHELAHD> CIKBMOFEDKC(TReceiver JKOBGLOJMAJ);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HPGFEOBNAML(TReceiver JKOBGLOJMAJ);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<BECHBBIPIFM<object, FFKOEKDBPON>> KNJOFGLIDKC(TReceiver JKOBGLOJMAJ, TAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] IMJBGFPGEFI(TReceiver JKOBGLOJMAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface DHOFDEDMLBM<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LCBDEAGLLKP(TRoot DGFFJNKGDJD);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LIBPJHDCOHF(TRoot DGFFJNKGDJD);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BCHENOIBMBD(TRoot DGFFJNKGDJD);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DNDCINFOAPE(TRoot DGFFJNKGDJD);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PGLPKELNHEG(TRoot DGFFJNKGDJD);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OGLJBLNAEGL(TRoot DGFFJNKGDJD, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, TAction[] BJHPHPBLMDP);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task HBAEHBBEEFK(TRoot DGFFJNKGDJD, JHLAGGIINPD<FFKEAHELAHD> CGMMAEHGDNB, JHLAGGIINPD<TMRequest> KPPBBAKFPGO, TAction PDHMHKIHKPF, bool ABKCKFCBGEK = true);
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
