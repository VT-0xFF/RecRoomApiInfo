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
public class DOBJELBFLON
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CBBIJOFIOMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public DOBJELBFLON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public CBBIJOFIOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73FA300", Offset = "0x73F9700", VA = "0x1873FA300")]
		internal void OCMCIBPKOLP(GameObject go)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x73FA260", Offset = "0x73F9660", VA = "0x1873FA260")]
		internal void APEANKJNCHB(GameObject go)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly DOBJELBFLON CEJLCJIOHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private Dictionary<string, GameObject> BPGHEKONDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<string, GameObject> IAJDPHKNEHA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x73FADC0", Offset = "0x73FA1C0", VA = "0x1873FADC0")]
	public DOBJELBFLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x73FA9C0", Offset = "0x73F9DC0", VA = "0x1873FA9C0", Slot = "1")]
	~DOBJELBFLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x73FABB0", Offset = "0x73F9FB0", VA = "0x1873FABB0")]
	private void NCDCJOPILKM(Scene JFMDCCFECCK, LoadSceneMode DOILDKPHIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x73FAAF0", Offset = "0x73F9EF0", VA = "0x1873FAAF0")]
	public GameObject JIJHDONEHKM(string HBGOACJMLDJ, bool KAHPAPFPEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x73FA860", Offset = "0x73F9C60", VA = "0x1873FA860")]
	public ELLFHPNCMJG<GameObject> CABMFABPEAJ(string HBGOACJMLDJ, bool KAHPAPFPEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x73FA880", Offset = "0x73F9C80", VA = "0x1873FA880")]
	private GameObject DOOLAJPPLOF(string HBGOACJMLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x73FA790", Offset = "0x73F9B90", VA = "0x1873FA790")]
	public void AKDHJPPBDNN(string HBGOACJMLDJ, GameObject ACHABLJAHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x73FA950", Offset = "0x73F9D50", VA = "0x1873FA950")]
	public void EAIGBDIFFGE(string HBGOACJMLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73FA3A0", Offset = "0x73F97A0", VA = "0x1873FA3A0")]
	public ELLFHPNCMJG<GameObject> AKDHJPPBDNN(string HBGOACJMLDJ, bool KAHPAPFPEHI, bool FMKCMJEPJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x73FAB30", Offset = "0x73F9F30", VA = "0x1873FAB30")]
	public bool KIOBAFFELNK(string HBGOACJMLDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EPHJONIHLAN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D55320", Offset = "0x2D54720", VA = "0x182D55320")]
	public static T EANBLGJFECN<T>(string GEAOIIINCOC) where T : UnityEngine.Object
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
		private class PIJFMOGMJHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string AHBAMLOJBAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public JGFPMDAOPIA<GameObject> NHKEOGAEEBO;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x73FB2C0", Offset = "0x73FA6C0", VA = "0x1873FB2C0")]
			public PIJFMOGMJHH(string AHBAMLOJBAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BGMACNGLAEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Queue<PIJFMOGMJHH> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Func<bool> <>9__0;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public BGMACNGLAEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x73FA210", Offset = "0x73F9610", VA = "0x1873FA210")]
			internal bool PAEAKKOONNE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class KMMBCAMANLM : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private MLEAAPMIINP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Queue<PIJFMOGMJHH> queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private BGMACNGLAEC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private PIJFMOGMJHH <loadRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public KMMBCAMANLM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x73FAEF0", Offset = "0x73FA2F0", VA = "0x1873FAEF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x73FB270", Offset = "0x73FA670", VA = "0x1873FB270", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int IPNLJENAJKC = 2;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static Queue<PIJFMOGMJHH> OIKLALKENPK;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x73FB500", Offset = "0x73FA900", VA = "0x1873FB500")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x317DD40", Offset = "0x317D140", VA = "0x18317DD40")]
		public ELLFHPNCMJG<T> LoadResourceAsync<T>(string AHBAMLOJBAO) where T : MonoBehaviour
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x73FB3E0", Offset = "0x73FA7E0", VA = "0x1873FB3E0")]
		public ELLFHPNCMJG<GameObject> LoadResourceAsync(string AHBAMLOJBAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x73FB360", Offset = "0x73FA760", VA = "0x1873FB360")]
		[IteratorStateMachine(typeof(KMMBCAMANLM))]
		private IEnumerator<MLEAAPMIINP> GDNJOMNAAMI(Queue<PIJFMOGMJHH> LBIOCHJBOOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x73FB710", Offset = "0x73FAB10", VA = "0x1873FB710")]
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
