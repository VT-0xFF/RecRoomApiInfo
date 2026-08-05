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
public class GFDGPHDEAEC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class OBOJMHGGENN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public GFDGPHDEAEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public OBOJMHGGENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x58964D0", Offset = "0x58950D0", VA = "0x1858964D0")]
		internal void <CachePrefab>b__0(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5896560", Offset = "0x5895160", VA = "0x185896560")]
		internal void <CachePrefab>b__1(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly GFDGPHDEAEC CGNIFGAGELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private Dictionary<string, GameObject> GKKAKBPHNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<string, GameObject> FGMDKFPDONP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5895A50", Offset = "0x5894650", VA = "0x185895A50")]
	public GFDGPHDEAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5895290", Offset = "0x5893E90", VA = "0x185895290", Slot = "1")]
	~GFDGPHDEAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58958B0", Offset = "0x58944B0", VA = "0x1858958B0")]
	private void OHNBJOACMFN(Scene CKMHEJALMFP, LoadSceneMode HGFDMHLJGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5895870", Offset = "0x5894470", VA = "0x185895870")]
	public GameObject NOBNLBIAMBK(string DAAPEPEGMGB, bool PFHMDODONKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58951F0", Offset = "0x5893DF0", VA = "0x1858951F0")]
	public global::FCECEOPAAFH<GameObject> BKECIIANBEF(string DAAPEPEGMGB, bool PFHMDODONKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5895140", Offset = "0x5893D40", VA = "0x185895140")]
	private GameObject AEAJAEDCBFK(string DAAPEPEGMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5895740", Offset = "0x5894340", VA = "0x185895740")]
	public void MBCDNDBMMEC(string DAAPEPEGMGB, GameObject PAMDOGALOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5895800", Offset = "0x5894400", VA = "0x185895800")]
	public void MJPIICHODJM(string DAAPEPEGMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x58953B0", Offset = "0x5893FB0", VA = "0x1858953B0")]
	public global::FCECEOPAAFH<GameObject> MBCDNDBMMEC(string DAAPEPEGMGB, bool PFHMDODONKJ, bool IAFAKNPFOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5895210", Offset = "0x5893E10", VA = "0x185895210")]
	public bool DHFLELHMAPA(string DAAPEPEGMGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CANKOLNJDDK
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFF630", Offset = "0x3BFE230", VA = "0x183BFF630")]
	public static T LMGAKPACPBJ<T>(string ABEDOAAIHDK) where T : UnityEngine.Object
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
		private class FOBIOAKAMPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string LKMLIBLEOIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public global::DHNNFIFBMBD<GameObject> OMOFCJPIGKF;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x58950C0", Offset = "0x5893CC0", VA = "0x1858950C0")]
			public FOBIOAKAMPH(string LKMLIBLEOIE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FKACDFEFDIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<FOBIOAKAMPH> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public FKACDFEFDIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x5895080", Offset = "0x5893C80", VA = "0x185895080")]
			internal bool <ProcessQueue>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class GHMKCGIDMDH : IEnumerator<OGCDMMFGIGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private OGCDMMFGIGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<FOBIOAKAMPH> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private FKACDFEFDIM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private FOBIOAKAMPH <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private OGCDMMFGIGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FD7D0", Offset = "0x6FC3D0", VA = "0x1806FD7D0")]
			[DebuggerHidden]
			public GHMKCGIDMDH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5896130", Offset = "0x5894D30", VA = "0x185896130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5896480", Offset = "0x5895080", VA = "0x185896480", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int KPLAJCMJEIC = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<FOBIOAKAMPH> IKIFLFAEHAN;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5896760", Offset = "0x5895360", VA = "0x185896760")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA8A0", Offset = "0x1FF94A0", VA = "0x181FFA8A0")]
		public global::FCECEOPAAFH<T> LoadResourceAsync<T>(string LKMLIBLEOIE) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5896660", Offset = "0x5895260", VA = "0x185896660")]
		public global::FCECEOPAAFH<GameObject> LoadResourceAsync(string LKMLIBLEOIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x58965F0", Offset = "0x58951F0", VA = "0x1858965F0")]
		[IteratorStateMachine(typeof(GHMKCGIDMDH))]
		private IEnumerator<OGCDMMFGIGL> DHDKHFPDKCB(Queue<FOBIOAKAMPH> IMIIFABFDDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5896880", Offset = "0x5895480", VA = "0x185896880")]
		public ResourcesManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5895E70", Offset = "0x5894A70", VA = "0x185895E70")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5895B40", Offset = "0x5894740", VA = "0x185895B40")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
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

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
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
