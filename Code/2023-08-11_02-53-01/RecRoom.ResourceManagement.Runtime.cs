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
		private class KNIHJCBMHBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string BFLDEPAGJMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public NBKOKFNHPDK<GameObject> JKKHPKEDPHI;

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6F12050", Offset = "0x6F10850", VA = "0x186F12050")]
			public KNIHJCBMHBD(string BFLDEPAGJMC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class CENGMEPCMAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Queue<KNIHJCBMHBD> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
			public CENGMEPCMAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6F113B0", Offset = "0x6F0FBB0", VA = "0x186F113B0")]
			internal bool BIADIKHOJPD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class KPGLAIEJGMC : IEnumerator<EPHOKNIGMNK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private EPHOKNIGMNK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Queue<KNIHJCBMHBD> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ResourcesManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private CENGMEPCMAB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private KNIHJCBMHBD <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private EPHOKNIGMNK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
			[DebuggerHidden]
			public KPGLAIEJGMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F120E0", Offset = "0x6F108E0", VA = "0x186F120E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F124C0", Offset = "0x6F10CC0", VA = "0x186F124C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const int KAJMFNMJDHI = 2;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Queue<KNIHJCBMHBD> OOIGICINHCA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F126C0", Offset = "0x6F10EC0", VA = "0x186F126C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3926370", Offset = "0x3924B70", VA = "0x183926370")]
		public JJMNNLLBAJO<T> LoadResourceAsync<T>(string BFLDEPAGJMC) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F12500", Offset = "0x6F10D00", VA = "0x186F12500")]
		public JJMNNLLBAJO<GameObject> LoadResourceAsync(string BFLDEPAGJMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F12630", Offset = "0x6F10E30", VA = "0x186F12630")]
		[IteratorStateMachine(typeof(KPGLAIEJGMC))]
		private IEnumerator<EPHOKNIGMNK> PEIHPLHLIPP(Queue<KNIHJCBMHBD> JBKCICGKJOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F12810", Offset = "0x6F11010", VA = "0x186F12810")]
		public ResourcesManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PEDLHONNOHK
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22F7190", Offset = "0x22F5990", VA = "0x1822F7190")]
	public static T CNBHFOPOBJH<T>(string NFJIPFJDKNL) where T : UnityEngine.Object
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GMGEPCOKGEN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IFPDKHDKNLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public GMGEPCOKGEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IFPDKHDKNLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F11F10", Offset = "0x6F10710", VA = "0x186F11F10")]
		internal void DKCBAAFPBNN(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F11FB0", Offset = "0x6F107B0", VA = "0x186F11FB0")]
		internal void IEOFCMEPHNE(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly GMGEPCOKGEN NMCHDHHCPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<string, GameObject> KJOFCNNJOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Dictionary<string, GameObject> DJIPLDIOJCH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F11DE0", Offset = "0x6F105E0", VA = "0x186F11DE0")]
	public GMGEPCOKGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F115C0", Offset = "0x6F0FDC0", VA = "0x186F115C0", Slot = "1")]
	~GMGEPCOKGEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F11BB0", Offset = "0x6F103B0", VA = "0x186F11BB0")]
	private void KMLDKIGIEOC(Scene JJIAFDKCLGJ, LoadSceneMode EAIHECKIMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F11C30", Offset = "0x6F10430", VA = "0x186F11C30")]
	public GameObject OBCAGOMIKBP(string NECMDMMFDDJ, bool CMCJPIHNLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F11B90", Offset = "0x6F10390", VA = "0x186F11B90")]
	public JJMNNLLBAJO<GameObject> JOHNLNAIDGB(string NECMDMMFDDJ, bool CMCJPIHNLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F11480", Offset = "0x6F0FC80", VA = "0x186F11480")]
	private GameObject DLGEAHMODBK(string NECMDMMFDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F11AB0", Offset = "0x6F102B0", VA = "0x186F11AB0")]
	public void HHJGIBEAONJ(string NECMDMMFDDJ, GameObject ALNJPMNLFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F11550", Offset = "0x6F0FD50", VA = "0x186F11550")]
	public void FGMMJFHBMHF(string NECMDMMFDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F116E0", Offset = "0x6F0FEE0", VA = "0x186F116E0")]
	public JJMNNLLBAJO<GameObject> HHJGIBEAONJ(string NECMDMMFDDJ, bool CMCJPIHNLBN, bool CFJBACLAOGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F11400", Offset = "0x6F0FC00", VA = "0x186F11400")]
	public bool CBNFPGFNEEN(string NECMDMMFDDJ)
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
