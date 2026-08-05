using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct IFGGDEDPHIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string BAGLDJIDHDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OJNMJAKAOEK PJIGJNPPIJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? LEMNBDIAFNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? LCJELECOJED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable DNJFJDHABIF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class GFBALNHDEKP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public GFBALNHDEKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3D92560", Offset = "0x3D90F60", VA = "0x183D92560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3D92730", Offset = "0x3D91130", VA = "0x183D92730", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BDCLCGFDMFD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public BBHGGOLAFNL promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public BDCLCGFDMFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3D924C0", Offset = "0x3D90EC0", VA = "0x183D924C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3D92510", Offset = "0x3D90F10", VA = "0x183D92510", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<IFGGDEDPHIE> ILMDBDBJHJG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GILCHCDMFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x427160", Offset = "0x425B60", VA = "0x180427160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x688380", Offset = "0x686D80", VA = "0x180688380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3D92300", Offset = "0x3D90D00", VA = "0x183D92300")]
		public static AsyncBatch Create(Transform PDMALPKAHLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D92400", Offset = "0x3D90E00", VA = "0x183D92400")]
		[IteratorStateMachine(typeof(GFBALNHDEKP))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D92210", Offset = "0x3D90C10", VA = "0x183D92210")]
		public void Add(string AKEPBHBNAIA, OJNMJAKAOEK JHPNEFHMIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D920A0", Offset = "0x3D90AA0", VA = "0x183D920A0")]
		public void Add(string AKEPBHBNAIA, IEnumerator LAFJEGDHPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D92390", Offset = "0x3D90D90", VA = "0x183D92390")]
		[IteratorStateMachine(typeof(BDCLCGFDMFD))]
		private IEnumerator EKEPENLMCJL(BBHGGOLAFNL JHPNEFHMIMF, IEnumerator LAFJEGDHPBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D92460", Offset = "0x3D90E60", VA = "0x183D92460")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AEEAODCJOPP<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LCACENOEPID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey PBPONIOKHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OJNMJAKAOEK PJIGJNPPIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime PNFLBHPLCHL;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public LCACENOEPID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CJBJANJGMKE<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::AEEAODCJOPP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public CJBJANJGMKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GNMCJKGFIDO<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LCACENOEPID cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CJBJANJGMKE<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public GNMCJKGFIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x22963A0", Offset = "0x2294DA0", VA = "0x1822963A0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, LCACENOEPID> GLJIPJCLMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<LCACENOEPID> ABGCCJHAOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<LCACENOEPID> DKMEIANCFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int AMIELMCHEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool CKMHGFIMGDM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> IDKJKPINCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1F940A0", Offset = "0x1F92AA0", VA = "0x181F940A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x228E820", Offset = "0x228D220", VA = "0x18228E820")]
	public AEEAODCJOPP([Optional] int? AMIELMCHEHH, bool CKMHGFIMGDM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20B1AE0", Offset = "0x20B04E0", VA = "0x1820B1AE0")]
	public bool GHGCFJJDANK(TKey AOLPFBNJMEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x20199E0", Offset = "0x20183E0", VA = "0x1820199E0")]
	public global::GDHDNGFJPDI<TValue> KFJNDNPGGHD<TValue>(TKey AOLPFBNJMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x249B5E0", Offset = "0x2499FE0", VA = "0x18249B5E0")]
	public void KGFOAJPEOIL<TValue>(TKey AOLPFBNJMEA, TValue MDAEJMIAMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x249B520", Offset = "0x2499F20", VA = "0x18249B520")]
	public void KGFOAJPEOIL<TValue>(TKey AOLPFBNJMEA, TValue MDAEJMIAMDO, TimeSpan LHKODLIKJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x249AAE0", Offset = "0x24994E0", VA = "0x18249AAE0")]
	public void BJFJNFPFBMG<TValue>(TKey AOLPFBNJMEA, global::GDHDNGFJPDI<TValue> JHPNEFHMIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x249AB90", Offset = "0x2499590", VA = "0x18249AB90")]
	public void BJFJNFPFBMG<TValue>(TKey AOLPFBNJMEA, global::GDHDNGFJPDI<TValue> JHPNEFHMIMF, TimeSpan LHKODLIKJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2019D00", Offset = "0x2018700", VA = "0x182019D00")]
	public global::GDHDNGFJPDI<TValue> OAFOGDLOJNH<TValue>(TKey AOLPFBNJMEA, Func<global::GDHDNGFJPDI<TValue>> ENKKJFJNCNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2019BC0", Offset = "0x20185C0", VA = "0x182019BC0")]
	public global::GDHDNGFJPDI<TValue> OAFOGDLOJNH<TValue>(TKey AOLPFBNJMEA, Func<global::GDHDNGFJPDI<TValue>> ENKKJFJNCNB, TimeSpan LHKODLIKJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x228C810", Offset = "0x228B210", VA = "0x18228C810")]
	public bool FIAJBIFJEOJ(TKey AOLPFBNJMEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x228D940", Offset = "0x228C340", VA = "0x18228D940")]
	public int MLDCPDKCNAA(Predicate<TKey> AGGLCAKHBAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x228C780", Offset = "0x228B180", VA = "0x18228C780")]
	public void ENEFFEHIEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x228E090", Offset = "0x228CA90", VA = "0x18228E090")]
	private void OALPFLNFKLA(LCACENOEPID CELBIAILGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x228CDF0", Offset = "0x228B7F0", VA = "0x18228CDF0")]
	private void GKGIMNHPHLD(LCACENOEPID CELBIAILGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x228D430", Offset = "0x228BE30", VA = "0x18228D430")]
	private void MDEFCBLLJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x228D1D0", Offset = "0x228BBD0", VA = "0x18228D1D0")]
	private bool IEMDEEMBPDA(LCACENOEPID CELBIAILGHB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IKAEKDPBOKM
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] PLMALFKJJFH;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int MNKELEMMCIP;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int JAADIHNAGCD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger HGHHBJPNHEH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
	public IKAEKDPBOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D92780", Offset = "0x3D91180", VA = "0x183D92780")]
	private static string GHHLIKAFOCC(byte[] MAKIBMGFDDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D92880", Offset = "0x3D91280", VA = "0x183D92880")]
	public static string NADJMKIAKML(byte[] LKPHIKGCGGC, bool BILKIJDICLE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
