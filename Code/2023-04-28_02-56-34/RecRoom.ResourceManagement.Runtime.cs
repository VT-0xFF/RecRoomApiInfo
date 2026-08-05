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
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EJPLJIDBAIM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class OGIEGEMDEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public EJPLJIDBAIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public OGIEGEMDEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69FC8B0", Offset = "0x69FB2B0", VA = "0x1869FC8B0")]
		internal void <CachePrefab>b__0(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69FC950", Offset = "0x69FB350", VA = "0x1869FC950")]
		internal void <CachePrefab>b__1(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly EJPLJIDBAIM OGLPOEFHDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private Dictionary<string, GameObject> KMHHEHHHGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<string, GameObject> DGOEGONGAOG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69FC0C0", Offset = "0x69FAAC0", VA = "0x1869FC0C0")]
	public EJPLJIDBAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69FB840", Offset = "0x69FA240", VA = "0x1869FB840", Slot = "1")]
	~EJPLJIDBAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69FB7C0", Offset = "0x69FA1C0", VA = "0x1869FB7C0")]
	private void EGJKOJDBDJG(Scene OOOMPFGDEEN, LoadSceneMode AHPJCIAEOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69FBF10", Offset = "0x69FA910", VA = "0x1869FBF10")]
	public GameObject OLPPJGBPBCN(string KJMIGPLGEHH, bool CAINLMINOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69FBEF0", Offset = "0x69FA8F0", VA = "0x1869FBEF0")]
	public global::ODHJGGEEIEO<GameObject> OLPBKDNDNAO(string KJMIGPLGEHH, bool CAINLMINOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69FB6F0", Offset = "0x69FA0F0", VA = "0x1869FB6F0")]
	private GameObject COIHJJFIIGJ(string KJMIGPLGEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69FB960", Offset = "0x69FA360", VA = "0x1869FB960")]
	public void GPIGKADBNKA(string KJMIGPLGEHH, GameObject OPBBFNOFOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69FBE80", Offset = "0x69FA880", VA = "0x1869FBE80")]
	public void HLGBHPODLMM(string KJMIGPLGEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69FBA40", Offset = "0x69FA440", VA = "0x1869FBA40")]
	public global::ODHJGGEEIEO<GameObject> GPIGKADBNKA(string KJMIGPLGEHH, bool CAINLMINOHF, bool ALPOMHJHJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69FB670", Offset = "0x69FA070", VA = "0x1869FB670")]
	public bool AKLMIGJHFEH(string KJMIGPLGEHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JMLHGPHKDCB
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x199AC70", Offset = "0x1999670", VA = "0x18199AC70")]
	public static T APBDNAAPBOL<T>(string CCJFOCJJBJG) where T : UnityEngine.Object
	{
		return null;
	}
}
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class GGCHEMCBMKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string FNCDIIKMNIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public global::GOEHKJJNHGC<GameObject> AAKPPKIFLGC;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x69FC1F0", Offset = "0x69FABF0", VA = "0x1869FC1F0")]
			public GGCHEMCBMKM(string FNCDIIKMNIG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PFHFGNDBCCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<GGCHEMCBMKM> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public PFHFGNDBCCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x69FC9F0", Offset = "0x69FB3F0", VA = "0x1869FC9F0")]
			internal bool <ProcessQueue>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class EBINGJDOBOL : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<GGCHEMCBMKM> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private PFHFGNDBCCM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private GGCHEMCBMKM <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public EBINGJDOBOL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x69FB270", Offset = "0x69F9C70", VA = "0x1869FB270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x69FB630", Offset = "0x69FA030", VA = "0x1869FB630", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int CIMOICLMKKP = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<GGCHEMCBMKM> JMLCBLNCIKB;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69FCBE0", Offset = "0x69FB5E0", VA = "0x1869FCBE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x39F2510", Offset = "0x39F0F10", VA = "0x1839F2510")]
		public global::ODHJGGEEIEO<T> LoadResourceAsync<T>(string FNCDIIKMNIG) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69FCAB0", Offset = "0x69FB4B0", VA = "0x1869FCAB0")]
		public global::ODHJGGEEIEO<GameObject> LoadResourceAsync(string FNCDIIKMNIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x69FCA40", Offset = "0x69FB440", VA = "0x1869FCA40")]
		[IteratorStateMachine(typeof(EBINGJDOBOL))]
		private IEnumerator<MEOADLJIECK> JEEGIHECHJK(Queue<GGCHEMCBMKM> OFLALIMFMPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69FCD30", Offset = "0x69FB730", VA = "0x1869FCD30")]
		public ResourcesManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69FC5D0", Offset = "0x69FAFD0", VA = "0x1869FC5D0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69FC280", Offset = "0x69FAC80", VA = "0x1869FC280")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
