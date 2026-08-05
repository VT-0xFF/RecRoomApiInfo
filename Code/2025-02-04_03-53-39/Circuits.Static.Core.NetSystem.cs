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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2557740", Offset = "0x2556540", VA = "0x182557740")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BLAOBJCLPPD : NPDJLDEDKNL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2557680", Offset = "0x2556480", VA = "0x182557680", Slot = "7")]
	public override string KMIKCFPGPHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2557700", Offset = "0x2556500", VA = "0x182557700")]
	private BLAOBJCLPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25576B0", Offset = "0x25564B0", VA = "0x1825576B0")]
	public static BLAOBJCLPPD MKHEJJEDOII()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HAMCBEKBCDB<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, CDBGEGGDAGG.FIMOJLPOEKL<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EJGNJAJFHFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] OJOCCDPNOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int KDMAAOILJNA;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xFB9DC0", Offset = "0xFB8BC0", VA = "0x180FB9DC0")]
		private EJGNJAJFHFF(TPartialAction[] JPBIEMDPONL, int FONCDPKDDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2D30", Offset = "0x3FF1B30", VA = "0x183FF2D30")]
		public static HAMCBEKBCDB<TPartialAction, TPartialActionId, TFullAction, TDeps>.EJGNJAJFHFF MKHEJJEDOII(int NDIAFIACNOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2B10", Offset = "0x3FF1910", VA = "0x183FF2B10")]
		public HHLFAFFGDEG<TFullAction> HMNBLMEFDCP(TPartialAction NEHEDNNDNFI, TDeps FLOGLGIGMAI)
		{
			return default(HHLFAFFGDEG<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, EJGNJAJFHFF>? HNFELFGGACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps IKKBNFCGFBJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, EJGNJAJFHFF> IMIFPMLPIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x454D7C0", Offset = "0x454C5C0", VA = "0x18454D7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
	private HAMCBEKBCDB(Dictionary<TPartialActionId, EJGNJAJFHFF>? DJIPHHNMIML, TDeps FLOGLGIGMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x454E830", Offset = "0x454D630", VA = "0x18454E830")]
	public static HAMCBEKBCDB<TPartialAction, TPartialActionId, TFullAction, TDeps> MKHEJJEDOII(TDeps FLOGLGIGMAI)
	{
		return default(HAMCBEKBCDB<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x454E010", Offset = "0x454CE10", VA = "0x18454E010")]
	public PGOLMGNGGBM<HHLFAFFGDEG<TFullAction>, HJBBDBHAMJJ> HMNBLMEFDCP(TPartialAction NEHEDNNDNFI)
	{
		return default(PGOLMGNGGBM<HHLFAFFGDEG<TFullAction>, HJBBDBHAMJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x454D8B0", Offset = "0x454C6B0", VA = "0x18454D8B0")]
	public void FKDOLBBAHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CDBGEGGDAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FIMOJLPOEKL<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JMOOMJKNOLJ([In] TPartialAction NEHEDNNDNFI);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int NPINCEPMNCH([In] TPartialAction NEHEDNNDNFI);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId OBHNMLAKEMI([In] TPartialAction NEHEDNNDNFI);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction FLNKCLLLGCA(TPartialAction[] JJABPPNKPEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BOKLDJDKJNN<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : LMACLINOOPB.LMAGJFJLIKM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] CCOANGPCEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int NCIKKLKGGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps IKKBNFCGFBJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x568E100", Offset = "0x568CF00", VA = "0x18568E100")]
	internal BOKLDJDKJNN(TPartialSnapshot[] IENIBEFIJDE, int POIFMOOGAKL, TDeps FLOGLGIGMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x568E030", Offset = "0x568CE30", VA = "0x18568E030")]
	public static BOKLDJDKJNN<TPartialSnapshot, TFullSnapshot, TDeps> MKHEJJEDOII(TDeps FLOGLGIGMAI)
	{
		return default(BOKLDJDKJNN<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LMACLINOOPB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LMAGJFJLIKM<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ODMKFJLMJBM([In] TPartialSnapshot JLODLPOJJEB);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot AABIHFJCAIM(TPartialSnapshot[] JLEOJFBODJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x33AE3D0", Offset = "0x33AD1D0", VA = "0x1833AE3D0")]
	public static HHLFAFFGDEG<TFullSnapshot> HMNBLMEFDCP<TFullSnapshot, TPartialSnapshot, TDeps>(this BOKLDJDKJNN<TPartialSnapshot, TFullSnapshot, TDeps> DJAJDIFOIHP, TPartialSnapshot JLODLPOJJEB) where TDeps : LMAGJFJLIKM<TPartialSnapshot, TFullSnapshot>
	{
		return default(HHLFAFFGDEG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x33AE290", Offset = "0x33AD090", VA = "0x1833AE290")]
	public static bool FJMPGKGLFAC<TPartialSnapshot, TFullSnapshot, TDeps>(this BOKLDJDKJNN<TPartialSnapshot, TFullSnapshot, TDeps> DJAJDIFOIHP, TPartialSnapshot JLODLPOJJEB) where TDeps : LMAGJFJLIKM<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class EFBPAGLGNOO : NPDJLDEDKNL
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2557710", Offset = "0x2556510", VA = "0x182557710", Slot = "7")]
	public override string KMIKCFPGPHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2557700", Offset = "0x2556500", VA = "0x182557700")]
	public EFBPAGLGNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KHPLJKHBKEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : PKBKOICGLPG.IKLIGLDOJCC<TAction, TNetSys> where TReceiverDeps : PKBKOICGLPG.HCFGEHFHCHL<TAction, TReceiver> where TRootDeps : PKBKOICGLPG.LMIDCNIAMJG<TMRequest, TAction, TRoot> where TDeps : PKBKOICGLPG.KJEMDEMCLEP<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface DOIDPOHKHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OHMPIGNMBME([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GKPPBKPFHOC();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PGOLMGNGGBM<object, HJBBDBHAMJJ> EJPOIPILCMG();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ABPOFEEDPLE(Exception JGLOLGKKBMI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class PHLHMCFDAFA : DOIDPOHKHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<PGOLMGNGGBM<object, HJBBDBHAMJJ>> CADJPICJHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<PGOLMGNGGBM<object, EOABGNINGBC>> OEKEALFGMCO;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4F23840", Offset = "0x4F22640", VA = "0x184F23840")]
		private PHLHMCFDAFA(TaskCompletionSource<PGOLMGNGGBM<object, HJBBDBHAMJJ>> FCHHBDBKHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x454F180", Offset = "0x454DF80", VA = "0x18454F180")]
		public static PHLHMCFDAFA MKHEJJEDOII(TaskCompletionSource<PGOLMGNGGBM<object, HJBBDBHAMJJ>> FCHHBDBKHLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4F23600", Offset = "0x4F22400", VA = "0x184F23600")]
		public void OHMPIGNMBME([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4F23440", Offset = "0x4F22240", VA = "0x184F23440", Slot = "5")]
		public void GKPPBKPFHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4F232E0", Offset = "0x4F220E0", VA = "0x184F232E0", Slot = "6")]
		public PGOLMGNGGBM<object, HJBBDBHAMJJ> EJPOIPILCMG()
		{
			return default(PGOLMGNGGBM<object, HJBBDBHAMJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4F23220", Offset = "0x4F22020", VA = "0x184F23220", Slot = "7")]
		public void ABPOFEEDPLE(Exception JGLOLGKKBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43D6750", Offset = "0x43D5550", VA = "0x1843D6750", Slot = "4")]
		private void OIEKDNDAFKG([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class HBABODHDJPF : DOIDPOHKHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<PGOLMGNGGBM<object, HJBBDBHAMJJ>> CADJPICJHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PGOLMGNGGBM<object, HJBBDBHAMJJ> KPJJFLCIPLE;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
		private HBABODHDJPF(TaskCompletionSource<PGOLMGNGGBM<object, HJBBDBHAMJJ>> FCHHBDBKHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x454F180", Offset = "0x454DF80", VA = "0x18454F180")]
		public static HBABODHDJPF MKHEJJEDOII(TaskCompletionSource<PGOLMGNGGBM<object, HJBBDBHAMJJ>> FCHHBDBKHLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x454F250", Offset = "0x454E050", VA = "0x18454F250")]
		public void OHMPIGNMBME([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x454F120", Offset = "0x454DF20", VA = "0x18454F120", Slot = "5")]
		public void GKPPBKPFHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xACB760", Offset = "0xACA560", VA = "0x180ACB760", Slot = "6")]
		public PGOLMGNGGBM<object, HJBBDBHAMJJ> EJPOIPILCMG()
		{
			return default(PGOLMGNGGBM<object, HJBBDBHAMJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x454F060", Offset = "0x454DE60", VA = "0x18454F060", Slot = "7")]
		public void ABPOFEEDPLE(Exception JGLOLGKKBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x43D6750", Offset = "0x43D5550", VA = "0x1843D6750", Slot = "4")]
		private void OIEKDNDAFKG([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BLFPKPIAOFE : DOIDPOHKHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<PGOLMGNGGBM<object, HJBBDBHAMJJ>> OEKEALFGMCO;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x567A6F0", Offset = "0x56794F0", VA = "0x18567A6F0")]
		private BLFPKPIAOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x43D6690", Offset = "0x43D5490", VA = "0x1843D6690")]
		public static BLFPKPIAOFE MKHEJJEDOII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x567A580", Offset = "0x5679380", VA = "0x18567A580")]
		public void OHMPIGNMBME([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void GKPPBKPFHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x567A440", Offset = "0x5679240", VA = "0x18567A440", Slot = "6")]
		public PGOLMGNGGBM<object, HJBBDBHAMJJ> EJPOIPILCMG()
		{
			return default(PGOLMGNGGBM<object, HJBBDBHAMJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x567A390", Offset = "0x5679190", VA = "0x18567A390", Slot = "7")]
		[OLBEHBOLMGB("This may be terminal and should probably do more than discarding the exception.")]
		public void ABPOFEEDPLE(Exception JGLOLGKKBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x43D6750", Offset = "0x43D5550", VA = "0x1843D6750", Slot = "4")]
		private void OIEKDNDAFKG([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class FPFABLGAONN : DOIDPOHKHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private PGOLMGNGGBM<object, HJBBDBHAMJJ> KPJJFLCIPLE;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		private FPFABLGAONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x43D6690", Offset = "0x43D5490", VA = "0x1843D6690")]
		public static FPFABLGAONN MKHEJJEDOII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x208D520", Offset = "0x208C320", VA = "0x18208D520")]
		public void OHMPIGNMBME([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void GKPPBKPFHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB21E50", Offset = "0xB20C50", VA = "0x180B21E50", Slot = "6")]
		public PGOLMGNGGBM<object, HJBBDBHAMJJ> EJPOIPILCMG()
		{
			return default(PGOLMGNGGBM<object, HJBBDBHAMJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x43D65F0", Offset = "0x43D53F0", VA = "0x1843D65F0", Slot = "7")]
		[OLBEHBOLMGB("This may be terminal and should probably do more than discarding the exception.")]
		public void ABPOFEEDPLE(Exception JGLOLGKKBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x43D6750", Offset = "0x43D5550", VA = "0x1843D6750", Slot = "4")]
		private void OIEKDNDAFKG([In] PGOLMGNGGBM<object, HJBBDBHAMJJ> LDEANEOLAOA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KHFCLGDJAHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KHPLJKHBKEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MMBOLDIBAHF<DLLCOFBGKPH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x49B3E70", Offset = "0x49B2C70", VA = "0x1849B3E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x49B48D0", Offset = "0x49B36D0", VA = "0x1849B48D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GJDOCKLJDKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KHPLJKHBKEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MMBOLDIBAHF<DLLCOFBGKPH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x44C8F00", Offset = "0x44C7D00", VA = "0x1844C8F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x44C97C0", Offset = "0x44C85C0", VA = "0x1844C97C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LMEKAHGFGDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public KHPLJKHBKEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MMBOLDIBAHF<DLLCOFBGKPH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public MMBOLDIBAHF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4AAAF40", Offset = "0x4AA9D40", VA = "0x184AAAF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4AAB320", Offset = "0x4AAA120", VA = "0x184AAB320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct EIEONEBONOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public KHPLJKHBKEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MMBOLDIBAHF<DLLCOFBGKPH> senderId;

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
		public MMBOLDIBAHF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private DOIDPOHKHLH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3FE15A0", Offset = "0x3FE03A0", VA = "0x183FE15A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2F80", Offset = "0x3FE1D80", VA = "0x183FE2F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MEBKFLLGMDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KHPLJKHBKEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public DOIDPOHKHLH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private DOIDPOHKHLH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4C900C0", Offset = "0x4C8EEC0", VA = "0x184C900C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4C94080", Offset = "0x4C92E80", VA = "0x184C94080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GIMEFAHMJEO : IAsyncStateMachine
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
		public KHPLJKHBKEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public MMBOLDIBAHF<DLLCOFBGKPH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x44C6830", Offset = "0x44C5630", VA = "0x1844C6830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x44C6C10", Offset = "0x44C5A10", VA = "0x1844C6C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps IKKBNFCGFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<MMBOLDIBAHF<TMRequest>, TaskCompletionSource<PGOLMGNGGBM<object, HJBBDBHAMJJ>>> EODPGBNLGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LCCALJNBLCJ<TMRequest> KPJLNOFOFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool PABFACDPIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int ONPCENNAMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task LMEDBCENGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int OHCMHGPOIKL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps EMPIMJJIAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x49BBA20", Offset = "0x49BA820", VA = "0x1849BBA20")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps FNINDPNEOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x49BBA50", Offset = "0x49BA850", VA = "0x1849BBA50")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps JOLCOHDBIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x49BBD80", Offset = "0x49BAB80", VA = "0x1849BBD80")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LBDCIHIOLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBD7AC0", Offset = "0xBD68C0", VA = "0x180BD7AC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBD78E0", Offset = "0xBD66E0", VA = "0x180BD78E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MPIMKCGIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F70", Offset = "0x8F7D70", VA = "0x1808F8F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PADEPEKFAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x914100", Offset = "0x912F00", VA = "0x180914100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x49BC0E0", Offset = "0x49BAEE0", VA = "0x1849BC0E0")]
	public KHPLJKHBKEP(TDeps FLOGLGIGMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x49B9E20", Offset = "0x49B8C20", VA = "0x1849B9E20")]
	public Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> ACKOFINFMNH(TRoot DOJENPPADJD, TNetSys KELKFJFEOIO, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, TAction OOCJAOHFGJK, bool EAJAGGAKOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x49BA940", Offset = "0x49B9740", VA = "0x1849BA940")]
	[AsyncStateMachine(typeof(KHPLJKHBKEP<, , , , , , , , >.KHFCLGDJAHK))]
	private Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> ACKOFINFMNH(TRoot DOJENPPADJD, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, TAction OOCJAOHFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x49BAF10", Offset = "0x49B9D10", VA = "0x1849BAF10")]
	[AsyncStateMachine(typeof(KHPLJKHBKEP<, , , , , , , , >.GJDOCKLJDKP))]
	private Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> DCNICMDBAIP(TRoot DOJENPPADJD, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, TAction[] KIJMGDBLMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x49BBF70", Offset = "0x49BAD70", VA = "0x1849BBF70")]
	[AsyncStateMachine(typeof(KHPLJKHBKEP<, , , , , , , , >.LMEKAHGFGDN))]
	public Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> ONPJOOFLLCF(TRoot DOJENPPADJD, TNetSys MKAOBDIMMIK, TReceiver MGPKLMAHHGI, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, MMBOLDIBAHF<TMRequest> JLPMMGLNOMC, TAction OOCJAOHFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x49BAC30", Offset = "0x49B9A30", VA = "0x1849BAC30")]
	[AsyncStateMachine(typeof(KHPLJKHBKEP<, , , , , , , , >.EIEONEBONOL))]
	private Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> BMFJNJPNMJE(TRoot DOJENPPADJD, TNetSys MKAOBDIMMIK, TReceiver MGPKLMAHHGI, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, MMBOLDIBAHF<TMRequest> JLPMMGLNOMC, TAction OOCJAOHFGJK, Task BMHOEOHIJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x49BBAD0", Offset = "0x49BA8D0", VA = "0x1849BBAD0")]
	[AsyncStateMachine(typeof(KHPLJKHBKEP<, , , , , , , , >.MEBKFLLGMDH))]
	private Task NPKNLPBPPKB(TRoot DOJENPPADJD, TNetSys MKAOBDIMMIK, TReceiver MGPKLMAHHGI, TAction OOCJAOHFGJK, DOIDPOHKHLH PNMEEKDGPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x49B9CF0", Offset = "0x49B8AF0", VA = "0x1849B9CF0")]
	private void ACGBHJIMMLN(TReceiver MGPKLMAHHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49BB710", Offset = "0x49BA510", VA = "0x1849BB710")]
	private void GOIFPHBJLGG(TRoot DOJENPPADJD, TNetSys MKAOBDIMMIK, TReceiver MGPKLMAHHGI, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, TAction OOCJAOHFGJK, bool DKEKINEJDNI, bool INMKADBPNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49BB1C0", Offset = "0x49B9FC0", VA = "0x1849BB1C0")]
	[AsyncStateMachine(typeof(KHPLJKHBKEP<, , , , , , , , >.GIMEFAHMJEO))]
	public Task FLEPGDGMLLH(TRoot DOJENPPADJD, TNetSys MKAOBDIMMIK, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, TAction[] FMGFGBFCPMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PKBKOICGLPG
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface IKLIGLDOJCC<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DEBMIBJOFMK(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction JAEKGBCJMIF(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction ELCKMBOOJCJ(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> GLOKJGIJMMF(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] DDLOGMMOPEG(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK, int IPMFBIMMKJJ);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KEMADKAECGN(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LLLBAKLNHEH(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BLHBADOEFBD(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool FGDENCMJAHN(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool MOBNDCHJCAA(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BKIAIGMGPEN(TNetSys NJKIHEOCFHI, TAction OOCJAOHFGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface KJEMDEMCLEP<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps EMPIMJJIAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps JOLCOHDBIPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps FNINDPNEOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface HCFGEHFHCHL<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MMBOLDIBAHF<DLLCOFBGKPH> GBJBJFFDJPF(TReceiver MGPKLMAHHGI);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OPOCFLDMAIC(TReceiver MGPKLMAHHGI);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> ONPJOOFLLCF(TReceiver MGPKLMAHHGI, TAction OOCJAOHFGJK);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] AFMMAIKNACH(TReceiver MGPKLMAHHGI);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface LMIDCNIAMJG<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HDBHPPNAJBJ(TRoot DOJENPPADJD);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int DDJNNJNABDA(TRoot DOJENPPADJD);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int AIGHJELHFNC(TRoot DOJENPPADJD);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JOAEECPKPPL(TRoot DOJENPPADJD);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AKIPLBKJCCO(TRoot DOJENPPADJD);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NHMGPILCNGN(TRoot DOJENPPADJD, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, TAction[] KIJMGDBLMOF);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task ACKOFINFMNH(TRoot DOJENPPADJD, MMBOLDIBAHF<DLLCOFBGKPH> MHOPLONLNME, MMBOLDIBAHF<TMRequest> JLPMMGLNOMC, TAction OOCJAOHFGJK, bool EMCPDHFFOOE = true);
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
