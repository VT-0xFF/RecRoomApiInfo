using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ENPNCOMIBHK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class MFHNMPDDCKA<T> : LNEFBBBKEKB<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2FAC860", Offset = "0x2FABC60", VA = "0x182FAC860")]
		public MFHNMPDDCKA(AsyncOperationHandle<T> BKKNJPDKNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2F70", Offset = "0x1CB2370", VA = "0x181CB2F70", Slot = "11")]
		protected override T KMDBKCBMKKI(T NKKAFOGBKLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2FAC7C0", Offset = "0x2FABBC0", VA = "0x182FAC7C0", Slot = "10")]
		protected sealed override void DHJJBILNOAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class AFFGNMIIKJP<T> : LNEFBBBKEKB<GameObject, T> where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2FAC860", Offset = "0x2FABC60", VA = "0x182FAC860")]
		public AFFGNMIIKJP(AsyncOperationHandle<GameObject> BKKNJPDKNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28AE400", Offset = "0x28AD800", VA = "0x1828AE400", Slot = "11")]
		protected override T KMDBKCBMKKI(GameObject NKKAFOGBKLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x340A0E0", Offset = "0x34094E0", VA = "0x18340A0E0", Slot = "10")]
		protected sealed override void DHJJBILNOAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private abstract class LNEFBBBKEKB<TSource, TTransformed> : global::NNDOHKCNEMF<Task<TSource>, TTransformed> where TSource : UnityEngine.Object where TTransformed : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected readonly AsyncOperationHandle<TSource> LEJLFNNGEAC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected TSource MLDJBMMDKCN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F45E0", Offset = "0x7F39E0", VA = "0x1807F45E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8877B0", Offset = "0x886BB0", VA = "0x1808877B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x38BC360", Offset = "0x38BB760", VA = "0x1838BC360")]
		protected LNEFBBBKEKB(AsyncOperationHandle<TSource> BKKNJPDKNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x38BC2F0", Offset = "0x38BB6F0", VA = "0x1838BC2F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x38BC260", Offset = "0x38BB660", VA = "0x1838BC260", Slot = "9")]
		protected override TTransformed HMHBONGCHJE(Task<TSource> JMOMGPFDODI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract TTransformed KMDBKCBMKKI(TSource NKKAFOGBKLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x32F2BC0", Offset = "0x32F1FC0", VA = "0x1832F2BC0")]
	public static bool ACAFHKIJPEB<T>(AssetReference JAHDBJLKHIA, Func<global::KFBENPHJFEN<T>> JLPAEEACBFD, out global::KFBENPHJFEN<T> JNDGCMPCMOH) where T : UnityEngine.Object
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x32F2D70", Offset = "0x32F2170", VA = "0x1832F2D70")]
	public static global::KFBENPHJFEN<T> MKHMHGBOGNN<T>([NotNull] AssetReference HDMEPHODNND) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x32F2C50", Offset = "0x32F2050", VA = "0x1832F2C50")]
	public static global::KFBENPHJFEN<T> GCNDJLKOOFN<T>([NotNull] AssetReference HDMEPHODNND) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private static void EDLPJHCGDCF(AssetReference HDMEPHODNND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AJJFIJHBMHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HCOANLGINCF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IADAMJMBKPF<T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public HCOANLGINCF request;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
			public IADAMJMBKPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5492B80", Offset = "0x5491F80", VA = "0x185492B80")]
			internal void EADCECLELAH(T o)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private KBEAHKJNPMN NFBBFKNFACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private object GFNODNPFCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int GDFCCJOBLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private UnityEngine.Object LDJJMOALFIM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int GNJJKOHGMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80E090", VA = "0x18080EC90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public UnityEngine.Object GPJEJLEFCCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x33DF270", Offset = "0x33DE670", VA = "0x1833DF270")]
		public static HCOANLGINCF CLPMMKIPDNO<T>(AssetReference JAHDBJLKHIA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x33DF2B0", Offset = "0x33DE6B0", VA = "0x1833DF2B0")]
		private static HCOANLGINCF OKMELEKOEBC<T>(AssetReference JAHDBJLKHIA, global::KFBENPHJFEN<T> MNAKGALDEIP) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		private HCOANLGINCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5FF0", Offset = "0x6FD53F0", VA = "0x186FD5FF0")]
		public void MPHDDJFMACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5FE0", Offset = "0x6FD53E0", VA = "0x186FD5FE0")]
		public void LLPFCPEMFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5F10", Offset = "0x6FD5310", VA = "0x186FD5F10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JFHBDKAKCAG<T> : global::KFBENPHJFEN<T>, KBEAHKJNPMN, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public Action MGNOKDCIBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool OLOGLDMJOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::KFBENPHJFEN<T> JBAIHECOPBN;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Task ACKFFHOOGGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1A92430", Offset = "0x1A91830", VA = "0x181A92430", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private FKADHPEOOEO DBGBIJPFDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x19432E0", Offset = "0x19426E0", VA = "0x1819432E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public global::CBFHNKNAJIN<T> FMLDFLIAFEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x33A2FF0", Offset = "0x33A23F0", VA = "0x1833A2FF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Task<T> NOLFHMGACNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x33A3050", Offset = "0x33A2450", VA = "0x1833A3050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x33A3100", Offset = "0x33A2500", VA = "0x1833A3100")]
		public JFHBDKAKCAG(global::KFBENPHJFEN<T> JBAIHECOPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x33A2F80", Offset = "0x33A2380", VA = "0x1833A2F80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class INJMMFBCNBD<T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public HCOANLGINCF cachedResourceRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AJJFIJHBMHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public object runtimeKey;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public INJMMFBCNBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3314EB0", Offset = "0x33142B0", VA = "0x183314EB0")]
		internal void EAGMPPCKMDI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly global::KDDMDDMMGFF<UnityEngine.Object> JIAJPFBCNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int GAEOHIGPPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool OLOGLDMJOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<object, HCOANLGINCF> LEKIGANCDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private LinkedList<object> HMELDHODLCE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5DF0", Offset = "0x6FD51F0", VA = "0x186FD5DF0")]
	public AJJFIJHBMHG(int GAEOHIGPPBH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1A4F310", Offset = "0x1A4E710", VA = "0x181A4F310")]
	public global::KFBENPHJFEN<T> GCNDJLKOOFN<T>([NotNull] AssetReference HDMEPHODNND) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1A4F370", Offset = "0x1A4E770", VA = "0x181A4F370")]
	private JFHBDKAKCAG<T> OBPALCFKEJA<T>(AssetReference JAHDBJLKHIA, global::KFBENPHJFEN<T> JNDGCMPCMOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1A4F430", Offset = "0x1A4E830", VA = "0x181A4F430")]
	private JFHBDKAKCAG<T> OPCCLJHJHGM<T>(AssetReference JAHDBJLKHIA, global::KFBENPHJFEN<T> JNDGCMPCMOH, Func<AssetReference, HCOANLGINCF> LLEBMAGAMHD) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5CD0", Offset = "0x6FD50D0", VA = "0x186FD5CD0")]
	private void HFEBJGPEMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5A10", Offset = "0x6FD4E10", VA = "0x186FD5A10")]
	private void CHDOGDBKHML(HCOANLGINCF OLCOAAKJEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5B60", Offset = "0x6FD4F60", VA = "0x186FD5B60", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace Cpp2IlInjected;

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
