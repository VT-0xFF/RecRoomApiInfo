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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8268850", Offset = "0x8267450", VA = "0x188268850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PEDADLHCIDC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected PEDADLHCIDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GKDJHKHNMCG<T> : PEDADLHCIDC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OFJIAGOENGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JLAFMMCOIDD
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
		public JLAFMMCOIDD MDCDODCGNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T KLIEOOEGDML;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GBFFNPIIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JEDJEFFAGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool GGNFIGIFCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? HAIMGIEPNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OFJIAGOENGD>? FEJLKNCCFIC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KEDFBMMJJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA410", Offset = "0x4EA9010", VA = "0x184EAA410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4EAABC0", Offset = "0x4EA97C0", VA = "0x184EAABC0")]
	protected GKDJHKHNMCG(bool GGNFIGIFCCG, bool JEDJEFFAGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4EAA460", Offset = "0x4EA9060", VA = "0x184EAA460")]
	protected bool EJKPBOCBBHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4EAA310", Offset = "0x4EA8F10", VA = "0x184EAA310")]
	protected void AGPFDNJKFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4EAA820", Offset = "0x4EA9420", VA = "0x184EAA820")]
	protected void IOKBFCEEGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x42F0930", Offset = "0x42EF530", VA = "0x1842F0930")]
	private static void IHBHBJNLGHK<U>(List<U>? ADEANPNALNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4EAA9F0", Offset = "0x4EA95F0", VA = "0x184EAA9F0", Slot = "4")]
	public void NDGLNAHKHEG(T KLIEOOEGDML, bool APCLCGIGCGL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAA500", Offset = "0x4EA9100", VA = "0x184EAA500", Slot = "5")]
	public void ENKPLOICKCM(T KLIEOOEGDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4EAA6B0", Offset = "0x4EA92B0", VA = "0x184EAA6B0")]
	public void HAGLLFMPLGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LKKDMOCNJPN : GKDJHKHNMCG<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82682F0", Offset = "0x8266EF0", VA = "0x1882682F0")]
	public LKKDMOCNJPN(bool GGNFIGIFCCG = false, bool JEDJEFFAGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8268090", Offset = "0x8266C90", VA = "0x188268090")]
	public void JMBILAAMFIC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8268030", Offset = "0x8266C30", VA = "0x188268030")]
	public static LKKDMOCNJPN JCGCHFODFEL(LKKDMOCNJPN FAEKACIALJO, Action KLIEOOEGDML)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8268290", Offset = "0x8266E90", VA = "0x188268290")]
	public static LKKDMOCNJPN NBMDFJJGJED(LKKDMOCNJPN FAEKACIALJO, Action KLIEOOEGDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KHIPOMDHCOK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDGLNAHKHEG(Action<T> KLIEOOEGDML, bool APCLCGIGCGL = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENKPLOICKCM(Action<T> KLIEOOEGDML);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GFJLLHFJBHN<T> : GKDJHKHNMCG<Action<T>>, KHIPOMDHCOK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48DF860", Offset = "0x48DE460", VA = "0x1848DF860")]
	public GFJLLHFJBHN(bool GGNFIGIFCCG = false, bool JEDJEFFAGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E94280", Offset = "0x4E92E80", VA = "0x184E94280")]
	public void JMBILAAMFIC(T KJCIKLJPCMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E00", Offset = "0x4E90A00", VA = "0x184E91E00")]
	public static GFJLLHFJBHN<T> JCGCHFODFEL(GFJLLHFJBHN<T> FAEKACIALJO, Action<T> KLIEOOEGDML)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E94F30", Offset = "0x4E93B30", VA = "0x184E94F30")]
	public static GFJLLHFJBHN<T> NBMDFJJGJED(GFJLLHFJBHN<T> FAEKACIALJO, Action<T> KLIEOOEGDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ELHLLEHEDIM<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDGLNAHKHEG(Action<T, U> KLIEOOEGDML, bool APCLCGIGCGL = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENKPLOICKCM(Action<T, U> KLIEOOEGDML);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class KLPJLNGNINA<T, U> : GKDJHKHNMCG<Action<T, U>>, ELHLLEHEDIM<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x48DF860", Offset = "0x48DE460", VA = "0x1848DF860")]
	public KLPJLNGNINA(bool GGNFIGIFCCG = false, bool JEDJEFFAGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x53CF4E0", Offset = "0x53CE0E0", VA = "0x1853CF4E0")]
	public void JMBILAAMFIC(T KJCIKLJPCMB, U HAOEBKGOJMP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E00", Offset = "0x4E90A00", VA = "0x184E91E00")]
	public static KLPJLNGNINA<T, U> JCGCHFODFEL(KLPJLNGNINA<T, U> FAEKACIALJO, Action<T, U> KLIEOOEGDML)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E94F30", Offset = "0x4E93B30", VA = "0x184E94F30")]
	public static KLPJLNGNINA<T, U> NBMDFJJGJED(KLPJLNGNINA<T, U> FAEKACIALJO, Action<T, U> KLIEOOEGDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IKGOKGNLKCJ<T, U, V> : GKDJHKHNMCG<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x48DF860", Offset = "0x48DE460", VA = "0x1848DF860")]
	public IKGOKGNLKCJ(bool GGNFIGIFCCG = false, bool JEDJEFFAGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x50A9990", Offset = "0x50A8590", VA = "0x1850A9990")]
	public void JMBILAAMFIC(T KJCIKLJPCMB, U HAOEBKGOJMP, V DNDKHMOJDEM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E00", Offset = "0x4E90A00", VA = "0x184E91E00")]
	public static IKGOKGNLKCJ<T, U, V> JCGCHFODFEL(IKGOKGNLKCJ<T, U, V> FAEKACIALJO, Action<T, U, V> KLIEOOEGDML)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4E94F30", Offset = "0x4E93B30", VA = "0x184E94F30")]
	public static IKGOKGNLKCJ<T, U, V> NBMDFJJGJED(IKGOKGNLKCJ<T, U, V> FAEKACIALJO, Action<T, U, V> KLIEOOEGDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EEMGCALDKBD<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class LOPOBKNLINJ<T, U, V, W> : GKDJHKHNMCG<Action<T, U, V, W>>, EEMGCALDKBD<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x48DF860", Offset = "0x48DE460", VA = "0x1848DF860")]
	public LOPOBKNLINJ(bool GGNFIGIFCCG = false, bool JEDJEFFAGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5473EA0", Offset = "0x5472AA0", VA = "0x185473EA0")]
	public void JMBILAAMFIC(T KJCIKLJPCMB, U HAOEBKGOJMP, V DNDKHMOJDEM, W PBIHGFKMLJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E00", Offset = "0x4E90A00", VA = "0x184E91E00")]
	public static LOPOBKNLINJ<T, U, V, W> JCGCHFODFEL(LOPOBKNLINJ<T, U, V, W> FAEKACIALJO, Action<T, U, V, W> KLIEOOEGDML)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E94F30", Offset = "0x4E93B30", VA = "0x184E94F30")]
	public static LOPOBKNLINJ<T, U, V, W> NBMDFJJGJED(LOPOBKNLINJ<T, U, V, W> FAEKACIALJO, Action<T, U, V, W> KLIEOOEGDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class INLJMGFDKOG<T, U, V, W, X> : GKDJHKHNMCG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48DF860", Offset = "0x48DE460", VA = "0x1848DF860")]
	public INLJMGFDKOG(bool GGNFIGIFCCG = false, bool JEDJEFFAGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x50B3470", Offset = "0x50B2070", VA = "0x1850B3470")]
	public void JMBILAAMFIC(T KJCIKLJPCMB, U HAOEBKGOJMP, V DNDKHMOJDEM, W PBIHGFKMLJE, X LGCEHLADNJC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E00", Offset = "0x4E90A00", VA = "0x184E91E00")]
	public static INLJMGFDKOG<T, U, V, W, X> JCGCHFODFEL(INLJMGFDKOG<T, U, V, W, X> FAEKACIALJO, Action<T, U, V, W, X> KLIEOOEGDML)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E94F30", Offset = "0x4E93B30", VA = "0x184E94F30")]
	public static INLJMGFDKOG<T, U, V, W, X> NBMDFJJGJED(INLJMGFDKOG<T, U, V, W, X> FAEKACIALJO, Action<T, U, V, W, X> KLIEOOEGDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NGAJDPCKAEH<T, U, V, W, X, Y> : GKDJHKHNMCG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x48DF860", Offset = "0x48DE460", VA = "0x1848DF860")]
	public NGAJDPCKAEH(bool GGNFIGIFCCG = false, bool JEDJEFFAGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x570AC80", Offset = "0x5709880", VA = "0x18570AC80")]
	public void JMBILAAMFIC(T KJCIKLJPCMB, U HAOEBKGOJMP, V DNDKHMOJDEM, W PBIHGFKMLJE, X LGCEHLADNJC, Y LFHMHCKODDK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E00", Offset = "0x4E90A00", VA = "0x184E91E00")]
	public static NGAJDPCKAEH<T, U, V, W, X, Y> JCGCHFODFEL(NGAJDPCKAEH<T, U, V, W, X, Y> FAEKACIALJO, Action<T, U, V, W, X, Y> KLIEOOEGDML)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E94F30", Offset = "0x4E93B30", VA = "0x184E94F30")]
	public static NGAJDPCKAEH<T, U, V, W, X, Y> NBMDFJJGJED(NGAJDPCKAEH<T, U, V, W, X, Y> FAEKACIALJO, Action<T, U, V, W, X, Y> KLIEOOEGDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HPMCMAJBFAH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BGFCJDALAHK<TKey, TVal> FNCNKBJCFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> EJKDDHOBAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BGFCJDALAHK<TKey, TVal>.GBBMOENHCCH? HGPMKDEPAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int KJLJPJIHMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BGFCJDALAHK<TKey, TVal>.BPJKAFHNEJC? NCLGALCEKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int ENCHPHMIJNO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int PJPMEFFADNA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4FB1FE0", Offset = "0x4FB0BE0", VA = "0x184FB1FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LNNGLAPDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5C760", Offset = "0xA5B360", VA = "0x180A5C760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4FB2A40", Offset = "0x4FB1640", VA = "0x184FB2A40")]
	public HPMCMAJBFAH(int KJLJPJIHMAL, [Optional] BGFCJDALAHK<TKey, TVal>.BPJKAFHNEJC? NCLGALCEKEA, [Optional] IEqualityComparer<TKey>? LFALBIKDJJH, [Optional] BGFCJDALAHK<TKey, TVal>.GBBMOENHCCH? HGPMKDEPAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4FB1AD0", Offset = "0x4FB06D0", VA = "0x184FB1AD0")]
	public void EGLMLDMMPKH(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG, bool KHNNGJGOEJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4FB2920", Offset = "0x4FB1520", VA = "0x184FB2920")]
	public bool OPLHHBHKKLH(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4FB1F10", Offset = "0x4FB0B10", VA = "0x184FB1F10")]
	public bool GLNNPKODOFD(TKey JKIPLLMBEPO, [Out] TVal BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4FB2150", Offset = "0x4FB0D50", VA = "0x184FB2150")]
	private void LIOECGNMEMF(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG, int PFHGPMHBODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4FB1C80", Offset = "0x4FB0880", VA = "0x184FB1C80")]
	public bool GAMNLFFMCKO(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG, bool KHNNGJGOEJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4FB2020", Offset = "0x4FB0C20", VA = "0x184FB2020")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4FB2460", Offset = "0x4FB1060", VA = "0x184FB2460")]
	private void ODKKBKFOEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4FB2380", Offset = "0x4FB0F80", VA = "0x184FB2380")]
	private bool LPGPOBHJOJC(TKey DHCHBFGMFFD, BPKOGKMOCCO LENOHNAJDNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4FB2080", Offset = "0x4FB0C80", VA = "0x184FB2080")]
	private void KJIEBAILNAN(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG, BPKOGKMOCCO LENOHNAJDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4FB1DF0", Offset = "0x4FB09F0", VA = "0x184FB1DF0")]
	private void GEBNPIBJFEG(TKey DHCHBFGMFFD, TVal PINMHDANIAH, BPKOGKMOCCO LENOHNAJDNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LOAIKHILJAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action FEPFKFFLCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool GKIEPENAMNB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public LOAIKHILJAF(Action HGEHGHPLMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8268350", Offset = "0x8266F50", VA = "0x188268350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3187C80", Offset = "0x3186880", VA = "0x183187C80")]
	public static ODNHGKKANOM<T> FOGKIHKKOLG<T>(T BKMPCFIAHIG, Action HGEHGHPLMFM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class ODNHGKKANOM<T> : LOAIKHILJAF where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x584FB70", Offset = "0x584E770", VA = "0x18584FB70")]
	public ODNHGKKANOM(T BKMPCFIAHIG, Action HGEHGHPLMFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class APGNGFIHPBL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly OHGOFOFHPMJ<T>? FOIPBAHEPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> CGNPOFNILNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool GKIEPENAMNB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly APGNGFIHPBL<T> LNCBONNLALO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> FIAGIKGIBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5257DD0", Offset = "0x52569D0", VA = "0x185257DD0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5257F60", Offset = "0x5256B60", VA = "0x185257F60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NNPPJEMMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5257B50", Offset = "0x5256750", VA = "0x185257B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x52585A0", Offset = "0x52571A0", VA = "0x1852585A0")]
	public APGNGFIHPBL(OHGOFOFHPMJ<T> GCBIAMOPENJ, OHGOFOFHPMJ<T> KMINBLHHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5258210", Offset = "0x5256E10", VA = "0x185258210")]
	public APGNGFIHPBL(OHGOFOFHPMJ<T> GCBIAMOPENJ, int FAHOKHGHPIJ, OHGOFOFHPMJ<T> KMINBLHHEAP, int HALHNLODLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5258660", Offset = "0x5257260", VA = "0x185258660")]
	private APGNGFIHPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5257CD0", Offset = "0x52568D0", VA = "0x185257CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5257A10", Offset = "0x5256610", VA = "0x185257A10")]
	public T[] CLDFJMLAOLG()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5257E50", Offset = "0x5256A50", VA = "0x185257E50")]
	public static ReadOnlySequence<T> KDDDGPNBGLG(APGNGFIHPBL<T>? PLKGHIAJHKM)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CLGBOEGNOEP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable ABPDPFDBHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T AHLMJDKCEID;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C34000", Offset = "0x6C32C00", VA = "0x186C34000")]
	public CLGBOEGNOEP(IDisposable JAOGNEOIMGK, [In] T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EAB430", Offset = "0x3EAA030", VA = "0x183EAB430")]
	public static CLGBOEGNOEP<U> EICKFANJELJ<U>([In] CLGBOEGNOEP<T> JAOGNEOIMGK, [In] U BKMPCFIAHIG) where U : notnull
	{
		return default(CLGBOEGNOEP<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C33E30", Offset = "0x6C32A30", VA = "0x186C33E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FMCPFFEJDFC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C29EA0", Offset = "0x3C28AA0", VA = "0x183C29EA0")]
	public static CLGBOEGNOEP<T> MJMNOIPJNFN<T>(IDisposable JAOGNEOIMGK, [In] T BKMPCFIAHIG) where T : notnull
	{
		return default(CLGBOEGNOEP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C29E40", Offset = "0x3C28A40", VA = "0x183C29E40")]
	public static CLGBOEGNOEP<T> EMNHBCENDEH<T>([In] this CLGBOEGNOEP<T> JBDFDFABHKD, [Out] T BKMPCFIAHIG) where T : notnull
	{
		return default(CLGBOEGNOEP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x39C0F90", Offset = "0x39BFB90", VA = "0x1839C0F90")]
	public static CLGBOEGNOEP<U?> EICKFANJELJ<U, T>([In] CLGBOEGNOEP<T> HJJKAKNPPKB, [In] U BKMPCFIAHIG)
	{
		return default(CLGBOEGNOEP<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GHCDGOPJPBJ : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct PPJPLGBOCGA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0")]
		public static PPJPLGBOCGA MJMNOIPJNFN()
		{
			return default(PPJPLGBOCGA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8266120", Offset = "0x8264D20", VA = "0x188266120")]
	public static string KPJJOHCGAAA(Type MDCDODCGNEK, [Optional] string? KALKEOGFJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3C460B0", Offset = "0x3C44CB0", VA = "0x183C460B0")]
	public static string? KPJJOHCGAAA<T>([Optional] string? KALKEOGFJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C46030", Offset = "0x3C44C30", VA = "0x183C46030")]
	public static string? JPFGPNNJLCL<T>([Optional] string? EDHLEALEDDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0")]
	public static GHCDGOPJPBJ HEAKFDDJFMJ(string KALKEOGFJIH, string? EDHLEALEDDE)
	{
		return default(GHCDGOPJPBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HFCIIALCHLD
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool EDFHIANLDAL(string HOPFKHKMPNB, HFCIIALCHLD CAMMPDHDIHN);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NMCBEDBINMB<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NMCBEDBINMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5723240", Offset = "0x5721E40", VA = "0x185723240")]
		internal void KCGEMLEDKPK(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int IILFEKLIFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string HHHKBKPIMNC;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8266410", Offset = "0x8265010", VA = "0x188266410")]
	public static Dictionary<string, HFCIIALCHLD> DLFLBADPCNK(Type IPGKEGBKDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A160", Offset = "0x3C58D60", VA = "0x183C5A160")]
	public static Dictionary<string, HFCIIALCHLD> DLFLBADPCNK<T>(Type IPGKEGBKDLL, IReadOnlyDictionary<T, string> BMBMCNGEOID) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A990", Offset = "0x3C59590", VA = "0x183C5A990")]
	public static Dictionary<string, HFCIIALCHLD> KNFGPJJCHLM<T>(List<T> CMLEEKHJMGA) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8266740", Offset = "0x8265340", VA = "0x188266740")]
	public static Dictionary<string, HFCIIALCHLD> DNHHLJCCBGO(Type IPGKEGBKDLL, EDFHIANLDAL MNOOKOFHHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8266B00", Offset = "0x8265700", VA = "0x188266B00")]
	public static Dictionary<int, string> GDOIELBBIKB(Dictionary<string, HFCIIALCHLD> NDMEBHICHPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class CLKLDHBJINM : KLHHEJIOGEP
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool EGIGOGDBEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? MFICLICBOLD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual KLHHEJIOGEP? LLANCJKPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8265810", Offset = "0x8264410", VA = "0x188265810")]
	protected CLKLDHBJINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BAMDPIFKGNE();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8265790", Offset = "0x8264390", VA = "0x188265790", Slot = "8")]
	public virtual string KAHGADOJMIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8265490", Offset = "0x8264090", VA = "0x188265490", Slot = "9")]
	public void IKIOCLBPDNP(StringBuilder EAPMCFJDNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8265730", Offset = "0x8264330", VA = "0x188265730", Slot = "10")]
	public void JJKDHGDKHIK(StringBuilder EAPMCFJDNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8265210", Offset = "0x8263E10", VA = "0x188265210", Slot = "11")]
	public void BLGHEOFEKDB(StringBuilder EAPMCFJDNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8265330", Offset = "0x8263F30", VA = "0x188265330", Slot = "12")]
	public void FIELFNFKGCI(StringBuilder EAPMCFJDNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8265170", Offset = "0x8263D70", VA = "0x188265170")]
	public static void AIMHFLEIILK(StringBuilder EAPMCFJDNJO, string JNKLGPOIBON, string DFHOHALNNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71627B0", Offset = "0x71613B0", VA = "0x1871627B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AKHPBBNOBLM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8264F90", Offset = "0x8263B90", VA = "0x188264F90")]
	public AKHPBBNOBLM(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OFIJLLIMAAI<TErr> : AKHPBBNOBLM where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr DMGLFPMGPME;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x585CCF0", Offset = "0x585B8F0", VA = "0x18585CCF0")]
	private OFIJLLIMAAI([In] TErr HGHFBMAKHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x585CC30", Offset = "0x585B830", VA = "0x18585CC30")]
	public static OFIJLLIMAAI<TErr> MJMNOIPJNFN([In] TErr HGHFBMAKHEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FHMOBMOMIJA : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm GACILMCANMK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool NPOADHODIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool BDCKLGFIKAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool OFEFOAGLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8265FC0", Offset = "0x8264BC0", VA = "0x188265FC0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long BCBKGNPANPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8266030", Offset = "0x8264C30", VA = "0x188266030", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82660A0", Offset = "0x8264CA0", VA = "0x1882660A0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8265F50", Offset = "0x8264B50", VA = "0x188265F50")]
	public FHMOBMOMIJA(HashAlgorithm GACILMCANMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8265D70", Offset = "0x8264970", VA = "0x188265D70", Slot = "35")]
	public override int Read(byte[] HAPOFGGDNGL, int HDEKJKJDEIC, int NKGPOLKDIPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8265F20", Offset = "0x8264B20", VA = "0x188265F20", Slot = "38")]
	public override void Write(byte[] HAPOFGGDNGL, int HDEKJKJDEIC, int NKGPOLKDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8265E10", Offset = "0x8264A10", VA = "0x188265E10", Slot = "33")]
	public override long Seek(long HDEKJKJDEIC, SeekOrigin PFKAKKFNLEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8265EA0", Offset = "0x8264AA0", VA = "0x188265EA0", Slot = "34")]
	public override void SetLength(long BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8265C90", Offset = "0x8264890", VA = "0x188265C90")]
	public byte[] IKOOFLBAMID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KLHHEJIOGEP
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KAHGADOJMIE();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BAMDPIFKGNE();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DEMOIOHLLCD<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface EMPDFHKKPAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string JNOPPOLMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OHGOFOFHPMJ<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static OHGOFOFHPMJ<T>? DEPCENOPDNI;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object IJAPGLGOJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? MBFOJAKFFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool GKIEPENAMNB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LBGGGNEDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAAA770", Offset = "0xAA9370", VA = "0x180AAA770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x586ACF0", Offset = "0x58698F0", VA = "0x18586ACF0")]
	private static OHGOFOFHPMJ<T> JPJBNFAJDMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x586B270", Offset = "0x5869E70", VA = "0x18586B270")]
	private static void NOFENDKDGOA(OHGOFOFHPMJ<T> BCGOLBEALCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF0A0", Offset = "0x4EADCA0", VA = "0x184EAF0A0")]
	private OHGOFOFHPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x586A850", Offset = "0x5869450", VA = "0x18586A850")]
	public static OHGOFOFHPMJ<T> FOGKIHKKOLG(ReadOnlyMemory<T> NFGNMIBGLMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x586AA00", Offset = "0x5869600", VA = "0x18586AA00")]
	public static OHGOFOFHPMJ<T> FOGKIHKKOLG(IMemoryOwner<T> DAMCGAELNDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x586B160", Offset = "0x5869D60", VA = "0x18586B160")]
	public static void MDHCMHFDCGP(OHGOFOFHPMJ<T> GCBIAMOPENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x586A280", Offset = "0x5868E80", VA = "0x18586A280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x586B7C0", Offset = "0x586A3C0", VA = "0x18586B7C0")]
	public OHGOFOFHPMJ<T> OIAGJKEAOCK(IMemoryOwner<T> DAMCGAELNDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x586A0C0", Offset = "0x5868CC0", VA = "0x18586A0C0")]
	private void BBJGCEELBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x586ABF0", Offset = "0x58697F0", VA = "0x18586ABF0")]
	private OHGOFOFHPMJ<T> HOCAKHDBLIH(OHGOFOFHPMJ<T> BCGOLBEALCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IFNJJBEHGAF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8267450", Offset = "0x8266050", VA = "0x188267450")]
	public IFNJJBEHGAF(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NFGJMKHHPOP<TOk> : IFNJJBEHGAF where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk PDJPIJCCMFN;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5709B70", Offset = "0x5708770", VA = "0x185709B70")]
	private NFGJMKHHPOP([In] TOk CPNOBHNPIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53C75A0", Offset = "0x53C61A0", VA = "0x1853C75A0")]
	public static NFGJMKHHPOP<TOk> MJMNOIPJNFN([In] TOk CPNOBHNPIHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct IADHIMOENNN<TOk, TErr> : IEquatable<IADHIMOENNN<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> KKODCJCMPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr DMGLFPMGPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk PDJPIJCCMFN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NJOJNPAKAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x50558C0", Offset = "0x50544C0", VA = "0x1850558C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool EBBOEMMPCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5055F50", Offset = "0x5054B50", VA = "0x185055F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x505AB80", Offset = "0x5059780", VA = "0x18505AB80")]
	internal IADHIMOENNN([In] TErr HGHFBMAKHEN, [In] TOk CPNOBHNPIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5053A80", Offset = "0x5052680", VA = "0x185053A80")]
	public static IADHIMOENNN<TOk, TErr> FCHDECNAPCA([In] TErr HGHFBMAKHEN)
	{
		return default(IADHIMOENNN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5056A10", Offset = "0x5055610", VA = "0x185056A10")]
	public static IADHIMOENNN<TOk, TErr> KGPJHGLMDJK([In] TOk CPNOBHNPIHD)
	{
		return default(IADHIMOENNN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x43A55B0", Offset = "0x43A41B0", VA = "0x1843A55B0")]
	public IADHIMOENNN<TOk?, UErr?> EKNEKCEODPI<UErr>()
	{
		return default(IADHIMOENNN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x43A7DB0", Offset = "0x43A69B0", VA = "0x1843A7DB0")]
	public IADHIMOENNN<UOk?, TErr?> OHJNHHFDBBI<UOk>()
	{
		return default(IADHIMOENNN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x43A6530", Offset = "0x43A5130", VA = "0x1843A6530")]
	public IADHIMOENNN<UOk?, TErr?> EOIOCDHKLGB<UOk>()
	{
		return default(IADHIMOENNN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x43A7310", Offset = "0x43A5F10", VA = "0x1843A7310")]
	public IADHIMOENNN<TOk?, UErr?> KHMNHGDNOIM<UErr>()
	{
		return default(IADHIMOENNN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5051F20", Offset = "0x5050B20", VA = "0x185051F20")]
	public IADHIMOENNN<DIKEICNGGBM, TErr> CICPFBLPGHA()
	{
		return default(IADHIMOENNN<DIKEICNGGBM, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5051090", Offset = "0x504FC90", VA = "0x185051090")]
	public static bool CDGFDPOPEPC([In] IADHIMOENNN<TOk, TErr> ODBANBBPCIA, [In] IADHIMOENNN<TOk, TErr> FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x50524A0", Offset = "0x50510A0", VA = "0x1850524A0", Slot = "4")]
	public bool Equals(IADHIMOENNN<TOk, TErr> IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5052320", Offset = "0x5050F20", VA = "0x185052320", Slot = "0")]
	public override bool Equals(object IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5054A90", Offset = "0x5053690", VA = "0x185054A90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x50597A0", Offset = "0x50583A0", VA = "0x1850597A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class AOIPEGOKOJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct DNHEGINNCAG<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<IADHIMOENNN<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<IADHIMOENNN<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4478930", Offset = "0x4477530", VA = "0x184478930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4478C30", Offset = "0x4477830", VA = "0x184478C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct IMEEGDPAPGI<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<DIKEICNGGBM, TErr>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Task<IADHIMOENNN<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<IADHIMOENNN<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x50AE5D0", Offset = "0x50AD1D0", VA = "0x1850AE5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x50AE900", Offset = "0x50AD500", VA = "0x1850AE900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3196090", Offset = "0x3194C90", VA = "0x183196090")]
	public static IADHIMOENNN<TOk?, TErr?> PDJPIJCCMFN<TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [In] TOk CPNOBHNPIHD)
	{
		return default(IADHIMOENNN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3199CE0", Offset = "0x31988E0", VA = "0x183199CE0")]
	public static IADHIMOENNN<DIKEICNGGBM, TErr?> PDJPIJCCMFN<TErr>([In] this IADHIMOENNN<DIKEICNGGBM, TErr> JBDFDFABHKD)
	{
		return default(IADHIMOENNN<DIKEICNGGBM, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3196090", Offset = "0x3194C90", VA = "0x183196090")]
	public static IADHIMOENNN<TOk?, TErr?> DMGLFPMGPME<TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [In] TErr HGHFBMAKHEN)
	{
		return default(IADHIMOENNN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3197360", Offset = "0x3195F60", VA = "0x183197360")]
	public static TOk? NJJLCEECJJI<TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x31966B0", Offset = "0x31952B0", VA = "0x1831966B0")]
	[AsyncStateMachine(typeof(DNHEGINNCAG<, >))]
	public static Task<TOk?>? IJKDLJPIKBD<TOk, TErr>(this Task<IADHIMOENNN<TOk, TErr>> JBDFDFABHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x31982D0", Offset = "0x3196ED0", VA = "0x1831982D0")]
	public static TErr? OCMFEGPKBKE<TErr, TOk>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3198A20", Offset = "0x3197620", VA = "0x183198A20")]
	public static bool OGNJHHJDMBH<TOk, TErr, UErr, UOk>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [Out] IADHIMOENNN<UOk, UErr> MJLMNEPGACJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3196200", Offset = "0x3194E00", VA = "0x183196200")]
	public static bool GBABPNKFALB<TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [Out] TOk CPNOBHNPIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3196490", Offset = "0x3195090", VA = "0x183196490")]
	public static bool GBEBNGFJPPK<TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [Out][NotNullWhen(true)] TErr HGHFBMAKHEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3196BC0", Offset = "0x31957C0", VA = "0x183196BC0")]
	public static bool MACBJGEPDEC<TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [Out][NotNullWhen(true)] TOk CPNOBHNPIHD, [Out][NotNullWhen(false)] TErr HGHFBMAKHEN) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3196A30", Offset = "0x3195630", VA = "0x183196A30")]
	public static bool JPHEEGMLHMN<TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [Out][NotNullWhen(true)] TOk CPNOBHNPIHD, [Out] IADHIMOENNN<TOk, TErr> MJLMNEPGACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x31987D0", Offset = "0x31973D0", VA = "0x1831987D0")]
	public static bool OGNJHHJDMBH<TOk, TErr, UErr, UOk>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [Out][NotNullWhen(true)] TOk CPNOBHNPIHD, [Out] IADHIMOENNN<UOk, UErr> MJLMNEPGACJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3196E90", Offset = "0x3195A90", VA = "0x183196E90")]
	public static bool MBHDNHGANDA<TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [Out][NotNullWhen(true)] TOk CPNOBHNPIHD, [Out] IADHIMOENNN<DIKEICNGGBM, TErr> MJLMNEPGACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3197970", Offset = "0x3196570", VA = "0x183197970")]
	public static IADHIMOENNN<UOk, UErr> NMMELDKMBDG<UOk, UErr, TOk, TErr>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, [In] IADHIMOENNN<UOk, UErr> HPNKJCMLGMJ) where TOk : UOk where TErr : UErr
	{
		return default(IADHIMOENNN<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3195B50", Offset = "0x3194750", VA = "0x183195B50")]
	public static IADHIMOENNN<TOk?[]?, TErr?> BBNMKJPMNMJ<TOk, TErr>(this IEnumerable<IADHIMOENNN<TOk, TErr>> JBDFDFABHKD)
	{
		return default(IADHIMOENNN<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3198590", Offset = "0x3197190", VA = "0x183198590")]
	public static IADHIMOENNN<UOk?, TErr?> OFHIIPOEOMG<UOk, TErr, TOk>([In] this IADHIMOENNN<TOk, TErr> JBDFDFABHKD, Func<TOk, UOk> KHDOILNJOHK)
	{
		return default(IADHIMOENNN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3195E90", Offset = "0x3194A90", VA = "0x183195E90")]
	[AsyncStateMachine(typeof(IMEEGDPAPGI<, >))]
	public static Task<IADHIMOENNN<DIKEICNGGBM, TErr?>>? BGFOGCIANOA<TErr, TOk>(this Task<IADHIMOENNN<TOk, TErr>> JBDFDFABHKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PEPLNFFMHLN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x43B5F30", Offset = "0x43B4B30", VA = "0x1843B5F30")]
	public static IADHIMOENNN<TOk, T> PDJPIJCCMFN<TOk>([In] TOk CPNOBHNPIHD) where TOk : notnull
	{
		return default(IADHIMOENNN<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x59BF700", Offset = "0x59BE300", VA = "0x1859BF700")]
	public static IADHIMOENNN<DIKEICNGGBM, T> PDJPIJCCMFN()
	{
		return default(IADHIMOENNN<DIKEICNGGBM, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x43B5EB0", Offset = "0x43B4AB0", VA = "0x1843B5EB0")]
	public static IADHIMOENNN<T, TErr> DMGLFPMGPME<TErr>([In] TErr HGHFBMAKHEN) where TErr : notnull
	{
		return default(IADHIMOENNN<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct BGGGAMDLFNI<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly FGIDOMKGKNE HIFCHMIPFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TValue> OJLNBKLGDDK;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5871BC0", Offset = "0x58707C0", VA = "0x185871BC0")]
	public static BGGGAMDLFNI<TKey, TValue> MJMNOIPJNFN(string PBHLPKLGFAP)
	{
		return default(BGGGAMDLFNI<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5871D70", Offset = "0x5870970", VA = "0x185871D70")]
	internal BGGGAMDLFNI(Dictionary<TKey, TValue> BKMPCFIAHIG, FGIDOMKGKNE MNBIJJACJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5871CD0", Offset = "0x58708D0", VA = "0x185871CD0")]
	public FICKOOCAHFO<TKey, TValue> OIGAJIKBDGA([Out] Dictionary<TKey, TValue> BKMPCFIAHIG)
	{
		return default(FICKOOCAHFO<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FICKOOCAHFO<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TKey, TValue> OJLNBKLGDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NKGCENNGHFG CIIBJIMJFGK;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C94930", Offset = "0x2C93530", VA = "0x182C94930")]
	internal FICKOOCAHFO(Dictionary<TKey, TValue> BKMPCFIAHIG, NKGCENNGHFG BDCFMPHOFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x445D0F0", Offset = "0x445BCF0", VA = "0x18445D0F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct CEEGNEGIMLB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FGIDOMKGKNE HIFCHMIPFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HashSet<T> OJLNBKLGDDK;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5871BC0", Offset = "0x58707C0", VA = "0x185871BC0")]
	public static CEEGNEGIMLB<T> MJMNOIPJNFN(string PBHLPKLGFAP)
	{
		return default(CEEGNEGIMLB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5871D70", Offset = "0x5870970", VA = "0x185871D70")]
	internal CEEGNEGIMLB(HashSet<T> BKMPCFIAHIG, FGIDOMKGKNE MNBIJJACJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5871CD0", Offset = "0x58708D0", VA = "0x185871CD0")]
	public JHKHOMCDONI<T> OIGAJIKBDGA([Out] HashSet<T> BKMPCFIAHIG)
	{
		return default(JHKHOMCDONI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JHKHOMCDONI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HashSet<T> OJLNBKLGDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly NKGCENNGHFG CIIBJIMJFGK;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C94930", Offset = "0x2C93530", VA = "0x182C94930")]
	internal JHKHOMCDONI(HashSet<T> BKMPCFIAHIG, NKGCENNGHFG BDCFMPHOFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x445D0F0", Offset = "0x445BCF0", VA = "0x18445D0F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct OJLIIJDLKAC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FGIDOMKGKNE HIFCHMIPFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Stack<T> OJLNBKLGDDK;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5871BC0", Offset = "0x58707C0", VA = "0x185871BC0")]
	public static OJLIIJDLKAC<T> MJMNOIPJNFN(string PBHLPKLGFAP)
	{
		return default(OJLIIJDLKAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5871D70", Offset = "0x5870970", VA = "0x185871D70")]
	internal OJLIIJDLKAC(Stack<T> BKMPCFIAHIG, FGIDOMKGKNE MNBIJJACJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5871CD0", Offset = "0x58708D0", VA = "0x185871CD0")]
	public DDPKBAGDHFN<T> OIGAJIKBDGA([Out] Stack<T> BKMPCFIAHIG)
	{
		return default(DDPKBAGDHFN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct DDPKBAGDHFN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Stack<T> OJLNBKLGDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NKGCENNGHFG CIIBJIMJFGK;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C94930", Offset = "0x2C93530", VA = "0x182C94930")]
	internal DDPKBAGDHFN(Stack<T> BKMPCFIAHIG, NKGCENNGHFG BDCFMPHOFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x445D0F0", Offset = "0x445BCF0", VA = "0x18445D0F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public sealed class PHPDOMPOAOK<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct CCOCMCMGNJM : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly PHPDOMPOAOK<T> NPLJHLAPOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly int FGOMJIFNIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool EEMGLHLAOCC;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28C9690", Offset = "0x28C8290", VA = "0x1828C9690")]
		public CCOCMCMGNJM(PHPDOMPOAOK<T> EIFNOCFPPHB, int GGBACMDMBDC, bool HAKDIDBEIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B3C0", Offset = "0x6A69FC0", VA = "0x186A6B3C0")]
		public PHPDOMPOAOK<T>.KCFOINEOMHI MIEHOANGBJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B4A0", Offset = "0x6A6A0A0", VA = "0x186A6B4A0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B4A0", Offset = "0x6A6A0A0", VA = "0x186A6B4A0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class KCFOINEOMHI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly PHPDOMPOAOK<T> NPLJHLAPOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly int CNLPPMBPHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int MHANEACOBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly bool EEMGLHLAOCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool DMKJPOHBDMI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5399530", Offset = "0x5398130", VA = "0x185399530")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x5399680", Offset = "0x5398280", VA = "0x185399680", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5399880", Offset = "0x5398480", VA = "0x185399880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5399910", Offset = "0x5398510", VA = "0x185399910")]
		public KCFOINEOMHI(PHPDOMPOAOK<T> EIFNOCFPPHB, int GGBACMDMBDC, bool HAKDIDBEIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x53994B0", Offset = "0x53980B0", VA = "0x1853994B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5399630", Offset = "0x5398230", VA = "0x185399630", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class AHBJMOBGJFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AHBJMOBGJFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5096500", Offset = "0x5095100", VA = "0x185096500")]
		internal T GEHOIAPHLML(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly T[] CHGIFAEDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int MHANEACOBCA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int IADNHCFCINH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x59C74A0", Offset = "0x59C60A0", VA = "0x1859C74A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T ALGELFNIHOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4D48290", Offset = "0x4D46E90", VA = "0x184D48290")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T LELGPBLLFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x59C7470", Offset = "0x59C6070", VA = "0x1859C7470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x59C7410", Offset = "0x59C6010", VA = "0x1859C7410")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PIELHOLGNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x286CC80", Offset = "0x286B880", VA = "0x18286CC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CB99D0", Offset = "0x1CB85D0", VA = "0x181CB99D0")]
	private static int NDPBAPKILJE(int LCCBBMBENOH, int LBLBECEIAEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x59C7850", Offset = "0x59C6450", VA = "0x1859C7850")]
	public PHPDOMPOAOK(int PFHGPMHBODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x59C7650", Offset = "0x59C6250", VA = "0x1859C7650")]
	public PHPDOMPOAOK(int PFHGPMHBODB, Func<T> PLPMJNBIAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x59C7B40", Offset = "0x59C6740", VA = "0x1859C7B40")]
	public PHPDOMPOAOK(T[] LNODOELCPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x59C7620", Offset = "0x59C6220", VA = "0x1859C7620")]
	public void NLFJGGNNJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x59C74E0", Offset = "0x59C60E0", VA = "0x1859C74E0")]
	public IEnumerable<T> MBLOFKMGIFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x59C75A0", Offset = "0x59C61A0", VA = "0x1859C75A0")]
	public PHPDOMPOAOK<T>.KCFOINEOMHI MIEHOANGBJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4EC3690", Offset = "0x4EC2290", VA = "0x184EC3690", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4EC3690", Offset = "0x4EC2290", VA = "0x184EC3690", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BHINMKNHBIB
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x39C3E60", Offset = "0x39C2A60", VA = "0x1839C3E60")]
	public static PHPDOMPOAOK<T> MJMNOIPJNFN<T>(int PFHGPMHBODB, Func<T> PLPMJNBIAPH) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6E5C650", Offset = "0x6E5B250", VA = "0x186E5C650")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8269300", Offset = "0x8267F00", VA = "0x188269300")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8269320", Offset = "0x8267F20", VA = "0x188269320")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8269340", Offset = "0x8267F40", VA = "0x188269340")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x82692E0", Offset = "0x8267EE0", VA = "0x1882692E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A01CD0", Offset = "0x2A008D0", VA = "0x182A01CD0")]
		public RRColor(float KFNDMAAELJD, float DJAGGMPPAPH, float MAKDDCFIOBO, float JPILOOHOBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x80E60D0", Offset = "0x80E4CD0", VA = "0x1880E60D0", Slot = "4")]
		public bool Equals(RRColor IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8268F20", Offset = "0x8267B20", VA = "0x188268F20", Slot = "0")]
		public override bool Equals(object IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8269020", Offset = "0x8267C20", VA = "0x188269020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x82690A0", Offset = "0x8267CA0", VA = "0x1882690A0", Slot = "5")]
		public string ToString(string DNHJAJKHKHI, IFormatProvider DELLHMMJLCI)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8268EC0", Offset = "0x8267AC0", VA = "0x188268EC0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8268E60", Offset = "0x8267A60", VA = "0x188268E60")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8268E90", Offset = "0x8267A90", VA = "0x188268E90")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8268EF0", Offset = "0x8267AF0", VA = "0x188268EF0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8268E30", Offset = "0x8267A30", VA = "0x188268E30")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6080E70", Offset = "0x607FA70", VA = "0x186080E70")]
		public RRColor32(byte KFNDMAAELJD, byte DJAGGMPPAPH, byte MAKDDCFIOBO, byte JPILOOHOBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2406580", Offset = "0x2405180", VA = "0x182406580", Slot = "4")]
		public bool Equals(RRColor32 IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8268970", Offset = "0x8267570", VA = "0x188268970", Slot = "0")]
		public override bool Equals(object IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x150B3A0", Offset = "0x1509FA0", VA = "0x18150B3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8268A70", Offset = "0x8267670", VA = "0x188268A70")]
		public static RRColor32 KDDDGPNBGLG(RRColor FBNAMAEDFNA)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8268A00", Offset = "0x8267600", VA = "0x188268A00")]
		public static RRColor KDDDGPNBGLG(RRColor32 FBNAMAEDFNA)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8268BC0", Offset = "0x82677C0", VA = "0x188268BC0", Slot = "5")]
		public string ToString(string DNHJAJKHKHI, IFormatProvider DELLHMMJLCI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class ODJIJDMEIPP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct CCNFBGJEFGF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly ODJIJDMEIPP<T> GFILBAGBLIK;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T AHLMJDKCEID
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5CC1600", Offset = "0x5CC0200", VA = "0x185CC1600")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A4A0", Offset = "0x6A690A0", VA = "0x186A6A4A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
		public CCNFBGJEFGF(ODJIJDMEIPP<T> GFILBAGBLIK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PGOCODHNHBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<CCNFBGJEFGF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ODJIJDMEIPP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x59C53A0", Offset = "0x59C3FA0", VA = "0x1859C53A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x48F2B40", Offset = "0x48F1740", VA = "0x1848F2B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly SemaphoreSlim FGFCMMCHIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private T MGGDDGHIKIG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x584F260", Offset = "0x584DE60", VA = "0x18584F260")]
	public ODJIJDMEIPP([In] T MGGDDGHIKIG, int GDPIIHBFLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x584F1A0", Offset = "0x584DDA0", VA = "0x18584F1A0")]
	public ODJIJDMEIPP([In] T MGGDDGHIKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x584ED00", Offset = "0x584D900", VA = "0x18584ED00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x584ECC0", Offset = "0x584D8C0", VA = "0x18584ECC0")]
	public CCNFBGJEFGF BLMCPDJNOMF()
	{
		return default(CCNFBGJEFGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x584EF80", Offset = "0x584DB80", VA = "0x18584EF80")]
	[AsyncStateMachine(typeof(ODJIJDMEIPP<>.PGOCODHNHBM))]
	public Task<ODJIJDMEIPP<T>.CCNFBGJEFGF> ICJOCMHGNLP(CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x584ED40", Offset = "0x584D940", VA = "0x18584ED40")]
	public void FDPMBJIEILI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LDFDFBICPJF
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8267F10", Offset = "0x8266B10", VA = "0x188267F10")]
	public static ODJIJDMEIPP<DIKEICNGGBM> MJMNOIPJNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x39C4240", Offset = "0x39C2E40", VA = "0x1839C4240")]
	public static ODJIJDMEIPP<T> MJMNOIPJNFN<T>([In] T MGGDDGHIKIG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class MEBKKMMOAKH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct EIMHMDABICB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly MEBKKMMOAKH<T> KJDFLKAODOG;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T AHLMJDKCEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x48DE440", Offset = "0x48DD040", VA = "0x1848DE440")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x48DE320", Offset = "0x48DCF20", VA = "0x1848DE320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
		internal EIMHMDABICB(MEBKKMMOAKH<T> GFILBAGBLIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct AHKODKOCGKE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly MEBKKMMOAKH<T> KJDFLKAODOG;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T AHLMJDKCEID
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x48DE440", Offset = "0x48DD040", VA = "0x1848DE440")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5096A20", Offset = "0x5095620", VA = "0x185096A20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
		internal AHKODKOCGKE(MEBKKMMOAKH<T> GFILBAGBLIK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct ENPNODDCOJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<AHKODKOCGKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MEBKKMMOAKH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private ODJIJDMEIPP<DIKEICNGGBM>.CCNFBGJEFGF <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<ODJIJDMEIPP<DIKEICNGGBM>.CCNFBGJEFGF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x48F2620", Offset = "0x48F1220", VA = "0x1848F2620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x48F2B40", Offset = "0x48F1740", VA = "0x1848F2B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly ODJIJDMEIPP<int> FKCKCBNNCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly ODJIJDMEIPP<DIKEICNGGBM> DJLBDJLECOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ODJIJDMEIPP<DIKEICNGGBM> PGPBKJLANID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private T FDKPMNPNOAJ;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x566B210", Offset = "0x5669E10", VA = "0x18566B210")]
	internal MEBKKMMOAKH(ODJIJDMEIPP<int> AAIENDFCPPG, ODJIJDMEIPP<DIKEICNGGBM> MNACPPNMJAL, ODJIJDMEIPP<DIKEICNGGBM> LIHNPMGCPMK, [In] T MGGDDGHIKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x566A4A0", Offset = "0x56690A0", VA = "0x18566A4A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x566A9A0", Offset = "0x56695A0", VA = "0x18566A9A0")]
	public EIMHMDABICB HEHDBFMCKCL()
	{
		return default(EIMHMDABICB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x566AEC0", Offset = "0x5669AC0", VA = "0x18566AEC0")]
	public AHKODKOCGKE KJONDBHMIMN()
	{
		return default(AHKODKOCGKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x566AC80", Offset = "0x5669880", VA = "0x18566AC80")]
	[AsyncStateMachine(typeof(MEBKKMMOAKH<>.ENPNODDCOJC))]
	public Task<MEBKKMMOAKH<T>.AHKODKOCGKE> HEKMMNCOEAI(CancellationToken JHCOCAANJDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NJJNOAOBMML
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8268530", Offset = "0x8267130", VA = "0x188268530")]
	public static MEBKKMMOAKH<DIKEICNGGBM> MJMNOIPJNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3DC95B0", Offset = "0x3DC81B0", VA = "0x183DC95B0")]
	public static MEBKKMMOAKH<T> MJMNOIPJNFN<T>([In] T MGGDDGHIKIG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class NPLFHLPCFHA<TData> : CLKLDHBJINM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly string GDBNPINLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly TData OHABHFNOKHJ;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
	public override string BAMDPIFKGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x572EE20", Offset = "0x572DA20", VA = "0x18572EE20")]
	internal NPLFHLPCFHA(string HLMEMBFCHLD, [In] TData CBCNBAPLLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ACMIHEMMJKD
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8264F10", Offset = "0x8263B10", VA = "0x188264F10")]
	public static NPLFHLPCFHA<DIKEICNGGBM> MJMNOIPJNFN(string HLMEMBFCHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3187C80", Offset = "0x3186880", VA = "0x183187C80")]
	public static NPLFHLPCFHA<TData> MJMNOIPJNFN<TData>(string HLMEMBFCHLD, [In] TData CBCNBAPLLJM) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class FGIDOMKGKNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal bool DOMKMBKPIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly string NNKEGMJKCKO;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xF3B900", Offset = "0xF3A500", VA = "0x180F3B900")]
	private FGIDOMKGKNE(bool IOOCPDLOPJN, string CKPHGMHLFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8265B60", Offset = "0x8264760", VA = "0x188265B60")]
	public static FGIDOMKGKNE MJMNOIPJNFN(string CKPHGMHLFLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8265BD0", Offset = "0x82647D0", VA = "0x188265BD0")]
	public NKGCENNGHFG OIGAJIKBDGA()
	{
		return default(NKGCENNGHFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct NKGCENNGHFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly FGIDOMKGKNE OMLHMMMGABI;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
	internal NKGCENNGHFG(FGIDOMKGKNE PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8268600", Offset = "0x8267200", VA = "0x188268600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class LGDKCMMGNCD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class FKLPIGFCJNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FKLPIGFCJNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4D7A8D0", Offset = "0x4D794D0", VA = "0x184D7A8D0")]
		internal int BCJILAFNOCB(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private HashSet<T>? BNKOCAFAHCK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> APGBNNNFMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x545F5D0", Offset = "0x545E1D0", VA = "0x18545F5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool EIBOFOPGACF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x48CC790", Offset = "0x48CB390", VA = "0x1848CC790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCA0", Offset = "0xA5E8A0", VA = "0x180A5FCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x545F480", Offset = "0x545E080", VA = "0x18545F480")]
	public bool NDGLNAHKHEG(T DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x545F2B0", Offset = "0x545DEB0", VA = "0x18545F2B0")]
	public bool ENKPLOICKCM(T DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x545F440", Offset = "0x545E040", VA = "0x18545F440")]
	public bool KDPIOFHPCJJ(T DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x545F3C0", Offset = "0x545DFC0", VA = "0x18545F3C0")]
	public void IMNLAFJNPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x545F600", Offset = "0x545E200", VA = "0x18545F600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public LGDKCMMGNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class IACMJMJNBEK
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LFJFGJJOOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LFJFGJJOOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8267F80", Offset = "0x8266B80", VA = "0x188267F80")]
		internal int BCJILAFNOCB(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private HashSet<object>? BNKOCAFAHCK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> APGBNNNFMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8267210", Offset = "0x8265E10", VA = "0x188267210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool EIBOFOPGACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8267050", Offset = "0x8265C50", VA = "0x188267050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCA0", Offset = "0xA5E8A0", VA = "0x180A5FCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8267130", Offset = "0x8265D30", VA = "0x188267130")]
	public bool NDGLNAHKHEG(object DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8266FB0", Offset = "0x8265BB0", VA = "0x188266FB0")]
	public bool ENKPLOICKCM(object DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x82670D0", Offset = "0x8265CD0", VA = "0x1882670D0")]
	public bool KDPIOFHPCJJ(object DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8267060", Offset = "0x8265C60", VA = "0x188267060")]
	public void IMNLAFJNPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x82672A0", Offset = "0x8265EA0", VA = "0x1882672A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public IACMJMJNBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class EPJDJILHGKF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct AFGOMHJACCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float KHOJKKJFMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public T AHLMJDKCEID;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<object, AFGOMHJACCP> ELIABFCDDBG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T HMJMELILNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x11E45F0", Offset = "0x11E31F0", VA = "0x1811E45F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1B9C9B0", Offset = "0x1B9B5B0", VA = "0x181B9C9B0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? NPADINNKKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IJLGIOHKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x48FFDD0", Offset = "0x48FE9D0", VA = "0x1848FFDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4901BA0", Offset = "0x49007A0", VA = "0x184901BA0")]
	public bool NFFELAKAFBO(T BKMPCFIAHIG, object DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x49017A0", Offset = "0x49003A0", VA = "0x1849017A0")]
	public bool HJKJEJAICJB(object DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4901770", Offset = "0x4900370", VA = "0x184901770")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4901500", Offset = "0x4900100", VA = "0x184901500")]
	public bool GLNNPKODOFD(object DANCOEFIHDF, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x49000A0", Offset = "0x48FECA0", VA = "0x1849000A0")]
	[AFOGCKCBHFD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BHPEICAJPNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4901FC0", Offset = "0x4900BC0", VA = "0x184901FC0")]
	public EPJDJILHGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class GPPIOPCLACN : ECCENKHCDOD<HDJJBEMDFDP>
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class CBFIKBIDGGC : IEqualityComparer<HDJJBEMDFDP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal static readonly CBFIKBIDGGC MFAGMJBMEEP;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x82650D0", Offset = "0x8263CD0", VA = "0x1882650D0", Slot = "4")]
		public bool Equals(HDJJBEMDFDP LGCEHLADNJC, HDJJBEMDFDP LFHMHCKODDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x734D750", Offset = "0x734C350", VA = "0x18734D750", Slot = "5")]
		public int GetHashCode(HDJJBEMDFDP KOJLNGLNBMH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CBFIKBIDGGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8266350", Offset = "0x8264F50", VA = "0x188266350")]
	public GPPIOPCLACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x82662A0", Offset = "0x8264EA0", VA = "0x1882662A0", Slot = "4")]
	public override bool NDGLNAHKHEG(HDJJBEMDFDP DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x82661F0", Offset = "0x8264DF0", VA = "0x1882661F0", Slot = "5")]
	public override bool ENKPLOICKCM(HDJJBEMDFDP DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8266160", Offset = "0x8264D60", VA = "0x188266160")]
	private static void DJOFEAFPDIB(HDJJBEMDFDP DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xAC3660", Offset = "0xAC2260", VA = "0x180AC3660", Slot = "6")]
	protected override string TokenToString(HDJJBEMDFDP DANCOEFIHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class HDJJBEMDFDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly string KCBNCFPGIOH;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public HDJJBEMDFDP(string KCBNCFPGIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x82663C0", Offset = "0x8264FC0", VA = "0x1882663C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class ECCENKHCDOD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IEqualityComparer<T> FLFBEHPGIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private HashSet<T>? BNKOCAFAHCK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> APGBNNNFMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x48CCB10", Offset = "0x48CB710", VA = "0x1848CCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EIBOFOPGACF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x48CC790", Offset = "0x48CB390", VA = "0x1848CC790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6880", Offset = "0xAB5480", VA = "0x180AB6880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x48CD180", Offset = "0x48CBD80", VA = "0x1848CD180")]
	public ECCENKHCDOD(IEqualityComparer<T> FLFBEHPGIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x48CC840", Offset = "0x48CB440", VA = "0x1848CC840", Slot = "4")]
	public virtual bool NDGLNAHKHEG(T DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x48CC680", Offset = "0x48CB280", VA = "0x1848CC680", Slot = "5")]
	public virtual bool ENKPLOICKCM(T DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x48CC7C0", Offset = "0x48CB3C0", VA = "0x1848CC7C0")]
	public void IMNLAFJNPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x48CCE00", Offset = "0x48CBA00", VA = "0x1848CCE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class COEGADFMPKG<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<WeakReference<T>>? BNKOCAFAHCK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool EIBOFOPGACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A2E0", Offset = "0x6C48EE0", VA = "0x186C4A2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A1A0", Offset = "0x6C48DA0", VA = "0x186C4A1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A500", Offset = "0x6C49100", VA = "0x186C4A500")]
	public void NDGLNAHKHEG(T DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A060", Offset = "0x6C48C60", VA = "0x186C4A060")]
	public void ENKPLOICKCM(T DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A3F0", Offset = "0x6C48FF0", VA = "0x186C4A3F0")]
	public bool KDPIOFHPCJJ(T DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A3D0", Offset = "0x6C48FD0", VA = "0x186C4A3D0")]
	public void IMNLAFJNPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A700", Offset = "0x6C49300", VA = "0x186C4A700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public COEGADFMPKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class OAELCLNIEFE
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3C2F130", Offset = "0x3C2DD30", VA = "0x183C2F130")]
	public static void FLNCHNHPMMB<T>(this List<T> ADEANPNALNF, int LCCBBMBENOH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FFAMFPJLMBA<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private struct GPFAEMPAEDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public float KHOJKKJFMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public T AHLMJDKCEID;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<HDJJBEMDFDP, GPFAEMPAEDA> ELIABFCDDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly EqualityComparer<T> NOMHPLBLMKC;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T HMJMELILNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A350", VA = "0x180A5B750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B510", Offset = "0xA5A110", VA = "0x180A5B510", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private HDJJBEMDFDP? NPADINNKKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool IJLGIOHKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x48FFDD0", Offset = "0x48FE9D0", VA = "0x1848FFDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4D6F5D0", Offset = "0x4D6E1D0", VA = "0x184D6F5D0")]
	public bool NFFELAKAFBO(T BKMPCFIAHIG, HDJJBEMDFDP DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x49017A0", Offset = "0x49003A0", VA = "0x1849017A0")]
	public bool HJKJEJAICJB(HDJJBEMDFDP DANCOEFIHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4901770", Offset = "0x4900370", VA = "0x184901770")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4901700", Offset = "0x4900300", VA = "0x184901700")]
	public bool GLNNPKODOFD(HDJJBEMDFDP DANCOEFIHDF, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4D6EF90", Offset = "0x4D6DB90", VA = "0x184D6EF90")]
	[AFOGCKCBHFD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BHPEICAJPNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4D6F6B0", Offset = "0x4D6E2B0", VA = "0x184D6F6B0")]
	public FFAMFPJLMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HLMDMJEMDFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<object, float> ELIABFCDDBG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float HFMBNOIDFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAB55B0", Offset = "0xAB41B0", VA = "0x180AB55B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1341FB0", Offset = "0x1340BB0", VA = "0x181341FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8266EB0", Offset = "0x8265AB0", VA = "0x188266EB0")]
	public void NFFELAKAFBO(float BKMPCFIAHIG, object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8266D10", Offset = "0x8265910", VA = "0x188266D10")]
	public void HJKJEJAICJB(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8266CC0", Offset = "0x82658C0", VA = "0x188266CC0")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8266D80", Offset = "0x8265980", VA = "0x188266D80")]
	private void KNFIJCJHCAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8266F20", Offset = "0x8265B20", VA = "0x188266F20")]
	public HLMDMJEMDFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface EGADDPGNOEN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GNEOHDAODCI JNJOPCMOPBM;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class JAGFCMEPKLK : EGADDPGNOEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct FEPKOAFEBIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly float JLODMKOIAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly float ELIJGEBKLPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal readonly bool BGMCAGMEELL;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float FEOFCNGFMML
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8265880", Offset = "0x8264480", VA = "0x188265880")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8265A00", Offset = "0x8264600", VA = "0x188265A00")]
		public FEPKOAFEBIA(float LJEEMMFNMLE, float MAFBAKDLLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8265890", Offset = "0x8264490", VA = "0x188265890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class PIIHNHACHJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public JAGFCMEPKLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public PIIHNHACHJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x82688D0", Offset = "0x82674D0", VA = "0x1882688D0")]
		internal void DDMKOLPCMMD(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int FJNGONEOHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int NPHBJDJADLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EGADDPGNOEN[] DLMIMJGHEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly GNEOHDAODCI[] FFBAIGJFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly FEPKOAFEBIA[] NPCDLBKFANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private FEPKOAFEBIA PDNNKKKNNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NKJPNBPOJGB IFBAELDKDAE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event GNEOHDAODCI JNJOPCMOPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82677B0", Offset = "0x82663B0", VA = "0x1882677B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x82675E0", Offset = "0x82661E0", VA = "0x1882675E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8267D80", Offset = "0x8266980", VA = "0x188267D80")]
	public JAGFCMEPKLK(int FJNGONEOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8267CF0", Offset = "0x82668F0", VA = "0x188267CF0")]
	public NKJPNBPOJGB NKCPJPHIDGP(FEPKOAFEBIA BNBCBHJAJGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8267870", Offset = "0x8266470", VA = "0x188267870")]
	public void HFNLKKDEOMF(EGADDPGNOEN EIKLEODEOFM, [Optional] FEPKOAFEBIA KMFAACJDFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x82676A0", Offset = "0x82662A0", VA = "0x1882676A0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void GNEOHDAODCI(float BICEBNIJDLJ);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class IPFNDIPGEDP
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class AOJHEBIIOGG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly EGADDPGNOEN PGLBMFGPOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly GNEOHDAODCI HFBNHPDLHHL;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8265040", Offset = "0x8263C40", VA = "0x188265040")]
		public AOJHEBIIOGG(EGADDPGNOEN PGLBMFGPOLP, GNEOHDAODCI HFBNHPDLHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8264FF0", Offset = "0x8263BF0", VA = "0x188264FF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8267570", Offset = "0x8266170", VA = "0x188267570")]
	internal static bool MOGELPFPJMO(float JPILOOHOBDJ, float MAKDDCFIOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8250340", Offset = "0x824EF40", VA = "0x188250340")]
	internal static float MFIBPPNJPFH(float JPILOOHOBDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x82674B0", Offset = "0x82660B0", VA = "0x1882674B0")]
	public static IDisposable JFIJKCELMNB(this EGADDPGNOEN PGLBMFGPOLP, GNEOHDAODCI HFBNHPDLHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class NKJPNBPOJGB : EGADDPGNOEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float BICEBNIJDLJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float MIDLKPJOJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8268760", Offset = "0x8267360", VA = "0x188268760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event GNEOHDAODCI? JNJOPCMOPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x82686C0", Offset = "0x82672C0", VA = "0x1882686C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8268620", Offset = "0x8267220", VA = "0x188268620", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public NKJPNBPOJGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface KHNDHJMDMBM<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PDMICMOCKGB<T> PKHHFIDGGFC([Out] T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HAGLLFMPLGJ();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PEHFLGFKBFE<T> : KHNDHJMDMBM<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ConcurrentStack<T> GFJHKPHELCI;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x59BF1A0", Offset = "0x59BDDA0", VA = "0x1859BF1A0", Slot = "4")]
	public PDMICMOCKGB<T> PKHHFIDGGFC([Out] T BKMPCFIAHIG)
	{
		return default(PDMICMOCKGB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x59BF140", Offset = "0x59BDD40", VA = "0x1859BF140")]
	public void NCHKMOJJHLK(T GLIOHJLPIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x545ACB0", Offset = "0x54598B0", VA = "0x18545ACB0", Slot = "5")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "6")]
	protected virtual void OCCDOEBHLAD(T JFOFKHOBAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x59BF0C0", Offset = "0x59BDCC0", VA = "0x1859BF0C0")]
	private T LGFPFICEOKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x59BF220", Offset = "0x59BDE20", VA = "0x1859BF220")]
	public PEHFLGFKBFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct PDMICMOCKGB<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly T GLIOHJLPIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly PEHFLGFKBFE<T> KBEGPPOKLOC;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
	internal PDMICMOCKGB(T BKMPCFIAHIG, PEHFLGFKBFE<T> KBEGPPOKLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x59BED20", Offset = "0x59BD920", VA = "0x1859BED20", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MALBOAMIMMA : PEHFLGFKBFE<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly MALBOAMIMMA MFAGMJBMEEP;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8268390", Offset = "0x8266F90", VA = "0x188268390")]
	public static PDMICMOCKGB<StringBuilder> LGFPFICEOKK([Out] StringBuilder BKMPCFIAHIG)
	{
		return default(PDMICMOCKGB<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8268430", Offset = "0x8267030", VA = "0x188268430", Slot = "6")]
	protected override void OCCDOEBHLAD(StringBuilder JFOFKHOBAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x82684F0", Offset = "0x82670F0", VA = "0x1882684F0")]
	public MALBOAMIMMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class POFLAMEEMMC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7AB8260", Offset = "0x7AB6E60", VA = "0x187AB8260")]
	public POFLAMEEMMC(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class DBHEMLHJKFK<TKey, TValue> : MDDOAHGLFGE<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, PIDNFNADICO where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class PCCLDBHMFAH : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public DBHEMLHJKFK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x11E45F0", Offset = "0x11E31F0", VA = "0x1811E45F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x4E10A40", Offset = "0x4E0F640", VA = "0x184E10A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public PCCLDBHMFAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E10AE0", Offset = "0x4E0F6E0", VA = "0x184E10AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x59BC950", Offset = "0x59BB550", VA = "0x1859BC950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x59BC0D0", Offset = "0x59BACD0", VA = "0x1859BC0D0")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x59BC120", Offset = "0x59BAD20", VA = "0x1859BC120")]
		private void KBNMMFGEPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x59BCD20", Offset = "0x59BB920", VA = "0x1859BCD20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MDDOAHGLFGE<TKey, TValue> JMEOODGNHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IDictionary<TKey, TValue> FNICDNJJLGB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4452DB0", Offset = "0x44519B0", VA = "0x184452DB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OBFGHCLKFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4453040", Offset = "0x4451C40", VA = "0x184453040", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4453280", Offset = "0x4451E80", VA = "0x184453280", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> MLFPECEOLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4453080", Offset = "0x4451C80", VA = "0x184453080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> OGINALBFHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4453180", Offset = "0x4451D80", VA = "0x184453180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4452D00", Offset = "0x4451900", VA = "0x184452D00")]
	public DBHEMLHJKFK(MDDOAHGLFGE<TKey, TValue> JMEOODGNHCO, [Optional] IDictionary<TKey, TValue>? FNICDNJJLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4450760", Offset = "0x444F360", VA = "0x184450760", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4450710", Offset = "0x444F310", VA = "0x184450710")]
	public void BBDEFJAICLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x44504E0", Offset = "0x444F0E0", VA = "0x1844504E0", Slot = "9")]
	public void Add(TKey DHCHBFGMFFD, TValue BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4451E90", Offset = "0x4450A90", VA = "0x184451E90")]
	public void PCMMMBOGKBP(TKey DHCHBFGMFFD, TValue BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4451B40", Offset = "0x4450740", VA = "0x184451B40")]
	public void NCOGNODBNJK(TKey DHCHBFGMFFD, TValue BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4451460", Offset = "0x4450060", VA = "0x184451460")]
	public void JOFLKLKALHN(TKey DHCHBFGMFFD, TValue BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4451AA0", Offset = "0x44506A0", VA = "0x184451AA0")]
	public void LMKBLPDHPGM(TKey DHCHBFGMFFD, TValue BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4452370", Offset = "0x4450F70", VA = "0x184452370", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4452540", Offset = "0x4451140", VA = "0x184452540", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4452700", Offset = "0x4451300", VA = "0x184452700", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x44507D0", Offset = "0x444F3D0", VA = "0x1844507D0", Slot = "8")]
	public bool ContainsKey(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x44513A0", Offset = "0x444FFA0", VA = "0x1844513A0")]
	public bool HONIPPFHDLC(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4451960", Offset = "0x4450560", VA = "0x184451960")]
	public bool KENAFGHLKEL(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x44521B0", Offset = "0x4450DB0", VA = "0x1844521B0", Slot = "10")]
	public bool Remove(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4452B60", Offset = "0x4451760", VA = "0x184452B60", Slot = "11")]
	public bool TryGetValue(TKey DHCHBFGMFFD, [Out] TValue BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4450900", Offset = "0x444F500", VA = "0x184450900", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] COJHNLDFDFB, int FPBBDMPMMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4452A60", Offset = "0x4451660", VA = "0x184452A60", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x44512B0", Offset = "0x444FEB0", VA = "0x1844512B0", Slot = "19")]
	[IteratorStateMachine(typeof(DBHEMLHJKFK<, >.PCCLDBHMFAH))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4451DF0", Offset = "0x44509F0", VA = "0x184451DF0", Slot = "21")]
	public bool OJBMMGINIMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4451050", Offset = "0x444FC50", VA = "0x184451050")]
	private TValue DHNDKNKJCJJ(TKey DHCHBFGMFFD)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface NFPANIBABKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string KDDMLIGBPOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface PIDNFNADICO
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJBMMGINIMG();
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface MDDOAHGLFGE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, PIDNFNADICO
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DefaultMember("Item")]
public sealed class BGFCJDALAHK<TKey, TVal> : MDDOAHGLFGE<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, PIDNFNADICO where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int BPJKAFHNEJC(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate void GBBMOENHCCH(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG, BPKOGKMOCCO LENOHNAJDNM);

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class HHGCCLPDNFP
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey DICGCMOFCOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xE507D0", Offset = "0xE4F3D0", VA = "0x180E507D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal AHLMJDKCEID
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB6880", Offset = "0xAB5480", VA = "0x180AB6880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int FEOFCNGFMML
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0B60", Offset = "0xABF760", VA = "0x180AC0B60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x10131E0", Offset = "0x1011DE0", VA = "0x1810131E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset MKPMGLOFDJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x13A8BF0", Offset = "0x13A77F0", VA = "0x1813A8BF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x14B08C0", Offset = "0x14AF4C0", VA = "0x1814B08C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C9E0", Offset = "0x4F8B5E0", VA = "0x184F8C9E0")]
		public HHGCCLPDNFP(TKey DHCHBFGMFFD, TVal PINMHDANIAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class ALBCDKBCAGL : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public BGFCJDALAHK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private LinkedList<HHGCCLPDNFP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x11E45F0", Offset = "0x11E31F0", VA = "0x1811E45F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x5185CD0", Offset = "0x51848D0", VA = "0x185185CD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public ALBCDKBCAGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4DF40C0", Offset = "0x4DF2CC0", VA = "0x184DF40C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5183650", Offset = "0x5182250", VA = "0x185183650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5183380", Offset = "0x5181F80", VA = "0x185183380")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5185AF0", Offset = "0x51846F0", VA = "0x185185AF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int OGJMDKECOAL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<HHGCCLPDNFP>> LBFMPJEBONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<HHGCCLPDNFP> MMHBHPAKHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly BPJKAFHNEJC? NCLGALCEKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan HJNGPDACLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly GBBMOENHCCH? HGPMKDEPAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly GAFEJJBMOGG JBINMFICFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool DGBALMGJLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<TKey> APMGMHCDBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<TVal> CCDIKKNFDCF;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int LNNGLAPDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xD050B0", Offset = "0xD03CB0", VA = "0x180D050B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int PJPMEFFADNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xE4A600", Offset = "0xE49200", VA = "0x180E4A600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xF7F2B0", Offset = "0xF7DEB0", VA = "0x180F7F2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6349CA0", Offset = "0x63488A0", VA = "0x186349CA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int CNOFPCMCANC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5649970", Offset = "0x5648570", VA = "0x185649970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> OGINALBFHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6349D80", Offset = "0x6348980", VA = "0x186349D80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.KCJPOGKHMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6348400", Offset = "0x6347000", VA = "0x186348400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool OBFGHCLKFON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6349D40", Offset = "0x6348940", VA = "0x186349D40", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6349DB0", Offset = "0x63489B0", VA = "0x186349DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6347C80", Offset = "0x6346880", VA = "0x186347C80")]
	private bool PPPJNIMKAOG(int FJNGONEOHID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6346D90", Offset = "0x6345990", VA = "0x186346D90")]
	private void NCNGGLJBNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6349670", Offset = "0x6348270", VA = "0x186349670")]
	public BGFCJDALAHK(int FJNGONEOHID, [Optional] BPJKAFHNEJC? NCLGALCEKEA, [Optional] IEqualityComparer<TKey>? LFALBIKDJJH, [Optional] GBBMOENHCCH? HGPMKDEPAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6348990", Offset = "0x6347590", VA = "0x186348990")]
	public BGFCJDALAHK(TimeSpan HJNGPDACLKA, [Optional] IEqualityComparer<TKey>? LFALBIKDJJH, [Optional] GBBMOENHCCH? HGPMKDEPAAM, [Optional] GAFEJJBMOGG? JBINMFICFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6348940", Offset = "0x6347540", VA = "0x186348940")]
	public BGFCJDALAHK(int FJNGONEOHID, TimeSpan HJNGPDACLKA, [Optional] IEqualityComparer<TKey>? LFALBIKDJJH, [Optional] GBBMOENHCCH? HGPMKDEPAAM, [Optional] GAFEJJBMOGG? JBINMFICFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6349730", Offset = "0x6348330", VA = "0x186349730")]
	public BGFCJDALAHK(int FJNGONEOHID, BPJKAFHNEJC? NCLGALCEKEA, TimeSpan HJNGPDACLKA, [Optional] IEqualityComparer<TKey>? LFALBIKDJJH, [Optional] GBBMOENHCCH? HGPMKDEPAAM, [Optional] GAFEJJBMOGG? JBINMFICFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6347C20", Offset = "0x6346820", VA = "0x186347C20", Slot = "21")]
	public bool OJBMMGINIMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6346530", Offset = "0x6345130", VA = "0x186346530", Slot = "22")]
	public bool MDECPJHAIMJ(int PFHGPMHBODB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6342FE0", Offset = "0x6341BE0", VA = "0x186342FE0")]
	private bool GMODBNBBLPI(int PFHGPMHBODB, BPKOGKMOCCO LENOHNAJDNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6344140", Offset = "0x6342D40", VA = "0x186344140")]
	public void IEFFBEILLPC(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6341590", Offset = "0x6340190", VA = "0x186341590", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BHNJKAEPJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6341410", Offset = "0x6340010", VA = "0x186341410", Slot = "9")]
	public void Add(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x63417A0", Offset = "0x63403A0", VA = "0x1863417A0", Slot = "8")]
	public bool ContainsKey(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x63480E0", Offset = "0x6346CE0", VA = "0x1863480E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6347CD0", Offset = "0x63468D0", VA = "0x186347CD0", Slot = "10")]
	public bool Remove(TKey DHCHBFGMFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x63482D0", Offset = "0x6346ED0", VA = "0x1863482D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> BHNJKAEPJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6345E10", Offset = "0x6344A10", VA = "0x186345E10")]
	private bool KHNDLLOAGKB(TKey DHCHBFGMFFD, [Out] TVal BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6346010", Offset = "0x6344C10", VA = "0x186346010")]
	private TVal LGFPFICEOKK(TKey JKIPLLMBEPO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x63487B0", Offset = "0x63473B0", VA = "0x1863487B0", Slot = "11")]
	public bool TryGetValue(TKey JKIPLLMBEPO, [Out] TVal BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6341700", Offset = "0x6340300", VA = "0x186341700", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6341BE0", Offset = "0x63407E0", VA = "0x186341BE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] COJHNLDFDFB, int FPBBDMPMMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6342810", Offset = "0x6341410", VA = "0x186342810")]
	private void GEBNPIBJFEG(TKey DHCHBFGMFFD, TVal PINMHDANIAH, BPKOGKMOCCO LENOHNAJDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6344750", Offset = "0x6343350", VA = "0x186344750")]
	private bool JCNMLPOGJNG(HHGCCLPDNFP MADAEMANFDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6345150", Offset = "0x6343D50", VA = "0x186345150")]
	private void JOOMFAPCDPP(LinkedListNode<HHGCCLPDNFP> EBLONJBOEKJ, TVal CBMDPCIEEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x63476E0", Offset = "0x63462E0", VA = "0x1863476E0")]
	private void NFFELAKAFBO(TKey DHCHBFGMFFD, TVal BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6346650", Offset = "0x6345250", VA = "0x186346650")]
	private void MOBGEOGEOIF(HHGCCLPDNFP MADAEMANFDA, TVal CBMDPCIEEMO, int HEOJCLMFPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6343F30", Offset = "0x6342B30", VA = "0x186343F30", Slot = "19")]
	[IteratorStateMachine(typeof(BGFCJDALAHK<, >.ALBCDKBCAGL))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6348430", Offset = "0x6347030", VA = "0x186348430", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public enum BPKOGKMOCCO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class DPLEAAJPKCB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly TKey CDLKCIFCFOL;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x447FD60", Offset = "0x447E960", VA = "0x18447FD60")]
	public DPLEAAJPKCB(TKey CBMOHAPLPNE, Exception BOEANKIKAPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class NKLBHMNKMPH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72E0670", Offset = "0x72DF270", VA = "0x1872E0670")]
	public NKLBHMNKMPH(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OAINJCAAIFK<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class BHFABKLCKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public OAINJCAAIFK<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BHFABKLCKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x64374A0", Offset = "0x64360A0", VA = "0x1864374A0")]
		internal Task<TResource> GKJAEFOFMLK(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct ONOEHICPEJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public OAINJCAAIFK<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x588C540", Offset = "0x588B140", VA = "0x18588C540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x588CE40", Offset = "0x588BA40", VA = "0x18588CE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct KPHKBNFNPDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x53D4030", Offset = "0x53D2C30", VA = "0x1853D4030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x53D4460", Offset = "0x53D3060", VA = "0x1853D4460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly HKNANFCMAFF<TId, Task<TResource>> HLNECADABGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> AKPLJMEOBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? HIDOAPFEHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Action<TResource>? MIOHDFKHLKI;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x583F0E0", Offset = "0x583DCE0", VA = "0x18583F0E0")]
	public OAINJCAAIFK(int FIDAAGJHPMA = 0, [Optional] IEqualityComparer<TId>? CBFACMEDEHM, [Optional] Func<TId, CancellationToken, Task<TResource>>? PABEIKHNOBO, [Optional] Action<TResource>? OLBNKJOIHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x583DA60", Offset = "0x583C660", VA = "0x18583DA60")]
	public ODNHGKKANOM<Task<TResource>> BBMGDJPIKOB(TId OIBGADINDDP, [Optional] Func<TId, CancellationToken, Task<TResource>>? PABEIKHNOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x583EE20", Offset = "0x583DA20", VA = "0x18583EE20")]
	private void NPOHFGHHAJJ(Task<TResource> MHGNKNMAFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x583E2E0", Offset = "0x583CEE0", VA = "0x18583E2E0")]
	[AsyncStateMachine(typeof(OAINJCAAIFK<, >.ONOEHICPEJF))]
	private Task DALICEINBPJ(Task<TResource> MHGNKNMAFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x583E9A0", Offset = "0x583D5A0", VA = "0x18583E9A0")]
	public void GFLLHHKILFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x583E9D0", Offset = "0x583D5D0", VA = "0x18583E9D0")]
	public HKNANFCMAFF<TId, Task<TResource>>.BHNBDCEEIAG MIEHOANGBJG()
	{
		return default(HKNANFCMAFF<TId, Task<TResource>>.BHNBDCEEIAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x583EF20", Offset = "0x583DB20", VA = "0x18583EF20", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x583EF20", Offset = "0x583DB20", VA = "0x18583EF20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x583E740", Offset = "0x583D340", VA = "0x18583E740")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(OAINJCAAIFK<, >.KPHKBNFNPDP))]
	internal static Task FIMJBIBMEDO(Task<TResource> MHGNKNMAFFC, CancellationTokenSource ENGBOLJKMHF, Dictionary<Task<TResource>, CancellationTokenSource> AKIMEFPDNFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HKNANFCMAFF<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class EACHPJCKJJI : IEquatable<EACHPJCKJJI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly TValue AHLMJDKCEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int IMCBJEBDMKE;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x12F1070", Offset = "0x12EFC70", VA = "0x1812F1070")]
		public EACHPJCKJJI(TValue BKMPCFIAHIG, int GGOBGGOJGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x48C5380", Offset = "0x48C3F80", VA = "0x1848C5380", Slot = "4")]
		public bool Equals(EACHPJCKJJI? IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x48C5400", Offset = "0x48C4000", VA = "0x1848C5400", Slot = "0")]
		public override bool Equals(object? KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x48C5510", Offset = "0x48C4110", VA = "0x1848C5510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public struct BHNBDCEEIAG : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<TKey, EACHPJCKJJI>.Enumerator DGAFOBNBFJC;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x6437D50", Offset = "0x6436950", VA = "0x186437D50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x64380E0", Offset = "0x6436CE0", VA = "0x1864380E0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6437EA0", Offset = "0x6436AA0", VA = "0x186437EA0")]
		public BHNBDCEEIAG(HKNANFCMAFF<TKey, TValue> ELIABFCDDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6437910", Offset = "0x6436510", VA = "0x186437910", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6437950", Offset = "0x6436550", VA = "0x186437950", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6437B70", Offset = "0x6436770", VA = "0x186437B70", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class PJOEPACDPFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public HKNANFCMAFF<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public EACHPJCKJJI refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public PJOEPACDPFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x59D0F00", Offset = "0x59CFB00", VA = "0x1859D0F00")]
		internal void GKJAEFOFMLK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Dictionary<TKey, EACHPJCKJJI> LFFNBFPCKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Func<TKey, TValue>? DLKLNHIBIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Action<TValue>? MHDIJBJCFNH;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0C00", Offset = "0x4F9F800", VA = "0x184FA0C00")]
	public HKNANFCMAFF(int FIDAAGJHPMA = 0, [Optional] IEqualityComparer<TKey>? LFALBIKDJJH, [Optional] Func<TKey, TValue>? CFPJNCEAEDA, [Optional] Action<TValue>? IMENMOCNPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4F9FE60", Offset = "0x4F9EA60", VA = "0x184F9FE60")]
	public ODNHGKKANOM<TValue> BBMGDJPIKOB(TKey DHCHBFGMFFD, [Optional] Func<TKey, TValue>? IEJHJOHKAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0950", Offset = "0x4F9F550", VA = "0x184FA0950")]
	private void NCHKMOJJHLK(TKey DHCHBFGMFFD, EACHPJCKJJI KHLGPAMPGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA04E0", Offset = "0x4F9F0E0", VA = "0x184FA04E0")]
	public void GFLLHHKILFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4FA06C0", Offset = "0x4F9F2C0", VA = "0x184FA06C0")]
	public BHNBDCEEIAG MIEHOANGBJG()
	{
		return default(BHNBDCEEIAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0B70", Offset = "0x4F9F770", VA = "0x184FA0B70", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0B70", Offset = "0x4F9F770", VA = "0x184FA0B70", Slot = "5")]
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
