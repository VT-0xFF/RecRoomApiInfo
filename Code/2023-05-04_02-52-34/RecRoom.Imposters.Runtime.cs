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
	private readonly struct IBDLKMAONGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KNGDAECHOFB JIGAOLFFNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string EFBIABFPECB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0F0", Offset = "0x7EA4F0", VA = "0x1807EB0F0")]
		public IBDLKMAONGJ(KNGDAECHOFB LIDJIDOMNFK, string CIJOBEFNJEC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ILPNEIJJPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public IBDLKMAONGJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6903350", Offset = "0x6902750", VA = "0x186903350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6903690", Offset = "0x6902A90", VA = "0x186903690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider GIFBCDHDOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::NMHOLBIFPJD<IBDLKMAONGJ, GameObject> LNKDBMBCDHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GKIOPGALCOE PPOKEFLEAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x734AF0", Offset = "0x733EF0", VA = "0x180734AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::NMHOLBIFPJD<IBDLKMAONGJ, GameObject> JCHGCFGLBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68FF150", Offset = "0x68FE550", VA = "0x1868FF150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int PCOLFGEJGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68FEF30", Offset = "0x68FE330", VA = "0x1868FEF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68FED30", Offset = "0x68FE130", VA = "0x1868FED30", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68FF2B0", Offset = "0x68FE6B0", VA = "0x1868FF2B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68FEDE0", Offset = "0x68FE1E0", VA = "0x1868FEDE0")]
	[AsyncStateMachine(typeof(ILPNEIJJPMA))]
	private Task<GameObject> LHCNLGOPNLP(IBDLKMAONGJ PLMDGCIEHMI, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68FEF80", Offset = "0x68FE380", VA = "0x1868FEF80")]
	public Task<GameObject> LoadItemAsync(KNGDAECHOFB LIDJIDOMNFK, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68FF320", Offset = "0x68FE720", VA = "0x1868FF320")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EHJHPMPHCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KNGDAECHOFB HMIIOHLCJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture DCLJGPCLLIK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7DE200", Offset = "0x7DD600", VA = "0x1807DE200")]
		public EHJHPMPHCED(KNGDAECHOFB LFECFKFMKPM, Texture IABGICEDMHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum OANJCCOLIDL
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
	private class JBMDFBOGOMC : global::EBCMIJBCHOC<Texture>, CNCDPCJODNI, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct HLLIDLOADEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public JBMDFBOGOMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6902470", Offset = "0x6901870", VA = "0x186902470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6902B70", Offset = "0x6901F70", VA = "0x186902B70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly KNGDAECHOFB LFECFKFMKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture MCBMPNNCIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig JIJIGNMNGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken OIMNLGJCBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject ALFFDIPJMMB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private JKAHJLGEFLE PCKBHIEKEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69047F0", Offset = "0x6903BF0", VA = "0x1869047F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::ODHJGGEEIEO<Texture> GDHMGJIPGBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x69047A0", Offset = "0x6903BA0", VA = "0x1869047A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task NABIIJNOOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> LJIHFECCOGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6904800", Offset = "0x6903C00", VA = "0x186904800")]
		public JBMDFBOGOMC(KNGDAECHOFB LFECFKFMKPM, RenderTexture MCBMPNNCIFL, ImposterRenderConfig JIJIGNMNGCN, CancellationToken OIMNLGJCBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6904680", Offset = "0x6903A80", VA = "0x186904680")]
		[AsyncStateMachine(typeof(HLLIDLOADEH))]
		private Task<Texture> KGAGHLEHFMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69045E0", Offset = "0x69039E0", VA = "0x1869045E0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69045F0", Offset = "0x69039F0", VA = "0x1869045F0")]
		private static void FBBNFKHFJPK(GameObject ALFFDIPJMMB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IBHFGGBJECN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6902BC0", Offset = "0x6901FC0", VA = "0x186902BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xF4AD90", Offset = "0xF4A190", VA = "0x180F4AD90", Slot = "5")]
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
	[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private OANJCCOLIDL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[MNCHKJFLKIP("size", 0)]
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
	private RenderTexture JHPNENCIEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::JNPPGBJHIKA<GameObject> NNJBAFNFEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PLALJAJNMKE FDCNHMGMIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource FFLFGHGEBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::EBCMIJBCHOC<Texture> DDICJJBDMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private KNGDAECHOFB OEHPKMIGMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture BKHKJMFMEBP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture PFNFGLLFPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6903C80", Offset = "0x6903080", VA = "0x186903C80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77EAD0", Offset = "0x77DED0", VA = "0x18077EAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private KNGDAECHOFB HMIIOHLCJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72B0C0", Offset = "0x72A4C0", VA = "0x18072B0C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6903A40", Offset = "0x6902E40", VA = "0x186903A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool HBAKHIAPJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A9290", Offset = "0x8A8690", VA = "0x1808A9290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int CBNEBCPMLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6903A30", Offset = "0x6902E30", VA = "0x186903A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69038B0", Offset = "0x6902CB0", VA = "0x1869038B0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6903DF0", Offset = "0x69031F0", VA = "0x186903DF0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69039A0", Offset = "0x6902DA0", VA = "0x1869039A0")]
	private void DHADANGHLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6904110", Offset = "0x6903510", VA = "0x186904110")]
	public void Set(KNGDAECHOFB AACJCFFJPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6904160", Offset = "0x6903560", VA = "0x186904160")]
	public void Set(Texture IABGICEDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6904120", Offset = "0x6903520", VA = "0x186904120")]
	public void Set(EHJHPMPHCED LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6903990", Offset = "0x6902D90", VA = "0x186903990")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6903EF0", Offset = "0x69032F0", VA = "0x186903EF0")]
	public void SetInternal(KNGDAECHOFB AACJCFFJPDI, [Optional] Texture CIEILAIHLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6903EE0", Offset = "0x69032E0", VA = "0x186903EE0")]
	public void SetCustomSize(int NGANBBIGPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x785A50", Offset = "0x784E50", VA = "0x180785A50")]
	public void SetAntiAliasing(int MBAEOBBGKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69038C0", Offset = "0x6902CC0", VA = "0x1869038C0")]
	[AsyncStateMachine(typeof(IBHFGGBJECN))]
	private void CAPCDPKLCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6903B90", Offset = "0x6902F90", VA = "0x186903B90")]
	private void KIHOJLPIGHK(Texture IABGICEDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6904170", Offset = "0x6903570", VA = "0x186904170")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, GBKIDPJAHAP
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float GMALPBPFIGI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "4")]
	public void PrepareImposter(ILHMGDCILMM BHGFJLDJJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6903870", Offset = "0x6902C70", VA = "0x186903870")]
	public void SetReferencePoint(Vector3 KPEIOCLIHAH, Quaternion LOFMMAJIGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69036E0", Offset = "0x6902AE0", VA = "0x1869036E0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6903840", Offset = "0x6902C40", VA = "0x186903840")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1392F20", Offset = "0x1392320", VA = "0x181392F20")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DFDJICCGPEO
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static DFDJICCGPEO KIBHFDAGGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float ICJDAOEOJBL;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xC835D0", Offset = "0xC829D0", VA = "0x180C835D0")]
	public DFDJICCGPEO(float HNOHODBIGCM)
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
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int BDDGDGCEDEF = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int MFIKLLECNAC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> PKJKJHGCHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool DFDDCEBJKLP;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6904320", Offset = "0x6903720", VA = "0x186904320")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6904230", Offset = "0x6903630", VA = "0x186904230")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6904560", Offset = "0x6903960", VA = "0x186904560")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KNGDAECHOFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string ADIONHKGAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DFDJICCGPEO DFDJICCGPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BKJALDCIKGJ;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> ENMCIABEOEK(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFDJOPCPCOF(KNGDAECHOFB MPHACEGLFIL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLGEFPEENFM();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJEMBLJNIEE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JDJBNEICAGE(out global::EBCMIJBCHOC<Texture> INAPKFAFAKN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OMDLKKHAOIN
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6905010", Offset = "0x6904410", VA = "0x186905010")]
	public static bool BKDAFMPKLHM(KNGDAECHOFB JPCKBOFGDCL, KNGDAECHOFB LDMDHJMJOEC)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, GBKIDPJAHAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x68FE260", Offset = "0x68FD660", VA = "0x1868FE260", Slot = "4")]
		public void PrepareImposter(ILHMGDCILMM BHGFJLDJJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GBKIDPJAHAP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ILHMGDCILMM BHGFJLDJJON);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NOPIHJLKCHK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GNJOIELEJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> ONGGMFPOEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GKIOPGALCOE
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFNNDIJNHHM(params Type[] OFGCLOACCDN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPJAEBLEDPE(params Type[] OFGCLOACCDN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject JBEHHNHEOLE(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JBEHHNHEOLE<T>(T OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T JBEHHNHEOLE<T>(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JBEHHNHEOLE(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T JBEHHNHEOLE<T>(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T JBEHHNHEOLE<T>(T OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FHDOPBLPNOC : IDisposable, GKIOPGALCOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> HNOPHLLHFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> MBEDCLHCLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform KCBJHKAPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> GFLIBLJMDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> OOMBIHAIOKP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6901720", Offset = "0x6900B20", VA = "0x186901720")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	public static void GBFPCIFAHPO(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6902030", Offset = "0x6901430", VA = "0x186902030")]
	[Preserve]
	public FHDOPBLPNOC([LIKONNNLKGK(null)] NOPIHJLKCHK FCMDFFLNFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6901620", Offset = "0x6900A20", VA = "0x186901620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69014A0", Offset = "0x69008A0", VA = "0x1869014A0", Slot = "5")]
	public void AFNNDIJNHHM(params Type[] OFGCLOACCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6901FE0", Offset = "0x69013E0", VA = "0x186901FE0", Slot = "6")]
	public void PPJAEBLEDPE(params Type[] OFGCLOACCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6901810", Offset = "0x6900C10", VA = "0x186901810", Slot = "7")]
	public GameObject JBEHHNHEOLE(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x261A730", Offset = "0x2619B30", VA = "0x18261A730", Slot = "8")]
	public T JBEHHNHEOLE<T>(T OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x261ADB0", Offset = "0x261A1B0", VA = "0x18261ADB0", Slot = "9")]
	public T JBEHHNHEOLE<T>(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69018A0", Offset = "0x6900CA0", VA = "0x1869018A0", Slot = "10")]
	public GameObject JBEHHNHEOLE(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x261A7A0", Offset = "0x2619BA0", VA = "0x18261A7A0", Slot = "11")]
	public T JBEHHNHEOLE<T>(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x261AD20", Offset = "0x261A120", VA = "0x18261AD20", Slot = "12")]
	public T JBEHHNHEOLE<T>(T OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x261A7F0", Offset = "0x2619BF0", VA = "0x18261A7F0")]
	private T JBEHHNHEOLE<T>(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF, out GameObject BGEKOOHKBDC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x261A1D0", Offset = "0x26195D0", VA = "0x18261A1D0")]
	private T EDEKNNPNGHO<T>(GameObject DLNMCGFEPOP, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69014F0", Offset = "0x69008F0", VA = "0x1869014F0")]
	private void CGDHJNGCGAL(Component AFCHMEJMNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6901A90", Offset = "0x6900E90", VA = "0x186901A90")]
	private void OMCDOCKFECH(Component AFCHMEJMNBE, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF, bool MAMIPEGJOBI, [Optional] Type JBDAMKJFJLJ, [Optional] Type OPJOEEBDBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6901930", Offset = "0x6900D30", VA = "0x186901930")]
	private void NEPAEDDDEIE(GameObject DLNMCGFEPOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ILHMGDCILMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> COAGNGCHEDM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5390", Offset = "0x1DC4790", VA = "0x181DC5390")]
	public ILHMGDCILMM EFMALMFMJGL<T>(T AJMLEIMJIOL)
	{
		return default(ILHMGDCILMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5AC0", Offset = "0x1DC4EC0", VA = "0x181DC5AC0")]
	public T MKLBNKEKMJE<T>(T LGCPJJBBDLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5BE0", Offset = "0x1DC4FE0", VA = "0x181DC5BE0")]
	public bool OBCGBBDEENH<T>(out T AJMLEIMJIOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NJAGODLJJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool CACBLJKDGDN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xCB80A0", Offset = "0xCB74A0", VA = "0x180CB80A0")]
	public NJAGODLJJJJ(bool LACCHBNCDNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OAKONJBEBKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool IPHDIGPKFIL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6905000", Offset = "0x6904400", VA = "0x186905000")]
	public OAKONJBEBKL(bool DPDEKOGFODB)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, GBKIDPJAHAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69050F0", Offset = "0x69044F0", VA = "0x1869050F0", Slot = "4")]
		public void PrepareImposter(ILHMGDCILMM BHGFJLDJJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
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
				[Cpp2IlInjected.Address(RVA = "0x6904FE0", Offset = "0x69043E0", VA = "0x186904FE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6904FD0", Offset = "0x69043D0", VA = "0x186904FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69041F0", Offset = "0x69035F0", VA = "0x1869041F0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EENNODEMKJD
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> BPJOKDAABHD;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 MCGNMLLEIOM;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 CLMOBKJKCDF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera AHAIANNMOHE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string NDDEAKGCJFP = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const HAKPBKMNANB EMCAKPAALDI = HAKPBKMNANB.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> GPEMENMPMBG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode LEHHJCMBNFJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color FIIMCHANIBN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color NHFGLOKLJKN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color DEAHGNOEJFA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap HOEGCLDAFAM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool GJKIGBIJHOH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera KFDAAPJBEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68FF5C0", Offset = "0x68FE9C0", VA = "0x1868FF5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6900220", Offset = "0x68FF620", VA = "0x186900220")]
	public static void FNDKCBJJJNK(Vector3 NPBKIEACEMP, Quaternion MICNMFJKHLD, ImposterRenderConfig LKKLEKNGBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x68FFF10", Offset = "0x68FF310", VA = "0x1868FFF10")]
	private static void FHAECCHMCNM(Vector3 NPBKIEACEMP, Quaternion MICNMFJKHLD, URPLight HKEKKAPPODJ, ImposterRenderConfig.LightConfig LDELOAOGKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6900CC0", Offset = "0x69000C0", VA = "0x186900CC0")]
	public static void MCFMLIJPAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x68FFAA0", Offset = "0x68FEEA0", VA = "0x1868FFAA0")]
	private static void DCLAIAHMDKF(int NIBABFDOKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69004A0", Offset = "0x68FF8A0", VA = "0x1869004A0")]
	public static void KFPCHPKLIBH(ImposterRenderConfig LKKLEKNGBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6900DB0", Offset = "0x69001B0", VA = "0x186900DB0")]
	public static void MEBDLHAOCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6900EB0", Offset = "0x69002B0", VA = "0x186900EB0")]
	public static void NMFFKHOMKGG(GameObject CFEALBKPBCK, RenderTexture MCBMPNNCIFL, ImposterRenderConfig LKKLEKNGBHF, DFDJICCGPEO CEGGCJMNPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6900620", Offset = "0x68FFA20", VA = "0x186900620")]
	private static void LEJDOOFAJLM(GameObject CFEALBKPBCK, RenderTexture MCBMPNNCIFL, ImposterRenderConfig LKKLEKNGBHF, DFDJICCGPEO CEGGCJMNPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68FF7F0", Offset = "0x68FEBF0", VA = "0x1868FF7F0")]
	private static void DBGCOIDACCD(GameObject CFEALBKPBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6900B20", Offset = "0x68FFF20", VA = "0x186900B20")]
	public static void MANJBFDGKIG(List<Renderer> FIHAAIGDJNO, List<Material> MMOICLFHNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6901080", Offset = "0x6900480", VA = "0x186901080")]
	public static void OOPEMININMH(GameObject OPBBFNOFOIK, Vector3 BKJAEBFEDKP, Vector3 BDGFILOLDLK, float JHKKBPKPOCL, DFDJICCGPEO CEGGCJMNPEG, out Vector3 EJGJFGOEAMI, out Quaternion BDIAFHIGHNB, out float HMKBMFGEIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x68FFE70", Offset = "0x68FF270", VA = "0x1868FFE70")]
	public static RenderTexture EJCKDADFGJI(int CNHIJOPNDKB, int PJDCFLLCMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68FF390", Offset = "0x68FE790", VA = "0x1868FF390")]
	public static void BCLBBPCKLAM()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct AIHNCLINPJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public IDFJJMAGGAN AAKPPKIFLGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject MKHKDKGMOFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture PFNFGLLFPFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig AEJHIEKKBAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public DFDJICCGPEO DFDJICCGPEO;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x68FE1F0", Offset = "0x68FD5F0", VA = "0x1868FE1F0")]
			public AIHNCLINPJL(IDFJJMAGGAN EKHBCMEIBCI, GameObject HJLCIHLLJOL, RenderTexture MCBMPNNCIFL, ImposterRenderConfig JIJIGNMNGCN, DFDJICCGPEO CEGGCJMNPEG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::NMHOLBIFPJD<AIHNCLINPJL, RenderTexture> BFBDFHENOBF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<AIHNCLINPJL> GJKNJDNCGGE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int DKDHGBBEDGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x68FE7C0", Offset = "0x68FDBC0", VA = "0x1868FE7C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68FE8D0", Offset = "0x68FDCD0", VA = "0x1868FE8D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject CFEALBKPBCK, RenderTexture MCBMPNNCIFL, ImposterRenderConfig LKKLEKNGBHF, DFDJICCGPEO CEGGCJMNPEG, CancellationToken OIMNLGJCBEC, bool ANPNGMFEKBP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68FE400", Offset = "0x68FD800", VA = "0x1868FE400", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68FE830", Offset = "0x68FDC30", VA = "0x1868FE830", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68FE5F0", Offset = "0x68FD9F0", VA = "0x1868FE5F0")]
		private static Task<RenderTexture> BMIHNAMACPA(AIHNCLINPJL MKOOBDILHFI, CancellationToken OIMNLGJCBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x68FECC0", Offset = "0x68FE0C0", VA = "0x1868FECC0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6904CF0", Offset = "0x69040F0", VA = "0x186904CF0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69049A0", Offset = "0x6903DA0", VA = "0x1869049A0")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
