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
	public class OFPDOBMFXXP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private sealed class YAKKJUTSMIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OFPDOBMFXXP SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string FRUATEAUAVQ;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public YAKKJUTSMIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8C6BBA0", Offset = "0x8C6A9A0", VA = "0x188C6BBA0")]
			internal void HZZLDUAFAML(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8C6BB00", Offset = "0x8C6A900", VA = "0x188C6BB00")]
			internal void HZUEGNGHRBC(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly OFPDOBMFXXP KLGKFHFOYDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Dictionary<string, GameObject> WEPPGFUQMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<string, GameObject> VFPDUUCPQHF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B530", Offset = "0x8C6A330", VA = "0x188C6B530")]
		public OFPDOBMFXXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B010", Offset = "0x8C69E10", VA = "0x188C6B010", Slot = "1")]
		~OFPDOBMFXXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B2B0", Offset = "0x8C6A0B0", VA = "0x188C6B2B0")]
		private void URVSLUBZSRM(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B270", Offset = "0x8C6A070", VA = "0x188C6B270")]
		public GameObject PMLMWNQSVCA(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B330", Offset = "0x8C6A130", VA = "0x188C6B330")]
		public WCGMKCSPRXW<GameObject> UZXFQXGTPYI(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B1A0", Offset = "0x8C69FA0", VA = "0x188C6B1A0")]
		private GameObject KVVAQFFYNFB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AF40", Offset = "0x8C69D40", VA = "0x188C6AF40")]
		public void ADBONMAGLSN(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B130", Offset = "0x8C69F30", VA = "0x188C6B130")]
		public void IKQPNCAYSXA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C6AB60", Offset = "0x8C69960", VA = "0x188C6AB60")]
		public WCGMKCSPRXW<GameObject> ADBONMAGLSN(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B350", Offset = "0x8C6A150", VA = "0x188C6B350")]
		public bool YFUVYOHYOFL(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class VNLQGITHKMQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E88D00", Offset = "0x3E87B00", VA = "0x183E88D00")]
		public static a GHFZWYYUWMS<a>(string a) where a : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class QTHMXFDOYXQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string EQPUHXMRJOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public RYRERWGHQHB<GameObject> RNTACPTQADO;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8C6B640", Offset = "0x8C6A440", VA = "0x188C6B640")]
			public QTHMXFDOYXQ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class VFMVPEYKGXJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<QTHMXFDOYXQ> DMBJRBYSHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> JNYRQJZXYCC;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public VFMVPEYKGXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8C6BAB0", Offset = "0x8C6A8B0", VA = "0x188C6BAB0")]
			internal bool LDETYSLLYUR()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class FWOAXBNDFFP : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<QTHMXFDOYXQ> DMBJRBYSHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private VFMVPEYKGXJ ANDVUQMLKTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private QTHMXFDOYXQ UBYXZTBOIFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest RTNPVUQVLDI;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public FWOAXBNDFFP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8C6A800", Offset = "0x8C69600", VA = "0x188C6A800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8C6A7C0", Offset = "0x8C695C0", VA = "0x188C6A7C0", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int TJEAJCLKBMI = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<QTHMXFDOYXQ> QEJJYYRQUKK;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B860", Offset = "0x8C6A660", VA = "0x188C6B860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3CDDF90", Offset = "0x3CDCD90", VA = "0x183CDDF90")]
		public WCGMKCSPRXW<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B740", Offset = "0x8C6A540", VA = "0x188C6B740")]
		public WCGMKCSPRXW<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C6B6D0", Offset = "0x8C6A4D0", VA = "0x188C6B6D0")]
		[IteratorStateMachine(typeof(FWOAXBNDFFP))]
		private IEnumerator<XTKXCVTPKYX> BQBGLQQLAHF(Queue<QTHMXFDOYXQ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8C6BA70", Offset = "0x8C6A870", VA = "0x188C6BA70")]
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
