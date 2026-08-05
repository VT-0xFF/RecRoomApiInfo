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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C4CB80", Offset = "0x7C4B380", VA = "0x187C4CB80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CFDGBFDBLBG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	protected CFDGBFDBLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OMBCNGCGMEE<T> : CFDGBFDBLBG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct PMOLFAMFCKD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum CDLHNIDJCGH
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
		public CDLHNIDJCGH PIJHKCJDAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T GFMBHCHPLDH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int EHJHNKFJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool OFKIKOLOIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool FGJHPDCNIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? FGCIPPFCDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<PMOLFAMFCKD>? KGBHJFCIMJB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MDPCKAPGGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x547DEE0", Offset = "0x547C6E0", VA = "0x18547DEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x547E900", Offset = "0x547D100", VA = "0x18547E900")]
	protected OMBCNGCGMEE(bool FGJHPDCNIEH, bool OFKIKOLOIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x547E230", Offset = "0x547CA30", VA = "0x18547E230")]
	protected bool GALNCECJHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x547E110", Offset = "0x547C910", VA = "0x18547E110")]
	protected void BIIIMGLBCCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x547E2D0", Offset = "0x547CAD0", VA = "0x18547E2D0")]
	protected void HHDKFCAMBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1CD0", Offset = "0x3EA04D0", VA = "0x183EA1CD0")]
	private static void DNPNJKMALLO<U>(List<U>? GIPAMJGJGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x547E6F0", Offset = "0x547CEF0", VA = "0x18547E6F0", Slot = "4")]
	public void OIHLAKEIFNH(T GFMBHCHPLDH, bool IPLFFNENNEF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x547DF40", Offset = "0x547C740", VA = "0x18547DF40", Slot = "5")]
	public void AHELLINFOCL(T GFMBHCHPLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x547E540", Offset = "0x547CD40", VA = "0x18547E540")]
	public void NNEMBDPLFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FIEKIAHLEMJ : OMBCNGCGMEE<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C3C0", Offset = "0x7C4ABC0", VA = "0x187C4C3C0")]
	public FIEKIAHLEMJ(bool FGJHPDCNIEH = false, bool OFKIKOLOIHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C160", Offset = "0x7C4A960", VA = "0x187C4C160")]
	public void GINPGABDCGP()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C360", Offset = "0x7C4AB60", VA = "0x187C4C360")]
	public static FIEKIAHLEMJ LGJHMHOMCNN(FIEKIAHLEMJ PMADIJLIHFD, Action GFMBHCHPLDH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C100", Offset = "0x7C4A900", VA = "0x187C4C100")]
	public static FIEKIAHLEMJ APCOPOMHNFL(FIEKIAHLEMJ PMADIJLIHFD, Action GFMBHCHPLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GJCLHNBJFNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIHLAKEIFNH(Action<T> GFMBHCHPLDH, bool IPLFFNENNEF = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHELLINFOCL(Action<T> GFMBHCHPLDH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HOPADDCECBJ<T> : OMBCNGCGMEE<Action<T>>, GJCLHNBJFNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48E8AC0", Offset = "0x48E72C0", VA = "0x1848E8AC0")]
	public HOPADDCECBJ(bool FGJHPDCNIEH = false, bool OFKIKOLOIHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A99880", Offset = "0x4A98080", VA = "0x184A99880")]
	public void GINPGABDCGP(T NACLDKPPPKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FEA0", Offset = "0x4A2E6A0", VA = "0x184A2FEA0")]
	public static HOPADDCECBJ<T> LGJHMHOMCNN(HOPADDCECBJ<T> PMADIJLIHFD, Action<T> GFMBHCHPLDH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F2E0", Offset = "0x4A2DAE0", VA = "0x184A2F2E0")]
	public static HOPADDCECBJ<T> APCOPOMHNFL(HOPADDCECBJ<T> PMADIJLIHFD, Action<T> GFMBHCHPLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FFOACGGAIDA<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIHLAKEIFNH(Action<T, U> GFMBHCHPLDH, bool IPLFFNENNEF = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHELLINFOCL(Action<T, U> GFMBHCHPLDH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class LLDDHLANFDF<T, U> : OMBCNGCGMEE<Action<T, U>>, FFOACGGAIDA<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x48E8AC0", Offset = "0x48E72C0", VA = "0x1848E8AC0")]
	public LLDDHLANFDF(bool FGJHPDCNIEH = false, bool OFKIKOLOIHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5008CE0", Offset = "0x50074E0", VA = "0x185008CE0")]
	public void GINPGABDCGP(T NACLDKPPPKG, U EOBFBGBIGDL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FEA0", Offset = "0x4A2E6A0", VA = "0x184A2FEA0")]
	public static LLDDHLANFDF<T, U> LGJHMHOMCNN(LLDDHLANFDF<T, U> PMADIJLIHFD, Action<T, U> GFMBHCHPLDH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F2E0", Offset = "0x4A2DAE0", VA = "0x184A2F2E0")]
	public static LLDDHLANFDF<T, U> APCOPOMHNFL(LLDDHLANFDF<T, U> PMADIJLIHFD, Action<T, U> GFMBHCHPLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PBNCAGPCDPH<T, U, V> : OMBCNGCGMEE<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x48E8AC0", Offset = "0x48E72C0", VA = "0x1848E8AC0")]
	public PBNCAGPCDPH(bool FGJHPDCNIEH = false, bool OFKIKOLOIHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x554BE10", Offset = "0x554A610", VA = "0x18554BE10")]
	public void GINPGABDCGP(T NACLDKPPPKG, U EOBFBGBIGDL, V AALALMNDJKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FEA0", Offset = "0x4A2E6A0", VA = "0x184A2FEA0")]
	public static PBNCAGPCDPH<T, U, V> LGJHMHOMCNN(PBNCAGPCDPH<T, U, V> PMADIJLIHFD, Action<T, U, V> GFMBHCHPLDH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F2E0", Offset = "0x4A2DAE0", VA = "0x184A2F2E0")]
	public static PBNCAGPCDPH<T, U, V> APCOPOMHNFL(PBNCAGPCDPH<T, U, V> PMADIJLIHFD, Action<T, U, V> GFMBHCHPLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CAHIKKNKIGN<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class KLPKNACDLEP<T, U, V, W> : OMBCNGCGMEE<Action<T, U, V, W>>, CAHIKKNKIGN<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x48E8AC0", Offset = "0x48E72C0", VA = "0x1848E8AC0")]
	public KLPKNACDLEP(bool FGJHPDCNIEH = false, bool OFKIKOLOIHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F315B0", Offset = "0x4F2FDB0", VA = "0x184F315B0")]
	public void GINPGABDCGP(T NACLDKPPPKG, U EOBFBGBIGDL, V AALALMNDJKO, W FHHDKECCOLA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FEA0", Offset = "0x4A2E6A0", VA = "0x184A2FEA0")]
	public static KLPKNACDLEP<T, U, V, W> LGJHMHOMCNN(KLPKNACDLEP<T, U, V, W> PMADIJLIHFD, Action<T, U, V, W> GFMBHCHPLDH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F2E0", Offset = "0x4A2DAE0", VA = "0x184A2F2E0")]
	public static KLPKNACDLEP<T, U, V, W> APCOPOMHNFL(KLPKNACDLEP<T, U, V, W> PMADIJLIHFD, Action<T, U, V, W> GFMBHCHPLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LAMJEAHCDEM<T, U, V, W, X> : OMBCNGCGMEE<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48E8AC0", Offset = "0x48E72C0", VA = "0x1848E8AC0")]
	public LAMJEAHCDEM(bool FGJHPDCNIEH = false, bool OFKIKOLOIHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4FC4B70", Offset = "0x4FC3370", VA = "0x184FC4B70")]
	public void GINPGABDCGP(T NACLDKPPPKG, U EOBFBGBIGDL, V AALALMNDJKO, W FHHDKECCOLA, X LEFBJAGNHCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FEA0", Offset = "0x4A2E6A0", VA = "0x184A2FEA0")]
	public static LAMJEAHCDEM<T, U, V, W, X> LGJHMHOMCNN(LAMJEAHCDEM<T, U, V, W, X> PMADIJLIHFD, Action<T, U, V, W, X> GFMBHCHPLDH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F2E0", Offset = "0x4A2DAE0", VA = "0x184A2F2E0")]
	public static LAMJEAHCDEM<T, U, V, W, X> APCOPOMHNFL(LAMJEAHCDEM<T, U, V, W, X> PMADIJLIHFD, Action<T, U, V, W, X> GFMBHCHPLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HBMBBNOPDKG<T, U, V, W, X, Y> : OMBCNGCGMEE<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x48E8AC0", Offset = "0x48E72C0", VA = "0x1848E8AC0")]
	public HBMBBNOPDKG(bool FGJHPDCNIEH = false, bool OFKIKOLOIHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F710", Offset = "0x4A2DF10", VA = "0x184A2F710")]
	public void GINPGABDCGP(T NACLDKPPPKG, U EOBFBGBIGDL, V AALALMNDJKO, W FHHDKECCOLA, X LEFBJAGNHCD, Y LLGPJHIECFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A2FEA0", Offset = "0x4A2E6A0", VA = "0x184A2FEA0")]
	public static HBMBBNOPDKG<T, U, V, W, X, Y> LGJHMHOMCNN(HBMBBNOPDKG<T, U, V, W, X, Y> PMADIJLIHFD, Action<T, U, V, W, X, Y> GFMBHCHPLDH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4A2F2E0", Offset = "0x4A2DAE0", VA = "0x184A2F2E0")]
	public static HBMBBNOPDKG<T, U, V, W, X, Y> APCOPOMHNFL(HBMBBNOPDKG<T, U, V, W, X, Y> PMADIJLIHFD, Action<T, U, V, W, X, Y> GFMBHCHPLDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DDMAONKJIKO<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KIIGOKDGLEA<TKey, TVal> BDKEGBBMJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> HDCGOHDKKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KIIGOKDGLEA<TKey, TVal>.BLNMJLEOOAE? OLBNJHJLCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int HCPECEMPKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KIIGOKDGLEA<TKey, TVal>.IDGCGHHIGKN? LENLEJHMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int LCLCGHJAMKF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int IJAJMJGPBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68C1E30", Offset = "0x68C0630", VA = "0x1868C1E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EHFFNOLNOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68C2BF0", Offset = "0x68C13F0", VA = "0x1868C2BF0")]
	public DDMAONKJIKO(int HCPECEMPKCD, [Optional] KIIGOKDGLEA<TKey, TVal>.IDGCGHHIGKN? LENLEJHMMNA, [Optional] IEqualityComparer<TKey>? DHJHOJMAKMF, [Optional] KIIGOKDGLEA<TKey, TVal>.BLNMJLEOOAE? OLBNJHJLCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68C2510", Offset = "0x68C0D10", VA = "0x1868C2510")]
	public void KIANKCOMLDH(TKey BELIEAFHDAH, TVal OPMIAMEJKDH, bool MOHCPHGMKAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68C1900", Offset = "0x68C0100", VA = "0x1868C1900")]
	public bool ADGCNHGHGNM(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68C1A60", Offset = "0x68C0260", VA = "0x1868C1A60")]
	public bool AEJGKIILIJC(TKey IEALGDFHJLA, [Out] TVal OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68C2930", Offset = "0x68C1130", VA = "0x1868C2930")]
	private void NOLJCCGEFIC(TKey BELIEAFHDAH, TVal OPMIAMEJKDH, int LBLAFDELPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68C1B60", Offset = "0x68C0360", VA = "0x1868C1B60")]
	public bool AMOODLAMCIB(TKey BELIEAFHDAH, TVal OPMIAMEJKDH, bool MOHCPHGMKAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68C2880", Offset = "0x68C1080", VA = "0x1868C2880")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68C1FB0", Offset = "0x68C07B0", VA = "0x1868C1FB0")]
	private void KGPJMAKAKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68C2740", Offset = "0x68C0F40", VA = "0x1868C2740")]
	private bool NEOCCOOEEPI(TKey BELIEAFHDAH, ECBGJCMPNFD NLGEMFKLFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68C1D10", Offset = "0x68C0510", VA = "0x1868C1D10")]
	private void CBENIOAEGNG(TKey BELIEAFHDAH, TVal OPMIAMEJKDH, ECBGJCMPNFD NLGEMFKLFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68C1E80", Offset = "0x68C0680", VA = "0x1868C1E80")]
	private void IPLFGBLFEMJ(TKey BELIEAFHDAH, TVal DDLBJHGGANE, ECBGJCMPNFD NLGEMFKLFCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DHEGPLMAJJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action PLAKEBFPHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EFEJMKDGODB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public DHEGPLMAJJJ(Action HPFEMIAMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BD60", Offset = "0x7C4A560", VA = "0x187C4BD60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3530660", Offset = "0x352EE60", VA = "0x183530660")]
	public static JMLHEDJNIFJ<T> NKIHIDGHACP<T>(T OPMIAMEJKDH, Action HPFEMIAMAPI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JMLHEDJNIFJ<T> : DHEGPLMAJJJ where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4E2AFB0", Offset = "0x4E297B0", VA = "0x184E2AFB0")]
	public JMLHEDJNIFJ(T OPMIAMEJKDH, Action HPFEMIAMAPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class MCCAFFIGBEL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly LPLCBFIPPGD<T>? AHNBKAECFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> ICBAKBLJNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool EFEJMKDGODB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly MCCAFFIGBEL<T> HMAILHHHNAA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> OKKBJPBHFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x51EB490", Offset = "0x51E9C90", VA = "0x1851EB490")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x51EB010", Offset = "0x51E9810", VA = "0x1851EB010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KBDBMNHHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x51EB510", Offset = "0x51E9D10", VA = "0x1851EB510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x51EBB80", Offset = "0x51EA380", VA = "0x1851EBB80")]
	public MCCAFFIGBEL(LPLCBFIPPGD<T> ABJELFIOOCJ, LPLCBFIPPGD<T> IIBDKOCBHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x51EB7D0", Offset = "0x51E9FD0", VA = "0x1851EB7D0")]
	public MCCAFFIGBEL(LPLCBFIPPGD<T> ABJELFIOOCJ, int IFOFOJHAFEG, LPLCBFIPPGD<T> IIBDKOCBHEO, int JKKKFFDIIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51EBC70", Offset = "0x51EA470", VA = "0x1851EBC70")]
	private MCCAFFIGBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x51EAF80", Offset = "0x51E9780", VA = "0x1851EAF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x51EB2B0", Offset = "0x51E9AB0", VA = "0x1851EB2B0")]
	public T[] FINOOPDOPBB()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x51EB190", Offset = "0x51E9990", VA = "0x1851EB190")]
	public static ReadOnlySequence<T> FGIKKMMHFBO(MCCAFFIGBEL<T>? DOGMACCPFAG)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MHEGBFEBENG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable JADDCPCKJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T GDCDOMLHCOE;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x52080E0", Offset = "0x52068E0", VA = "0x1852080E0")]
	public MHEGBFEBENG(IDisposable PIDPEOCOGMC, [In] T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4410", Offset = "0x3AF2C10", VA = "0x183AF4410")]
	public static MHEGBFEBENG<U> KIDIEHHJGNK<U>([In] MHEGBFEBENG<T> PIDPEOCOGMC, [In] U OPMIAMEJKDH) where U : notnull
	{
		return default(MHEGBFEBENG<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5208040", Offset = "0x5206840", VA = "0x185208040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EFGAFBKIBGG
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x35FD260", Offset = "0x35FBA60", VA = "0x1835FD260")]
	public static MHEGBFEBENG<T> CJOJELENPLJ<T>(IDisposable PIDPEOCOGMC, [In] T OPMIAMEJKDH) where T : notnull
	{
		return default(MHEGBFEBENG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x35FD2C0", Offset = "0x35FBAC0", VA = "0x1835FD2C0")]
	public static MHEGBFEBENG<T> MNLCDAAMIGK<T>([In] this MHEGBFEBENG<T> NFOGFJOGLPE, [Out] T OPMIAMEJKDH) where T : notnull
	{
		return default(MHEGBFEBENG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x358D370", Offset = "0x358BB70", VA = "0x18358D370")]
	public static MHEGBFEBENG<U?> KIDIEHHJGNK<U, T>([In] MHEGBFEBENG<T> GIHOCKCELAJ, [In] U OPMIAMEJKDH)
	{
		return default(MHEGBFEBENG<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct MBIIGEKJFNE : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct HKDKBBNMCKI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
		public static HKDKBBNMCKI CJOJELENPLJ()
		{
			return default(HKDKBBNMCKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CA90", Offset = "0x7C4B290", VA = "0x187C4CA90")]
	public static string OODDENNADDB(Type PIJHKCJDAHO, [Optional] string? IKLKCDOLMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x38B2A50", Offset = "0x38B1250", VA = "0x1838B2A50")]
	public static string? OODDENNADDB<T>([Optional] string? IKLKCDOLMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x38B29D0", Offset = "0x38B11D0", VA = "0x1838B29D0")]
	public static string? IPNPBKBAKGF<T>([Optional] string? AFNJFAEPPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	public static MBIIGEKJFNE FJFLDAKDOLM(string IKLKCDOLMCM, string? AFNJFAEPPGC)
	{
		return default(MBIIGEKJFNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BJCOKIAGPOC
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool CNFKCNBDIFK(string HNFNLJMHLIB, BJCOKIAGPOC JLIOBOFLAFH);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class LEMCEBCHFJP<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LEMCEBCHFJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4FDBF90", Offset = "0x4FDA790", VA = "0x184FDBF90")]
		internal void IHHINAFGKKF(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int IPCBOKHNPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string NCHBNCOKHCB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B0A0", Offset = "0x7C498A0", VA = "0x187C4B0A0")]
	public static Dictionary<string, BJCOKIAGPOC> LIPPPJNIFKP(Type IAKHMPNNHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x352B7A0", Offset = "0x3529FA0", VA = "0x18352B7A0")]
	public static Dictionary<string, BJCOKIAGPOC> LIPPPJNIFKP<T>(Type IAKHMPNNHBN, IReadOnlyDictionary<T, string> HIBPHOBJNAO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x352BFC0", Offset = "0x352A7C0", VA = "0x18352BFC0")]
	public static Dictionary<string, BJCOKIAGPOC> NMPJGEBPPKF<T>(List<T> KHKLGECKDJO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AB30", Offset = "0x7C49330", VA = "0x187C4AB30")]
	public static Dictionary<string, BJCOKIAGPOC> DEJBDEPCPOA(Type IAKHMPNNHBN, CNFKCNBDIFK FIEHCOBLEFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AEE0", Offset = "0x7C496E0", VA = "0x187C4AEE0")]
	public static Dictionary<int, string> KPMOHMNNFKD(Dictionary<string, BJCOKIAGPOC> MDFGJCKGNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class PLLAIPNOLPG : IGEMMGEDLOA
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool KBINEEJHMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? BHBKHJHFHGD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual IGEMMGEDLOA? CNCNHEBHEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D370", Offset = "0x7C4BB70", VA = "0x187C4D370")]
	protected PLLAIPNOLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KCDPOCMBOHI();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CF50", Offset = "0x7C4B750", VA = "0x187C4CF50", Slot = "8")]
	public virtual string IEABGLCGJIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D070", Offset = "0x7C4B870", VA = "0x187C4D070", Slot = "9")]
	public void MKOMDNIKKLP(StringBuilder LJPELIDDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C4D310", Offset = "0x7C4BB10", VA = "0x187C4D310", Slot = "10")]
	public void OCHNPCECOMO(StringBuilder LJPELIDDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CE30", Offset = "0x7C4B630", VA = "0x187C4CE30", Slot = "11")]
	public void CCAKMOABLBD(StringBuilder LJPELIDDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CCD0", Offset = "0x7C4B4D0", VA = "0x187C4CCD0", Slot = "12")]
	public void BHADNIPALNC(StringBuilder LJPELIDDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CFD0", Offset = "0x7C4B7D0", VA = "0x187C4CFD0")]
	public static void KIBLJLLDJMC(StringBuilder LJPELIDDJEO, string OJJDJJMGEHH, string MGAPIODBPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C22230", Offset = "0x6C20A30", VA = "0x186C22230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BMPECIGKJMN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B3D0", Offset = "0x7C49BD0", VA = "0x187C4B3D0")]
	public BMPECIGKJMN(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GPHMPLPBOCO<TErr> : BMPECIGKJMN where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr EGOOIFKEANJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x49DC7E0", Offset = "0x49DAFE0", VA = "0x1849DC7E0")]
	private GPHMPLPBOCO([In] TErr BOKGBNFEFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49DC710", Offset = "0x49DAF10", VA = "0x1849DC710")]
	public static GPHMPLPBOCO<TErr> CJOJELENPLJ([In] TErr BOKGBNFEFMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ADFBMHBOAHB : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm FAPIEBBKCAE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool FCKNAMPFKME
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool KMLJBBLKDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool NEMNPOEFJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C49D90", Offset = "0x7C48590", VA = "0x187C49D90", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long COFBFGOOFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C49E00", Offset = "0x7C48600", VA = "0x187C49E00", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C49E70", Offset = "0x7C48670", VA = "0x187C49E70", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C49D20", Offset = "0x7C48520", VA = "0x187C49D20")]
	public ADFBMHBOAHB(HashAlgorithm FAPIEBBKCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C49B50", Offset = "0x7C48350", VA = "0x187C49B50", Slot = "35")]
	public override int Read(byte[] HOAEKOMMHIH, int BFKGIFAKMAP, int PCFOAHIEPDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C49CF0", Offset = "0x7C484F0", VA = "0x187C49CF0", Slot = "38")]
	public override void Write(byte[] HOAEKOMMHIH, int BFKGIFAKMAP, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C49BF0", Offset = "0x7C483F0", VA = "0x187C49BF0", Slot = "33")]
	public override long Seek(long BFKGIFAKMAP, SeekOrigin HBMCBDFIIOP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C49C80", Offset = "0x7C48480", VA = "0x187C49C80", Slot = "34")]
	public override void SetLength(long OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C49A80", Offset = "0x7C48280", VA = "0x187C49A80")]
	public byte[] AAPOGCKAEOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IGEMMGEDLOA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IEABGLCGJIF();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KCDPOCMBOHI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface AHPGDOMHCDN<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface LFFCOBCLALN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string JCKAMCLALHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LPLCBFIPPGD<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static LPLCBFIPPGD<T>? NIGJFANDKMN;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object NLBPMLPBBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? CGKCFFBMHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool EFEJMKDGODB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool AFPBFKGMNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xD58CC0", Offset = "0xD574C0", VA = "0x180D58CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x501D2D0", Offset = "0x501BAD0", VA = "0x18501D2D0")]
	private static LPLCBFIPPGD<T> MNIIIOMDOOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x501DE80", Offset = "0x501C680", VA = "0x18501DE80")]
	private static void OKAJMJEKOJH(LPLCBFIPPGD<T> IPHKFFAEKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B97B30", Offset = "0x4B96330", VA = "0x184B97B30")]
	private LPLCBFIPPGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x501D8D0", Offset = "0x501C0D0", VA = "0x18501D8D0")]
	public static LPLCBFIPPGD<T> NKIHIDGHACP(ReadOnlyMemory<T> LLKGFCLBHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x501DC70", Offset = "0x501C470", VA = "0x18501DC70")]
	public static LPLCBFIPPGD<T> NKIHIDGHACP(IMemoryOwner<T> DMJKEOLKEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x501D190", Offset = "0x501B990", VA = "0x18501D190")]
	public static void EACBLACGNAA(LPLCBFIPPGD<T> ABJELFIOOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x501CC90", Offset = "0x501B490", VA = "0x18501CC90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x501C980", Offset = "0x501B180", VA = "0x18501C980")]
	public LPLCBFIPPGD<T> BJOHCNAKMFD(IMemoryOwner<T> DMJKEOLKEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x501CB90", Offset = "0x501B390", VA = "0x18501CB90")]
	private void CGHHPMPIKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x501D780", Offset = "0x501BF80", VA = "0x18501D780")]
	private LPLCBFIPPGD<T> MPMPGNFNJFK(LPLCBFIPPGD<T> IPHKFFAEKEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BDMEJJFKHLL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AAD0", Offset = "0x7C492D0", VA = "0x187C4AAD0")]
	public BDMEJJFKHLL(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MDEGNFMIFJO<TOk> : BDMEJJFKHLL where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk MIFIOPOFFBK;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x51F1730", Offset = "0x51EFF30", VA = "0x1851F1730")]
	private MDEGNFMIFJO([In] TOk JMLBENPHHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4D526C0", Offset = "0x4D50EC0", VA = "0x184D526C0")]
	public static MDEGNFMIFJO<TOk> CJOJELENPLJ([In] TOk JMLBENPHHGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct HCGBMJDNFKJ<TOk, TErr> : IEquatable<HCGBMJDNFKJ<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> FKJNGIDDNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr EGOOIFKEANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk MIFIOPOFFBK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool IDDBLCHFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4A35CC0", Offset = "0x4A344C0", VA = "0x184A35CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool OCJGCMJKKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4A37AA0", Offset = "0x4A362A0", VA = "0x184A37AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B650", Offset = "0x4A39E50", VA = "0x184A3B650")]
	internal HCGBMJDNFKJ([In] TErr BOKGBNFEFMG, [In] TOk JMLBENPHHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4A35670", Offset = "0x4A33E70", VA = "0x184A35670")]
	public static HCGBMJDNFKJ<TOk, TErr> KOJNOPKHAJA([In] TErr BOKGBNFEFMG)
	{
		return default(HCGBMJDNFKJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4A34B50", Offset = "0x4A33350", VA = "0x184A34B50")]
	public static HCGBMJDNFKJ<TOk, TErr> IBIMNGHDNOE([In] TOk JMLBENPHHGF)
	{
		return default(HCGBMJDNFKJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x398C010", Offset = "0x398A810", VA = "0x18398C010")]
	public HCGBMJDNFKJ<TOk?, UErr?> FLNKFNKGELP<UErr>()
	{
		return default(HCGBMJDNFKJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x398D3F0", Offset = "0x398BBF0", VA = "0x18398D3F0")]
	public HCGBMJDNFKJ<UOk?, TErr?> OBMPIGNIJOA<UOk>()
	{
		return default(HCGBMJDNFKJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x398E4C0", Offset = "0x398CCC0", VA = "0x18398E4C0")]
	public HCGBMJDNFKJ<UOk?, TErr?> ONNHBAIFOCG<UOk>()
	{
		return default(HCGBMJDNFKJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x398C8B0", Offset = "0x398B0B0", VA = "0x18398C8B0")]
	public HCGBMJDNFKJ<TOk?, UErr?> HMFAPENCFGP<UErr>()
	{
		return default(HCGBMJDNFKJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4A31CB0", Offset = "0x4A304B0", VA = "0x184A31CB0")]
	public HCGBMJDNFKJ<OLONILFLODF, TErr> BIFBGENAPBK()
	{
		return default(HCGBMJDNFKJ<OLONILFLODF, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4A36620", Offset = "0x4A34E20", VA = "0x184A36620")]
	public static bool NIDGPKKMDPO([In] HCGBMJDNFKJ<TOk, TErr> HKAFAMHBCLL, [In] HCGBMJDNFKJ<TOk, TErr> JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4A321C0", Offset = "0x4A309C0", VA = "0x184A321C0", Slot = "4")]
	public bool Equals(HCGBMJDNFKJ<TOk, TErr> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4A32290", Offset = "0x4A30A90", VA = "0x184A32290", Slot = "0")]
	public override bool Equals(object PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4A33A50", Offset = "0x4A32250", VA = "0x184A33A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4A3B150", Offset = "0x4A39950", VA = "0x184A3B150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DDFEHLGDMKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct AIPGJDECNKE<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<HCGBMJDNFKJ<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<HCGBMJDNFKJ<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x49EBA80", Offset = "0x49EA280", VA = "0x1849EBA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x49EC700", Offset = "0x49EAF00", VA = "0x1849EC700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x35D2760", Offset = "0x35D0F60", VA = "0x1835D2760")]
	public static HCGBMJDNFKJ<TOk?, TErr?> MIFIOPOFFBK<TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [In] TOk JMLBENPHHGF)
	{
		return default(HCGBMJDNFKJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x35D3B20", Offset = "0x35D2320", VA = "0x1835D3B20")]
	public static HCGBMJDNFKJ<OLONILFLODF, TErr?> MIFIOPOFFBK<TErr>([In] this HCGBMJDNFKJ<OLONILFLODF, TErr> NFOGFJOGLPE)
	{
		return default(HCGBMJDNFKJ<OLONILFLODF, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35D2760", Offset = "0x35D0F60", VA = "0x1835D2760")]
	public static HCGBMJDNFKJ<TOk?, TErr?> EGOOIFKEANJ<TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [In] TErr BOKGBNFEFMG)
	{
		return default(HCGBMJDNFKJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35D3C70", Offset = "0x35D2470", VA = "0x1835D3C70")]
	public static TOk? PKHEANEHAEL<TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x35D2000", Offset = "0x35D0800", VA = "0x1835D2000")]
	[AsyncStateMachine(typeof(AIPGJDECNKE<, >))]
	public static Task<TOk?>? DAJNDLKJHPB<TOk, TErr>(this Task<HCGBMJDNFKJ<TOk, TErr>> NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x35D2ED0", Offset = "0x35D16D0", VA = "0x1835D2ED0")]
	public static TErr? HMEFPBLECBK<TErr, TOk>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x35D0660", Offset = "0x35CEE60", VA = "0x1835D0660")]
	public static bool BMDGMAMBBKB<TOk, TErr, UErr, UOk>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [Out] HCGBMJDNFKJ<UOk, UErr> NFIKHPFJCPH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x35D15D0", Offset = "0x35CFDD0", VA = "0x1835D15D0")]
	public static bool BMEFCBCBHBE<TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [Out] TOk JMLBENPHHGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x35D3150", Offset = "0x35D1950", VA = "0x1835D3150")]
	public static bool JJJFNNHFHNL<TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [Out][NotNullWhen(true)] TErr BOKGBNFEFMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x35D2A30", Offset = "0x35D1230", VA = "0x1835D2A30")]
	public static bool HFLILOBDKEI<TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [Out][NotNullWhen(true)] TOk JMLBENPHHGF, [Out][NotNullWhen(false)] TErr BOKGBNFEFMG) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35D2930", Offset = "0x35D1130", VA = "0x1835D2930")]
	public static bool FBBILGMKIIA<TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [Out][NotNullWhen(true)] TOk JMLBENPHHGF, [Out] HCGBMJDNFKJ<TOk, TErr> NFIKHPFJCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x35D03F0", Offset = "0x35CEBF0", VA = "0x1835D03F0")]
	public static bool BMDGMAMBBKB<TOk, TErr, UErr, UOk>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [Out][NotNullWhen(true)] TOk JMLBENPHHGF, [Out] HCGBMJDNFKJ<UOk, UErr> NFIKHPFJCPH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x35D23B0", Offset = "0x35D0BB0", VA = "0x1835D23B0")]
	public static bool ECIHKMJCMLP<TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [Out][NotNullWhen(true)] TOk JMLBENPHHGF, [Out] HCGBMJDNFKJ<OLONILFLODF, TErr> NFIKHPFJCPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x35D3340", Offset = "0x35D1B40", VA = "0x1835D3340")]
	public static HCGBMJDNFKJ<UOk, UErr> JPAPKMIEDME<UOk, UErr, TOk, TErr>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, [In] HCGBMJDNFKJ<UOk, UErr> LDIOMGMJIGF) where TOk : UOk where TErr : UErr
	{
		return default(HCGBMJDNFKJ<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x35D1AB0", Offset = "0x35D02B0", VA = "0x1835D1AB0")]
	public static HCGBMJDNFKJ<TOk?[]?, TErr?> DABAPOHDLDE<TOk, TErr>(this IEnumerable<HCGBMJDNFKJ<TOk, TErr>> NFOGFJOGLPE)
	{
		return default(HCGBMJDNFKJ<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x35D1800", Offset = "0x35D0000", VA = "0x1835D1800")]
	public static HCGBMJDNFKJ<UOk?, TErr?> CAINCJAHEMF<UOk, TErr, TOk>([In] this HCGBMJDNFKJ<TOk, TErr> NFOGFJOGLPE, Func<TOk, UOk> FDBOJPCMJHJ)
	{
		return default(HCGBMJDNFKJ<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class PJDPGOHFLBG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1F50", Offset = "0x3EA0750", VA = "0x183EA1F50")]
	public static HCGBMJDNFKJ<TOk, T> MIFIOPOFFBK<TOk>([In] TOk JMLBENPHHGF) where TOk : notnull
	{
		return default(HCGBMJDNFKJ<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5562BF0", Offset = "0x55613F0", VA = "0x185562BF0")]
	public static HCGBMJDNFKJ<OLONILFLODF, T> MIFIOPOFFBK()
	{
		return default(HCGBMJDNFKJ<OLONILFLODF, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1F50", Offset = "0x3EA0750", VA = "0x183EA1F50")]
	public static HCGBMJDNFKJ<T, TErr> EGOOIFKEANJ<TErr>([In] TErr BOKGBNFEFMG) where TErr : notnull
	{
		return default(HCGBMJDNFKJ<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct GLPNBMFDBBK<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly CNFGGJCGFDN JBMCIDOFPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> JJOGNLCLDEJ;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4861EC0", Offset = "0x48606C0", VA = "0x184861EC0")]
	public static GLPNBMFDBBK<TKey, TValue> CJOJELENPLJ(string KLNHOILIBHH)
	{
		return default(GLPNBMFDBBK<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4862080", Offset = "0x4860880", VA = "0x184862080")]
	internal GLPNBMFDBBK(Dictionary<TKey, TValue> OPMIAMEJKDH, CNFGGJCGFDN KAOHOCHDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4861FE0", Offset = "0x48607E0", VA = "0x184861FE0")]
	public GDHHKFHLLNO<TKey, TValue> IIBJGEFPODA([Out] Dictionary<TKey, TValue> OPMIAMEJKDH)
	{
		return default(GDHHKFHLLNO<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct GDHHKFHLLNO<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> JJOGNLCLDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CLDJABACFED JCCOPHADIEM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x296EA30", Offset = "0x296D230", VA = "0x18296EA30")]
	internal GDHHKFHLLNO(Dictionary<TKey, TValue> OPMIAMEJKDH, CLDJABACFED CDLENIGNMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x43D8A80", Offset = "0x43D7280", VA = "0x1843D8A80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct JBKEIMKJACC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly CNFGGJCGFDN JBMCIDOFPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> JJOGNLCLDEJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4861EC0", Offset = "0x48606C0", VA = "0x184861EC0")]
	public static JBKEIMKJACC<T> CJOJELENPLJ(string KLNHOILIBHH)
	{
		return default(JBKEIMKJACC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4862080", Offset = "0x4860880", VA = "0x184862080")]
	internal JBKEIMKJACC(HashSet<T> OPMIAMEJKDH, CNFGGJCGFDN KAOHOCHDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4861FE0", Offset = "0x48607E0", VA = "0x184861FE0")]
	public EBBCOPIFMJI<T> IIBJGEFPODA([Out] HashSet<T> OPMIAMEJKDH)
	{
		return default(EBBCOPIFMJI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct EBBCOPIFMJI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> JJOGNLCLDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CLDJABACFED JCCOPHADIEM;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x296EA30", Offset = "0x296D230", VA = "0x18296EA30")]
	internal EBBCOPIFMJI(HashSet<T> OPMIAMEJKDH, CLDJABACFED CDLENIGNMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x43D8A80", Offset = "0x43D7280", VA = "0x1843D8A80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct FCILIEBIDEC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CNFGGJCGFDN JBMCIDOFPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> JJOGNLCLDEJ;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4861EC0", Offset = "0x48606C0", VA = "0x184861EC0")]
	public static FCILIEBIDEC<T> CJOJELENPLJ(string KLNHOILIBHH)
	{
		return default(FCILIEBIDEC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4862080", Offset = "0x4860880", VA = "0x184862080")]
	internal FCILIEBIDEC(Stack<T> OPMIAMEJKDH, CNFGGJCGFDN KAOHOCHDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4861FE0", Offset = "0x48607E0", VA = "0x184861FE0")]
	public IDPPIBGJCBK<T> IIBJGEFPODA([Out] Stack<T> OPMIAMEJKDH)
	{
		return default(IDPPIBGJCBK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct IDPPIBGJCBK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> JJOGNLCLDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly CLDJABACFED JCCOPHADIEM;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x296EA30", Offset = "0x296D230", VA = "0x18296EA30")]
	internal IDPPIBGJCBK(Stack<T> OPMIAMEJKDH, CLDJABACFED CDLENIGNMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x43D8A80", Offset = "0x43D7280", VA = "0x1843D8A80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class BDPNHBHOHEJ<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct NOLFPKIFGIA : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly BDPNHBHOHEJ<T> FIFFPJBDNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int JICEBMFDOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool IPEJOBDPICL;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2628930", Offset = "0x2627130", VA = "0x182628930")]
		public NOLFPKIFGIA(BDPNHBHOHEJ<T> JLPKBNIJDEI, int MBBPKJBBFDD, bool DPMAMJOKJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5359560", Offset = "0x5357D60", VA = "0x185359560")]
		public BDPNHBHOHEJ<T>.BMHOKDOKAHI DPNIJJHCOGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5359650", Offset = "0x5357E50", VA = "0x185359650", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5359650", Offset = "0x5357E50", VA = "0x185359650", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class BMHOKDOKAHI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly BDPNHBHOHEJ<T> FIFFPJBDNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int JIAMOODJBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int AOKFNNGJEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool IPEJOBDPICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool ANNDJKBEMFJ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x60113A0", Offset = "0x600FBA0", VA = "0x1860113A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6011480", Offset = "0x600FC80", VA = "0x186011480", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6011630", Offset = "0x600FE30", VA = "0x186011630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x60119D0", Offset = "0x60101D0", VA = "0x1860119D0")]
		public BMHOKDOKAHI(BDPNHBHOHEJ<T> JLPKBNIJDEI, int MBBPKJBBFDD, bool DPMAMJOKJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x60112D0", Offset = "0x600FAD0", VA = "0x1860112D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6011460", Offset = "0x600FC60", VA = "0x186011460", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class LFEBPJGIOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LFEBPJGIOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4FDCC60", Offset = "0x4FDB460", VA = "0x184FDCC60")]
		internal T GJLCNIACNFJ(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] EKGDGKMALGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int AOKFNNGJEBD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int LBDABLINNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5DA69C0", Offset = "0x5DA51C0", VA = "0x185DA69C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4852D10", Offset = "0x4851510", VA = "0x184852D10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T BMGLGMIMDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6980", Offset = "0x5DA5180", VA = "0x185DA6980")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6B70", Offset = "0x5DA5370", VA = "0x185DA6B70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x25310C0", Offset = "0x252F8C0", VA = "0x1825310C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A385F0", Offset = "0x1A36DF0", VA = "0x181A385F0")]
	private static int OJLHPLKOFMD(int FPEOONOJHML, int IMNFCKGEMOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6D70", Offset = "0x5DA5570", VA = "0x185DA6D70")]
	public BDPNHBHOHEJ(int LBLAFDELPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6DF0", Offset = "0x5DA55F0", VA = "0x185DA6DF0")]
	public BDPNHBHOHEJ(int LBLAFDELPAC, Func<T> AEMFKOHDOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7050", Offset = "0x5DA5850", VA = "0x185DA7050")]
	public BDPNHBHOHEJ(T[] ECFHLCJLIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6D40", Offset = "0x5DA5540", VA = "0x185DA6D40")]
	public void FKMHCCJPELD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6BE0", Offset = "0x5DA53E0", VA = "0x185DA6BE0")]
	public IEnumerable<T> DKDNPEIILED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DA6CA0", Offset = "0x5DA54A0", VA = "0x185DA6CA0")]
	public BDPNHBHOHEJ<T>.BMHOKDOKAHI DPNIJJHCOGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4943940", Offset = "0x4942140", VA = "0x184943940", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4943940", Offset = "0x4942140", VA = "0x184943940", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PANIHICHCPF
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3964FD0", Offset = "0x39637D0", VA = "0x183964FD0")]
	public static BDPNHBHOHEJ<T> CJOJELENPLJ<T>(int LBLAFDELPAC, Func<T> AEMFKOHDOKH) where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7C4DD80", Offset = "0x7C4C580", VA = "0x187C4DD80")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7C4DD40", Offset = "0x7C4C540", VA = "0x187C4DD40")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7C4DD60", Offset = "0x7C4C560", VA = "0x187C4DD60")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7C4DDA0", Offset = "0x7C4C5A0", VA = "0x187C4DDA0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7C4DD20", Offset = "0x7C4C520", VA = "0x187C4DD20")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2751C80", Offset = "0x2750480", VA = "0x182751C80")]
		public RRColor(float GGILEDABHIF, float PEOGEGNGBJJ, float NOAPPAEGHOH, float BINANFFLHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B12CA0", Offset = "0x7B114A0", VA = "0x187B12CA0", Slot = "4")]
		public bool Equals(RRColor PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D970", Offset = "0x7C4C170", VA = "0x187C4D970", Slot = "0")]
		public override bool Equals(object PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DA70", Offset = "0x7C4C270", VA = "0x187C4DA70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DAF0", Offset = "0x7C4C2F0", VA = "0x187C4DAF0", Slot = "5")]
		public string ToString(string CGJBGKAIMNA, IFormatProvider AFAOOFNPIHH)
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
			[Cpp2IlInjected.Address(RVA = "0x7C4D910", Offset = "0x7C4C110", VA = "0x187C4D910")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D8B0", Offset = "0x7C4C0B0", VA = "0x187C4D8B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D8E0", Offset = "0x7C4C0E0", VA = "0x187C4D8E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D940", Offset = "0x7C4C140", VA = "0x187C4D940")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D880", Offset = "0x7C4C080", VA = "0x187C4D880")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5BBDBB0", Offset = "0x5BBC3B0", VA = "0x185BBDBB0")]
		public RRColor32(byte GGILEDABHIF, byte PEOGEGNGBJJ, byte NOAPPAEGHOH, byte BINANFFLHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x210E570", Offset = "0x210CD70", VA = "0x18210E570", Slot = "4")]
		public bool Equals(RRColor32 PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D3E0", Offset = "0x7C4BBE0", VA = "0x187C4D3E0", Slot = "0")]
		public override bool Equals(object PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1295300", Offset = "0x1293B00", VA = "0x181295300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D4D0", Offset = "0x7C4BCD0", VA = "0x187C4D4D0")]
		public static RRColor32 FGIKKMMHFBO(RRColor JDLOGJMLBHP)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D460", Offset = "0x7C4BC60", VA = "0x187C4D460")]
		public static RRColor FGIKKMMHFBO(RRColor32 JDLOGJMLBHP)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D620", Offset = "0x7C4BE20", VA = "0x187C4D620", Slot = "5")]
		public string ToString(string CGJBGKAIMNA, IFormatProvider AFAOOFNPIHH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class AMDNAHHLEKJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct OEHDHCODJFA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly AMDNAHHLEKJ<T> HNPLIPKBADD;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T GDCDOMLHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x54680B0", Offset = "0x54668B0", VA = "0x1854680B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x54680D0", Offset = "0x54668D0", VA = "0x1854680D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
		public OEHDHCODJFA(AMDNAHHLEKJ<T> HNPLIPKBADD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct EKJIAFDHOGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<OEHDHCODJFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AMDNAHHLEKJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x44070E0", Offset = "0x44058E0", VA = "0x1844070E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4407340", Offset = "0x4405B40", VA = "0x184407340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim POOCDCOOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T KAMABMPPAPM;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x49F6080", Offset = "0x49F4880", VA = "0x1849F6080")]
	public AMDNAHHLEKJ([In] T KAMABMPPAPM, int OPILNKBJAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x49F6040", Offset = "0x49F4840", VA = "0x1849F6040")]
	public AMDNAHHLEKJ([In] T KAMABMPPAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x49F5B20", Offset = "0x49F4320", VA = "0x1849F5B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x49F5B60", Offset = "0x49F4360", VA = "0x1849F5B60")]
	public OEHDHCODJFA NPADFJJDBJI()
	{
		return default(OEHDHCODJFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x49F5DE0", Offset = "0x49F45E0", VA = "0x1849F5DE0")]
	[AsyncStateMachine(typeof(AMDNAHHLEKJ<>.EKJIAFDHOGO))]
	public Task<AMDNAHHLEKJ<T>.OEHDHCODJFA> OKGJJBKOAHE(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x49F6020", Offset = "0x49F4820", VA = "0x1849F6020")]
	public void PMGOMEJAOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class AFODIIDJEGN
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C49EE0", Offset = "0x7C486E0", VA = "0x187C49EE0")]
	public static AMDNAHHLEKJ<OLONILFLODF> CJOJELENPLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x358FF90", Offset = "0x358E790", VA = "0x18358FF90")]
	public static AMDNAHHLEKJ<T> CJOJELENPLJ<T>([In] T KAMABMPPAPM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LHHMAJGLFEM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct JGAHHEPGLLK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly LHHMAJGLFEM<T> HHALCJEIJNL;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T GDCDOMLHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4D67A60", Offset = "0x4D66260", VA = "0x184D67A60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4D67BA0", Offset = "0x4D663A0", VA = "0x184D67BA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
		internal JGAHHEPGLLK(LHHMAJGLFEM<T> HNPLIPKBADD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct BIMEAJMIPCC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly LHHMAJGLFEM<T> HHALCJEIJNL;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T GDCDOMLHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4D67A60", Offset = "0x4D66260", VA = "0x184D67A60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B310", Offset = "0x5F19B10", VA = "0x185F1B310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
		internal BIMEAJMIPCC(LHHMAJGLFEM<T> HNPLIPKBADD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct DAJMJGNHKEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<BIMEAJMIPCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public LHHMAJGLFEM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private AMDNAHHLEKJ<OLONILFLODF>.OEHDHCODJFA <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<AMDNAHHLEKJ<OLONILFLODF>.OEHDHCODJFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x68A2E70", Offset = "0x68A1670", VA = "0x1868A2E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4407340", Offset = "0x4405B40", VA = "0x184407340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AMDNAHHLEKJ<int> PIJPJJIGCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AMDNAHHLEKJ<OLONILFLODF> CONJIHEHAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AMDNAHHLEKJ<OLONILFLODF> GCEGCGIALHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T HIJPEKCHALL;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE3C0", Offset = "0x4FDCBC0", VA = "0x184FDE3C0")]
	internal LHHMAJGLFEM(AMDNAHHLEKJ<int> CMKJDBGCFLC, AMDNAHHLEKJ<OLONILFLODF> HDKDDPKGOHJ, AMDNAHHLEKJ<OLONILFLODF> MKKOONHKDBM, [In] T KAMABMPPAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDA20", Offset = "0x4FDC220", VA = "0x184FDDA20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDE00", Offset = "0x4FDC600", VA = "0x184FDDE00")]
	public JGAHHEPGLLK OABFAPACBPL()
	{
		return default(JGAHHEPGLLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD830", Offset = "0x4FDC030", VA = "0x184FDD830")]
	public BIMEAJMIPCC AMAEHFOLFGF()
	{
		return default(BIMEAJMIPCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDCE0", Offset = "0x4FDC4E0", VA = "0x184FDDCE0")]
	[AsyncStateMachine(typeof(LHHMAJGLFEM<>.DAJMJGNHKEM))]
	public Task<LHHMAJGLFEM<T>.BIMEAJMIPCC> HGOLIDKDMNP(CancellationToken DNHBNMHIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class PICHKKGLGAF
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4CC00", Offset = "0x7C4B400", VA = "0x187C4CC00")]
	public static LHHMAJGLFEM<OLONILFLODF> CJOJELENPLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x396B190", Offset = "0x3969990", VA = "0x18396B190")]
	public static LHHMAJGLFEM<T> CJOJELENPLJ<T>([In] T KAMABMPPAPM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class ENHECPFIADM<TData> : PLLAIPNOLPG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string LOFKFCJKLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData BADLMALNNLF;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
	public override string KCDPOCMBOHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4437610", Offset = "0x4435E10", VA = "0x184437610")]
	internal ENHECPFIADM(string NJAAPDELBNN, [In] TData NFNBKNAJBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ACKDFNOLJKF
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7C49A00", Offset = "0x7C48200", VA = "0x187C49A00")]
	public static ENHECPFIADM<OLONILFLODF> CJOJELENPLJ(string NJAAPDELBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3530660", Offset = "0x352EE60", VA = "0x183530660")]
	public static ENHECPFIADM<TData> CJOJELENPLJ<TData>(string NJAAPDELBNN, [In] TData NFNBKNAJBPN) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class CNFGGJCGFDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool KAFKGKEEALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string GCABNBKLENF;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xDE3340", Offset = "0xDE1B40", VA = "0x180DE3340")]
	private CNFGGJCGFDN(bool JEGBMCKFOKD, string DMJEBLBCCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B680", Offset = "0x7C49E80", VA = "0x187C4B680")]
	public static CNFGGJCGFDN CJOJELENPLJ(string DMJEBLBCCPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B6F0", Offset = "0x7C49EF0", VA = "0x187C4B6F0")]
	public CLDJABACFED IIBJGEFPODA()
	{
		return default(CLDJABACFED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct CLDJABACFED : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly CNFGGJCGFDN LDHPOGHHJOI;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	internal CLDJABACFED(CNFGGJCGFDN KLNHOILIBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B430", Offset = "0x7C49C30", VA = "0x187C4B430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class JMKOJJLAFMG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class NCMOGJFCMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NCMOGJFCMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x52DEEE0", Offset = "0x52DD6E0", VA = "0x1852DEEE0")]
		internal int GGLBHGHOJBD(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? AELIFOELHOA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> CICCDKJGFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4E2AAE0", Offset = "0x4E292E0", VA = "0x184E2AAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FLNHPINNCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4E2A9B0", Offset = "0x4E291B0", VA = "0x184E2A9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4E2AB20", Offset = "0x4E29320", VA = "0x184E2AB20")]
	public bool OIHLAKEIFNH(T JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4E2A840", Offset = "0x4E29040", VA = "0x184E2A840")]
	public bool AHELLINFOCL(T JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4E2ACE0", Offset = "0x4E294E0", VA = "0x184E2ACE0")]
	public bool PHEIEKKHJKM(T JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4E2AA00", Offset = "0x4E29200", VA = "0x184E2AA00")]
	public void JGMGCNJPIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4E2AD30", Offset = "0x4E29530", VA = "0x184E2AD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JMKOJJLAFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class FLJKJAPOKJM
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NOJFHHNAEFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NOJFHHNAEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C4CAD0", Offset = "0x7C4B2D0", VA = "0x187C4CAD0")]
		internal int GGLBHGHOJBD(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? AELIFOELHOA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> CICCDKJGFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C540", Offset = "0x7C4AD40", VA = "0x187C4C540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool FLNHPINNCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C4C0", Offset = "0x7C4ACC0", VA = "0x187C4C4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C5D0", Offset = "0x7C4ADD0", VA = "0x187C4C5D0")]
	public bool OIHLAKEIFNH(object JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C420", Offset = "0x7C4AC20", VA = "0x187C4C420")]
	public bool AHELLINFOCL(object JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C6B0", Offset = "0x7C4AEB0", VA = "0x187C4C6B0")]
	public bool PHEIEKKHJKM(object JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C4D0", Offset = "0x7C4ACD0", VA = "0x187C4C4D0")]
	public void JGMGCNJPIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C710", Offset = "0x7C4AF10", VA = "0x187C4C710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FLJKJAPOKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GBGBLMPKPFA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct JNPHDGMIFMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float LAPPFJGEKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T GDCDOMLHCOE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, JNPHDGMIFMB> BFIDNFGDLKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T BCDJGFMIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1920270", Offset = "0x191EA70", VA = "0x181920270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x191F640", Offset = "0x191DE40", VA = "0x18191F640", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? DCGMGMEJMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NDKPBGECEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4980110", Offset = "0x497E910", VA = "0x184980110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x497FE20", Offset = "0x497E620", VA = "0x18497FE20")]
	public bool DDFDIJPBPID(T OPMIAMEJKDH, object JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4980070", Offset = "0x497E870", VA = "0x184980070")]
	public bool LABBPGFDNPL(object JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x48E2FE0", Offset = "0x48E17E0", VA = "0x1848E2FE0")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x497EC20", Offset = "0x497D420", VA = "0x18497EC20")]
	public bool AEJGKIILIJC(object JILOCOLKOMJ, [Out] T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x497ED50", Offset = "0x497D550", VA = "0x18497ED50")]
	[HAFDNMLPCDB("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CBKFJIKNJLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4980170", Offset = "0x497E970", VA = "0x184980170")]
	public GBGBLMPKPFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class BBLFOPIOEDD : DHHDPBNHCIP<GKLIALCKGHC>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class ELJKNLFPJMC : IEqualityComparer<GKLIALCKGHC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly ELJKNLFPJMC DJLOIKDDKCN;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C070", Offset = "0x7C4A870", VA = "0x187C4C070", Slot = "4")]
		public bool Equals(GKLIALCKGHC LEFBJAGNHCD, GKLIALCKGHC LLGPJHIECFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6E09630", Offset = "0x6E07E30", VA = "0x186E09630", Slot = "5")]
		public int GetHashCode(GKLIALCKGHC PNHCNFOFAFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ELJKNLFPJMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4AA60", Offset = "0x7C49260", VA = "0x187C4AA60")]
	public BBLFOPIOEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A9B0", Offset = "0x7C491B0", VA = "0x187C4A9B0", Slot = "4")]
	public override bool OIHLAKEIFNH(GKLIALCKGHC JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A870", Offset = "0x7C49070", VA = "0x187C4A870", Slot = "5")]
	public override bool AHELLINFOCL(GKLIALCKGHC JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A920", Offset = "0x7C49120", VA = "0x187C4A920")]
	private static void NNICEFPEHIC(GKLIALCKGHC JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x17FDEB0", Offset = "0x17FC6B0", VA = "0x1817FDEB0", Slot = "6")]
	protected override string TokenToString(GKLIALCKGHC JILOCOLKOMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class GKLIALCKGHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string HDLLCBFKPGL;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public GKLIALCKGHC(string HDLLCBFKPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7C4C8C0", Offset = "0x7C4B0C0", VA = "0x187C4C8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class DHHDPBNHCIP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> OHBECKLCOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? AELIFOELHOA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FLNHPINNCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x590F020", Offset = "0x590D820", VA = "0x18590F020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x68D4310", Offset = "0x68D2B10", VA = "0x1868D4310")]
	public DHHDPBNHCIP(IEqualityComparer<T> OHBECKLCOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x68D38E0", Offset = "0x68D20E0", VA = "0x1868D38E0", Slot = "4")]
	public virtual bool OIHLAKEIFNH(T JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x68D3520", Offset = "0x68D1D20", VA = "0x1868D3520", Slot = "5")]
	public virtual bool AHELLINFOCL(T JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x68D3800", Offset = "0x68D2000", VA = "0x1868D3800")]
	public void JGMGCNJPIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x68D3F70", Offset = "0x68D2770", VA = "0x1868D3F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class NMIOJOMFPNP<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? AELIFOELHOA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool FLNHPINNCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5356AE0", Offset = "0x53552E0", VA = "0x185356AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5356940", Offset = "0x5355140", VA = "0x185356940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5356C40", Offset = "0x5355440", VA = "0x185356C40")]
	public void OIHLAKEIFNH(T JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x53567A0", Offset = "0x5354FA0", VA = "0x1853567A0")]
	public void AHELLINFOCL(T JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5356C00", Offset = "0x5355400", VA = "0x185356C00")]
	public void JGMGCNJPIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5356EB0", Offset = "0x53556B0", VA = "0x185356EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NMIOJOMFPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class GIDKDDNHBBL
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x37998D0", Offset = "0x37980D0", VA = "0x1837998D0")]
	public static void AGPFKFDFKFP<T>(this List<T> GIPAMJGJGNH, int FPEOONOJHML) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GCDAJEIKGKO<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct ALHIKPMAHLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float LAPPFJGEKGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T GDCDOMLHCOE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<GKLIALCKGHC, ALHIKPMAHLP> BFIDNFGDLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> DAOLMDAGHDM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T BCDJGFMIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E00", Offset = "0x9DF600", VA = "0x1809E0E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9E0E10", Offset = "0x9DF610", VA = "0x1809E0E10", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private GKLIALCKGHC? DCGMGMEJMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NDKPBGECEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4980110", Offset = "0x497E910", VA = "0x184980110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4983D00", Offset = "0x4982500", VA = "0x184983D00")]
	public bool DDFDIJPBPID(T OPMIAMEJKDH, GKLIALCKGHC JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4980070", Offset = "0x497E870", VA = "0x184980070")]
	public bool LABBPGFDNPL(GKLIALCKGHC JILOCOLKOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x48E2FE0", Offset = "0x48E17E0", VA = "0x1848E2FE0")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x497EB90", Offset = "0x497D390", VA = "0x18497EB90")]
	public bool AEJGKIILIJC(GKLIALCKGHC JILOCOLKOMJ, [Out] T OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4983930", Offset = "0x4982130", VA = "0x184983930")]
	[HAFDNMLPCDB("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CBKFJIKNJLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4983F50", Offset = "0x4982750", VA = "0x184983F50")]
	public GCDAJEIKGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DCLCLDNJCOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> BFIDNFGDLKJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float ENBPOECDIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xEB6410", Offset = "0xEB4C10", VA = "0x180EB6410")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xEB6420", Offset = "0xEB4C20", VA = "0x180EB6420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B8E0", Offset = "0x7C4A0E0", VA = "0x187C4B8E0")]
	public void DDFDIJPBPID(float OPMIAMEJKDH, object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B950", Offset = "0x7C4A150", VA = "0x187C4B950")]
	public void LABBPGFDNPL(object JILOCOLKOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BAF0", Offset = "0x7C4A2F0", VA = "0x187C4BAF0")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B9C0", Offset = "0x7C4A1C0", VA = "0x187C4B9C0")]
	private void MJJJLAJPEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BB40", Offset = "0x7C4A340", VA = "0x187C4BB40")]
	public DCLCLDNJCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface HPIIBGBFMNF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OLNBDDIDIEL EHINKHJMACF;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class ANMPLDNLLMO : HPIIBGBFMNF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct DOHGJOCDGNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float GIABKOFDCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float AHCBKJCMCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool FFFKLPKJBMG;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float OABHEPHNFCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x7C4BDA0", Offset = "0x7C4A5A0", VA = "0x187C4BDA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BF10", Offset = "0x7C4A710", VA = "0x187C4BF10")]
		public DOHGJOCDGNK(float MLFBDFDDHEO, float HDGKPCMCJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BDB0", Offset = "0x7C4A5B0", VA = "0x187C4BDB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class HODEKNKJOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public ANMPLDNLLMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HODEKNKJOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C910", Offset = "0x7C4B110", VA = "0x187C4C910")]
		internal void HGAGIJHLFMK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int CFHPBCCHEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int OIPKCMBDHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly HPIIBGBFMNF[] CBHCIHOKHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly OLNBDDIDIEL[] LMJFACKNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DOHGJOCDGNK[] OBIDHENCNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private DOHGJOCDGNK HKMNEECLGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CMMOHKIHFLN CGIBBNHDHDN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OLNBDDIDIEL EHINKHJMACF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A120", Offset = "0x7C48920", VA = "0x187C4A120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A060", Offset = "0x7C48860", VA = "0x187C4A060", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A6E0", Offset = "0x7C48EE0", VA = "0x187C4A6E0")]
	public ANMPLDNLLMO(int CFHPBCCHEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A650", Offset = "0x7C48E50", VA = "0x187C4A650")]
	public CMMOHKIHFLN OOOHBHKEBCP(DOHGJOCDGNK LPANGBAAEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A1E0", Offset = "0x7C489E0", VA = "0x187C4A1E0")]
	public void MMLDFJKFOII(HPIIBGBFMNF JBKDNOLLJBO, [Optional] DOHGJOCDGNK IAGFLNLDAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7C49F50", Offset = "0x7C48750", VA = "0x187C49F50", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void OLNBDDIDIEL(float JFFBLIAEJEK);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CNLDAPPCCNM
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class JKPNKHDAPAP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly HPIIBGBFMNF JIJALFBBLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly OLNBDDIDIEL NELMOECDPJP;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4CA00", Offset = "0x7C4B200", VA = "0x187C4CA00")]
		public JKPNKHDAPAP(HPIIBGBFMNF JIJALFBBLEC, OLNBDDIDIEL NELMOECDPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C9B0", Offset = "0x7C4B1B0", VA = "0x187C4C9B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B7B0", Offset = "0x7C49FB0", VA = "0x187C4B7B0")]
	internal static bool FJOHLGNCOGA(float BINANFFLHIK, float NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C38DE0", Offset = "0x7C375E0", VA = "0x187C38DE0")]
	internal static float MIGBDNIENOK(float BINANFFLHIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4B820", Offset = "0x7C4A020", VA = "0x187C4B820")]
	public static IDisposable NKEIKMGAOHH(this HPIIBGBFMNF JIJALFBBLEC, OLNBDDIDIEL NELMOECDPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CMMOHKIHFLN : HPIIBGBFMNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float JFFBLIAEJEK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float OGBKIGOCMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B450", Offset = "0x7C49C50", VA = "0x187C4B450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OLNBDDIDIEL? EHINKHJMACF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B5E0", Offset = "0x7C49DE0", VA = "0x187C4B5E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B540", Offset = "0x7C49D40", VA = "0x187C4B540", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public CMMOHKIHFLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface LEHMBKNDCDM<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KENMKJMLHKJ<T> GDNGJAGCHOI([Out] T OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNEMBDPLFBE();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DDKHODPCHJL<T> : LEHMBKNDCDM<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> AOFCNOJJFNK;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68C1740", Offset = "0x68BFF40", VA = "0x1868C1740", Slot = "4")]
	public KENMKJMLHKJ<T> GDNGJAGCHOI([Out] T OPMIAMEJKDH)
	{
		return default(KENMKJMLHKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68C17E0", Offset = "0x68BFFE0", VA = "0x1868C17E0")]
	public void IHLFGIKCBJJ(T PKEJPOKJAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x503EDA0", Offset = "0x503D5A0", VA = "0x18503EDA0", Slot = "5")]
	public void NNEMBDPLFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
	protected virtual void EONEAKCHNEO(T EHNBCIPAAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x68C16A0", Offset = "0x68BFEA0", VA = "0x1868C16A0")]
	private T EFPADONOPCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x68C1860", Offset = "0x68C0060", VA = "0x1868C1860")]
	public DDKHODPCHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct KENMKJMLHKJ<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T PKEJPOKJAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly DDKHODPCHJL<T> BODBBJKKCJB;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
	internal KENMKJMLHKJ(T OPMIAMEJKDH, DDKHODPCHJL<T> BODBBJKKCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4EFBAD0", Offset = "0x4EFA2D0", VA = "0x184EFBAD0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DEFFEKCLLCB : DDKHODPCHJL<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly DEFFEKCLLCB DJLOIKDDKCN;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BBD0", Offset = "0x7C4A3D0", VA = "0x187C4BBD0")]
	public static KENMKJMLHKJ<StringBuilder> EFPADONOPCC([Out] StringBuilder OPMIAMEJKDH)
	{
		return default(KENMKJMLHKJ<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BC70", Offset = "0x7C4A470", VA = "0x187C4BC70", Slot = "6")]
	protected override void EONEAKCHNEO(StringBuilder EHNBCIPAAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7C4BD20", Offset = "0x7C4A520", VA = "0x187C4BD20")]
	public DEFFEKCLLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HAHLNGGJJLF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x75497C0", Offset = "0x7547FC0", VA = "0x1875497C0")]
	public HAHLNGGJJLF(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class EPONLFPCFDI<TKey, TValue> : LFNOFDOMHCE<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, ANDEMLFEBMK where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class OCNNDJNKJHM : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public EPONLFPCFDI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1920270", Offset = "0x191EA70", VA = "0x181920270", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x49168F0", Offset = "0x49150F0", VA = "0x1849168F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public OCNNDJNKJHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4882C90", Offset = "0x4881490", VA = "0x184882C90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5461C10", Offset = "0x5460410", VA = "0x185461C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5461A80", Offset = "0x5460280", VA = "0x185461A80")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5461B70", Offset = "0x5460370", VA = "0x185461B70")]
		private void LGFFOGMDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5462750", Offset = "0x5460F50", VA = "0x185462750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly LFNOFDOMHCE<TKey, TValue> CHCPAHGFEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> HCNKMOIMFEO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x44426C0", Offset = "0x4440EC0", VA = "0x1844426C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool KFFGFCMACFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4442860", Offset = "0x4441060", VA = "0x184442860", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4442B70", Offset = "0x4441370", VA = "0x184442B70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> IBFMKGDJJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x44428F0", Offset = "0x44410F0", VA = "0x1844428F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> NFABEMFBIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4442A10", Offset = "0x4441210", VA = "0x184442A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4442530", Offset = "0x4440D30", VA = "0x184442530")]
	public EPONLFPCFDI(LFNOFDOMHCE<TKey, TValue> CHCPAHGFEPF, [Optional] IDictionary<TKey, TValue>? HCNKMOIMFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4440330", Offset = "0x443EB30", VA = "0x184440330", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x44402E0", Offset = "0x443EAE0", VA = "0x1844402E0")]
	public void BIKFKJBOLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x443FAF0", Offset = "0x443E2F0", VA = "0x18443FAF0", Slot = "9")]
	public void Add(TKey BELIEAFHDAH, TValue OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4440E90", Offset = "0x443F690", VA = "0x184440E90")]
	public void EPNHOIFGAMM(TKey BELIEAFHDAH, TValue OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x44410F0", Offset = "0x443F8F0", VA = "0x1844410F0")]
	public void GENBOPDPBJA(TKey BELIEAFHDAH, TValue OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x443FE60", Offset = "0x443E660", VA = "0x18443FE60")]
	public void BEONAMEGFBN(TKey BELIEAFHDAH, TValue OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4440BF0", Offset = "0x443F3F0", VA = "0x184440BF0")]
	public void ELKHFNJNCNE(TKey BELIEAFHDAH, TValue OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4441B70", Offset = "0x4440370", VA = "0x184441B70", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4441BC0", Offset = "0x44403C0", VA = "0x184441BC0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x44420C0", Offset = "0x44408C0", VA = "0x1844420C0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x44403C0", Offset = "0x443EBC0", VA = "0x1844403C0", Slot = "8")]
	public bool ContainsKey(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4441440", Offset = "0x443FC40", VA = "0x184441440")]
	public bool JKFCMEILHLN(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4440220", Offset = "0x443EA20", VA = "0x184440220")]
	public bool BHENMEIHGMI(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4441990", Offset = "0x4440190", VA = "0x184441990", Slot = "10")]
	public bool Remove(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x44422C0", Offset = "0x4440AC0", VA = "0x1844422C0", Slot = "11")]
	public bool TryGetValue(TKey BELIEAFHDAH, [Out] TValue OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4440770", Offset = "0x443EF70", VA = "0x184440770", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CPIDEKBKOPO, int KNKIMBLHNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4442280", Offset = "0x4440A80", VA = "0x184442280", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4441280", Offset = "0x443FA80", VA = "0x184441280", Slot = "19")]
	[IteratorStateMachine(typeof(EPONLFPCFDI<, >.OCNNDJNKJHM))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4441830", Offset = "0x4440030", VA = "0x184441830", Slot = "21")]
	public bool OCCPMMNPLNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x44415D0", Offset = "0x443FDD0", VA = "0x1844415D0")]
	private TValue LHBKBBLHDLM(TKey BELIEAFHDAH)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface LPGPGMMGLGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string OLPBFPKEPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface ANDEMLFEBMK
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCCPMMNPLNA();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface LFNOFDOMHCE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, ANDEMLFEBMK
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class KIIGOKDGLEA<TKey, TVal> : LFNOFDOMHCE<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, ANDEMLFEBMK where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int IDGCGHHIGKN(TKey BELIEAFHDAH, TVal OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void BLNMJLEOOAE(TKey BELIEAFHDAH, TVal OPMIAMEJKDH, ECBGJCMPNFD NLGEMFKLFCF);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class CEAGACKLIOL
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal GDCDOMLHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xC46540", Offset = "0xC44D40", VA = "0x180C46540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int OABHEPHNFCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xCE6F70", Offset = "0xCE5770", VA = "0x180CE6F70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xEF7300", Offset = "0xEF5B00", VA = "0x180EF7300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset NLMHOLBPDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1256F40", Offset = "0x1255740", VA = "0x181256F40")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x12575D0", Offset = "0x1255DD0", VA = "0x1812575D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x630D6E0", Offset = "0x630BEE0", VA = "0x18630D6E0")]
		public CEAGACKLIOL(TKey BELIEAFHDAH, TVal DDLBJHGGANE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class LDCNFGJOKAM : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public KIIGOKDGLEA<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<CEAGACKLIOL>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1920270", Offset = "0x191EA70", VA = "0x181920270", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FDAEB0", Offset = "0x4FD96B0", VA = "0x184FDAEB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
		[DebuggerHidden]
		public LDCNFGJOKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4880B70", Offset = "0x487F370", VA = "0x184880B70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4FD97E0", Offset = "0x4FD7FE0", VA = "0x184FD97E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8280", Offset = "0x4FD6A80", VA = "0x184FD8280")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4FDAE60", Offset = "0x4FD9660", VA = "0x184FDAE60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int LECAEMPCGEO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<CEAGACKLIOL>> ENEAJAIIGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<CEAGACKLIOL> NLCDKJODNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly IDGCGHHIGKN? LENLEJHMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan OCMPICJGMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly BLNMJLEOOAE? OLBNJHJLCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly GIBKPHCLPMP DOHLFNMCPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool KOBAAJCIABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> COGJHAGOGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> NMGNKNKEIOJ;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int EHFFNOLNOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int IJAJMJGPBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xCF7390", Offset = "0xCF5B90", VA = "0x180CF7390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xE29320", Offset = "0xE27B20", VA = "0x180E29320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4F19160", Offset = "0x4F17960", VA = "0x184F19160", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int JPHHHNOPCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x48E2FE0", Offset = "0x48E17E0", VA = "0x1848E2FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> NFABEMFBIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4F192A0", Offset = "0x4F17AA0", VA = "0x184F192A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.IGPMLGJKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4F15BE0", Offset = "0x4F143E0", VA = "0x184F15BE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool KFFGFCMACFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4F191F0", Offset = "0x4F179F0", VA = "0x184F191F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4F19330", Offset = "0x4F17B30", VA = "0x184F19330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4F070B0", Offset = "0x4F058B0", VA = "0x184F070B0")]
	private bool BFPCKBFELEI(int CFHPBCCHEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4F149F0", Offset = "0x4F131F0", VA = "0x184F149F0")]
	private void OPMEACBJBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4F17720", Offset = "0x4F15F20", VA = "0x184F17720")]
	public KIIGOKDGLEA(int CFHPBCCHEDC, [Optional] IDGCGHHIGKN? LENLEJHMMNA, [Optional] IEqualityComparer<TKey>? DHJHOJMAKMF, [Optional] BLNMJLEOOAE? OLBNJHJLCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4F16C30", Offset = "0x4F15430", VA = "0x184F16C30")]
	public KIIGOKDGLEA(TimeSpan OCMPICJGMIO, [Optional] IEqualityComparer<TKey>? DHJHOJMAKMF, [Optional] BLNMJLEOOAE? OLBNJHJLCMM, [Optional] GIBKPHCLPMP? DOHLFNMCPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4F16BB0", Offset = "0x4F153B0", VA = "0x184F16BB0")]
	public KIIGOKDGLEA(int CFHPBCCHEDC, TimeSpan OCMPICJGMIO, [Optional] IEqualityComparer<TKey>? DHJHOJMAKMF, [Optional] BLNMJLEOOAE? OLBNJHJLCMM, [Optional] GIBKPHCLPMP? DOHLFNMCPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4F188A0", Offset = "0x4F170A0", VA = "0x184F188A0")]
	public KIIGOKDGLEA(int CFHPBCCHEDC, IDGCGHHIGKN? LENLEJHMMNA, TimeSpan OCMPICJGMIO, [Optional] IEqualityComparer<TKey>? DHJHOJMAKMF, [Optional] BLNMJLEOOAE? OLBNJHJLCMM, [Optional] GIBKPHCLPMP? DOHLFNMCPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4F14950", Offset = "0x4F13150", VA = "0x184F14950", Slot = "21")]
	public bool OCCPMMNPLNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4F0C7B0", Offset = "0x4F0AFB0", VA = "0x184F0C7B0", Slot = "22")]
	public bool EJANADFEMBP(int LBLAFDELPAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F12160", Offset = "0x4F10960", VA = "0x184F12160")]
	private bool IIAEMGLEKFG(int LBLAFDELPAC, ECBGJCMPNFD NLGEMFKLFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F06180", Offset = "0x4F04980", VA = "0x184F06180")]
	public void AFOHMCJECDO(TKey BELIEAFHDAH, TVal OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F065F0", Offset = "0x4F04DF0", VA = "0x184F065F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BLFLGKHLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F06680", Offset = "0x4F04E80", VA = "0x184F06680", Slot = "9")]
	public void Add(TKey BELIEAFHDAH, TVal OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4F08370", Offset = "0x4F06B70", VA = "0x184F08370", Slot = "8")]
	public bool ContainsKey(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F15580", Offset = "0x4F13D80", VA = "0x184F15580", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4F150D0", Offset = "0x4F138D0", VA = "0x184F150D0", Slot = "10")]
	public bool Remove(TKey BELIEAFHDAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F15950", Offset = "0x4F14150", VA = "0x184F15950", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> BLFLGKHLJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4F100C0", Offset = "0x4F0E8C0", VA = "0x184F100C0")]
	private bool HNFKOFCEHLG(TKey BELIEAFHDAH, [Out] TVal OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F0BEB0", Offset = "0x4F0A6B0", VA = "0x184F0BEB0")]
	private TVal EFPADONOPCC(TKey IEALGDFHJLA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F15C70", Offset = "0x4F14470", VA = "0x184F15C70", Slot = "11")]
	public bool TryGetValue(TKey IEALGDFHJLA, [Out] TVal OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F08180", Offset = "0x4F06980", VA = "0x184F08180", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4F087F0", Offset = "0x4F06FF0", VA = "0x184F087F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CPIDEKBKOPO, int KNKIMBLHNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4F13B90", Offset = "0x4F12390", VA = "0x184F13B90")]
	private void IPLFGBLFEMJ(TKey BELIEAFHDAH, TVal DDLBJHGGANE, ECBGJCMPNFD NLGEMFKLFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4F13CD0", Offset = "0x4F124D0", VA = "0x184F13CD0")]
	private bool JOCFDAFNOLM(CEAGACKLIOL MAKMOGLFEFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F0E060", Offset = "0x4F0C860", VA = "0x184F0E060")]
	private void HEOKEMKGCFB(LinkedListNode<CEAGACKLIOL> PAHKFLKHBEO, TVal BOCGDEDFMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F0B720", Offset = "0x4F09F20", VA = "0x184F0B720")]
	private void DDFDIJPBPID(TKey BELIEAFHDAH, TVal OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F07730", Offset = "0x4F05F30", VA = "0x184F07730")]
	private void BJFKCFLJNGK(CEAGACKLIOL MAKMOGLFEFG, TVal BOCGDEDFMLC, int DAMNAOHIEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F0C860", Offset = "0x4F0B060", VA = "0x184F0C860", Slot = "19")]
	[IteratorStateMachine(typeof(KIIGOKDGLEA<, >.LDCNFGJOKAM))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4F15C30", Offset = "0x4F14430", VA = "0x184F15C30", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum ECBGJCMPNFD : byte
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
public class FDJCOJNMGFC<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey GDCHAAOCLDI;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4866840", Offset = "0x4865040", VA = "0x184866840")]
	public FDJCOJNMGFC(TKey PHHOPOBOLKP, Exception CLGGKPBHAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NIAOKJCGGPE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F5F0", Offset = "0x6D9DDF0", VA = "0x186D9F5F0")]
	public NIAOKJCGGPE(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class GNDJEFKFJMI<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class KLGJLODGCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public GNDJEFKFJMI<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KLGJLODGCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4F2C330", Offset = "0x4F2AB30", VA = "0x184F2C330")]
		internal Task<TResource> GEONOLEKILI(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct PLPPMKBHGEI : IAsyncStateMachine
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
		public GNDJEFKFJMI<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x557CBD0", Offset = "0x557B3D0", VA = "0x18557CBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x557D810", Offset = "0x557C010", VA = "0x18557D810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct ENNFDPCMPNB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4438690", Offset = "0x4436E90", VA = "0x184438690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4438A70", Offset = "0x4437270", VA = "0x184438A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly IOPJHHELMEK<TId, Task<TResource>> MKHCMNLPKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> ODEIGNPDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? HLOOJNCKGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? NLCMCACKDPN;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x49D48C0", Offset = "0x49D30C0", VA = "0x1849D48C0")]
	public GNDJEFKFJMI(int GCLDKHIFCPL = 0, [Optional] IEqualityComparer<TId>? JKFMJLOPKDJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? GMEIGGEMPFG, [Optional] Action<TResource>? DNAPMNAIEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x49D4160", Offset = "0x49D2960", VA = "0x1849D4160")]
	public JMLHEDJNIFJ<Task<TResource>> OOPEOBNCHCJ(TId MLBCMOLHELH, [Optional] Func<TId, CancellationToken, Task<TResource>>? GMEIGGEMPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x49D3E60", Offset = "0x49D2660", VA = "0x1849D3E60")]
	private void NGLIAILHNGF(Task<TResource> BFOIMBMKJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x49D3270", Offset = "0x49D1A70", VA = "0x1849D3270")]
	[AsyncStateMachine(typeof(GNDJEFKFJMI<, >.PLPPMKBHGEI))]
	private Task DLECBONJDIJ(Task<TResource> BFOIMBMKJIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x49D35E0", Offset = "0x49D1DE0", VA = "0x1849D35E0")]
	public void ELFFAHMMPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x49D3470", Offset = "0x49D1C70", VA = "0x1849D3470")]
	public IOPJHHELMEK<TId, Task<TResource>>.MGBGFGDFELC DPNIJJHCOGM()
	{
		return default(IOPJHHELMEK<TId, Task<TResource>>.MGBGFGDFELC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x49D46F0", Offset = "0x49D2EF0", VA = "0x1849D46F0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x49D46F0", Offset = "0x49D2EF0", VA = "0x1849D46F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x49D38A0", Offset = "0x49D20A0", VA = "0x1849D38A0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GNDJEFKFJMI<, >.ENNFDPCMPNB))]
	internal static Task KFOKGHDCOBP(Task<TResource> BFOIMBMKJIA, CancellationTokenSource CCLIKBGHLPF, Dictionary<Task<TResource>, CancellationTokenSource> MPAKIACIPEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class IOPJHHELMEK<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class CMJMHGFPLKD : IEquatable<CMJMHGFPLKD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue GDCDOMLHCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int PFCLJIPDIGD;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1166030", Offset = "0x1164830", VA = "0x181166030")]
		public CMJMHGFPLKD(TValue OPMIAMEJKDH, int CHBIALLHLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x64D63E0", Offset = "0x64D4BE0", VA = "0x1864D63E0", Slot = "4")]
		public bool Equals(CMJMHGFPLKD? PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x64D6470", Offset = "0x64D4C70", VA = "0x1864D6470", Slot = "0")]
		public override bool Equals(object? PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x64D6630", Offset = "0x64D4E30", VA = "0x1864D6630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct MGBGFGDFELC : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, CMJMHGFPLKD>.Enumerator PKBMFKKCJJK;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x51F82C0", Offset = "0x51F6AC0", VA = "0x1851F82C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x51F87E0", Offset = "0x51F6FE0", VA = "0x1851F87E0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x51F8430", Offset = "0x51F6C30", VA = "0x1851F8430")]
		public MGBGFGDFELC(IOPJHHELMEK<TKey, TValue> BFIDNFGDLKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x51F7DD0", Offset = "0x51F65D0", VA = "0x1851F7DD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x51F7E50", Offset = "0x51F6650", VA = "0x1851F7E50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x51F7ED0", Offset = "0x51F66D0", VA = "0x1851F7ED0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class BIJGBAKNMIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public IOPJHHELMEK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CMJMHGFPLKD refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BIJGBAKNMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A440", Offset = "0x5F18C40", VA = "0x185F1A440")]
		internal void GEONOLEKILI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, CMJMHGFPLKD> BNDEKHPNLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? FDJDGOKGLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? CGBBDKMGFCP;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E2D0", Offset = "0x4B8CAD0", VA = "0x184B8E2D0")]
	public IOPJHHELMEK(int GCLDKHIFCPL = 0, [Optional] IEqualityComparer<TKey>? DHJHOJMAKMF, [Optional] Func<TKey, TValue>? LFAMMINNNEM, [Optional] Action<TValue>? GODHIOHMGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4B8D4B0", Offset = "0x4B8BCB0", VA = "0x184B8D4B0")]
	public JMLHEDJNIFJ<TValue> OOPEOBNCHCJ(TKey BELIEAFHDAH, [Optional] Func<TKey, TValue>? JJJNIBOLEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4B8D380", Offset = "0x4B8BB80", VA = "0x184B8D380")]
	private void IHLFGIKCBJJ(TKey BELIEAFHDAH, CMJMHGFPLKD CBHNBNEGLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4B8CCB0", Offset = "0x4B8B4B0", VA = "0x184B8CCB0")]
	public void ELFFAHMMPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C9D0", Offset = "0x4B8B1D0", VA = "0x184B8C9D0")]
	public MGBGFGDFELC DPNIJJHCOGM()
	{
		return default(MGBGFGDFELC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E100", Offset = "0x4B8C900", VA = "0x184B8E100", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4B8E100", Offset = "0x4B8C900", VA = "0x184B8E100", Slot = "5")]
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
