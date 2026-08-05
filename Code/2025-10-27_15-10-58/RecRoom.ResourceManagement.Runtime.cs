using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Async;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class UHKOLRAJDCL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private sealed class IJCSPLUDTQJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public UHKOLRAJDCL FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string ARSBZUVOXEY;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public IJCSPLUDTQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8F10460", Offset = "0x8F0F460", VA = "0x188F10460")]
			internal void BDHYOVJWZTD(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8F103C0", Offset = "0x8F0F3C0", VA = "0x188F103C0")]
			internal void BDCRROPZQHU(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly UHKOLRAJDCL GSHVROXYJFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Dictionary<string, GameObject> ULUQMFGCIQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<string, GameObject> SQNXWLGPJHH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F112A0", Offset = "0x8F102A0", VA = "0x188F112A0")]
		public UHKOLRAJDCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F10DE0", Offset = "0x8F0FDE0", VA = "0x188F10DE0", Slot = "1")]
		~UHKOLRAJDCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F110C0", Offset = "0x8F100C0", VA = "0x188F110C0")]
		private void YWFDKCZLEWI(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F108D0", Offset = "0x8F0F8D0", VA = "0x188F108D0")]
		public GameObject EBMCMLEQRTQ(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8F10DC0", Offset = "0x8F0FDC0", VA = "0x188F10DC0")]
		public EHHKMPWOBWW<GameObject> FMDHGZCOWQO(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F10F00", Offset = "0x8F0FF00", VA = "0x188F10F00")]
		private GameObject MPIZUTYGRER(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F10910", Offset = "0x8F0F910", VA = "0x188F10910")]
		public void EJDYDPVKMMH(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F11050", Offset = "0x8F10050", VA = "0x188F11050")]
		public void RCWDUKFABOQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F109E0", Offset = "0x8F0F9E0", VA = "0x188F109E0")]
		public EHHKMPWOBWW<GameObject> EJDYDPVKMMH(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F10FD0", Offset = "0x8F0FFD0", VA = "0x188F10FD0")]
		public bool PYJLXUSUGTN(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EVEWBIUKNMW
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3881370", Offset = "0x3880370", VA = "0x183881370")]
		public static a HAUCVDTAWJW<a>(string a) where a : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class USHTLADKBOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string QHMKTGTTDUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public TOYEGNJFNVD<GameObject> AUSTWJIEORM;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8F113B0", Offset = "0x8F103B0", VA = "0x188F113B0")]
			public USHTLADKBOE(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HTMXAPREZJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<USHTLADKBOE> AFJBEVYVICQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> RTOYDAIMEGI;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HTMXAPREZJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8F10370", Offset = "0x8F0F370", VA = "0x188F10370")]
			internal bool PEJFBCXVIPB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class FFRTQKUTDQH : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<USHTLADKBOE> AFJBEVYVICQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private HTMXAPREZJT OEEMOVFQUDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private USHTLADKBOE GAQOLPNDAGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest CNOVLIMNSUU;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public FFRTQKUTDQH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8F10010", Offset = "0x8F0F010", VA = "0x188F10010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8F0FFD0", Offset = "0x8F0EFD0", VA = "0x188F0FFD0", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int UFMNPEAEZMO = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<USHTLADKBOE> EBZUSDQPFIE;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F10620", Offset = "0x8F0F620", VA = "0x188F10620")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D64780", Offset = "0x3D63780", VA = "0x183D64780")]
		public EHHKMPWOBWW<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8F10500", Offset = "0x8F0F500", VA = "0x188F10500")]
		public EHHKMPWOBWW<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8F10790", Offset = "0x8F0F790", VA = "0x188F10790")]
		[IteratorStateMachine(typeof(FFRTQKUTDQH))]
		private IEnumerator<UNBASXFCXPD> ZOPMPSYJTYV(Queue<USHTLADKBOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F10890", Offset = "0x8F0F890", VA = "0x188F10890")]
		public ResourcesManager()
		{
		}
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
