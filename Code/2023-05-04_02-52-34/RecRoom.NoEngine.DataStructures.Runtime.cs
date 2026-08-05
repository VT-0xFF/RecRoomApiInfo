using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69F54B0", Offset = "0x69F48B0", VA = "0x1869F54B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class INGPBNPGBIJ<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::JNOHGJIOCHP<TKey, TVal> NDMKNLAHLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF800", Offset = "0x6CEC00")]
	internal readonly Dictionary<TKey, (TVal value, int size)> NCKIOEMHOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int NEFEENDABEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF8D0", Offset = "0x6CECD0")]
	private readonly global::JNOHGJIOCHP<TKey, TVal>.PJDNAGIKDDC IGIPODFNIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int OFFCGKNHCDM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal int LHEFHMFBKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2500C20", Offset = "0x2500020", VA = "0x182500C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x735750", Offset = "0x734B50", VA = "0x180735750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2500C60", Offset = "0x2500060", VA = "0x182500C60")]
	public INGPBNPGBIJ(int NEFEENDABEP, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF930", Offset = "0x6CED30")] global::JNOHGJIOCHP<TKey, TVal>.PJDNAGIKDDC IGIPODFNIHC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF990", Offset = "0x6CED90")] IEqualityComparer<TKey> KODMKCMCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25005F0", Offset = "0x24FF9F0", VA = "0x1825005F0")]
	public void BCGJFDCGEBL(TKey OGFDNCPKECB, TVal LPJDDLMPNCG, bool JOMPHGOEHAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2500760", Offset = "0x24FFB60", VA = "0x182500760")]
	public bool BGKDECKBCKM(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x25007E0", Offset = "0x24FFBE0", VA = "0x1825007E0")]
	public bool DJKANKJNGBD(TKey OBALLIKLNDH, out TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2500A60", Offset = "0x24FFE60", VA = "0x182500A60")]
	private void KMEJBEPGHMF(TKey OGFDNCPKECB, TVal LPJDDLMPNCG, int GBNBGNMHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2500890", Offset = "0x24FFC90", VA = "0x182500890")]
	public bool ECBGNPHGBKB(TKey OGFDNCPKECB, TVal LPJDDLMPNCG, bool JOMPHGOEHAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x25009C0", Offset = "0x24FFDC0", VA = "0x1825009C0")]
	private bool GFBFBDGIMCE(TKey OGFDNCPKECB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class JNOHGJIOCHP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate int PJDNAGIKDDC(TKey OGFDNCPKECB, TVal LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class HMKCNFFEDMN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TKey MKIHFPLFIBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA3E9F0", Offset = "0xA3DDF0", VA = "0x180A3E9F0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TVal NDNOLKCBONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7A04D0", Offset = "0x79F8D0", VA = "0x1807A04D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int MDFKAKBJDBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x736B90", Offset = "0x735F90", VA = "0x180736B90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB5AD10", Offset = "0xB5A110", VA = "0x180B5AD10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DateTime FBAPCPICNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCCB600", Offset = "0xCCAA00", VA = "0x180CCB600")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x359CE10", Offset = "0x359C210", VA = "0x18359CE10")]
		public HMKCNFFEDMN(TKey OGFDNCPKECB, TVal IHADMCKJLJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class COBOEGGLMPJ : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0080", Offset = "0x6CF480")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::JNOHGJIOCHP<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D00E0", Offset = "0x6CF4E0")]
		private LinkedList<global::JNOHGJIOCHP<TKey, TVal>.HMKCNFFEDMN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x12CF0C0", Offset = "0x12CE4C0", VA = "0x1812CF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x259FE40", Offset = "0x259F240", VA = "0x18259FE40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEB70", Offset = "0x1DCDF70", VA = "0x181DCEB70")]
		[DebuggerHidden]
		public COBOEGGLMPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F92660", Offset = "0x1F91A60", VA = "0x181F92660", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x259F6C0", Offset = "0x259EAC0", VA = "0x18259F6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x259FF70", Offset = "0x259F370", VA = "0x18259FF70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x259FDB0", Offset = "0x259F1B0", VA = "0x18259FDB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public const int MFLHNKFMKFK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFA50", Offset = "0x6CEE50")]
	private readonly Dictionary<TKey, LinkedListNode<global::JNOHGJIOCHP<TKey, TVal>.HMKCNFFEDMN>> BAEHCPGKKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFAB0", Offset = "0x6CEEB0")]
	private readonly LinkedList<global::JNOHGJIOCHP<TKey, TVal>.HMKCNFFEDMN> EPAEMLKHODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFB10", Offset = "0x6CEF10")]
	private readonly global::JNOHGJIOCHP<TKey, TVal>.PJDNAGIKDDC IGIPODFNIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly TimeSpan OIDDBECDJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ABKKMACBPPJ LKAJCPDJAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool PNMJPNNOAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TKey> CLGLGOKLPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TVal> GPPFGKKLFIH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CMKLLLCOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE240", Offset = "0x8DD640", VA = "0x1808DE240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal int LHEFHMFBKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8DE250", Offset = "0x8DD650", VA = "0x1808DE250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8DE400", Offset = "0x8DD800", VA = "0x1808DE400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1621C40", Offset = "0x1621040", VA = "0x181621C40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TVal> NJOPDFPBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3EF0", Offset = "0x2CD32F0", VA = "0x182CD3EF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ICollection<TKey> IDictionary<TKey, TVal>.OPLBHNKCNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2CD2640", Offset = "0x2CD1A40", VA = "0x182CD2640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ADPPFIHDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TVal JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3EB0", Offset = "0x2CD32B0", VA = "0x182CD3EB0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2CD3F60", Offset = "0x2CD3360", VA = "0x182CD3F60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD15B0", Offset = "0x2CD09B0", VA = "0x182CD15B0")]
	private bool PEMODNBNJPM(int IPADGNLNKOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE190", Offset = "0x2CCD590", VA = "0x182CCE190")]
	private void CEPAGOEPJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3650", Offset = "0x2CD2A50", VA = "0x182CD3650")]
	public JNOHGJIOCHP(int IPADGNLNKOB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFB70", Offset = "0x6CEF70")] global::JNOHGJIOCHP<TKey, TVal>.PJDNAGIKDDC IGIPODFNIHC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFBD0", Offset = "0x6CEFD0")] IEqualityComparer<TKey> KODMKCMCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3180", Offset = "0x2CD2580", VA = "0x182CD3180")]
	public JNOHGJIOCHP(int IPADGNLNKOB, TimeSpan OIDDBECDJJM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFC30", Offset = "0x6CF030")] IEqualityComparer<TKey?>? KODMKCMCJEA, [Optional] ABKKMACBPPJ? LKAJCPDJAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3AD0", Offset = "0x2CD2ED0", VA = "0x182CD3AD0")]
	public JNOHGJIOCHP(int IPADGNLNKOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFC90", Offset = "0x6CF090")] global::JNOHGJIOCHP<TKey?, TVal?>.PJDNAGIKDDC? IGIPODFNIHC, TimeSpan OIDDBECDJJM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFCF0", Offset = "0x6CF0F0")] IEqualityComparer<TKey?>? KODMKCMCJEA, [Optional] ABKKMACBPPJ? LKAJCPDJAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFF60", Offset = "0x2CCF360", VA = "0x182CCFF60")]
	public bool DFKDLGOGOMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFFC0", Offset = "0x2CCF3C0", VA = "0x182CCFFC0")]
	public bool EEOGDMDHJFN(int GBNBGNMHGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD09D0", Offset = "0x2CCFDD0", VA = "0x182CD09D0")]
	public void EFMALMFMJGL(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2CCE0D0", Offset = "0x2CCD4D0", VA = "0x182CCE0D0", Slot = "14")]
	public void Add([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFD50", Offset = "0x6CF150")] KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDCC0", Offset = "0x2CCD0C0", VA = "0x182CCDCC0", Slot = "9")]
	public void Add(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF320", Offset = "0x2CCE720", VA = "0x182CCF320", Slot = "8")]
	public bool ContainsKey(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF320", Offset = "0x2CCE720", VA = "0x182CCF320", Slot = "16")]
	public bool Contains([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFDB0", Offset = "0x6CF1B0")] KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CD22C0", Offset = "0x2CD16C0", VA = "0x182CD22C0", Slot = "10")]
	public bool Remove(TKey OGFDNCPKECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2600", Offset = "0x2CD1A00", VA = "0x182CD2600", Slot = "18")]
	public bool Remove([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFE10", Offset = "0x6CF210")] KeyValuePair<TKey, TVal> JPOBIIKLHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1410", Offset = "0x2CD0810", VA = "0x182CD1410")]
	private TVal MKLBNKEKMJE(TKey OBALLIKLNDH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2970", Offset = "0x2CD1D70", VA = "0x182CD2970", Slot = "11")]
	public bool TryGetValue(TKey OBALLIKLNDH, out TVal LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF210", Offset = "0x2CCE610", VA = "0x182CCF210", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF430", Offset = "0x2CCE830", VA = "0x182CCF430", Slot = "17")]
	public void CopyTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFE70", Offset = "0x6CF270")] KeyValuePair<TKey, TVal>[] BGAKDGCGOMH, int HJEGHEJBGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF150", Offset = "0x2CCE550", VA = "0x182CCF150")]
	private bool COCKJAFJBPA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFED0", Offset = "0x6CF2D0")] global::JNOHGJIOCHP<TKey, TVal>.HMKCNFFEDMN PDCHFFGGJFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1E10", Offset = "0x2CD1210", VA = "0x182CD1E10")]
	private void PHNBHHCBHJF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFF30", Offset = "0x6CF330")] LinkedListNode<global::JNOHGJIOCHP<TKey, TVal>.HMKCNFFEDMN> ILEJJGCBEDI, TVal CKCLLMGGJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2CCECD0", Offset = "0x2CCE0D0", VA = "0x182CCECD0")]
	private void CJNLKFPNHDF(TKey OGFDNCPKECB, TVal LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD10D0", Offset = "0x2CD04D0", VA = "0x182CD10D0")]
	private void MFNDPMGDEAI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CFF90", Offset = "0x6CF390")] global::JNOHGJIOCHP<TKey, TVal>.HMKCNFFEDMN PDCHFFGGJFJ, TVal CKCLLMGGJFK, int DNLNCODPELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0B30", Offset = "0x2CCFF30", VA = "0x182CD0B30", Slot = "19")]
	[IteratorStateMachine(typeof(global::JNOHGJIOCHP<, >.COBOEGGLMPJ))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2680", Offset = "0x2CD1A80", VA = "0x182CD2680", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct OJKKFFLDPME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
	public static OJKKFFLDPME AENBDOEOIOH(Type OGILDIMGIOH, [Optional] string? PHICDGIEFLG, [Optional] string? GJHAEFNLOCG, bool CPKFKLHCCHO = false)
	{
		return default(OJKKFFLDPME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820")]
	public static OJKKFFLDPME AENBDOEOIOH<T>([Optional] string? PHICDGIEFLG, [Optional] string? GJHAEFNLOCG, bool CPKFKLHCCHO = false)
	{
		return default(OJKKFFLDPME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CPFMMOODPIE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate bool ACOOFFCIGGP(string ACNHNBLINPG, CPFMMOODPIE MGHHFPCAJLH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public int LOCDANMFCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public string DPBBLFJJIFG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69F3A20", Offset = "0x69F2E20", VA = "0x1869F3A20")]
	public static Dictionary<string, CPFMMOODPIE> IJFPLNHFGDG(Type ONAHEPMMCHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69F36F0", Offset = "0x69F2AF0", VA = "0x1869F36F0")]
	public static Dictionary<string, CPFMMOODPIE> CDBPLKIBBLD(Type ONAHEPMMCHP, ACOOFFCIGGP MKDEDBNKLGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69F3D10", Offset = "0x69F3110", VA = "0x1869F3D10")]
	public static Dictionary<int, string> PEENCEMNOBM(Dictionary<string, CPFMMOODPIE> KCGHNGOMAMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class KFANFMGGLGP : PAMMHIBIBOL
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool NHDAEOKICEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? GAGGJBBCEJG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public virtual PAMMHIBIBOL? HNKNAHALNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69F4A70", Offset = "0x69F3E70", VA = "0x1869F4A70")]
	protected KFANFMGGLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GMMLNCMCCAJ();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69F4530", Offset = "0x69F3930", VA = "0x1869F4530", Slot = "8")]
	public virtual string BLBJLPOLPAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69F4610", Offset = "0x69F3A10", VA = "0x1869F4610", Slot = "9")]
	public void EDOHGNMMEBH(StringBuilder IHDOPDPCKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x69F45B0", Offset = "0x69F39B0", VA = "0x1869F45B0", Slot = "10")]
	public void CAOIECPHFOO(StringBuilder IHDOPDPCKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69F4950", Offset = "0x69F3D50", VA = "0x1869F4950", Slot = "11")]
	public void PNDFOLPJBFN(StringBuilder IHDOPDPCKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69F43D0", Offset = "0x69F37D0", VA = "0x1869F43D0", Slot = "12")]
	public void AELEBNNIGOM(StringBuilder IHDOPDPCKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69F48B0", Offset = "0x69F3CB0", VA = "0x1869F48B0")]
	public static void NDJFKHGEHGP(StringBuilder IHDOPDPCKJA, string OECHCNGOMCE, string IDHHFABBFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x213E7B0", Offset = "0x213DBB0", VA = "0x18213E7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JCJPHNCPMOC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69F4360", Offset = "0x69F3760", VA = "0x1869F4360")]
	public JCJPHNCPMOC(string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PIHBFGJOEBD<TErr> : JCJPHNCPMOC where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr MPCELFDCBIE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26315C0", Offset = "0x26309C0", VA = "0x1826315C0")]
	private PIHBFGJOEBD(in TErr LCPOHMIBKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x26314F0", Offset = "0x26308F0", VA = "0x1826314F0")]
	public static global::PIHBFGJOEBD<TErr> GILBACJLDCL(in TErr LCPOHMIBKBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PAMMHIBIBOL
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BLBJLPOLPAM();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GMMLNCMCCAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GBPBAFKAGPD<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	TOptions NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NBANJOJNMDP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string PDOOHLLNOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HEPEDIGJPKD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69F42F0", Offset = "0x69F36F0", VA = "0x1869F42F0")]
	public HEPEDIGJPKD(string BALNMHDNCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EEFNOAMMAJG<TOk> : HEPEDIGJPKD where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly TOk LLEMJKAJHEC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3438B80", Offset = "0x3437F80", VA = "0x183438B80")]
	private EEFNOAMMAJG(in TOk DAHFMBELKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2237650", Offset = "0x2236A50", VA = "0x182237650")]
	public static global::EEFNOAMMAJG<TOk> GILBACJLDCL(in TOk DAHFMBELKAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct LFBADEDAHHF<TOk, TErr> : IEquatable<global::LFBADEDAHHF<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<TErr> AMJMOCOLEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal readonly TErr MPCELFDCBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal readonly TOk LLEMJKAJHEC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EDABOFCCCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x33C8FF0", Offset = "0x33C83F0", VA = "0x1833C8FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GHGNCBEBBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x33C8440", Offset = "0x33C7840", VA = "0x1833C8440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x33CB0A0", Offset = "0x33CA4A0", VA = "0x1833CB0A0")]
	internal LFBADEDAHHF(in TErr LCPOHMIBKBM, in TOk DAHFMBELKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x33C6270", Offset = "0x33C5670", VA = "0x1833C6270")]
	public static global::LFBADEDAHHF<TOk, TErr> DNENEOPIPCO(in TErr LCPOHMIBKBM)
	{
		return default(global::LFBADEDAHHF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x33C88B0", Offset = "0x33C7CB0", VA = "0x1833C88B0")]
	public static global::LFBADEDAHHF<TOk, TErr> LGLJIAKCIMO(in TOk DAHFMBELKAJ)
	{
		return default(global::LFBADEDAHHF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3172150", Offset = "0x3171550", VA = "0x183172150")]
	public global::LFBADEDAHHF<UOk?, TErr?> GFGACMODJPA<UOk>()
	{
		return default(global::LFBADEDAHHF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x31724C0", Offset = "0x31718C0", VA = "0x1831724C0")]
	public global::LFBADEDAHHF<UOk?, TErr?> OPPJDIEJDJO<UOk>()
	{
		return default(global::LFBADEDAHHF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3171E10", Offset = "0x3171210", VA = "0x183171E10")]
	public global::LFBADEDAHHF<TOk?, UErr?> DCMPGOMBHAH<UErr>()
	{
		return default(global::LFBADEDAHHF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x33C5100", Offset = "0x33C4500", VA = "0x1833C5100")]
	public global::LFBADEDAHHF<JAPIHNFIDBB, TErr> AAFADGNPBNE()
	{
		return default(global::LFBADEDAHHF<JAPIHNFIDBB, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x33C5800", Offset = "0x33C4C00", VA = "0x1833C5800")]
	public static bool BOBJELOEACN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D01E0", Offset = "0x6CF5E0")] in global::LFBADEDAHHF<TOk, TErr> LJLKLAFAGNO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0250", Offset = "0x6CF650")] in global::LFBADEDAHHF<TOk, TErr> HFBAHIGFPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x33C6750", Offset = "0x33C5B50", VA = "0x1833C6750", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D02C0", Offset = "0x6CF6C0")] global::LFBADEDAHHF<TOk, TErr> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x33C6A80", Offset = "0x33C5E80", VA = "0x1833C6A80", Slot = "0")]
	public override bool Equals(object MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x33C7F20", Offset = "0x33C7320", VA = "0x1833C7F20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x33CA5C0", Offset = "0x33C99C0", VA = "0x1833CA5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OKNMMNECALM
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x25B8B60", Offset = "0x25B7F60", VA = "0x1825B8B60")]
	public static global::LFBADEDAHHF<TOk?, TErr?> LLEMJKAJHEC<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0360", Offset = "0x6CF760")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, in TOk DAHFMBELKAJ)
	{
		return default(global::LFBADEDAHHF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x25B8BD0", Offset = "0x25B7FD0", VA = "0x1825B8BD0")]
	public static global::LFBADEDAHHF<JAPIHNFIDBB, TErr?> LLEMJKAJHEC<TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0400", Offset = "0x6CF800")] this in global::LFBADEDAHHF<JAPIHNFIDBB, TErr?> INHKNJBCCPD)
	{
		return default(global::LFBADEDAHHF<JAPIHNFIDBB, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25B8B60", Offset = "0x25B7F60", VA = "0x1825B8B60")]
	public static global::LFBADEDAHHF<TOk?, TErr?> MPCELFDCBIE<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0470", Offset = "0x6CF870")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, in TErr LCPOHMIBKBM)
	{
		return default(global::LFBADEDAHHF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25B9180", Offset = "0x25B8580", VA = "0x1825B9180")]
	public static TOk? MJHHCGBONLP<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D04E0", Offset = "0x6CF8E0")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x25B8C90", Offset = "0x25B8090", VA = "0x1825B8C90")]
	[AsyncStateMachine(typeof(DEDHFFBLMLP))]
	public static Task<TOk?>? MHOICKCPKBB<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D05C0", Offset = "0x6CF9C0")] this Task<global::LFBADEDAHHF<TOk?, TErr?>>? INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x25B7F60", Offset = "0x25B7360", VA = "0x1825B7F60")]
	public static TErr? DIHFOECBEFC<TErr, TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0620", Offset = "0x6CFA20")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x25B82F0", Offset = "0x25B76F0", VA = "0x1825B82F0")]
	public static bool GDKAAPPNNPL<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0690", Offset = "0x6CFA90")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0700", Offset = "0x6CFB00")] out global::LFBADEDAHHF<UOk?, UErr?> ODCDKLCLFMF) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x25B8190", Offset = "0x25B7590", VA = "0x1825B8190")]
	public static bool FKIGOGBGJOF<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0760", Offset = "0x6CFB60")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x25B7F20", Offset = "0x25B7320", VA = "0x1825B7F20")]
	public static bool BNIGFFHLNNL<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0810", Offset = "0x6CFC10")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TErr LCPOHMIBKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x25B80F0", Offset = "0x25B74F0", VA = "0x1825B80F0")]
	public static bool FDCHGFGHFNJ<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D08C0", Offset = "0x6CFCC0")] this in global::LFBADEDAHHF<TOk, TErr> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ, [MNKKOBAPPBG(false)] out TErr LCPOHMIBKBM) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x25B9840", Offset = "0x25B8C40", VA = "0x1825B9840")]
	public static bool PJHIHKOLEHA<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0930", Offset = "0x6CFD30")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D09A0", Offset = "0x6CFDA0")] out global::LFBADEDAHHF<TOk?, TErr?> ODCDKLCLFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x25B81D0", Offset = "0x25B75D0", VA = "0x1825B81D0")]
	public static bool GDKAAPPNNPL<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0A00", Offset = "0x6CFE00")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0A70", Offset = "0x6CFE70")] out global::LFBADEDAHHF<UOk?, UErr?> ODCDKLCLFMF) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x25B9580", Offset = "0x25B8980", VA = "0x1825B9580")]
	public static bool NLJKHNJBIPM<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0AD0", Offset = "0x6CFED0")] this in global::LFBADEDAHHF<TOk?, TErr?> INHKNJBCCPD, [MNKKOBAPPBG(true)] out TOk DAHFMBELKAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0B40", Offset = "0x6CFF40")] out global::LFBADEDAHHF<JAPIHNFIDBB, TErr?> ODCDKLCLFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25B98E0", Offset = "0x25B8CE0", VA = "0x1825B98E0")]
	public static global::LFBADEDAHHF<UOk, UErr> PLHOHGHAJKG<UOk, UErr, TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0BA0", Offset = "0x6CFFA0")] this in global::LFBADEDAHHF<TOk, TErr> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0C10", Offset = "0x6D0010")] in global::LFBADEDAHHF<UOk, UErr> PJEHHDIBMKL) where TOk : UOk where TErr : UErr
	{
		return default(global::LFBADEDAHHF<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25B91F0", Offset = "0x25B85F0", VA = "0x1825B91F0")]
	public static global::LFBADEDAHHF<TOk?[]?, TErr?> NFNCJFHGINO<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0C80", Offset = "0x6D0080")] this IEnumerable<global::LFBADEDAHHF<TOk?, TErr?>>? INHKNJBCCPD)
	{
		return default(global::LFBADEDAHHF<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x234EF80", Offset = "0x234E380", VA = "0x18234EF80")]
	[IteratorStateMachine(typeof(BKABNHENIBH))]
	public static IEnumerable<TOk?>? GEFMILAOMHN<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0D40", Offset = "0x6D0140")] this IEnumerable<global::LFBADEDAHHF<TOk?, TErr?>>? INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BLGOIPNLKAC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2451B80", Offset = "0x2450F80", VA = "0x182451B80")]
	public static global::LFBADEDAHHF<TOk, T> LLEMJKAJHEC<TOk>(in TOk DAHFMBELKAJ) where TOk : notnull
	{
		return default(global::LFBADEDAHHF<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x20B4F30", Offset = "0x20B4330", VA = "0x1820B4F30")]
	public static global::LFBADEDAHHF<JAPIHNFIDBB, T> LLEMJKAJHEC()
	{
		return default(global::LFBADEDAHHF<JAPIHNFIDBB, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2451B80", Offset = "0x2450F80", VA = "0x182451B80")]
	public static global::LFBADEDAHHF<T, TErr> MPCELFDCBIE<TErr>(in TErr LCPOHMIBKBM) where TErr : notnull
	{
		return default(global::LFBADEDAHHF<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public sealed class AJCGCEFGDHE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private readonly struct GCEJHNAFDBM : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly global::AJCGCEFGDHE<T> OGFCGJHPMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly int KGBJNHCAIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly bool NLKHPENODEB;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3107530", Offset = "0x3106930", VA = "0x183107530")]
		public GCEJHNAFDBM(global::AJCGCEFGDHE<T> NLKDOMNEDBE, int DOBBJOIAKFM, bool LHHCABEHHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3107400", Offset = "0x3106800", VA = "0x183107400")]
		public global::AJCGCEFGDHE<T>.OABBNCFGOBI OKFDNCHLPHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x31074F0", Offset = "0x31068F0", VA = "0x1831074F0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x31074F0", Offset = "0x31068F0", VA = "0x1831074F0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class OABBNCFGOBI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::AJCGCEFGDHE<T> OGFCGJHPMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly int KEFCNKDFGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int CMCKDKHKFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly bool NLKHPENODEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool MCNADHLKJEG;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T IFFLDLNKLFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2CA3C20", Offset = "0x2CA3020", VA = "0x182CA3C20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2CA3DF0", Offset = "0x2CA31F0", VA = "0x182CA3DF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2CA3FF0", Offset = "0x2CA33F0", VA = "0x182CA3FF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CA41C0", Offset = "0x2CA35C0", VA = "0x182CA41C0")]
		public OABBNCFGOBI(global::AJCGCEFGDHE<T> NLKDOMNEDBE, int DOBBJOIAKFM, bool LHHCABEHHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3CC0", Offset = "0x2CA30C0", VA = "0x182CA3CC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3D40", Offset = "0x2CA3140", VA = "0x182CA3D40", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IANBJFGMNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0E30", Offset = "0x6D0230")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public IANBJFGMNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1615070", Offset = "0x1614470", VA = "0x181615070")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly T[] LJLFICLCEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CMCKDKHKFAE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int ACBICPOGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7A20", Offset = "0x2BA6E20", VA = "0x182BA7A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T IFFLDLNKLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x241E050", Offset = "0x241D450", VA = "0x18241E050")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T BPAJEMADNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7770", Offset = "0x2BA6B70", VA = "0x182BA7770")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BA78C0", Offset = "0x2BA6CC0", VA = "0x182BA78C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int JJINKJIBOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1836BF0", Offset = "0x1835FF0", VA = "0x181836BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7950", Offset = "0x2BA6D50", VA = "0x182BA7950")]
	private static int DJHLMKBGKHN(int EGNHJGKABLC, int OEMPOIHBNFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7C30", Offset = "0x2BA7030", VA = "0x182BA7C30")]
	public AJCGCEFGDHE(int GBNBGNMHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7AE0", Offset = "0x2BA6EE0", VA = "0x182BA7AE0")]
	public AJCGCEFGDHE(int GBNBGNMHGLO, Func<T> DGKINJNHIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7E60", Offset = "0x2BA7260", VA = "0x182BA7E60")]
	public AJCGCEFGDHE(T[] AABKFFENABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7920", Offset = "0x2BA6D20", VA = "0x182BA7920")]
	public void DFJNLNPIOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7970", Offset = "0x2BA6D70", VA = "0x182BA7970")]
	public IEnumerable<T> EGGHGPAIJEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7A60", Offset = "0x2BA6E60", VA = "0x182BA7A60")]
	public global::AJCGCEFGDHE<T>.OABBNCFGOBI OKFDNCHLPHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x162C6C0", Offset = "0x162BAC0", VA = "0x18162C6C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x162C6C0", Offset = "0x162BAC0", VA = "0x18162C6C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class LBPNKBLFEOA
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1F0BCD0", Offset = "0x1F0B0D0", VA = "0x181F0BCD0")]
	public static global::AJCGCEFGDHE<T> GILBACJLDCL<T>(int GBNBGNMHGLO, Func<T> DGKINJNHIJP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class JLPHKECNIFM<TData> : KFANFMGGLGP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly string KKGDNEGJOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly TData CNDFKFGJPCE;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
	public override string GMMLNCMCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D60D20", Offset = "0x3D60120", VA = "0x183D60D20")]
	internal JLPHKECNIFM(string BALNMHDNCIN, in TData HIDEHJGLNHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GDGDFDJMCLF
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69F4280", Offset = "0x69F3680", VA = "0x1869F4280")]
	public static global::JLPHKECNIFM<JAPIHNFIDBB> GILBACJLDCL(string BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x169AEB0", Offset = "0x169A2B0", VA = "0x18169AEB0")]
	public static global::JLPHKECNIFM<TData> GILBACJLDCL<TData>(string BALNMHDNCIN, in TData HIDEHJGLNHO) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PMNIAEBNKPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Dictionary<object, float> GDCEFHMGFFB;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float EEEEJNHDKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xCDDBB0", Offset = "0xCDCFB0", VA = "0x180CDDBB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xC4E3F0", Offset = "0xC4D7F0", VA = "0x180C4E3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69F55F0", Offset = "0x69F49F0", VA = "0x1869F55F0")]
	public void CJNLKFPNHDF(float LPJDDLMPNCG, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x69F5780", Offset = "0x69F4B80", VA = "0x1869F5780")]
	public void PBFPIEEMKFJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x69F5660", Offset = "0x69F4A60", VA = "0x1869F5660")]
	private void CMKKCBILMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x69F57F0", Offset = "0x69F4BF0", VA = "0x1869F57F0")]
	public PMNIAEBNKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BHECNCBBLMC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OGJIAOHJIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public OGJIAOHJIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69F5540", Offset = "0x69F4940", VA = "0x1869F5540")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0E90", Offset = "0x6D0290")]
	private HashSet<object> EFOCNJAEIPA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IReadOnlyCollection<object> OPBNFDMBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69F3250", Offset = "0x69F2650", VA = "0x1869F3250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool MJNHCKEGDDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69F33C0", Offset = "0x69F27C0", VA = "0x1869F33C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x788950", Offset = "0x787D50", VA = "0x180788950")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBB01E0", Offset = "0xBAF5E0", VA = "0x180BB01E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x69F3160", Offset = "0x69F2560", VA = "0x1869F3160")]
	public bool AGMLDLCGDGN(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x69F3320", Offset = "0x69F2720", VA = "0x1869F3320")]
	public bool FJEBMLODAAK(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69F33D0", Offset = "0x69F27D0", VA = "0x1869F33D0")]
	public bool GMBMHDKFMPB(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69F3430", Offset = "0x69F2830", VA = "0x1869F3430")]
	public void OKDDGLLANON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x69F34A0", Offset = "0x69F28A0", VA = "0x1869F34A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public BHECNCBBLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NFFFIELCCID<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct FOBKEJBJPAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float PKIGECIECGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public T NDNOLKCBONM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D0EF0", Offset = "0x6D02F0")]
	private readonly Dictionary<object, global::NFFFIELCCID<T>.FOBKEJBJPAG> GDCEFHMGFFB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public virtual T GHFFBIHAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x12CF0C0", Offset = "0x12CE4C0", VA = "0x1812CF0C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x16BBD20", Offset = "0x16BB120", VA = "0x1816BBD20", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public object? FDCDOIPHEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0D30", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HDDGJFGBFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x26E2170", Offset = "0x26E1570", VA = "0x1826E2170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x26E1D40", Offset = "0x26E1140", VA = "0x1826E1D40")]
	public bool CJNLKFPNHDF(T LPJDDLMPNCG, object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x26E37F0", Offset = "0x26E2BF0", VA = "0x1826E37F0")]
	public bool PBFPIEEMKFJ(object MIFCLBEAOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x16337C0", Offset = "0x1632BC0", VA = "0x1816337C0")]
	public void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x26E1F70", Offset = "0x26E1370", VA = "0x1826E1F70")]
	public bool DJKANKJNGBD(object MIFCLBEAOPM, out T LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x26E21B0", Offset = "0x26E15B0", VA = "0x1826E21B0")]
	private bool KBFDGGDEHPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x26E3870", Offset = "0x26E2C70", VA = "0x1826E3870")]
	public NFFFIELCCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NKKFNBJGPNK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FPLCMFJCNOC KBCLEKGFIKC;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KIBJFOMIMGE : NKKFNBJGPNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public readonly struct PNJNOBBFOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly float FHHOHIGFIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly float GLLHIGHMNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal readonly bool FAKGJGPBFFP;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float MDFKAKBJDBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x69F5870", Offset = "0x69F4C70", VA = "0x1869F5870")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x69F5A00", Offset = "0x69F4E00", VA = "0x1869F5A00")]
		public PNJNOBBFOOP(float LOEMONDJCMM, float FHNIHLGHOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x69F5880", Offset = "0x69F4C80", VA = "0x1869F5880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CLCDKMOMFPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public KIBJFOMIMGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public CLCDKMOMFPP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly int IPADGNLNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int DEKBMMBKAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NKKFNBJGPNK[] JNPPFFIIFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly FPLCMFJCNOC[] NOHGMFJPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly PNJNOBBFOOP[] JNPBEPOKPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private PNJNOBBFOOP LJHNGOAJDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FBEIKNPDGBI BAPOMLOEIFI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D36840", Offset = "0x1D35C40", VA = "0x181D36840", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event FPLCMFJCNOC KBCLEKGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x69F5190", Offset = "0x69F4590", VA = "0x1869F5190", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x69F50D0", Offset = "0x69F44D0", VA = "0x1869F50D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69F5250", Offset = "0x69F4650", VA = "0x1869F5250")]
	public KIBJFOMIMGE(int IPADGNLNKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69F4AE0", Offset = "0x69F3EE0", VA = "0x1869F4AE0")]
	public FBEIKNPDGBI AMKEFKFNPHM(PNJNOBBFOOP FAOHJBCBHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x69F4B70", Offset = "0x69F3F70", VA = "0x1869F4B70")]
	public void BJEMJCMIGEI(NKKFNBJGPNK GNMHMDLPNNJ, [Optional] PNJNOBBFOOP KFPLIKEEDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x69F4FC0", Offset = "0x69F43C0", VA = "0x1869F4FC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public delegate void FPLCMFJCNOC(float PDMEDOHHOJO);
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DEFCEDAMCAC
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class KIKPFBDALMN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly NKKFNBJGPNK AKAFEPHMBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly FPLCMFJCNOC MIKGEIBIMCG;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x69F5420", Offset = "0x69F4820", VA = "0x1869F5420")]
		public KIKPFBDALMN(NKKFNBJGPNK AKAFEPHMBOO, FPLCMFJCNOC MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x69F53D0", Offset = "0x69F47D0", VA = "0x1869F53D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69F3F80", Offset = "0x69F3380", VA = "0x1869F3F80")]
	internal static bool NOPKMNHPAME(float HFOFADIOHHP, float GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x49C74F0", Offset = "0x49C68F0", VA = "0x1849C74F0")]
	internal static float IKALADPEBMK(float HFOFADIOHHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69F3EC0", Offset = "0x69F32C0", VA = "0x1869F3EC0")]
	public static IDisposable FPMJEILKHCJ(this NKKFNBJGPNK AKAFEPHMBOO, FPLCMFJCNOC MIKGEIBIMCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FBEIKNPDGBI : NKKFNBJGPNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private float PDMEDOHHOJO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float DJDJFCOJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xCDDBB0", Offset = "0xCDCFB0", VA = "0x180CDDBB0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x69F40A0", Offset = "0x69F34A0", VA = "0x1869F40A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FPLCMFJCNOC? KBCLEKGFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x69F4160", Offset = "0x69F3560", VA = "0x1869F4160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x69F4000", Offset = "0x69F3400", VA = "0x1869F4000", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public FBEIKNPDGBI()
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
