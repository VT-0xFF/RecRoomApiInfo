using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B6D0", Offset = "0x1E3A4D0", VA = "0x181E3B6D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct IGJEKPCNGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> CNCLGHBJNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int AKOMBCBOHAO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
	public IGJEKPCNGDG(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> LIAKDIHFADF, int PJPGJICIKPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ANOIOAJPPBN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class DBAPBJNPIMC : BBIABCOFEMI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct JALGDIEPPEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly GFNEJJPKIIB<byte> JDKLKJIEBIG;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DFB010", Offset = "0x1DF9E10", VA = "0x181DFB010")]
		public JALGDIEPPEB(GFNEJJPKIIB<byte> KKAMOMBNLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A2B0", Offset = "0x1E390B0", VA = "0x181E3A2B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class JFMBPKOPALE : BBIABCOFEMI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct HEFLFLBEBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> IPJBHCHAIEM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		public HEFLFLBEBPB(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> PJKMEFJLOMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum GOFADEJHPEL
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BytesImmediate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		X32Immediate
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class ILPIBKFMMDP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class BBIABCOFEMI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct ABADMMEIGBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly GOFADEJHPEL LCJOCBLINAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly FCLFMGJFDHI<BBIABCOFEMI> FDNIEJOEGNM;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
		public ABADMMEIGBK(GOFADEJHPEL MKHIJDBGKJK, FCLFMGJFDHI<BBIABCOFEMI> ONABEHOICDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class HKINFFPALCA : BBIABCOFEMI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MGLGFACIFEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FCKENLOJEDK;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		public MGLGFACIFEI(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BLHNCIHEPPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class AMOHCFFMAFC : BBIABCOFEMI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct HCLAGCIIEEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly CNLMJLLGIPI KDFKHOBOJAO;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		public HCLAGCIIEEM(CNLMJLLGIPI MIFNGJHBBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1E39E30", Offset = "0x1E38C30", VA = "0x181E39E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal HHCFKKLFNMF<ILPIBKFMMDP, ABADMMEIGBK> KFALHPHCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal HHCFKKLFNMF<DBAPBJNPIMC, JALGDIEPPEB> MHHODKABKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal HHCFKKLFNMF<JFMBPKOPALE, HEFLFLBEBPB> GGAMBFJHGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HHCFKKLFNMF<HKINFFPALCA, MGLGFACIFEI> LGJGDFNJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal HHCFKKLFNMF<AMOHCFFMAFC, HCLAGCIIEEM> NNADJNNCFAN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E36590", Offset = "0x1E35390", VA = "0x181E36590")]
	private ANOIOAJPPBN([In] HHCFKKLFNMF<ILPIBKFMMDP, ABADMMEIGBK> OFOIEPENHCO, [In] HHCFKKLFNMF<DBAPBJNPIMC, JALGDIEPPEB> BHLOFNLEIGH, [In] HHCFKKLFNMF<JFMBPKOPALE, HEFLFLBEBPB> ABGMJGKCDJF, [In] HHCFKKLFNMF<HKINFFPALCA, MGLGFACIFEI> BDJGLOAEAHP, [In] HHCFKKLFNMF<AMOHCFFMAFC, HCLAGCIIEEM> BIPOMNNIPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E36450", Offset = "0x1E35250", VA = "0x181E36450")]
	public static ANOIOAJPPBN KHDJPNLCMFA()
	{
		return default(ANOIOAJPPBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HPHLOBEJMNJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A0A0", Offset = "0x1E38EA0", VA = "0x181E3A0A0")]
	public static void OFGJMFOHKEH(this ANOIOAJPPBN ILACEKALGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OHDMLDLAHPD
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KENCEJNFJPG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class JEJOEBGOKAF : LDNBNOEMHIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct OEMMCAAJANP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> HNBKNJMCKKI;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		public OEMMCAAJANP(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> MOPGOBOJMBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum EDABKJLMIEE
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Branch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DeadEndData,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OutNode
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class BMCHOEJMLCO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class LDNBNOEMHIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct LOELHAJGGFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly EDABKJLMIEE LCJOCBLINAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly FCLFMGJFDHI<LDNBNOEMHIF> FDNIEJOEGNM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
		public LOELHAJGGFN(EDABKJLMIEE MKHIJDBGKJK, FCLFMGJFDHI<LDNBNOEMHIF> ONABEHOICDM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HHCFKKLFNMF<BMCHOEJMLCO, LOELHAJGGFN> KFALHPHCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HHCFKKLFNMF<JEJOEBGOKAF, OEMMCAAJANP> DLPBPIMOMOA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E36720", Offset = "0x1E35520", VA = "0x181E36720")]
	private KENCEJNFJPG([In] HHCFKKLFNMF<BMCHOEJMLCO, LOELHAJGGFN> OFOIEPENHCO, [In] HHCFKKLFNMF<JEJOEBGOKAF, OEMMCAAJANP> JNMNGGDBOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AA20", Offset = "0x1E39820", VA = "0x181E3AA20")]
	public static KENCEJNFJPG KHDJPNLCMFA()
	{
		return default(KENCEJNFJPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HJCDBCEEOIA
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E39E50", Offset = "0x1E38C50", VA = "0x181E39E50")]
	public static void OFGJMFOHKEH(this KENCEJNFJPG ILACEKALGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KIBJOCIJFAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NGFOIHIBELM<int> NAKGPICPBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NGFOIHIBELM<int> NOINOHBANCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int NOOCDDFDPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int BGJCJLGGDII;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AB50", Offset = "0x1E39950", VA = "0x181E3AB50")]
	private KIBJOCIJFAE([In] NGFOIHIBELM<int> MANEHLGMICA, [In] NGFOIHIBELM<int> AIBKAGBIOKC, int EGGPMJAOCKF, int MPMMEPINAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AAB0", Offset = "0x1E398B0", VA = "0x181E3AAB0")]
	public static KIBJOCIJFAE KHDJPNLCMFA()
	{
		return default(KIBJOCIJFAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LBOLBMNJEIH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E3AD60", Offset = "0x1E39B60", VA = "0x181E3AD60")]
	public static void OFGJMFOHKEH(this KIBJOCIJFAE ILACEKALGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JFBBGPKBHHB
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum HDDCNMNHGCF
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class JJDIAKMFNKJ : IPMADAHNKEC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct HHNIJLHHECE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly FCLFMGJFDHI<BFMFMHENDCE> ADKKIKOLAPO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		public HHNIJLHHECE(FCLFMGJFDHI<BFMFMHENDCE> EBDDJDEGMJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class IGDDFBLAJJC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class IPMADAHNKEC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct EIHNMCFGNIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly HDDCNMNHGCF LCJOCBLINAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly FCLFMGJFDHI<IPMADAHNKEC> FDNIEJOEGNM;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
		private EIHNMCFGNIL(HDDCNMNHGCF MKHIJDBGKJK, FCLFMGJFDHI<IPMADAHNKEC> ONABEHOICDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E36C50", Offset = "0x1E35A50", VA = "0x181E36C50")]
		public static EIHNMCFGNIL KHDJPNLCMFA(HDDCNMNHGCF MKHIJDBGKJK, FCLFMGJFDHI<IPMADAHNKEC> ONABEHOICDM)
		{
			return default(EIHNMCFGNIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class FBDFDMIIONK : IPMADAHNKEC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct PJMEBDHDEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly FCLFMGJFDHI<BFMFMHENDCE> ADKKIKOLAPO;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		public PJMEBDHDEHJ(FCLFMGJFDHI<BFMFMHENDCE> EBDDJDEGMJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BFMFMHENDCE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CODDAPHMBKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NGFOIHIBELM<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> BEOEAENJKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NGFOIHIBELM<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> BMKCKLOILIP;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E36720", Offset = "0x1E35520", VA = "0x181E36720")]
		private CODDAPHMBKA([In] NGFOIHIBELM<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> MLBJBAMBDEM, [In] NGFOIHIBELM<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> ACBMCEKAPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E366A0", Offset = "0x1E354A0", VA = "0x181E366A0")]
		public static CODDAPHMBKA KHDJPNLCMFA()
		{
			return default(CODDAPHMBKA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal HHCFKKLFNMF<IGDDFBLAJJC, EIHNMCFGNIL> KFALHPHCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal HHCFKKLFNMF<FBDFDMIIONK, PJMEBDHDEHJ> AMCPMNLMOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal HHCFKKLFNMF<JJDIAKMFNKJ, HHNIJLHHECE> EGGDAKFGBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal NGFOIHIBELM<(FCLFMGJFDHI<IGDDFBLAJJC> CallId, FCLFMGJFDHI<BFMFMHENDCE> IOId)> DAKHMKDFDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal HHCFKKLFNMF<BFMFMHENDCE, CODDAPHMBKA> PKMICHBIAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal FCECAFACGGB<BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> AJMHBIBMDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal FCECAFACGGB<BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> DMKFKEGONEC;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A4C0", Offset = "0x1E392C0", VA = "0x181E3A4C0")]
	private JFBBGPKBHHB([In] HHCFKKLFNMF<IGDDFBLAJJC, EIHNMCFGNIL> OFOIEPENHCO, [In] HHCFKKLFNMF<FBDFDMIIONK, PJMEBDHDEHJ> FNEIJKDFLAC, [In] HHCFKKLFNMF<JJDIAKMFNKJ, HHNIJLHHECE> GINAPKPPNPJ, [In] NGFOIHIBELM<(FCLFMGJFDHI<IGDDFBLAJJC> CallId, FCLFMGJFDHI<BFMFMHENDCE> IOId)> LGPGNFPLIKH, [In] HHCFKKLFNMF<BFMFMHENDCE, CODDAPHMBKA> HBBEJBHLFME, [In] FCECAFACGGB<BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> GGLEKGINGIJ, [In] FCECAFACGGB<BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> BJEMIGOIBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A320", Offset = "0x1E39120", VA = "0x181E3A320")]
	public static JFBBGPKBHHB KHDJPNLCMFA()
	{
		return default(JFBBGPKBHHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NNHAAOBJAHK
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B680", Offset = "0x1E3A480", VA = "0x181E3B680")]
	private static void OFGJMFOHKEH(this JFBBGPKBHHB.CODDAPHMBKA ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B470", Offset = "0x1E3A270", VA = "0x181E3B470")]
	public static void OFGJMFOHKEH(this JFBBGPKBHHB ILACEKALGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct FFCBGKABGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NGFOIHIBELM<byte> FICKCKJKEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal JFBBGPKBHHB INMNHKNEEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal JKEGEFMLIHN ADHPMOKHAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> GHIJGDBFCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal ANOIOAJPPBN LEBOJMLAPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal KENCEJNFJPG FEHLJLGGGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal FCECAFACGGB<MFHPFJOJHEP, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>?> DMIGGNCCFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal NGFOIHIBELM<FCLFMGJFDHI<MFHPFJOJHEP>> KEPFDIHCCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> DOPMKMCAEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> PPHIIGCLHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> PAEAKPIPAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal DBBGMMNECLP EFDLGFKFMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal ADKGGGMHEHA EGAJKKLPLLD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E39A10", Offset = "0x1E38810", VA = "0x181E39A10")]
	private FFCBGKABGLE([In] NGFOIHIBELM<byte> PLFCLKOCBCM, [In] JFBBGPKBHHB FPKEAHFKOEG, [In] JKEGEFMLIHN MKNAFFFLLDI, [In] ANOIOAJPPBN PEOLOAOHJHG, [In] KENCEJNFJPG AOCCPIDBNEL, [In] FCECAFACGGB<MFHPFJOJHEP, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>?> KKHHEANFFIH, [In] NGFOIHIBELM<FCLFMGJFDHI<MFHPFJOJHEP>> HJHKHHENNIL, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> PMOHGEAOGKG, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> EEDGDJCOHIJ, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> BCGJCCNMEBI, [In] DBBGMMNECLP EABFDIGAPCN, [In] ADKGGGMHEHA DIFJKFBJNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E38F50", Offset = "0x1E37D50", VA = "0x181E38F50")]
	public static FFCBGKABGLE KHDJPNLCMFA()
	{
		return default(FFCBGKABGLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FBONMEDNEGO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct LFMHAPJCBIK : OPECJNBDHBD<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>, FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E3AE50", Offset = "0x1E39C50", VA = "0x181E3AE50")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E3AED0", Offset = "0x1E39CD0", VA = "0x181E3AED0", Slot = "4")]
		public FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> KPAOMAEDJFI(int AELAKOMEEDP)
		{
			return default(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590")]
		public bool PBIEOPKNOCO(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "5")]
		private bool LAIDAGECEGO(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E3AE50", Offset = "0x1E39C50", VA = "0x181E3AE50", Slot = "6")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> HMEKEJEDMDI(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct NIMGKEJCOOJ : IOEOLKIEMJC<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>, FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B1F0", Offset = "0x1E39FF0", VA = "0x181E3B1F0")]
		public NGFOIHIBELM<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>> KNEOIHEDFJO(int OIJMFGBHJAH, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B170", Offset = "0x1E39F70", VA = "0x181E3B170")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B260", Offset = "0x1E3A060", VA = "0x181E3B260", Slot = "6")]
		public void PBLONGLKJOO(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B1F0", Offset = "0x1E39FF0", VA = "0x181E3B1F0", Slot = "4")]
		private NGFOIHIBELM<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>> PGNHCKJOKMF(int OIJMFGBHJAH, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B170", Offset = "0x1E39F70", VA = "0x181E3B170", Slot = "5")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> PMAIJJBOJEI(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct IIOKBOFKOMM : OPECJNBDHBD<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>, FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A200", Offset = "0x1E39000", VA = "0x181E3A200")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A280", Offset = "0x1E39080", VA = "0x181E3A280", Slot = "4")]
		public FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> KPAOMAEDJFI(int AELAKOMEEDP)
		{
			return default(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590")]
		public bool PBIEOPKNOCO(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "5")]
		private bool KNBNAIGEECA(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A200", Offset = "0x1E39000", VA = "0x181E3A200", Slot = "6")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> EFEHKNHCCIN(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct NMCOKLAJLJJ : IOEOLKIEMJC<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>, FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B370", Offset = "0x1E3A170", VA = "0x181E3B370")]
		public NGFOIHIBELM<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>> KNEOIHEDFJO(int OIJMFGBHJAH, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B2F0", Offset = "0x1E3A0F0", VA = "0x181E3B2F0")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B3E0", Offset = "0x1E3A1E0", VA = "0x181E3B3E0", Slot = "6")]
		public void PBLONGLKJOO(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B370", Offset = "0x1E3A170", VA = "0x181E3B370", Slot = "4")]
		private NGFOIHIBELM<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>> FDKLMIFIIPB(int OIJMFGBHJAH, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B2F0", Offset = "0x1E3A0F0", VA = "0x181E3B2F0", Slot = "5")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> BGPDGMPHFKK(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> AELAKOMEEDP, [In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct ABDMCBBDBJP : OPECJNBDHBD<FCLFMGJFDHI<LHAJKMKKACM>, FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E36220", Offset = "0x1E35020", VA = "0x181E36220")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(FCLFMGJFDHI<LHAJKMKKACM> AELAKOMEEDP, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E362D0", Offset = "0x1E350D0", VA = "0x181E362D0", Slot = "4")]
		public FCLFMGJFDHI<LHAJKMKKACM> KPAOMAEDJFI(int AELAKOMEEDP)
		{
			return default(FCLFMGJFDHI<LHAJKMKKACM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1E361C0", Offset = "0x1E34FC0", VA = "0x181E361C0")]
		public bool PBIEOPKNOCO(FCLFMGJFDHI<LHAJKMKKACM> AELAKOMEEDP, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1E361C0", Offset = "0x1E34FC0", VA = "0x181E361C0", Slot = "5")]
		private bool ACJPEPAFDDB(FCLFMGJFDHI<LHAJKMKKACM> AELAKOMEEDP, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E362C0", Offset = "0x1E350C0", VA = "0x181E362C0", Slot = "6")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> JJNHMEDBFHB(FCLFMGJFDHI<LHAJKMKKACM> AELAKOMEEDP, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct DKJPNMDDOOA : IOEOLKIEMJC<FCLFMGJFDHI<LHAJKMKKACM>, FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1E36A80", Offset = "0x1E35880", VA = "0x181E36A80")]
		public NGFOIHIBELM<FCLFMGJFDHI<LHAJKMKKACM>> KNEOIHEDFJO(int OIJMFGBHJAH, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<FCLFMGJFDHI<LHAJKMKKACM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1E36AF0", Offset = "0x1E358F0", VA = "0x181E36AF0")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(FCLFMGJFDHI<LHAJKMKKACM> AELAKOMEEDP, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1E36B90", Offset = "0x1E35990", VA = "0x181E36B90", Slot = "6")]
		public void PBLONGLKJOO(FCLFMGJFDHI<LHAJKMKKACM> AELAKOMEEDP, FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1E36A80", Offset = "0x1E35880", VA = "0x181E36A80", Slot = "4")]
		private NGFOIHIBELM<FCLFMGJFDHI<LHAJKMKKACM>> DFHDCLBMPKB(int OIJMFGBHJAH, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<FCLFMGJFDHI<LHAJKMKKACM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1E36A70", Offset = "0x1E35870", VA = "0x181E36A70", Slot = "5")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> BDOLHLFOOBO(FCLFMGJFDHI<LHAJKMKKACM> AELAKOMEEDP, [In] FCECAFACGGB<LHAJKMKKACM, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>?> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct OHEGHAAHLPH : OPECJNBDHBD<int, NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B750", Offset = "0x1E3A550", VA = "0x181E3B750")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x11E3DF0", Offset = "0x11E2BF0", VA = "0x1811E3DF0", Slot = "4")]
		public int KPAOMAEDJFI(int AELAKOMEEDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590")]
		public bool PBIEOPKNOCO(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "5")]
		private bool PMIOKAADIAG(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B7D0", Offset = "0x1E3A5D0", VA = "0x181E3B7D0", Slot = "6")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> HNANBPKIBHF(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct PPPHFACCELD : IOEOLKIEMJC<int, NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1E40B90", Offset = "0x1E3F990", VA = "0x181E40B90")]
		public NGFOIHIBELM<int> KNEOIHEDFJO(int OIJMFGBHJAH, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E40C00", Offset = "0x1E3FA00", VA = "0x181E40C00")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1E40C80", Offset = "0x1E3FA80", VA = "0x181E40C80", Slot = "6")]
		public void PBLONGLKJOO(int AELAKOMEEDP, NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E40B90", Offset = "0x1E3F990", VA = "0x181E40B90", Slot = "4")]
		private NGFOIHIBELM<int> DIMHPFEDKDJ(int OIJMFGBHJAH, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E40B80", Offset = "0x1E3F980", VA = "0x181E40B80", Slot = "5")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> BDPLIPJIOGG(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> VariableId, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<INDJOPDPNLB>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct DJICJLDCIOH : OPECJNBDHBD<int, NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1E369F0", Offset = "0x1E357F0", VA = "0x181E369F0")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x11E3DF0", Offset = "0x11E2BF0", VA = "0x1811E3DF0", Slot = "4")]
		public int KPAOMAEDJFI(int AELAKOMEEDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590")]
		public bool PBIEOPKNOCO(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "5")]
		private bool ALOIIIEOCIM(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1E369F0", Offset = "0x1E357F0", VA = "0x181E369F0", Slot = "6")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> EIKEEBLHCJB(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct NFBDFJECODP : IOEOLKIEMJC<int, NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B020", Offset = "0x1E39E20", VA = "0x181E3B020")]
		public NGFOIHIBELM<int> KNEOIHEDFJO(int OIJMFGBHJAH, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1E3AFA0", Offset = "0x1E39DA0", VA = "0x181E3AFA0")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B090", Offset = "0x1E39E90", VA = "0x181E3B090", Slot = "6")]
		public void PBLONGLKJOO(int AELAKOMEEDP, NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1E3B020", Offset = "0x1E39E20", VA = "0x181E3B020", Slot = "4")]
		private NGFOIHIBELM<int> NDLPJACCMFE(int OIJMFGBHJAH, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E3AFA0", Offset = "0x1E39DA0", VA = "0x181E3AFA0", Slot = "5")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DGHDMAPOOAE(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct AAIBAAJKENG : OPECJNBDHBD<int, NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E36140", Offset = "0x1E34F40", VA = "0x181E36140")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x11E3DF0", Offset = "0x11E2BF0", VA = "0x1811E3DF0", Slot = "4")]
		public int KPAOMAEDJFI(int AELAKOMEEDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590")]
		public bool PBIEOPKNOCO(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "5")]
		private bool ALOIIIEOCIM(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E36130", Offset = "0x1E34F30", VA = "0x181E36130", Slot = "6")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> EIKEEBLHCJB(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct HMHMAMPPLFH : IOEOLKIEMJC<int, NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E39F40", Offset = "0x1E38D40", VA = "0x181E39F40")]
		public NGFOIHIBELM<int> KNEOIHEDFJO(int OIJMFGBHJAH, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1E39EC0", Offset = "0x1E38CC0", VA = "0x181E39EC0")]
		public FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E39FB0", Offset = "0x1E38DB0", VA = "0x181E39FB0", Slot = "6")]
		public void PBLONGLKJOO(int AELAKOMEEDP, NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1E39F40", Offset = "0x1E38D40", VA = "0x181E39F40", Slot = "4")]
		private NGFOIHIBELM<int> NDLPJACCMFE(int OIJMFGBHJAH, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(NGFOIHIBELM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1E39EB0", Offset = "0x1E38CB0", VA = "0x181E39EB0", Slot = "5")]
		private FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DGHDMAPOOAE(int AELAKOMEEDP, [In] NGFOIHIBELM<(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> Target, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> ByteCodeWriteLocation)> NIEBKKPIOLC)
		{
			return default(FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct DBOJAMBBOLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> EBLGPMEHFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool HHJPPABDKLB;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xEDEF80", Offset = "0xEDDD80", VA = "0x180EDEF80")]
		public DBOJAMBBOLH(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK, bool KJDKBFMHBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E369E0", Offset = "0x1E357E0", VA = "0x181E369E0")]
		public void PHDHBCEACMN([Out] FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK, [Out] bool KJDKBFMHBIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct GGBPBDBLCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly FCLFMGJFDHI<LHAJKMKKACM> FEAIBANJOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> EBLGPMEHFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool HHJPPABDKLB;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E39E20", Offset = "0x1E38C20", VA = "0x181E39E20")]
		public GGBPBDBLCEP(FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK, bool KJDKBFMHBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1E39E10", Offset = "0x1E38C10", VA = "0x181E39E10")]
		public void PHDHBCEACMN([Out] FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK, [Out] bool KJDKBFMHBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1E39DF0", Offset = "0x1E38BF0", VA = "0x181E39DF0")]
		public void PHDHBCEACMN([Out] FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK, [Out] FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL, [Out] bool KJDKBFMHBIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct EECDGKLGHIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly FCLFMGJFDHI<LHAJKMKKACM> FEAIBANJOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> EBLGPMEHFIA;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
		public EECDGKLGHIC(FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E36C40", Offset = "0x1E35A40", VA = "0x181E36C40")]
		public void PHDHBCEACMN([Out] FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK, [Out] FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1E38B60", Offset = "0x1E37960", VA = "0x181E38B60")]
	public static void OFGJMFOHKEH(this FFCBGKABGLE ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E36FA0", Offset = "0x1E35DA0", VA = "0x181E36FA0")]
	public static void BIGNEFGNPPO(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<MFHPFJOJHEP> DKECCAKJPPL, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> KKMGLGCFGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E37D20", Offset = "0x1E36B20", VA = "0x181E37D20")]
	public static void GIMOJLFJALE(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<MFHPFJOJHEP> DKECCAKJPPL, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> KKMGLGCFGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1E37380", Offset = "0x1E36180", VA = "0x181E37380")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>? DMDOCKHCEAG([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<MFHPFJOJHEP> DKECCAKJPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E38530", Offset = "0x1E37330", VA = "0x181E38530")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> KCICFDCDADK([In] this FFCBGKABGLE ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E38370", Offset = "0x1E37170", VA = "0x181E38370")]
	private static void JJHIDLKIGBM(this FFCBGKABGLE ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E38200", Offset = "0x1E37000", VA = "0x181E38200")]
	private static FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>? IKPJNIOLLNM([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E377A0", Offset = "0x1E365A0", VA = "0x181E377A0")]
	public static void EGNHFACCPNG(this FFCBGKABGLE ILACEKALGJH, [In] NGFOIHIBELM<IGJEKPCNGDG> NDMAOGNMMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E37DF0", Offset = "0x1E36BF0", VA = "0x181E37DF0")]
	public static ANOIOAJPPBN.GOFADEJHPEL GKFBMHADMEO([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK)
	{
		return default(ANOIOAJPPBN.GOFADEJHPEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E387B0", Offset = "0x1E375B0", VA = "0x181E387B0")]
	public static GFNEJJPKIIB<byte> LLIBBPEOEOC([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK)
	{
		return default(GFNEJJPKIIB<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E379B0", Offset = "0x1E367B0", VA = "0x181E379B0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FMAFPJDDGCB([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E38AB0", Offset = "0x1E378B0", VA = "0x181E38AB0")]
	public static CNLMJLLGIPI NPCFHGIFHEM([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28A2FB0", Offset = "0x28A1DB0", VA = "0x1828A2FB0")]
	private static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> GALKHCAAAEF<TMJoin>(this FFCBGKABGLE ILACEKALGJH, ANOIOAJPPBN.GOFADEJHPEL MKHIJDBGKJK, FCLFMGJFDHI<TMJoin> ONABEHOICDM) where TMJoin : ANOIOAJPPBN.BBIABCOFEMI
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E38620", Offset = "0x1E37420", VA = "0x181E38620")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> KNMLNOFENGM(this FFCBGKABGLE ILACEKALGJH, bool JDLHJANDINM)
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E38590", Offset = "0x1E37390", VA = "0x181E38590")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> KDDBGEFFIPI(this FFCBGKABGLE ILACEKALGJH, GFNEJJPKIIB<byte> KKAMOMBNLOJ)
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1E386A0", Offset = "0x1E374A0", VA = "0x181E386A0")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> LIOLHHPBALO(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> PJKMEFJLOMD)
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1E37110", Offset = "0x1E35F10", VA = "0x181E37110")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> CHAEJAHGLEK(this FFCBGKABGLE ILACEKALGJH, int FAMFGGBBGKO)
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1E38E70", Offset = "0x1E37C70", VA = "0x181E38E70")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> PEGKLEEBIDC(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BLHNCIHEPPJ)
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28A2B00", Offset = "0x28A1900", VA = "0x1828A2B00")]
	private static FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> FCLPPLIFIMF<TMJoin>(this FFCBGKABGLE ILACEKALGJH, KENCEJNFJPG.EDABKJLMIEE MKHIJDBGKJK, FCLFMGJFDHI<TMJoin> ONABEHOICDM) where TMJoin : KENCEJNFJPG.LDNBNOEMHIF
	{
		return default(FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1E38290", Offset = "0x1E37090", VA = "0x181E38290")]
	public static FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> JAHOOLKDGMN(this FFCBGKABGLE ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1E372E0", Offset = "0x1E360E0", VA = "0x181E372E0")]
	public static FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> CMKMJEAPPPI(this FFCBGKABGLE ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1E389F0", Offset = "0x1E377F0", VA = "0x181E389F0")]
	public static FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> NABGJKHHKPD(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> MOPGOBOJMBN)
	{
		return default(FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E38A70", Offset = "0x1E37870", VA = "0x181E38A70")]
	public static FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> NCOBNMMGBLC(this FFCBGKABGLE ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E38160", Offset = "0x1E36F60", VA = "0x181E38160")]
	public static FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> IAAJGHMIIBL(this FFCBGKABGLE ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E384D0", Offset = "0x1E372D0", VA = "0x181E384D0")]
	public static JFBBGPKBHHB.HDDCNMNHGCF KAOBJIHBGLP([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> MPHHIHKJCKM)
	{
		return default(JFBBGPKBHHB.HDDCNMNHGCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E38E30", Offset = "0x1E37C30", VA = "0x181E38E30")]
	public static CBADNDLLJMD<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>, CFHCFBAJCGJ<JFBBGPKBHHB.BFMFMHENDCE>> PDMKMJABAII([In] this FFCBGKABGLE ILACEKALGJH)
	{
		return default(CBADNDLLJMD<FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>, CFHCFBAJCGJ<JFBBGPKBHHB.BFMFMHENDCE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E37EB0", Offset = "0x1E36CB0", VA = "0x181E37EB0")]
	public static FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> HICBEDDICFM([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> MPHHIHKJCKM)
	{
		return default(FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E38EF0", Offset = "0x1E37CF0", VA = "0x181E38EF0")]
	public static JFBBGPKBHHB.CODDAPHMBKA PLJJDKJCKBM([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> EBDDJDEGMJJ)
	{
		return default(JFBBGPKBHHB.CODDAPHMBKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E36C60", Offset = "0x1E35A60", VA = "0x181E36C60")]
	public static JFBBGPKBHHB.CODDAPHMBKA AHFIIHALPIN(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> EBDDJDEGMJJ)
	{
		return default(JFBBGPKBHHB.CODDAPHMBKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28A1A10", Offset = "0x28A0810", VA = "0x1828A1A10")]
	private static FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> CHAFJLIELGG<TMJoin>(this FFCBGKABGLE ILACEKALGJH, JFBBGPKBHHB.HDDCNMNHGCF MKHIJDBGKJK, FCLFMGJFDHI<TMJoin> ONABEHOICDM) where TMJoin : JFBBGPKBHHB.IPMADAHNKEC
	{
		return default(FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E375D0", Offset = "0x1E363D0", VA = "0x181E375D0")]
	public static (FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>) DOFNCEIEFHN(this FFCBGKABGLE ILACEKALGJH)
	{
		return default((FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E37410", Offset = "0x1E36210", VA = "0x181E37410")]
	public static (FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>) DMPDGFDIFKB(this FFCBGKABGLE ILACEKALGJH)
	{
		return default((FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1E37030", Offset = "0x1E35E30", VA = "0x181E37030")]
	public static FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> BJGNADPNFID(this FFCBGKABGLE ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E38020", Offset = "0x1E36E20", VA = "0x181E38020")]
	public static void HJBANFPBCIK(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE> EBDDJDEGMJJ, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> OJCGGKKDNAJ, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>> NCNALDLGPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28A1AA0", Offset = "0x28A08A0", VA = "0x1828A1AA0")]
	public static DBOJAMBBOLH CHLGHOMKNEG<TDeps, TStateSys>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL) where TDeps : JAILJNAHIGF<TStateSys>
	{
		return default(DBOJAMBBOLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28A2880", Offset = "0x28A1680", VA = "0x1828A2880")]
	public static GGBPBDBLCEP EPJCHDICOGC<TDeps, TStateSys>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<HNBANOMJKFE> NLOKDELMBLG, int CKNOGMJBMDG) where TDeps : JAILJNAHIGF<TStateSys>
	{
		return default(GGBPBDBLCEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28A2B90", Offset = "0x28A1990", VA = "0x1828A2B90")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>? FDMFFNPIAFL<TDeps, TStateSys>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<HNBANOMJKFE> NLOKDELMBLG, [In] ReadOnlySpan<int> GDIKFJGPNKM, [In] Span<EECDGKLGHIC> LEFKDOBKJLF) where TDeps : JAILJNAHIGF<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28A1480", Offset = "0x28A0280", VA = "0x1828A1480")]
	public static FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> BCMLFFBBPDH<TDeps, TStateSys>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<MFHPFJOJHEP> DKECCAKJPPL) where TDeps : JAILJNAHIGF<TStateSys>
	{
		return default(FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E37910", Offset = "0x1E36710", VA = "0x181E37910")]
	public static JKEGEFMLIHN.LPEOBCLNCIJ FFKDMFBGMFG([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NLFEJIHGBIC)
	{
		return default(JKEGEFMLIHN.LPEOBCLNCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1E36F00", Offset = "0x1E35D00", VA = "0x181E36F00")]
	public static JKEGEFMLIHN.GAKDHBMFDMP BDJKKILGCJL([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NLFEJIHGBIC)
	{
		return default(JKEGEFMLIHN.GAKDHBMFDMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E37070", Offset = "0x1E35E70", VA = "0x181E37070")]
	public static JKEGEFMLIHN.HDILIAHOHND CBMPHNNBEIM([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NLFEJIHGBIC)
	{
		return default(JKEGEFMLIHN.HDILIAHOHND);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1E37B60", Offset = "0x1E36960", VA = "0x181E37B60")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> GIGNFCCFMFK(this FFCBGKABGLE ILACEKALGJH, int? AJFJIIHDCHN, string PHEKPMAPPHM)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1E382D0", Offset = "0x1E370D0", VA = "0x181E382D0")]
	public static JKEGEFMLIHN.PJHLKJJNNGG JIEAIMODBFD([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NLFEJIHGBIC)
	{
		return default(JKEGEFMLIHN.PJHLKJJNNGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E37E50", Offset = "0x1E36C50", VA = "0x181E37E50")]
	public static JKEGEFMLIHN.ECMMGDPEDHC HFKGAACIKEG([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NLFEJIHGBIC)
	{
		return default(JKEGEFMLIHN.ECMMGDPEDHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E37320", Offset = "0x1E36120", VA = "0x181E37320")]
	public static int? DDAGDNMAIME([In] this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NLFEJIHGBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28A3040", Offset = "0x28A1E40", VA = "0x1828A3040")]
	private static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> IJIAGEDDAPO<TMJoin>(this FFCBGKABGLE ILACEKALGJH, int? AJFJIIHDCHN, JKEGEFMLIHN.ECMMGDPEDHC MKHIJDBGKJK, FCLFMGJFDHI<TMJoin> ONABEHOICDM) where TMJoin : JKEGEFMLIHN.BHLGKGIHLKA
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E380B0", Offset = "0x1E36EB0", VA = "0x181E380B0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> HJNKAMCIHMC(this FFCBGKABGLE ILACEKALGJH, int? AJFJIIHDCHN, FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> MPHHIHKJCKM, int AELAKOMEEDP)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E381A0", Offset = "0x1E36FA0", VA = "0x181E381A0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> IHIOKKPAIAM(this FFCBGKABGLE ILACEKALGJH, int? AJFJIIHDCHN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E38860", Offset = "0x1E37660", VA = "0x181E38860")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MMGAIIEBHDP(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>? NDJNAJHAMLB, int? AJFJIIHDCHN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E38720", Offset = "0x1E37520", VA = "0x181E38720")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> LKNPJFMJIII(this FFCBGKABGLE ILACEKALGJH, int? AJFJIIHDCHN, int AELAKOMEEDP)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E36D80", Offset = "0x1E35B80", VA = "0x181E36D80")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> AJDDEHJBHAG(this FFCBGKABGLE ILACEKALGJH, int? AJFJIIHDCHN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E36DE0", Offset = "0x1E35BE0", VA = "0x181E36DE0")]
	public static void BBDJIGFJCLE(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BLHNCIHEPPJ, FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> MPHHIHKJCKM, int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E37A60", Offset = "0x1E36860", VA = "0x181E37A60")]
	public static void GBBKNNBNCLP(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BLHNCIHEPPJ, int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E37190", Offset = "0x1E35F90", VA = "0x181E37190")]
	public static void CIABCABFJHA(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BLHNCIHEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E37250", Offset = "0x1E36050", VA = "0x181E37250")]
	public static void CMFKPGOAJEG(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> KCDBINENHAL, FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> BBMJGLFDHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1E36CC0", Offset = "0x1E35AC0", VA = "0x181E36CC0")]
	public static void AHGNHOLHAEI(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BLHNCIHEPPJ, FCLFMGJFDHI<BBGNJJIAHOD<MIMHPEOELHJ>> PFANGANPIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28A3120", Offset = "0x28A1F20", VA = "0x1828A3120")]
	public static void LFHEJPHGECB<M>(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BLHNCIHEPPJ, FCLFMGJFDHI<BBGNJJIAHOD<NBCPCEFHAEB<M>>> PFANGANPIAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JAILJNAHIGF<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FCLFMGJFDHI<EKPIIADOODM> HAONGJEBKDC(TStateSys PGNMOONDDMA);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCLFMGJFDHI<EKPIIADOODM> BEHBMNMFGOI(TStateSys PGNMOONDDMA);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCLFMGJFDHI<EKPIIADOODM> AKJLGOIECFP(TStateSys PGNMOONDDMA);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FCLFMGJFDHI<EKPIIADOODM> LKCLIAGOCHF(TStateSys PGNMOONDDMA);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> MFDAOBDEEAG(TStateSys PGNMOONDDMA, FFCBGKABGLE CEJCCNJMOCF, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> CCHHBHBAKNM(TStateSys PGNMOONDDMA, FFCBGKABGLE CEJCCNJMOCF, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<MFHPFJOJHEP> DKECCAKJPPL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PPIBCCJBMOG(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FCLFMGJFDHI<MFHPFJOJHEP> GBPCHOKLOME(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL, int JJDGKODAPKP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OHDMLDLAHPD INNEIBJEMDD(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KOCEPOONECJ(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int MHDEPPCGJIP(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GFNEJJPKIIB<byte> LJDIDJFCPIM(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(GFNEJJPKIIB<byte>, FCLFMGJFDHI<EKPIIADOODM>) MDOBOHFPLOF(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<LHAJKMKKACM> PFKCNGFFICL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int NPPBIDMIDBD(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<MFHPFJOJHEP> DKECCAKJPPL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FCLFMGJFDHI<LHAJKMKKACM> DFADEPPLJIJ(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<MFHPFJOJHEP> DKECCAKJPPL, int CKNOGMJBMDG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FCLFMGJFDHI<LHAJKMKKACM> NALNFJFNPHD(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<HNBANOMJKFE> NLOKDELMBLG, int CKNOGMJBMDG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int BIIGIIBGDKI(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? CHPJLGEDJBP(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int KLDKKIDIANE(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? OCOLANDGBMB(TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, int AELAKOMEEDP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class PCEINGGNKGE
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A500", Offset = "0x2A49300", VA = "0x182A4A500")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL?> ELNGDIGDCFI<T, TOpInput, TOpOutput>(this FFCBGKABGLE ILACEKALGJH, T MAEINFGKCEL, T FLBFHNBPNFN, int LGLHFLEEFJB, IntPtr CBFKJDHBEEH)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A49D10", Offset = "0x2A48B10", VA = "0x182A49D10")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL?> CFIJNIFAPAD<T, TOpInput, TOpOutput>(this FFCBGKABGLE ILACEKALGJH, T MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN, int LGLHFLEEFJB, IntPtr CBFKJDHBEEH)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B4B0", Offset = "0x2A4A2B0", VA = "0x182A4B4B0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL?> JDJEBLNFJIC<TOpInput, TOpOutput>(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN, int LGLHFLEEFJB, IntPtr CBFKJDHBEEH)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E190", Offset = "0x1E3CF90", VA = "0x181E3E190")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> GLHOLGCLGGF(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E40A60", Offset = "0x1E3F860", VA = "0x181E40A60")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> PGENNACMCFJ(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E570", Offset = "0x1E3D370", VA = "0x181E3E570")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> HHJKJBIMMGK(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F330", Offset = "0x1E3E130", VA = "0x181E3F330")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> LLBJEEIPBBP(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D890", Offset = "0x1E3C690", VA = "0x181E3D890")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FIKBKLDIGPD(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D100", Offset = "0x1E3BF00", VA = "0x181E3D100")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ELDGDHLGMGL(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EC20", Offset = "0x1E3DA20", VA = "0x181E3EC20")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> JEDKCIEBLKH(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E2B0", Offset = "0x1E3D0B0", VA = "0x181E3E2B0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> HAKAECFIADI(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F170", Offset = "0x1E3DF70", VA = "0x181E3F170")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> LHEPCMILCFE(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E40590", Offset = "0x1E3F390", VA = "0x181E40590")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> OOGAPFJKKOI(this FFCBGKABGLE ILACEKALGJH, int MAEINFGKCEL, int FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E407A0", Offset = "0x1E3F5A0", VA = "0x181E407A0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> PCEILFDPBOE(this FFCBGKABGLE ILACEKALGJH, int MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FE50", Offset = "0x1E3EC50", VA = "0x181E3FE50")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NOPMFPKLJJL(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E090", Offset = "0x1E3CE90", VA = "0x181E3E090")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> GJGFLLMBMAG(this FFCBGKABGLE ILACEKALGJH, float MAEINFGKCEL, float FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DE20", Offset = "0x1E3CC20", VA = "0x181E3DE20")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> GGBCAIKDOKO(this FFCBGKABGLE ILACEKALGJH, float MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F910", Offset = "0x1E3E710", VA = "0x181E3F910")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NALJHPEKOON(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E4F0", Offset = "0x1E3D2F0", VA = "0x181E3E4F0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> HFAOLGNIBBK(this FFCBGKABGLE ILACEKALGJH, int MAEINFGKCEL, int FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FF90", Offset = "0x1E3ED90", VA = "0x181E3FF90")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> OEDBJEHEGAA(this FFCBGKABGLE ILACEKALGJH, int MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D000", Offset = "0x1E3BE00", VA = "0x181E3D000")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> EHAHBIADONE(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D380", Offset = "0x1E3C180", VA = "0x181E3D380")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENDKOFKBADG(this FFCBGKABGLE ILACEKALGJH, float MAEINFGKCEL, float FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C290", Offset = "0x1E3B090", VA = "0x181E3C290")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CEHBOCMCPGA(this FFCBGKABGLE ILACEKALGJH, float MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D080", Offset = "0x1E3BE80", VA = "0x181E3D080")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> EHFNDKIPKDG(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FDD0", Offset = "0x1E3EBD0", VA = "0x181E3FDD0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NOEDGCLKLHP(this FFCBGKABGLE ILACEKALGJH, int MAEINFGKCEL, int FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F2B0", Offset = "0x1E3E0B0", VA = "0x181E3F2B0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> LIBAMEDMNGF(this FFCBGKABGLE ILACEKALGJH, int MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B900", Offset = "0x1E3A700", VA = "0x181E3B900")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> AHGMFHBEACN(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F0F0", Offset = "0x1E3DEF0", VA = "0x181E3F0F0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> LGPCHBGDEPH(this FFCBGKABGLE ILACEKALGJH, float MAEINFGKCEL, float FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FB90", Offset = "0x1E3E990", VA = "0x181E3FB90")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NJJJFJLODNA(this FFCBGKABGLE ILACEKALGJH, float MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FD50", Offset = "0x1E3EB50", VA = "0x181E3FD50")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NMIFFJNJAAF(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CB90", Offset = "0x1E3B990", VA = "0x181E3CB90")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> DLFEDFDMBMA(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CD70", Offset = "0x1E3BB70", VA = "0x181E3CD70")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> DPHPEOOGEKF(this FFCBGKABGLE ILACEKALGJH, int DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CAF0", Offset = "0x1E3B8F0", VA = "0x181E3CAF0")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> DGICDCBCOEM(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C7D0", Offset = "0x1E3B5D0", VA = "0x181E3C7D0")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> CPLNINBONLJ(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BEIEONIMMKK)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C310", Offset = "0x1E3B110", VA = "0x181E3C310")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> CHOILDBFNCH(this FFCBGKABGLE ILACEKALGJH, int DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E6B0", Offset = "0x1E3D4B0", VA = "0x181E3E6B0")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> HIHMMLGGHLP(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E40100", Offset = "0x1E3EF00", VA = "0x181E40100")]
	public static (FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>) OMBPIMIAFAI(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<HHDPBMHOJPK> CINGEHOFIPA, [In] ReadOnlySpan<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> MLBJBAMBDEM, [In] ReadOnlySpan<int?> NGPCINIDOMO, [In] Span<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> OMOKONHHFLG)
	{
		return default((FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D400", Offset = "0x1E3C200", VA = "0x181E3D400")]
	public static (FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>) FCNKHJFIOIN(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JNJEBJHPFKK> JAPAKEELFJG, [In] ReadOnlySpan<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> MLBJBAMBDEM, [In] ReadOnlySpan<int?> NGPCINIDOMO, [In] Span<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> OMOKONHHFLG)
	{
		return default((FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BE10", Offset = "0x2A4AC10", VA = "0x182A4BE10")]
	public static (FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<EKPIIADOODM>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<TMarker>>, FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>) MMOHHBMBEGF<TMarker>(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<EKPIIADOODM> BNNAMBCLBLN, [In] ReadOnlySpan<byte> LHODDAGAJKC)
	{
		return default((FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<BBGNJJIAHOD<EKPIIADOODM>>, FCLFMGJFDHI<BBGNJJIAHOD<MCGEGMFELIF>>, FCLFMGJFDHI<BBGNJJIAHOD<TMarker>>, FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EB60", Offset = "0x1E3D960", VA = "0x181E3EB60")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> JCBLIJJCNLC(this FFCBGKABGLE ILACEKALGJH, int FEAFHENKEAJ, [Optional] FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>? CALLEFILHJM)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E750", Offset = "0x1E3D550", VA = "0x181E3E750")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> HKICCJCJOLD(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FEAFHENKEAJ, [Optional] FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>? CALLEFILHJM)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F000", Offset = "0x1E3DE00", VA = "0x181E3F000")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> KODBIHEKGAE(this FFCBGKABGLE ILACEKALGJH, [In] ReadOnlySpan<byte> FEAFHENKEAJ, [Optional] FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>? CALLEFILHJM)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B7E0", Offset = "0x1E3A5E0", VA = "0x181E3B7E0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> AGEIKHDKEJL(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FEAFHENKEAJ, int CGDBKIJPKOF, [Optional] FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>? CALLEFILHJM)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BDB0", Offset = "0x1E3ABB0", VA = "0x181E3BDB0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BCOPKLEPIJK(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BEB0", Offset = "0x1E3ACB0", VA = "0x181E3BEB0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BGFCIBCPDEB(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FC10", Offset = "0x1E3EA10", VA = "0x181E3FC10")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NKIFJNHMEAN(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CF10", Offset = "0x1E3BD10", VA = "0x181E3CF10")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> EFLEBBJKCGN(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1E3CDF0", Offset = "0x1E3BBF0", VA = "0x181E3CDF0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> EAPBMCNOMPP(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C690", Offset = "0x1E3B490", VA = "0x181E3C690")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CPELPIPLCEB(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EE40", Offset = "0x1E3DC40", VA = "0x181E3EE40")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> KDPCFAMGMHO(this FFCBGKABGLE ILACEKALGJH, int MAEINFGKCEL, int FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BFD0", Offset = "0x1E3ADD0", VA = "0x181E3BFD0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BMJIJMAJNIL(this FFCBGKABGLE ILACEKALGJH, int MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1E408C0", Offset = "0x1E3F6C0", VA = "0x181E408C0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> PDOAFPFMDBP(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MAEINFGKCEL, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FLBFHNBPNFN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C190", Offset = "0x1E3AF90", VA = "0x181E3C190")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CDBHDPIBCNM(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E3ED10", Offset = "0x1E3DB10", VA = "0x181E3ED10")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> JKEBJAKJHCB(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C050", Offset = "0x1E3AE50", VA = "0x181E3C050")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BNOLEOMHMGE(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C5A0", Offset = "0x1E3B3A0", VA = "0x181E3C5A0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> COONMFLPAKA(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E3B980", Offset = "0x1E3A780", VA = "0x181E3B980")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> AHIJAMKCGAD(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C9B0", Offset = "0x1E3B7B0", VA = "0x181E3C9B0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> DENIBLFFLDB(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E290", Offset = "0x1E3D090", VA = "0x181E3E290")]
	public static FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>> GPGCAIEGCNK(this FFCBGKABGLE ILACEKALGJH)
	{
		return default(FCLFMGJFDHI<BBGNJJIAHOD<BBGNJJIAHOD<NMPFACAPKKC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C3A0", Offset = "0x1E3B1A0", VA = "0x181E3C3A0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CKCPAPGKBOB(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E40940", Offset = "0x1E3F740", VA = "0x181E40940")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> PFJCKCGGABA(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E3FA50", Offset = "0x1E3E850", VA = "0x181E3FA50")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NJAHFEJMGFA(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E40010", Offset = "0x1E3EE10", VA = "0x181E40010")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> OHGAKPLFMKL(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E3D0", Offset = "0x1E3D1D0", VA = "0x181E3E3D0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> HEJBAAKMIMK(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EEC0", Offset = "0x1E3DCC0", VA = "0x181E3EEC0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> KJNKIGOEAII(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DD20", Offset = "0x1E3CB20", VA = "0x181E3DD20")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> GFCOFELLFCJ(this FFCBGKABGLE ILACEKALGJH, int DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D9B0", Offset = "0x1E3C7B0", VA = "0x181E3D9B0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FJJNPFOMFAL(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> DIBNBLEEFNN)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C390", Offset = "0x1E3B190", VA = "0x181E3C390")]
	public static void CJFAECLGIBG(this FFCBGKABGLE ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E3C4A0", Offset = "0x1E3B2A0", VA = "0x181E3C4A0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CLKHLGCCDFO(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, float CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F420", Offset = "0x1E3E220", VA = "0x181E3F420")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MBPJNBNAENM(this FFCBGKABGLE ILACEKALGJH, float ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E3EA20", Offset = "0x1E3D820", VA = "0x181E3EA20")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ICHAGDPPCEN(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E930", Offset = "0x1E3D730", VA = "0x181E3E930")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> IACPDIBLDFK(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E40680", Offset = "0x1E3F480", VA = "0x181E40680")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> PBMJJPDHFLB(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DF50", Offset = "0x1E3CD50", VA = "0x181E3DF50")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> GIOHMMBHOGI(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F540", Offset = "0x1E3E340", VA = "0x181E3F540")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> MENGOMIDOEF(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> AHNBNBNONGJ, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> IINAAHPKHMO)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E3E840", Offset = "0x1E3D640", VA = "0x181E3E840")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> HPCEJIDOEGC(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, int CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DAC0", Offset = "0x1E3C8C0", VA = "0x181E3DAC0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> GBNCPBMMKJO(this FFCBGKABGLE ILACEKALGJH, int ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1E3D240", Offset = "0x1E3C040", VA = "0x181E3D240")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ELMLLMGPDHC(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> ENBPDIJHKJG, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> CFFNBDCKFPB)
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BF00", Offset = "0x2A4AD00", VA = "0x182A4BF00")]
	public static void MNNGFMBJDOD<TDeps, TState>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TState DEPIDMABJHK, FCLFMGJFDHI<HHDPBMHOJPK> CINGEHOFIPA, [In] ReadOnlySpan<FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>> JPLDKEAICHK, [In] ReadOnlySpan<int?> NGPCINIDOMO, [In] Span<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> OMOKONHHFLG, [In] Span<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> FBHBOJLGNNK, [In] ReadOnlySpan<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>?> OLAOJCDKOCA) where TDeps : notnull, JAILJNAHIGF<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2A49FF0", Offset = "0x2A48DF0", VA = "0x182A49FF0")]
	public static void EIAGEPOPBPM<TDeps, TState>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TState DEPIDMABJHK, FCLFMGJFDHI<JNJEBJHPFKK> HAEHEOGNGAP, [In] ReadOnlySpan<FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>> MDEECBFALDO, [In] ReadOnlySpan<int?> NGPCINIDOMO, [In] Span<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> OMOKONHHFLG, [In] Span<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>> FBHBOJLGNNK, [In] ReadOnlySpan<FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>?> OLAOJCDKOCA) where TDeps : notnull, JAILJNAHIGF<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2A49B50", Offset = "0x2A48950", VA = "0x182A49B50")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BJHKIFJGMOE<TDeps, TState>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TState DEPIDMABJHK, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> NDJNAJHAMLB, [Optional] FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>? CALLEFILHJM) where TDeps : notnull, JAILJNAHIGF<TState> where TState : notnull
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A49720", Offset = "0x2A48520", VA = "0x182A49720")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> BHLBBIKIGFN<TDeps, TState>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TState DEPIDMABJHK, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> MOPGOBOJMBN, [Optional] FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>? CALLEFILHJM) where TDeps : notnull, JAILJNAHIGF<TState> where TState : notnull
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2A493B0", Offset = "0x2A481B0", VA = "0x182A493B0")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> ANOOGGECEKA<TDeps, TStateSys>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TStateSys PGNMOONDDMA) where TDeps : notnull, JAILJNAHIGF<TStateSys> where TStateSys : notnull
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B160", Offset = "0x2A49F60", VA = "0x182A4B160")]
	public static FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO> IAEPILFNHBC<TDeps, TStateSys>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TStateSys PGNMOONDDMA) where TDeps : notnull, JAILJNAHIGF<TStateSys> where TStateSys : notnull
	{
		return default(FCLFMGJFDHI<KENCEJNFJPG.BMCHOEJMLCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DBE0", Offset = "0x1E3C9E0", VA = "0x181E3DBE0")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> GCECJFNBJKC(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BAABCLFFLBH, IntPtr GONMMPIOEPO, IntPtr LHHNNOELOEO)
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1E3BAA0", Offset = "0x1E3A8A0", VA = "0x181E3BAA0")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> ALBOBBNDFAM(this FFCBGKABGLE ILACEKALGJH, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BCJLPLECJJJ, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> FLFOPBGKDIK, IntPtr KJOJJPDDJLB, IntPtr IEKMEGNILKL, IntPtr OOCNDAHIHGA, bool KJIMELBAIHD)
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AAB0", Offset = "0x2A498B0", VA = "0x182A4AAB0")]
	public static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> GOIDFOPAODJ<TDeps, TState>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TState DEPIDMABJHK, FCLFMGJFDHI<HHDPBMHOJPK> ECCACJCOIPI, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BCJLPLECJJJ, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> FLFOPBGKDIK, int? JFOCOJDHKIG, [Optional] IntPtr CIHIPLEPCMF) where TDeps : notnull, JAILJNAHIGF<TState> where TState : notnull
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A7A0", Offset = "0x2A495A0", VA = "0x182A4A7A0")]
	private static FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> GOIDFOPAODJ<TDeps, TState>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TState DEPIDMABJHK, FCLFMGJFDHI<HHDPBMHOJPK> ECCACJCOIPI, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> BCJLPLECJJJ, FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP> FLFOPBGKDIK, int? JFOCOJDHKIG) where TDeps : notnull, JAILJNAHIGF<TState> where TState : notnull
	{
		return default(FCLFMGJFDHI<ANOIOAJPPBN.ILPIBKFMMDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B5D0", Offset = "0x2A4A3D0", VA = "0x182A4B5D0")]
	public static FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> LLICKKKLDCF<TDeps, TState>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TState DEPIDMABJHK, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL> FEAFHENKEAJ, FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>? CALLEFILHJM) where TDeps : notnull, JAILJNAHIGF<TState> where TState : notnull
	{
		return default(FCLFMGJFDHI<JKEGEFMLIHN.ACAGKAHDEAL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2A4BA50", Offset = "0x2A4A850", VA = "0x182A4BA50")]
	public static void LNMCMMHBLCM<TDeps, TState>(this FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TState DEPIDMABJHK, int FBEPNICAPLI) where TDeps : notnull, JAILJNAHIGF<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct AHJDKEDLNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> JIBHBGCEGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> OOLAKPGKBIP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
	public AHJDKEDLNEG(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> NIKGFLHEGDI, FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> LECEAPCHNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1E36440", Offset = "0x1E35240", VA = "0x181E36440")]
	public static AHJDKEDLNEG KHDJPNLCMFA(FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>> NIKGFLHEGDI)
	{
		return default(AHJDKEDLNEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct JKEGEFMLIHN
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class NOALNFEKJBH : BHLGKGIHLKA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct LPEOBCLNCIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> ELFHFJMIMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int PCBIBNEPCKE;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
		public LPEOBCLNCIJ(FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> MPHHIHKJCKM, int AELAKOMEEDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class CCGKEOMOABG : BHLGKGIHLKA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct GAKDHBMFDMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int PCBIBNEPCKE;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		public GAKDHBMFDMP(int AELAKOMEEDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class PBLFCBECDKK : BHLGKGIHLKA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct HDILIAHOHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> ELFHFJMIMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int PCBIBNEPCKE;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAE9A50", Offset = "0xAE8850", VA = "0x180AE9A50")]
		public HDILIAHOHND(FCLFMGJFDHI<JFBBGPKBHHB.IGDDFBLAJJC> MPHHIHKJCKM, int AELAKOMEEDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum ECMMGDPEDHC
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class ACAGKAHDEAL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class BHLGKGIHLKA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct JMIOGFLIOHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? NMGNJDCOCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AHJDKEDLNEG EGMMFNCOGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public ECMMGDPEDHC LCJOCBLINAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FCLFMGJFDHI<BHLGKGIHLKA> FDNIEJOEGNM;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1E3A8A0", Offset = "0x1E396A0", VA = "0x181E3A8A0")]
		public JMIOGFLIOHK(int? AJFJIIHDCHN, [In] AHJDKEDLNEG KDGONCKPMMI, ECMMGDPEDHC MKHIJDBGKJK, FCLFMGJFDHI<BHLGKGIHLKA> ONABEHOICDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class IMDNGLPFMNJ : BHLGKGIHLKA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct PJHLKJJNNGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int PCBIBNEPCKE;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		public PJHLKJJNNGG(int AELAKOMEEDP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal LBJGBNCCFFE<ACAGKAHDEAL, JMIOGFLIOHK> KFALHPHCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal LBJGBNCCFFE<NOALNFEKJBH, LPEOBCLNCIJ> CJPPIJIKNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal LBJGBNCCFFE<PBLFCBECDKK, HDILIAHOHND> HPPHKMONPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal LBJGBNCCFFE<IMDNGLPFMNJ, PJHLKJJNNGG> NBDMMEBMMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal LBJGBNCCFFE<CCGKEOMOABG, GAKDHBMFDMP> KPDKHHDOGAM;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A770", Offset = "0x1E39570", VA = "0x181E3A770")]
	private JKEGEFMLIHN([In] LBJGBNCCFFE<ACAGKAHDEAL, JMIOGFLIOHK> OFOIEPENHCO, [In] LBJGBNCCFFE<NOALNFEKJBH, LPEOBCLNCIJ> IKFFEGELKIP, [In] LBJGBNCCFFE<PBLFCBECDKK, HDILIAHOHND> DJLMLLJKANN, [In] LBJGBNCCFFE<IMDNGLPFMNJ, PJHLKJJNNGG> FIFHJOIJGFH, [In] LBJGBNCCFFE<CCGKEOMOABG, GAKDHBMFDMP> NICFHOICLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A580", Offset = "0x1E39380", VA = "0x181E3A580")]
	public static JKEGEFMLIHN KHDJPNLCMFA()
	{
		return default(JKEGEFMLIHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IHGPAADONHP
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A150", Offset = "0x1E38F50", VA = "0x181E3A150")]
	public static void OFGJMFOHKEH(this JKEGEFMLIHN ILACEKALGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class KEFBGOMCKCB
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1E3A8C0", Offset = "0x1E396C0", VA = "0x181E3A8C0")]
	public static void AHOFDHJJGBG(FFCBGKABGLE ILACEKALGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct DBBGMMNECLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, KIBJOCIJFAE> APEKGBCNNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int GINHILEEKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int EHNMFMLNJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1E369A0", Offset = "0x1E357A0", VA = "0x181E369A0")]
	private DBBGMMNECLP([In] FCECAFACGGB<JFBBGPKBHHB.BFMFMHENDCE, KIBJOCIJFAE> AFMCHOPFJFL, int MNLGFIAHPJH, int ABANJMHOEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1E36760", Offset = "0x1E35560", VA = "0x181E36760")]
	public static DBBGMMNECLP KHDJPNLCMFA()
	{
		return default(DBBGMMNECLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1E367D0", Offset = "0x1E355D0", VA = "0x181E367D0")]
	public void OFGJMFOHKEH([In] FFCBGKABGLE LGCLICFOKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x273FCC0", Offset = "0x273EAC0", VA = "0x18273FCC0")]
	public static void AHOFDHJJGBG<TDeps, TStateSys>(FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TStateSys PGNMOONDDMA, FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG) where TDeps : notnull, JAILJNAHIGF<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KODBACECOCL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1E3ABB0", Offset = "0x1E399B0", VA = "0x181E3ABB0")]
	public static void AHOFDHJJGBG(FFCBGKABGLE ILACEKALGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ADKGGGMHEHA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface OCMFHNHGGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void APLNHPCKNGJ(NGFOIHIBELM<byte> PLFCLKOCBCM, int MLKIEPADLLM);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct FGNPMIDOCNC : OCMFHNHGGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1E39D70", Offset = "0x1E38B70", VA = "0x181E39D70", Slot = "4")]
		public void APLNHPCKNGJ(NGFOIHIBELM<byte> PLFCLKOCBCM, int MLKIEPADLLM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct NEDPNEGHGAK : OCMFHNHGGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1E3AF00", Offset = "0x1E39D00", VA = "0x181E3AF00", Slot = "4")]
		public void APLNHPCKNGJ(NGFOIHIBELM<byte> PLFCLKOCBCM, int MLKIEPADLLM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct CJPDPOAOCLG : OCMFHNHGGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1E36620", Offset = "0x1E35420", VA = "0x181E36620", Slot = "4")]
		public void APLNHPCKNGJ(NGFOIHIBELM<byte> PLFCLKOCBCM, int MLKIEPADLLM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct LCBGAIFHCFB : OCMFHNHGGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1E3ADB0", Offset = "0x1E39BB0", VA = "0x181E3ADB0", Slot = "4")]
		public void APLNHPCKNGJ(NGFOIHIBELM<byte> PLFCLKOCBCM, int MLKIEPADLLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class FMNHNDOHPLE<TCallProcessorDeps> where TCallProcessorDeps : struct, OCMFHNHGGKL
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps PIBJMGMHGME;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x27CC990", Offset = "0x27CB790", VA = "0x1827CC990")]
		public static int AHOFDHJJGBG<TDeps, TStateSys>(TDeps GLJEJHKFIBB, TStateSys DEPIDMABJHK, FFCBGKABGLE LGCLICFOKFI, [In] NGFOIHIBELM<byte> NNGJECDGPGA, int ALLHDEFACBC) where TDeps : JAILJNAHIGF<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NGFOIHIBELM<IGJEKPCNGDG> ICMECOAINIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>> AGOGFNOHJPJ;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1E36400", Offset = "0x1E35200", VA = "0x181E36400")]
	private ADKGGGMHEHA([In] NGFOIHIBELM<IGJEKPCNGDG> NDMAOGNMMII, Dictionary<FCLFMGJFDHI<BBGNJJIAHOD<NMPFACAPKKC>>, FCLFMGJFDHI<JFBBGPKBHHB.BFMFMHENDCE>> LEEBOGIDDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1E36300", Offset = "0x1E35100", VA = "0x181E36300")]
	public static ADKGGGMHEHA KHDJPNLCMFA()
	{
		return default(ADKGGGMHEHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1E363C0", Offset = "0x1E351C0", VA = "0x181E363C0")]
	public void OFGJMFOHKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2F013C0", Offset = "0x2F001C0", VA = "0x182F013C0")]
	public static void AHOFDHJJGBG<TDeps, TStateSys>(FFCBGKABGLE ILACEKALGJH, TDeps GLJEJHKFIBB, TStateSys PGNMOONDDMA) where TDeps : JAILJNAHIGF<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IEPMJCPBENF<TDeps, TIndex, TValues> where TDeps : struct, IOEOLKIEMJC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps PIBJMGMHGME;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3A720C0", Offset = "0x3A70EC0", VA = "0x183A720C0")]
	public static void AHOFDHJJGBG([In] NGFOIHIBELM<IGJEKPCNGDG> NDMAOGNMMII, int OIJMFGBHJAH, TValues NIEBKKPIOLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface IOEOLKIEMJC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGFOIHIBELM<TIndex> KNEOIHEDFJO(int OIJMFGBHJAH, [In] TValues NIEBKKPIOLC);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(TIndex AELAKOMEEDP, [In] TValues NIEBKKPIOLC);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBLONGLKJOO(TIndex AELAKOMEEDP, TValues NIEBKKPIOLC, FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface OPECJNBDHBD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex KPAOMAEDJFI(int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PBIEOPKNOCO(TIndex AELAKOMEEDP, [In] TValues NIEBKKPIOLC);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FCLFMGJFDHI<BBGNJJIAHOD<INDJOPDPNLB>> GFDAGGBECFG(TIndex AELAKOMEEDP, [In] TValues NIEBKKPIOLC);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DHAFAFCJLBK<TDeps, TIndex, TValues> where TDeps : struct, OPECJNBDHBD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps PIBJMGMHGME;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5148880", Offset = "0x5147680", VA = "0x185148880")]
	public static NGFOIHIBELM<TIndex> AHOFDHJJGBG(int OIJMFGBHJAH, [In] TValues NIEBKKPIOLC)
	{
		return default(NGFOIHIBELM<TIndex>);
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
