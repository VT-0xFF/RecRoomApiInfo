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
	public class JBMOOBUQYEF
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private sealed class CKKPNCYLFCX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public JBMOOBUQYEF VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string RJTWKVNYEDA;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CKKPNCYLFCX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8B1AA90", Offset = "0x8B19490", VA = "0x188B1AA90")]
			internal void GPVEILSCKNV(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8B1A9F0", Offset = "0x8B193F0", VA = "0x188B1A9F0")]
			internal void GPPXLEYFBCM(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly JBMOOBUQYEF TTIZOBUFQHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Dictionary<string, GameObject> UMQSLDGUXVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<string, GameObject> ZBUBAFILCUX;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B500", Offset = "0x8B19F00", VA = "0x188B1B500")]
		public JBMOOBUQYEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AC40", Offset = "0x8B19640", VA = "0x188B1AC40", Slot = "1")]
		~JBMOOBUQYEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AD60", Offset = "0x8B19760", VA = "0x188B1AD60")]
		private void NBPPKCADDIG(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AB30", Offset = "0x8B19530", VA = "0x188B1AB30")]
		public GameObject DHJJRAURTZW(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AE50", Offset = "0x8B19850", VA = "0x188B1AE50")]
		public PVOPFDWRLHK<GameObject> SJEXZGDVKMQ(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AB70", Offset = "0x8B19570", VA = "0x188B1AB70")]
		private GameObject FGDIMUCPOVJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B2D0", Offset = "0x8B19CD0", VA = "0x188B1B2D0")]
		public void XVGMHMEENXH(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B1ADE0", Offset = "0x8B197E0", VA = "0x188B1ADE0")]
		public void QWRSMHVLGJY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AEF0", Offset = "0x8B198F0", VA = "0x188B1AEF0")]
		public PVOPFDWRLHK<GameObject> XVGMHMEENXH(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AE70", Offset = "0x8B19870", VA = "0x188B1AE70")]
		public bool XNFBYXXXKQJ(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class LGPGQAJFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37619B0", Offset = "0x37603B0", VA = "0x1837619B0")]
		public static a HXHEMZNNYAG<a>(string a) where a : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class VBASBCBKWVA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string SGDFGIJBRFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ASLDKLWEVEH<GameObject> BCGUMWNTOSM;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B1BDB0", Offset = "0x8B1A7B0", VA = "0x188B1BDB0")]
			public VBASBCBKWVA(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PBZSWMUOFRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<VBASBCBKWVA> HZHLYVZJFSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> VRMPKGMRFAW;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PBZSWMUOFRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B1B610", Offset = "0x8B1A010", VA = "0x188B1B610")]
			internal bool KGLYTAFXZSV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class SRNIAOFBHCJ : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<VBASBCBKWVA> HZHLYVZJFSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private PBZSWMUOFRV KUKOITOJGQQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private VBASBCBKWVA CKBPHRGCZZX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest IHMWGYYEDRI;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public SRNIAOFBHCJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B1BA10", Offset = "0x8B1A410", VA = "0x188B1BA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8B1BD70", Offset = "0x8B1A770", VA = "0x188B1BD70", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int OKGMXJZDBLW = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<VBASBCBKWVA> DLCXTYWHDQO;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B7E0", Offset = "0x8B1A1E0", VA = "0x188B1B7E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3A2CB90", Offset = "0x3A2B590", VA = "0x183A2CB90")]
		public PVOPFDWRLHK<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B6D0", Offset = "0x8B1A0D0", VA = "0x188B1B6D0")]
		public PVOPFDWRLHK<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B660", Offset = "0x8B1A060", VA = "0x188B1B660")]
		[IteratorStateMachine(typeof(SRNIAOFBHCJ))]
		private IEnumerator<YTAMKWOJLST> GZCSOSSGNBJ(Queue<VBASBCBKWVA> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B9D0", Offset = "0x8B1A3D0", VA = "0x188B1B9D0")]
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
