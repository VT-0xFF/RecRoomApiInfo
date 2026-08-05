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
		private struct JJAEILFBMFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string NIGNPLIEFKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public FIIDGPMBKPK EKAHKONEBMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? GGLJHFLFINE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? PFCJBAPHFMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable ADAGFDGINIF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class ICLBFNBHEGN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public ICLBFNBHEGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3D7CFD0", Offset = "0x3D7C1D0", VA = "0x183D7CFD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3D7D1A0", Offset = "0x3D7C3A0", VA = "0x183D7D1A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class DGFEBIAKEIN : IEnumerator<object>, IEnumerator, IDisposable
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
			public LBOFBPOGAAB promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public DGFEBIAKEIN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3D7CF30", Offset = "0x3D7C130", VA = "0x183D7CF30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3D7CF80", Offset = "0x3D7C180", VA = "0x183D7CF80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<JJAEILFBMFN> POOFJNNBIHH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LKIAHKCKMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x425160", Offset = "0x424360", VA = "0x180425160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x536D10", Offset = "0x535F10", VA = "0x180536D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C790", Offset = "0x3D7B990", VA = "0x183D7C790")]
		public static AsyncBatch Create(Transform AIJNAMEGHNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C890", Offset = "0x3D7BA90", VA = "0x183D7C890")]
		[IteratorStateMachine(typeof(ICLBFNBHEGN))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C6A0", Offset = "0x3D7B8A0", VA = "0x183D7C6A0")]
		public void Add(string DILLFCNMNDO, FIIDGPMBKPK IHBPKCCLLJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C530", Offset = "0x3D7B730", VA = "0x183D7C530")]
		public void Add(string DILLFCNMNDO, IEnumerator JGNPBDAPHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C820", Offset = "0x3D7BA20", VA = "0x183D7C820")]
		[IteratorStateMachine(typeof(DGFEBIAKEIN))]
		private IEnumerator KCHBOLDHKFG(LBOFBPOGAAB IHBPKCCLLJG, IEnumerator JGNPBDAPHAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C8F0", Offset = "0x3D7BAF0", VA = "0x183D7C8F0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JDLAAKAKDBL<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class POODPHIBBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey CHAPOCEIMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FIIDGPMBKPK EKAHKONEBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime JGGDKCMPKFC;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public POODPHIBBMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NPDKGPFHEOO<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::JDLAAKAKDBL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public NPDKGPFHEOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GKGBLMHAAMI<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public POODPHIBBMG cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NPDKGPFHEOO<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public GKGBLMHAAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x24961C0", Offset = "0x24953C0", VA = "0x1824961C0")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, POODPHIBBMG> JBHPDMAJHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<POODPHIBBMG> FGILAENFOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<POODPHIBBMG> NNPCGJJIACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int NCLFKCHHKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool GBBFBGFPOOJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> NJJDPLJBGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2191070", Offset = "0x2190270", VA = "0x182191070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x249D9C0", Offset = "0x249CBC0", VA = "0x18249D9C0")]
	public JDLAAKAKDBL([Optional] int? NCLFKCHHKOD, bool GBBFBGFPOOJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x249C2D0", Offset = "0x249B4D0", VA = "0x18249C2D0")]
	public bool HFLENNLDFBO(TKey BGJKOMDILFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1A923D0", Offset = "0x1A915D0", VA = "0x181A923D0")]
	public global::MGLHMIMFOOP<TValue> JHMBIBNDLDJ<TValue>(TKey BGJKOMDILFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1C6C8D0", Offset = "0x1C6BAD0", VA = "0x181C6C8D0")]
	public void JDDADGBDHNL<TValue>(TKey BGJKOMDILFD, TValue NAOGMHDFAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C6C9B0", Offset = "0x1C6BBB0", VA = "0x181C6C9B0")]
	public void JDDADGBDHNL<TValue>(TKey BGJKOMDILFD, TValue NAOGMHDFAEF, TimeSpan CGLDIGICMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1C6C4F0", Offset = "0x1C6B6F0", VA = "0x181C6C4F0")]
	public void IDOKIDEEDIB<TValue>(TKey BGJKOMDILFD, global::MGLHMIMFOOP<TValue> IHBPKCCLLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1C6C5A0", Offset = "0x1C6B7A0", VA = "0x181C6C5A0")]
	public void IDOKIDEEDIB<TValue>(TKey BGJKOMDILFD, global::MGLHMIMFOOP<TValue> IHBPKCCLLJG, TimeSpan CGLDIGICMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1A91E40", Offset = "0x1A91040", VA = "0x181A91E40")]
	public global::MGLHMIMFOOP<TValue> BJFOJPEPMPG<TValue>(TKey BGJKOMDILFD, Func<global::MGLHMIMFOOP<TValue>> NLAHDNPFHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1A91C50", Offset = "0x1A90E50", VA = "0x181A91C50")]
	public global::MGLHMIMFOOP<TValue> BJFOJPEPMPG<TValue>(TKey BGJKOMDILFD, Func<global::MGLHMIMFOOP<TValue>> NLAHDNPFHNE, TimeSpan CGLDIGICMLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x249B8F0", Offset = "0x249AAF0", VA = "0x18249B8F0")]
	public bool BMFIDCHECMB(TKey BGJKOMDILFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x249CE10", Offset = "0x249C010", VA = "0x18249CE10")]
	public int MELNKPMMDBF(Predicate<TKey> CHPMELEFOLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x249C300", Offset = "0x249B500", VA = "0x18249C300")]
	public void JOFBHKLPDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x249BB60", Offset = "0x249AD60", VA = "0x18249BB60")]
	private void EGGAEDFPNNI(POODPHIBBMG MHIEPNKCEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x249C390", Offset = "0x249B590", VA = "0x18249C390")]
	private void MAFAEEDJLEN(POODPHIBBMG MHIEPNKCEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x249D4A0", Offset = "0x249C6A0", VA = "0x18249D4A0")]
	private void PCKGCDJPMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x249C1A0", Offset = "0x249B3A0", VA = "0x18249C1A0")]
	private bool FPJNCFBBLFN(POODPHIBBMG MHIEPNKCEHE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BCKBGMPBOEN
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] IIKLKCCNJOK;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int EFALHOKMJDD;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int EIOLKOFHOIE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger DCNHKPLAFAO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
	public BCKBGMPBOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D7C950", Offset = "0x3D7BB50", VA = "0x183D7C950")]
	private static string JACOKJKBDNF(byte[] EELHLJKEFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D7CA50", Offset = "0x3D7BC50", VA = "0x183D7CA50")]
	public static string MIOPHHLBAMI(byte[] DNMICDHPJHJ, bool AFHNMHOEHHN)
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
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
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
