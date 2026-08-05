using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9A90", Offset = "0x5EA8890", VA = "0x185EA9A90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct NHMBMNDNAMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string BAAGNNPAEFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public PCFNKHPOHAG AOAJFDMKKAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float? EEPNEOLFEIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public float? HBMKGHEHCOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public IDisposable IHNNJBFGJFH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JHBMDDBIJPA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public JHBMDDBIJPA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA94C0", Offset = "0x5EA82C0", VA = "0x185EA94C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9690", Offset = "0x5EA8490", VA = "0x185EA9690", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KDFFOBPFFCK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public EEELEBFPAJE promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
			[DebuggerHidden]
			public KDFFOBPFFCK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5EA96E0", Offset = "0x5EA84E0", VA = "0x185EA96E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9750", Offset = "0x5EA8550", VA = "0x185EA9750", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<NHMBMNDNAMK> FKMIMAAIJEL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MCMOHAOIJHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x78E250", Offset = "0x78D050", VA = "0x18078E250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x78E230", Offset = "0x78D030", VA = "0x18078E230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9270", Offset = "0x5EA8070", VA = "0x185EA9270")]
		public static AsyncBatch Create(Transform GEFCENNBDFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5EA93B0", Offset = "0x5EA81B0", VA = "0x185EA93B0")]
		[IteratorStateMachine(typeof(JHBMDDBIJPA))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5EA90E0", Offset = "0x5EA7EE0", VA = "0x185EA90E0")]
		public void Add(string AOAIBMOPKPE, PCFNKHPOHAG ENDOBNICGKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8E90", Offset = "0x5EA7C90", VA = "0x185EA8E90")]
		public void Add(string AOAIBMOPKPE, IEnumerator NKNFNCGJODD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9320", Offset = "0x5EA8120", VA = "0x185EA9320")]
		[IteratorStateMachine(typeof(KDFFOBPFFCK))]
		private IEnumerator NKDAJJOCDFE(EEELEBFPAJE ENDOBNICGKI, IEnumerator NKNFNCGJODD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9430", Offset = "0x5EA8230", VA = "0x185EA9430")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FIBDHOMEEPC<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class PNICPFLBCCL
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public TKey OFBDILANEMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x78D180", Offset = "0x78BF80", VA = "0x18078D180")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PCFNKHPOHAG AOAJFDMKKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DateTime JFDIEGAPHFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x40533F0", Offset = "0x40521F0", VA = "0x1840533F0")]
		public PNICPFLBCCL(TKey IDGIKKEFDCG, PCFNKHPOHAG ENDOBNICGKI, DateTime HOPLMNOFPJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FJJKGGLOAJG<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FIBDHOMEEPC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PNICPFLBCCL cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public FJJKGGLOAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3612A30", Offset = "0x3611830", VA = "0x183612A30")]
		internal void EKPBBIBNBHH(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<TKey, PNICPFLBCCL> NKBOFPLFCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LinkedList<PNICPFLBCCL> MNFNKEPFOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LinkedList<PNICPFLBCCL> GDJOADDPGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int BALOFIIADFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MEGFNDFFLCG;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x360A720", Offset = "0x3609520", VA = "0x18360A720")]
	public FIBDHOMEEPC([Optional] int? BALOFIIADFB, bool MEGFNDFFLCG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x36082D0", Offset = "0x36070D0", VA = "0x1836082D0")]
	public bool EJCLHJOEIHC(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B6A0", Offset = "0x2F0A4A0", VA = "0x182F0B6A0")]
	public FJJBNKADFNG<TValue> JNJAHLHBNEI<TValue>(TKey IDGIKKEFDCG) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B5D0", Offset = "0x2F0A3D0", VA = "0x182F0B5D0")]
	public void GCKNNHFHAPA<TValue>(TKey IDGIKKEFDCG, TValue MBDKMNBCLGF) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AD60", Offset = "0x2F09B60", VA = "0x182F0AD60")]
	public void DNPKBFHKIHN<TValue>(TKey IDGIKKEFDCG, FJJBNKADFNG<TValue> ENDOBNICGKI, TimeSpan ADHAHHJAEPM) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B530", Offset = "0x2F0A330", VA = "0x182F0B530")]
	public FJJBNKADFNG<TValue> ECPNMJLLONH<TValue>(TKey IDGIKKEFDCG, Func<FJJBNKADFNG<TValue>> DAKEOFAHDOF) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B3F0", Offset = "0x2F0A1F0", VA = "0x182F0B3F0")]
	public FJJBNKADFNG<TValue> ECPNMJLLONH<TValue>(TKey IDGIKKEFDCG, Func<FJJBNKADFNG<TValue>> DAKEOFAHDOF, TimeSpan ADHAHHJAEPM) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3608230", Offset = "0x3607030", VA = "0x183608230")]
	public bool CPMMAHJGJAD(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3608310", Offset = "0x3607110", VA = "0x183608310")]
	public void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x360A040", Offset = "0x3608E40", VA = "0x18360A040")]
	private void PHKMBLBJHFF(PNICPFLBCCL IIPEKCHFNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3609750", Offset = "0x3608550", VA = "0x183609750")]
	private void NILFJNAGGAC(PNICPFLBCCL IIPEKCHFNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3608AD0", Offset = "0x36078D0", VA = "0x183608AD0")]
	private void MFPOBIGPFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36083A0", Offset = "0x36071A0", VA = "0x1836083A0")]
	private bool MFMLPFMDAKC(PNICPFLBCCL IIPEKCHFNGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MICGBGLOGDN
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NEIDGEOMKKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KEFAEGNACHO? logFlags;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public NEIDGEOMKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9900", Offset = "0x5EA8700", VA = "0x185EA9900")]
		internal void ANLKEGEHDCN(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BCIHBGOHELJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public KEFAEGNACHO? logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public BCIHBGOHELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4668150", Offset = "0x4666F50", VA = "0x184668150")]
		internal void ANLKEGEHDCN(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA97A0", Offset = "0x5EA85A0", VA = "0x185EA97A0")]
	public static PCFNKHPOHAG FDGPDPJEDKD(this PCFNKHPOHAG ENDOBNICGKI, string KMAPAFFIGCG, [Optional] KEFAEGNACHO? CJNBOOFGMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26A39A0", Offset = "0x26A27A0", VA = "0x1826A39A0")]
	public static FJJBNKADFNG<T> FDGPDPJEDKD<T>(this FJJBNKADFNG<T> ENDOBNICGKI, string KMAPAFFIGCG, [Optional] KEFAEGNACHO? CJNBOOFGMFC)
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
