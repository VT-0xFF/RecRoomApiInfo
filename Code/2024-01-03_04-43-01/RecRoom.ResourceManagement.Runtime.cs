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
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NGNEADECKAP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PEHIFCMHGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public NGNEADECKAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public PEHIFCMHGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63BF7A0", Offset = "0x63BE3A0", VA = "0x1863BF7A0")]
		internal void DGKFHOIBMPC(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63BF840", Offset = "0x63BE440", VA = "0x1863BF840")]
		internal void NDHMHDHCMPK(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly NGNEADECKAP OKJEMPCIPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private Dictionary<string, GameObject> HNICPCAMJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<string, GameObject> ILOHNOLAGPO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63BF670", Offset = "0x63BE270", VA = "0x1863BF670")]
	public NGNEADECKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63BED40", Offset = "0x63BD940", VA = "0x1863BED40", Slot = "1")]
	~NGNEADECKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63BF370", Offset = "0x63BDF70", VA = "0x1863BF370")]
	private void HOGBLEPDMAB(Scene LLAJBOAGJHA, LoadSceneMode KBLMDIMGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63BEE70", Offset = "0x63BDA70", VA = "0x1863BEE70")]
	public GameObject HCJCHHFNKEP(string CDJCGCBIKKC, bool ENBCNIKKNGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63BEC50", Offset = "0x63BD850", VA = "0x1863BEC50")]
	public HPJLJGHAIKN<GameObject> ENCJKEICGBF(string CDJCGCBIKKC, bool ENBCNIKKNGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63BEC70", Offset = "0x63BD870", VA = "0x1863BEC70")]
	private GameObject FEJGCJOPEJP(string CDJCGCBIKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x63BEEB0", Offset = "0x63BDAB0", VA = "0x1863BEEB0")]
	public void HIEEICJNNGK(string CDJCGCBIKKC, GameObject NMGALPBKFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x63BF470", Offset = "0x63BE070", VA = "0x1863BF470")]
	public void NIBJAKELKIL(string CDJCGCBIKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x63BEF80", Offset = "0x63BDB80", VA = "0x1863BEF80")]
	public HPJLJGHAIKN<GameObject> HIEEICJNNGK(string CDJCGCBIKKC, bool ENBCNIKKNGC, bool GLAPBLAEAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x63BF3F0", Offset = "0x63BDFF0", VA = "0x1863BF3F0")]
	public bool MBOCKDCOMFF(string CDJCGCBIKKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LICJALAKNFM
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x25746F0", Offset = "0x25732F0", VA = "0x1825746F0")]
	public static T CEEOFOFGLIL<T>(string ELOBOAALAAG) where T : UnityEngine.Object
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
		private class FFDOJPMNHJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string KPAMMNNINOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public KNCNIEDDCNP<GameObject> BIEOCHKCNBO;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63BEB60", Offset = "0x63BD760", VA = "0x1863BEB60")]
			public FFDOJPMNHJA(string KPAMMNNINOK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ICCPBOGNKCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<FFDOJPMNHJA> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public ICCPBOGNKCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x63BEC00", Offset = "0x63BD800", VA = "0x1863BEC00")]
			internal bool JCEAGHJHIHD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class AGGHAKLBEPF : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private MJMKCFLBGFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<FFDOJPMNHJA> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private ICCPBOGNKCH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private FFDOJPMNHJA <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
			[DebuggerHidden]
			public AGGHAKLBEPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63BE790", Offset = "0x63BD390", VA = "0x1863BE790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x63BEB10", Offset = "0x63BD710", VA = "0x1863BEB10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int DINEOMFMLHD = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<FFDOJPMNHJA> JALNKPKJIKC;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63BFA80", Offset = "0x63BE680", VA = "0x1863BFA80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2741400", Offset = "0x2740000", VA = "0x182741400")]
		public HPJLJGHAIKN<T> LoadResourceAsync<T>(string KPAMMNNINOK) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63BF960", Offset = "0x63BE560", VA = "0x1863BF960")]
		public HPJLJGHAIKN<GameObject> LoadResourceAsync(string KPAMMNNINOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x63BF8E0", Offset = "0x63BE4E0", VA = "0x1863BF8E0")]
		[IteratorStateMachine(typeof(AGGHAKLBEPF))]
		private IEnumerator<MJMKCFLBGFK> GMJKAMDDAJK(Queue<FFDOJPMNHJA> OAOBAEBKDCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x63BFC90", Offset = "0x63BE890", VA = "0x1863BFC90")]
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
