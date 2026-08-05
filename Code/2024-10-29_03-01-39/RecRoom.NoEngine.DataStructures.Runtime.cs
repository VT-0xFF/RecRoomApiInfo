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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F88B40", Offset = "0x6F87B40", VA = "0x186F88B40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class KCCLBCBHBEM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	protected KCCLBCBHBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BOAIPPJEFFC<T> : KCCLBCBHBEM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct NADDCACCFEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum ICHOIOPABMN
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
		public ICHOIOPABMN PFCMGBLCCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T NDLMGANFCBJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int CNKPIGDEPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool GEIMPMMMNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool AEIIEGLPHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? ANAJDGJIEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<NADDCACCFEP>? DNFKJLIMLEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EFFPEGOKJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x53DCB80", Offset = "0x53DBB80", VA = "0x1853DCB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x53DD620", Offset = "0x53DC620", VA = "0x1853DD620")]
	protected BOAIPPJEFFC(bool AEIIEGLPHLN, bool GEIMPMMMNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x53DD360", Offset = "0x53DC360", VA = "0x1853DD360")]
	protected bool IPGEKDKPECF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x53DD230", Offset = "0x53DC230", VA = "0x1853DD230")]
	protected void GPDFPEMPGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x53DCF90", Offset = "0x53DBF90", VA = "0x1853DCF90")]
	protected void EHKBOPCLLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E75560", Offset = "0x2E74560", VA = "0x182E75560")]
	private static void PGBHIPMFOKI<U>(List<U>? AKKGGCHEPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x53DD400", Offset = "0x53DC400", VA = "0x1853DD400", Slot = "4")]
	public void OPFOFHIGBEE(T NDLMGANFCBJ, bool FHPGKCDFPCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x53DCBF0", Offset = "0x53DBBF0", VA = "0x1853DCBF0", Slot = "5")]
	public void CAKBCGBONLK(T NDLMGANFCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x53DCDD0", Offset = "0x53DBDD0", VA = "0x1853DCDD0")]
	public void EGPGCHCMHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GDBINPMHEFP : BOAIPPJEFFC<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F87070", Offset = "0x6F86070", VA = "0x186F87070")]
	public GDBINPMHEFP(bool AEIIEGLPHLN = false, bool GEIMPMMMNJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F86E10", Offset = "0x6F85E10", VA = "0x186F86E10")]
	public void IJNFOBHJKBL()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F86DB0", Offset = "0x6F85DB0", VA = "0x186F86DB0")]
	public static GDBINPMHEFP FHMEBNGHEBM(GDBINPMHEFP PCPOGLLOPDN, Action NDLMGANFCBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F87010", Offset = "0x6F86010", VA = "0x186F87010")]
	public static GDBINPMHEFP PIHMBHKMEME(GDBINPMHEFP PCPOGLLOPDN, Action NDLMGANFCBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PEEHIJFFKMH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPFOFHIGBEE(Action<T> NDLMGANFCBJ, bool FHPGKCDFPCK = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAKBCGBONLK(Action<T> NDLMGANFCBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JFMBBHOLPOC<T> : BOAIPPJEFFC<Action<T>>, PEEHIJFFKMH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4004D60", Offset = "0x4003D60", VA = "0x184004D60")]
	public JFMBBHOLPOC(bool AEIIEGLPHLN = false, bool GEIMPMMMNJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x457BA90", Offset = "0x457AA90", VA = "0x18457BA90")]
	public void IJNFOBHJKBL(T JJJGJKKAJDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x41A2DD0", Offset = "0x41A1DD0", VA = "0x1841A2DD0")]
	public static JFMBBHOLPOC<T> FHMEBNGHEBM(JFMBBHOLPOC<T> PCPOGLLOPDN, Action<T> NDLMGANFCBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x41A39D0", Offset = "0x41A29D0", VA = "0x1841A39D0")]
	public static JFMBBHOLPOC<T> PIHMBHKMEME(JFMBBHOLPOC<T> PCPOGLLOPDN, Action<T> NDLMGANFCBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CPGONALNCEK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class CCHMOPPHMKK<T, U> : BOAIPPJEFFC<Action<T, U>>, CPGONALNCEK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4004D60", Offset = "0x4003D60", VA = "0x184004D60")]
	public CCHMOPPHMKK(bool AEIIEGLPHLN = false, bool GEIMPMMMNJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x570BC80", Offset = "0x570AC80", VA = "0x18570BC80")]
	public void IJNFOBHJKBL(T JJJGJKKAJDC, U OABKFLJNDAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x41A2DD0", Offset = "0x41A1DD0", VA = "0x1841A2DD0")]
	public static CCHMOPPHMKK<T, U> FHMEBNGHEBM(CCHMOPPHMKK<T, U> PCPOGLLOPDN, Action<T, U> NDLMGANFCBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x41A39D0", Offset = "0x41A29D0", VA = "0x1841A39D0")]
	public static CCHMOPPHMKK<T, U> PIHMBHKMEME(CCHMOPPHMKK<T, U> PCPOGLLOPDN, Action<T, U> NDLMGANFCBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IEKKNHHCJLB<T, U, V> : BOAIPPJEFFC<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4004D60", Offset = "0x4003D60", VA = "0x184004D60")]
	public IEKKNHHCJLB(bool AEIIEGLPHLN = false, bool GEIMPMMMNJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42F3FC0", Offset = "0x42F2FC0", VA = "0x1842F3FC0")]
	public void IJNFOBHJKBL(T JJJGJKKAJDC, U OABKFLJNDAK, V DEGBNBIJGGI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x41A2DD0", Offset = "0x41A1DD0", VA = "0x1841A2DD0")]
	public static IEKKNHHCJLB<T, U, V> FHMEBNGHEBM(IEKKNHHCJLB<T, U, V> PCPOGLLOPDN, Action<T, U, V> NDLMGANFCBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x41A39D0", Offset = "0x41A29D0", VA = "0x1841A39D0")]
	public static IEKKNHHCJLB<T, U, V> PIHMBHKMEME(IEKKNHHCJLB<T, U, V> PCPOGLLOPDN, Action<T, U, V> NDLMGANFCBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MCOCJGFBBKP<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class BKHLDJHNHGJ<T, U, V, W> : BOAIPPJEFFC<Action<T, U, V, W>>, MCOCJGFBBKP<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4004D60", Offset = "0x4003D60", VA = "0x184004D60")]
	public BKHLDJHNHGJ(bool AEIIEGLPHLN = false, bool GEIMPMMMNJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x535D910", Offset = "0x535C910", VA = "0x18535D910")]
	public void IJNFOBHJKBL(T JJJGJKKAJDC, U OABKFLJNDAK, V DEGBNBIJGGI, W LMLEEJBFLHI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x41A2DD0", Offset = "0x41A1DD0", VA = "0x1841A2DD0")]
	public static BKHLDJHNHGJ<T, U, V, W> FHMEBNGHEBM(BKHLDJHNHGJ<T, U, V, W> PCPOGLLOPDN, Action<T, U, V, W> NDLMGANFCBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x41A39D0", Offset = "0x41A29D0", VA = "0x1841A39D0")]
	public static BKHLDJHNHGJ<T, U, V, W> PIHMBHKMEME(BKHLDJHNHGJ<T, U, V, W> PCPOGLLOPDN, Action<T, U, V, W> NDLMGANFCBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class OPMGGBMJCAB<T, U, V, W, X> : BOAIPPJEFFC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4004D60", Offset = "0x4003D60", VA = "0x184004D60")]
	public OPMGGBMJCAB(bool AEIIEGLPHLN = false, bool GEIMPMMMNJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4B406D0", Offset = "0x4B3F6D0", VA = "0x184B406D0")]
	public void IJNFOBHJKBL(T JJJGJKKAJDC, U OABKFLJNDAK, V DEGBNBIJGGI, W LMLEEJBFLHI, X GOCMFEAMGHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x41A2DD0", Offset = "0x41A1DD0", VA = "0x1841A2DD0")]
	public static OPMGGBMJCAB<T, U, V, W, X> FHMEBNGHEBM(OPMGGBMJCAB<T, U, V, W, X> PCPOGLLOPDN, Action<T, U, V, W, X> NDLMGANFCBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41A39D0", Offset = "0x41A29D0", VA = "0x1841A39D0")]
	public static OPMGGBMJCAB<T, U, V, W, X> PIHMBHKMEME(OPMGGBMJCAB<T, U, V, W, X> PCPOGLLOPDN, Action<T, U, V, W, X> NDLMGANFCBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class AIFFLOGJCHL<T, U, V, W, X, Y> : BOAIPPJEFFC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4004D60", Offset = "0x4003D60", VA = "0x184004D60")]
	public AIFFLOGJCHL(bool AEIIEGLPHLN = false, bool GEIMPMMMNJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41A3290", Offset = "0x41A2290", VA = "0x1841A3290")]
	public void IJNFOBHJKBL(T JJJGJKKAJDC, U OABKFLJNDAK, V DEGBNBIJGGI, W LMLEEJBFLHI, X GOCMFEAMGHO, Y AEFHGLLPABH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x41A2DD0", Offset = "0x41A1DD0", VA = "0x1841A2DD0")]
	public static AIFFLOGJCHL<T, U, V, W, X, Y> FHMEBNGHEBM(AIFFLOGJCHL<T, U, V, W, X, Y> PCPOGLLOPDN, Action<T, U, V, W, X, Y> NDLMGANFCBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41A39D0", Offset = "0x41A29D0", VA = "0x1841A39D0")]
	public static AIFFLOGJCHL<T, U, V, W, X, Y> PIHMBHKMEME(AIFFLOGJCHL<T, U, V, W, X, Y> PCPOGLLOPDN, Action<T, U, V, W, X, Y> NDLMGANFCBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GOGGILLHAHO<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BDGGAOKPMHJ<TKey, TVal> GNDEMJJALIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> PEEGGAJAFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BDGGAOKPMHJ<TKey, TVal>.CPIHDOFIKKA? AONMDCGGMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int GFPMNCKBHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BDGGAOKPMHJ<TKey, TVal>.ICGOCKDJMJJ? DMCAMPPFLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int KKFCJJEGGMO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int AIPJMEEOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4190AC0", Offset = "0x418FAC0", VA = "0x184190AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LMAJBADMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6660", Offset = "0x8B5660", VA = "0x1808B6660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4190B20", Offset = "0x418FB20", VA = "0x184190B20")]
	public GOGGILLHAHO(int GFPMNCKBHPJ, [Optional] BDGGAOKPMHJ<TKey, TVal>.ICGOCKDJMJJ? DMCAMPPFLNK, [Optional] IEqualityComparer<TKey>? DAICGGEDAFJ, [Optional] BDGGAOKPMHJ<TKey, TVal>.CPIHDOFIKKA? AONMDCGGMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x418FA80", Offset = "0x418EA80", VA = "0x18418FA80")]
	public void GEIJHFJBDKE(TKey MLAECOMLIEC, TVal BJDKOHEGDOK, bool CFKKAPFFHAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x418FE00", Offset = "0x418EE00", VA = "0x18418FE00")]
	public bool IBEOJMCAFFF(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4190250", Offset = "0x418F250", VA = "0x184190250")]
	public bool JIBJJFGCKGK(TKey PCNGBBMCPJN, [Out] TVal BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x418FF70", Offset = "0x418EF70", VA = "0x18418FF70")]
	private void IFNGGPCGDHN(TKey MLAECOMLIEC, TVal BJDKOHEGDOK, int MLDINGBBEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x41908F0", Offset = "0x418F8F0", VA = "0x1841908F0")]
	public bool LOBFPPEFJBO(TKey MLAECOMLIEC, TVal BJDKOHEGDOK, bool CFKKAPFFHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x418F9D0", Offset = "0x418E9D0", VA = "0x18418F9D0")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4190350", Offset = "0x418F350", VA = "0x184190350")]
	private void KLPLHENKNPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x418F750", Offset = "0x418E750", VA = "0x18418F750")]
	private bool CJKLPLNHAJK(TKey MLAECOMLIEC, BDHHBDPDFLJ BMAADIIMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x418FCD0", Offset = "0x418ECD0", VA = "0x18418FCD0")]
	private void GFGPIJBKBLO(TKey MLAECOMLIEC, TVal BJDKOHEGDOK, BDHHBDPDFLJ BMAADIIMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x418F8A0", Offset = "0x418E8A0", VA = "0x18418F8A0")]
	private void EGMKOBCPBJF(TKey MLAECOMLIEC, TVal ADMAMDKLPIC, BDHHBDPDFLJ BMAADIIMEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DJINNOCJBEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action NEPHIECEEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MJBLHBIFEPP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public DJINNOCJBEC(Action PKDGHKHNOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F861E0", Offset = "0x6F851E0", VA = "0x186F861E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6380", Offset = "0x2DB5380", VA = "0x182DB6380")]
	public static CLCEBAEDACG<T> AIOPMLNOOEO<T>(T BJDKOHEGDOK, Action PKDGHKHNOJH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CLCEBAEDACG<T> : DJINNOCJBEC where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x58FC650", Offset = "0x58FB650", VA = "0x1858FC650")]
	public CLCEBAEDACG(T BJDKOHEGDOK, Action PKDGHKHNOJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class FOBHKEDFMJJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly OENKHFOIMAB<T>? CCEMGLNICNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> NPBNDCKBHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool MJBLHBIFEPP;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly FOBHKEDFMJJ<T> BOAMOHHEBKK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> LBIPCMLLCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x401B860", Offset = "0x401A860", VA = "0x18401B860")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AAOLGFOFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x401B3A0", Offset = "0x401A3A0", VA = "0x18401B3A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DCLLIFLPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x401B2E0", Offset = "0x401A2E0", VA = "0x18401B2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x401C250", Offset = "0x401B250", VA = "0x18401C250")]
	public FOBHKEDFMJJ(OENKHFOIMAB<T> JOPHFPIEAAA, OENKHFOIMAB<T> PKCCAGHLDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x401BE80", Offset = "0x401AE80", VA = "0x18401BE80")]
	public FOBHKEDFMJJ(OENKHFOIMAB<T> JOPHFPIEAAA, int KECPKLHBJEB, OENKHFOIMAB<T> PKCCAGHLDDB, int GDFGKEPOHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x401C350", Offset = "0x401B350", VA = "0x18401C350")]
	private FOBHKEDFMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x401B520", Offset = "0x401A520", VA = "0x18401B520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x401B7A0", Offset = "0x401A7A0", VA = "0x18401B7A0")]
	public T[] LKGOBMDPHFJ()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x401B5B0", Offset = "0x401A5B0", VA = "0x18401B5B0")]
	public static ReadOnlySequence<T> ILBKFABDDDI(FOBHKEDFMJJ<T>? EGGPEJFCICF)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct PEIKIFBHNLD : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GCCEDIJGOOM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
		public static GCCEDIJGOOM EJLELCHFLID()
		{
			return default(GCCEDIJGOOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F88BC0", Offset = "0x6F87BC0", VA = "0x186F88BC0")]
	public static string PIMHJLGMHLL(Type PFCMGBLCCPJ, [Optional] string? BHAFLFJADJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3153440", Offset = "0x3152440", VA = "0x183153440")]
	public static string? PIMHJLGMHLL<T>([Optional] string? BHAFLFJADJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31533C0", Offset = "0x31523C0", VA = "0x1831533C0")]
	public static string? DIGMDEHHCDP<T>([Optional] string? KHNDEFJGLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	public static PEIKIFBHNLD DPIOBCKIDMC(string BHAFLFJADJH, string? KHNDEFJGLLO)
	{
		return default(PEIKIFBHNLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GBEIEIMAINC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool PJANEMCKGDA(string LCAJBBHCCOI, GBEIEIMAINC KLINGOLLLPC);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BPNMJCFPOBM<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BPNMJCFPOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x53EBD50", Offset = "0x53EAD50", VA = "0x1853EBD50")]
		internal void HMCOKOBLKBK(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int FIAIOBCELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string HDEIEFGDKGO;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F86A80", Offset = "0x6F85A80", VA = "0x186F86A80")]
	public static Dictionary<string, GBEIEIMAINC> PHOAIJPHFOI(Type NFICGGNDBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B280", Offset = "0x2F7A280", VA = "0x182F7B280")]
	public static Dictionary<string, GBEIEIMAINC> PHOAIJPHFOI<T>(Type NFICGGNDBHN, IReadOnlyDictionary<T, string> NDGJPLDAAKN) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F7AB00", Offset = "0x2F79B00", VA = "0x182F7AB00")]
	public static Dictionary<string, GBEIEIMAINC> FOENBNAOBOF<T>(List<T> JOPALLODOMO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F86510", Offset = "0x6F85510", VA = "0x186F86510")]
	public static Dictionary<string, GBEIEIMAINC> CMLMFPBBMCG(Type NFICGGNDBHN, PJANEMCKGDA EKIPMKOODFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F868C0", Offset = "0x6F858C0", VA = "0x186F868C0")]
	public static Dictionary<int, string> GCFOBDLLBFF(Dictionary<string, GBEIEIMAINC> LNLOCMMGLOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PPOILIOPEKP : HJOFKELFHOB
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool IAKECDIDEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? KFIIOAANJBB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual HJOFKELFHOB? OAOEHALMHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F892A0", Offset = "0x6F882A0", VA = "0x186F892A0")]
	protected PPOILIOPEKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string DOJAIBMDODD();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F89220", Offset = "0x6F88220", VA = "0x186F89220", Slot = "8")]
	public virtual string NEOMOBDPBNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F88F80", Offset = "0x6F87F80", VA = "0x186F88F80", Slot = "9")]
	public void IEFKCBCNFHD(StringBuilder BKHDHJLAMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F88D20", Offset = "0x6F87D20", VA = "0x186F88D20", Slot = "10")]
	public void CGFLANJGOMJ(StringBuilder BKHDHJLAMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F88C00", Offset = "0x6F87C00", VA = "0x186F88C00", Slot = "11")]
	public void BPLHNICEDPB(StringBuilder BKHDHJLAMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F88E20", Offset = "0x6F87E20", VA = "0x186F88E20", Slot = "12")]
	public void GOPAHMPLLFC(StringBuilder BKHDHJLAMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F88D80", Offset = "0x6F87D80", VA = "0x186F88D80")]
	public static void DCGHBFNNIMD(StringBuilder BKHDHJLAMCH, string BNGCOHPPGBN, string OFBLOKPLKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x612B130", Offset = "0x612A130", VA = "0x18612B130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CBEJLNMIAJA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F85F60", Offset = "0x6F84F60", VA = "0x186F85F60")]
	public CBEJLNMIAJA(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PMKBMFGPBNN<TErr> : CBEJLNMIAJA where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr CABICNIKEHC;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4BE9F40", Offset = "0x4BE8F40", VA = "0x184BE9F40")]
	private PMKBMFGPBNN([In] TErr FDIDPGNJBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4BE9E60", Offset = "0x4BE8E60", VA = "0x184BE9E60")]
	public static PMKBMFGPBNN<TErr> EJLELCHFLID([In] TErr FDIDPGNJBLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KNOPFOCPENN : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm LPLHFDEOJLP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool IMBMFBHOKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool AKLDEFDHDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool IIHKKOGBMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long AAOLGFOFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F88030", Offset = "0x6F87030", VA = "0x186F88030", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long BFENJPJIDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F880A0", Offset = "0x6F870A0", VA = "0x186F880A0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F88110", Offset = "0x6F87110", VA = "0x186F88110", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F87FC0", Offset = "0x6F86FC0", VA = "0x186F87FC0")]
	public KNOPFOCPENN(HashAlgorithm LPLHFDEOJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F87DF0", Offset = "0x6F86DF0", VA = "0x186F87DF0", Slot = "35")]
	public override int Read(byte[] CNIEHBMANDE, int OFDADLBABBI, int DCEOMHJEBBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F87F90", Offset = "0x6F86F90", VA = "0x186F87F90", Slot = "38")]
	public override void Write(byte[] CNIEHBMANDE, int OFDADLBABBI, int DCEOMHJEBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F87E90", Offset = "0x6F86E90", VA = "0x186F87E90", Slot = "33")]
	public override long Seek(long OFDADLBABBI, SeekOrigin KGHGAEAECEO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F87F20", Offset = "0x6F86F20", VA = "0x186F87F20", Slot = "34")]
	public override void SetLength(long BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F87D20", Offset = "0x6F86D20", VA = "0x186F87D20")]
	public byte[] INCBCCNBIKG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HJOFKELFHOB
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NEOMOBDPBNO();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DOJAIBMDODD();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NDCJIIFFPED<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PGIPKNDBIGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string NCIOFHOGDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OENKHFOIMAB<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static OENKHFOIMAB<T>? JGAMOHBCKOC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object HADAPDJHPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? DHMGCPJMHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool MJBLHBIFEPP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MKCCGLFKGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA24150", Offset = "0xA23150", VA = "0x180A24150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E4E0", Offset = "0x4B0D4E0", VA = "0x184B0E4E0")]
	private static OENKHFOIMAB<T> PBFIJPDBFLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4B0D600", Offset = "0x4B0C600", VA = "0x184B0D600")]
	private static void BGFFNJIHGHI(OENKHFOIMAB<T> MMNBDONBOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x42E46C0", Offset = "0x42E36C0", VA = "0x1842E46C0")]
	private OENKHFOIMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4B0D240", Offset = "0x4B0C240", VA = "0x184B0D240")]
	public static OENKHFOIMAB<T> AIOPMLNOOEO(ReadOnlyMemory<T> JGGCIMKCNGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4B0D020", Offset = "0x4B0C020", VA = "0x184B0D020")]
	public static OENKHFOIMAB<T> AIOPMLNOOEO(IMemoryOwner<T> LHBLFMKBNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DD60", Offset = "0x4B0CD60", VA = "0x184B0DD60")]
	public static void DMBMDIEEFMK(OENKHFOIMAB<T> JOPHFPIEAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DEA0", Offset = "0x4B0CEA0", VA = "0x184B0DEA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E3C0", Offset = "0x4B0D3C0", VA = "0x184B0E3C0")]
	public OENKHFOIMAB<T> HAOGEBCKFIP(IMemoryOwner<T> LHBLFMKBNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E9C0", Offset = "0x4B0D9C0", VA = "0x184B0E9C0")]
	private void PJLAFPDNJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DC00", Offset = "0x4B0CC00", VA = "0x184B0DC00")]
	private OENKHFOIMAB<T> BIHOJGCABDF(OENKHFOIMAB<T> MMNBDONBOFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EAMANCBGMBM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F862D0", Offset = "0x6F852D0", VA = "0x186F862D0")]
	public EAMANCBGMBM(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class IBAKFEGFDEO<TOk> : EAMANCBGMBM where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk DFDAGMADNDM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x42E51E0", Offset = "0x42E41E0", VA = "0x1842E51E0")]
	private IBAKFEGFDEO([In] TOk KJOFEIEDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x419CFA0", Offset = "0x419BFA0", VA = "0x18419CFA0")]
	public static IBAKFEGFDEO<TOk> EJLELCHFLID([In] TOk KJOFEIEDONA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct OBFFLKDLIBJ<TOk, TErr> : IEquatable<OBFFLKDLIBJ<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> MBDIPFIAKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr CABICNIKEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk DFDAGMADNDM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EBNMFKMMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE3E0", Offset = "0x4ADD3E0", VA = "0x184ADE3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MBPOBJEIMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4ADDC80", Offset = "0x4ADCC80", VA = "0x184ADDC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4AE3CA0", Offset = "0x4AE2CA0", VA = "0x184AE3CA0")]
	internal OBFFLKDLIBJ([In] TErr FDIDPGNJBLK, [In] TOk KJOFEIEDONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0650", Offset = "0x4ADF650", VA = "0x184AE0650")]
	public static OBFFLKDLIBJ<TOk, TErr> MOHCKPFCMDO([In] TErr FDIDPGNJBLK)
	{
		return default(OBFFLKDLIBJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4ADBE60", Offset = "0x4ADAE60", VA = "0x184ADBE60")]
	public static OBFFLKDLIBJ<TOk, TErr> GCJCNHNBDBB([In] TOk KJOFEIEDONA)
	{
		return default(OBFFLKDLIBJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3503BB0", Offset = "0x3502BB0", VA = "0x183503BB0")]
	public OBFFLKDLIBJ<TOk?, UErr?> PGGFDCIBFFD<UErr>()
	{
		return default(OBFFLKDLIBJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3503850", Offset = "0x3502850", VA = "0x183503850")]
	public OBFFLKDLIBJ<UOk?, TErr?> ODAOHHAJOFA<UOk>()
	{
		return default(OBFFLKDLIBJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3502900", Offset = "0x3501900", VA = "0x183502900")]
	public OBFFLKDLIBJ<UOk?, TErr?> BLHHLKEECLK<UOk>()
	{
		return default(OBFFLKDLIBJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3503190", Offset = "0x3502190", VA = "0x183503190")]
	public OBFFLKDLIBJ<TOk?, UErr?> BOKNILKLEMP<UErr>()
	{
		return default(OBFFLKDLIBJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4ADC620", Offset = "0x4ADB620", VA = "0x184ADC620")]
	public OBFFLKDLIBJ<MKHCENILMPB, TErr> GGIFIKCHDLM()
	{
		return default(OBFFLKDLIBJ<MKHCENILMPB, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4ADED20", Offset = "0x4ADDD20", VA = "0x184ADED20")]
	public static bool LJMKDDBNEAO([In] OBFFLKDLIBJ<TOk, TErr> GGEOEEJGPGH, [In] OBFFLKDLIBJ<TOk, TErr> OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4ADAE10", Offset = "0x4AD9E10", VA = "0x184ADAE10", Slot = "4")]
	public bool Equals(OBFFLKDLIBJ<TOk, TErr> DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4ADB090", Offset = "0x4ADA090", VA = "0x184ADB090", Slot = "0")]
	public override bool Equals(object DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4ADD510", Offset = "0x4ADC510", VA = "0x184ADD510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0E70", Offset = "0x4ADFE70", VA = "0x184AE0E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LIHJLMHGAPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct BNJOBJBDOBI<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<OBFFLKDLIBJ<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<OBFFLKDLIBJ<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x53DC6F0", Offset = "0x53DB6F0", VA = "0x1853DC6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x53DCA30", Offset = "0x53DBA30", VA = "0x1853DCA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x304C850", Offset = "0x304B850", VA = "0x18304C850")]
	public static OBFFLKDLIBJ<TOk?, TErr?> DFDAGMADNDM<TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [In] TOk KJOFEIEDONA)
	{
		return default(OBFFLKDLIBJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x304CB10", Offset = "0x304BB10", VA = "0x18304CB10")]
	public static OBFFLKDLIBJ<MKHCENILMPB, TErr?> DFDAGMADNDM<TErr>([In] this OBFFLKDLIBJ<MKHCENILMPB, TErr> GFJPFDOHONG)
	{
		return default(OBFFLKDLIBJ<MKHCENILMPB, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x304C850", Offset = "0x304B850", VA = "0x18304C850")]
	public static OBFFLKDLIBJ<TOk?, TErr?> CABICNIKEHC<TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [In] TErr FDIDPGNJBLK)
	{
		return default(OBFFLKDLIBJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x304E120", Offset = "0x304D120", VA = "0x18304E120")]
	public static TOk? KFEDPPEJMOA<TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x304C580", Offset = "0x304B580", VA = "0x18304C580")]
	[AsyncStateMachine(typeof(BNJOBJBDOBI<, >))]
	public static Task<TOk?>? BDDPDHLDHAA<TOk, TErr>(this Task<OBFFLKDLIBJ<TOk, TErr>> GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x304D050", Offset = "0x304C050", VA = "0x18304D050")]
	public static TErr? HJJEEJEMBEO<TErr, TOk>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x304E620", Offset = "0x304D620", VA = "0x18304E620")]
	public static bool MLLPKKMKDCG<TOk, TErr, UErr, UOk>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [Out] OBFFLKDLIBJ<UOk, UErr> CAPAGLFHFJM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x304CA20", Offset = "0x304BA20", VA = "0x18304CA20")]
	public static bool CKIDMDNIAAE<TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [Out][NotNullWhen(true)] TOk KJOFEIEDONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x304C440", Offset = "0x304B440", VA = "0x18304C440")]
	public static bool BCAOIDGAKDM<TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [Out][NotNullWhen(true)] TErr FDIDPGNJBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x304D4B0", Offset = "0x304C4B0", VA = "0x18304D4B0")]
	public static bool HPFEIJNLAFM<TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [Out][NotNullWhen(true)] TOk KJOFEIEDONA, [Out][NotNullWhen(false)] TErr FDIDPGNJBLK) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x304C340", Offset = "0x304B340", VA = "0x18304C340")]
	public static bool BBEJDDMFCCO<TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [Out][NotNullWhen(true)] TOk KJOFEIEDONA, [Out] OBFFLKDLIBJ<TOk, TErr> CAPAGLFHFJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x304E750", Offset = "0x304D750", VA = "0x18304E750")]
	public static bool MLLPKKMKDCG<TOk, TErr, UErr, UOk>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [Out][NotNullWhen(true)] TOk KJOFEIEDONA, [Out] OBFFLKDLIBJ<UOk, UErr> CAPAGLFHFJM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x304D610", Offset = "0x304C610", VA = "0x18304D610")]
	public static bool IIJIIAKLMOG<TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [Out][NotNullWhen(true)] TOk KJOFEIEDONA, [Out] OBFFLKDLIBJ<MKHCENILMPB, TErr> CAPAGLFHFJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x304DAE0", Offset = "0x304CAE0", VA = "0x18304DAE0")]
	public static OBFFLKDLIBJ<UOk, UErr> IKLHKAFEPCK<UOk, UErr, TOk, TErr>([In] this OBFFLKDLIBJ<TOk, TErr> GFJPFDOHONG, [In] OBFFLKDLIBJ<UOk, UErr> BEELICCCBAC) where TOk : UOk where TErr : UErr
	{
		return default(OBFFLKDLIBJ<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x304CBB0", Offset = "0x304BBB0", VA = "0x18304CBB0")]
	public static OBFFLKDLIBJ<TOk?[]?, TErr?> EMCOCCAHHEO<TOk, TErr>(this IEnumerable<OBFFLKDLIBJ<TOk, TErr>> GFJPFDOHONG)
	{
		return default(OBFFLKDLIBJ<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MOEGMJKABNI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x33C4A50", Offset = "0x33C3A50", VA = "0x1833C4A50")]
	public static OBFFLKDLIBJ<TOk, T> DFDAGMADNDM<TOk>([In] TOk KJOFEIEDONA) where TOk : notnull
	{
		return default(OBFFLKDLIBJ<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x496EE30", Offset = "0x496DE30", VA = "0x18496EE30")]
	public static OBFFLKDLIBJ<MKHCENILMPB, T> DFDAGMADNDM()
	{
		return default(OBFFLKDLIBJ<MKHCENILMPB, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x33C4AF0", Offset = "0x33C3AF0", VA = "0x1833C4AF0")]
	public static OBFFLKDLIBJ<T, TErr> CABICNIKEHC<TErr>([In] TErr FDIDPGNJBLK) where TErr : notnull
	{
		return default(OBFFLKDLIBJ<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct LAFPFLFPOLB<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IPBJACHFDFE ABHLALGFHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> FBBEFPJLMMN;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4689570", Offset = "0x4688570", VA = "0x184689570")]
	public static LAFPFLFPOLB<TKey, TValue> EJLELCHFLID(string NDMMIOJEOEB)
	{
		return default(LAFPFLFPOLB<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4689750", Offset = "0x4688750", VA = "0x184689750")]
	internal LAFPFLFPOLB(Dictionary<TKey, TValue> BJDKOHEGDOK, IPBJACHFDFE LNPOGGPMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46896A0", Offset = "0x46886A0", VA = "0x1846896A0")]
	public AHKLDIEPEGK<TKey, TValue> GNMIFPNKCDD([Out] Dictionary<TKey, TValue> BJDKOHEGDOK)
	{
		return default(AHKLDIEPEGK<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct AHKLDIEPEGK<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> FBBEFPJLMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly DHMFGNLJKOB FKIGLNMCKIG;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x24A83D0", Offset = "0x24A73D0", VA = "0x1824A83D0")]
	internal AHKLDIEPEGK(Dictionary<TKey, TValue> BJDKOHEGDOK, DHMFGNLJKOB AFGFGJDJLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x41A1410", Offset = "0x41A0410", VA = "0x1841A1410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct NMOMDHOAPPO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly IPBJACHFDFE ABHLALGFHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> FBBEFPJLMMN;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4689570", Offset = "0x4688570", VA = "0x184689570")]
	public static NMOMDHOAPPO<T> EJLELCHFLID(string NDMMIOJEOEB)
	{
		return default(NMOMDHOAPPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4689750", Offset = "0x4688750", VA = "0x184689750")]
	internal NMOMDHOAPPO(HashSet<T> BJDKOHEGDOK, IPBJACHFDFE LNPOGGPMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46896A0", Offset = "0x46886A0", VA = "0x1846896A0")]
	public MDJAIGCMJAK<T> GNMIFPNKCDD([Out] HashSet<T> BJDKOHEGDOK)
	{
		return default(MDJAIGCMJAK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct MDJAIGCMJAK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> FBBEFPJLMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DHMFGNLJKOB FKIGLNMCKIG;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x24A83D0", Offset = "0x24A73D0", VA = "0x1824A83D0")]
	internal MDJAIGCMJAK(HashSet<T> BJDKOHEGDOK, DHMFGNLJKOB AFGFGJDJLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x41A1410", Offset = "0x41A0410", VA = "0x1841A1410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KIPIMCKPNBK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IPBJACHFDFE ABHLALGFHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> FBBEFPJLMMN;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4689570", Offset = "0x4688570", VA = "0x184689570")]
	public static KIPIMCKPNBK<T> EJLELCHFLID(string NDMMIOJEOEB)
	{
		return default(KIPIMCKPNBK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4689750", Offset = "0x4688750", VA = "0x184689750")]
	internal KIPIMCKPNBK(Stack<T> BJDKOHEGDOK, IPBJACHFDFE LNPOGGPMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x46896A0", Offset = "0x46886A0", VA = "0x1846896A0")]
	public ALOGFFPAOJI<T> GNMIFPNKCDD([Out] Stack<T> BJDKOHEGDOK)
	{
		return default(ALOGFFPAOJI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct ALOGFFPAOJI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> FBBEFPJLMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DHMFGNLJKOB FKIGLNMCKIG;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x24A83D0", Offset = "0x24A73D0", VA = "0x1824A83D0")]
	internal ALOGFFPAOJI(Stack<T> BJDKOHEGDOK, DHMFGNLJKOB AFGFGJDJLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x41A1410", Offset = "0x41A0410", VA = "0x1841A1410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class GMPHPPCOFJN<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct HHOFJMAOGIJ : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly GMPHPPCOFJN<T> PEADGGKOPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int KDHKCOGHCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool HFDMBBHNEPH;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x21E8B00", Offset = "0x21E7B00", VA = "0x1821E8B00")]
		public HHOFJMAOGIJ(GMPHPPCOFJN<T> PHOINLFJEFI, int CCDKJMGFNMG, bool OMGFAPHMIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x41FABB0", Offset = "0x41F9BB0", VA = "0x1841FABB0")]
		public GMPHPPCOFJN<T>.PLDNHCGJLNM EMFBOAAPBLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x41FACB0", Offset = "0x41F9CB0", VA = "0x1841FACB0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x41FACB0", Offset = "0x41F9CB0", VA = "0x1841FACB0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class PLDNHCGJLNM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly GMPHPPCOFJN<T> PEADGGKOPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int OIBBNCAIEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int BFJJCNMHBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool HFDMBBHNEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool OKNENEJPIHH;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x4BE8A70", Offset = "0x4BE7A70", VA = "0x184BE8A70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x4BE8BA0", Offset = "0x4BE7BA0", VA = "0x184BE8BA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x4BE8DB0", Offset = "0x4BE7DB0", VA = "0x184BE8DB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4BE8EE0", Offset = "0x4BE7EE0", VA = "0x184BE8EE0")]
		public PLDNHCGJLNM(GMPHPPCOFJN<T> PHOINLFJEFI, int CCDKJMGFNMG, bool OMGFAPHMIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4BE8990", Offset = "0x4BE7990", VA = "0x184BE8990", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4BE8B30", Offset = "0x4BE7B30", VA = "0x184BE8B30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NAMEGDNNJJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NAMEGDNNJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x49BCA40", Offset = "0x49BBA40", VA = "0x1849BCA40")]
		internal T LHMCPEBOPFA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] ADENMCCNFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int BFJJCNMHBJH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int GANMBKDAMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x418E4E0", Offset = "0x418D4E0", VA = "0x18418E4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T OEJFPPMIFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3FE4730", Offset = "0x3FE3730", VA = "0x183FE4730")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T CENFMIKPMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x418E540", Offset = "0x418D540", VA = "0x18418E540")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x418E730", Offset = "0x418D730", VA = "0x18418E730")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int AAOLGFOFBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1EF07C0", Offset = "0x1EEF7C0", VA = "0x181EF07C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1574CB0", Offset = "0x1573CB0", VA = "0x181574CB0")]
	private static int CCNODBCCDDN(int KHAIDMGPIED, int CDEEBECPNGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x418EB20", Offset = "0x418DB20", VA = "0x18418EB20")]
	public GMPHPPCOFJN(int MLDINGBBEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x418E8B0", Offset = "0x418D8B0", VA = "0x18418E8B0")]
	public GMPHPPCOFJN(int MLDINGBBEHA, Func<T> FGECDJCMNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x418EC50", Offset = "0x418DC50", VA = "0x18418EC50")]
	public GMPHPPCOFJN(T[] LCHNOCELOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x418E4B0", Offset = "0x418D4B0", VA = "0x18418E4B0")]
	public void HEKFDMECNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x418E580", Offset = "0x418D580", VA = "0x18418E580")]
	public IEnumerable<T> KFPNHLLJPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x418E410", Offset = "0x418D410", VA = "0x18418E410")]
	public GMPHPPCOFJN<T>.PLDNHCGJLNM EMFBOAAPBLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A370", Offset = "0x3C79370", VA = "0x183C7A370", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A370", Offset = "0x3C79370", VA = "0x183C7A370", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GKPAALENLFC
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F87420", Offset = "0x2F86420", VA = "0x182F87420")]
	public static GMPHPPCOFJN<T> EJLELCHFLID<T>(int MLDINGBBEHA, Func<T> FGECDJCMNNA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class KFKKHKEKBAC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct PFLGKNGJJBA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly KFKKHKEKBAC<T> KBINABCHDLN;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T DMNEEJMINJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x4BE11A0", Offset = "0x4BE01A0", VA = "0x184BE11A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4BE1170", Offset = "0x4BE0170", VA = "0x184BE1170", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
		public PFLGKNGJJBA(KFKKHKEKBAC<T> KBINABCHDLN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CBGOBIIFILA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<PFLGKNGJJBA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public KFKKHKEKBAC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5706E80", Offset = "0x5705E80", VA = "0x185706E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x400BF30", Offset = "0x400AF30", VA = "0x18400BF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim EMKLLNHJLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T PJCBCPDOGAA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4678E50", Offset = "0x4677E50", VA = "0x184678E50")]
	public KFKKHKEKBAC([In] T PJCBCPDOGAA, int JINEJADLEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4678CD0", Offset = "0x4677CD0", VA = "0x184678CD0")]
	public KFKKHKEKBAC([In] T PJCBCPDOGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4678770", Offset = "0x4677770", VA = "0x184678770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4678C90", Offset = "0x4677C90", VA = "0x184678C90")]
	public PFLGKNGJJBA OHEPEJJNMNC()
	{
		return default(PFLGKNGJJBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4678B40", Offset = "0x4677B40", VA = "0x184678B40")]
	[AsyncStateMachine(typeof(KFKKHKEKBAC<>.CBGOBIIFILA))]
	public Task<KFKKHKEKBAC<T>.PFLGKNGJJBA> HFEAAAJMJAC(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4678C70", Offset = "0x4677C70", VA = "0x184678C70")]
	public void JOGPNBKHDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AGGBFKAABFI
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F85C20", Offset = "0x6F84C20", VA = "0x186F85C20")]
	public static KFKKHKEKBAC<MKHCENILMPB> EJLELCHFLID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B850", Offset = "0x2D6A850", VA = "0x182D6B850")]
	public static KFKKHKEKBAC<T> EJLELCHFLID<T>([In] T PJCBCPDOGAA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class IIEOMDBNJIL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct KLLFGLHEEBH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly IIEOMDBNJIL<T> BOOCJHFCAJP;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T DMNEEJMINJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x469EAA0", Offset = "0x469DAA0", VA = "0x18469EAA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x469E860", Offset = "0x469D860", VA = "0x18469E860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
		internal KLLFGLHEEBH(IIEOMDBNJIL<T> KBINABCHDLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct MMLCHHFDAAO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly IIEOMDBNJIL<T> BOOCJHFCAJP;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T DMNEEJMINJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x469EAA0", Offset = "0x469DAA0", VA = "0x18469EAA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x49663D0", Offset = "0x49653D0", VA = "0x1849663D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
		internal MMLCHHFDAAO(IIEOMDBNJIL<T> KBINABCHDLN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct JDJJOOHILAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<MMLCHHFDAAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IIEOMDBNJIL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private KFKKHKEKBAC<MKHCENILMPB>.PFLGKNGJJBA <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<KFKKHKEKBAC<MKHCENILMPB>.PFLGKNGJJBA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x45736B0", Offset = "0x45726B0", VA = "0x1845736B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x400BF30", Offset = "0x400AF30", VA = "0x18400BF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly KFKKHKEKBAC<int> EIBBDGGJOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KFKKHKEKBAC<MKHCENILMPB> LAIDJNGOLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KFKKHKEKBAC<MKHCENILMPB> DIHANBGLDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T LKIDDBLKJHD;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x435D890", Offset = "0x435C890", VA = "0x18435D890")]
	internal IIEOMDBNJIL(KFKKHKEKBAC<int> HIEFBKHDDMM, KFKKHKEKBAC<MKHCENILMPB> NANDMDLCPNH, KFKKHKEKBAC<MKHCENILMPB> JFOOKCJHGCH, [In] T PJCBCPDOGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x435CB70", Offset = "0x435BB70", VA = "0x18435CB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x435CF40", Offset = "0x435BF40", VA = "0x18435CF40")]
	public KLLFGLHEEBH MLANHIECOMM()
	{
		return default(KLLFGLHEEBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x435CD60", Offset = "0x435BD60", VA = "0x18435CD60")]
	public MMLCHHFDAAO LILBNEHPPBF()
	{
		return default(MMLCHHFDAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x435D480", Offset = "0x435C480", VA = "0x18435D480")]
	[AsyncStateMachine(typeof(IIEOMDBNJIL<>.JDJJOOHILAG))]
	public Task<IIEOMDBNJIL<T>.MMLCHHFDAAO> OPECCCKOLIF(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CJEFNOJDBME
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F860F0", Offset = "0x6F850F0", VA = "0x186F860F0")]
	public static IIEOMDBNJIL<MKHCENILMPB> EJLELCHFLID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2D69960", Offset = "0x2D68960", VA = "0x182D69960")]
	public static IIEOMDBNJIL<T> EJLELCHFLID<T>([In] T PJCBCPDOGAA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class DAGAPCOEPEC<TData> : PPOILIOPEKP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string OHIKBLEAMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData CKGGEHCOAJK;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
	public override string DOJAIBMDODD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D3C230", Offset = "0x5D3B230", VA = "0x185D3C230")]
	internal DAGAPCOEPEC(string ABHPFCOODAJ, [In] TData CONAFKKIHKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KKOJKOKAIMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F87CA0", Offset = "0x6F86CA0", VA = "0x186F87CA0")]
	public static DAGAPCOEPEC<MKHCENILMPB> EJLELCHFLID(string ABHPFCOODAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6380", Offset = "0x2DB5380", VA = "0x182DB6380")]
	public static DAGAPCOEPEC<TData> EJLELCHFLID<TData>(string ABHPFCOODAJ, [In] TData CONAFKKIHKL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class IPBJACHFDFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool OJNKJGMCABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string OBJDJAMLMLK;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA6CE20", Offset = "0xA6BE20", VA = "0x180A6CE20")]
	private IPBJACHFDFE(bool CCFNDGPLPIH, string BJHFCLLECAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F87B70", Offset = "0x6F86B70", VA = "0x186F87B70")]
	public static IPBJACHFDFE EJLELCHFLID(string BJHFCLLECAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F87BE0", Offset = "0x6F86BE0", VA = "0x186F87BE0")]
	public DHMFGNLJKOB GNMIFPNKCDD()
	{
		return default(DHMFGNLJKOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct DHMFGNLJKOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IPBJACHFDFE EHNNMOFGALK;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	internal DHMFGNLJKOB(IPBJACHFDFE NDMMIOJEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F861C0", Offset = "0x6F851C0", VA = "0x186F861C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class CHPMHHPOFGE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class IHNCHLFDICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IHNCHLFDICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x435C9B0", Offset = "0x435B9B0", VA = "0x18435C9B0")]
		internal int GMOKCJJHFKC(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? JFBPNFDJADM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> CEBGCFAHJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x58F9400", Offset = "0x58F8400", VA = "0x1858F9400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MBEJACJCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x58F9230", Offset = "0x58F8230", VA = "0x1858F9230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C12F0", Offset = "0x8C02F0", VA = "0x1808C12F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x58F9490", Offset = "0x58F8490", VA = "0x1858F9490")]
	public bool OPFOFHIGBEE(T NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x58F9280", Offset = "0x58F8280", VA = "0x1858F9280")]
	public bool CAKBCGBONLK(T NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x58F9440", Offset = "0x58F8440", VA = "0x1858F9440")]
	public bool KOLCIDGNCMK(T NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x58F9670", Offset = "0x58F8670", VA = "0x1858F9670")]
	public void PJAICCADFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x58F9760", Offset = "0x58F8760", VA = "0x1858F9760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public CHPMHHPOFGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class MPAMFIMFCFF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class DNGJJJEMELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public DNGJJJEMELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6F86220", Offset = "0x6F85220", VA = "0x186F86220")]
		internal int GMOKCJJHFKC(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? JFBPNFDJADM;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> CEBGCFAHJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6F88460", Offset = "0x6F87460", VA = "0x186F88460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool MBEJACJCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6F883B0", Offset = "0x6F873B0", VA = "0x186F883B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8C12F0", Offset = "0x8C02F0", VA = "0x1808C12F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6F88550", Offset = "0x6F87550", VA = "0x186F88550")]
	public bool OPFOFHIGBEE(object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F883C0", Offset = "0x6F873C0", VA = "0x186F883C0")]
	public bool CAKBCGBONLK(object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6F884F0", Offset = "0x6F874F0", VA = "0x186F884F0")]
	public bool KOLCIDGNCMK(object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6F88630", Offset = "0x6F87630", VA = "0x186F88630")]
	public void PJAICCADFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6F886A0", Offset = "0x6F876A0", VA = "0x186F886A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public MPAMFIMFCFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class IKJPHCKCAAO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct NGPLMPODDOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float HHJLPJHDMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T DMNEEJMINJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, NGPLMPODDOF> LMPEOFNFEPH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T AHCBCADLACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x147F3E0", Offset = "0x147E3E0", VA = "0x18147F3E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x147E9D0", Offset = "0x147D9D0", VA = "0x18147E9D0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? LMGHFFGMDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool LHGADJIMJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4378FE0", Offset = "0x4377FE0", VA = "0x184378FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4376E50", Offset = "0x4375E50", VA = "0x184376E50")]
	public bool ALENMIAKIAD(T BJDKOHEGDOK, object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4378B20", Offset = "0x4377B20", VA = "0x184378B20")]
	public bool HKHPJBJFLMH(object NANMDIJGGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4377200", Offset = "0x4376200", VA = "0x184377200")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4378C60", Offset = "0x4377C60", VA = "0x184378C60")]
	public bool JIBJJFGCKGK(object NANMDIJGGLP, [Out] T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4378730", Offset = "0x4377730", VA = "0x184378730")]
	[AMAEILDHAGM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FDEGGJDCAHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4379040", Offset = "0x4378040", VA = "0x184379040")]
	public IKJPHCKCAAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class FMCPMEFHBJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly string DKHKDCAHGAM;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public FMCPMEFHBJK(string DKHKDCAHGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F864C0", Offset = "0x6F854C0", VA = "0x186F864C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class JOLPOJKDDFO<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private List<WeakReference<T>>? JFBPNFDJADM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MBEJACJCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x45BBE80", Offset = "0x45BAE80", VA = "0x1845BBE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x45BC160", Offset = "0x45BB160", VA = "0x1845BC160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x45BC310", Offset = "0x45BB310", VA = "0x1845BC310")]
	public void OPFOFHIGBEE(T NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x45BBFB0", Offset = "0x45BAFB0", VA = "0x1845BBFB0")]
	public void CAKBCGBONLK(T NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x45BC5A0", Offset = "0x45BB5A0", VA = "0x1845BC5A0")]
	public void PJAICCADFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x45BC5F0", Offset = "0x45BB5F0", VA = "0x1845BC5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public JOLPOJKDDFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class KMMIFGAMOKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x303EA90", Offset = "0x303DA90", VA = "0x18303EA90")]
	public static void AJPODPOKFGA<T>(this List<T> AKKGGCHEPCI, int KHAIDMGPIED) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class NKHJLBAECFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<object, float> LMPEOFNFEPH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float CPHPEAMKFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xB2DDE0", Offset = "0xB2CDE0", VA = "0x180B2DDE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xB2DEC0", Offset = "0xB2CEC0", VA = "0x180B2DEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6F88850", Offset = "0x6F87850", VA = "0x186F88850")]
	public void ALENMIAKIAD(float BJDKOHEGDOK, object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F88910", Offset = "0x6F87910", VA = "0x186F88910")]
	public void HKHPJBJFLMH(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6F888C0", Offset = "0x6F878C0", VA = "0x186F888C0")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F88980", Offset = "0x6F87980", VA = "0x186F88980")]
	private void NAKPMMBBOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F88AB0", Offset = "0x6F87AB0", VA = "0x186F88AB0")]
	public NKHJLBAECFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface ODIJIHPCMIA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DAGADGHJCCE CNHNFGNJFKN;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GFBJONOOLIG : ODIJIHPCMIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct BNAKLLKEFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float DMGNCFFGIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly float ENFIFPOLOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal readonly bool MNCIMEONHOG;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float IIJOJMFBBBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x6F85C90", Offset = "0x6F84C90", VA = "0x186F85C90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6F85E00", Offset = "0x6F84E00", VA = "0x186F85E00")]
		public BNAKLLKEFON(float NOAHCMMOGGC, float IPCMHIELOCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6F85CA0", Offset = "0x6F84CA0", VA = "0x186F85CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class INCJKIDMMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public GFBJONOOLIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public INCJKIDMMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6F87AD0", Offset = "0x6F86AD0", VA = "0x186F87AD0")]
		internal void HLDFPCGFKAG(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int BHNNGJABFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int NFJIFAFKCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly ODIJIHPCMIA[] OKGDEPBGOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DAGADGHJCCE[] LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly BNAKLLKEFON[] KHOJAJJAPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BNAKLLKEFON JKOMLKJDIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LNGPHIHDADF KBCLBLLPHLK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event DAGADGHJCCE CNHNFGNJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6F870D0", Offset = "0x6F860D0", VA = "0x186F870D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6F872A0", Offset = "0x6F862A0", VA = "0x186F872A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6F87860", Offset = "0x6F86860", VA = "0x186F87860")]
	public GFBJONOOLIG(int BHNNGJABFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6F877D0", Offset = "0x6F867D0", VA = "0x186F877D0")]
	public LNGPHIHDADF PEFCJIEDEPH(BNAKLLKEFON FMPNIOHIOBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6F87360", Offset = "0x6F86360", VA = "0x186F87360")]
	public void LFODENHIBPE(ODIJIHPCMIA OBAKOEACEBA, [Optional] BNAKLLKEFON OJBLLIALOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6F87190", Offset = "0x6F86190", VA = "0x186F87190", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void DAGADGHJCCE(float FIDENFMFGLC);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class CFGDIPANHMN
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class HNFEEGNNBCE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly ODIJIHPCMIA NIEANGOMMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly DAGADGHJCCE BLNJHEMNIGB;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6F87A40", Offset = "0x6F86A40", VA = "0x186F87A40")]
		public HNFEEGNNBCE(ODIJIHPCMIA NIEANGOMMHB, DAGADGHJCCE BLNJHEMNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6F879F0", Offset = "0x6F869F0", VA = "0x186F879F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6F85FC0", Offset = "0x6F84FC0", VA = "0x186F85FC0")]
	internal static bool KCOEEGALGKK(float LGLGFADDDNK, float GMGEKOBCPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6F76FF0", Offset = "0x6F75FF0", VA = "0x186F76FF0")]
	internal static float GPFBHEBPJMJ(float LGLGFADDDNK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6F86030", Offset = "0x6F85030", VA = "0x186F86030")]
	public static IDisposable OBDLAEDIBOG(this ODIJIHPCMIA NIEANGOMMHB, DAGADGHJCCE BLNJHEMNIGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class LNGPHIHDADF : ODIJIHPCMIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private float FIDENFMFGLC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float GNCNKOCLBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6F882C0", Offset = "0x6F872C0", VA = "0x186F882C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event DAGADGHJCCE? CNHNFGNJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6F88180", Offset = "0x6F87180", VA = "0x186F88180", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6F88220", Offset = "0x6F87220", VA = "0x186F88220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public LNGPHIHDADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface LEKCJNPIPDA<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GHGEFGFEEOG<T> EDGCLAMDNDK([Out] T BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGPGCHCMHIK();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LMLEAKCKCEG<T> : LEKCJNPIPDA<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ConcurrentStack<T> HMNOMKACHJP;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4760770", Offset = "0x475F770", VA = "0x184760770", Slot = "4")]
	public GHGEFGFEEOG<T> EDGCLAMDNDK([Out] T BJDKOHEGDOK)
	{
		return default(GHGEFGFEEOG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x47606F0", Offset = "0x475F6F0", VA = "0x1847606F0")]
	public void DIPKALJLHOB(T GJEEBDPDFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3C44DC0", Offset = "0x3C43DC0", VA = "0x183C44DC0", Slot = "5")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "6")]
	protected virtual void EHKKEJCCOID(T OPLOPGFOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4760810", Offset = "0x475F810", VA = "0x184760810")]
	private T KIJHOBDIGPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x47608C0", Offset = "0x475F8C0", VA = "0x1847608C0")]
	public LMLEAKCKCEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct GHGEFGFEEOG<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly T GJEEBDPDFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly LMLEAKCKCEG<T> KFPDBBNOEPD;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	internal GHGEFGFEEOG(T BJDKOHEGDOK, LMLEAKCKCEG<T> KFPDBBNOEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x416BF00", Offset = "0x416AF00", VA = "0x18416BF00", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class FAAHGCEPIAH : LMLEAKCKCEG<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly FAAHGCEPIAH LONLOOPDCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6F86350", Offset = "0x6F85350", VA = "0x186F86350")]
	public static GHGEFGFEEOG<StringBuilder> KIJHOBDIGPJ([Out] StringBuilder BJDKOHEGDOK)
	{
		return default(GHGEFGFEEOG<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6F86330", Offset = "0x6F85330", VA = "0x186F86330", Slot = "6")]
	protected override void EHKKEJCCOID(StringBuilder OPLOPGFOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6F86480", Offset = "0x6F85480", VA = "0x186F86480")]
	public FAAHGCEPIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class DFFNHMIICAD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x69D51E0", Offset = "0x69D41E0", VA = "0x1869D51E0")]
	public DFFNHMIICAD(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class ALABJACLCOL<TKey, TValue> : OGEKNLPLJFD<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, LGKIBLOEKNO where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class CGKCCPGBALL : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public ALABJACLCOL<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x147F3E0", Offset = "0x147E3E0", VA = "0x18147F3E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x58117F0", Offset = "0x58107F0", VA = "0x1858117F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public CGKCCPGBALL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3F4F160", Offset = "0x3F4E160", VA = "0x183F4F160", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5811310", Offset = "0x5810310", VA = "0x185811310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5810B40", Offset = "0x580FB40", VA = "0x185810B40")]
		private void CLDKBJALKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5810A50", Offset = "0x580FA50", VA = "0x185810A50")]
		private void AFDHGAJFOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x5811700", Offset = "0x5810700", VA = "0x185811700", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly OGEKNLPLJFD<TKey, TValue> EBMEEBGJDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IDictionary<TKey, TValue> JLNPKJAGGBD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x41ADAA0", Offset = "0x41ACAA0", VA = "0x1841ADAA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AGBMIOANOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x41ADBB0", Offset = "0x41ACBB0", VA = "0x1841ADBB0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x41ADE60", Offset = "0x41ACE60", VA = "0x1841ADE60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> KKDDLFINFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x41ADC00", Offset = "0x41ACC00", VA = "0x1841ADC00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> EHCBJAEHPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x41ADD30", Offset = "0x41ACD30", VA = "0x1841ADD30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x41AD830", Offset = "0x41AC830", VA = "0x1841AD830")]
	public ALABJACLCOL(OGEKNLPLJFD<TKey, TValue> EBMEEBGJDPG, [Optional] IDictionary<TKey, TValue>? JLNPKJAGGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x41AAF10", Offset = "0x41A9F10", VA = "0x1841AAF10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x41AC370", Offset = "0x41AB370", VA = "0x1841AC370")]
	public void IBPFLPAAAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x41AAA50", Offset = "0x41A9A50", VA = "0x1841AAA50", Slot = "9")]
	public void Add(TKey MLAECOMLIEC, TValue BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x41ABBC0", Offset = "0x41AABC0", VA = "0x1841ABBC0")]
	public void DHMBDHPJMGK(TKey MLAECOMLIEC, TValue BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x41ABF30", Offset = "0x41AAF30", VA = "0x1841ABF30")]
	public void FADLJJKBGHI(TKey MLAECOMLIEC, TValue BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x41AC640", Offset = "0x41AB640", VA = "0x1841AC640")]
	public void KDHBPLBLEJN(TKey MLAECOMLIEC, TValue BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x41AC9B0", Offset = "0x41AB9B0", VA = "0x1841AC9B0")]
	public void LOOHICPHGND(TKey MLAECOMLIEC, TValue BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x41ACE00", Offset = "0x41ABE00", VA = "0x1841ACE00", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x41ACEA0", Offset = "0x41ABEA0", VA = "0x1841ACEA0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x41AD3A0", Offset = "0x41AC3A0", VA = "0x1841AD3A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x41AB050", Offset = "0x41AA050", VA = "0x1841AB050", Slot = "8")]
	public bool ContainsKey(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x41AC880", Offset = "0x41AB880", VA = "0x1841AC880")]
	public bool LJGJENAABKJ(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x41AC140", Offset = "0x41AB140", VA = "0x1841AC140")]
	public bool FALAEHDLDPM(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x41ACBA0", Offset = "0x41ABBA0", VA = "0x1841ACBA0", Slot = "10")]
	public bool Remove(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x41AD680", Offset = "0x41AC680", VA = "0x1841AD680", Slot = "11")]
	public bool TryGetValue(TKey MLAECOMLIEC, [Out] TValue BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x41AB5C0", Offset = "0x41AA5C0", VA = "0x1841AB5C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CHPMBGHOEJI, int MJFNOLHAPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x41AD560", Offset = "0x41AC560", VA = "0x1841AD560", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x41AC2C0", Offset = "0x41AB2C0", VA = "0x1841AC2C0", Slot = "19")]
	[IteratorStateMachine(typeof(ALABJACLCOL<, >.CGKCCPGBALL))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x41ABDC0", Offset = "0x41AADC0", VA = "0x1841ABDC0", Slot = "21")]
	public bool DJHJHNCHGHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x41AB9E0", Offset = "0x41AA9E0", VA = "0x1841AB9E0")]
	private TValue DCJLPNOEDPE(TKey MLAECOMLIEC)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface LGKIBLOEKNO
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJHJHNCHGHL();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface OGEKNLPLJFD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LGKIBLOEKNO
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public sealed class BDGGAOKPMHJ<TKey, TVal> : OGEKNLPLJFD<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LGKIBLOEKNO where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate int ICGOCKDJMJJ(TKey MLAECOMLIEC, TVal BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void CPIHDOFIKKA(TKey MLAECOMLIEC, TVal BJDKOHEGDOK, BDHHBDPDFLJ BMAADIIMEEA);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class LLNJAJDLOMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB885E0", Offset = "0xB875E0", VA = "0x180B885E0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal DMNEEJMINJG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB48CD0", Offset = "0xB47CD0", VA = "0x180B48CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int IIJOJMFBBBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8F5FB0", Offset = "0x8F4FB0", VA = "0x1808F5FB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x8F55A0", Offset = "0x8F45A0", VA = "0x1808F55A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset HPOLLJIBKAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x10168D0", Offset = "0x10158D0", VA = "0x1810168D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1A995E0", Offset = "0x1A985E0", VA = "0x181A995E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x475E3E0", Offset = "0x475D3E0", VA = "0x18475E3E0")]
		public LLNJAJDLOMP(TKey MLAECOMLIEC, TVal ADMAMDKLPIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class CHAMNGBCDCF : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public BDGGAOKPMHJ<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LinkedList<LLNJAJDLOMP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x147F3E0", Offset = "0x147E3E0", VA = "0x18147F3E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x5812270", Offset = "0x5811270", VA = "0x185812270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public CHAMNGBCDCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3DF29B0", Offset = "0x3DF19B0", VA = "0x183DF29B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5811EF0", Offset = "0x5810EF0", VA = "0x185811EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5811ED0", Offset = "0x5810ED0", VA = "0x185811ED0")]
		private void CLDKBJALKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5812220", Offset = "0x5811220", VA = "0x185812220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int FJGLDIMHHME = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<TKey, LinkedListNode<LLNJAJDLOMP>> IKADLGOGHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LinkedList<LLNJAJDLOMP> OFIPJJMFNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ICGOCKDJMJJ? DMCAMPPFLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly TimeSpan CJHKGENACIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly CPIHDOFIKKA? AONMDCGGMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly AFMLPIBKEFM OGNAAJEGJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool INBNDBOLBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<TKey> PAGKBKBBKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<TVal> IEHEHLLMPMN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int LMAJBADMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EE0", Offset = "0x8C3EE0", VA = "0x1808C4EE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int AIPJMEEOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x991640", Offset = "0x990640", VA = "0x180991640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xABDBD0", Offset = "0xABCBD0", VA = "0x180ABDBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5321030", Offset = "0x5320030", VA = "0x185321030", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int EHNGGNGBKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4377200", Offset = "0x4376200", VA = "0x184377200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> EHCBJAEHPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x53211A0", Offset = "0x53201A0", VA = "0x1853211A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.OIFFKFLFBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x531B600", Offset = "0x531A600", VA = "0x18531B600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool AGBMIOANOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal JKBIAPJPPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x53210D0", Offset = "0x53200D0", VA = "0x1853210D0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5321290", Offset = "0x5320290", VA = "0x185321290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5319DE0", Offset = "0x5318DE0", VA = "0x185319DE0")]
	private bool PONMCLOHFDP(int BHNNGJABFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x530B720", Offset = "0x530A720", VA = "0x18530B720")]
	private void CLEEOKADHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x531DC30", Offset = "0x531CC30", VA = "0x18531DC30")]
	public BDGGAOKPMHJ(int BHNNGJABFPL, [Optional] ICGOCKDJMJJ? DMCAMPPFLNK, [Optional] IEqualityComparer<TKey>? DAICGGEDAFJ, [Optional] CPIHDOFIKKA? AONMDCGGMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x531C9D0", Offset = "0x531B9D0", VA = "0x18531C9D0")]
	public BDGGAOKPMHJ(TimeSpan CJHKGENACIJ, [Optional] IEqualityComparer<TKey>? DAICGGEDAFJ, [Optional] CPIHDOFIKKA? AONMDCGGMBF, [Optional] AFMLPIBKEFM? OGNAAJEGJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x531C950", Offset = "0x531B950", VA = "0x18531C950")]
	public BDGGAOKPMHJ(int BHNNGJABFPL, TimeSpan CJHKGENACIJ, [Optional] IEqualityComparer<TKey>? DAICGGEDAFJ, [Optional] CPIHDOFIKKA? AONMDCGGMBF, [Optional] AFMLPIBKEFM? OGNAAJEGJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x531FD50", Offset = "0x531ED50", VA = "0x18531FD50")]
	public BDGGAOKPMHJ(int BHNNGJABFPL, ICGOCKDJMJJ? DMCAMPPFLNK, TimeSpan CJHKGENACIJ, [Optional] IEqualityComparer<TKey>? DAICGGEDAFJ, [Optional] CPIHDOFIKKA? AONMDCGGMBF, [Optional] AFMLPIBKEFM? OGNAAJEGJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x530F510", Offset = "0x530E510", VA = "0x18530F510", Slot = "21")]
	public bool DJHJHNCHGHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x530EC20", Offset = "0x530DC20", VA = "0x18530EC20", Slot = "22")]
	public bool DEPNNBKCBLB(int MLDINGBBEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5312AC0", Offset = "0x5311AC0", VA = "0x185312AC0")]
	private bool FEECIGBGMOE(int MLDINGBBEHA, BDHHBDPDFLJ BMAADIIMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5317E30", Offset = "0x5316E30", VA = "0x185317E30")]
	public void NONCGFKLPGD(TKey MLAECOMLIEC, TVal BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5305D10", Offset = "0x5304D10", VA = "0x185305D10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KBDJJFPFPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5306690", Offset = "0x5305690", VA = "0x185306690", Slot = "9")]
	public void Add(TKey MLAECOMLIEC, TVal BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x530BF40", Offset = "0x530AF40", VA = "0x18530BF40", Slot = "8")]
	public bool ContainsKey(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x531A880", Offset = "0x5319880", VA = "0x18531A880", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5319E30", Offset = "0x5318E30", VA = "0x185319E30", Slot = "10")]
	public bool Remove(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x531B270", Offset = "0x531A270", VA = "0x18531B270", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> KBDJJFPFPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x53170E0", Offset = "0x53160E0", VA = "0x1853170E0")]
	private bool LMLCIHOFKPN(TKey MLAECOMLIEC, [Out] TVal BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x53163E0", Offset = "0x53153E0", VA = "0x1853163E0")]
	private TVal KIJHOBDIGPJ(TKey PCNGBBMCPJN)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x531C110", Offset = "0x531B110", VA = "0x18531C110", Slot = "11")]
	public bool TryGetValue(TKey PCNGBBMCPJN, [Out] TVal BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x530BC20", Offset = "0x530AC20", VA = "0x18530BC20", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x530DB60", Offset = "0x530CB60", VA = "0x18530DB60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CHPMBGHOEJI, int MJFNOLHAPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x530FD60", Offset = "0x530ED60", VA = "0x18530FD60")]
	private void EGMKOBCPBJF(TKey MLAECOMLIEC, TVal ADMAMDKLPIC, BDHHBDPDFLJ BMAADIIMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5318CB0", Offset = "0x5317CB0", VA = "0x185318CB0")]
	private bool PMHHAEPNJNI(LLNJAJDLOMP NKLPNIJHEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x530ABA0", Offset = "0x5309BA0", VA = "0x18530ABA0")]
	private void CAGDJIFHIOB(LinkedListNode<LLNJAJDLOMP> MLJMMKLOIJA, TVal GKLNJFJLDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x53050B0", Offset = "0x53040B0", VA = "0x1853050B0")]
	private void ALENMIAKIAD(TKey MLAECOMLIEC, TVal BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5301E10", Offset = "0x5300E10", VA = "0x185301E10")]
	private void AACMBAGBMBA(LLNJAJDLOMP NKLPNIJHEFM, TVal GKLNJFJLDOL, int PCNLEGBOOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5315710", Offset = "0x5314710", VA = "0x185315710", Slot = "19")]
	[IteratorStateMachine(typeof(BDGGAOKPMHJ<, >.CHAMNGBCDCF))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x531B650", Offset = "0x531A650", VA = "0x18531B650", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum BDHHBDPDFLJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class DFHHGPKLDNP<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly TKey AGFJLGEHEMK;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D770C0", Offset = "0x5D760C0", VA = "0x185D770C0")]
	public DFHHGPKLDNP(TKey IGIPKACENDJ, Exception AHKLKPABMPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class LBJDMNEPBBL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x629C7D0", Offset = "0x629B7D0", VA = "0x18629C7D0")]
	public LBJDMNEPBBL(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class OAOFDKPFEAD<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GPCEBLFCJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public OAOFDKPFEAD<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GPCEBLFCJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4192760", Offset = "0x4191760", VA = "0x184192760")]
		internal Task<TResource> JBGAANDPPNC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct OEKCHDEIBCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public OAOFDKPFEAD<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4B0C2A0", Offset = "0x4B0B2A0", VA = "0x184B0C2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4B0CF00", Offset = "0x4B0BF00", VA = "0x184B0CF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct DFJMDPDDNPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D77530", Offset = "0x5D76530", VA = "0x185D77530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D78350", Offset = "0x5D77350", VA = "0x185D78350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly MDKDIAFAMGD<TId, Task<TResource>> KMHBHONAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> EALAGKIPDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? OCFEDNHMHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Action<TResource>? PJBEOLEJFDD;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA5E0", Offset = "0x4AD95E0", VA = "0x184ADA5E0")]
	public OAOFDKPFEAD(int GBJJLLONKID = 0, [Optional] IEqualityComparer<TId>? BJPDNPDADOD, [Optional] Func<TId, CancellationToken, Task<TResource>>? JOPLMFNMCMP, [Optional] Action<TResource>? GIDNHNCKLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4AD9C20", Offset = "0x4AD8C20", VA = "0x184AD9C20")]
	public CLCEBAEDACG<Task<TResource>> MAECCCILHJN(TId JHCIODFGPNM, [Optional] Func<TId, CancellationToken, Task<TResource>>? JOPLMFNMCMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4AD90D0", Offset = "0x4AD80D0", VA = "0x184AD90D0")]
	private void BDNOPBPGHDF(Task<TResource> KDFIPCHFLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA2F0", Offset = "0x4AD92F0", VA = "0x184ADA2F0")]
	[AsyncStateMachine(typeof(OAOFDKPFEAD<, >.OEKCHDEIBCG))]
	private Task MMEKLEBGKFJ(Task<TResource> KDFIPCHFLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8CE0", Offset = "0x4AD7CE0", VA = "0x184AD8CE0")]
	public void ANOEIGBIOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4AD9300", Offset = "0x4AD8300", VA = "0x184AD9300")]
	public MDKDIAFAMGD<TId, Task<TResource>>.EDAKBDODCNK EMFBOAAPBLH()
	{
		return default(MDKDIAFAMGD<TId, Task<TResource>>.EDAKBDODCNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA4A0", Offset = "0x4AD94A0", VA = "0x184ADA4A0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA4A0", Offset = "0x4AD94A0", VA = "0x184ADA4A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4AD94B0", Offset = "0x4AD84B0", VA = "0x184AD94B0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(OAOFDKPFEAD<, >.DFJMDPDDNPH))]
	internal static Task IBNDGHMMDBH(Task<TResource> KDFIPCHFLGF, CancellationTokenSource IENCGJBNNFI, Dictionary<Task<TResource>, CancellationTokenSource> PFKDAJGDKBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MDKDIAFAMGD<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class ICKEOPCJOMB : IEquatable<ICKEOPCJOMB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TValue DMNEEJMINJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int POMKFBDLPLH;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xD29490", Offset = "0xD28490", VA = "0x180D29490")]
		public ICKEOPCJOMB(TValue BJDKOHEGDOK, int EBPLJIHGPMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x42EC8D0", Offset = "0x42EB8D0", VA = "0x1842EC8D0", Slot = "4")]
		public bool Equals(ICKEOPCJOMB? DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x42EC820", Offset = "0x42EB820", VA = "0x1842EC820", Slot = "0")]
		public override bool Equals(object? IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x42EC9F0", Offset = "0x42EB9F0", VA = "0x1842EC9F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct EDAKBDODCNK : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<TKey, ICKEOPCJOMB>.Enumerator FMOPLLFADNF;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x3C47E30", Offset = "0x3C46E30", VA = "0x183C47E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x3C483D0", Offset = "0x3C473D0", VA = "0x183C483D0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C48020", Offset = "0x3C47020", VA = "0x183C48020")]
		public EDAKBDODCNK(MDKDIAFAMGD<TKey, TValue> LMPEOFNFEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C47A70", Offset = "0x3C46A70", VA = "0x183C47A70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C47AB0", Offset = "0x3C46AB0", VA = "0x183C47AB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3C47B70", Offset = "0x3C46B70", VA = "0x183C47B70", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class POOLFPHILHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public MDKDIAFAMGD<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public ICKEOPCJOMB refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public POOLFPHILHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4BEA8D0", Offset = "0x4BE98D0", VA = "0x184BEA8D0")]
		internal void JBGAANDPPNC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Dictionary<TKey, ICKEOPCJOMB> ABANJFJBMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly Func<TKey, TValue>? FJLLEMJIIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Action<TValue>? MLPOADBBFDP;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4937810", Offset = "0x4936810", VA = "0x184937810")]
	public MDKDIAFAMGD(int GBJJLLONKID = 0, [Optional] IEqualityComparer<TKey>? DAICGGEDAFJ, [Optional] Func<TKey, TValue>? IHACGHOOOKI, [Optional] Action<TValue>? ABFMAOBIFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4936C70", Offset = "0x4935C70", VA = "0x184936C70")]
	public CLCEBAEDACG<TValue> MAECCCILHJN(TKey MLAECOMLIEC, [Optional] Func<TKey, TValue>? DCELBGGDHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x49364D0", Offset = "0x49354D0", VA = "0x1849364D0")]
	private void DIPKALJLHOB(TKey MLAECOMLIEC, ICKEOPCJOMB CCBMJGIODHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4935E10", Offset = "0x4934E10", VA = "0x184935E10")]
	public void ANOEIGBIOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x49368E0", Offset = "0x49358E0", VA = "0x1849368E0")]
	public EDAKBDODCNK EMFBOAAPBLH()
	{
		return default(EDAKBDODCNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x49376C0", Offset = "0x49366C0", VA = "0x1849376C0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x49376C0", Offset = "0x49366C0", VA = "0x1849376C0", Slot = "5")]
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
