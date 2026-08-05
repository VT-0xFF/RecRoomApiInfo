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
	public class KWZBNDWHJSW
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private sealed class RPXDXIRZXRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KWZBNDWHJSW MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string RTPOALIBRZR;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RPXDXIRZXRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8A6B080", Offset = "0x8A6A480", VA = "0x188A6B080")]
			internal void NLXOGYDOEUE(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8A6B120", Offset = "0x8A6A520", VA = "0x188A6B120")]
			internal void NMCVEEXLOFN(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly KWZBNDWHJSW LPDGRYIEPOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Dictionary<string, GameObject> AMEZMCEKPOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<string, GameObject> HEMFYILVEAG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AF70", Offset = "0x8A6A370", VA = "0x188A6AF70")]
		public KWZBNDWHJSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A5A0", Offset = "0x8A699A0", VA = "0x188A6A5A0", Slot = "1")]
		~KWZBNDWHJSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A7A0", Offset = "0x8A69BA0", VA = "0x188A6A7A0")]
		private void PVINJNUQVXN(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A760", Offset = "0x8A69B60", VA = "0x188A6A760")]
		public GameObject OMYKZWBIJJH(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A6C0", Offset = "0x8A69AC0", VA = "0x188A6A6C0")]
		public SPVBYBYHFON<GameObject> IBSYGYBFCKL(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A6ACD0", Offset = "0x8A6A0D0", VA = "0x188A6ACD0")]
		private GameObject RFQXBKNUMBO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A6AC00", Offset = "0x8A6A000", VA = "0x188A6AC00")]
		public void QBRPTSXNQNU(string a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A6ADA0", Offset = "0x8A6A1A0", VA = "0x188A6ADA0")]
		public void WKNPAJUJFLT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A820", Offset = "0x8A69C20", VA = "0x188A6A820")]
		public SPVBYBYHFON<GameObject> QBRPTSXNQNU(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6A6E0", Offset = "0x8A69AE0", VA = "0x188A6A6E0")]
		public bool OGTXTEQGHTY(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OPPKVMTUCEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x386E830", Offset = "0x386DC30", VA = "0x18386E830")]
		public static a NFOSVFIGMQL<a>(string a) where a : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ResourcesManager : SingletonMonoBehaviour<ResourcesManager>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class XHFHSSYPSAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string YDNSUBBQLNT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ZXQVDMQSZDC<GameObject> UAAAFZPRYNF;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8A6B570", Offset = "0x8A6A970", VA = "0x188A6B570")]
			public XHFHSSYPSAP(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<XHFHSSYPSAP> GVUWMCOWTGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> GRJPJADMRTR;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A1B0", Offset = "0x8A695B0", VA = "0x188A6A1B0")]
			internal bool LYLNXHFRGDS()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class IYHWHHNLWKU : IEnumerator<EXCEMTVEEEU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private EXCEMTVEEEU JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<XHFHSSYPSAP> GVUWMCOWTGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private EOXEHAWLLLA MOZJTUCKZRH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private XHFHSSYPSAP JCVQDCCKJDQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest ZFPDVJEJWVL;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private EXCEMTVEEEU RGLTPZKGWZB
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public IYHWHHNLWKU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A240", Offset = "0x8A69640", VA = "0x188A6A240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A200", Offset = "0x8A69600", VA = "0x188A6A200", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int CCAFPOEBPNP = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<XHFHSSYPSAP> BTZMDMQFXVD;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B340", Offset = "0x8A6A740", VA = "0x188A6B340")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3A45130", Offset = "0x3A44530", VA = "0x183A45130")]
		public SPVBYBYHFON<T> LoadResourceAsync<T>(string assetName) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B1C0", Offset = "0x8A6A5C0", VA = "0x188A6B1C0")]
		public SPVBYBYHFON<GameObject> LoadResourceAsync(string assetName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B2D0", Offset = "0x8A6A6D0", VA = "0x188A6B2D0")]
		[IteratorStateMachine(typeof(IYHWHHNLWKU))]
		private IEnumerator<EXCEMTVEEEU> QTRHBOXGUCO(Queue<XHFHSSYPSAP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A6B530", Offset = "0x8A6A930", VA = "0x188A6B530")]
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
