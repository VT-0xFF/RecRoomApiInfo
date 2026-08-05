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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ABB000", Offset = "0x6AB9A00", VA = "0x186ABB000")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EEAMKILKNCP<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::MHNDLIAIGJG<TKey, TVal> OEEPEMJBNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4AA0", Offset = "0x6F3EA0")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BMFHMPMKNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int DENJPPONHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4B70", Offset = "0x6F3F70")]
	private readonly global::MHNDLIAIGJG<TKey, TVal>.BFMBDMOHGMP HDJHBIOCAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int IIENIHLIFMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal int ECLPMMKCDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D51E10", Offset = "0x3D50810", VA = "0x183D51E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OAFOLGMAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D52060", Offset = "0x3D50A60", VA = "0x183D52060")]
	public EEAMKILKNCP(int DENJPPONHEG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4BD0", Offset = "0x6F3FD0")] global::MHNDLIAIGJG<TKey, TVal>.BFMBDMOHGMP HDJHBIOCAOP, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4C30", Offset = "0x6F4030")] IEqualityComparer<TKey> DLFMAEIBLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D51EF0", Offset = "0x3D508F0", VA = "0x183D51EF0")]
	public void PHACAAGMLOJ(TKey IGFDDANAMMH, TVal MFBGAMJDOKA, bool MFIKOALBONE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D51D90", Offset = "0x3D50790", VA = "0x183D51D90")]
	public bool LHIHMIEAOFH(TKey IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D51CE0", Offset = "0x3D506E0", VA = "0x183D51CE0")]
	public bool JBPBACKGAAO(TKey HLDNBMGGENJ, out TVal MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D51B20", Offset = "0x3D50520", VA = "0x183D51B20")]
	private void INFPNLGFFJL(TKey IGFDDANAMMH, TVal MFBGAMJDOKA, int IMMPKDAEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D519F0", Offset = "0x3D503F0", VA = "0x183D519F0")]
	public bool AFNNLPOHFDB(TKey IGFDDANAMMH, TVal MFBGAMJDOKA, bool MFIKOALBONE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D51E50", Offset = "0x3D50850", VA = "0x183D51E50")]
	private bool PEEFJGBFBHH(TKey IGFDDANAMMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class MHNDLIAIGJG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate int BFMBDMOHGMP(TKey IGFDDANAMMH, TVal MFBGAMJDOKA);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class CNNDNLKHNJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TKey LAPHJCILMHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8B9650", Offset = "0x8B8050", VA = "0x1808B9650")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TVal ONBMIOJBCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int PMGBHJMMFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4060", VA = "0x1807E5660")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7E5650", Offset = "0x7E4050", VA = "0x1807E5650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DateTime MOEOJABLNNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8464D0", Offset = "0x844ED0", VA = "0x1808464D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4283F50", Offset = "0x4282950", VA = "0x184283F50")]
		public CNNDNLKHNJO(TKey IGFDDANAMMH, TVal GNMCFHMDDGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EFOLDJLNFAJ : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5320", Offset = "0x6F4720")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::MHNDLIAIGJG<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5380", Offset = "0x6F4780")]
		private LinkedList<global::MHNDLIAIGJG<TKey, TVal>.CNNDNLKHNJO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1E361B0", Offset = "0x1E34BB0", VA = "0x181E361B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3144E40", Offset = "0x3143840", VA = "0x183144E40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2F0C300", Offset = "0x2F0AD00", VA = "0x182F0C300")]
		[DebuggerHidden]
		public EFOLDJLNFAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3144E90", Offset = "0x3143890", VA = "0x183144E90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3144480", Offset = "0x3142E80", VA = "0x183144480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3145190", Offset = "0x3143B90", VA = "0x183145190")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3144CB0", Offset = "0x31436B0", VA = "0x183144CB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public const int CBGCKPPMNMN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4CF0", Offset = "0x6F40F0")]
	private readonly Dictionary<TKey, LinkedListNode<global::MHNDLIAIGJG<TKey, TVal>.CNNDNLKHNJO>> NPBOHIHHOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4D50", Offset = "0x6F4150")]
	private readonly LinkedList<global::MHNDLIAIGJG<TKey, TVal>.CNNDNLKHNJO> PEHLFOCNAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4DB0", Offset = "0x6F41B0")]
	private readonly global::MHNDLIAIGJG<TKey, TVal>.BFMBDMOHGMP HDJHBIOCAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly TimeSpan FHJGGIALLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly GCJHKDPHCIF FGPDIFPJIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JHHKFKOPNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TKey> MEIAKHNEGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TVal> EFLMPCABIMJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OAFOLGMAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x857010", Offset = "0x855A10", VA = "0x180857010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal int ECLPMMKCDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87C8E0", Offset = "0x87B2E0", VA = "0x18087C8E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87CB70", Offset = "0x87B570", VA = "0x18087CB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4850", Offset = "0x3AD3250", VA = "0x183AD4850", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TVal> FBMMJKJNBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AD48F0", Offset = "0x3AD32F0", VA = "0x183AD48F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ICollection<TKey> IDictionary<TKey, TVal>.LMIIHBHJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2BC0", Offset = "0x3AD15C0", VA = "0x183AD2BC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GOJJAFPEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TVal KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4880", Offset = "0x3AD3280", VA = "0x183AD4880", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4960", Offset = "0x3AD3360", VA = "0x183AD4960", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3AD1D90", Offset = "0x3AD0790", VA = "0x183AD1D90")]
	private bool NBPFDBKKDLD(int ICKPJJPJOOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3AD14F0", Offset = "0x3ACFEF0", VA = "0x183AD14F0")]
	private void IAHMEBACPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3600", Offset = "0x3AD2000", VA = "0x183AD3600")]
	public MHNDLIAIGJG(int ICKPJJPJOOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4E10", Offset = "0x6F4210")] global::MHNDLIAIGJG<TKey, TVal>.BFMBDMOHGMP HDJHBIOCAOP, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4E70", Offset = "0x6F4270")] IEqualityComparer<TKey> DLFMAEIBLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3AD36D0", Offset = "0x3AD20D0", VA = "0x183AD36D0")]
	public MHNDLIAIGJG(int ICKPJJPJOOC, TimeSpan FHJGGIALLNO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4ED0", Offset = "0x6F42D0")] IEqualityComparer<TKey?>? DLFMAEIBLHE, [Optional] GCJHKDPHCIF? FGPDIFPJIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3720", Offset = "0x3AD2120", VA = "0x183AD3720")]
	public MHNDLIAIGJG(int ICKPJJPJOOC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4F30", Offset = "0x6F4330")] global::MHNDLIAIGJG<TKey?, TVal?>.BFMBDMOHGMP? HDJHBIOCAOP, TimeSpan FHJGGIALLNO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4F90", Offset = "0x6F4390")] IEqualityComparer<TKey?>? DLFMAEIBLHE, [Optional] GCJHKDPHCIF? FGPDIFPJIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF170", Offset = "0x3ACDB70", VA = "0x183ACF170")]
	public bool FLPAILPDCKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFE80", Offset = "0x3ACE880", VA = "0x183ACFE80")]
	public bool GHDMHPLFLAG(int IMMPKDAEONJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDE40", Offset = "0x3ACC840", VA = "0x183ACDE40")]
	public void CKIEIOOCMAM(TKey IGFDDANAMMH, TVal MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD960", Offset = "0x3ACC360", VA = "0x183ACD960", Slot = "14")]
	public void Add([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F4FF0", Offset = "0x6F43F0")] KeyValuePair<TKey, TVal> FPEJLKINELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDAD0", Offset = "0x3ACC4D0", VA = "0x183ACDAD0", Slot = "9")]
	public void Add(TKey IGFDDANAMMH, TVal MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE220", Offset = "0x3ACCC20", VA = "0x183ACE220", Slot = "8")]
	public bool ContainsKey(TKey IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE220", Offset = "0x3ACCC20", VA = "0x183ACE220", Slot = "16")]
	public bool Contains([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5050", Offset = "0x6F4450")] KeyValuePair<TKey, TVal> FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2820", Offset = "0x3AD1220", VA = "0x183AD2820", Slot = "10")]
	public bool Remove(TKey IGFDDANAMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3AD27E0", Offset = "0x3AD11E0", VA = "0x183AD27E0", Slot = "18")]
	public bool Remove([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F50B0", Offset = "0x6F44B0")] KeyValuePair<TKey, TVal> FPEJLKINELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD740", Offset = "0x3ACC140", VA = "0x183ACD740")]
	private TVal ABMJNALEGDK(TKey HLDNBMGGENJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2EB0", Offset = "0x3AD18B0", VA = "0x183AD2EB0", Slot = "11")]
	public bool TryGetValue(TKey HLDNBMGGENJ, out TVal MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE150", Offset = "0x3ACCB50", VA = "0x183ACE150", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3ACEE90", Offset = "0x3ACD890", VA = "0x183ACEE90", Slot = "17")]
	public void CopyTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5110", Offset = "0x6F4510")] KeyValuePair<TKey, TVal>[] HPOICFFOIAP, int IEPKLEKMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3AD1CD0", Offset = "0x3AD06D0", VA = "0x183AD1CD0")]
	private bool MAIKEAPBALH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5170", Offset = "0x6F4570")] global::MHNDLIAIGJG<TKey, TVal>.CNNDNLKHNJO NDPHNIOBDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0F80", Offset = "0x3ACF980", VA = "0x183AD0F80")]
	private void HOLOHKPNGOG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F51D0", Offset = "0x6F45D0")] LinkedListNode<global::MHNDLIAIGJG<TKey, TVal>.CNNDNLKHNJO> CJFADGDIJCD, TVal LMBBEFCIFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF3F0", Offset = "0x3ACDDF0", VA = "0x183ACF3F0")]
	private void FMHGDPNPEHP(TKey IGFDDANAMMH, TVal MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2140", Offset = "0x3AD0B40", VA = "0x183AD2140")]
	private void NCCNMPFIABF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5230", Offset = "0x6F4630")] global::MHNDLIAIGJG<TKey, TVal>.CNNDNLKHNJO NDPHNIOBDOP, TVal LMBBEFCIFMN, int KIAHDMBANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0650", Offset = "0x3ACF050", VA = "0x183AD0650", Slot = "19")]
	[IteratorStateMachine(typeof(global::MHNDLIAIGJG<, >.EFOLDJLNFAJ))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x38F7640", Offset = "0x38F6040", VA = "0x1838F7640", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct DBABJEJNHLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0")]
	public static DBABJEJNHLL PLBJOAHNOPL(Type EMKINACMDLO, [Optional] string? HAOOCKIFPEA, [Optional] string? DMLKPBILBPG, bool PDPEFOJHJHJ = false)
	{
		return default(DBABJEJNHLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0")]
	public static DBABJEJNHLL PLBJOAHNOPL<T>([Optional] string? HAOOCKIFPEA, [Optional] string? DMLKPBILBPG, bool PDPEFOJHJHJ = false)
	{
		return default(DBABJEJNHLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KNPMJIHCBMO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate bool PBNCKDKHHHO(string IAHFJOLDCAP, KNPMJIHCBMO OKGDNHAHGFO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public int MKLGBIEKHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public string GPHGFAEHHAN;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9A20", Offset = "0x6AB8420", VA = "0x186AB9A20")]
	public static Dictionary<string, KNPMJIHCBMO> CHAPGNBAKDN(Type JNEGGKHKLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9D10", Offset = "0x6AB8710", VA = "0x186AB9D10")]
	public static Dictionary<string, KNPMJIHCBMO> DLNIKFFGPMM(Type JNEGGKHKLLI, PBNCKDKHHHO BNMFFKBGACI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA040", Offset = "0x6AB8A40", VA = "0x186ABA040")]
	public static Dictionary<int, string> HGPMCJPGHMD(Dictionary<string, KNPMJIHCBMO> BMKGEKNDEIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MIKMJPNAIIO : GEPHFINPONA
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool DGGAFONIEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? JMCGBAFEDNH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public virtual GEPHFINPONA? OCJLKFLJBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA890", Offset = "0x6AB9290", VA = "0x186ABA890")]
	protected MIKMJPNAIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string ODHCPOFFIEP();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA810", Offset = "0x6AB9210", VA = "0x186ABA810", Slot = "8")]
	public virtual string PPJHLEIMCFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA470", Offset = "0x6AB8E70", VA = "0x186ABA470", Slot = "9")]
	public void KILAIDNEIKL(StringBuilder PIOIMMCCFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA7B0", Offset = "0x6AB91B0", VA = "0x186ABA7B0", Slot = "10")]
	public void ONCMNIBBELE(StringBuilder PIOIMMCCFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA1F0", Offset = "0x6AB8BF0", VA = "0x186ABA1F0", Slot = "11")]
	public void AJEDBGOOCMJ(StringBuilder PIOIMMCCFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA310", Offset = "0x6AB8D10", VA = "0x186ABA310", Slot = "12")]
	public void DBLJOOKHLPC(StringBuilder PIOIMMCCFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA710", Offset = "0x6AB9110", VA = "0x186ABA710")]
	public static void KKOBANDIAJO(StringBuilder PIOIMMCCFBK, string DNFMGLNNHOJ, string IPIOCDIIAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8334E0", Offset = "0x831EE0", VA = "0x1808334E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CNEINJFLCJB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8790", Offset = "0x6AB7190", VA = "0x186AB8790")]
	public CNEINJFLCJB(string MDEEJIBNIAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MFPNMCIKDGJ<TErr> : CNEINJFLCJB where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr MKEOCBLGCJI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA62B0", Offset = "0x4EA4CB0", VA = "0x184EA62B0")]
	private MFPNMCIKDGJ(in TErr CAIOLBAJJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x42D8CC0", Offset = "0x42D76C0", VA = "0x1842D8CC0")]
	public static global::MFPNMCIKDGJ<TErr> IDLIIDOEAFG(in TErr CAIOLBAJJDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GEPHFINPONA
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PPJHLEIMCFA();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ODHCPOFFIEP();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LHLKKOLPFIN<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	TOptions ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PINMJEMDFGA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string LOPLKPKLGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KCPMGJGGKNF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AB99B0", Offset = "0x6AB83B0", VA = "0x186AB99B0")]
	public KCPMGJGGKNF(string MDEEJIBNIAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GJAIDABOMCA<TOk> : KCPMGJGGKNF where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly TOk IHLLAGDBFIH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3FE4CE0", Offset = "0x3FE36E0", VA = "0x183FE4CE0")]
	private GJAIDABOMCA(in TOk IOAABMLJGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x37776B0", Offset = "0x37760B0", VA = "0x1837776B0")]
	public static global::GJAIDABOMCA<TOk> IDLIIDOEAFG(in TOk IOAABMLJGAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct DAOEJNFJJPJ<TOk, TErr> : IEquatable<global::DAOEJNFJJPJ<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<TErr> EDHBBLAFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal readonly TErr MKEOCBLGCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal readonly TOk IHLLAGDBFIH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GHCONHKCIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x435CE70", Offset = "0x435B870", VA = "0x18435CE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool LJMMHPJAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x435A3B0", Offset = "0x4358DB0", VA = "0x18435A3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x435F060", Offset = "0x435DA60", VA = "0x18435F060")]
	internal DAOEJNFJJPJ(in TErr CAIOLBAJJDE, in TOk IOAABMLJGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4359200", Offset = "0x4357C00", VA = "0x184359200")]
	public static global::DAOEJNFJJPJ<TOk, TErr> DDLMDAJNABJ(in TErr CAIOLBAJJDE)
	{
		return default(global::DAOEJNFJJPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x435C430", Offset = "0x435AE30", VA = "0x18435C430")]
	public static global::DAOEJNFJJPJ<TOk, TErr> LMAKNPMNEOM(in TOk IOAABMLJGAJ)
	{
		return default(global::DAOEJNFJJPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x347D890", Offset = "0x347C290", VA = "0x18347D890")]
	public global::DAOEJNFJJPJ<UOk?, TErr?> ICKDMCNAKIM<UOk>()
	{
		return default(global::DAOEJNFJJPJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x347DC00", Offset = "0x347C600", VA = "0x18347DC00")]
	public global::DAOEJNFJJPJ<UOk?, TErr?> KHKBPGDCEDO<UOk>()
	{
		return default(global::DAOEJNFJJPJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x347D550", Offset = "0x347BF50", VA = "0x18347D550")]
	public global::DAOEJNFJJPJ<TOk?, UErr?> HELHDBJCCKD<UErr>()
	{
		return default(global::DAOEJNFJJPJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x435C9F0", Offset = "0x435B3F0", VA = "0x18435C9F0")]
	public global::DAOEJNFJJPJ<LEKKGHCNCEK, TErr> LMCJACFEOCP()
	{
		return default(global::DAOEJNFJJPJ<LEKKGHCNCEK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4359740", Offset = "0x4358140", VA = "0x184359740")]
	public static bool ENMIHMCKBEN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5480", Offset = "0x6F4880")] in global::DAOEJNFJJPJ<TOk, TErr> BBDDOKEDLCI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F54F0", Offset = "0x6F48F0")] in global::DAOEJNFJJPJ<TOk, TErr> NAHMKAGEEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x435A820", Offset = "0x4359220", VA = "0x18435A820", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5560", Offset = "0x6F4960")] global::DAOEJNFJJPJ<TOk, TErr> EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x435AB60", Offset = "0x4359560", VA = "0x18435AB60", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x435C280", Offset = "0x435AC80", VA = "0x18435C280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x435E060", Offset = "0x435CA60", VA = "0x18435E060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ACHKBBDBAKH
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2549090", Offset = "0x2547A90", VA = "0x182549090")]
	public static global::DAOEJNFJJPJ<TOk?, TErr?> IHLLAGDBFIH<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5600", Offset = "0x6F4A00")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB, in TOk IOAABMLJGAJ)
	{
		return default(global::DAOEJNFJJPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2549100", Offset = "0x2547B00", VA = "0x182549100")]
	public static global::DAOEJNFJJPJ<LEKKGHCNCEK, TErr?> IHLLAGDBFIH<TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F56A0", Offset = "0x6F4AA0")] this in global::DAOEJNFJJPJ<LEKKGHCNCEK, TErr?> IKHBPJOEIEB)
	{
		return default(global::DAOEJNFJJPJ<LEKKGHCNCEK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2549090", Offset = "0x2547A90", VA = "0x182549090")]
	public static global::DAOEJNFJJPJ<TOk?, TErr?> MKEOCBLGCJI<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5710", Offset = "0x6F4B10")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB, in TErr CAIOLBAJJDE)
	{
		return default(global::DAOEJNFJJPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x254A6E0", Offset = "0x25490E0", VA = "0x18254A6E0")]
	public static TOk? LADDDPHOPME<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5780", Offset = "0x6F4B80")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x25496E0", Offset = "0x25480E0", VA = "0x1825496E0")]
	[AsyncStateMachine(typeof(GCMOKFNONBC))]
	public static Task<TOk?>? JABFILJAMCC<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5860", Offset = "0x6F4C60")] this Task<global::DAOEJNFJJPJ<TOk?, TErr?>>? IKHBPJOEIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x254A750", Offset = "0x2549150", VA = "0x18254A750")]
	public static TErr? LKOHLHGJHCO<TErr, TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F58C0", Offset = "0x6F4CC0")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2549AF0", Offset = "0x25484F0", VA = "0x182549AF0")]
	public static bool KGMOEBNPNOJ<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5930", Offset = "0x6F4D30")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F59A0", Offset = "0x6F4DA0")] out global::DAOEJNFJJPJ<UOk?, UErr?> MNHIEJEANPB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2549AB0", Offset = "0x25484B0", VA = "0x182549AB0")]
	public static bool KEKILGLONPK<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5A00", Offset = "0x6F4E00")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB, [OFMILDPNIPJ(true)] out TOk IOAABMLJGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2549050", Offset = "0x2547A50", VA = "0x182549050")]
	public static bool HOHBBBODJIN<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5AB0", Offset = "0x6F4EB0")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB, [OFMILDPNIPJ(true)] out TErr CAIOLBAJJDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2548F70", Offset = "0x2547970", VA = "0x182548F70")]
	public static bool EKPNFDEGPHF<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5B60", Offset = "0x6F4F60")] this in global::DAOEJNFJJPJ<TOk, TErr> IKHBPJOEIEB, [OFMILDPNIPJ(true)] out TOk IOAABMLJGAJ, [OFMILDPNIPJ(false)] out TErr CAIOLBAJJDE) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2548AF0", Offset = "0x25474F0", VA = "0x182548AF0")]
	public static bool BOMCAJOKKNG<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5BD0", Offset = "0x6F4FD0")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB, [OFMILDPNIPJ(true)] out TOk IOAABMLJGAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5C40", Offset = "0x6F5040")] out global::DAOEJNFJJPJ<TOk?, TErr?> MNHIEJEANPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2549C10", Offset = "0x2548610", VA = "0x182549C10")]
	public static bool KGMOEBNPNOJ<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5CA0", Offset = "0x6F50A0")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB, [OFMILDPNIPJ(true)] out TOk IOAABMLJGAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5D10", Offset = "0x6F5110")] out global::DAOEJNFJJPJ<UOk?, UErr?> MNHIEJEANPB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2548C70", Offset = "0x2547670", VA = "0x182548C70")]
	public static bool CHPCOKCJJCO<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5D70", Offset = "0x6F5170")] this in global::DAOEJNFJJPJ<TOk?, TErr?> IKHBPJOEIEB, [OFMILDPNIPJ(true)] out TOk IOAABMLJGAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5DE0", Offset = "0x6F51E0")] out global::DAOEJNFJJPJ<LEKKGHCNCEK, TErr?> MNHIEJEANPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25493E0", Offset = "0x2547DE0", VA = "0x1825493E0")]
	public static global::DAOEJNFJJPJ<UOk, UErr> IIANOKPGOKI<UOk, UErr, TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5E40", Offset = "0x6F5240")] this in global::DAOEJNFJJPJ<TOk, TErr> IKHBPJOEIEB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5EB0", Offset = "0x6F52B0")] in global::DAOEJNFJJPJ<UOk, UErr> NHAGEBCMLPC) where TOk : UOk where TErr : UErr
	{
		return default(global::DAOEJNFJJPJ<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x254A8A0", Offset = "0x25492A0", VA = "0x18254A8A0")]
	public static global::DAOEJNFJJPJ<TOk?[]?, TErr?> MEOEOGDJHOP<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5F20", Offset = "0x6F5320")] this IEnumerable<global::DAOEJNFJJPJ<TOk?, TErr?>>? IKHBPJOEIEB)
	{
		return default(global::DAOEJNFJJPJ<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2548FD0", Offset = "0x25479D0", VA = "0x182548FD0")]
	[IteratorStateMachine(typeof(OACGLLKHMFE))]
	public static IEnumerable<TOk?>? HGGGCGGFPFB<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5FF0", Offset = "0x6F53F0")] this IEnumerable<global::DAOEJNFJJPJ<TOk?, TErr?>>? IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IDDDLBIKOGO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x355F160", Offset = "0x355DB60", VA = "0x18355F160")]
	public static global::DAOEJNFJJPJ<TOk, T> IHLLAGDBFIH<TOk>(in TOk IOAABMLJGAJ) where TOk : notnull
	{
		return default(global::DAOEJNFJJPJ<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4069200", Offset = "0x4067C00", VA = "0x184069200")]
	public static global::DAOEJNFJJPJ<LEKKGHCNCEK, T> IHLLAGDBFIH()
	{
		return default(global::DAOEJNFJJPJ<LEKKGHCNCEK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x355F160", Offset = "0x355DB60", VA = "0x18355F160")]
	public static global::DAOEJNFJJPJ<T, TErr> MKEOCBLGCJI<TErr>(in TErr CAIOLBAJJDE) where TErr : notnull
	{
		return default(global::DAOEJNFJJPJ<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public sealed class APBOBBIPBGH<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private readonly struct OHMCJDPKLJC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly global::APBOBBIPBGH<T> HAMBBNLBAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly int BOIKABNPPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly bool LBGFKPNOEDJ;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x866E70", Offset = "0x865870", VA = "0x180866E70")]
		public OHMCJDPKLJC(global::APBOBBIPBGH<T> NPGEFAIHGBA, int OINNHOOPEHN, bool EBOEGMHLMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBD80", Offset = "0x3EDA780", VA = "0x183EDBD80")]
		public global::APBOBBIPBGH<T>.GLEOJDALDOE ODEOKNNCFHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBE70", Offset = "0x3EDA870", VA = "0x183EDBE70", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBE70", Offset = "0x3EDA870", VA = "0x183EDBE70", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class GLEOJDALDOE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::APBOBBIPBGH<T> HAMBBNLBAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly int PCLMGDFLHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int OPECHONDHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly bool LBGFKPNOEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool BNIPAIONDIA;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T LEJKACPKMMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3FF45B0", Offset = "0x3FF2FB0", VA = "0x183FF45B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x3FF47D0", Offset = "0x3FF31D0", VA = "0x183FF47D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4830", Offset = "0x3FF3230", VA = "0x183FF4830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4B50", Offset = "0x3FF3550", VA = "0x183FF4B50")]
		public GLEOJDALDOE(global::APBOBBIPBGH<T> NPGEFAIHGBA, int OINNHOOPEHN, bool EBOEGMHLMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4650", Offset = "0x3FF3050", VA = "0x183FF4650", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3FF46D0", Offset = "0x3FF30D0", VA = "0x183FF46D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AIJOKOPFKGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F60E0", Offset = "0x6F54E0")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public AIJOKOPFKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6E60", Offset = "0x3CA5860", VA = "0x183CA6E60")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly T[] AIGDELJGGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int OPECHONDHCE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MDJAPEPENON
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x475DEC0", Offset = "0x475C8C0", VA = "0x18475DEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T LEJKACPKMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3817280", Offset = "0x3815C80", VA = "0x183817280")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T FELGMGCNPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x475E150", Offset = "0x475CB50", VA = "0x18475E150")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x475E020", Offset = "0x475CA20", VA = "0x18475E020")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int ANNFCHOJNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA7B980", Offset = "0xA7A380", VA = "0x180A7B980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x475E130", Offset = "0x475CB30", VA = "0x18475E130")]
	private static int KEOLHEFCKHN(int ALJOMNDNEBM, int GIDABKFIKCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x475E200", Offset = "0x475CC00", VA = "0x18475E200")]
	public APBOBBIPBGH(int IMMPKDAEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x475E280", Offset = "0x475CC80", VA = "0x18475E280")]
	public APBOBBIPBGH(int IMMPKDAEONJ, Func<T> LIJDMPCOJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x475E610", Offset = "0x475D010", VA = "0x18475E610")]
	public APBOBBIPBGH(T[] FGILJLADPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x475DE90", Offset = "0x475C890", VA = "0x18475DE90")]
	public void CDLINFIFODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x475E080", Offset = "0x475CA80", VA = "0x18475E080")]
	public IEnumerable<T> JDGMGOIAPFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x475E180", Offset = "0x475CB80", VA = "0x18475E180")]
	public global::APBOBBIPBGH<T>.GLEOJDALDOE ODEOKNNCFHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x347CDC0", Offset = "0x347B7C0", VA = "0x18347CDC0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x347CDC0", Offset = "0x347B7C0", VA = "0x18347CDC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class NPCPPKDILLE
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x367D760", Offset = "0x367C160", VA = "0x18367D760")]
	public static global::APBOBBIPBGH<T> IDLIIDOEAFG<T>(int IMMPKDAEONJ, Func<T> LIJDMPCOJNO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MDALCHIADDA<TData> : MIKMJPNAIIO where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly string PDFPEKEFLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly TData LAEHDPABEIH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
	public override string ODHCPOFFIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x467CE80", Offset = "0x467B880", VA = "0x18467CE80")]
	internal MDALCHIADDA(string MDEEJIBNIAD, in TData MNILNHMNKJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class OPGIJNJGNKK
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB090", Offset = "0x6AB9A90", VA = "0x186ABB090")]
	public static global::MDALCHIADDA<LEKKGHCNCEK> IDLIIDOEAFG(string MDEEJIBNIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x30CB000", Offset = "0x30C9A00", VA = "0x1830CB000")]
	public static global::MDALCHIADDA<TData> IDLIIDOEAFG<TData>(string MDEEJIBNIAD, in TData MNILNHMNKJK) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FPIFLAACMNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Dictionary<object, float> AHKMGODEDKL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float PLKCMGMHLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAEC0F0", Offset = "0xAEAAF0", VA = "0x180AEC0F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAEC100", Offset = "0xAEAB00", VA = "0x180AEC100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8940", Offset = "0x6AB7340", VA = "0x186AB8940")]
	public void FMHGDPNPEHP(float MFBGAMJDOKA, object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8AD0", Offset = "0x6AB74D0", VA = "0x186AB8AD0")]
	public void NHIFDNAHCNB(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB89B0", Offset = "0x6AB73B0", VA = "0x186AB89B0")]
	private void KPFEAOBEOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8B40", Offset = "0x6AB7540", VA = "0x186AB8B40")]
	public FPIFLAACMNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MLJMKOJHCLB
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JINHNGHOOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public JINHNGHOOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB97A0", Offset = "0x6AB81A0", VA = "0x186AB97A0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6140", Offset = "0x6F5540")]
	private HashSet<object> GJLENILPINE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IReadOnlyCollection<object> FBHCFIEFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6ABAB70", Offset = "0x6AB9570", VA = "0x186ABAB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool AODGJLFDBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6ABA960", Offset = "0x6AB9360", VA = "0x186ABA960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x767540", Offset = "0x765F40", VA = "0x180767540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAA80", Offset = "0x6AB9480", VA = "0x186ABAA80")]
	public bool IFPOOIAJHAI(object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA9E0", Offset = "0x6AB93E0", VA = "0x186ABA9E0")]
	public bool HEOHJOBENDL(object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA900", Offset = "0x6AB9300", VA = "0x186ABA900")]
	public bool AAFBPIPDPOL(object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA970", Offset = "0x6AB9370", VA = "0x186ABA970")]
	public void FKHFGNJIMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAC40", Offset = "0x6AB9640", VA = "0x186ABAC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public MLJMKOJHCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class INFEPAMAGFB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct PMJMGPAGOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float IFBAKPAONCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public T ONBMIOJBCHK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F61A0", Offset = "0x6F55A0")]
	private readonly Dictionary<object, global::INFEPAMAGFB<T>.PMJMGPAGOIL> AHKMGODEDKL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public virtual T GEKMANGOLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1E361B0", Offset = "0x1E34BB0", VA = "0x181E361B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x26BB380", Offset = "0x26B9D80", VA = "0x1826BB380", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public object? GEAAEEENPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool ECDKDGMLFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x32C3960", Offset = "0x32C2360", VA = "0x1832C3960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x32C3790", Offset = "0x32C2190", VA = "0x1832C3790")]
	public bool FMHGDPNPEHP(T MFBGAMJDOKA, object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x32C5250", Offset = "0x32C3C50", VA = "0x1832C5250")]
	public bool NHIFDNAHCNB(object HMAOAMDKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3148250", Offset = "0x3146C50", VA = "0x183148250")]
	public void PDOAHDCGLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x32C3A00", Offset = "0x32C2400", VA = "0x1832C3A00")]
	public bool JBPBACKGAAO(object HMAOAMDKNDD, out T MFBGAMJDOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x32C3F30", Offset = "0x32C2930", VA = "0x1832C3F30")]
	private bool LIGMKANNBAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x32C52B0", Offset = "0x32C3CB0", VA = "0x1832C52B0")]
	public INFEPAMAGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MJHLKKEGOKC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KCEPJJCHDOP IACJMBANPAE;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HAEDIPOOPOK : MJHLKKEGOKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public readonly struct HCLKGNIJGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly float AJFOCJFBCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly float JJLPJHMCCFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal readonly bool GGNGOEANAEK;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float PMGBHJMMFFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6AB94D0", Offset = "0x6AB7ED0", VA = "0x186AB94D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9660", Offset = "0x6AB8060", VA = "0x186AB9660")]
		public HCLKGNIJGGK(float ONAOKOFPGLK, float PCPMBKDCIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6AB94E0", Offset = "0x6AB7EE0", VA = "0x186AB94E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class POHEKIBBHCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public HAEDIPOOPOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public POHEKIBBHCI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly int ICKPJJPJOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int ENCDBBBPMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly MJHLKKEGOKC[] GCHGLJGELNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly KCEPJJCHDOP[] FAMLIKPHPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly HCLKGNIJGGK[] EBIKAGABLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private HCLKGNIJGGK BPAKJENHLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly NAMIMOJBOGM JEKANBDPCDM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float EAHGGLGEJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8C80", Offset = "0x6AB7680", VA = "0x186AB8C80", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KCEPJJCHDOP IACJMBANPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9290", Offset = "0x6AB7C90", VA = "0x186AB9290", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8BC0", Offset = "0x6AB75C0", VA = "0x186AB8BC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9350", Offset = "0x6AB7D50", VA = "0x186AB9350")]
	public HAEDIPOOPOK(int ICKPJJPJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8DB0", Offset = "0x6AB77B0", VA = "0x186AB8DB0")]
	public NAMIMOJBOGM EKMMGABDCMB(HCLKGNIJGGK ELHMOBCGDNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8E40", Offset = "0x6AB7840", VA = "0x186AB8E40")]
	public void OBAJJEHNFCC(MJHLKKEGOKC BHBBBEPOJGF, [Optional] HCLKGNIJGGK LFEOFNOFGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8CA0", Offset = "0x6AB76A0", VA = "0x186AB8CA0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public delegate void KCEPJJCHDOP(float GOHAMNOOEHJ);
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FPAOOOGBMFP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class JMEGOJBNGAH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly MJHLKKEGOKC NOGMCLPNNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly KCEPJJCHDOP KFICNKMCGGK;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB98A0", Offset = "0x6AB82A0", VA = "0x186AB98A0")]
		public JMEGOJBNGAH(MJHLKKEGOKC NOGMCLPNNKB, KCEPJJCHDOP KFICNKMCGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9850", Offset = "0x6AB8250", VA = "0x186AB9850", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8800", Offset = "0x6AB7200", VA = "0x186AB8800")]
	internal static bool CJKIIMHFOFK(float MGFKDMJBGAK, float LPDJCHOFJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C100", Offset = "0x1E2AB00", VA = "0x181E2C100")]
	internal static float JLLFGJLFKDF(float MGFKDMJBGAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8880", Offset = "0x6AB7280", VA = "0x186AB8880")]
	public static IDisposable MNHFKJBDMKF(this MJHLKKEGOKC NOGMCLPNNKB, KCEPJJCHDOP KFICNKMCGGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NAMIMOJBOGM : MJHLKKEGOKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private float GOHAMNOOEHJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float EAHGGLGEJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAEC0F0", Offset = "0xAEAAF0", VA = "0x180AEC0F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6ABAF40", Offset = "0x6AB9940", VA = "0x186ABAF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KCEPJJCHDOP? IACJMBANPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6ABAEA0", Offset = "0x6AB98A0", VA = "0x186ABAEA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6ABAE00", Offset = "0x6AB9800", VA = "0x186ABAE00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NAMIMOJBOGM()
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
