using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85278E0", Offset = "0x85262E0", VA = "0x1885278E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85275E0", Offset = "0x8525FE0", VA = "0x1885275E0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class LIFLHNMFMLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HEOFHBHOJNK CPMOFDFKMNJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8527530", Offset = "0x8525F30", VA = "0x188527530")]
	public LIFLHNMFMLP(IReadOnlyCollection<string> EJLGKHGBDBL, [In] GKMDLIOOPPF ANGOOFAAJMM, [Optional] HEOFHBHOJNK.ENCNNGPCKFM FLHPCJFBFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85272F0", Offset = "0x8525CF0", VA = "0x1885272F0")]
	public IReadOnlyList<OLOPGENIAMO> FAJLNAGLJCF(string ABOBMDKLEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8527150", Offset = "0x8525B50", VA = "0x188527150")]
	public void AEPDLCDGMBP(string ABOBMDKLEBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HEOFHBHOJNK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int ENCNNGPCKFM(IReadOnlyList<char> DMLEPIPKPBO, int CMEMFECGKAM, string BBAOLAIABFH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GKMDLIOOPPF HHCIPIPKDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ENCNNGPCKFM AMKHELDEOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] MOKPOMCGHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly OLOPGENIAMO[] ECLPEGKCLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] OEDNHJDMPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] HMDMFKHEFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly OLOPGENIAMO[] ILLGIHEOBJI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
	public static int PGBDGGDDCLA(IReadOnlyList<char> DMLEPIPKPBO, int CMEMFECGKAM, string BBAOLAIABFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8525470", Offset = "0x8523E70", VA = "0x188525470")]
	public HEOFHBHOJNK(IReadOnlyCollection<string> EJLGKHGBDBL, [In] GKMDLIOOPPF ANGOOFAAJMM, [Optional] ENCNNGPCKFM FLHPCJFBFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85253E0", Offset = "0x8523DE0", VA = "0x1885253E0")]
	public string NMPMIGCHNAL(string ABOBMDKLEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85253D0", Offset = "0x8523DD0", VA = "0x1885253D0")]
	public int FBKBAGABICE(int MABKCFLBCJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8524DD0", Offset = "0x85237D0", VA = "0x188524DD0")]
	public int AEPDLCDGMBP(string ABOBMDKLEBE, int BIIPOGPDIBC, int DNANMMDMMAP, int CMEMFECGKAM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct GKMDLIOOPPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool PGFBAHFHPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool AMPOACPNCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int OPHIIDGAOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int HJGMFHHJMMA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly GKMDLIOOPPF FAAKOMBEDNN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GKMDLIOOPPF IIDHIFPMCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8524D00", Offset = "0x8523700", VA = "0x188524D00")]
		get
		{
			return default(GKMDLIOOPPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8524DB0", Offset = "0x85237B0", VA = "0x188524DB0")]
	public GKMDLIOOPPF(bool LMEOJAEMMHF, bool EHCILLHKECM, int NNPGCDNKOFG, int GOAPDJGNOEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct OLOPGENIAMO : IEquatable<OLOPGENIAMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int CIDCBGPMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int AEPDLCDGMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int HGDHJFLGCIJ;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xED24F0", Offset = "0xED0EF0", VA = "0x180ED24F0")]
	public OLOPGENIAMO(int KABGMIEBEFC, int MAENDNFMHBC, int FDHENGJKBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8527960", Offset = "0x8526360", VA = "0x188527960")]
	public static int CFCJGKNKJDE([In] OLOPGENIAMO CFAKKPGMPGD, [In] OLOPGENIAMO KMGOFHJBCKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29DCF80", Offset = "0x29DB980", VA = "0x1829DCF80", Slot = "4")]
	public bool Equals(OLOPGENIAMO GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8527980", Offset = "0x8526380", VA = "0x188527980", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8527A30", Offset = "0x8526430", VA = "0x188527A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CIPFCGAPDKB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JNHDCEJMFGE(string ABOBMDKLEBE, [Out][NotNullWhen(true)] IReadOnlyList<JDPEPOIFICP>? DOFMOFNBENO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IMDKKAJMFFO : CIPFCGAPDKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int JCMKFOINDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<JDPEPOIFICP> results)> DMBGDIBKIKH;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8526590", Offset = "0x8524F90", VA = "0x188526590")]
	public IMDKKAJMFFO(int JCMKFOINDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8526410", Offset = "0x8524E10", VA = "0x188526410", Slot = "4")]
	public bool JNHDCEJMFGE(string ABOBMDKLEBE, [Out][NotNullWhen(true)] IReadOnlyList<JDPEPOIFICP>? DOFMOFNBENO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MFJMNJIBOMK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void LENCJCOHNOF(IReadOnlyList<JDPEPOIFICP> DOFMOFNBENO);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DLBAGNALJAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MFJMNJIBOMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DLBAGNALJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8523D40", Offset = "0x8522740", VA = "0x188523D40")]
		internal JDPEPOIFICP[] FEMANAJPHAH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HOPDIPFIHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MFJMNJIBOMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private DLBAGNALJAI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LENCJCOHNOF onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<JDPEPOIFICP[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8525F60", Offset = "0x8524960", VA = "0x188525F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FLGLDLNLBKC NHDHENDGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IDNLNGCLNOC GLJEDONIPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly AODFJIPLDAI.FIHEMFCDDIO? AAKABABIMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private JDPEPOIFICP[] PKKDDJOLAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? OHFCLCGHNMB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GDGPOPAPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x12B66E0", Offset = "0x12B50E0", VA = "0x1812B66E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8527830", Offset = "0x8526230", VA = "0x188527830")]
	public MFJMNJIBOMK(FLGLDLNLBKC NHDHENDGOCA, IDNLNGCLNOC GLJEDONIPGH, [Optional] AODFJIPLDAI.FIHEMFCDDIO? AAKABABIMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8527670", Offset = "0x8526070", VA = "0x188527670")]
	[AsyncStateMachine(typeof(HOPDIPFIHCO))]
	public void FAJLNAGLJCF(string ABOBMDKLEBE, LENCJCOHNOF KBFNOJHGILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8527760", Offset = "0x8526160", VA = "0x188527760")]
	public void LFPMCBHAIJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AODFJIPLDAI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int FIHEMFCDDIO(ReadOnlySpan<char> ABOBMDKLEBE, ReadOnlySpan<char> HADIONNOEHI, int POJBGOGMJOE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8522B50", Offset = "0x8521550", VA = "0x188522B50")]
	public static int NMAOCGMPMCJ([In] JDPEPOIFICP CFAKKPGMPGD, [In] JDPEPOIFICP KMGOFHJBCKL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JDPEPOIFICP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CIJDBEGHLNC : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public JDPEPOIFICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public JDPEPOIFICP <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1341D00", Offset = "0x1340700", VA = "0x181341D00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8522D90", Offset = "0x8521790", VA = "0x188522D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x15CE630", Offset = "0x15CD030", VA = "0x1815CE630")]
		[DebuggerHidden]
		public CIJDBEGHLNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8522BE0", Offset = "0x85215E0", VA = "0x188522BE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8522D40", Offset = "0x8521740", VA = "0x188522D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8522C80", Offset = "0x8521680", VA = "0x188522C80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8522C80", Offset = "0x8521680", VA = "0x188522C80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float AEPDLCDGMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int CIDCBGPMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> ENBGHFMNKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray HMFBKGBIIGI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> IBMHMLDIPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8526630", Offset = "0x8525030", VA = "0x188526630")]
		[IteratorStateMachine(typeof(CIJDBEGHLNC))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85266C0", Offset = "0x85250C0", VA = "0x1885266C0")]
	public JDPEPOIFICP(float MAENDNFMHBC, int KABGMIEBEFC, ReadOnlyMemory<char> JFBLIPHGGPK, IEnumerable<int> HMFBKGBIIGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GDPMDNGKIPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool PGFBAHFHPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool AMPOACPNCKD;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4AFCD00", Offset = "0x4AFB700", VA = "0x184AFCD00")]
	public GDPMDNGKIPA(bool EDOGJAHBDGA, bool EAMGOJMIMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8524C70", Offset = "0x8523670", VA = "0x188524C70")]
	public string DBFLIDEOLNL(string KKIOLBHBACC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IDNLNGCLNOC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float AEPDLCDGMBP(ReadOnlySpan<char> ABOBMDKLEBE, ReadOnlySpan<char> HADIONNOEHI, [Optional] List<int>? DNOMFECBIOA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PKDLKBNGHDB : IDNLNGCLNOC
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct IJBPHNKPDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float INIAMLMLNEN;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7390", Offset = "0x2DD5D90", VA = "0x182DD7390")]
		public IJBPHNKPDOL(float PBHFJLFGIPN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] DHPAFLMNDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] FIAFBNJIKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray BIAJJJLDJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IJBPHNKPDOL ANGOOFAAJMM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8528380", Offset = "0x8526D80", VA = "0x188528380")]
	public PKDLKBNGHDB([In] IJBPHNKPDOL ANGOOFAAJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8527AA0", Offset = "0x85264A0", VA = "0x188527AA0", Slot = "4")]
	public float AEPDLCDGMBP(ReadOnlySpan<char> ABOBMDKLEBE, ReadOnlySpan<char> HADIONNOEHI, [Optional] List<int>? DNOMFECBIOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8527E20", Offset = "0x8526820", VA = "0x188527E20")]
	private void AOFLBHCDFIB(int BCAJFCGHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8527EB0", Offset = "0x85268B0", VA = "0x188527EB0")]
	private float CBJNJEOHEFD(ReadOnlySpan<char> ABOBMDKLEBE, ReadOnlySpan<char> HADIONNOEHI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8528270", Offset = "0x8526C70", VA = "0x188528270")]
	private int CJKCLMAEIFJ(ReadOnlySpan<char> EBECFLDEGON, ReadOnlySpan<char> JFBLIPHGGPK, int HPGMPCJOFMG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EENIOALNLFA : IDNLNGCLNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int NNPGCDNKOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? LKIDIEPOGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] IBCIJKHBJHM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8524A90", Offset = "0x8523490", VA = "0x188524A90")]
	public EENIOALNLFA(int NNPGCDNKOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85243E0", Offset = "0x8522DE0", VA = "0x1885243E0", Slot = "4")]
	public float AEPDLCDGMBP(ReadOnlySpan<char> ABOBMDKLEBE, ReadOnlySpan<char> HADIONNOEHI, [Optional] List<int>? DNOMFECBIOA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FLGLDLNLBKC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> NPJGCFEENHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KDJIEKABCAD : FLGLDLNLBKC
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HPCBFBGOJAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GDPMDNGKIPA settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HPCBFBGOJAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8526380", Offset = "0x8524D80", VA = "0x188526380")]
		internal string DFKCOOJLNMK(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AEGNDLECDMH : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ReadOnlyMemory<char> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public KDJIEKABCAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<GOOPDMLHGAA<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ReadOnlyMemory<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8522A70", Offset = "0x8521470", VA = "0x188522A70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xBF9340", Offset = "0xBF7D40", VA = "0x180BF9340")]
		[DebuggerHidden]
		public AEGNDLECDMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8522AC0", Offset = "0x85214C0", VA = "0x188522AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85225A0", Offset = "0x8520FA0", VA = "0x1885225A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8522550", Offset = "0x8520F50", VA = "0x188522550")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8522A20", Offset = "0x8521420", VA = "0x188522A20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8522970", Offset = "0x8521370", VA = "0x188522970", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8522970", Offset = "0x8521370", VA = "0x188522970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] NGLAOBKPIOM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> NPJGCFEENHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8526920", Offset = "0x8525320", VA = "0x188526920", Slot = "4")]
		[IteratorStateMachine(typeof(AEGNDLECDMH))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85269A0", Offset = "0x85253A0", VA = "0x1885269A0")]
	public KDJIEKABCAD(IEnumerable<string> NHDHENDGOCA, GDPMDNGKIPA ANGOOFAAJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class DHDDDPAAMEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void NODBPNLOJLA(IReadOnlyList<OLOPGENIAMO> DOFMOFNBENO, IReadOnlyList<bool> IPHNGCGNLKL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CIPFCGAPDKB? DMBGDIBKIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MFJMNJIBOMK EBECFLDEGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GDPMDNGKIPA ADIJMMMGJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly GKMDLIOOPPF ANGOOFAAJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NODBPNLOJLA JOIALPBAPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly AODFJIPLDAI.FIHEMFCDDIO? AAKABABIMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<OLOPGENIAMO> ADNFKMOLDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> LEIIMDEAAEB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<OLOPGENIAMO> HLCHMGMEIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> BJEIGPEHECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool GDGPOPAPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8522FD0", Offset = "0x85219D0", VA = "0x188522FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85238F0", Offset = "0x85222F0", VA = "0x1885238F0")]
	public DHDDDPAAMEC(IReadOnlyList<string> EJLGKHGBDBL, [In] GKMDLIOOPPF ANGOOFAAJMM, NODBPNLOJLA KBFNOJHGILE, [Optional] AODFJIPLDAI.FIHEMFCDDIO? AAKABABIMLE, [Optional] IDNLNGCLNOC? IDBHBNDHNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8523550", Offset = "0x8521F50", VA = "0x188523550")]
	public void MEKGCLFOOIO(string ABOBMDKLEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8522FF0", Offset = "0x85219F0", VA = "0x188522FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8523030", Offset = "0x8521A30", VA = "0x188523030")]
	private void KNACBPFDCFP(IReadOnlyList<JDPEPOIFICP> DOFMOFNBENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8522DE0", Offset = "0x85217E0", VA = "0x188522DE0")]
	private int AFHMHMDODNP(ReadOnlySpan<char> PBOCDEMNFLD, ReadOnlySpan<char> JFBLIPHGGPK, int NBLHLFLBKCJ)
	{
		return default(int);
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
