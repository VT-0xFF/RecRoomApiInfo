using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2A30", Offset = "0x7DE1C30", VA = "0x187DE2A30")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
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
public abstract class CFNCNGGOJMI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected CFNCNGGOJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class ADLDDHHOBLB<T> : CFNCNGGOJMI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct HCIKOGAIMEG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum FACCDJEOMGI
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public FACCDJEOMGI EDLOHJEBKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T HDKINMMJOHF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int ABDNBMBODJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool AGMIENILJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool EOPHJOEIHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? EFEPPDCIFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<HCIKOGAIMEG>? MLJBEIJPKLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HEIMBCICNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4A7D480", Offset = "0x4A7C680", VA = "0x184A7D480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DBD0", Offset = "0x4A7CDD0", VA = "0x184A7DBD0")]
	protected ADLDDHHOBLB(bool EOPHJOEIHJI, bool AGMIENILJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DB30", Offset = "0x4A7CD30", VA = "0x184A7DB30")]
	protected bool OPCDNALIEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D1B0", Offset = "0x4A7C3B0", VA = "0x184A7D1B0")]
	protected void DCIKDINFLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D6B0", Offset = "0x4A7C8B0", VA = "0x184A7D6B0")]
	protected void OIPIMFNBEAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E614D0", Offset = "0x2E606D0", VA = "0x182E614D0")]
	private static void DKMDAALNGDK<U>(List<U>? MEHAOGGFJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D920", Offset = "0x4A7CB20", VA = "0x184A7D920", Slot = "4")]
	public void OOLDDNFEGEK(T HDKINMMJOHF, bool BJIBHCGLBOH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D4E0", Offset = "0x4A7C6E0", VA = "0x184A7D4E0", Slot = "5")]
	public void KKKHDEJPLIG(T HDKINMMJOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D2D0", Offset = "0x4A7C4D0", VA = "0x184A7D2D0")]
	public void FKFEALEGJFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class JGNOJICCDHE : ADLDDHHOBLB<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1EB0", Offset = "0x7DE10B0", VA = "0x187DE1EB0")]
	public JGNOJICCDHE(bool EOPHJOEIHJI = false, bool AGMIENILJGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1BF0", Offset = "0x7DE0DF0", VA = "0x187DE1BF0")]
	public void ENEDPBAOBKF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1DF0", Offset = "0x7DE0FF0", VA = "0x187DE1DF0")]
	public static JGNOJICCDHE FCGKNANLNCA(JGNOJICCDHE GDHICCNNLKM, Action HDKINMMJOHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1E50", Offset = "0x7DE1050", VA = "0x187DE1E50")]
	public static JGNOJICCDHE MIIOGMOPELA(JGNOJICCDHE GDHICCNNLKM, Action HDKINMMJOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CJPIAHIIPBM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOLDDNFEGEK(Action<T> HDKINMMJOHF, bool BJIBHCGLBOH = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKKHDEJPLIG(Action<T> HDKINMMJOHF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NDCOIAMFCNJ<T> : ADLDDHHOBLB<Action<T>>, CJPIAHIIPBM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4EADE10", Offset = "0x4EAD010", VA = "0x184EADE10")]
	public NDCOIAMFCNJ(bool EOPHJOEIHJI = false, bool AGMIENILJGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x537CCE0", Offset = "0x537BEE0", VA = "0x18537CCE0")]
	public void ENEDPBAOBKF(T PNIEJJKFCEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x52D8330", Offset = "0x52D7530", VA = "0x1852D8330")]
	public static NDCOIAMFCNJ<T> FCGKNANLNCA(NDCOIAMFCNJ<T> GDHICCNNLKM, Action<T> HDKINMMJOHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x52D83D0", Offset = "0x52D75D0", VA = "0x1852D83D0")]
	public static NDCOIAMFCNJ<T> MIIOGMOPELA(NDCOIAMFCNJ<T> GDHICCNNLKM, Action<T> HDKINMMJOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DMKBHGDJOCE<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOLDDNFEGEK(Action<T, U> HDKINMMJOHF, bool BJIBHCGLBOH = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKKHDEJPLIG(Action<T, U> HDKINMMJOHF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PFCLJBDPGOA<T, U> : ADLDDHHOBLB<Action<T, U>>, DMKBHGDJOCE<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EADE10", Offset = "0x4EAD010", VA = "0x184EADE10")]
	public PFCLJBDPGOA(bool EOPHJOEIHJI = false, bool AGMIENILJGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x560FF40", Offset = "0x560F140", VA = "0x18560FF40")]
	public void ENEDPBAOBKF(T PNIEJJKFCEK, U LJMKALCMHBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x52D8330", Offset = "0x52D7530", VA = "0x1852D8330")]
	public static PFCLJBDPGOA<T, U> FCGKNANLNCA(PFCLJBDPGOA<T, U> GDHICCNNLKM, Action<T, U> HDKINMMJOHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x52D83D0", Offset = "0x52D75D0", VA = "0x1852D83D0")]
	public static PFCLJBDPGOA<T, U> MIIOGMOPELA(PFCLJBDPGOA<T, U> GDHICCNNLKM, Action<T, U> HDKINMMJOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BGBNJBDHOLE<T, U, V> : ADLDDHHOBLB<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EADE10", Offset = "0x4EAD010", VA = "0x184EADE10")]
	public BGBNJBDHOLE(bool EOPHJOEIHJI = false, bool AGMIENILJGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E85B90", Offset = "0x5E84D90", VA = "0x185E85B90")]
	public void ENEDPBAOBKF(T PNIEJJKFCEK, U LJMKALCMHBH, V KOBHBJCHIOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x52D8330", Offset = "0x52D7530", VA = "0x1852D8330")]
	public static BGBNJBDHOLE<T, U, V> FCGKNANLNCA(BGBNJBDHOLE<T, U, V> GDHICCNNLKM, Action<T, U, V> HDKINMMJOHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x52D83D0", Offset = "0x52D75D0", VA = "0x1852D83D0")]
	public static BGBNJBDHOLE<T, U, V> MIIOGMOPELA(BGBNJBDHOLE<T, U, V> GDHICCNNLKM, Action<T, U, V> HDKINMMJOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PAGLEKFHKAB<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class BAGDJPJBODB<T, U, V, W> : ADLDDHHOBLB<Action<T, U, V, W>>, PAGLEKFHKAB<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4EADE10", Offset = "0x4EAD010", VA = "0x184EADE10")]
	public BAGDJPJBODB(bool EOPHJOEIHJI = false, bool AGMIENILJGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E66020", Offset = "0x5E65220", VA = "0x185E66020")]
	public void ENEDPBAOBKF(T PNIEJJKFCEK, U LJMKALCMHBH, V KOBHBJCHIOC, W CGJLBECCPJC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x52D8330", Offset = "0x52D7530", VA = "0x1852D8330")]
	public static BAGDJPJBODB<T, U, V, W> FCGKNANLNCA(BAGDJPJBODB<T, U, V, W> GDHICCNNLKM, Action<T, U, V, W> HDKINMMJOHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x52D83D0", Offset = "0x52D75D0", VA = "0x1852D83D0")]
	public static BAGDJPJBODB<T, U, V, W> MIIOGMOPELA(BAGDJPJBODB<T, U, V, W> GDHICCNNLKM, Action<T, U, V, W> HDKINMMJOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CMJMAAPNEAH<T, U, V, W, X> : ADLDDHHOBLB<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4EADE10", Offset = "0x4EAD010", VA = "0x184EADE10")]
	public CMJMAAPNEAH(bool EOPHJOEIHJI = false, bool AGMIENILJGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6630C30", Offset = "0x662FE30", VA = "0x186630C30")]
	public void ENEDPBAOBKF(T PNIEJJKFCEK, U LJMKALCMHBH, V KOBHBJCHIOC, W CGJLBECCPJC, X CCOLDGJALNH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x52D8330", Offset = "0x52D7530", VA = "0x1852D8330")]
	public static CMJMAAPNEAH<T, U, V, W, X> FCGKNANLNCA(CMJMAAPNEAH<T, U, V, W, X> GDHICCNNLKM, Action<T, U, V, W, X> HDKINMMJOHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x52D83D0", Offset = "0x52D75D0", VA = "0x1852D83D0")]
	public static CMJMAAPNEAH<T, U, V, W, X> MIIOGMOPELA(CMJMAAPNEAH<T, U, V, W, X> GDHICCNNLKM, Action<T, U, V, W, X> HDKINMMJOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MDLHLKKJDFD<T, U, V, W, X, Y> : ADLDDHHOBLB<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4EADE10", Offset = "0x4EAD010", VA = "0x184EADE10")]
	public MDLHLKKJDFD(bool EOPHJOEIHJI = false, bool AGMIENILJGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x52D7FA0", Offset = "0x52D71A0", VA = "0x1852D7FA0")]
	public void ENEDPBAOBKF(T PNIEJJKFCEK, U LJMKALCMHBH, V KOBHBJCHIOC, W CGJLBECCPJC, X CCOLDGJALNH, Y JCBKIOEHCDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x52D8330", Offset = "0x52D7530", VA = "0x1852D8330")]
	public static MDLHLKKJDFD<T, U, V, W, X, Y> FCGKNANLNCA(MDLHLKKJDFD<T, U, V, W, X, Y> GDHICCNNLKM, Action<T, U, V, W, X, Y> HDKINMMJOHF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x52D83D0", Offset = "0x52D75D0", VA = "0x1852D83D0")]
	public static MDLHLKKJDFD<T, U, V, W, X, Y> MIIOGMOPELA(MDLHLKKJDFD<T, U, V, W, X, Y> GDHICCNNLKM, Action<T, U, V, W, X, Y> HDKINMMJOHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OABHGOMKONB<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JBIBALGPAGF<TKey, TVal> KIEDAGEOMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BGOFAFLODAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JBIBALGPAGF<TKey, TVal>.KFJABJFCCJN? JAIOOHHLDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int GNNNMHFIBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JBIBALGPAGF<TKey, TVal>.GDPJHFMGHME? AOOJMBDAJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int IDAEDLFMCDD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int LAKFKGLEGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x54B58A0", Offset = "0x54B4AA0", VA = "0x1854B58A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JDBAJODHLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x54B58F0", Offset = "0x54B4AF0", VA = "0x1854B58F0")]
	public OABHGOMKONB(int GNNNMHFIBCF, [Optional] JBIBALGPAGF<TKey, TVal>.GDPJHFMGHME? AOOJMBDAJOC, [Optional] IEqualityComparer<TKey>? JMGOAMAODFP, [Optional] JBIBALGPAGF<TKey, TVal>.KFJABJFCCJN? JAIOOHHLDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x54B5670", Offset = "0x54B4870", VA = "0x1854B5670")]
	public void NKDCIMODGFF(TKey AGBHGDFILGO, TVal MLCDCHNOCFI, bool PDGHOFAAMFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x54B4600", Offset = "0x54B3800", VA = "0x1854B4600")]
	public bool DIJBDIPHNAN(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x54B4D70", Offset = "0x54B3F70", VA = "0x1854B4D70")]
	public bool FLFGMEICIOC(TKey AAHHAPOLENF, [Out] TVal MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x54B5020", Offset = "0x54B4220", VA = "0x1854B5020")]
	private void HJEHCBDFBFH(TKey AGBHGDFILGO, TVal MLCDCHNOCFI, int JAFKPMJIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x54B4E70", Offset = "0x54B4070", VA = "0x1854B4E70")]
	public bool GIHAPLEAPCE(TKey AGBHGDFILGO, TVal MLCDCHNOCFI, bool PDGHOFAAMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x54B4CC0", Offset = "0x54B3EC0", VA = "0x1854B4CC0")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x54B4760", Offset = "0x54B3960", VA = "0x1854B4760")]
	private void FCMKJLCAELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x54B5530", Offset = "0x54B4730", VA = "0x1854B5530")]
	private bool MANOCJDMJOB(TKey AGBHGDFILGO, HNAGFNJIFEE BPAILNFLNFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x54B5410", Offset = "0x54B4610", VA = "0x1854B5410")]
	private void KFDFPOHHADO(TKey AGBHGDFILGO, TVal MLCDCHNOCFI, HNAGFNJIFEE BPAILNFLNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x54B52E0", Offset = "0x54B44E0", VA = "0x1854B52E0")]
	private void IELAGAAIEJC(TKey AGBHGDFILGO, TVal KFEGNKODPFP, HNAGFNJIFEE BPAILNFLNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PONINGBMLMH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action PMGAJGOAJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JKJPAJBBBIM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public PONINGBMLMH(Action NEBLENLODFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2E50", Offset = "0x7DE2050", VA = "0x187DE2E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x36A0B10", Offset = "0x369FD10", VA = "0x1836A0B10")]
	public static LGILIJIJPGJ<T> EAIFKKLDBGP<T>(T MLCDCHNOCFI, Action NEBLENLODFH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LGILIJIJPGJ<T> : PONINGBMLMH where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50CB120", Offset = "0x50CA320", VA = "0x1850CB120")]
	public LGILIJIJPGJ(T MLCDCHNOCFI, Action NEBLENLODFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ELHONIOEKGG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FFJGPPNFDAK<T>? ACPDPLHLCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> LOMCDHDEPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool JKJPAJBBBIM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly ELHONIOEKGG<T> MLINAHCDIHH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> EENJDLMPEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x453BDD0", Offset = "0x453AFD0", VA = "0x18453BDD0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x453C0C0", Offset = "0x453B2C0", VA = "0x18453C0C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BFALGEPOBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x453BC50", Offset = "0x453AE50", VA = "0x18453BC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x453C8F0", Offset = "0x453BAF0", VA = "0x18453C8F0")]
	public ELHONIOEKGG(FFJGPPNFDAK<T> HBHFCILHFCL, FFJGPPNFDAK<T> PEFLBAJICOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x453C9E0", Offset = "0x453BBE0", VA = "0x18453C9E0")]
	public ELHONIOEKGG(FFJGPPNFDAK<T> HBHFCILHFCL, int AIGLIPKHKOK, FFJGPPNFDAK<T> PEFLBAJICOB, int KNOIOHINDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x453C4A0", Offset = "0x453B6A0", VA = "0x18453C4A0")]
	private ELHONIOEKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x453BED0", Offset = "0x453B0D0", VA = "0x18453BED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x453C010", Offset = "0x453B210", VA = "0x18453C010")]
	public T[] EKNHBOFPBHM()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x453C240", Offset = "0x453B440", VA = "0x18453C240")]
	public static ReadOnlySequence<T> NEKLFDMHCNA(ELHONIOEKGG<T>? JOEIEILCALI)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JCGMDJAAPMF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable PJJDEJHHGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T ABLHJAOAOGP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4EAAF40", Offset = "0x4EAA140", VA = "0x184EAAF40")]
	public JCGMDJAAPMF(IDisposable FNEFIOJLPDJ, [In] T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E330", Offset = "0x3F6D530", VA = "0x183F6E330")]
	public static JCGMDJAAPMF<U> FELDFFEEKHI<U>([In] JCGMDJAAPMF<T> FNEFIOJLPDJ, [In] U MLCDCHNOCFI) where U : notnull
	{
		return default(JCGMDJAAPMF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAAD30", Offset = "0x4EA9F30", VA = "0x184EAAD30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OGLAJPDFOHP
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x39EE500", Offset = "0x39ED700", VA = "0x1839EE500")]
	public static JCGMDJAAPMF<T> OIKMHICCLEP<T>(IDisposable FNEFIOJLPDJ, [In] T MLCDCHNOCFI) where T : notnull
	{
		return default(JCGMDJAAPMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x39EE590", Offset = "0x39ED790", VA = "0x1839EE590")]
	public static JCGMDJAAPMF<T> PHFECNPMCFG<T>([In] this JCGMDJAAPMF<T> CEENCLMGJAM, [Out] T MLCDCHNOCFI) where T : notnull
	{
		return default(JCGMDJAAPMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37F32E0", Offset = "0x37F24E0", VA = "0x1837F32E0")]
	public static JCGMDJAAPMF<U?> FELDFFEEKHI<U, T>([In] JCGMDJAAPMF<T> DIKJCKBFBLP, [In] U MLCDCHNOCFI)
	{
		return default(JCGMDJAAPMF<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct PIJFLCEMDCN : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct OKGMIFOBFCP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
		public static OKGMIFOBFCP OIKMHICCLEP()
		{
			return default(OKGMIFOBFCP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2D70", Offset = "0x7DE1F70", VA = "0x187DE2D70")]
	public static string LNAIFNHAOMJ(Type EDLOHJEBKFM, [Optional] string? PKEAHDJHOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A168E0", Offset = "0x3A15AE0", VA = "0x183A168E0")]
	public static string? LNAIFNHAOMJ<T>([Optional] string? PKEAHDJHOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A16860", Offset = "0x3A15A60", VA = "0x183A16860")]
	public static string? GPPMNAAGIBD<T>([Optional] string? JBDKILLGLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0")]
	public static PIJFLCEMDCN JHLKCEPMGDF(string PKEAHDJHOGG, string? JBDKILLGLJO)
	{
		return default(PIJFLCEMDCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IENBLMBPDPG
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool DLHDDEABLGB(string FJNPOKPCBIH, IENBLMBPDPG PCCGMCJCMFO);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EFGONPCBDDE<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EFGONPCBDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4533360", Offset = "0x4532560", VA = "0x184533360")]
		internal void KDAEFPBKHMI(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int EJKIDBDKPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string EKMHIOABOHB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1070", Offset = "0x7DE0270", VA = "0x187DE1070")]
	public static Dictionary<string, IENBLMBPDPG> KGPEPBJOJBC(Type CIPDLJOCAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38458D0", Offset = "0x3844AD0", VA = "0x1838458D0")]
	public static Dictionary<string, IENBLMBPDPG> KGPEPBJOJBC<T>(Type CIPDLJOCAPI, IReadOnlyDictionary<T, string> IOPBCIPIDBE) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x38460F0", Offset = "0x38452F0", VA = "0x1838460F0")]
	public static Dictionary<string, IENBLMBPDPG> LDFHKFIPHOM<T>(List<T> HLAMELDMDEC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE13A0", Offset = "0x7DE05A0", VA = "0x187DE13A0")]
	public static Dictionary<string, IENBLMBPDPG> MBJECJEDHCA(Type CIPDLJOCAPI, DLHDDEABLGB MLNDHMFDAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0EB0", Offset = "0x7DE00B0", VA = "0x187DE0EB0")]
	public static Dictionary<int, string> DBLLLKMOBGE(Dictionary<string, IENBLMBPDPG> LJMBANNFBIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class DKPIACPJNCE : GEFBDEPLDON
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool AGMENKFBHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? OMOGLENIGDK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual GEFBDEPLDON? FCLBMILNNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0020", Offset = "0x7DDF220", VA = "0x187DE0020")]
	protected DKPIACPJNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JOOGKGIFDEP();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFFA0", Offset = "0x7DDF1A0", VA = "0x187DDFFA0", Slot = "8")]
	public virtual string PLMCPIFAKPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFD00", Offset = "0x7DDEF00", VA = "0x187DDFD00", Slot = "9")]
	public void KNOGBJJOMBL(StringBuilder CHGJIFICBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFCA0", Offset = "0x7DDEEA0", VA = "0x187DDFCA0", Slot = "10")]
	public void IINFBEANCBH(StringBuilder CHGJIFICBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF980", Offset = "0x7DDEB80", VA = "0x187DDF980", Slot = "11")]
	public void AAEDMCFDKJN(StringBuilder CHGJIFICBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFB40", Offset = "0x7DDED40", VA = "0x187DDFB40", Slot = "12")]
	public void ANFPPOMLHHD(StringBuilder CHGJIFICBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFAA0", Offset = "0x7DDECA0", VA = "0x187DDFAA0")]
	public static void AIGABBJCNCF(StringBuilder CHGJIFICBNI, string LBMHFAOKMJO, string NIKEDDJEDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A930", Offset = "0x6D79B30", VA = "0x186D7A930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KANFHDNKBAP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1F70", Offset = "0x7DE1170", VA = "0x187DE1F70")]
	public KANFHDNKBAP(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KBHCEKKCKDG<TErr> : KANFHDNKBAP where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr PFBCMJFDKGF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4FD69E0", Offset = "0x4FD5BE0", VA = "0x184FD69E0")]
	private KBHCEKKCKDG([In] TErr HBDPLHDGEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6910", Offset = "0x4FD5B10", VA = "0x184FD6910")]
	public static KBHCEKKCKDG<TErr> OIKMHICCLEP([In] TErr HBDPLHDGEIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BEMMBGIGDEF : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm BGKPKCFENMF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool LMLFLGFNEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool BAFLNGMJNME
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool ANKGFGFDNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF830", Offset = "0x7DDEA30", VA = "0x187DDF830", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long PHGICKGLDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF8A0", Offset = "0x7DDEAA0", VA = "0x187DDF8A0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7DDF910", Offset = "0x7DDEB10", VA = "0x187DDF910", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF7C0", Offset = "0x7DDE9C0", VA = "0x187DDF7C0")]
	public BEMMBGIGDEF(HashAlgorithm BGKPKCFENMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF5F0", Offset = "0x7DDE7F0", VA = "0x187DDF5F0", Slot = "35")]
	public override int Read(byte[] KKCFCHBPMCG, int OEBFFKLMAPN, int KIFHGDECLNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF790", Offset = "0x7DDE990", VA = "0x187DDF790", Slot = "38")]
	public override void Write(byte[] KKCFCHBPMCG, int OEBFFKLMAPN, int KIFHGDECLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF690", Offset = "0x7DDE890", VA = "0x187DDF690", Slot = "33")]
	public override long Seek(long OEBFFKLMAPN, SeekOrigin CGNCLEEPDED)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF720", Offset = "0x7DDE920", VA = "0x187DDF720", Slot = "34")]
	public override void SetLength(long MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF520", Offset = "0x7DDE720", VA = "0x187DDF520")]
	public byte[] IFOIOHPAAHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GEFBDEPLDON
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PLMCPIFAKPI();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JOOGKGIFDEP();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EPIFIECCMDK<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface CHDCNOFNBGL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string ADFCKNAJOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FFJGPPNFDAK<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static FFJGPPNFDAK<T>? JDIHHLKNFIH;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object PBMDDCIIOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? FGCMEEBHBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool JKJPAJBBBIM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool GLGAHOJADMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xD8A840", Offset = "0xD89A40", VA = "0x180D8A840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x499ABA0", Offset = "0x4999DA0", VA = "0x18499ABA0")]
	private static FFJGPPNFDAK<T> JJNAGDAIEAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x499B3A0", Offset = "0x499A5A0", VA = "0x18499B3A0")]
	private static void OKGELIEBMOA(FFJGPPNFDAK<T> PLDJGENNIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x499BBD0", Offset = "0x499ADD0", VA = "0x18499BBD0")]
	private FFJGPPNFDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x499A570", Offset = "0x4999770", VA = "0x18499A570")]
	public static FFJGPPNFDAK<T> EAIFKKLDBGP(ReadOnlyMemory<T> KFMEBMDKDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x499A740", Offset = "0x4999940", VA = "0x18499A740")]
	public static FFJGPPNFDAK<T> EAIFKKLDBGP(IMemoryOwner<T> FBOBCEAENCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x499A950", Offset = "0x4999B50", VA = "0x18499A950")]
	public static void IOINOPBLLLM(FFJGPPNFDAK<T> HBHFCILHFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x499A120", Offset = "0x4999320", VA = "0x18499A120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x499AA90", Offset = "0x4999C90", VA = "0x18499AA90")]
	public FFJGPPNFDAK<T> JBHHHNKAKMJ(IMemoryOwner<T> FBOBCEAENCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x499B2A0", Offset = "0x499A4A0", VA = "0x18499B2A0")]
	private void NNDPANIBCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x499B050", Offset = "0x499A250", VA = "0x18499B050")]
	private FFJGPPNFDAK<T> NKJPDLBBKKC(FFJGPPNFDAK<T> PLDJGENNIJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JNMPIKCCLEO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1F10", Offset = "0x7DE1110", VA = "0x187DE1F10")]
	public JNMPIKCCLEO(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IGDECLHOGGJ<TOk> : JNMPIKCCLEO where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk ODDIHJFJMPN;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4C7E160", Offset = "0x4C7D360", VA = "0x184C7E160")]
	private IGDECLHOGGJ([In] TOk DKPMLCBLCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4C7DFD0", Offset = "0x4C7D1D0", VA = "0x184C7DFD0")]
	public static IGDECLHOGGJ<TOk> OIKMHICCLEP([In] TOk DKPMLCBLCMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct LOAMJJJEMNF<TOk, TErr> : IEquatable<LOAMJJJEMNF<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> JEMCFOMPLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr PFBCMJFDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk ODDIHJFJMPN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool IIEFIJNLDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x50F0620", Offset = "0x50EF820", VA = "0x1850F0620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HGEJPGEHLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x50F0D80", Offset = "0x50EFF80", VA = "0x1850F0D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x50F69C0", Offset = "0x50F5BC0", VA = "0x1850F69C0")]
	internal LOAMJJJEMNF([In] TErr HBDPLHDGEIK, [In] TOk DKPMLCBLCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x50ED5F0", Offset = "0x50EC7F0", VA = "0x1850ED5F0")]
	public static LOAMJJJEMNF<TOk, TErr> DKBOKGMGGMG([In] TErr HBDPLHDGEIK)
	{
		return default(LOAMJJJEMNF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x50F2A80", Offset = "0x50F1C80", VA = "0x1850F2A80")]
	public static LOAMJJJEMNF<TOk, TErr> NMLAEHIKNEH([In] TOk DKPMLCBLCMA)
	{
		return default(LOAMJJJEMNF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F74730", Offset = "0x3F73930", VA = "0x183F74730")]
	public LOAMJJJEMNF<TOk?, UErr?> POMKHIJHJGF<UErr>()
	{
		return default(LOAMJJJEMNF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F74010", Offset = "0x3F73210", VA = "0x183F74010")]
	public LOAMJJJEMNF<UOk?, TErr?> GNOIBEMJGEK<UOk>()
	{
		return default(LOAMJJJEMNF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F725B0", Offset = "0x3F717B0", VA = "0x183F725B0")]
	public LOAMJJJEMNF<UOk?, TErr?> GFIJDONMFHN<UOk>()
	{
		return default(LOAMJJJEMNF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F74250", Offset = "0x3F73450", VA = "0x183F74250")]
	public LOAMJJJEMNF<TOk?, UErr?> IFCAPMIKINF<UErr>()
	{
		return default(LOAMJJJEMNF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x50ED200", Offset = "0x50EC400", VA = "0x1850ED200")]
	public LOAMJJJEMNF<GKPOGNMPJHG, TErr> AJIGNPEMDDO()
	{
		return default(LOAMJJJEMNF<GKPOGNMPJHG, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x50F1290", Offset = "0x50F0490", VA = "0x1850F1290")]
	public static bool NDBPPCEOMJH([In] LOAMJJJEMNF<TOk, TErr> MHEJPNNFCGC, [In] LOAMJJJEMNF<TOk, TErr> BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x50EE1A0", Offset = "0x50ED3A0", VA = "0x1850EE1A0", Slot = "4")]
	public bool Equals(LOAMJJJEMNF<TOk, TErr> FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x50EE5A0", Offset = "0x50ED7A0", VA = "0x1850EE5A0", Slot = "0")]
	public override bool Equals(object FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x50F03D0", Offset = "0x50EF5D0", VA = "0x1850F03D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x50F5670", Offset = "0x50F4870", VA = "0x1850F5670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MHLKMPPNOGC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct FECMMINJALF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<LOAMJJJEMNF<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<LOAMJJJEMNF<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4991D10", Offset = "0x4990F10", VA = "0x184991D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4992350", Offset = "0x4991550", VA = "0x184992350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38F2F30", Offset = "0x38F2130", VA = "0x1838F2F30")]
	public static LOAMJJJEMNF<TOk?, TErr?> ODDIHJFJMPN<TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [In] TOk DKPMLCBLCMA)
	{
		return default(LOAMJJJEMNF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38F2E90", Offset = "0x38F2090", VA = "0x1838F2E90")]
	public static LOAMJJJEMNF<GKPOGNMPJHG, TErr?> ODDIHJFJMPN<TErr>([In] this LOAMJJJEMNF<GKPOGNMPJHG, TErr> CEENCLMGJAM)
	{
		return default(LOAMJJJEMNF<GKPOGNMPJHG, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38F2F30", Offset = "0x38F2130", VA = "0x1838F2F30")]
	public static LOAMJJJEMNF<TOk?, TErr?> PFBCMJFDKGF<TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [In] TErr HBDPLHDGEIK)
	{
		return default(LOAMJJJEMNF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x38F0B10", Offset = "0x38EFD10", VA = "0x1838F0B10")]
	public static TOk? EONHLGGDPAH<TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38F04B0", Offset = "0x38EF6B0", VA = "0x1838F04B0")]
	[AsyncStateMachine(typeof(FECMMINJALF<, >))]
	public static Task<TOk?>? EOKCAHENEKO<TOk, TErr>(this Task<LOAMJJJEMNF<TOk, TErr>> CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x38F1230", Offset = "0x38F0430", VA = "0x1838F1230")]
	public static TErr? IFHLGOEECON<TErr, TOk>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x38F16F0", Offset = "0x38F08F0", VA = "0x1838F16F0")]
	public static bool KABMMLOEGGI<TOk, TErr, UErr, UOk>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [Out] LOAMJJJEMNF<UOk, UErr> BPALPFKICNL) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x38F3100", Offset = "0x38F2300", VA = "0x1838F3100")]
	public static bool OPJJCEIHGMA<TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [Out] TOk DKPMLCBLCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x38F0FB0", Offset = "0x38F01B0", VA = "0x1838F0FB0")]
	public static bool GMNKDMAMLAO<TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [Out][NotNullWhen(true)] TErr HBDPLHDGEIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x38EF7D0", Offset = "0x38EE9D0", VA = "0x1838EF7D0")]
	public static bool BIHKIOOFBBM<TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [Out][NotNullWhen(true)] TOk DKPMLCBLCMA, [Out][NotNullWhen(false)] TErr HBDPLHDGEIK) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x38F0DE0", Offset = "0x38EFFE0", VA = "0x1838F0DE0")]
	public static bool GBDAIKALPHG<TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [Out][NotNullWhen(true)] TOk DKPMLCBLCMA, [Out] LOAMJJJEMNF<TOk, TErr> BPALPFKICNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x38F1A80", Offset = "0x38F0C80", VA = "0x1838F1A80")]
	public static bool KABMMLOEGGI<TOk, TErr, UErr, UOk>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [Out][NotNullWhen(true)] TOk DKPMLCBLCMA, [Out] LOAMJJJEMNF<UOk, UErr> BPALPFKICNL) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x38F2AE0", Offset = "0x38F1CE0", VA = "0x1838F2AE0")]
	public static bool MNDEPEPPLAO<TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [Out][NotNullWhen(true)] TOk DKPMLCBLCMA, [Out] LOAMJJJEMNF<GKPOGNMPJHG, TErr> BPALPFKICNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x38EFC00", Offset = "0x38EEE00", VA = "0x1838EFC00")]
	public static LOAMJJJEMNF<UOk, UErr> CMNLBIDLFCA<UOk, UErr, TOk, TErr>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, [In] LOAMJJJEMNF<UOk, UErr> NIDPEFPJBOO) where TOk : UOk where TErr : UErr
	{
		return default(LOAMJJJEMNF<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x38F3330", Offset = "0x38F2530", VA = "0x1838F3330")]
	public static LOAMJJJEMNF<TOk?[]?, TErr?> PNIIPJFNHOI<TOk, TErr>(this IEnumerable<LOAMJJJEMNF<TOk, TErr>> CEENCLMGJAM)
	{
		return default(LOAMJJJEMNF<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x38F1440", Offset = "0x38F0640", VA = "0x1838F1440")]
	public static LOAMJJJEMNF<UOk?, TErr?> JNJLBJNHEPI<UOk, TErr, TOk>([In] this LOAMJJJEMNF<TOk, TErr> CEENCLMGJAM, Func<TOk, UOk> AJGIDFJCFOL)
	{
		return default(LOAMJJJEMNF<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class AEHLKFDLJBG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E615F0", Offset = "0x2E607F0", VA = "0x182E615F0")]
	public static LOAMJJJEMNF<TOk, T> ODDIHJFJMPN<TOk>([In] TOk DKPMLCBLCMA) where TOk : notnull
	{
		return default(LOAMJJJEMNF<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E5F0", Offset = "0x4A7D7F0", VA = "0x184A7E5F0")]
	public static LOAMJJJEMNF<GKPOGNMPJHG, T> ODDIHJFJMPN()
	{
		return default(LOAMJJJEMNF<GKPOGNMPJHG, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E615F0", Offset = "0x2E607F0", VA = "0x182E615F0")]
	public static LOAMJJJEMNF<T, TErr> PFBCMJFDKGF<TErr>([In] TErr HBDPLHDGEIK) where TErr : notnull
	{
		return default(LOAMJJJEMNF<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct GJMGPCFLMJK<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly KJJFOFPDPHA PKIEGLBIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> BPMPIMPDGDP;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4544820", Offset = "0x4543A20", VA = "0x184544820")]
	public static GJMGPCFLMJK<TKey, TValue> OIKMHICCLEP(string OPJOIGJBJKN)
	{
		return default(GJMGPCFLMJK<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4544940", Offset = "0x4543B40", VA = "0x184544940")]
	internal GJMGPCFLMJK(Dictionary<TKey, TValue> MLCDCHNOCFI, KJJFOFPDPHA KEKOEGODAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4544780", Offset = "0x4543980", VA = "0x184544780")]
	public BPLFMBBNENK<TKey, TValue> DPLFMAFBPCF([Out] Dictionary<TKey, TValue> MLCDCHNOCFI)
	{
		return default(BPLFMBBNENK<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct BPLFMBBNENK<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> BPMPIMPDGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly BACFKGNOKLF LBKHGEBANPB;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x29D1EA0", Offset = "0x29D10A0", VA = "0x1829D1EA0")]
	internal BPLFMBBNENK(Dictionary<TKey, TValue> MLCDCHNOCFI, BACFKGNOKLF LJKDLAKEJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4A80720", Offset = "0x4A7F920", VA = "0x184A80720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct EOBNOBEILJH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly KJJFOFPDPHA PKIEGLBIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> BPMPIMPDGDP;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4544820", Offset = "0x4543A20", VA = "0x184544820")]
	public static EOBNOBEILJH<T> OIKMHICCLEP(string OPJOIGJBJKN)
	{
		return default(EOBNOBEILJH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4544940", Offset = "0x4543B40", VA = "0x184544940")]
	internal EOBNOBEILJH(HashSet<T> MLCDCHNOCFI, KJJFOFPDPHA KEKOEGODAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4544780", Offset = "0x4543980", VA = "0x184544780")]
	public KKGNPCMCBIJ<T> DPLFMAFBPCF([Out] HashSet<T> MLCDCHNOCFI)
	{
		return default(KKGNPCMCBIJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KKGNPCMCBIJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> BPMPIMPDGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BACFKGNOKLF LBKHGEBANPB;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29D1EA0", Offset = "0x29D10A0", VA = "0x1829D1EA0")]
	internal KKGNPCMCBIJ(HashSet<T> MLCDCHNOCFI, BACFKGNOKLF LJKDLAKEJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A80720", Offset = "0x4A7F920", VA = "0x184A80720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct FHDEFNPGBCI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KJJFOFPDPHA PKIEGLBIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> BPMPIMPDGDP;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4544820", Offset = "0x4543A20", VA = "0x184544820")]
	public static FHDEFNPGBCI<T> OIKMHICCLEP(string OPJOIGJBJKN)
	{
		return default(FHDEFNPGBCI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4544940", Offset = "0x4543B40", VA = "0x184544940")]
	internal FHDEFNPGBCI(Stack<T> MLCDCHNOCFI, KJJFOFPDPHA KEKOEGODAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4544780", Offset = "0x4543980", VA = "0x184544780")]
	public AFABHCICOJJ<T> DPLFMAFBPCF([Out] Stack<T> MLCDCHNOCFI)
	{
		return default(AFABHCICOJJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct AFABHCICOJJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> BPMPIMPDGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly BACFKGNOKLF LBKHGEBANPB;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x29D1EA0", Offset = "0x29D10A0", VA = "0x1829D1EA0")]
	internal AFABHCICOJJ(Stack<T> MLCDCHNOCFI, BACFKGNOKLF LJKDLAKEJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4A80720", Offset = "0x4A7F920", VA = "0x184A80720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class PLAHILCPIKM<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct BLOOKGHBDPP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly PLAHILCPIKM<T> OMLFBAHOPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int DLDGCPFKEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool HBOBHDJCHFM;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x268B470", Offset = "0x268A670", VA = "0x18268B470")]
		public BLOOKGHBDPP(PLAHILCPIKM<T> AHLPFPPNCPD, int EKKOLKNAGLE, bool EDMJOMKJKIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x605E2E0", Offset = "0x605D4E0", VA = "0x18605E2E0")]
		public PLAHILCPIKM<T>.GOPMJMOIDBL MAJHBAEJHEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x605E3D0", Offset = "0x605D5D0", VA = "0x18605E3D0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x605E3D0", Offset = "0x605D5D0", VA = "0x18605E3D0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class GOPMJMOIDBL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly PLAHILCPIKM<T> OMLFBAHOPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int GNFMCCGIIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int GDEABMPJNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool HBOBHDJCHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool CFPLFKPCOBN;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9E60", Offset = "0x4AA9060", VA = "0x184AA9E60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9FA0", Offset = "0x4AA91A0", VA = "0x184AA9FA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4AAA270", Offset = "0x4AA9470", VA = "0x184AAA270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4AAA490", Offset = "0x4AA9690", VA = "0x184AAA490")]
		public GOPMJMOIDBL(PLAHILCPIKM<T> AHLPFPPNCPD, int EKKOLKNAGLE, bool EDMJOMKJKIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9EA0", Offset = "0x4AA90A0", VA = "0x184AA9EA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9F30", Offset = "0x4AA9130", VA = "0x184AA9F30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class EPLALPBDEAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EPLALPBDEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x454E180", Offset = "0x454D380", VA = "0x18454E180")]
		internal T MLBJPLDJHGA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] KLFIGACLGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int GDEABMPJNEE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int CMBFABDOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5632800", Offset = "0x5631A00", VA = "0x185632800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T HJBNOIBEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x49869D0", Offset = "0x4985BD0", VA = "0x1849869D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T EIFAEANLFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x56327C0", Offset = "0x56319C0", VA = "0x1856327C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5632620", Offset = "0x5631820", VA = "0x185632620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x25AF920", Offset = "0x25AEB20", VA = "0x1825AF920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A96720", Offset = "0x1A95920", VA = "0x181A96720")]
	private static int IILKBHODFDK(int NIBICIJAIGM, int LMMGFKFHEJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5632930", Offset = "0x5631B30", VA = "0x185632930")]
	public PLAHILCPIKM(int JAFKPMJIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x56329B0", Offset = "0x5631BB0", VA = "0x1856329B0")]
	public PLAHILCPIKM(int JAFKPMJIGFL, Func<T> AEOHHJGJHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5632E90", Offset = "0x5632090", VA = "0x185632E90")]
	public PLAHILCPIKM(T[] FOLAIIIFFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5632860", Offset = "0x5631A60", VA = "0x185632860")]
	public void LHAECOLFPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5632700", Offset = "0x5631900", VA = "0x185632700")]
	public IEnumerable<T> GOMLABNCBCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5632890", Offset = "0x5631A90", VA = "0x185632890")]
	public PLAHILCPIKM<T>.GOPMJMOIDBL MAJHBAEJHEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4A11570", Offset = "0x4A10770", VA = "0x184A11570", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4A11570", Offset = "0x4A10770", VA = "0x184A11570", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KLHOHOOCEOM
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x38B50F0", Offset = "0x38B42F0", VA = "0x1838B50F0")]
	public static PLAHILCPIKM<T> OIKMHICCLEP<T>(int JAFKPMJIGFL, Func<T> AEOHHJGJHDB) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7DE3830", Offset = "0x7DE2A30", VA = "0x187DE3830")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7DE37F0", Offset = "0x7DE29F0", VA = "0x187DE37F0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7DE3810", Offset = "0x7DE2A10", VA = "0x187DE3810")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7DE3850", Offset = "0x7DE2A50", VA = "0x187DE3850")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7DE37D0", Offset = "0x7DE29D0", VA = "0x187DE37D0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x27B5190", Offset = "0x27B4390", VA = "0x1827B5190")]
		public RRColor(float DENDMCHJGLJ, float POMMAOAOILC, float PMDPDEMGJJE, float FCKEKMKDGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C81A50", Offset = "0x7C80C50", VA = "0x187C81A50", Slot = "4")]
		public bool Equals(RRColor FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3420", Offset = "0x7DE2620", VA = "0x187DE3420", Slot = "0")]
		public override bool Equals(object FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7DE3520", Offset = "0x7DE2720", VA = "0x187DE3520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7DE35A0", Offset = "0x7DE27A0", VA = "0x187DE35A0", Slot = "5")]
		public string ToString(string HPCBECKKHGG, IFormatProvider MAMHBLJAPHN)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7DE33C0", Offset = "0x7DE25C0", VA = "0x187DE33C0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7DE3360", Offset = "0x7DE2560", VA = "0x187DE3360")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7DE3390", Offset = "0x7DE2590", VA = "0x187DE3390")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7DE33F0", Offset = "0x7DE25F0", VA = "0x187DE33F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7DE3330", Offset = "0x7DE2530", VA = "0x187DE3330")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C2C0", Offset = "0x5C8B4C0", VA = "0x185C8C2C0")]
		public RRColor32(byte DENDMCHJGLJ, byte POMMAOAOILC, byte PMDPDEMGJJE, byte FCKEKMKDGOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2175BB0", Offset = "0x2174DB0", VA = "0x182175BB0", Slot = "4")]
		public bool Equals(RRColor32 FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2E90", Offset = "0x7DE2090", VA = "0x187DE2E90", Slot = "0")]
		public override bool Equals(object FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x12D61D0", Offset = "0x12D53D0", VA = "0x1812D61D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2F80", Offset = "0x7DE2180", VA = "0x187DE2F80")]
		public static RRColor32 NEKLFDMHCNA(RRColor FLCLDMGPCKH)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2F10", Offset = "0x7DE2110", VA = "0x187DE2F10")]
		public static RRColor NEKLFDMHCNA(RRColor32 FLCLDMGPCKH)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DE30D0", Offset = "0x7DE22D0", VA = "0x187DE30D0", Slot = "5")]
		public string ToString(string HPCBECKKHGG, IFormatProvider MAMHBLJAPHN)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class IJGBDKEGPLN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct JCPJIKBEBHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly IJGBDKEGPLN<T> AOBGKKACOKA;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T ABLHJAOAOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x4EAC740", Offset = "0x4EAB940", VA = "0x184EAC740")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC760", Offset = "0x4EAB960", VA = "0x184EAC760", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
		public JCPJIKBEBHB(IJGBDKEGPLN<T> AOBGKKACOKA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct AJKIJKJHBEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<JCPJIKBEBHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IJGBDKEGPLN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4B62170", Offset = "0x4B61370", VA = "0x184B62170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x498C0A0", Offset = "0x498B2A0", VA = "0x18498C0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim DCOEMFEKAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T ILLGDKFPAIL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4C89FE0", Offset = "0x4C891E0", VA = "0x184C89FE0")]
	public IJGBDKEGPLN([In] T ILLGDKFPAIL, int OBPPGPGMANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4C8A080", Offset = "0x4C89280", VA = "0x184C8A080")]
	public IJGBDKEGPLN([In] T ILLGDKFPAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4C89C00", Offset = "0x4C88E00", VA = "0x184C89C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4C89FA0", Offset = "0x4C891A0", VA = "0x184C89FA0")]
	public JCPJIKBEBHB FDENFLKLPBP()
	{
		return default(JCPJIKBEBHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4C89C40", Offset = "0x4C88E40", VA = "0x184C89C40")]
	[AsyncStateMachine(typeof(IJGBDKEGPLN<>.AJKIJKJHBEH))]
	public Task<IJGBDKEGPLN<T>.JCPJIKBEBHB> EFOCAFDMIOH(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4C89BE0", Offset = "0x4C88DE0", VA = "0x184C89BE0")]
	public void BPGMGCOBECC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KGPNONIBLPE
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1FD0", Offset = "0x7DE11D0", VA = "0x187DE1FD0")]
	public static IJGBDKEGPLN<GKPOGNMPJHG> OIKMHICCLEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3615CF0", Offset = "0x3614EF0", VA = "0x183615CF0")]
	public static IJGBDKEGPLN<T> OIKMHICCLEP<T>([In] T ILLGDKFPAIL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class EANHNEMAGFI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct DJGNMICNEIC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly EANHNEMAGFI<T> AMLHAKMMANM;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T ABLHJAOAOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x500D9E0", Offset = "0x500CBE0", VA = "0x18500D9E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A28120", Offset = "0x6A27320", VA = "0x186A28120", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
		internal DJGNMICNEIC(EANHNEMAGFI<T> AOBGKKACOKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct KGPBFEBPHNO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly EANHNEMAGFI<T> AMLHAKMMANM;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T ABLHJAOAOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x500D9E0", Offset = "0x500CBE0", VA = "0x18500D9E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x500DAA0", Offset = "0x500CCA0", VA = "0x18500DAA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
		internal KGPBFEBPHNO(EANHNEMAGFI<T> AOBGKKACOKA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BIIBCIPJDFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<KGPBFEBPHNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public EANHNEMAGFI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private IJGBDKEGPLN<GKPOGNMPJHG>.JCPJIKBEBHB <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<IJGBDKEGPLN<GKPOGNMPJHG>.JCPJIKBEBHB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5E91FF0", Offset = "0x5E911F0", VA = "0x185E91FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x498C0A0", Offset = "0x498B2A0", VA = "0x18498C0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly IJGBDKEGPLN<int> LICCMMGJFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IJGBDKEGPLN<GKPOGNMPJHG> MMHBCGHIJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IJGBDKEGPLN<GKPOGNMPJHG> PEEJNIOMLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T DCPONLADMFF;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4521230", Offset = "0x4520430", VA = "0x184521230")]
	internal EANHNEMAGFI(IJGBDKEGPLN<int> OEJPKBPJNMD, IJGBDKEGPLN<GKPOGNMPJHG> CKJHIFOGAGL, IJGBDKEGPLN<GKPOGNMPJHG> DHJDMBPJAJD, [In] T ILLGDKFPAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4520A80", Offset = "0x451FC80", VA = "0x184520A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x45208C0", Offset = "0x451FAC0", VA = "0x1845208C0")]
	public DJGNMICNEIC CADFNPGIBLB()
	{
		return default(DJGNMICNEIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4520F60", Offset = "0x4520160", VA = "0x184520F60")]
	public KGPBFEBPHNO PNPAJCFNCBG()
	{
		return default(KGPBFEBPHNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4520D20", Offset = "0x451FF20", VA = "0x184520D20")]
	[AsyncStateMachine(typeof(EANHNEMAGFI<>.BIIBCIPJDFI))]
	public Task<EANHNEMAGFI<T>.KGPBFEBPHNO> KHIALOBPJNI(CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HFJCMGJMKJH
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0A30", Offset = "0x7DDFC30", VA = "0x187DE0A30")]
	public static EANHNEMAGFI<GKPOGNMPJHG> OIKMHICCLEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x382C740", Offset = "0x382B940", VA = "0x18382C740")]
	public static EANHNEMAGFI<T> OIKMHICCLEP<T>([In] T ILLGDKFPAIL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class BJJBLOIKLDP<TData> : DKPIACPJNCE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string FIKKCGNKHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData ALBEJFPMKJB;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
	public override string JOOGKGIFDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5F65EA0", Offset = "0x5F650A0", VA = "0x185F65EA0")]
	internal BJJBLOIKLDP(string BDAAPBJEHGD, [In] TData DHAOEHNLNON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GHPFAEOBNDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7DE09B0", Offset = "0x7DDFBB0", VA = "0x187DE09B0")]
	public static BJJBLOIKLDP<GKPOGNMPJHG> OIKMHICCLEP(string BDAAPBJEHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x36A0B10", Offset = "0x369FD10", VA = "0x1836A0B10")]
	public static BJJBLOIKLDP<TData> OIKMHICCLEP<TData>(string BDAAPBJEHGD, [In] TData DHAOEHNLNON) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class KJJFOFPDPHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool CPBLCCGDDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string NIMONIELEFF;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xE11010", Offset = "0xE10210", VA = "0x180E11010")]
	private KJJFOFPDPHA(bool MFHPKHLJDMC, string PBFBPFMJPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7DE23F0", Offset = "0x7DE15F0", VA = "0x187DE23F0")]
	public static KJJFOFPDPHA OIKMHICCLEP(string PBFBPFMJPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2330", Offset = "0x7DE1530", VA = "0x187DE2330")]
	public BACFKGNOKLF DPLFMAFBPCF()
	{
		return default(BACFKGNOKLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct BACFKGNOKLF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KJJFOFPDPHA MLICHDGCDPE;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	internal BACFKGNOKLF(KJJFOFPDPHA OPJOIGJBJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF500", Offset = "0x7DDE700", VA = "0x187DDF500", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class PHPPOGHKPHP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HLANAEFGPDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HLANAEFGPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4BA3F60", Offset = "0x4BA3160", VA = "0x184BA3F60")]
		internal int PKDEHOPMPDI(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? GJNDLMFGPEJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> KAGMHEKBAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x562A1C0", Offset = "0x56293C0", VA = "0x18562A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ODCFLIDDFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x562A170", Offset = "0x5629370", VA = "0x18562A170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x562A3C0", Offset = "0x56295C0", VA = "0x18562A3C0")]
	public bool OOLDDNFEGEK(T PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x562A250", Offset = "0x5629450", VA = "0x18562A250")]
	public bool KKKHDEJPLIG(T PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x562A200", Offset = "0x5629400", VA = "0x18562A200")]
	public bool HHAMPMLOBIE(T PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x562A090", Offset = "0x5629290", VA = "0x18562A090")]
	public void CMCOPBNKODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x562A580", Offset = "0x5629780", VA = "0x18562A580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PHPPOGHKPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class IHHCNLCAMGC
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NCCHGAIJAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public NCCHGAIJAAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7DE24F0", Offset = "0x7DE16F0", VA = "0x187DE24F0")]
		internal int PKDEHOPMPDI(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? GJNDLMFGPEJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> KAGMHEKBAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7DE17D0", Offset = "0x7DE09D0", VA = "0x187DE17D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool ODCFLIDDFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7DE17C0", Offset = "0x7DE09C0", VA = "0x187DE17C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1960", Offset = "0x7DE0B60", VA = "0x187DE1960")]
	public bool OOLDDNFEGEK(object PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE18C0", Offset = "0x7DE0AC0", VA = "0x187DE18C0")]
	public bool KKKHDEJPLIG(object PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1860", Offset = "0x7DE0A60", VA = "0x187DE1860")]
	public bool HHAMPMLOBIE(object PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1750", Offset = "0x7DE0950", VA = "0x187DE1750")]
	public void CMCOPBNKODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE1A40", Offset = "0x7DE0C40", VA = "0x187DE1A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public IHHCNLCAMGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CDJLKMPKJAG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct OLLNMFHEBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float MIOFIINCDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T ABLHJAOAOGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, OLLNMFHEBCN> IEEHHNMCCEB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T ICABEMKAPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x197AD30", Offset = "0x1979F30", VA = "0x18197AD30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1979B20", Offset = "0x1978D20", VA = "0x181979B20", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? POFLLGPMFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IIHHFONPMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F7F0", Offset = "0x4B1E9F0", VA = "0x184B1F7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x644D040", Offset = "0x644C240", VA = "0x18644D040")]
	public bool DHOBLHFMEFC(T MLCDCHNOCFI, object PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F630", Offset = "0x4B1E830", VA = "0x184B1F630")]
	public bool EJDGOKPPHLI(object PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4A69240", Offset = "0x4A68440", VA = "0x184A69240")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x644D6E0", Offset = "0x644C8E0", VA = "0x18644D6E0")]
	public bool FLFGMEICIOC(object PPOILDCNBFL, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x644BC00", Offset = "0x644AE00", VA = "0x18644BC00")]
	[PLKEPGJEPLK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BGEKCDDPAHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x644D940", Offset = "0x644CB40", VA = "0x18644D940")]
	public CDJLKMPKJAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class NEBOPKIABGF : FGDONFEOMNA<AAILLPLJANG>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class LPBGHLBLKGE : IEqualityComparer<AAILLPLJANG>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly LPBGHLBLKGE NDDGJHHDBNJ;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2460", Offset = "0x7DE1660", VA = "0x187DE2460", Slot = "4")]
		public bool Equals(AAILLPLJANG CCOLDGJALNH, AAILLPLJANG JCBKIOEHCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6F62220", Offset = "0x6F61420", VA = "0x186F62220", Slot = "5")]
		public int GetHashCode(AAILLPLJANG DBCLNEGBNLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LPBGHLBLKGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2790", Offset = "0x7DE1990", VA = "0x187DE2790")]
	public NEBOPKIABGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE26E0", Offset = "0x7DE18E0", VA = "0x187DE26E0", Slot = "4")]
	public override bool OOLDDNFEGEK(AAILLPLJANG PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE25A0", Offset = "0x7DE17A0", VA = "0x187DE25A0", Slot = "5")]
	public override bool KKKHDEJPLIG(AAILLPLJANG PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2650", Offset = "0x7DE1850", VA = "0x187DE2650")]
	private static void NJNCNJHOIFM(AAILLPLJANG PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x188E090", Offset = "0x188D290", VA = "0x18188E090", Slot = "6")]
	protected override string TokenToString(AAILLPLJANG PPOILDCNBFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class AAILLPLJANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string BJHAEGDDGOK;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public AAILLPLJANG(string BJHAEGDDGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7DDF4B0", Offset = "0x7DDE6B0", VA = "0x187DDF4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class FGDONFEOMNA<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> LEABKHICHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? GJNDLMFGPEJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ODCFLIDDFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x499ED80", Offset = "0x499DF80", VA = "0x18499ED80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x499FAD0", Offset = "0x499ECD0", VA = "0x18499FAD0")]
	public FGDONFEOMNA(IEqualityComparer<T> LEABKHICHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x499F0A0", Offset = "0x499E2A0", VA = "0x18499F0A0", Slot = "4")]
	public virtual bool OOLDDNFEGEK(T PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x499EF30", Offset = "0x499E130", VA = "0x18499EF30", Slot = "5")]
	public virtual bool KKKHDEJPLIG(T PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x499ECA0", Offset = "0x499DEA0", VA = "0x18499ECA0")]
	public void CMCOPBNKODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T PPOILDCNBFL);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x499F440", Offset = "0x499E640", VA = "0x18499F440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class NNNGNLOOJFG<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? GJNDLMFGPEJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ODCFLIDDFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x53C0610", Offset = "0x53BF810", VA = "0x1853C0610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x53C08D0", Offset = "0x53BFAD0", VA = "0x1853C08D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x53C0A70", Offset = "0x53BFC70", VA = "0x1853C0A70")]
	public void OOLDDNFEGEK(T PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x53C0730", Offset = "0x53BF930", VA = "0x1853C0730")]
	public void KKKHDEJPLIG(T PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x53C05D0", Offset = "0x53BF7D0", VA = "0x1853C05D0")]
	public void CMCOPBNKODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x53C0CE0", Offset = "0x53BFEE0", VA = "0x1853C0CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NNNGNLOOJFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class IEANGFKFOHB
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3844B40", Offset = "0x3843D40", VA = "0x183844B40")]
	public static void ILIMKGBDIAO<T>(this List<T> MEHAOGGFJIO, int NIBICIJAIGM) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class HEIPOKBBEGC<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct DKGNCIEFEMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float MIOFIINCDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T ABLHJAOAOGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<AAILLPLJANG, DKGNCIEFEMH> IEEHHNMCCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> DPAKLGFGBLH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T ICABEMKAPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private AAILLPLJANG? POFLLGPMFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool IIHHFONPMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F7F0", Offset = "0x4B1E9F0", VA = "0x184B1F7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F410", Offset = "0x4B1E610", VA = "0x184B1F410")]
	public bool DHOBLHFMEFC(T MLCDCHNOCFI, AAILLPLJANG PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F630", Offset = "0x4B1E830", VA = "0x184B1F630")]
	public bool EJDGOKPPHLI(AAILLPLJANG PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4A69240", Offset = "0x4A68440", VA = "0x184A69240")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F6D0", Offset = "0x4B1E8D0", VA = "0x184B1F6D0")]
	public bool FLFGMEICIOC(AAILLPLJANG PPOILDCNBFL, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4B1EE70", Offset = "0x4B1E070", VA = "0x184B1EE70")]
	[PLKEPGJEPLK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BGEKCDDPAHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F9A0", Offset = "0x4B1EBA0", VA = "0x184B1F9A0")]
	public HEIPOKBBEGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KIGJLPCAPLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> IEEHHNMCCEB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float CIFCCIPANBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xEE8B50", Offset = "0xEE7D50", VA = "0x180EE8B50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xEE8B60", Offset = "0xEE7D60", VA = "0x180EE8B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2040", Offset = "0x7DE1240", VA = "0x187DE2040")]
	public void DHOBLHFMEFC(float MLCDCHNOCFI, object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7DE20B0", Offset = "0x7DE12B0", VA = "0x187DE20B0")]
	public void EJDGOKPPHLI(object PPOILDCNBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2120", Offset = "0x7DE1320", VA = "0x187DE2120")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2170", Offset = "0x7DE1370", VA = "0x187DE2170")]
	private void PNOCDABADEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7DE22A0", Offset = "0x7DE14A0", VA = "0x187DE22A0")]
	public KIGJLPCAPLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LIJKHOFENFD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HOBIDMFELEB HBIIFHAAGAG;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class EGOLNJDEEMP : LIJKHOFENFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct IDDBIGMBCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float MBLDJPNEDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float DJEBEGAHKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool KJALJJOFOOG;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float LDPBGKCICAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x7DE0BE0", Offset = "0x7DDFDE0", VA = "0x187DE0BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0D50", Offset = "0x7DDFF50", VA = "0x187DE0D50")]
		public IDDBIGMBCON(float CAECICLJFEI, float KAFOOAGKGFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0BF0", Offset = "0x7DDFDF0", VA = "0x187DE0BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class PNCOMMCPCAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EGOLNJDEEMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PNCOMMCPCAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2DB0", Offset = "0x7DE1FB0", VA = "0x187DE2DB0")]
		internal void JHBIHHPBDNN(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int PIBKMAHMMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int FHBPGEOBHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly LIJKHOFENFD[] FOIOCENOIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly HOBIDMFELEB[] OIONFMJBFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IDDBIGMBCON[] DBAFHFGOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private IDDBIGMBCON IINEJKHFFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NPIJPEFDCBH JELGBKAOJNC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event HOBIDMFELEB HBIIFHAAGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE01A0", Offset = "0x7DDF3A0", VA = "0x187DE01A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0260", Offset = "0x7DDF460", VA = "0x187DE0260", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0820", Offset = "0x7DDFA20", VA = "0x187DE0820")]
	public EGOLNJDEEMP(int PIBKMAHMMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0320", Offset = "0x7DDF520", VA = "0x187DE0320")]
	public NPIJPEFDCBH IDFAPICGJHB(IDDBIGMBCON IKOPOIHFBKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7DE03B0", Offset = "0x7DDF5B0", VA = "0x187DE03B0")]
	public void LFOIJEKOKJO(LIJKHOFENFD FFMCKEOIONK, [Optional] IDDBIGMBCON OJGMHCLOFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7DE0090", Offset = "0x7DDF290", VA = "0x187DE0090", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void HOBIDMFELEB(float IMNNIMPHNKE);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class OPHGOLKFBPJ
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class HNDCHIDHGDI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly LIJKHOFENFD HIJALMHJFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly HOBIDMFELEB LKEPFHDAAED;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0B50", Offset = "0x7DDFD50", VA = "0x187DE0B50")]
		public HNDCHIDHGDI(LIJKHOFENFD HIJALMHJFJH, HOBIDMFELEB LKEPFHDAAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7DE0B00", Offset = "0x7DDFD00", VA = "0x187DE0B00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2D00", Offset = "0x7DE1F00", VA = "0x187DE2D00")]
	internal static bool LOBLCMEHCGL(float FCKEKMKDGOB, float PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7DD10B0", Offset = "0x7DD02B0", VA = "0x187DD10B0")]
	internal static float EDCDCFNHJJO(float FCKEKMKDGOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2C40", Offset = "0x7DE1E40", VA = "0x187DE2C40")]
	public static IDisposable BOGGLKKDHIL(this LIJKHOFENFD HIJALMHJFJH, HOBIDMFELEB LKEPFHDAAED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NPIJPEFDCBH : LIJKHOFENFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float IMNNIMPHNKE;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float PBOBMECHMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2800", Offset = "0x7DE1A00", VA = "0x187DE2800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event HOBIDMFELEB? HBIIFHAAGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7DE28F0", Offset = "0x7DE1AF0", VA = "0x187DE28F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE2990", Offset = "0x7DE1B90", VA = "0x187DE2990", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NPIJPEFDCBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface GONFMGBJBMA<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONIILEFMLKH<T> CANMOBCCPFJ([Out] T MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKFEALEGJFP();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class AJMBAKAADCG<T> : GONFMGBJBMA<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> HHEOFAKJKPC;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4B62890", Offset = "0x4B61A90", VA = "0x184B62890", Slot = "4")]
	public ONIILEFMLKH<T> CANMOBCCPFJ([Out] T MLCDCHNOCFI)
	{
		return default(ONIILEFMLKH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4B62930", Offset = "0x4B61B30", VA = "0x184B62930")]
	public void EFCGIOJACBM(T KDGCCGEBMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x498C180", Offset = "0x498B380", VA = "0x18498C180", Slot = "5")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "6")]
	protected virtual void PDNGLOOEJNJ(T POBHDCNLCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4B629B0", Offset = "0x4B61BB0", VA = "0x184B629B0")]
	private T HKFPFFCEPKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4B62A50", Offset = "0x4B61C50", VA = "0x184B62A50")]
	public AJMBAKAADCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct ONIILEFMLKH<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T KDGCCGEBMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly AJMBAKAADCG<T> PLCKFFFKLMB;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
	internal ONIILEFMLKH(T MLCDCHNOCFI, AJMBAKAADCG<T> PLCKFFFKLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5541290", Offset = "0x5540490", VA = "0x185541290", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class OHKAMIMJAHO : AJMBAKAADCG<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly OHKAMIMJAHO NDDGJHHDBNJ;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2AB0", Offset = "0x7DE1CB0", VA = "0x187DE2AB0")]
	public static ONIILEFMLKH<StringBuilder> HKFPFFCEPKK([Out] StringBuilder MLCDCHNOCFI)
	{
		return default(ONIILEFMLKH<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2B50", Offset = "0x7DE1D50", VA = "0x187DE2B50", Slot = "6")]
	protected override void PDNGLOOEJNJ(StringBuilder POBHDCNLCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7DE2C00", Offset = "0x7DE1E00", VA = "0x187DE2C00")]
	public OHKAMIMJAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AKMAFBHLNEL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x76A8C10", Offset = "0x76A7E10", VA = "0x1876A8C10")]
	public AKMAFBHLNEL(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class FGKFKPOCMLG<TKey, TValue> : COLIPCNCPGI<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, FBGIJAHFLAB where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class FHLLABLDMPP : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public FGKFKPOCMLG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x197AD30", Offset = "0x1979F30", VA = "0x18197AD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x49A89E0", Offset = "0x49A7BE0", VA = "0x1849A89E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public FHLLABLDMPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x49A8A30", Offset = "0x49A7C30", VA = "0x1849A8A30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x49A7D70", Offset = "0x49A6F70", VA = "0x1849A7D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x49A7B90", Offset = "0x49A6D90", VA = "0x1849A7B90")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x49A7CD0", Offset = "0x49A6ED0", VA = "0x1849A7CD0")]
		private void GCCIFBPGOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x49A88B0", Offset = "0x49A7AB0", VA = "0x1849A88B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly COLIPCNCPGI<TKey, TValue> DKNIPPPONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> BCNENBIMCKK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x49A5080", Offset = "0x49A4280", VA = "0x1849A5080", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FDKDJBEEIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x49A5150", Offset = "0x49A4350", VA = "0x1849A5150", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x49A53E0", Offset = "0x49A45E0", VA = "0x1849A53E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> NDCACBKNNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x49A51A0", Offset = "0x49A43A0", VA = "0x1849A51A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> KIMMFFMKHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x49A52C0", Offset = "0x49A44C0", VA = "0x1849A52C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x49A4FC0", Offset = "0x49A41C0", VA = "0x1849A4FC0")]
	public FGKFKPOCMLG(COLIPCNCPGI<TKey, TValue> DKNIPPPONKJ, [Optional] IDictionary<TKey, TValue>? BCNENBIMCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x49A3B60", Offset = "0x49A2D60", VA = "0x1849A3B60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x49A3B10", Offset = "0x49A2D10", VA = "0x1849A3B10")]
	public void CHCNMOFAMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x49A3890", Offset = "0x49A2A90", VA = "0x1849A3890", Slot = "9")]
	public void Add(TKey AGBHGDFILGO, TValue MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x49A44E0", Offset = "0x49A36E0", VA = "0x1849A44E0")]
	public void NDJBHJIGEIP(TKey AGBHGDFILGO, TValue MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x49A4350", Offset = "0x49A3550", VA = "0x1849A4350")]
	public void IDPBHEBPIDH(TKey AGBHGDFILGO, TValue MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x49A3EF0", Offset = "0x49A30F0", VA = "0x1849A3EF0")]
	public void GFKAHEJJNNF(TKey AGBHGDFILGO, TValue MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x49A4780", Offset = "0x49A3980", VA = "0x1849A4780")]
	public void OMAKHEAGEIP(TKey AGBHGDFILGO, TValue MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x49A4A10", Offset = "0x49A3C10", VA = "0x1849A4A10", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x49A4A60", Offset = "0x49A3C60", VA = "0x1849A4A60", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x49A4C20", Offset = "0x49A3E20", VA = "0x1849A4C20", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x49A3BF0", Offset = "0x49A2DF0", VA = "0x1849A3BF0", Slot = "8")]
	public bool ContainsKey(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x49A4120", Offset = "0x49A3320", VA = "0x1849A4120")]
	public bool GPHGBEOMNAJ(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x49A4290", Offset = "0x49A3490", VA = "0x1849A4290")]
	public bool HGINLCAHMCN(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x49A4870", Offset = "0x49A3A70", VA = "0x1849A4870", Slot = "10")]
	public bool Remove(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x49A4E20", Offset = "0x49A4020", VA = "0x1849A4E20", Slot = "11")]
	public bool TryGetValue(TKey AGBHGDFILGO, [Out] TValue MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x49A3CB0", Offset = "0x49A2EB0", VA = "0x1849A3CB0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CABEAFGDMFF, int KLEAEAJOBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x49A4DE0", Offset = "0x49A3FE0", VA = "0x1849A4DE0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x49A41E0", Offset = "0x49A33E0", VA = "0x1849A41E0", Slot = "19")]
	[IteratorStateMachine(typeof(FGKFKPOCMLG<, >.FHLLABLDMPP))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x49A3AC0", Offset = "0x49A2CC0", VA = "0x1849A3AC0", Slot = "21")]
	public bool BNKJABINFCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x49A4670", Offset = "0x49A3870", VA = "0x1849A4670")]
	private TValue NKGOCLAGJFC(TKey AGBHGDFILGO)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface EGAAGPBKACM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string OPJCHGKECPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface FBGIJAHFLAB
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNKJABINFCD();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface COLIPCNCPGI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FBGIJAHFLAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class JBIBALGPAGF<TKey, TVal> : COLIPCNCPGI<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FBGIJAHFLAB where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int GDPJHFMGHME(TKey AGBHGDFILGO, TVal MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void KFJABJFCCJN(TKey AGBHGDFILGO, TVal MLCDCHNOCFI, HNAGFNJIFEE BPAILNFLNFH);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class LFPCEIBNBLK
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal ABLHJAOAOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int LDPBGKCICAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset ICACIHMCHCC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x12A6210", Offset = "0x12A5410", VA = "0x1812A6210")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x12A62F0", Offset = "0x12A54F0", VA = "0x1812A62F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x50C4590", Offset = "0x50C3790", VA = "0x1850C4590")]
		public LFPCEIBNBLK(TKey AGBHGDFILGO, TVal KFEGNKODPFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class JPAJAPKNACO : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public JBIBALGPAGF<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<LFPCEIBNBLK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x197AD30", Offset = "0x1979F30", VA = "0x18197AD30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x4F0CFC0", Offset = "0x4F0C1C0", VA = "0x184F0CFC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public JPAJAPKNACO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4534380", Offset = "0x4533580", VA = "0x184534380", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4F0BBD0", Offset = "0x4F0ADD0", VA = "0x184F0BBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F0A3B0", Offset = "0x4F095B0", VA = "0x184F0A3B0")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4F0CE80", Offset = "0x4F0C080", VA = "0x184F0CE80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int NNEIBMLPJDH = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<LFPCEIBNBLK>> IOIKELIKBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<LFPCEIBNBLK> MCCKMONGDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly GDPJHFMGHME? AOOJMBDAJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan BFIECLBIJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly KFJABJFCCJN? JAIOOHHLDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OHHLIEHJBIN DIEAFJEPIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool CDLPEMNGEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> OGBPDNJKFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> CHONKHLLHBJ;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int JDBAJODHLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int LAKFKGLEGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xD34EE0", Offset = "0xD340E0", VA = "0x180D34EE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xE750A0", Offset = "0xE742A0", VA = "0x180E750A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4E95150", Offset = "0x4E94350", VA = "0x184E95150", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int OLEANEMCFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4A69240", Offset = "0x4A68440", VA = "0x184A69240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> KIMMFFMKHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4E952D0", Offset = "0x4E944D0", VA = "0x184E952D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.ECJAGJBCABE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E90F50", Offset = "0x4E90150", VA = "0x184E90F50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool FDKDJBEEIID
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4E95240", Offset = "0x4E94440", VA = "0x184E95240", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4E95320", Offset = "0x4E94520", VA = "0x184E95320", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FEC0", Offset = "0x4E8F0C0", VA = "0x184E8FEC0")]
	private bool NJGBMEPFLBG(int PIBKMAHMMLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FA10", Offset = "0x4E8EC10", VA = "0x184E8FA10")]
	private void LLGMNFFHMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E92BB0", Offset = "0x4E91DB0", VA = "0x184E92BB0")]
	public JBIBALGPAGF(int PIBKMAHMMLH, [Optional] GDPJHFMGHME? AOOJMBDAJOC, [Optional] IEqualityComparer<TKey>? JMGOAMAODFP, [Optional] KFJABJFCCJN? JAIOOHHLDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E91BE0", Offset = "0x4E90DE0", VA = "0x184E91BE0")]
	public JBIBALGPAGF(TimeSpan BFIECLBIJMK, [Optional] IEqualityComparer<TKey>? JMGOAMAODFP, [Optional] KFJABJFCCJN? JAIOOHHLDAI, [Optional] OHHLIEHJBIN? DIEAFJEPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E920B0", Offset = "0x4E912B0", VA = "0x184E920B0")]
	public JBIBALGPAGF(int PIBKMAHMMLH, TimeSpan BFIECLBIJMK, [Optional] IEqualityComparer<TKey>? JMGOAMAODFP, [Optional] KFJABJFCCJN? JAIOOHHLDAI, [Optional] OHHLIEHJBIN? DIEAFJEPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4E931D0", Offset = "0x4E923D0", VA = "0x184E931D0")]
	public JBIBALGPAGF(int PIBKMAHMMLH, GDPJHFMGHME? AOOJMBDAJOC, TimeSpan BFIECLBIJMK, [Optional] IEqualityComparer<TKey>? JMGOAMAODFP, [Optional] KFJABJFCCJN? JAIOOHHLDAI, [Optional] OHHLIEHJBIN? DIEAFJEPIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4E857B0", Offset = "0x4E849B0", VA = "0x184E857B0", Slot = "21")]
	public bool BNKJABINFCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F490", Offset = "0x4E8E690", VA = "0x184E8F490", Slot = "22")]
	public bool IPBKFPPDFNJ(int JAFKPMJIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E81CA0", Offset = "0x4E80EA0", VA = "0x184E81CA0")]
	private bool BLOMPAFPDCM(int JAFKPMJIGFL, HNAGFNJIFEE BPAILNFLNFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E88280", Offset = "0x4E87480", VA = "0x184E88280")]
	public void DENBCCCLIHH(TKey AGBHGDFILGO, TVal MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E80E90", Offset = "0x4E80090", VA = "0x184E80E90", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E80EE0", Offset = "0x4E800E0", VA = "0x184E80EE0", Slot = "9")]
	public void Add(TKey AGBHGDFILGO, TVal MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E85B40", Offset = "0x4E84D40", VA = "0x184E85B40", Slot = "8")]
	public bool ContainsKey(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E90700", Offset = "0x4E8F900", VA = "0x184E90700", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FF10", Offset = "0x4E8F110", VA = "0x184E8FF10", Slot = "10")]
	public bool Remove(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E90A70", Offset = "0x4E8FC70", VA = "0x184E90A70", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C590", Offset = "0x4E8B790", VA = "0x184E8C590")]
	private bool HIIFFDCKMGN(TKey AGBHGDFILGO, [Out] TVal MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D070", Offset = "0x4E8C270", VA = "0x184E8D070")]
	private TVal HKFPFFCEPKK(TKey AAHHAPOLENF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4E919E0", Offset = "0x4E90BE0", VA = "0x184E919E0", Slot = "11")]
	public bool TryGetValue(TKey AAHHAPOLENF, [Out] TVal MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4E85850", Offset = "0x4E84A50", VA = "0x184E85850", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4E86CA0", Offset = "0x4E85EA0", VA = "0x184E86CA0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CABEAFGDMFF, int KLEAEAJOBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D4B0", Offset = "0x4E8C6B0", VA = "0x184E8D4B0")]
	private void IELAGAAIEJC(TKey AGBHGDFILGO, TVal KFEGNKODPFP, HNAGFNJIFEE BPAILNFLNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B130", Offset = "0x4E8A330", VA = "0x184E8B130")]
	private bool EHIILBDADLN(LFPCEIBNBLK MNCAIAGKOBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4E7EC50", Offset = "0x4E7DE50", VA = "0x184E7EC50")]
	private void APMIOGHECAB(LinkedListNode<LFPCEIBNBLK> MKHGDAMPLLO, TVal INDHDEDDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4E898D0", Offset = "0x4E88AD0", VA = "0x184E898D0")]
	private void DHOBLHFMEFC(TKey AGBHGDFILGO, TVal MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E8EAF0", Offset = "0x4E8DCF0", VA = "0x184E8EAF0")]
	private void IGDBKGGKEMO(LFPCEIBNBLK MNCAIAGKOBP, TVal INDHDEDDIPE, int NCANCFPGAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B740", Offset = "0x4E8A940", VA = "0x184E8B740", Slot = "19")]
	[IteratorStateMachine(typeof(JBIBALGPAGF<, >.JPAJAPKNACO))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E90FA0", Offset = "0x4E901A0", VA = "0x184E90FA0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum HNAGFNJIFEE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NPMKBPDKNDC<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey BIFPMDOBECH;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x53C7C50", Offset = "0x53C6E50", VA = "0x1853C7C50")]
	public NPMKBPDKNDC(TKey MNACMBNCPFL, Exception DBEGDJHGEMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class BFOECDMHNDH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9240", Offset = "0x6EF8440", VA = "0x186EF9240")]
	public BFOECDMHNDH(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class KACGMINCHLD<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class CEDFLOFKBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public KACGMINCHLD<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CEDFLOFKBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x644FF70", Offset = "0x644F170", VA = "0x18644FF70")]
		internal Task<TResource> LKLEFJMPDPA(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct KADDIMKKJMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public KACGMINCHLD<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4FC9F80", Offset = "0x4FC9180", VA = "0x184FC9F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x4FCAB60", Offset = "0x4FC9D60", VA = "0x184FCAB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct HMDFCGGFJBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA060", Offset = "0x4BA9260", VA = "0x184BAA060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4BAA7C0", Offset = "0x4BA99C0", VA = "0x184BAA7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly POLKNEKONFN<TId, Task<TResource>> CNFNCINOEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> FOFLONMEKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? INLMNDMJNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? FMEBKFIIEPK;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4FC9DB0", Offset = "0x4FC8FB0", VA = "0x184FC9DB0")]
	public KACGMINCHLD(int AAJLDOONBPL = 0, [Optional] IEqualityComparer<TId>? IFOIGMDDNFB, [Optional] Func<TId, CancellationToken, Task<TResource>>? FFFIDGNAACE, [Optional] Action<TResource>? IBEJFHBLEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4FC9A00", Offset = "0x4FC8C00", VA = "0x184FC9A00")]
	public LGILIJIJPGJ<Task<TResource>> OGCDKJLAAHO(TId MKHHKDJKLDN, [Optional] Func<TId, CancellationToken, Task<TResource>>? FFFIDGNAACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4FC9230", Offset = "0x4FC8430", VA = "0x184FC9230")]
	private void OEOOAOLMMGM(Task<TResource> LDLKICLCOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4FC8EF0", Offset = "0x4FC80F0", VA = "0x184FC8EF0")]
	[AsyncStateMachine(typeof(KACGMINCHLD<, >.KADDIMKKJMF))]
	private Task MMONEHDHEBL(Task<TResource> LDLKICLCOAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4C80580", Offset = "0x4C7F780", VA = "0x184C80580")]
	public void FANGCAGBFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4FC8B00", Offset = "0x4FC7D00", VA = "0x184FC8B00")]
	public POLKNEKONFN<TId, Task<TResource>>.HKCHNPFMJKC MAJHBAEJHEK()
	{
		return default(POLKNEKONFN<TId, Task<TResource>>.HKCHNPFMJKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4FC9D10", Offset = "0x4FC8F10", VA = "0x184FC9D10", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4FC9D10", Offset = "0x4FC8F10", VA = "0x184FC9D10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4FC86F0", Offset = "0x4FC78F0", VA = "0x184FC86F0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(KACGMINCHLD<, >.HMDFCGGFJBA))]
	internal static Task KBKPDFKGJGO(Task<TResource> LDLKICLCOAG, CancellationTokenSource HLIKNJCPCJO, Dictionary<Task<TResource>, CancellationTokenSource> JOGFNBLBKAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class POLKNEKONFN<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class LBMJPMIDCCH : IEquatable<LBMJPMIDCCH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue ABLHJAOAOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int DMPKELCENOJ;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x11C8070", Offset = "0x11C7270", VA = "0x1811C8070")]
		public LBMJPMIDCCH(TValue MLCDCHNOCFI, int LFJNDKIABBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x50BA130", Offset = "0x50B9330", VA = "0x1850BA130", Slot = "4")]
		public bool Equals(LBMJPMIDCCH? FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x50BA1C0", Offset = "0x50B93C0", VA = "0x1850BA1C0", Slot = "0")]
		public override bool Equals(object? DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x50BA260", Offset = "0x50B9460", VA = "0x1850BA260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct HKCHNPFMJKC : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, LBMJPMIDCCH>.Enumerator JCFDIHBGNPF;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x4B9F9B0", Offset = "0x4B9EBB0", VA = "0x184B9F9B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4B9FD60", Offset = "0x4B9EF60", VA = "0x184B9FD60", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4B9FC90", Offset = "0x4B9EE90", VA = "0x184B9FC90")]
		public HKCHNPFMJKC(POLKNEKONFN<TKey, TValue> IEEHHNMCCEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4B9F560", Offset = "0x4B9E760", VA = "0x184B9F560", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4B9F5A0", Offset = "0x4B9E7A0", VA = "0x184B9F5A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4B9F710", Offset = "0x4B9E910", VA = "0x184B9F710", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class JOFLHADMGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public POLKNEKONFN<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public LBMJPMIDCCH refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JOFLHADMGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4F09D70", Offset = "0x4F08F70", VA = "0x184F09D70")]
		internal void LKLEFJMPDPA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, LBMJPMIDCCH> IPDAJPMCGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? BPNMFGCFBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? OOHHKGEMDMI;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x563DEE0", Offset = "0x563D0E0", VA = "0x18563DEE0")]
	public POLKNEKONFN(int AAJLDOONBPL = 0, [Optional] IEqualityComparer<TKey>? JMGOAMAODFP, [Optional] Func<TKey, TValue>? KBNGKHNILKA, [Optional] Action<TValue>? JCAMDMBPPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x563D440", Offset = "0x563C640", VA = "0x18563D440")]
	public LGILIJIJPGJ<TValue> OGCDKJLAAHO(TKey AGBHGDFILGO, [Optional] Func<TKey, TValue>? PMJCKNEMFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x563CCE0", Offset = "0x563BEE0", VA = "0x18563CCE0")]
	private void EFCGIOJACBM(TKey AGBHGDFILGO, LBMJPMIDCCH DGCOOOIGBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x563CF60", Offset = "0x563C160", VA = "0x18563CF60")]
	public void FANGCAGBFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x563D400", Offset = "0x563C600", VA = "0x18563D400")]
	public HKCHNPFMJKC MAJHBAEJHEK()
	{
		return default(HKCHNPFMJKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x563DE40", Offset = "0x563D040", VA = "0x18563DE40", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x563DE40", Offset = "0x563D040", VA = "0x18563DE40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
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
