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
public class HLLOCAEEOBF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class IKKECCOCNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public HLLOCAEEOBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
		public IKKECCOCNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4FD7A70", Offset = "0x4FD6C70", VA = "0x184FD7A70")]
		internal void <CachePrefab>b__0(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4FD7B00", Offset = "0x4FD6D00", VA = "0x184FD7B00")]
		internal void <CachePrefab>b__1(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly HLLOCAEEOBF EAFCLEKLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private Dictionary<string, GameObject> APGPLHFNFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<string, GameObject> ALOCCMJLDEI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4FD7980", Offset = "0x4FD6B80", VA = "0x184FD7980")]
	public HLLOCAEEOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4FD70E0", Offset = "0x4FD62E0", VA = "0x184FD70E0", Slot = "1")]
	~HLLOCAEEOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4FD7730", Offset = "0x4FD6930", VA = "0x184FD7730")]
	private void OFMBCKLHFGE(Scene OCGCBAEOKLF, LoadSceneMode FHAMOGHOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4FD7280", Offset = "0x4FD6480", VA = "0x184FD7280")]
	public GameObject JOECEJLJLLK(string GDNBKFMLBGF, bool KGAAHMEIFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4FD72C0", Offset = "0x4FD64C0", VA = "0x184FD72C0")]
	public global::IAGOKENNLHI<GameObject> MAHJMBKEAAF(string GDNBKFMLBGF, bool KGAAHMEIFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4FD77A0", Offset = "0x4FD69A0", VA = "0x184FD77A0")]
	private GameObject OMJGKCBNFCD(string GDNBKFMLBGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4FD72E0", Offset = "0x4FD64E0", VA = "0x184FD72E0")]
	public void MHAJCBIOGLM(string GDNBKFMLBGF, GameObject LKMDFAIEDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4FD73A0", Offset = "0x4FD65A0", VA = "0x184FD73A0")]
	public global::IAGOKENNLHI<GameObject> MHAJCBIOGLM(string GDNBKFMLBGF, bool KGAAHMEIFJI, bool DLJJOOJEIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FD7200", Offset = "0x4FD6400", VA = "0x184FD7200")]
	public bool IMJDHMNAHGG(string GDNBKFMLBGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FJNFDODGMAC
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x193B6F0", Offset = "0x193A8F0", VA = "0x18193B6F0")]
	public static T KFMMBHEKOJI<T>(string ONIMCFGGJHN) where T : UnityEngine.Object
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
		private class BCDIDBKIIFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string MHBHCDFJKOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public global::CJNJOHDMLHP<GameObject> KDLMOPBIKOO;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x4FD6A30", Offset = "0x4FD5C30", VA = "0x184FD6A30")]
			public BCDIDBKIIFG(string MHBHCDFJKOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EPDKOMJCEIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<BCDIDBKIIFG> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public EPDKOMJCEIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4FD6AB0", Offset = "0x4FD5CB0", VA = "0x184FD6AB0")]
			internal bool <ProcessQueue>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class NLJBOLDJFFF : IEnumerator<MFHKIJODCKI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private MFHKIJODCKI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<BCDIDBKIIFG> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private EPDKOMJCEIF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private BCDIDBKIIFG <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private MFHKIJODCKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x574120", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x604130", Offset = "0x603330", VA = "0x180604130")]
			[DebuggerHidden]
			public NLJBOLDJFFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x4FD7B90", Offset = "0x4FD6D90", VA = "0x184FD7B90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x4FD7EE0", Offset = "0x4FD70E0", VA = "0x184FD7EE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int GMKPNEPBGMP = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<BCDIDBKIIFG> KKAENHAOCKO;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4FD80A0", Offset = "0x4FD72A0", VA = "0x184FD80A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x19C7CA0", Offset = "0x19C6EA0", VA = "0x1819C7CA0")]
		public global::IAGOKENNLHI<T> LoadResourceAsync<T>(string MHBHCDFJKOH) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4FD7F30", Offset = "0x4FD7130", VA = "0x184FD7F30")]
		public global::IAGOKENNLHI<GameObject> LoadResourceAsync(string MHBHCDFJKOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8030", Offset = "0x4FD7230", VA = "0x184FD8030")]
		[IteratorStateMachine(typeof(NLJBOLDJFFF))]
		private IEnumerator<MFHKIJODCKI> PBCPMHEEAMA(Queue<BCDIDBKIIFG> CFPMOBDGPJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4FD81C0", Offset = "0x4FD73C0", VA = "0x184FD81C0")]
		public ResourcesManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FNGEDJFFIEL
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] JKCEPOEAODE;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int HMIFPHDBAAL;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int JLNLCKONFPG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger EBGIPPCOABB;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNGEDJFFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6AF0", Offset = "0x4FD5CF0", VA = "0x184FD6AF0")]
	private static string CHCKGNJAKBF(byte[] CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6BF0", Offset = "0x4FD5DF0", VA = "0x184FD6BF0")]
	public static string PEFJMDOFNMG(byte[] PKBLLNJJAGK, bool HCHELKBPHNG)
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

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
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
