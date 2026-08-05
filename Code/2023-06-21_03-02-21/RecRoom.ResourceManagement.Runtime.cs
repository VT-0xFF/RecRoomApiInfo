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
		private class JIAPCBDAGEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string PCPHHGOABPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public JFMAKJPJKJA<GameObject> AIJCKJJIIGI;

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x158BAF0", Offset = "0x158ACF0", VA = "0x18158BAF0")]
			public JIAPCBDAGEJ(string PCPHHGOABPC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BPCGGINNCMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Queue<JIAPCBDAGEJ> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public BPCGGINNCMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x158AF90", Offset = "0x158A190", VA = "0x18158AF90")]
			internal bool FBOPCKMJLCC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JMIKMJFBCDN : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private HGAIOCFFOOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Queue<JIAPCBDAGEJ> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ResourcesManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private BPCGGINNCMN <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private JIAPCBDAGEJ <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
			[DebuggerHidden]
			public JMIKMJFBCDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x158BB80", Offset = "0x158AD80", VA = "0x18158BB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x158BF60", Offset = "0x158B160", VA = "0x18158BF60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const int JIKKHJBOBAK = 2;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Queue<JIAPCBDAGEJ> DJGOEIOJNHJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x158C160", Offset = "0x158B360", VA = "0x18158C160")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4258710", Offset = "0x4257910", VA = "0x184258710")]
		public NHJDNADPIAN<T> LoadResourceAsync<T>(string PCPHHGOABPC) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x158C030", Offset = "0x158B230", VA = "0x18158C030")]
		public NHJDNADPIAN<GameObject> LoadResourceAsync(string PCPHHGOABPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x158BFA0", Offset = "0x158B1A0", VA = "0x18158BFA0")]
		[IteratorStateMachine(typeof(JMIKMJFBCDN))]
		private IEnumerator<HGAIOCFFOOA> CCKBFDMMDKK(Queue<JIAPCBDAGEJ> JMMNJJCIEMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x158C2B0", Offset = "0x158B4B0", VA = "0x18158C2B0")]
		public ResourcesManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FMGPNGCHIOL
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x383B0C0", Offset = "0x383A2C0", VA = "0x18383B0C0")]
	public static T DDIIJNLFAHP<T>(string KMBFNDAPCGA) where T : UnityEngine.Object
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DGPPJJOFMJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AJKHCMKHEOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DGPPJJOFMJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AJKHCMKHEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x158AE50", Offset = "0x158A050", VA = "0x18158AE50")]
		internal void APMDCLOJNKF(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x158AEF0", Offset = "0x158A0F0", VA = "0x18158AEF0")]
		internal void JDEOLGKCEEN(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DGPPJJOFMJJ EKJMFOBBBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<string, GameObject> GJFPINNBENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Dictionary<string, GameObject> CPIKLLEJINN;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x158B9C0", Offset = "0x158ABC0", VA = "0x18158B9C0")]
	public DGPPJJOFMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x158B0D0", Offset = "0x158A2D0", VA = "0x18158B0D0", Slot = "1")]
	~DGPPJJOFMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x158B7D0", Offset = "0x158A9D0", VA = "0x18158B7D0")]
	private void PMPJBNFDBFD(Scene EPBAFGFEGFJ, LoadSceneMode OOEIEGHCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x158B790", Offset = "0x158A990", VA = "0x18158B790")]
	public GameObject NMONBJKILOB(string LOPGCKODAFJ, bool HMLKEPFLANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x158AFE0", Offset = "0x158A1E0", VA = "0x18158AFE0")]
	public NHJDNADPIAN<GameObject> CDDDDKPPFGK(string LOPGCKODAFJ, bool HMLKEPFLANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x158B000", Offset = "0x158A200", VA = "0x18158B000")]
	private GameObject FBJEGBDELKP(string LOPGCKODAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x158B270", Offset = "0x158A470", VA = "0x18158B270")]
	public void IGDAMJMMDKO(string LOPGCKODAFJ, GameObject AHDDCNOKJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x158B720", Offset = "0x158A920", VA = "0x18158B720")]
	public void JDPBNOOIAGC(string LOPGCKODAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x158B350", Offset = "0x158A550", VA = "0x18158B350")]
	public NHJDNADPIAN<GameObject> IGDAMJMMDKO(string LOPGCKODAFJ, bool HMLKEPFLANN, bool MNOMNJBMMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x158B1F0", Offset = "0x158A3F0", VA = "0x18158B1F0")]
	public bool GKFBCGNHOEB(string LOPGCKODAFJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
