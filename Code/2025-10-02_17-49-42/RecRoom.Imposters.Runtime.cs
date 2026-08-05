using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
	private readonly struct ACIJNLOAEIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KAHAAKGFHGH ELGAGBLNPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string KMGIKAEEDOC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
		public ACIJNLOAEIP(KAHAAKGFHGH NHOPEAGCHLG, string CDLCGIGHGJP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct OAJGAFGPHMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public ACIJNLOAEIP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85358A0", Offset = "0x85342A0", VA = "0x1885358A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8535C60", Offset = "0x8534660", VA = "0x188535C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider PNMEGMOJIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HOBAPCBIFBD<ACIJNLOAEIP, GameObject> FPGEFHPKGIJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MOGFECNMFOM HEHLJOANPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private HOBAPCBIFBD<ACIJNLOAEIP, GameObject> MOCNLNEABMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8531CC0", Offset = "0x85306C0", VA = "0x188531CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int ANLOIGABOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8531C70", Offset = "0x8530670", VA = "0x188531C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8531B90", Offset = "0x8530590", VA = "0x188531B90", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8532110", Offset = "0x8530B10", VA = "0x188532110", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8531FF0", Offset = "0x85309F0", VA = "0x188531FF0")]
	[AsyncStateMachine(typeof(OAJGAFGPHMM))]
	private Task<GameObject> OMFCIKDPCDK(ACIJNLOAEIP IDJKFNOHMFL, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8531E20", Offset = "0x8530820", VA = "0x188531E20")]
	public Task<GameObject> LoadItemAsync(KAHAAKGFHGH NHOPEAGCHLG, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8532180", Offset = "0x8530B80", VA = "0x188532180")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CFDFCKIJNGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KAHAAKGFHGH HEMEINKKDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DOODMBFAKHA;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
		public CFDFCKIJNGE(KAHAAKGFHGH GPLLIDCDOPF, Texture JBOOEIGKOID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum EPBHACIOLLG
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class HDMLCELJELF : CGNDLDCBLDI<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct NGMKJGAHJEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HDMLCELJELF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8533B80", Offset = "0x8532580", VA = "0x188533B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8534370", Offset = "0x8532D70", VA = "0x188534370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly KAHAAKGFHGH GPLLIDCDOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FCPOHBIAEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig NADOBNMPLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken AHOMALKMHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D GGACHFBDLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject KJNDNPDKMFL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override FKFADEBPFBK<Texture2D> JOMCHNHPFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8532360", Offset = "0x8530D60", VA = "0x188532360", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> GLNBMPPKHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85323C0", Offset = "0x8530DC0", VA = "0x1885323C0")]
		public HDMLCELJELF(KAHAAKGFHGH GPLLIDCDOPF, RenderTexture FCPOHBIAEDM, ImposterRenderConfig NADOBNMPLKI, CancellationToken AHOMALKMHKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85321C0", Offset = "0x8530BC0", VA = "0x1885321C0")]
		[AsyncStateMachine(typeof(NGMKJGAHJEM))]
		private Task<Texture2D> GGPBGIEJGBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8532330", Offset = "0x8530D30", VA = "0x188532330", Slot = "10")]
		protected override void INJOKNFPAOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85322B0", Offset = "0x8530CB0", VA = "0x1885322B0")]
		private static void IIDIIPFGAON(GameObject KJNDNPDKMFL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OOCLFEEPJPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8535CD0", Offset = "0x85346D0", VA = "0x188535CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
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
	[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private EPBHACIOLLG size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[FFBOEEGEIOD("size", EPBHACIOLLG.Custom)]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int LODEJEBDCGA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture LJIOKDINLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DLKJELDKMAE<GameObject> IKPKFNLOEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PKHGEDPOIHB LCOCBPNIPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource CFDOKKENJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private AACADPLMCLK<Texture2D> ALDEFPDFBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private KAHAAKGFHGH DBHFDEMMLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture OHIOPMHIKKP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int EIHOMKNGLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85334E0", Offset = "0x8531EE0", VA = "0x1885334E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8533530", Offset = "0x8531F30", VA = "0x188533530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture DJFAKMACKON
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8532D60", Offset = "0x8531760", VA = "0x188532D60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private KAHAAKGFHGH HEMEINKKDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8532C00", Offset = "0x8531600", VA = "0x188532C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool BKIANJKGDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x256A6D0", Offset = "0x25690D0", VA = "0x18256A6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int HDDAAGGIACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8532F40", Offset = "0x8531940", VA = "0x188532F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8532AB0", Offset = "0x85314B0", VA = "0x188532AB0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85330C0", Offset = "0x8531AC0", VA = "0x1885330C0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8532B80", Offset = "0x8531580", VA = "0x188532B80")]
	private void DIKPJDIMGDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85333C0", Offset = "0x8531DC0", VA = "0x1885333C0")]
	public void Set(KAHAAKGFHGH FOFEEHILCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85333B0", Offset = "0x8531DB0", VA = "0x1885333B0")]
	public void Set(Texture JBOOEIGKOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85333D0", Offset = "0x8531DD0", VA = "0x1885333D0")]
	public void Set(CFDFCKIJNGE KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8532AC0", Offset = "0x85314C0", VA = "0x188532AC0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85331C0", Offset = "0x8531BC0", VA = "0x1885331C0")]
	public void SetInternal(KAHAAKGFHGH FOFEEHILCJH, [Optional] Texture OCIOJDMHFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85331B0", Offset = "0x8531BB0", VA = "0x1885331B0")]
	public void SetCustomSize(int MLHHAKNNDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
	public void SetAntiAliasing(int MGGLPOAOIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8532AD0", Offset = "0x85314D0", VA = "0x188532AD0")]
	[AsyncStateMachine(typeof(OOCLFEEPJPA))]
	private void DGODLKKMACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8532FE0", Offset = "0x85319E0", VA = "0x188532FE0")]
	private void LMALBDMDLEN(Texture JBOOEIGKOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8533460", Offset = "0x8531E60", VA = "0x188533460")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, ICCPABBNNCM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float GMPBFBBEGOA = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void PrepareImposter(NJBJGAIKJEP PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8532A70", Offset = "0x8531470", VA = "0x188532A70")]
	public void SetReferencePoint(Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8532880", Offset = "0x8531280", VA = "0x188532880")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8532A50", Offset = "0x8531450", VA = "0x188532A50")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x231C2D0", Offset = "0x231ACD0", VA = "0x18231C2D0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KFODACJFDOC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static KFODACJFDOC FFHNFAFDCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float BLPMHEDLGNH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7390", Offset = "0x2DD5D90", VA = "0x182DD7390")]
	public KFODACJFDOC(float EPDJNBMKEEO)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85367D0", Offset = "0x85351D0", VA = "0x1885367D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int OFIDIPJNNMJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int MDCMHFKPJNH = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> NKOMNLBOOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool EHGBFINBJGL;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8533750", Offset = "0x8532150", VA = "0x188533750")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8533650", Offset = "0x8532050", VA = "0x188533650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8533990", Offset = "0x8532390", VA = "0x188533990")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KAHAAKGFHGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DMMJIPMCHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KFODACJFDOC KFODACJFDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AIPDBPENDIB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> FDNJFFCMLMF(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AOMGENJHHLO(KAHAAKGFHGH GOCNHGEHNFD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJINEAGAHJL();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JNBPFOJENKK();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IJOPIJHKHKK(uint? DCIMICJMEHI, [Out] AACADPLMCLK<Texture2D> EFJJEIKJEOO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LCOGLKEIPEE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8533A60", Offset = "0x8532460", VA = "0x188533A60")]
	public static bool PGLLMBFABIO(KAHAAKGFHGH KHLNPPJPDIJ, KAHAAKGFHGH FJFIEGBKMAN)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, ICCPABBNNCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8530F90", Offset = "0x852F990", VA = "0x188530F90", Slot = "4")]
		public void PrepareImposter(NJBJGAIKJEP PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ICCPABBNNCM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NJBJGAIKJEP PDCLAJMPOEB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MMDPIAFPDEB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> OLCHNPGPPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> JOAPHNNKKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MOGFECNMFOM
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAGHJBHJBPJ(params Type[] GBEPIPLGCGD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LNPMOCGOLEE<T>(T IGAKMAMDNNB, Transform AEMEEJKFKNN, bool HIKJNGBEOGP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T LNPMOCGOLEE<T>(GameObject IGAKMAMDNNB, Transform AEMEEJKFKNN, bool HIKJNGBEOGP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject LNPMOCGOLEE(GameObject IGAKMAMDNNB, Transform AEMEEJKFKNN, NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NHHMEAIIJGL : IDisposable, MOGFECNMFOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> COODGOFNEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> GIHCOMIIIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform PCIBFEPECLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> LKAGDOJJEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DCAGFGBMGGO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85349C0", Offset = "0x85333C0", VA = "0x1885349C0")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	public static void HFPMPAAENFC(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8535410", Offset = "0x8533E10", VA = "0x188535410")]
	[UnityEngine.Scripting.Preserve]
	public NHHMEAIIJGL([BMCONCJPCIA(null)] MMDPIAFPDEB LOMFECINLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8534610", Offset = "0x8533010", VA = "0x188534610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85346F0", Offset = "0x85330F0", VA = "0x1885346F0", Slot = "5")]
	public void FAGHJBHJBPJ(params Type[] GBEPIPLGCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3F08F40", Offset = "0x3F07940", VA = "0x183F08F40", Slot = "6")]
	public T LNPMOCGOLEE<T>(T IGAKMAMDNNB, Transform AEMEEJKFKNN, bool HIKJNGBEOGP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3F08F10", Offset = "0x3F07910", VA = "0x183F08F10", Slot = "7")]
	public T LNPMOCGOLEE<T>(GameObject IGAKMAMDNNB, Transform AEMEEJKFKNN, bool HIKJNGBEOGP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8535380", Offset = "0x8533D80", VA = "0x188535380", Slot = "8")]
	public GameObject LNPMOCGOLEE(GameObject IGAKMAMDNNB, Transform AEMEEJKFKNN, NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F08ED0", Offset = "0x3F078D0", VA = "0x183F08ED0", Slot = "9")]
	public T LNPMOCGOLEE<T>(GameObject IGAKMAMDNNB, Transform AEMEEJKFKNN, NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3F08FB0", Offset = "0x3F079B0", VA = "0x183F08FB0")]
	private T LNPMOCGOLEE<T>(GameObject IGAKMAMDNNB, Transform AEMEEJKFKNN, NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP, [Out] GameObject BOJBHLAOJAF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F08BE0", Offset = "0x3F075E0", VA = "0x183F08BE0")]
	private T GCLHLCNGFIF<T>(GameObject FNCBMCHNDJI, NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85343E0", Offset = "0x8532DE0", VA = "0x1885343E0")]
	private void DIBEJCAIAKJ(NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8535150", Offset = "0x8533B50", VA = "0x188535150")]
	private void KPOOMOHFCFK(NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85348B0", Offset = "0x85332B0", VA = "0x1885348B0")]
	private void GMINPPLGAOO(Component ADKKEOFFDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8534EE0", Offset = "0x85338E0", VA = "0x188534EE0")]
	private void KPOOMOHFCFK(Component ADKKEOFFDMM, NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP, bool CPJFCIHGIFP, [Optional] Type PHJIHIBILBA, [Optional] Type CDNDHGLIMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8534AB0", Offset = "0x85334B0", VA = "0x188534AB0")]
	private void IBBGDCOPELO(Component ADKKEOFFDMM, NJBJGAIKJEP PDCLAJMPOEB, bool HIKJNGBEOGP, bool CPJFCIHGIFP, [Optional] Type PHJIHIBILBA, [Optional] Type CDNDHGLIMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8534740", Offset = "0x8533140", VA = "0x188534740")]
	private void GEDJCMKGAPK(GameObject FNCBMCHNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NJBJGAIKJEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> HHGNJJJFNDA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3F0DAF0", Offset = "0x3F0C4F0", VA = "0x183F0DAF0")]
	public NJBJGAIKJEP FNAEMEPGHFK<T>(T PDNOHILPLOC)
	{
		return default(NJBJGAIKJEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3F0E220", Offset = "0x3F0CC20", VA = "0x183F0E220")]
	public T GFFPJLNAMHB<T>(T KJMOBDOKFBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3F0E330", Offset = "0x3F0CD30", VA = "0x183F0E330")]
	public bool NLKHMGDKJML<T>([Out] T PDNOHILPLOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8535850", Offset = "0x8534250", VA = "0x188535850")]
	public void EMMOLKMNHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JALCMKLPFEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool KLCBJCFCMFH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8640", Offset = "0x2DD7040", VA = "0x182DD8640")]
	public JALCMKLPFEG(bool OHFNMPGOODA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LPHAGPBBFID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool KCNJGNEICLG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8533B40", Offset = "0x8532540", VA = "0x188533B40")]
	public LPHAGPBBFID(bool ACONHCENGML)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, ICCPABBNNCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8536510", Offset = "0x8534F10", VA = "0x188536510", Slot = "4")]
		public void PrepareImposter(NJBJGAIKJEP PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds EMGFBGJGFKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85326F0", Offset = "0x85310F0", VA = "0x1885326F0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85326B0", Offset = "0x85310B0", VA = "0x1885326B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8532670", Offset = "0x8531070", VA = "0x188532670")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8532580", Offset = "0x8530F80", VA = "0x188532580")]
		private void MJMKIFAHHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x8533B60", Offset = "0x8532560", VA = "0x188533B60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8533B50", Offset = "0x8532550", VA = "0x188533B50")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[FFBOEEGEIOD("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[FFBOEEGEIOD("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85335B0", Offset = "0x8531FB0", VA = "0x1885335B0")]
		public void DNFOKMGINNN(Vector3 GBPDMHAFFAI, Quaternion DNNEKANFEBG, float AKOLFCHBOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85335E0", Offset = "0x8531FE0", VA = "0x1885335E0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class AGDDMBDNLLI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 IPLCIOJHGJI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> JPNBAKNFHNJ;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> BGJAACMCIDH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera IGABEAIOIFB;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> IJHHMAGDMBA;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> LEHIHHHEHNG;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode FJLMKJPDDEE;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color KOKHBOBDBFB;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color BIJDMDMNGBB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color GDKBJKNKGPA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap EHFOPAMDHJL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool HDHDIKJGMHB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> AGCHJNFOKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8530D10", Offset = "0x852F710", VA = "0x188530D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> OLNMOKCFPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8530CC0", Offset = "0x852F6C0", VA = "0x188530CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera ADGBIMIIIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x852F2D0", Offset = "0x852DCD0", VA = "0x18852F2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8530A20", Offset = "0x852F420", VA = "0x188530A20")]
	public static void OBJIBDOEJCE(Vector3 FLCJBMHENDH, Quaternion LKFKMOELCMO, ImposterRenderConfig LJNBLENBPBF, bool IHGIEDPINMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x85301D0", Offset = "0x852EBD0", VA = "0x1885301D0")]
	private static void KFCPPJCOFKP(Vector3 FLCJBMHENDH, Quaternion LKFKMOELCMO, URPLight CDLINADDDPH, ImposterRenderConfig.LightConfig KBCMNJINNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x852EB20", Offset = "0x852D520", VA = "0x18852EB20")]
	public static void AFLPMCCAPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x852E6F0", Offset = "0x852D0F0", VA = "0x18852E6F0")]
	private static void ACHMMGNAKIO(int DAIBEOGDKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x852F100", Offset = "0x852DB00", VA = "0x18852F100")]
	public static void CEPLLHJIEID(ImposterRenderConfig LJNBLENBPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x852EC00", Offset = "0x852D600", VA = "0x18852EC00")]
	public static void AGPALPLEPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x852ECF0", Offset = "0x852D6F0", VA = "0x18852ECF0")]
	public static void AIOIHPAPDOJ(GameObject MOIKFNBINIL, RenderTexture FCPOHBIAEDM, ImposterRenderConfig LJNBLENBPBF, KFODACJFDOC IGOLNLEAJPB, [Optional] Vector3? EPMPABIBBJI, [Optional] Vector3? ELBCNCOPPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x852F890", Offset = "0x852E290", VA = "0x18852F890")]
	private static void KAIPMMIJBOG(GameObject MOIKFNBINIL, RenderTexture FCPOHBIAEDM, ImposterRenderConfig LJNBLENBPBF, KFODACJFDOC IGOLNLEAJPB, Vector3 EPMPABIBBJI, Vector3 ELBCNCOPPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x852FEF0", Offset = "0x852E8F0", VA = "0x18852FEF0")]
	private static void KBBNMOKHHGK(GameObject MOIKFNBINIL, Vector3 GAENCFMAIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x852F520", Offset = "0x852DF20", VA = "0x18852F520")]
	public static void JELHPDILPLA(Bounds IDBHNLPIGNN, ImposterRenderConfig LJNBLENBPBF, [Out] Vector3 JDLBGGGIKLL, [Out] Quaternion GEOKKGNGOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x85304F0", Offset = "0x852EEF0", VA = "0x1885304F0")]
	private static void NOGJJJCOGCM(GameObject IGAKMAMDNNB, ImposterRenderConfig LJNBLENBPBF, KFODACJFDOC IGOLNLEAJPB, [Out] Vector3 JDLBGGGIKLL, [Out] Quaternion GEOKKGNGOPE, [Out] float DJDMJBAHEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x852F030", Offset = "0x852DA30", VA = "0x18852F030")]
	public static RenderTexture CADMIKHIPMA(int ANOHMOCFGAJ, int NJLBPEGOCCN, RenderTextureFormat JBHFIGLCFLB = RenderTextureFormat.ARGB32, string OLGJDPNIHEL = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct DHHMMPCFKDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public FNHGFPOHNDG FFDEPACNPIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject DCLOPOICMHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture DJFAKMACKON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig DLPOBJNFBKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public KFODACJFDOC KFODACJFDOC;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x85310E0", Offset = "0x852FAE0", VA = "0x1885310E0")]
			public DHHMMPCFKDE(FNHGFPOHNDG FBJNLPOFDFG, GameObject GCODDBIKKFL, RenderTexture FCPOHBIAEDM, ImposterRenderConfig NADOBNMPLKI, KFODACJFDOC IGOLNLEAJPB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static HOBAPCBIFBD<DHHMMPCFKDE, RenderTexture> HEHMOEGFEOM;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<DHHMMPCFKDE> JFHGBHBEING;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int JBBJCHCOJLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8531600", Offset = "0x8530000", VA = "0x188531600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8531730", Offset = "0x8530130", VA = "0x188531730")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MOIKFNBINIL, RenderTexture FCPOHBIAEDM, ImposterRenderConfig LJNBLENBPBF, KFODACJFDOC IGOLNLEAJPB, CancellationToken AHOMALKMHKK, bool GKIFNFCDMFD = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85313F0", Offset = "0x852FDF0", VA = "0x1885313F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8531690", Offset = "0x8530090", VA = "0x188531690", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8531150", Offset = "0x852FB50", VA = "0x188531150")]
		private static Task<RenderTexture> AIFCNKCHGDE(DHHMMPCFKDE LJCNHJKAFOL, CancellationToken AHOMALKMHKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8531B50", Offset = "0x8530550", VA = "0x188531B50")]
		public DeferredImposterRenderer()
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
