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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A27BF0", Offset = "0x2A26BF0", VA = "0x182A27BF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FFAEIFGAJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public OCIDMCEKJIP<DLCHMCPFNIN> CIKGCJJOMMK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A27B90", Offset = "0x2A26B90", VA = "0x182A27B90")]
	public static FFAEIFGAJJC MPFKOOIPONO()
	{
		return default(FFAEIFGAJJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A27BC0", Offset = "0x2A26BC0", VA = "0x182A27BC0")]
	[CompilerGenerated]
	internal static OCIDMCEKJIP<DLCHMCPFNIN> PMAAJJAGJAP(int IOALKPFEKEK)
	{
		return default(OCIDMCEKJIP<DLCHMCPFNIN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AEDIOHJJANA
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PFGHCEEOFIG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int AFCBPNIHNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int AEEAEGIBPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float LGCDGMDEPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float GLCLMNHGCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LLOBJPODHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LCNEALCKMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IHDPINNLBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DIKJGKAAAPH<GAAICFLNCNK> CV2SetMaxAmmo(PKEPBOMIKGN KKDGPEIEFMH, int EOMGFLMBKFN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DIKJGKAAAPH<GAAICFLNCNK> CV2SetCurrentAmmo(PKEPBOMIKGN KKDGPEIEFMH, int EBMOGPINHGC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DIKJGKAAAPH<GAAICFLNCNK> CV2SetADSEnabled(PKEPBOMIKGN KKDGPEIEFMH, bool OPEAEGJENDN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DIKJGKAAAPH<GAAICFLNCNK> CV2SetCanReload(PKEPBOMIKGN KKDGPEIEFMH, bool JBHANJLNFJC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DIKJGKAAAPH<GAAICFLNCNK> CV2SetContinuousFire(PKEPBOMIKGN KKDGPEIEFMH, bool LKBCLCBLOJJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DIKJGKAAAPH<GAAICFLNCNK> CV2SetRateOfFire(PKEPBOMIKGN KKDGPEIEFMH, float CKOCAINJLPA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DIKJGKAAAPH<GAAICFLNCNK> CV2SetReloadDuration(PKEPBOMIKGN KKDGPEIEFMH, float JAPNNLNNKKI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GOHPIJMBALO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string NCJAEKMANFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DIKJGKAAAPH<GAAICFLNCNK> SetHandleControlLabel(PKEPBOMIKGN KKDGPEIEFMH, string NGBNCPKJGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CDCDKBAKLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(AEDIOHJJANA, AEDIOHJJANA, AEDIOHJJANA, AEDIOHJJANA, AEDIOHJJANA) IGOOFALIGGH(object MFOAOKBDIIM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object DILBAPLDMLF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJIKLILMPOK(object MFOAOKBDIIM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string ENNGHFKIKPI(object MFOAOKBDIIM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GOAGAFEAJPE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OJOGFMFIBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MNPDBHHKPDH
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKHCPAADOMC BLLECDFLLOK(int ELKLKEMINCE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LLGOMGFOGCH([In] EKHCPAADOMC AHBPOAJCLJB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PELEAJMPDKN
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DIKJGKAAAPH<GAAICFLNCNK> SetEnabled(PKEPBOMIKGN KKDGPEIEFMH, bool EKPLGGDDFGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct PHONGLLKKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HJKDEKHGGLM POCHPBIEGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MNPDBHHKPDH HBOJCFECKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly CDCDKBAKLOA KHJDKHJIMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly FFAEIFGAJJC GONIPOCIKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly GPKCFPBHKEE AOEJAFJLAMD;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2A27C70", Offset = "0x2A26C70", VA = "0x182A27C70")]
	public PHONGLLKKPK(HJKDEKHGGLM IAAIHJIFFGA, MNPDBHHKPDH EBMMGEHIFEN, CDCDKBAKLOA KOFLKFCAHBD, [In] FFAEIFGAJJC OOHJEMBKNMK, GPKCFPBHKEE KJMCMGPMFOF)
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
