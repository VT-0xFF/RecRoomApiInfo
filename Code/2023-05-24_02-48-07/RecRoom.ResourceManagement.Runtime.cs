using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class BGJGLEFOOKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string GKPAICDJKCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public global::GBNOCCBNCBC<GameObject> AICEHFEIDDL;

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9F60", Offset = "0x6FC8B60", VA = "0x186FC9F60")]
			public BGJGLEFOOKM(string GKPAICDJKCF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class OHMONODEBJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Queue<BGJGLEFOOKM> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public OHMONODEBJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6FCB070", Offset = "0x6FC9C70", VA = "0x186FCB070")]
			internal bool KIHIHDMOFJO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class FJCMGMLADBF : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private EDDHBDCNFKM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Queue<BGJGLEFOOKM> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ResourcesManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private OHMONODEBJP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private BGJGLEFOOKM <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
			[DebuggerHidden]
			public FJCMGMLADBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6FCAC70", Offset = "0x6FC9870", VA = "0x186FCAC70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6FCB030", Offset = "0x6FC9C30", VA = "0x186FCB030", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const int GIFPCENDNDK = 2;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Queue<BGJGLEFOOKM> NEDJFCCBDDD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB280", Offset = "0x6FC9E80", VA = "0x186FCB280")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3C95BC0", Offset = "0x3C947C0", VA = "0x183C95BC0")]
		public global::NBFPPJGKGOH<T> LoadResourceAsync<T>(string GKPAICDJKCF) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB150", Offset = "0x6FC9D50", VA = "0x186FCB150")]
		public global::NBFPPJGKGOH<GameObject> LoadResourceAsync(string GKPAICDJKCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB0C0", Offset = "0x6FC9CC0", VA = "0x186FCB0C0")]
		[IteratorStateMachine(typeof(FJCMGMLADBF))]
		private IEnumerator<EDDHBDCNFKM> CMLPNALAHKD(Queue<BGJGLEFOOKM> MCCOEGJFPHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB3D0", Offset = "0x6FC9FD0", VA = "0x186FCB3D0")]
		public ResourcesManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KJBGCGPOGJG
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x365C600", Offset = "0x365B200", VA = "0x18365C600")]
	public static T CHEOBHKAFJE<T>(string FMALCPACLGP) where T : UnityEngine.Object
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FILNLIMAINC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BMKFIMEJLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public FILNLIMAINC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BMKFIMEJLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA090", Offset = "0x6FC8C90", VA = "0x186FCA090")]
		internal void EKPBDHLIOHF(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9FF0", Offset = "0x6FC8BF0", VA = "0x186FC9FF0")]
		internal void BNGDDPBNPBI(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly FILNLIMAINC AKFGOJKPFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<string, GameObject> FPDAAFHBKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Dictionary<string, GameObject> KEPMLIGHEBN;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FCAB40", Offset = "0x6FC9740", VA = "0x186FCAB40")]
	public FILNLIMAINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA690", Offset = "0x6FC9290", VA = "0x186FCA690", Slot = "1")]
	~FILNLIMAINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA130", Offset = "0x6FC8D30", VA = "0x186FCA130")]
	private void DNMCENGCAOO(Scene IKOPIEMNEKF, LoadSceneMode GGEPKHEIMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA8C0", Offset = "0x6FC94C0", VA = "0x186FCA8C0")]
	public GameObject LKCDPDOJKII(string JKENAADABML, bool KHEEMKJFLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA8A0", Offset = "0x6FC94A0", VA = "0x186FCA8A0")]
	public global::NBFPPJGKGOH<GameObject> LBNLAHFCNCM(string JKENAADABML, bool KHEEMKJFLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA900", Offset = "0x6FC9500", VA = "0x186FCA900")]
	private GameObject MCCAOAEGHAN(string JKENAADABML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA1B0", Offset = "0x6FC8DB0", VA = "0x186FCA1B0")]
	public void FAEBKLHPPDM(string JKENAADABML, GameObject OGIDMIHPCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA7B0", Offset = "0x6FC93B0", VA = "0x186FCA7B0")]
	public void GFKABKLCAOK(string JKENAADABML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA290", Offset = "0x6FC8E90", VA = "0x186FCA290")]
	public global::NBFPPJGKGOH<GameObject> FAEBKLHPPDM(string JKENAADABML, bool KHEEMKJFLMI, bool ELEDAFPMHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA820", Offset = "0x6FC9420", VA = "0x186FCA820")]
	public bool KCEBLMHLNEC(string JKENAADABML)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
