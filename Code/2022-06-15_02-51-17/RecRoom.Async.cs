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
		private struct FMELICKHHFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string GBBNAEGPONH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OBKKHCFLPCB FOALNDEPENC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? LOIGKIMNHCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? BBHKPEJAFBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable EGGHKJBCHBM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class AADFLKOPFKF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
			[DebuggerHidden]
			public AADFLKOPFKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E38B90", Offset = "0x4E37790", VA = "0x184E38B90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4E38D60", Offset = "0x4E37960", VA = "0x184E38D60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class FIEKIMIFFIF : IEnumerator<object>, IEnumerator, IDisposable
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
			public KOCFEPMOONC promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
			[DebuggerHidden]
			public FIEKIMIFFIF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4E39290", Offset = "0x4E37E90", VA = "0x184E39290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4E392F0", Offset = "0x4E37EF0", VA = "0x184E392F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<FMELICKHHFM> GBGEJIKBIDG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GJGMEKODLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x55C190", Offset = "0x55AD90", VA = "0x18055C190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x694360", Offset = "0x692F60", VA = "0x180694360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4E39090", Offset = "0x4E37C90", VA = "0x184E39090")]
		public static AsyncBatch Create(Transform JNKAEALDKKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4E391B0", Offset = "0x4E37DB0", VA = "0x184E391B0")]
		[IteratorStateMachine(typeof(AADFLKOPFKF))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4E38DB0", Offset = "0x4E379B0", VA = "0x184E38DB0")]
		public void Add(string HBGNDBNJDEC, OBKKHCFLPCB PKLMFFLCDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E38ED0", Offset = "0x4E37AD0", VA = "0x184E38ED0")]
		public void Add(string HBGNDBNJDEC, IEnumerator EDDNKHPOIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E39120", Offset = "0x4E37D20", VA = "0x184E39120")]
		[IteratorStateMachine(typeof(FIEKIMIFFIF))]
		private IEnumerator FOBPEPJBPMB(KOCFEPMOONC PKLMFFLCDAI, IEnumerator EDDNKHPOIOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E39220", Offset = "0x4E37E20", VA = "0x184E39220")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NHNEGHPACKN<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MDBJGGNAOJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey LBLIIGONCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OBKKHCFLPCB FOALNDEPENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime DINOOCFPKLD;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public MDBJGGNAOJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NJBICGIIFGC<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::NHNEGHPACKN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public NJBICGIIFGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GAAADEAKCLP<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MDBJGGNAOJN cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NJBICGIIFGC<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public GAAADEAKCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B33DF0", Offset = "0x2B329F0", VA = "0x182B33DF0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, MDBJGGNAOJN> EGCLPNLNKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<MDBJGGNAOJN> IHNGCKLNJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<MDBJGGNAOJN> NMJBKEOAKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int LFOIMOLIDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool MKNBNECABOL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> AMNOMAFPPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x22754E0", Offset = "0x22740E0", VA = "0x1822754E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B38C60", Offset = "0x2B37860", VA = "0x182B38C60")]
	public NHNEGHPACKN([Optional] int? LFOIMOLIDKL, bool MKNBNECABOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2271F90", Offset = "0x2270B90", VA = "0x182271F90")]
	public bool PMCGIMHJPDO(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DE37A0", Offset = "0x1DE23A0", VA = "0x181DE37A0")]
	public global::KKLFNGHEAIK<TValue> OFOHAFMLJCL<TValue>(TKey OMAJLLKKGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x311E910", Offset = "0x311D510", VA = "0x18311E910")]
	public void NMGMBMENGDG<TValue>(TKey OMAJLLKKGPH, TValue ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x311E850", Offset = "0x311D450", VA = "0x18311E850")]
	public void NMGMBMENGDG<TValue>(TKey OMAJLLKKGPH, TValue ODCJDJDBONO, TimeSpan BJPEMNKMGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x311E440", Offset = "0x311D040", VA = "0x18311E440")]
	public void JABPNOPPFEM<TValue>(TKey OMAJLLKKGPH, global::KKLFNGHEAIK<TValue> PKLMFFLCDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x311E4F0", Offset = "0x311D0F0", VA = "0x18311E4F0")]
	public void JABPNOPPFEM<TValue>(TKey OMAJLLKKGPH, global::KKLFNGHEAIK<TValue> PKLMFFLCDAI, TimeSpan BJPEMNKMGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3390", Offset = "0x1DE1F90", VA = "0x181DE3390")]
	public global::KKLFNGHEAIK<TValue> EJEMBFALFFI<TValue>(TKey OMAJLLKKGPH, Func<global::KKLFNGHEAIK<TValue>> DKFAHEGPJNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE31A0", Offset = "0x1DE1DA0", VA = "0x181DE31A0")]
	public global::KKLFNGHEAIK<TValue> EJEMBFALFFI<TValue>(TKey OMAJLLKKGPH, Func<global::KKLFNGHEAIK<TValue>> DKFAHEGPJNA, TimeSpan BJPEMNKMGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B378C0", Offset = "0x2B364C0", VA = "0x182B378C0")]
	public bool JGCOEHFAOLL(TKey OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B37940", Offset = "0x2B36540", VA = "0x182B37940")]
	public int KJIFOFHBNJG(Predicate<TKey> DBFEOMAHBLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B369C0", Offset = "0x2B355C0", VA = "0x182B369C0")]
	public void AIGACLLIPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B376D0", Offset = "0x2B362D0", VA = "0x182B376D0")]
	private void DNPDGLBCJFO(MDBJGGNAOJN HOFHOBIMEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B38090", Offset = "0x2B36C90", VA = "0x182B38090")]
	private void MIAPLFNJNIB(MDBJGGNAOJN HOFHOBIMEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B37140", Offset = "0x2B35D40", VA = "0x182B37140")]
	private void DNFKAJOACKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B36B80", Offset = "0x2B35780", VA = "0x182B36B80")]
	private bool DFEDEDHMICL(MDBJGGNAOJN HOFHOBIMEKF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HNGLDPHHCGI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] HNCEJLIIPMJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int GPLDKCDHCAH;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int JHGLEHDFIPO;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger ALPCFLGFGJH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public HNGLDPHHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E39340", Offset = "0x4E37F40", VA = "0x184E39340")]
	private static string CHLEKPLKKKF(byte[] GONCOEMNHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E39440", Offset = "0x4E38040", VA = "0x184E39440")]
	public static string KBPCOEPOAHA(byte[] EDEEEGMMOHA, bool EDDELBNCJAF)
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
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
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
