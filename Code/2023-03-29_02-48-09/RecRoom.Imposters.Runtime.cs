using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct IMFPBJFIHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JBJJDGEBHJL IKPPKKEHACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string KFEOLFOGHMM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9333E0", Offset = "0x9321E0", VA = "0x1809333E0")]
		public IMFPBJFIHHF(JBJJDGEBHJL EBIEFBGGLEO, string JIECLEDMKEK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct LLBFNFOOLMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public IMFPBJFIHHF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6533D90", Offset = "0x6532B90", VA = "0x186533D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65340D0", Offset = "0x6532ED0", VA = "0x1865340D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider IGLMIONMBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::NCJPHGMJAPE<IMFPBJFIHHF, GameObject> HHPNCIIEFLM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PLMEJOABLDL NDEDKLJEJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::NCJPHGMJAPE<IMFPBJFIHHF, GameObject> PJCNOEJFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x652FDA0", Offset = "0x652EBA0", VA = "0x18652FDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int LEKNPNJDCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x652FF00", Offset = "0x652ED00", VA = "0x18652FF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x652FCF0", Offset = "0x652EAF0", VA = "0x18652FCF0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6530270", Offset = "0x652F070", VA = "0x186530270", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6530120", Offset = "0x652EF20", VA = "0x186530120")]
	[AsyncStateMachine(typeof(LLBFNFOOLMP))]
	private Task<GameObject> MPONCNCHGLF(IMFPBJFIHHF JBGGCCODOLJ, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x652FF50", Offset = "0x652ED50", VA = "0x18652FF50")]
	public Task<GameObject> LoadItemAsync(JBJJDGEBHJL EBIEFBGGLEO, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65302E0", Offset = "0x652F0E0", VA = "0x1865302E0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KJNJNOGDJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JBJJDGEBHJL KKOBJFKBFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture INLMOPFOEFJ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87BC00", Offset = "0x87AA00", VA = "0x18087BC00")]
		public KJNJNOGDJGO(JBJJDGEBHJL GKLFNEOEFJH, Texture BHABCHLJFHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HOKFGLBNCGA
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class EANDAGPIAEH : global::HBCJHPKGFFI<Texture>, JLEECCFLDND, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct BENDHHKMHDL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public EANDAGPIAEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x652EB00", Offset = "0x652D900", VA = "0x18652EB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x652F200", Offset = "0x652E000", VA = "0x18652F200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly JBJJDGEBHJL GKLFNEOEFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture EHJGGAEBFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig DELMHJGFBJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken ONFKFAAPNBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject PKDHGEILBFO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LMAPELGHNPL PNBNKIHNACH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6530560", Offset = "0x652F360", VA = "0x186530560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::ONJEHKCKOLK<Texture> AOIBAIHJCAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6530480", Offset = "0x652F280", VA = "0x186530480", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task MJNHFHJACGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> NFOALBONBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6530570", Offset = "0x652F370", VA = "0x186530570")]
		public EANDAGPIAEH(JBJJDGEBHJL GKLFNEOEFJH, RenderTexture EHJGGAEBFFD, ImposterRenderConfig DELMHJGFBJN, CancellationToken ONFKFAAPNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6530350", Offset = "0x652F150", VA = "0x186530350")]
		[AsyncStateMachine(typeof(BENDHHKMHDL))]
		private Task<Texture> BGCNLCNLIKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6530470", Offset = "0x652F270", VA = "0x186530470", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x65304D0", Offset = "0x652F2D0", VA = "0x1865304D0")]
		private static void HAGALNPOINC(GameObject PKDHGEILBFO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OCLNINMCHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6534230", Offset = "0x6533030", VA = "0x186534230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1481BB0", Offset = "0x14809B0", VA = "0x181481BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private HOKFGLBNCGA size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[OPHMEKPGALB("size", 0)]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private RenderTexture EEJLCEAPKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::LMLPIGPLPMG<GameObject> JMBHBPGLAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private ILDCKENHFOE KMFNPHDCAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource EGHIEJEBCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::HBCJHPKGFFI<Texture> CGMGCGIJOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private JBJJDGEBHJL NBIACGODGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture HOANBKPKNEA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture LJLIMIKNIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6532C40", Offset = "0x6531A40", VA = "0x186532C40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3E0", Offset = "0x6F91E0", VA = "0x1806FA3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private JBJJDGEBHJL KKOBJFKBFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C60", Offset = "0x7B0A60", VA = "0x1807B1C60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6532A40", Offset = "0x6531840", VA = "0x186532A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool IAAMNNKPGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC480D0", Offset = "0xC46ED0", VA = "0x180C480D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int JPEPCKIDCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6532C30", Offset = "0x6531A30", VA = "0x186532C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6532A30", Offset = "0x6531830", VA = "0x186532A30")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6532EA0", Offset = "0x6531CA0", VA = "0x186532EA0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6532BA0", Offset = "0x65319A0", VA = "0x186532BA0")]
	private void DHLHGBPDIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x65332E0", Offset = "0x65320E0", VA = "0x1865332E0")]
	public void Set(JBJJDGEBHJL MDJGJEPGMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x65332D0", Offset = "0x65320D0", VA = "0x1865332D0")]
	public void Set(Texture BHABCHLJFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6533290", Offset = "0x6532090", VA = "0x186533290")]
	public void Set(KJNJNOGDJGO NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6532B90", Offset = "0x6531990", VA = "0x186532B90")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6533070", Offset = "0x6531E70", VA = "0x186533070")]
	public void SetInternal(JBJJDGEBHJL MDJGJEPGMLN, [Optional] Texture FBLACLCKKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6533060", Offset = "0x6531E60", VA = "0x186533060")]
	public void SetCustomSize(int AFDCFDNJKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8605F0", Offset = "0x85F3F0", VA = "0x1808605F0")]
	public void SetAntiAliasing(int BJICONHAHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6532F90", Offset = "0x6531D90", VA = "0x186532F90")]
	[AsyncStateMachine(typeof(OCLNINMCHMA))]
	private void PGMFPANCILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6532DB0", Offset = "0x6531BB0", VA = "0x186532DB0")]
	private void OGOIDFHOLBF(Texture BHABCHLJFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x65332F0", Offset = "0x65320F0", VA = "0x1865332F0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, PHJCHLDCEHP
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float IMAKJFDOJAN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "4")]
	public void PrepareImposter(PDPFONPKEHB FGGPHJMDLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65329F0", Offset = "0x65317F0", VA = "0x1865329F0")]
	public void SetReferencePoint(Vector3 BELKCDDMLBN, Quaternion DADJJDDMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6532860", Offset = "0x6531660", VA = "0x186532860")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65329C0", Offset = "0x65317C0", VA = "0x1865329C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x13B7FB0", Offset = "0x13B6DB0", VA = "0x1813B7FB0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ELLMGKDBABN
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static ELLMGKDBABN EHMFGLPGNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float GBICPOLMBHA;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x714930", Offset = "0x713730", VA = "0x180714930")]
	public ELLMGKDBABN(float MPHBPCNFNIK)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int BCDBACIPBKG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int JJCAKJKAHJK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> ONCLBLBEGIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool DBHJDJOPPAG;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x65334A0", Offset = "0x65322A0", VA = "0x1865334A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x65333B0", Offset = "0x65321B0", VA = "0x1865333B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x65336E0", Offset = "0x65324E0", VA = "0x1865336E0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JBJJDGEBHJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string CEGHLMMOIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	ELLMGKDBABN ELLMGKDBABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FIHFBLHCKKI;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> HMENNBKEHCG(CancellationToken ONFKFAAPNBK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGKAMMBMDOO(JBJJDGEBHJL ONICAEEHHFG);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODODGJHEMLI();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOMLEIENNNE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OHLCBEHANIL(out global::HBCJHPKGFFI<Texture> FKBDHNGMKHI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NBNMBLCHFHP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6534150", Offset = "0x6532F50", VA = "0x186534150")]
	public static bool NCNDPJJOFIJ(JBJJDGEBHJL FBNDGEMLMMC, JBJJDGEBHJL HBNJBKMFNGN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, PHJCHLDCEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x652F260", Offset = "0x652E060", VA = "0x18652F260", Slot = "4")]
		public void PrepareImposter(PDPFONPKEHB FGGPHJMDLJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PHJCHLDCEHP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PDPFONPKEHB FGGPHJMDLJN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GGPAINIJEOE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> ONHCCCALIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> AFHHHDJNCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PLMEJOABLDL
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNGCOIDHIED(params Type[] JGOGDIOCDNG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBKCFKEDEPP(params Type[] JGOGDIOCDNG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject DHGECKHFCAH(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, bool JDOOBIOFICK = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DHGECKHFCAH<T>(T BCDGDEJOBOG, Transform AABHIBJPKOH, bool JDOOBIOFICK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T DHGECKHFCAH<T>(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, bool JDOOBIOFICK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DHGECKHFCAH(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T DHGECKHFCAH<T>(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T DHGECKHFCAH<T>(T BCDGDEJOBOG, Transform AABHIBJPKOH, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PONLGNKHEPM : IDisposable, PLMEJOABLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> PGLMKEGMAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> ELIDHGAFGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform NNMAHAPCIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> MMIKEIMEHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PBKFBPEDEHP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6534E00", Offset = "0x6533C00", VA = "0x186534E00")]
	[NPBDMCLHPNM(AIJEIIPHIJH.None)]
	public static void HEKOMGIGKGF(HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x65355C0", Offset = "0x65343C0", VA = "0x1865355C0")]
	[Preserve]
	public PONLGNKHEPM([KIJADEHPJBH(null)] GGPAINIJEOE CAHKMJEKPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6534D00", Offset = "0x6533B00", VA = "0x186534D00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6535570", Offset = "0x6534370", VA = "0x186535570", Slot = "5")]
	public void NNGCOIDHIED(params Type[] JGOGDIOCDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6534B90", Offset = "0x6533990", VA = "0x186534B90", Slot = "6")]
	public void DBKCFKEDEPP(params Type[] JGOGDIOCDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6534BE0", Offset = "0x65339E0", VA = "0x186534BE0", Slot = "7")]
	public GameObject DHGECKHFCAH(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, bool JDOOBIOFICK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x24B2180", Offset = "0x24B0F80", VA = "0x1824B2180", Slot = "8")]
	public T DHGECKHFCAH<T>(T BCDGDEJOBOG, Transform AABHIBJPKOH, bool JDOOBIOFICK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x24B1AE0", Offset = "0x24B08E0", VA = "0x1824B1AE0", Slot = "9")]
	public T DHGECKHFCAH<T>(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, bool JDOOBIOFICK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6534C70", Offset = "0x6533A70", VA = "0x186534C70", Slot = "10")]
	public GameObject DHGECKHFCAH(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24B1B10", Offset = "0x24B0910", VA = "0x1824B1B10", Slot = "11")]
	public T DHGECKHFCAH<T>(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24B1B60", Offset = "0x24B0960", VA = "0x1824B1B60", Slot = "12")]
	public T DHGECKHFCAH<T>(T BCDGDEJOBOG, Transform AABHIBJPKOH, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24B1BF0", Offset = "0x24B09F0", VA = "0x1824B1BF0")]
	private T DHGECKHFCAH<T>(GameObject BCDGDEJOBOG, Transform AABHIBJPKOH, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK, out GameObject EAGDMNEJHIE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24B21F0", Offset = "0x24B0FF0", VA = "0x1824B21F0")]
	private T JMNAINBKCEP<T>(GameObject AAMBGNNHMBI, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6535440", Offset = "0x6534240", VA = "0x186535440")]
	private void NDACKKCCIJI(Component BJCJNGNNING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6534EF0", Offset = "0x6533CF0", VA = "0x186534EF0")]
	private void JKPJFOAFOGO(Component BJCJNGNNING, PDPFONPKEHB FGGPHJMDLJN, bool JDOOBIOFICK, bool FCGMMCKPEFB, [Optional] Type EOFLMMPBPKC, [Optional] Type LLAGDCHHHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6534A30", Offset = "0x6533830", VA = "0x186534A30")]
	private void BPFJGKHIMCH(GameObject AAMBGNNHMBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PDPFONPKEHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> OGIJLJPOBJI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24AE980", Offset = "0x24AD780", VA = "0x1824AE980")]
	public PDPFONPKEHB NIPKJFNBLBF<T>(T FKKFAJIGADC)
	{
		return default(PDPFONPKEHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24AE860", Offset = "0x24AD660", VA = "0x1824AE860")]
	public T BPAEGFNIDAI<T>(T IMIKACAODIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24AF0B0", Offset = "0x24ADEB0", VA = "0x1824AF0B0")]
	public bool OOMGGBPLIIB<T>(out T FKKFAJIGADC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PIMPFJMFCPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool NJGHNDLPBNH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8A76D0", Offset = "0x8A64D0", VA = "0x1808A76D0")]
	public PIMPFJMFCPP(bool EHIIMHDOPCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BFDEJAJIDAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool AKOIMALNDLC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x652F250", Offset = "0x652E050", VA = "0x18652F250")]
	public BFDEJAJIDAK(bool PHFKKGPMIAC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, PHJCHLDCEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6535A00", Offset = "0x6534800", VA = "0x186535A00", Slot = "4")]
		public void PrepareImposter(PDPFONPKEHB FGGPHJMDLJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x6534130", Offset = "0x6532F30", VA = "0x186534130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6534120", Offset = "0x6532F20", VA = "0x186534120")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6533370", Offset = "0x6532170", VA = "0x186533370")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class IAFAIAKHLCL
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> LKFJNJDBKOL;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 EFBDNDAOIMK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 JKDEDJIMHDO;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera OOLDIDEGIIO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string JKIEAJNGOMB = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const GBIDEBDGMHN LDJGLMEIOKC = GBIDEBDGMHN.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> CPEDMEFHIIB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode NPLLCHNNJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color JGLODLMHPKD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color BNDGCKHLAAH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color DNMDIEIFLOK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap BEEHLMAHHNK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool OJIBEIEOKAB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera CNMOAECCICN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x65321D0", Offset = "0x6530FD0", VA = "0x1865321D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6531F50", Offset = "0x6530D50", VA = "0x186531F50")]
	public static void OAEBJPLJJNC(Vector3 OCJNHFOCAOK, Quaternion GIEMDLOKFKA, ImposterRenderConfig EEDNBBJFLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6532400", Offset = "0x6531200", VA = "0x186532400")]
	private static void PMJHFEOLGOG(Vector3 OCJNHFOCAOK, Quaternion GIEMDLOKFKA, URPLight MKDEAJGGGFO, ImposterRenderConfig.LightConfig FIJBOFMGJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6531E60", Offset = "0x6530C60", VA = "0x186531E60")]
	public static void NCKPHNOOBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6531260", Offset = "0x6530060", VA = "0x186531260")]
	private static void HDKFPIGOBMF(int OFGLKBMBGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6530750", Offset = "0x652F550", VA = "0x186530750")]
	public static void BIJHIILHOHC(ImposterRenderConfig EEDNBBJFLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6531B30", Offset = "0x6530930", VA = "0x186531B30")]
	public static void KJDHMDFKNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6530EF0", Offset = "0x652FCF0", VA = "0x186530EF0")]
	public static void GFNDJFNOLIA(GameObject JNGNKILHDPE, RenderTexture EHJGGAEBFFD, ImposterRenderConfig EEDNBBJFLJH, ELLMGKDBABN GIBJDBHBKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6531630", Offset = "0x6530430", VA = "0x186531630")]
	private static void IOPECJEJBCK(GameObject JNGNKILHDPE, RenderTexture EHJGGAEBFFD, ImposterRenderConfig EEDNBBJFLJH, ELLMGKDBABN GIBJDBHBKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6530BA0", Offset = "0x652F9A0", VA = "0x186530BA0")]
	private static void EPLCJNCANJM(GameObject JNGNKILHDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x65310C0", Offset = "0x652FEC0", VA = "0x1865310C0")]
	public static void HBCMNIHPIAG(List<Renderer> LMBKHACBDFJ, List<Material> CBIOJPMDOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x65308D0", Offset = "0x652F6D0", VA = "0x1865308D0")]
	public static void DFAKHJKLDJK(GameObject BCDGDEJOBOG, Vector3 BLCDKCMOAFH, Vector3 HPEAIEEFMAK, float HOMJFMCMDGC, ELLMGKDBABN GIBJDBHBKOD, out Vector3 GIHPGGAELHJ, out Quaternion GGJLOFOJHBP, out float OAOJCKJGKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6530E50", Offset = "0x652FC50", VA = "0x186530E50")]
	public static RenderTexture FDLPIIOIGOG(int FLPAOFBCNFM, int BDNEGOJDOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6531C30", Offset = "0x6530A30", VA = "0x186531C30")]
	public static void LCHANDOBBKP()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct PFPODJLJGOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public NGNPLNHEGFI PHLPFKDGNNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject BHPOIEMKGMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture LJLIMIKNIHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig EIDLDGDAMLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public ELLMGKDBABN ELLMGKDBABN;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x65349C0", Offset = "0x65337C0", VA = "0x1865349C0")]
			public PFPODJLJGOK(NGNPLNHEGFI DFJCJFEOFBE, GameObject KOGIHNCGMED, RenderTexture EHJGGAEBFFD, ImposterRenderConfig DELMHJGFBJN, ELLMGKDBABN GIBJDBHBKOD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::NCJPHGMJAPE<PFPODJLJGOK, RenderTexture> FFCAKCHLDJF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<PFPODJLJGOK> HDCKJOFADJA;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int HMOFNOMOGHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x652F780", Offset = "0x652E580", VA = "0x18652F780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x652F890", Offset = "0x652E690", VA = "0x18652F890")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject JNGNKILHDPE, RenderTexture EHJGGAEBFFD, ImposterRenderConfig EEDNBBJFLJH, ELLMGKDBABN GIBJDBHBKOD, CancellationToken ONFKFAAPNBK, bool MAHIGENNCMH = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x652F3C0", Offset = "0x652E1C0", VA = "0x18652F3C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x652F7F0", Offset = "0x652E5F0", VA = "0x18652F7F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x652F5B0", Offset = "0x652E3B0", VA = "0x18652F5B0")]
		private static Task<RenderTexture> BJJJCOGKLIA(PFPODJLJGOK DNENOJFNLKP, CancellationToken ONFKFAAPNBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x652FC80", Offset = "0x652EA80", VA = "0x18652FC80")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6533760", Offset = "0x6532560", VA = "0x186533760")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6533870", Offset = "0x6532670", VA = "0x186533870")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
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
