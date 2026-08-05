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
		private class HDAOMPNDEMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string HNOBDEPNIBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public EAELMMECBND<GameObject> LPMJENPJDAP;

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1922170", Offset = "0x1920F70", VA = "0x181922170")]
			public HDAOMPNDEMP(string HNOBDEPNIBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class NALJKCMDEGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Queue<HDAOMPNDEMP> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public NALJKCMDEGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1922200", Offset = "0x1921000", VA = "0x181922200")]
			internal bool NLAFGGHCPJF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class GJFABOBKIDG : IEnumerator<PONKBHEDEAE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private PONKBHEDEAE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Queue<HDAOMPNDEMP> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ResourcesManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private NALJKCMDEGA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private HDAOMPNDEMP <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private PONKBHEDEAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x91F900", Offset = "0x91E700", VA = "0x18091F900")]
			[DebuggerHidden]
			public GJFABOBKIDG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1921D70", Offset = "0x1920B70", VA = "0x181921D70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1922130", Offset = "0x1920F30", VA = "0x181922130", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const int EIFDNNLHEJG = 2;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Queue<HDAOMPNDEMP> PNOFEOEMEML;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1922410", Offset = "0x1921210", VA = "0x181922410")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x407EB50", Offset = "0x407D950", VA = "0x18407EB50")]
		public AHPDIJDJLKD<T> LoadResourceAsync<T>(string HNOBDEPNIBA) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x19222E0", Offset = "0x19210E0", VA = "0x1819222E0")]
		public AHPDIJDJLKD<GameObject> LoadResourceAsync(string HNOBDEPNIBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1922250", Offset = "0x1921050", VA = "0x181922250")]
		[IteratorStateMachine(typeof(GJFABOBKIDG))]
		private IEnumerator<PONKBHEDEAE> LHLNLOCIOMI(Queue<HDAOMPNDEMP> OFMJJGAFNMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1922560", Offset = "0x1921360", VA = "0x181922560")]
		public ResourcesManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BLIAMOJJKOG
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4513320", Offset = "0x4512120", VA = "0x184513320")]
	public static T NAPFCFGOEAK<T>(string EMNEBALMLGH) where T : UnityEngine.Object
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EFDIKEKIFFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BKKFPBJJDJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EFDIKEKIFFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BKKFPBJJDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x19210F0", Offset = "0x191FEF0", VA = "0x1819210F0")]
		internal void JJDMAPJGMEP(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1921190", Offset = "0x191FF90", VA = "0x181921190")]
		internal void OMDMGDLEKDO(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly EFDIKEKIFFJ NLCMFLAHDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<string, GameObject> ECAGFMJFDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Dictionary<string, GameObject> FACAPEALDPO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1921C40", Offset = "0x1920A40", VA = "0x181921C40")]
	public EFDIKEKIFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1921730", Offset = "0x1920530", VA = "0x181921730", Slot = "1")]
	~EFDIKEKIFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x19218C0", Offset = "0x19206C0", VA = "0x1819218C0")]
	private void OOJNKLJPMJJ(Scene MFGLJIKGLMN, LoadSceneMode CLBCNDPJEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1921A90", Offset = "0x1920890", VA = "0x181921A90")]
	public GameObject PLJOBCBLGFI(string FDDFNICFOOO, bool KJNOMEJIEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1921230", Offset = "0x1920030", VA = "0x181921230")]
	public AHPDIJDJLKD<GameObject> EEKCBEPAHNF(string FDDFNICFOOO, bool KJNOMEJIEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x19219C0", Offset = "0x19207C0", VA = "0x1819219C0")]
	private GameObject PBJKKNPNGJC(string FDDFNICFOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1921650", Offset = "0x1920450", VA = "0x181921650")]
	public void FHMJDFODOKI(string FDDFNICFOOO, GameObject NDMDIDJLLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1921850", Offset = "0x1920650", VA = "0x181921850")]
	public void LEHDMDBPLLI(string FDDFNICFOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1921250", Offset = "0x1920050", VA = "0x181921250")]
	public AHPDIJDJLKD<GameObject> FHMJDFODOKI(string FDDFNICFOOO, bool KJNOMEJIEMG, bool KKPADAGHKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1921940", Offset = "0x1920740", VA = "0x181921940")]
	public bool OPKBLNFFGDA(string FDDFNICFOOO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
