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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CKKPNCYLFCX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8A18740", Offset = "0x8A16F40", VA = "0x188A18740")]
			internal void GPVEILSCKNV(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8A186A0", Offset = "0x8A16EA0", VA = "0x188A186A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A191B0", Offset = "0x8A179B0", VA = "0x188A191B0")]
		public JBMOOBUQYEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A188F0", Offset = "0x8A170F0", VA = "0x188A188F0", Slot = "1")]
		~JBMOOBUQYEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A18A10", Offset = "0x8A17210", VA = "0x188A18A10")]
		private void NBPPKCADDIG(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A187E0", Offset = "0x8A16FE0", VA = "0x188A187E0")]
		public GameObject DHJJRAURTZW(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A18B00", Offset = "0x8A17300", VA = "0x188A18B00")]
		public PVOPFDWRLHK<GameObject> SJEXZGDVKMQ(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A18820", Offset = "0x8A17020", VA = "0x188A18820")]
		private GameObject FGDIMUCPOVJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A18F80", Offset = "0x8A17780", VA = "0x188A18F80")]
		public void XVGMHMEENXH(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A18A90", Offset = "0x8A17290", VA = "0x188A18A90")]
		public void QWRSMHVLGJY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A18BA0", Offset = "0x8A173A0", VA = "0x188A18BA0")]
		public PVOPFDWRLHK<GameObject> XVGMHMEENXH(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A18B20", Offset = "0x8A17320", VA = "0x188A18B20")]
		public bool XNFBYXXXKQJ(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class LGPGQAJFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3747B80", Offset = "0x3746380", VA = "0x183747B80")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A19A60", Offset = "0x8A18260", VA = "0x188A19A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PBZSWMUOFRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8A192C0", Offset = "0x8A17AC0", VA = "0x188A192C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public SRNIAOFBHCJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8A196C0", Offset = "0x8A17EC0", VA = "0x188A196C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8A19A20", Offset = "0x8A18220", VA = "0x188A19A20", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A19490", Offset = "0x8A17C90", VA = "0x188A19490")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3A143B0", Offset = "0x3A12BB0", VA = "0x183A143B0")]
		public PVOPFDWRLHK<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A19380", Offset = "0x8A17B80", VA = "0x188A19380")]
		public PVOPFDWRLHK<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A19310", Offset = "0x8A17B10", VA = "0x188A19310")]
		[IteratorStateMachine(typeof(SRNIAOFBHCJ))]
		private IEnumerator<YTAMKWOJLST> GZCSOSSGNBJ(Queue<VBASBCBKWVA> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A19680", Offset = "0x8A17E80", VA = "0x188A19680")]
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
