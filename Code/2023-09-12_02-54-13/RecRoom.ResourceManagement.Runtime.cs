using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		private class NOOBDIJNKHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string PMDLHJHOCKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KLOLCAIIKNK<GameObject> BLNJACJPPFL;

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x720FD80", Offset = "0x720F180", VA = "0x18720FD80")]
			public NOOBDIJNKHJ(string PMDLHJHOCKD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class OBLDEHAOCKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Queue<NOOBDIJNKHJ> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public OBLDEHAOCKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x720FE10", Offset = "0x720F210", VA = "0x18720FE10")]
			internal bool BKEFNAOIPEM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class LNPOHJEKGLN : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private PHFLFKPMCCG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Queue<NOOBDIJNKHJ> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ResourcesManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private OBLDEHAOCKM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private NOOBDIJNKHJ <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public LNPOHJEKGLN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x720F9B0", Offset = "0x720EDB0", VA = "0x18720F9B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x720FD40", Offset = "0x720F140", VA = "0x18720FD40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const int EBCLFLNCEAI = 2;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Queue<NOOBDIJNKHJ> OBBOBAHGJJF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7210020", Offset = "0x720F420", VA = "0x187210020")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3787500", Offset = "0x3786900", VA = "0x183787500")]
		public KDCMFGDLEKL<T> LoadResourceAsync<T>(string PMDLHJHOCKD) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x720FEF0", Offset = "0x720F2F0", VA = "0x18720FEF0")]
		public KDCMFGDLEKL<GameObject> LoadResourceAsync(string PMDLHJHOCKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x720FE60", Offset = "0x720F260", VA = "0x18720FE60")]
		[IteratorStateMachine(typeof(LNPOHJEKGLN))]
		private IEnumerator<PHFLFKPMCCG> HMDDLGGFHON(Queue<NOOBDIJNKHJ> CLAOAKAOJHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7210170", Offset = "0x720F570", VA = "0x187210170")]
		public ResourcesManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MIODBDJAAMG
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1B2AF00", Offset = "0x1B2A300", VA = "0x181B2AF00")]
	public static T NFMOHMANDNN<T>(string GBGNJPBFOBA) where T : UnityEngine.Object
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EJMOEABHJAP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HNOGDPJFLBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EJMOEABHJAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HNOGDPJFLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x720F910", Offset = "0x720ED10", VA = "0x18720F910")]
		internal void MHPOJLFMHBB(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x720F870", Offset = "0x720EC70", VA = "0x18720F870")]
		internal void KMICJJADNEB(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly EJMOEABHJAP LKHBAJOJOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<string, GameObject> ONFMBKBEBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Dictionary<string, GameObject> HCGFMENNAGL;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x720F740", Offset = "0x720EB40", VA = "0x18720F740")]
	public EJMOEABHJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x720EDE0", Offset = "0x720E1E0", VA = "0x18720EDE0", Slot = "1")]
	~EJMOEABHJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x720ED60", Offset = "0x720E160", VA = "0x18720ED60")]
	private void DPBHDGIACEL(Scene PJOBCGNOOBP, LoadSceneMode CALBOODFAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x720F3B0", Offset = "0x720E7B0", VA = "0x18720F3B0")]
	public GameObject JCPMIHHKPOJ(string KNPFDHANMOI, bool IPJBNPBGHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x720F3F0", Offset = "0x720E7F0", VA = "0x18720F3F0")]
	public KDCMFGDLEKL<GameObject> MBFFOPDKEBL(string KNPFDHANMOI, bool IPJBNPBGHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x720F410", Offset = "0x720E810", VA = "0x18720F410")]
	private GameObject MEBLBGLIJCG(string KNPFDHANMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x720EF00", Offset = "0x720E300", VA = "0x18720EF00")]
	public void IAEGGKGKMCH(string KNPFDHANMOI, GameObject OGOBDKNMJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x720F560", Offset = "0x720E960", VA = "0x18720F560")]
	public void PPBEOBEAEAD(string KNPFDHANMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x720EFE0", Offset = "0x720E3E0", VA = "0x18720EFE0")]
	public KDCMFGDLEKL<GameObject> IAEGGKGKMCH(string KNPFDHANMOI, bool IPJBNPBGHKA, bool OLDHENPAJPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x720F4E0", Offset = "0x720E8E0", VA = "0x18720F4E0")]
	public bool NNNOGOBKBIG(string KNPFDHANMOI)
	{
		return default(bool);
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
