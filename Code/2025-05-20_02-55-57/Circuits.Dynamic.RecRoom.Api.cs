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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27B4C60", Offset = "0x27B3E60", VA = "0x1827B4C60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CLPMAIJIHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public JFIBBLJIDCN<MOGCENFLBIL> BECEMNCDGAB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27B4C30", Offset = "0x27B3E30", VA = "0x1827B4C30")]
	public static CLPMAIJIHEJ OIKMHICCLEP()
	{
		return default(CLPMAIJIHEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27B4C00", Offset = "0x27B3E00", VA = "0x1827B4C00")]
	[CompilerGenerated]
	internal static JFIBBLJIDCN<MOGCENFLBIL> NHHJLCFFMHO(int MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<MOGCENFLBIL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OJMDDPOPIHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OOJOENEDMII
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MJOJKOJHOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int BGGPFHIIFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float EFCGCLBCCCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float GDKLGPBAAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AINPDOKILIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PDBDGADBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LBFHHAGCCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JMBKPLPJPML<GKPOGNMPJHG> CV2SetMaxAmmo(CCNMLIIOCEM NHADLBPGDMN, int IMCPMFMKKOG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JMBKPLPJPML<GKPOGNMPJHG> CV2SetCurrentAmmo(CCNMLIIOCEM NHADLBPGDMN, int BMBDPNPBBFI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JMBKPLPJPML<GKPOGNMPJHG> CV2SetADSEnabled(CCNMLIIOCEM NHADLBPGDMN, bool PGGLOGHIPPK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JMBKPLPJPML<GKPOGNMPJHG> CV2SetCanReload(CCNMLIIOCEM NHADLBPGDMN, bool IJAPKDEAMOC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JMBKPLPJPML<GKPOGNMPJHG> CV2SetContinuousFire(CCNMLIIOCEM NHADLBPGDMN, bool LIBHDKGAPLI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JMBKPLPJPML<GKPOGNMPJHG> CV2SetRateOfFire(CCNMLIIOCEM NHADLBPGDMN, float PGAPIGPPCKB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JMBKPLPJPML<GKPOGNMPJHG> CV2SetReloadDuration(CCNMLIIOCEM NHADLBPGDMN, float ALBGFINLCPH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FAOOHFNHFEL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string DHGAJIEDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JMBKPLPJPML<GKPOGNMPJHG> SetHandleControlLabel(CCNMLIIOCEM NHADLBPGDMN, string BFICFCBIIPI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EBNGHKFAOEP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(OJMDDPOPIHK, OJMDDPOPIHK, OJMDDPOPIHK, OJMDDPOPIHK, OJMDDPOPIHK) OHEEMBDDNKI(object PNBFNEJFAPC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object GCNEJGOBMFA();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJALJJOFOOG(object PNBFNEJFAPC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string FBOFLEFHCMG(object PNBFNEJFAPC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CEOBEIPBBGP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool PFMHIJCOFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HJIMBKHELCB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPMGKMACEBI HABMJMHBADC(int ALCALNAEEDE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DNCECGDODOK([In] CPMGKMACEBI ILOEEHKJEHF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OLCMIHKGIIH
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMBKPLPJPML<GKPOGNMPJHG> SetEnabled(CCNMLIIOCEM NHADLBPGDMN, bool BLAFNFFGEOH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct CKJHFNPPAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HKFCEKGBDOE PLCFJEBKLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly HJIMBKHELCB GGOEGCNKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly EBNGHKFAOEP BIJJPMBFICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly CLPMAIJIHEJ LDIPKNKLANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly DKLOGFJBOIL NPEJBDGMJCC;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x27B4B90", Offset = "0x27B3D90", VA = "0x1827B4B90")]
	public CKJHFNPPAJC(HKFCEKGBDOE EFIAOJKKBEJ, HJIMBKHELCB NHOCKDJEOHA, EBNGHKFAOEP IALHJCCAGBA, [In] CLPMAIJIHEJ NKCBHGONOJG, DKLOGFJBOIL HGBIFBIALPH)
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
