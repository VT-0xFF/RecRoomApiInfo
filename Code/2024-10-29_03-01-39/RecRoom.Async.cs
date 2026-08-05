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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D1AAE0", Offset = "0x6D19AE0", VA = "0x186D1AAE0")]
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
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct EJJBGBGAGBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string KKNEIOOKBDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public KKJPAEAJCIM BENGLBBECJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float? KLBNNMEHDJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public float? IFOFGJMCKEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public IDisposable DBKBKAHELHF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class LBBBNBHDIAC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public LBBBNBHDIAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D1A740", Offset = "0x6D19740", VA = "0x186D1A740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6D1A910", Offset = "0x6D19910", VA = "0x186D1A910", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ABNFKKFPAAM : IEnumerator<object>, IEnumerator, IDisposable
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
			public IIAHDMFNNHP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public ABNFKKFPAAM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6D19EB0", Offset = "0x6D18EB0", VA = "0x186D19EB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6D19F20", Offset = "0x6D18F20", VA = "0x186D19F20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<EJJBGBGAGBF> ICDFFHFCOBB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HICNMIFIMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E50", Offset = "0x8B8E50", VA = "0x1808B9E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8BA040", Offset = "0x8B9040", VA = "0x1808BA040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A390", Offset = "0x6D19390", VA = "0x186D1A390")]
		public static AsyncBatch Create(Transform JNLBEALAMNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A4D0", Offset = "0x6D194D0", VA = "0x186D1A4D0")]
		[IteratorStateMachine(typeof(LBBBNBHDIAC))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A1E0", Offset = "0x6D191E0", VA = "0x186D1A1E0")]
		public void Add(string DMCFPOLFNCF, KKJPAEAJCIM CKPIAGAFCGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D19F70", Offset = "0x6D18F70", VA = "0x186D19F70")]
		public void Add(string DMCFPOLFNCF, IEnumerator KIDOMMFFGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A440", Offset = "0x6D19440", VA = "0x186D1A440")]
		[IteratorStateMachine(typeof(ABNFKKFPAAM))]
		private IEnumerator IFMBCCDDDCF(IIAHDMFNNHP CKPIAGAFCGI, IEnumerator KIDOMMFFGFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A550", Offset = "0x6D19550", VA = "0x186D1A550")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AOAANMHCCDK<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class HLNEBELEEKK
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public TKey AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public KKJPAEAJCIM BENGLBBECJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DateTime EGBBBGPACNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x42090B0", Offset = "0x42080B0", VA = "0x1842090B0")]
		public HLNEBELEEKK(TKey MLAECOMLIEC, KKJPAEAJCIM CKPIAGAFCGI, DateTime JBNHDFBEFCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IDJOANNMPAE<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AOAANMHCCDK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HLNEBELEEKK cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IDJOANNMPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x42EE140", Offset = "0x42ED140", VA = "0x1842EE140")]
		internal void OHJHEBKLALH(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<TKey, HLNEBELEEKK> NBMFIGMFHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LinkedList<HLNEBELEEKK> HJABBFHIIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LinkedList<HLNEBELEEKK> OMOFGOJALHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int MPCAFEJCGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool AJIDHIKKJKK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x43E2CB0", Offset = "0x43E1CB0", VA = "0x1843E2CB0")]
	public AOAANMHCCDK([Optional] int? MPCAFEJCGEN, bool AJIDHIKKJKK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28FA4C0", Offset = "0x28F94C0", VA = "0x1828FA4C0")]
	public OBJFFICJNII<TValue> MONPNAOKBCG<TValue>(TKey MLAECOMLIEC) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28FABA0", Offset = "0x28F9BA0", VA = "0x1828FABA0")]
	public void NBNIOMBIFDJ<TValue>(TKey MLAECOMLIEC, OBJFFICJNII<TValue> CKPIAGAFCGI, TimeSpan JIOBJAOJBGC) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28FA250", Offset = "0x28F9250", VA = "0x1828FA250")]
	public OBJFFICJNII<TValue> FNLOKHOKBGD<TValue>(TKey MLAECOMLIEC, Func<OBJFFICJNII<TValue>> EMFGNOHPNJE) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x28FA3E0", Offset = "0x28F93E0", VA = "0x1828FA3E0")]
	public OBJFFICJNII<TValue> FNLOKHOKBGD<TValue>(TKey MLAECOMLIEC, Func<OBJFFICJNII<TValue>> EMFGNOHPNJE, TimeSpan JIOBJAOJBGC) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x43E0540", Offset = "0x43DF540", VA = "0x1843E0540")]
	public bool CAKBCGBONLK(TKey MLAECOMLIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x43E1DA0", Offset = "0x43E0DA0", VA = "0x1843E1DA0")]
	public void EGPGCHCMHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43E0940", Offset = "0x43DF940", VA = "0x1843E0940")]
	private void CBJDBLGDKEE(HLNEBELEEKK NKLPNIJHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x43E0FC0", Offset = "0x43DFFC0", VA = "0x1843E0FC0")]
	private void DIDNEBCEGMO(HLNEBELEEKK NKLPNIJHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43E29E0", Offset = "0x43E19E0", VA = "0x1843E29E0")]
	private void MGBNEFCKBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x43E2260", Offset = "0x43E1260", VA = "0x1843E2260")]
	private bool KHCJOHNNIJJ(HLNEBELEEKK NKLPNIJHEFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CFOPMGIIKKG
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NLELGJDHFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IFNJBMDJFEC? logFlags;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NLELGJDHFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A960", Offset = "0x6D19960", VA = "0x186D1A960")]
		internal void KJGGDBNDJMO(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ABFDAILKADM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public IFNJBMDJFEC? logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ABFDAILKADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x408AC70", Offset = "0x4089C70", VA = "0x18408AC70")]
		internal void KJGGDBNDJMO(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A5E0", Offset = "0x6D195E0", VA = "0x186D1A5E0")]
	public static KKJPAEAJCIM DFFCLIBELGI(this KKJPAEAJCIM CKPIAGAFCGI, string CNHHHMJFIFK, [Optional] IFNJBMDJFEC? HGMIOHEIHIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2D67E00", Offset = "0x2D66E00", VA = "0x182D67E00")]
	public static OBJFFICJNII<T> DFFCLIBELGI<T>(this OBJFFICJNII<T> CKPIAGAFCGI, string CNHHHMJFIFK, [Optional] IFNJBMDJFEC? HGMIOHEIHIP)
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
