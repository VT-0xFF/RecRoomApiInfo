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
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4F70", Offset = "0x6AE3D70", VA = "0x186AE4F70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NGKOBNMFLPP<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::HENINDMIAPN<TKey, TVal> IMGAOCIOGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4130", Offset = "0x6E3530")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FMIKLOKKDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int KBGLJKKNKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4200", Offset = "0x6E3600")]
	private readonly global::HENINDMIAPN<TKey, TVal>.JDELHBLJGDE ECEBIINBLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int FDICBBIABIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal int EKFJGBMCKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x31B5ED0", Offset = "0x31B4CD0", VA = "0x1831B5ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DGLKHMNKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x740010", Offset = "0x73EE10", VA = "0x180740010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x31B6540", Offset = "0x31B5340", VA = "0x1831B6540")]
	public NGKOBNMFLPP(int KBGLJKKNKCK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4260", Offset = "0x6E3660")] global::HENINDMIAPN<TKey, TVal>.JDELHBLJGDE ECEBIINBLAE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E42C0", Offset = "0x6E36C0")] IEqualityComparer<TKey> NJMLBDIJBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x31B6180", Offset = "0x31B4F80", VA = "0x1831B6180")]
	public void KCHEDGEKLGG(TKey JHANOPJHOLP, TVal MGFMONLLLPD, bool ANHPCDOPFKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x31B62F0", Offset = "0x31B50F0", VA = "0x1831B62F0")]
	public bool MAPNLLNJFDI(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x31B5F10", Offset = "0x31B4D10", VA = "0x1831B5F10")]
	public bool BOAPLFBFGDK(TKey APNLOIIAPBF, out TVal MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x31B5FC0", Offset = "0x31B4DC0", VA = "0x1831B5FC0")]
	private void GPLHLOFBFFK(TKey JHANOPJHOLP, TVal MGFMONLLLPD, int MKGODNJCKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x31B6370", Offset = "0x31B5170", VA = "0x1831B6370")]
	public bool MNKHABCKDEI(TKey JHANOPJHOLP, TVal MGFMONLLLPD, bool ANHPCDOPFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x31B64A0", Offset = "0x31B52A0", VA = "0x1831B64A0")]
	private bool NJAKKDOCFGJ(TKey JHANOPJHOLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class HENINDMIAPN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate int JDELHBLJGDE(TKey JHANOPJHOLP, TVal MGFMONLLLPD);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class NCCGNPPIHJC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public TKey MPJCJINPOHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD5A960", Offset = "0xD59760", VA = "0x180D5A960")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TVal KCKILJPPPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int OGFGLCKEPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762140", VA = "0x180763340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9DFFF0", Offset = "0x9DEDF0", VA = "0x1809DFFF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DateTime OFGPCLKECGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xE3F730", Offset = "0xE3E530", VA = "0x180E3F730")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x31AB390", Offset = "0x31AA190", VA = "0x1831AB390")]
		public NCCGNPPIHJC(TKey JHANOPJHOLP, TVal MMAFFACGBGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IAJLFFKHCEO : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E49B0", Offset = "0x6E3DB0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::HENINDMIAPN<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4A10", Offset = "0x6E3E10")]
		private LinkedList<global::HENINDMIAPN<TKey, TVal>.NCCGNPPIHJC>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x116B780", Offset = "0x116A580", VA = "0x18116B780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1DF44C0", Offset = "0x1DF32C0", VA = "0x181DF44C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D036E0", Offset = "0x1D024E0", VA = "0x181D036E0")]
		[DebuggerHidden]
		public IAJLFFKHCEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4510", Offset = "0x1DF3310", VA = "0x181DF4510", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DF3900", Offset = "0x1DF2700", VA = "0x181DF3900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DF48F0", Offset = "0x1DF36F0", VA = "0x181DF48F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1DF43F0", Offset = "0x1DF31F0", VA = "0x181DF43F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public const int BPBLFJFFIAL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4380", Offset = "0x6E3780")]
	private readonly Dictionary<TKey, LinkedListNode<global::HENINDMIAPN<TKey, TVal>.NCCGNPPIHJC>> AAAIEHLJJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E43E0", Offset = "0x6E37E0")]
	private readonly LinkedList<global::HENINDMIAPN<TKey, TVal>.NCCGNPPIHJC> EJGJBPIBANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4440", Offset = "0x6E3840")]
	private readonly global::HENINDMIAPN<TKey, TVal>.JDELHBLJGDE ECEBIINBLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly TimeSpan EKLHGAHIAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly GHJJELLJAPK JJLDMEDECIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool IJJONIGPKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TKey> JKJCMKOHCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TVal> NPKOFPALCBH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DGLKHMNKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x740020", Offset = "0x73EE20", VA = "0x180740020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal int EKFJGBMCKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x97E740", Offset = "0x97D540", VA = "0x18097E740")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x97E8E0", Offset = "0x97D6E0", VA = "0x18097E8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2762F90", Offset = "0x2761D90", VA = "0x182762F90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TVal> DAGPLHDNNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x323EAD0", Offset = "0x323D8D0", VA = "0x18323EAD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ICollection<TKey> IDictionary<TKey, TVal>.BJAEJMFFCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x323CDD0", Offset = "0x323BBD0", VA = "0x18323CDD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TVal BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x323EA60", Offset = "0x323D860", VA = "0x18323EA60", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x323EB40", Offset = "0x323D940", VA = "0x18323EB40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x323B680", Offset = "0x323A480", VA = "0x18323B680")]
	private bool JFELLIFCGLO(int JNGKGNOBDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x323A300", Offset = "0x3239100", VA = "0x18323A300")]
	private void GMOKBBCCKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x323E090", Offset = "0x323CE90", VA = "0x18323E090")]
	public HENINDMIAPN(int JNGKGNOBDKI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E44A0", Offset = "0x6E38A0")] global::HENINDMIAPN<TKey, TVal>.JDELHBLJGDE ECEBIINBLAE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4500", Offset = "0x6E3900")] IEqualityComparer<TKey> NJMLBDIJBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x323D460", Offset = "0x323C260", VA = "0x18323D460")]
	public HENINDMIAPN(int JNGKGNOBDKI, TimeSpan EKLHGAHIAID, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4560", Offset = "0x6E3960")] IEqualityComparer<TKey?>? NJMLBDIJBCD, [Optional] GHJJELLJAPK? JJLDMEDECIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x323E6B0", Offset = "0x323D4B0", VA = "0x18323E6B0")]
	public HENINDMIAPN(int JNGKGNOBDKI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E45C0", Offset = "0x6E39C0")] global::HENINDMIAPN<TKey?, TVal?>.JDELHBLJGDE? ECEBIINBLAE, TimeSpan EKLHGAHIAID, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4620", Offset = "0x6E3A20")] IEqualityComparer<TKey?>? NJMLBDIJBCD, [Optional] GHJJELLJAPK? JJLDMEDECIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x323A2A0", Offset = "0x32390A0", VA = "0x18323A2A0")]
	public bool EBHJFLKDMOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3239AD0", Offset = "0x32388D0", VA = "0x183239AD0")]
	public bool DCOKJGGHIKJ(int MKGODNJCKOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x323B910", Offset = "0x323A710", VA = "0x18323B910")]
	public void KKNDJJJFEOO(TKey JHANOPJHOLP, TVal MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3237BC0", Offset = "0x32369C0", VA = "0x183237BC0", Slot = "14")]
	public void Add([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4680", Offset = "0x6E3A80")] KeyValuePair<TKey, TVal> PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3237A90", Offset = "0x3236890", VA = "0x183237A90", Slot = "9")]
	public void Add(TKey JHANOPJHOLP, TVal MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3238990", Offset = "0x3237790", VA = "0x183238990", Slot = "8")]
	public bool ContainsKey(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3238990", Offset = "0x3237790", VA = "0x183238990", Slot = "16")]
	public bool Contains([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E46E0", Offset = "0x6E3AE0")] KeyValuePair<TKey, TVal> PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x323CBE0", Offset = "0x323B9E0", VA = "0x18323CBE0", Slot = "10")]
	public bool Remove(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x323CD90", Offset = "0x323BB90", VA = "0x18323CD90", Slot = "18")]
	public bool Remove([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4740", Offset = "0x6E3B40")] KeyValuePair<TKey, TVal> PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3237CF0", Offset = "0x3236AF0", VA = "0x183237CF0")]
	private TVal BANNGLOAJDI(TKey APNLOIIAPBF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x323D0C0", Offset = "0x323BEC0", VA = "0x18323D0C0", Slot = "11")]
	public bool TryGetValue(TKey APNLOIIAPBF, out TVal MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32388C0", Offset = "0x32376C0", VA = "0x1832388C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3238AE0", Offset = "0x32378E0", VA = "0x183238AE0", Slot = "17")]
	public void CopyTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E47A0", Offset = "0x6E3BA0")] KeyValuePair<TKey, TVal>[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x323B9E0", Offset = "0x323A7E0", VA = "0x18323B9E0")]
	private bool NEGGPPAEAGP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4800", Offset = "0x6E3C00")] global::HENINDMIAPN<TKey, TVal>.NCCGNPPIHJC LBNKEEKMHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x323B3C0", Offset = "0x323A1C0", VA = "0x18323B3C0")]
	private void IAHEDJADKOD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4860", Offset = "0x6E3C60")] LinkedListNode<global::HENINDMIAPN<TKey, TVal>.NCCGNPPIHJC> LLLPBNELPLC, TVal IJHAJFKAPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x323C400", Offset = "0x323B200", VA = "0x18323C400")]
	private void NMBLHBILMPM(TKey JHANOPJHOLP, TVal MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3238200", Offset = "0x3237000", VA = "0x183238200")]
	private void CPLMCNDHACO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E48C0", Offset = "0x6E3CC0")] global::HENINDMIAPN<TKey, TVal>.NCCGNPPIHJC LBNKEEKMHJK, TVal IJHAJFKAPBA, int EPJNKNCDEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x323A870", Offset = "0x3239670", VA = "0x18323A870", Slot = "19")]
	[IteratorStateMachine(typeof(global::HENINDMIAPN<, >.IAJLFFKHCEO))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x26F5BB0", Offset = "0x26F49B0", VA = "0x1826F5BB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LJCIEFMECBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330")]
	public static LJCIEFMECBF EJPGKLALKON(Type LEDIIMFEFLP, [Optional] string? PBGEMHGLCHE, [Optional] string? MIFDGHHOCHL, bool LENNOGBMFPB = false)
	{
		return default(LJCIEFMECBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330")]
	public static LJCIEFMECBF EJPGKLALKON<T>([Optional] string? PBGEMHGLCHE, [Optional] string? MIFDGHHOCHL, bool LENNOGBMFPB = false)
	{
		return default(LJCIEFMECBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EPNNCCPNIMB
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate bool CDDMFKCNHEO(string PILGAPEKAPH, EPNNCCPNIMB PJBIDIGAIMJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public int MKKOHAABCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public string ADGCKEDHNLP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3C60", Offset = "0x6AE2A60", VA = "0x186AE3C60")]
	public static Dictionary<string, EPNNCCPNIMB> FIPPFBAMIMH(Type GPGFFDPHLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3F50", Offset = "0x6AE2D50", VA = "0x186AE3F50")]
	public static Dictionary<string, EPNNCCPNIMB> LMHLFDJIPPL(Type GPGFFDPHLAM, CDDMFKCNHEO DOINBBMHBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4280", Offset = "0x6AE3080", VA = "0x186AE4280")]
	public static Dictionary<int, string> PCKBFONKPLI(Dictionary<string, EPNNCCPNIMB> NFJHHMHDKEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MDPLBPNGKPK : CBJABNKIELI
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool NNBONJCCGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? ONMNGHEDOFM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public virtual CBJABNKIELI? HGFICGOFENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4E80", Offset = "0x6AE3C80", VA = "0x186AE4E80")]
	protected MDPLBPNGKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string HKMFFLPHOOE();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AE47E0", Offset = "0x6AE35E0", VA = "0x186AE47E0", Slot = "8")]
	public virtual string BJJENIMEBHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4980", Offset = "0x6AE3780", VA = "0x186AE4980", Slot = "9")]
	public void KCMPEAKIMGN(StringBuilder NELGNHHJHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4C20", Offset = "0x6AE3A20", VA = "0x186AE4C20", Slot = "10")]
	public void KNLBILJEKHH(StringBuilder NELGNHHJHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4860", Offset = "0x6AE3660", VA = "0x186AE4860", Slot = "11")]
	public void DLOIKBJGKAO(StringBuilder NELGNHHJHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4D20", Offset = "0x6AE3B20", VA = "0x186AE4D20", Slot = "12")]
	public void NAEBKPFJGOL(StringBuilder NELGNHHJHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4C80", Offset = "0x6AE3A80", VA = "0x186AE4C80")]
	public static void MEFEKAGHLGF(StringBuilder NELGNHHJHBG, string KIMCFMFLGJC, string PHHEPDJNCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xABEFD0", Offset = "0xABDDD0", VA = "0x180ABEFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DFLBNEFHGHN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3BF0", Offset = "0x6AE29F0", VA = "0x186AE3BF0")]
	public DFLBNEFHGHN(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HACNIGGBMKP<TErr> : DFLBNEFHGHN where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr CJCKAGLJNMG;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7C50", Offset = "0x3DA6A50", VA = "0x183DA7C50")]
	private HACNIGGBMKP(in TErr LGDLKIHNNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x35445B0", Offset = "0x35433B0", VA = "0x1835445B0")]
	public static global::HACNIGGBMKP<TErr> AIJMFKKLHCC(in TErr LGDLKIHNNHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CBJABNKIELI
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BJJENIMEBHC();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HKMFFLPHOOE();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CKDEBHLDJOO<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	TOptions KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GMEBAJNDELH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string BMCKFCBHKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CCNBJIJAAPC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3800", Offset = "0x6AE2600", VA = "0x186AE3800")]
	public CCNBJIJAAPC(string GPAOLHFLBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KEMGGALDCLA<TOk> : CCNBJIJAAPC where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly TOk CPPJCDDEALE;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2354000", Offset = "0x2352E00", VA = "0x182354000")]
	private KEMGGALDCLA(in TOk BNCOBEMIAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2353EC0", Offset = "0x2352CC0", VA = "0x182353EC0")]
	public static global::KEMGGALDCLA<TOk> AIJMFKKLHCC(in TOk BNCOBEMIAGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct AEGPCPFJGKN<TOk, TErr> : IEquatable<global::AEGPCPFJGKN<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<TErr> MIAJFIGNDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal readonly TErr CJCKAGLJNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal readonly TOk CPPJCDDEALE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GPBFAOOFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5780", Offset = "0x2BA4580", VA = "0x182BA5780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool EIBNKAOFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5E90", Offset = "0x2BA4C90", VA = "0x182BA5E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2BA60D0", Offset = "0x2BA4ED0", VA = "0x182BA60D0")]
	internal AEGPCPFJGKN(in TErr LGDLKIHNNHH, in TOk BNCOBEMIAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5E30", Offset = "0x2BA4C30", VA = "0x182BA5E30")]
	public static global::AEGPCPFJGKN<TOk, TErr> IIHIENKOEGD(in TErr LGDLKIHNNHH)
	{
		return default(global::AEGPCPFJGKN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5EE0", Offset = "0x2BA4CE0", VA = "0x182BA5EE0")]
	public static global::AEGPCPFJGKN<TOk, TErr> JHNAKFBPLGP(in TOk BNCOBEMIAGA)
	{
		return default(global::AEGPCPFJGKN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27190B0", Offset = "0x2717EB0", VA = "0x1827190B0")]
	public global::AEGPCPFJGKN<UOk?, TErr?> LONODEALBLH<UOk>()
	{
		return default(global::AEGPCPFJGKN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2719420", Offset = "0x2718220", VA = "0x182719420")]
	public global::AEGPCPFJGKN<UOk?, TErr?> PDOCMJNJKNM<UOk>()
	{
		return default(global::AEGPCPFJGKN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2718D70", Offset = "0x2717B70", VA = "0x182718D70")]
	public global::AEGPCPFJGKN<TOk?, UErr?> FGJFMKHLDHH<UErr>()
	{
		return default(global::AEGPCPFJGKN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA58B0", Offset = "0x2BA46B0", VA = "0x182BA58B0")]
	public global::AEGPCPFJGKN<JCKJOPOBLHO, TErr> CMMDLNPNCKL()
	{
		return default(global::AEGPCPFJGKN<JCKJOPOBLHO, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5950", Offset = "0x2BA4750", VA = "0x182BA5950")]
	public static bool EJGLOGBEPOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4B10", Offset = "0x6E3F10")] in global::AEGPCPFJGKN<TOk, TErr> CJCAMOJJGED, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4B80", Offset = "0x6E3F80")] in global::AEGPCPFJGKN<TOk, TErr> DDMHJAPFCFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5A70", Offset = "0x2BA4870", VA = "0x182BA5A70", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4BF0", Offset = "0x6E3FF0")] global::AEGPCPFJGKN<TOk, TErr> IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5BB0", Offset = "0x2BA49B0", VA = "0x182BA5BB0", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5D90", Offset = "0x2BA4B90", VA = "0x182BA5D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5F40", Offset = "0x2BA4D40", VA = "0x182BA5F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ALBEMNEGDKM
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x23008E0", Offset = "0x22FF6E0", VA = "0x1823008E0")]
	public static global::AEGPCPFJGKN<TOk?, TErr?> CPPJCDDEALE<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4C90", Offset = "0x6E4090")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK, in TOk BNCOBEMIAGA)
	{
		return default(global::AEGPCPFJGKN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x23009E0", Offset = "0x22FF7E0", VA = "0x1823009E0")]
	public static global::AEGPCPFJGKN<JCKJOPOBLHO, TErr?> CPPJCDDEALE<TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4D30", Offset = "0x6E4130")] this in global::AEGPCPFJGKN<JCKJOPOBLHO, TErr?> LCNEHOGIJPK)
	{
		return default(global::AEGPCPFJGKN<JCKJOPOBLHO, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x23008E0", Offset = "0x22FF6E0", VA = "0x1823008E0")]
	public static global::AEGPCPFJGKN<TOk?, TErr?> CJCKAGLJNMG<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4DA0", Offset = "0x6E41A0")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK, in TErr LGDLKIHNNHH)
	{
		return default(global::AEGPCPFJGKN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x23013A0", Offset = "0x23001A0", VA = "0x1823013A0")]
	public static TOk? HDAKGCAPOFB<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4E10", Offset = "0x6E4210")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2302530", Offset = "0x2301330", VA = "0x182302530")]
	[AsyncStateMachine(typeof(IJDKBKALEEB))]
	public static Task<TOk?>? PADFDMFHOHN<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4EF0", Offset = "0x6E42F0")] this Task<global::AEGPCPFJGKN<TOk?, TErr?>>? LCNEHOGIJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2302340", Offset = "0x2301140", VA = "0x182302340")]
	public static TErr? MAPNIPADFDD<TErr, TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4F50", Offset = "0x6E4350")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2301930", Offset = "0x2300730", VA = "0x182301930")]
	public static bool JMPJICJGPOD<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4FC0", Offset = "0x6E43C0")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5030", Offset = "0x6E4430")] out global::AEGPCPFJGKN<UOk?, UErr?> LIPMAJMCOFG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2302300", Offset = "0x2301100", VA = "0x182302300")]
	public static bool KGNICOMILDH<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5090", Offset = "0x6E4490")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK, [LBBFCMALCPB(true)] out TOk BNCOBEMIAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2301060", Offset = "0x22FFE60", VA = "0x182301060")]
	public static bool ELPMDHJDLHP<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5140", Offset = "0x6E4540")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK, [LBBFCMALCPB(true)] out TErr LGDLKIHNNHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x23024D0", Offset = "0x23012D0", VA = "0x1823024D0")]
	public static bool OEMAIACPPJJ<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E51F0", Offset = "0x6E45F0")] this in global::AEGPCPFJGKN<TOk, TErr> LCNEHOGIJPK, [LBBFCMALCPB(true)] out TOk BNCOBEMIAGA, [LBBFCMALCPB(false)] out TErr LGDLKIHNNHH) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x23010A0", Offset = "0x22FFEA0", VA = "0x1823010A0")]
	public static bool GJHHHOOALNH<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5260", Offset = "0x6E4660")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK, [LBBFCMALCPB(true)] out TOk BNCOBEMIAGA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E52D0", Offset = "0x6E46D0")] out global::AEGPCPFJGKN<TOk?, TErr?> LIPMAJMCOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2301A50", Offset = "0x2300850", VA = "0x182301A50")]
	public static bool JMPJICJGPOD<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5330", Offset = "0x6E4730")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK, [LBBFCMALCPB(true)] out TOk BNCOBEMIAGA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E53A0", Offset = "0x6E47A0")] out global::AEGPCPFJGKN<UOk?, UErr?> LIPMAJMCOFG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2300AF0", Offset = "0x22FF8F0", VA = "0x182300AF0")]
	public static bool DCOHNGHCDMK<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5400", Offset = "0x6E4800")] this in global::AEGPCPFJGKN<TOk?, TErr?> LCNEHOGIJPK, [LBBFCMALCPB(true)] out TOk BNCOBEMIAGA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5470", Offset = "0x6E4870")] out global::AEGPCPFJGKN<JCKJOPOBLHO, TErr?> LIPMAJMCOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2301520", Offset = "0x2300320", VA = "0x182301520")]
	public static global::AEGPCPFJGKN<UOk, UErr> HGCEINADKLH<UOk, UErr, TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E54D0", Offset = "0x6E48D0")] this in global::AEGPCPFJGKN<TOk, TErr> LCNEHOGIJPK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5540", Offset = "0x6E4940")] in global::AEGPCPFJGKN<UOk, UErr> IDKOCJBGGJO) where TOk : UOk where TErr : UErr
	{
		return default(global::AEGPCPFJGKN<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2300DB0", Offset = "0x22FFBB0", VA = "0x182300DB0")]
	public static global::AEGPCPFJGKN<TOk?[]?, TErr?> EDFDKKCAILO<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E55B0", Offset = "0x6E49B0")] this IEnumerable<global::AEGPCPFJGKN<TOk?, TErr?>>? LCNEHOGIJPK)
	{
		return default(global::AEGPCPFJGKN<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x16620D0", Offset = "0x1660ED0", VA = "0x1816620D0")]
	[IteratorStateMachine(typeof(NJDNKFDPDBM))]
	public static IEnumerable<TOk?>? HBCCOKBBAOJ<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5670", Offset = "0x6E4A70")] this IEnumerable<global::AEGPCPFJGKN<TOk?, TErr?>>? LCNEHOGIJPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PEIBKHPMFOE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1BF9150", Offset = "0x1BF7F50", VA = "0x181BF9150")]
	public static global::AEGPCPFJGKN<TOk, T> CPPJCDDEALE<TOk>(in TOk BNCOBEMIAGA) where TOk : notnull
	{
		return default(global::AEGPCPFJGKN<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2000C50", Offset = "0x1FFFA50", VA = "0x182000C50")]
	public static global::AEGPCPFJGKN<JCKJOPOBLHO, T> CPPJCDDEALE()
	{
		return default(global::AEGPCPFJGKN<JCKJOPOBLHO, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1BF9150", Offset = "0x1BF7F50", VA = "0x181BF9150")]
	public static global::AEGPCPFJGKN<T, TErr> CJCKAGLJNMG<TErr>(in TErr LGDLKIHNNHH) where TErr : notnull
	{
		return default(global::AEGPCPFJGKN<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public sealed class HCFFOFCFHIL<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private readonly struct GMHBACCMGCO : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly global::HCFFOFCFHIL<T> AMJKAHLBPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly int OOBAIECABAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly bool GOOPCANEIMB;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x38BE070", Offset = "0x38BCE70", VA = "0x1838BE070")]
		public GMHBACCMGCO(global::HCFFOFCFHIL<T> FFDAOJPJGNO, int CCENHGMMINB, bool APFFHHLMHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x38BDF40", Offset = "0x38BCD40", VA = "0x1838BDF40")]
		public global::HCFFOFCFHIL<T>.HCNPABMNNIA NEACBAFBFJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x38BE030", Offset = "0x38BCE30", VA = "0x1838BE030", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x38BE030", Offset = "0x38BCE30", VA = "0x1838BE030", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class HCNPABMNNIA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::HCFFOFCFHIL<T> AMJKAHLBPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly int MHIBGNONPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int JMCKEOMPNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly bool GOOPCANEIMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool MIEDECLIBGK;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T OAFAFEDHHDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3DBDC20", Offset = "0x3DBCA20", VA = "0x183DBDC20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x3DBDD10", Offset = "0x3DBCB10", VA = "0x183DBDD10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3DBE010", Offset = "0x3DBCE10", VA = "0x183DBE010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE4F0", Offset = "0x3DBD2F0", VA = "0x183DBE4F0")]
		public HCNPABMNNIA(global::HCFFOFCFHIL<T> FFDAOJPJGNO, int CCENHGMMINB, bool APFFHHLMHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DBDC70", Offset = "0x3DBCA70", VA = "0x183DBDC70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3DBDCF0", Offset = "0x3DBCAF0", VA = "0x183DBDCF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KLKGKJEKECA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5760", Offset = "0x6E4B60")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public KLKGKJEKECA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x30137F0", Offset = "0x30125F0", VA = "0x1830137F0")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly T[] DFEJCPECIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int JMCKEOMPNLH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int GGEMOOCCBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD350", Offset = "0x3DBC150", VA = "0x183DBD350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T OAFAFEDHHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2E14340", Offset = "0x2E13140", VA = "0x182E14340")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T IAEBPIKIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD040", Offset = "0x3DBBE40", VA = "0x183DBD040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD150", Offset = "0x3DBBF50", VA = "0x183DBD150")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int GOGPPCBDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x916280", Offset = "0x915080", VA = "0x180916280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD390", Offset = "0x3DBC190", VA = "0x183DBD390")]
	private static int PNJLAGMKNIF(int NNHNOIMLALG, int PFLGNDMCMIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD620", Offset = "0x3DBC420", VA = "0x183DBD620")]
	public HCFFOFCFHIL(int MKGODNJCKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD3B0", Offset = "0x3DBC1B0", VA = "0x183DBD3B0")]
	public HCFFOFCFHIL(int MKGODNJCKOC, Func<T> PNLMMOEDGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD6A0", Offset = "0x3DBC4A0", VA = "0x183DBD6A0")]
	public HCFFOFCFHIL(T[] BFGFBJNNCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD120", Offset = "0x3DBBF20", VA = "0x183DBD120")]
	public void FOEBHDHNFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD070", Offset = "0x3DBBE70", VA = "0x183DBD070")]
	public IEnumerable<T> CNAALMNLNAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD2D0", Offset = "0x3DBC0D0", VA = "0x183DBD2D0")]
	public global::HCFFOFCFHIL<T>.HCNPABMNNIA NEACBAFBFJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2351080", Offset = "0x234FE80", VA = "0x182351080", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2351080", Offset = "0x234FE80", VA = "0x182351080", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class PCHPMIBDHAA
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x27E23E0", Offset = "0x27E11E0", VA = "0x1827E23E0")]
	public static global::HCFFOFCFHIL<T> AIJMFKKLHCC<T>(int MKGODNJCKOC, Func<T> PNLMMOEDGON) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class JEFPFIEACCG<TData> : MDPLBPNGKPK where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly string GNOMDKEMEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly TData BPHPMBBMNOF;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
	public override string HKMFFLPHOOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F87210", Offset = "0x3F86010", VA = "0x183F87210")]
	internal JEFPFIEACCG(string GPAOLHFLBHD, in TData MMJOHADFCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CHNIJOJGDKM
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3B80", Offset = "0x6AE2980", VA = "0x186AE3B80")]
	public static global::JEFPFIEACCG<JCKJOPOBLHO> AIJMFKKLHCC(string GPAOLHFLBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x16423D0", Offset = "0x16411D0", VA = "0x1816423D0")]
	public static global::JEFPFIEACCG<TData> AIJMFKKLHCC<TData>(string GPAOLHFLBHD, in TData MMJOHADFCHO) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CDAIOGKHLMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Dictionary<object, float> HOPLLDGEACD;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float NDGOKDGMLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x10A4E10", Offset = "0x10A3C10", VA = "0x1810A4E10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xE6F360", Offset = "0xE6E160", VA = "0x180E6F360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3A00", Offset = "0x6AE2800", VA = "0x186AE3A00")]
	public void NMBLHBILMPM(float MGFMONLLLPD, object AMBDKIOJFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3990", Offset = "0x6AE2790", VA = "0x186AE3990")]
	public void MNMLNGCEBNN(object AMBDKIOJFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3870", Offset = "0x6AE2670", VA = "0x186AE3870")]
	private void MIHPIOFHCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3A70", Offset = "0x6AE2870", VA = "0x186AE3A70")]
	public CDAIOGKHLMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EPJMNKPKPPF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DIHKGINCCCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public DIHKGINCCCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B05950", Offset = "0x2B04750", VA = "0x182B05950")]
		internal int <ToString>b__0(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E57C0", Offset = "0x6E4BC0")]
	private HashSet<T> AKILODLIDKE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IReadOnlyCollection<T> JHAPEKIKKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1055270", Offset = "0x1054070", VA = "0x181055270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool EMMNAOBCCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1055240", Offset = "0x1054040", VA = "0x181055240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB10", Offset = "0x7FB910", VA = "0x1807FCB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x10552C0", Offset = "0x10540C0", VA = "0x1810552C0")]
	public bool OEECIDDHIAM(T AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1055150", Offset = "0x1053F50", VA = "0x181055150")]
	public bool CJGLMEKHGBL(T AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1055290", Offset = "0x1054090", VA = "0x181055290")]
	public bool LDEEBLCAEDK(T AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x10553F0", Offset = "0x10541F0", VA = "0x1810553F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	public EPJMNKPKPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OLFJFONDFJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly string EHMJJDGDABB;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	public OLFJFONDFJE(string EHMJJDGDABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5000", Offset = "0x6AE3E00", VA = "0x186AE5000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BAHKENJLEMI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BIGADIFLGBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BIGADIFLGBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3750", Offset = "0x6AE2550", VA = "0x186AE3750")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5820", Offset = "0x6E4C20")]
	private HashSet<object> AKILODLIDKE;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyCollection<object> JHAPEKIKKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AE3300", Offset = "0x6AE2100", VA = "0x186AE3300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool EMMNAOBCCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE32F0", Offset = "0x6AE20F0", VA = "0x186AE32F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x741BD0", Offset = "0x7409D0", VA = "0x180741BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB10", Offset = "0x7FB910", VA = "0x1807FCB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3430", Offset = "0x6AE2230", VA = "0x186AE3430")]
	public bool OEECIDDHIAM(object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3250", Offset = "0x6AE2050", VA = "0x186AE3250")]
	public bool CJGLMEKHGBL(object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AE33D0", Offset = "0x6AE21D0", VA = "0x186AE33D0")]
	public bool LDEEBLCAEDK(object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3520", Offset = "0x6AE2320", VA = "0x186AE3520")]
	public void PEFBOPBDPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3590", Offset = "0x6AE2390", VA = "0x186AE3590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BAHKENJLEMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HODAABIFJII<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private struct FGEFLLLPMOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float LODBIHCAGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public T KCKILJPPPGI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5880", Offset = "0x6E4C80")]
	private readonly Dictionary<object, global::HODAABIFJII<T>.FGEFLLLPMOF> HOPLLDGEACD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual T CPGODFFIGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x116B780", Offset = "0x116A580", VA = "0x18116B780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x17C1CE0", Offset = "0x17C0AE0", VA = "0x1817C1CE0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public object? GMLPOLOHNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NNJFFHEJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C4D0", Offset = "0x3E0B2D0", VA = "0x183E0C4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E0CAA0", Offset = "0x3E0B8A0", VA = "0x183E0CAA0")]
	public bool NMBLHBILMPM(T MGFMONLLLPD, object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x33FD160", Offset = "0x33FBF60", VA = "0x1833FD160")]
	public bool MNMLNGCEBNN(object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E290", Offset = "0x2A3D090", VA = "0x182A3E290")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E0AD40", Offset = "0x3E09B40", VA = "0x183E0AD40")]
	public bool BOAPLFBFGDK(object AMBDKIOJFBL, out T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E0B7F0", Offset = "0x3E0A5F0", VA = "0x183E0B7F0")]
	private bool JPGKFFGILAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x33FD6D0", Offset = "0x33FC4D0", VA = "0x1833FD6D0")]
	public HODAABIFJII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LMOCEHOAJIL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NEKACKKACMG ODMDLNBIEAL;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ANINPBDMPIO : LMOCEHOAJIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct IIMALDEMBIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly float EJEHGNMMKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly float MLNNFPABIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal readonly bool EMDPCLDELLN;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float OGFGLCKEPLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x6AE4430", Offset = "0x6AE3230", VA = "0x186AE4430")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE45C0", Offset = "0x6AE33C0", VA = "0x186AE45C0")]
		public IIMALDEMBIG(float CKCLNMMLENB, float KHILBFLOBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4440", Offset = "0x6AE3240", VA = "0x186AE4440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PFKFHJEBKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ANINPBDMPIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PFKFHJEBKNO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly int JNGKGNOBDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private int ONPPDHCHGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly LMOCEHOAJIL[] JMADPBDMELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly NEKACKKACMG[] BGEMPOFCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly IIMALDEMBIG[] LNDJNAJFCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private IIMALDEMBIG JEAKAGHLNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly PGCPDGBOHJA DFHGANNMEFI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float NNMDGEJCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6AE30B0", Offset = "0x6AE1EB0", VA = "0x186AE30B0", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NEKACKKACMG ODMDLNBIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2B10", Offset = "0x6AE1910", VA = "0x186AE2B10", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2940", Offset = "0x6AE1740", VA = "0x186AE2940", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6AE30D0", Offset = "0x6AE1ED0", VA = "0x186AE30D0")]
	public ANINPBDMPIO(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2BD0", Offset = "0x6AE19D0", VA = "0x186AE2BD0")]
	public PGCPDGBOHJA HEIHDBMDPEN(IIMALDEMBIG MKIDAPMAKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2C60", Offset = "0x6AE1A60", VA = "0x186AE2C60")]
	public void KMEDMLBHPJD(LMOCEHOAJIL EFDKMLPAOOC, [Optional] IIMALDEMBIG GDDPHMHMIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2A00", Offset = "0x6AE1800", VA = "0x186AE2A00", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public delegate void NEKACKKACMG(float DPHHOFKPKFO);
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PDPJJIDGHME
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class KPFANHAGHDE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly LMOCEHOAJIL BJFMPBPEDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly NEKACKKACMG FNIOCOFMFAB;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4750", Offset = "0x6AE3550", VA = "0x186AE4750")]
		public KPFANHAGHDE(LMOCEHOAJIL BJFMPBPEDNF, NEKACKKACMG FNIOCOFMFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AE4700", Offset = "0x6AE3500", VA = "0x186AE4700", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5050", Offset = "0x6AE3E50", VA = "0x186AE5050")]
	internal static bool EAMMBFEJOHE(float GCKGDDMIIDO, float EJKHFJILHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C290", Offset = "0x4B1B090", VA = "0x184B1C290")]
	internal static float EIMLEAOENOL(float GCKGDDMIIDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6AE50D0", Offset = "0x6AE3ED0", VA = "0x186AE50D0")]
	public static IDisposable JDFJOJBHCEE(this LMOCEHOAJIL BJFMPBPEDNF, NEKACKKACMG FNIOCOFMFAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class PGCPDGBOHJA : LMOCEHOAJIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float DPHHOFKPKFO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float NNMDGEJCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x10A4E10", Offset = "0x10A3C10", VA = "0x1810A4E10", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE52C0", Offset = "0x6AE40C0", VA = "0x186AE52C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NEKACKKACMG? ODMDLNBIEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5380", Offset = "0x6AE4180", VA = "0x186AE5380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5220", Offset = "0x6AE4020", VA = "0x186AE5220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public PGCPDGBOHJA()
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
