using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2ABF630", Offset = "0x2ABE430", VA = "0x182ABF630")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LCNMFIPMLFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public PFJMKELOBBL<OFPNJMOJLCK> EOLKBIMOLJI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2ABF5D0", Offset = "0x2ABE3D0", VA = "0x182ABF5D0")]
	public static LCNMFIPMLFG ELDPFIHNJDG()
	{
		return default(LCNMFIPMLFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2ABF600", Offset = "0x2ABE400", VA = "0x182ABF600")]
	[CompilerGenerated]
	internal static PFJMKELOBBL<OFPNJMOJLCK> MNCHBFKFPHM(int HGMAIPELJHM)
	{
		return default(PFJMKELOBBL<OFPNJMOJLCK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JFJPCIHFFGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LKIBPFBHNGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BKLAIJICOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int DAEJPMMAOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float NKLPHGGOLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float HCCKIIBAGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JGAMLPHLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MKFNAJNLANA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NNNBBPCICDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GKFOCMGEGLF<GFJAPJIFDGB> CV2SetMaxAmmo(OGBLMALEBJH DNLEOFNAGNA, int ANDCPDPHMGN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GKFOCMGEGLF<GFJAPJIFDGB> CV2SetCurrentAmmo(OGBLMALEBJH DNLEOFNAGNA, int NKNCDMONMEC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GKFOCMGEGLF<GFJAPJIFDGB> CV2SetADSEnabled(OGBLMALEBJH DNLEOFNAGNA, bool GDNKPNFMPCI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GKFOCMGEGLF<GFJAPJIFDGB> CV2SetCanReload(OGBLMALEBJH DNLEOFNAGNA, bool GADJNJDHOEI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GKFOCMGEGLF<GFJAPJIFDGB> CV2SetContinuousFire(OGBLMALEBJH DNLEOFNAGNA, bool JKMBMGEEJPC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GKFOCMGEGLF<GFJAPJIFDGB> CV2SetRateOfFire(OGBLMALEBJH DNLEOFNAGNA, float GAFEGGNEMAE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GKFOCMGEGLF<GFJAPJIFDGB> CV2SetReloadDuration(OGBLMALEBJH DNLEOFNAGNA, float GJEDFMHCPFI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MLNBNGLBGME
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string PEBGCJIPACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GKFOCMGEGLF<GFJAPJIFDGB> SetHandleControlLabel(OGBLMALEBJH DNLEOFNAGNA, string KCAHPOJKMFB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GJCGBKFMJMA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(JFJPCIHFFGP, JFJPCIHFFGP, JFJPCIHFFGP, JFJPCIHFFGP, JFJPCIHFFGP) HLDCHGAKGAL(object GLMBLPAKFLM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object CNCPLDHKICA();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HCIMLNOEIII(object GLMBLPAKFLM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string GIONDKPEHKP(object GLMBLPAKFLM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LIEKOPNHKFP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MKCMNIAPBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DIMFPDLCGHJ
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FIHLGNKHEAG FMENGDKDPBD(int LBFEHACLMBD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LOLCIAANEJP([In] FIHLGNKHEAG ACCBDPACOIL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FDBCHIBEAHH
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKFOCMGEGLF<GFJAPJIFDGB> SetEnabled(OGBLMALEBJH DNLEOFNAGNA, bool HNBJAPDPLDD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct IOAMPBMLBKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ENJLJBCOBHJ GKNALFFHODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DIMFPDLCGHJ NCHCKECDHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly GJCGBKFMJMA FFBNBDKCEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly LCNMFIPMLFG FNGFAIHBHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly ELGOGNDDOEK PMGMCMIAHNE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2ABF560", Offset = "0x2ABE360", VA = "0x182ABF560")]
	public IOAMPBMLBKO(ENJLJBCOBHJ KCNNNEGFJDM, DIMFPDLCGHJ AHLPFFGNOPK, GJCGBKFMJMA IEPMLOBBJJI, [In] LCNMFIPMLFG JPKEOEBMCBM, ELGOGNDDOEK NDPHNEJJCNA)
	{
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
