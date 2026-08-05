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
	private readonly struct DFPGEONPKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly NPKPAGAIAJN DKGGJOFLCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string ABEKIOKGBBN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
		public DFPGEONPKBE(NPKPAGAIAJN OKJLIMBDPHO, string MKKBKODCDFF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct NDOPHMPNBEG : IAsyncStateMachine
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
		public DFPGEONPKBE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7026EA0", Offset = "0x70262A0", VA = "0x187026EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7027260", Offset = "0x7026660", VA = "0x187027260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider BEFLLAKIFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HIBACLKOFDE<DFPGEONPKBE, GameObject> NIBJFAFLBFG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MILFLNDMGGG ONPGAPFDPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private HIBACLKOFDE<DFPGEONPKBE, GameObject> BBBCBNNFBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70215A0", Offset = "0x70209A0", VA = "0x1870215A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int NFAIDFEKBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7021700", Offset = "0x7020B00", VA = "0x187021700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70214C0", Offset = "0x70208C0", VA = "0x1870214C0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7021A30", Offset = "0x7020E30", VA = "0x187021A30", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7021910", Offset = "0x7020D10", VA = "0x187021910")]
	[AsyncStateMachine(typeof(NDOPHMPNBEG))]
	private Task<GameObject> ONJJEEPMIHG(DFPGEONPKBE NPKGCAJIBMC, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7021750", Offset = "0x7020B50", VA = "0x187021750")]
	public Task<GameObject> LoadItemAsync(NPKPAGAIAJN OKJLIMBDPHO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7021AA0", Offset = "0x7020EA0", VA = "0x187021AA0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BBEINLABGFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NPKPAGAIAJN JOLAHJHKKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture GJLCMMMNILC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
		public BBEINLABGFA(NPKPAGAIAJN HPCPKMICMHO, Texture EPCABFKFFHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PEPIPJDCNLH
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
	private class OIAFKIMLAOJ : EFHIOEOEBAA<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct LEBGMJGFIFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OIAFKIMLAOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7023E10", Offset = "0x7023210", VA = "0x187023E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7024600", Offset = "0x7023A00", VA = "0x187024600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly NPKPAGAIAJN HPCPKMICMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture BJOPCDPNEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig JLNJKDCIPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken FHGIOBPPFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D PKJCMEANLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject GPPBBACNJCF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override AMMGOODCICE<Texture2D> JIGLPKCOBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x70273B0", Offset = "0x70267B0", VA = "0x1870273B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> JONNKIJMLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70275B0", Offset = "0x70269B0", VA = "0x1870275B0")]
		public OIAFKIMLAOJ(NPKPAGAIAJN HPCPKMICMHO, RenderTexture BJOPCDPNEJH, ImposterRenderConfig JLNJKDCIPGO, CancellationToken FHGIOBPPFHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70274C0", Offset = "0x70268C0", VA = "0x1870274C0")]
		[AsyncStateMachine(typeof(LEBGMJGFIFP))]
		private Task<Texture2D> ONHMLFJMFCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7027490", Offset = "0x7026890", VA = "0x187027490", Slot = "10")]
		protected override void OEKDJLADKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7027410", Offset = "0x7026810", VA = "0x187027410")]
		private static void IOMEOOHHIMH(GameObject GPPBBACNJCF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DENECBAPOIF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7020270", Offset = "0x701F670", VA = "0x187020270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
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
	[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private PEPIPJDCNLH size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[HFJGENLBJBK("size", PEPIPJDCNLH.Custom)]
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
	private static int PAOMAJLOGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture IFNCFNLFMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private KGPGGHIJBKN<GameObject> CBKLOKMAILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private JNDAODDCIHF OPLNAHNBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource BPPNMIHDBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private PLBFKJMGACI<Texture2D> MEEEPCECPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NPKPAGAIAJN LMMDDOENION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture CKIDNLIJIOP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int AHKENPPKHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x70238E0", Offset = "0x7022CE0", VA = "0x1870238E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7023930", Offset = "0x7022D30", VA = "0x187023930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture FIAHKFGEOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7022F80", Offset = "0x7022380", VA = "0x187022F80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C7BA0", Offset = "0x8C6FA0", VA = "0x1808C7BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private NPKPAGAIAJN JOLAHJHKKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF00", Offset = "0x8CA300", VA = "0x1808CAF00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7023170", Offset = "0x7022570", VA = "0x187023170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool PLHBLJLHGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B298A0", Offset = "0x1B28CA0", VA = "0x181B298A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int OJNDOOCNPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7023520", Offset = "0x7022920", VA = "0x187023520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7022F70", Offset = "0x7022370", VA = "0x187022F70")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7023430", Offset = "0x7022830", VA = "0x187023430")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70232D0", Offset = "0x70226D0", VA = "0x1870232D0")]
	private void MOKHBPLFGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70237B0", Offset = "0x7022BB0", VA = "0x1870237B0")]
	public void Set(NPKPAGAIAJN ONGCEDLJKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x70237C0", Offset = "0x7022BC0", VA = "0x1870237C0")]
	public void Set(Texture EPCABFKFFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x70237D0", Offset = "0x7022BD0", VA = "0x1870237D0")]
	public void Set(BBEINLABGFA HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7023160", Offset = "0x7022560", VA = "0x187023160")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x70235C0", Offset = "0x70229C0", VA = "0x1870235C0")]
	public void SetInternal(NPKPAGAIAJN ONGCEDLJKAL, [Optional] Texture MMBHGCBNMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x70235B0", Offset = "0x70229B0", VA = "0x1870235B0")]
	public void SetCustomSize(int LKCDFGFJCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D80", Offset = "0x8C7180", VA = "0x1808C7D80")]
	public void SetAntiAliasing(int PDODHAPOLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7022EC0", Offset = "0x70222C0", VA = "0x187022EC0")]
	[AsyncStateMachine(typeof(DENECBAPOIF))]
	private void AHHECLAPEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7023350", Offset = "0x7022750", VA = "0x187023350")]
	private void OCAEPMMFHNB(Texture EPCABFKFFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7023860", Offset = "0x7022C60", VA = "0x187023860")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, AGDJJEGOLHH
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float JNJJIIJEHOA = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
	public void PrepareImposter(PILOCIKGANN OKAMEPDCJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7022E80", Offset = "0x7022280", VA = "0x187022E80")]
	public void SetReferencePoint(Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7022C90", Offset = "0x7022090", VA = "0x187022C90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7022E60", Offset = "0x7022260", VA = "0x187022E60")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x19CC8D0", Offset = "0x19CBCD0", VA = "0x1819CC8D0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PJKHGJGAIAK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static PJKHGJGAIAK MAFLPCNLIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float MFFLECFLKHA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2509A70", Offset = "0x2508E70", VA = "0x182509A70")]
	public PJKHGJGAIAK(float AODNEKIEPBB)
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
		[Cpp2IlInjected.Address(RVA = "0x7027A60", Offset = "0x7026E60", VA = "0x187027A60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
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
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MBHMMHHMEFD = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int ODANBBEIHKK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> MJJJGJONEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CELBIDCFCGG;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7023B40", Offset = "0x7022F40", VA = "0x187023B40")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7023A40", Offset = "0x7022E40", VA = "0x187023A40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7023D80", Offset = "0x7023180", VA = "0x187023D80")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NPKPAGAIAJN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string DLKGPKONKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PJKHGJGAIAK PJKHGJGAIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LAFLNPBOOCC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> JAFEEMFNDDI(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GHCLGIOHEEC(NPKPAGAIAJN BMKPAKCEMFK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void APOHLLKCNOE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIAAMNFNEAN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EJIHOALMJMP(uint? INCGJNJBLKN, [Out] PLBFKJMGACI<Texture2D> MOLCEKOJNIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OELKNFANLKI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x70272D0", Offset = "0x70266D0", VA = "0x1870272D0")]
	public static bool KBDCPMIECHL(NPKPAGAIAJN PMPCPIAMAOG, NPKPAGAIAJN DAPNKBEGPKI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, AGDJJEGOLHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7020120", Offset = "0x701F520", VA = "0x187020120", Slot = "4")]
		public void PrepareImposter(PILOCIKGANN OKAMEPDCJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AGDJJEGOLHH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PILOCIKGANN OKAMEPDCJCI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JOPABFMOPEA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NBLBINKLJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> MPDALOBCGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MILFLNDMGGG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKECKGIPPFB(params Type[] FIJPKDOHEHI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IHMDBIEDNEN(GameObject FIDMHGJFAFJ, Transform AMMKPAGCALK, bool GFCAMFKKOFN = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T IHMDBIEDNEN<T>(T FIDMHGJFAFJ, Transform AMMKPAGCALK, bool GFCAMFKKOFN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T IHMDBIEDNEN<T>(GameObject FIDMHGJFAFJ, Transform AMMKPAGCALK, bool GFCAMFKKOFN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject IHMDBIEDNEN(GameObject FIDMHGJFAFJ, Transform AMMKPAGCALK, PILOCIKGANN OKAMEPDCJCI, bool GFCAMFKKOFN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IDAGNNHCOHF : IDisposable, MILFLNDMGGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> MBGKKJBOLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> FFLBAPJPDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform FGKDDMHNBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> KMFJLOCFEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> NFJLHNAPMHM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7021FB0", Offset = "0x70213B0", VA = "0x187021FB0")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	public static void OHHPJPBCCIE(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7022550", Offset = "0x7021950", VA = "0x187022550")]
	[UnityEngine.Scripting.Preserve]
	public IDAGNNHCOHF([CNGCCDLPGOD(null)] JOPABFMOPEA KIFJEOIFMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7021D60", Offset = "0x7021160", VA = "0x187021D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7021F60", Offset = "0x7021360", VA = "0x187021F60", Slot = "5")]
	public void LKECKGIPPFB(params Type[] FIJPKDOHEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7021E40", Offset = "0x7021240", VA = "0x187021E40", Slot = "6")]
	public GameObject IHMDBIEDNEN(GameObject FIDMHGJFAFJ, Transform AMMKPAGCALK, bool GFCAMFKKOFN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3091200", Offset = "0x3090600", VA = "0x183091200", Slot = "7")]
	public T IHMDBIEDNEN<T>(T FIDMHGJFAFJ, Transform AMMKPAGCALK, bool GFCAMFKKOFN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3090BD0", Offset = "0x308FFD0", VA = "0x183090BD0", Slot = "8")]
	public T IHMDBIEDNEN<T>(GameObject FIDMHGJFAFJ, Transform AMMKPAGCALK, bool GFCAMFKKOFN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7021ED0", Offset = "0x70212D0", VA = "0x187021ED0", Slot = "9")]
	public GameObject IHMDBIEDNEN(GameObject FIDMHGJFAFJ, Transform AMMKPAGCALK, PILOCIKGANN OKAMEPDCJCI, bool GFCAMFKKOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x30911A0", Offset = "0x30905A0", VA = "0x1830911A0", Slot = "10")]
	public T IHMDBIEDNEN<T>(GameObject FIDMHGJFAFJ, Transform AMMKPAGCALK, PILOCIKGANN OKAMEPDCJCI, bool GFCAMFKKOFN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3090C20", Offset = "0x3090020", VA = "0x183090C20")]
	private T IHMDBIEDNEN<T>(GameObject FIDMHGJFAFJ, Transform AMMKPAGCALK, PILOCIKGANN OKAMEPDCJCI, bool GFCAMFKKOFN, [Out] GameObject JKBIGHEPAPM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3091290", Offset = "0x3090690", VA = "0x183091290")]
	private T MFPEOPJGOFB<T>(GameObject MCCIFMIMANN, PILOCIKGANN OKAMEPDCJCI, bool GFCAMFKKOFN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7021C50", Offset = "0x7021050", VA = "0x187021C50")]
	private void CFAIKNJONBB(Component HFEBDCHJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x70220A0", Offset = "0x70214A0", VA = "0x1870220A0")]
	private void PGMKFABPEDI(Component HFEBDCHJGBG, PILOCIKGANN OKAMEPDCJCI, bool GFCAMFKKOFN, bool CPEGPPMBAHP, [Optional] Type IGLACEJICEB, [Optional] Type KGGNJGNOPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7021AE0", Offset = "0x7020EE0", VA = "0x187021AE0")]
	private void ADOKMEPDFBB(GameObject MCCIFMIMANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PILOCIKGANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> KIEILMHEMDA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3223CE0", Offset = "0x32230E0", VA = "0x183223CE0")]
	public PILOCIKGANN KJLAKIGFJAC<T>(T BPDKBPGAHON)
	{
		return default(PILOCIKGANN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3223430", Offset = "0x3222830", VA = "0x183223430")]
	public T AFFELPLAAIM<T>(T EKFBHIJFHMA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3223540", Offset = "0x3222940", VA = "0x183223540")]
	public bool BBKOOAPFEDD<T>([Out] T BPDKBPGAHON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct DHOLLGILOAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool FCPKPIFJCGO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2508F90", Offset = "0x2508390", VA = "0x182508F90")]
	public DHOLLGILOAJ(bool BNOHINCLCHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AICFFKLLDMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool MPGBEDDPBDL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7020110", Offset = "0x701F510", VA = "0x187020110")]
	public AICFFKLLDMN(bool JOEAGEPAJDF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, AGDJJEGOLHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70277B0", Offset = "0x7026BB0", VA = "0x1870277B0", Slot = "4")]
		public void PrepareImposter(PILOCIKGANN OKAMEPDCJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
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
		public Bounds GGEIJABCKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7022B00", Offset = "0x7021F00", VA = "0x187022B00")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x70229D0", Offset = "0x7021DD0", VA = "0x1870229D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7022990", Offset = "0x7021D90", VA = "0x187022990")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7022A10", Offset = "0x7021E10", VA = "0x187022A10")]
		private void PBHCNLCOFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
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
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x7024680", Offset = "0x7023A80", VA = "0x187024680")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7024670", Offset = "0x7023A70", VA = "0x187024670")]
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
		[HFJGENLBJBK("frameCameraToImposterBounds", true)]
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
		[HFJGENLBJBK("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x70239A0", Offset = "0x7022DA0", VA = "0x1870239A0")]
		public void HCFOBPAPMKF(Vector3 HOKKAJJAAEN, Quaternion FKEOAFFLAFC, float ENLJODNFONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x70239D0", Offset = "0x7022DD0", VA = "0x1870239D0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MDHIGPBEKEH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 FGAEPKANJCN;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> INJBDAHHFGO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> DEPGGJFPDPL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera NFNAPNHFANE;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> COGIJNGCKIP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> HGIHFLOIADM;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode BJOFFLGLCMH;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color HBIFHHMHBJA;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color GJCCJFIELFC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color IDKGBFHGDOK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap BPAIGMEBMKD;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool DCDHCCOLAHO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> GFIFONMAMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7025010", Offset = "0x7024410", VA = "0x187025010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> MHIOPHOMPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x70252F0", Offset = "0x70246F0", VA = "0x1870252F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera KDHDBKEBOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7025340", Offset = "0x7024740", VA = "0x187025340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7025E70", Offset = "0x7025270", VA = "0x187025E70")]
	public static void JLDFCKCFIJB(Vector3 KHKHFADLBIH, Quaternion HKFBKMCAHHL, ImposterRenderConfig LBLJNKMCPFE, bool ILBNILFGLOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7025B50", Offset = "0x7024F50", VA = "0x187025B50")]
	private static void IIFPOCFCNJM(Vector3 KHKHFADLBIH, Quaternion HKFBKMCAHHL, URPLight HMIGGOIJKAI, ImposterRenderConfig.LightConfig OFMBALLIBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7025060", Offset = "0x7024460", VA = "0x187025060")]
	public static void DIJMABEHGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x70264A0", Offset = "0x70258A0", VA = "0x1870264A0")]
	private static void LOKKBGGBIJA(int KJCBOIDPLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7025140", Offset = "0x7024540", VA = "0x187025140")]
	public static void DNDGJOEHNLJ(ImposterRenderConfig LBLJNKMCPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70263C0", Offset = "0x70257C0", VA = "0x1870263C0")]
	public static void LBGJDIGILLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70246A0", Offset = "0x7023AA0", VA = "0x1870246A0")]
	public static void CHMENDHGIDF(GameObject NDCIIJEJLOP, RenderTexture BJOPCDPNEJH, ImposterRenderConfig LBLJNKMCPFE, PJKHGJGAIAK EMADOCDNGAC, [Optional] Vector3? HKCNILJNPJD, [Optional] Vector3? LNCFLEBCCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70249E0", Offset = "0x7023DE0", VA = "0x1870249E0")]
	private static void DBFAIJLIBBN(GameObject NDCIIJEJLOP, RenderTexture BJOPCDPNEJH, ImposterRenderConfig LBLJNKMCPFE, PJKHGJGAIAK EMADOCDNGAC, Vector3 HKCNILJNPJD, Vector3 LNCFLEBCCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7026100", Offset = "0x7025500", VA = "0x187026100")]
	private static void KHOEAOJDDKK(GameObject NDCIIJEJLOP, Vector3 NIEKHMBBFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70268B0", Offset = "0x7025CB0", VA = "0x1870268B0")]
	public static void OCPNPNGFDMC(Bounds JMBENOHGHLJ, ImposterRenderConfig LBLJNKMCPFE, [Out] Vector3 ILDINMHIEEG, [Out] Quaternion IMKPDCHOOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7025570", Offset = "0x7024970", VA = "0x187025570")]
	private static void HGKCPBBMNKK(GameObject FIDMHGJFAFJ, ImposterRenderConfig LBLJNKMCPFE, PJKHGJGAIAK EMADOCDNGAC, [Out] Vector3 ILDINMHIEEG, [Out] Quaternion IMKPDCHOOJC, [Out] float HKLECBBEIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7025A80", Offset = "0x7024E80", VA = "0x187025A80")]
	public static RenderTexture HOFJPIFMBIL(int KHEFLNOGEHI, int ADAKCMMMMFF, RenderTextureFormat LAKAMCGCHJB = RenderTextureFormat.ARGB32, string CKGCLAHIEHL = "[ImposterRendering]Preview")
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
		public struct MPHCPDDLCEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public FPFCPNKOFAP BPGDDNEJNGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject EFINAEHLBPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture FIAHKFGEOJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig LNADKMALCDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public PJKHGJGAIAK PJKHGJGAIAK;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7026E30", Offset = "0x7026230", VA = "0x187026E30")]
			public MPHCPDDLCEO(FPFCPNKOFAP JLLOAJKMIBO, GameObject ILJFEAHCJDH, RenderTexture BJOPCDPNEJH, ImposterRenderConfig JLNJKDCIPGO, PJKHGJGAIAK EMADOCDNGAC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static HIBACLKOFDE<MPHCPDDLCEO, RenderTexture> KIPNMFPEKGN;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<MPHCPDDLCEO> JBKFMMNMHNK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int NGPPJLIMLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7020F60", Offset = "0x7020360", VA = "0x187020F60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7021080", Offset = "0x7020480", VA = "0x187021080")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NDCIIJEJLOP, RenderTexture BJOPCDPNEJH, ImposterRenderConfig LBLJNKMCPFE, PJKHGJGAIAK EMADOCDNGAC, CancellationToken FHGIOBPPFHG, bool BMHEFEHDLFB = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7020AB0", Offset = "0x701FEB0", VA = "0x187020AB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7020FF0", Offset = "0x70203F0", VA = "0x187020FF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7020CC0", Offset = "0x70200C0", VA = "0x187020CC0")]
		private static Task<RenderTexture> MGFOIJMIGHD(MPHCPDDLCEO CFOAPCNNOPG, CancellationToken FHGIOBPPFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7021480", Offset = "0x7020880", VA = "0x187021480")]
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
