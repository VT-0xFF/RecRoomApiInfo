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
		[Cpp2IlInjected.Address(RVA = "0x7C16B0", Offset = "0x7C00B0", VA = "0x1807C16B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E35D0", Offset = "0x68E1FD0", VA = "0x1868E35D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68E3910", Offset = "0x68E2310", VA = "0x1868E3910", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::NMHOLBIFPJD<IBDLKMAONGJ, GameObject> JCHGCFGLBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68DF3D0", Offset = "0x68DDDD0", VA = "0x1868DF3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int PCOLFGEJGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68DF1B0", Offset = "0x68DDBB0", VA = "0x1868DF1B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68DEFB0", Offset = "0x68DD9B0", VA = "0x1868DEFB0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68DF530", Offset = "0x68DDF30", VA = "0x1868DF530", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68DF060", Offset = "0x68DDA60", VA = "0x1868DF060")]
	[AsyncStateMachine(typeof(ILPNEIJJPMA))]
	private Task<GameObject> LHCNLGOPNLP(IBDLKMAONGJ PLMDGCIEHMI, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68DF200", Offset = "0x68DDC00", VA = "0x1868DF200")]
	public Task<GameObject> LoadItemAsync(KNGDAECHOFB LIDJIDOMNFK, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68DF5A0", Offset = "0x68DDFA0", VA = "0x1868DF5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B6A40", Offset = "0x7B5440", VA = "0x1807B6A40")]
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
			[Cpp2IlInjected.Address(RVA = "0x68E26F0", Offset = "0x68E10F0", VA = "0x1868E26F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68E2DF0", Offset = "0x68E17F0", VA = "0x1868E2DF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x68E4A70", Offset = "0x68E3470", VA = "0x1868E4A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::ODHJGGEEIEO<Texture> GDHMGJIPGBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x68E4A20", Offset = "0x68E3420", VA = "0x1868E4A20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task NABIIJNOOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> LJIHFECCOGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68E4A80", Offset = "0x68E3480", VA = "0x1868E4A80")]
		public JBMDFBOGOMC(KNGDAECHOFB LFECFKFMKPM, RenderTexture MCBMPNNCIFL, ImposterRenderConfig JIJIGNMNGCN, CancellationToken OIMNLGJCBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68E4900", Offset = "0x68E3300", VA = "0x1868E4900")]
		[AsyncStateMachine(typeof(HLLIDLOADEH))]
		private Task<Texture> KGAGHLEHFMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68E4860", Offset = "0x68E3260", VA = "0x1868E4860", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68E4870", Offset = "0x68E3270", VA = "0x1868E4870")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E2E40", Offset = "0x68E1840", VA = "0x1868E2E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x10099B0", Offset = "0x10083B0", VA = "0x1810099B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E3F00", Offset = "0x68E2900", VA = "0x1868E3F00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x771120", Offset = "0x76FB20", VA = "0x180771120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private KNGDAECHOFB HMIIOHLCJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68E3CC0", Offset = "0x68E26C0", VA = "0x1868E3CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool HBAKHIAPJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E61C0", Offset = "0x8E4BC0", VA = "0x1808E61C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int CBNEBCPMLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68E3CB0", Offset = "0x68E26B0", VA = "0x1868E3CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68E3B30", Offset = "0x68E2530", VA = "0x1868E3B30")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68E4070", Offset = "0x68E2A70", VA = "0x1868E4070")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68E3C20", Offset = "0x68E2620", VA = "0x1868E3C20")]
	private void DHADANGHLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68E4390", Offset = "0x68E2D90", VA = "0x1868E4390")]
	public void Set(KNGDAECHOFB AACJCFFJPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68E43E0", Offset = "0x68E2DE0", VA = "0x1868E43E0")]
	public void Set(Texture IABGICEDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68E43A0", Offset = "0x68E2DA0", VA = "0x1868E43A0")]
	public void Set(EHJHPMPHCED LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68E3C10", Offset = "0x68E2610", VA = "0x1868E3C10")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68E4170", Offset = "0x68E2B70", VA = "0x1868E4170")]
	public void SetInternal(KNGDAECHOFB AACJCFFJPDI, [Optional] Texture CIEILAIHLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68E4160", Offset = "0x68E2B60", VA = "0x1868E4160")]
	public void SetCustomSize(int NGANBBIGPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7780A0", Offset = "0x776AA0", VA = "0x1807780A0")]
	public void SetAntiAliasing(int MBAEOBBGKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68E3B40", Offset = "0x68E2540", VA = "0x1868E3B40")]
	[AsyncStateMachine(typeof(IBHFGGBJECN))]
	private void CAPCDPKLCLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68E3E10", Offset = "0x68E2810", VA = "0x1868E3E10")]
	private void KIHOJLPIGHK(Texture IABGICEDMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68E43F0", Offset = "0x68E2DF0", VA = "0x1868E43F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "4")]
	public void PrepareImposter(ILHMGDCILMM BHGFJLDJJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68E3AF0", Offset = "0x68E24F0", VA = "0x1868E3AF0")]
	public void SetReferencePoint(Vector3 KPEIOCLIHAH, Quaternion LOFMMAJIGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68E3960", Offset = "0x68E2360", VA = "0x1868E3960")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68E3AC0", Offset = "0x68E24C0", VA = "0x1868E3AC0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x14BDA80", Offset = "0x14BC480", VA = "0x1814BDA80")]
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
	[Cpp2IlInjected.Address(RVA = "0x305E2D0", Offset = "0x305CCD0", VA = "0x18305E2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E45A0", Offset = "0x68E2FA0", VA = "0x1868E45A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68E44B0", Offset = "0x68E2EB0", VA = "0x1868E44B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68E47E0", Offset = "0x68E31E0", VA = "0x1868E47E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x68E5290", Offset = "0x68E3C90", VA = "0x1868E5290")]
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
		[Cpp2IlInjected.Address(RVA = "0x68DE4E0", Offset = "0x68DCEE0", VA = "0x1868DE4E0", Slot = "4")]
		public void PrepareImposter(ILHMGDCILMM BHGFJLDJJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
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
	[Cpp2IlInjected.Address(RVA = "0x68E19A0", Offset = "0x68E03A0", VA = "0x1868E19A0")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	public static void GBFPCIFAHPO(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68E22B0", Offset = "0x68E0CB0", VA = "0x1868E22B0")]
	[Preserve]
	public FHDOPBLPNOC([LIKONNNLKGK(null)] NOPIHJLKCHK FCMDFFLNFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68E18A0", Offset = "0x68E02A0", VA = "0x1868E18A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68E1720", Offset = "0x68E0120", VA = "0x1868E1720", Slot = "5")]
	public void AFNNDIJNHHM(params Type[] OFGCLOACCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x68E2260", Offset = "0x68E0C60", VA = "0x1868E2260", Slot = "6")]
	public void PPJAEBLEDPE(params Type[] OFGCLOACCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68E1A90", Offset = "0x68E0490", VA = "0x1868E1A90", Slot = "7")]
	public GameObject JBEHHNHEOLE(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C560", Offset = "0x2F7AF60", VA = "0x182F7C560", Slot = "8")]
	public T JBEHHNHEOLE<T>(T OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CBE0", Offset = "0x2F7B5E0", VA = "0x182F7CBE0", Slot = "9")]
	public T JBEHHNHEOLE<T>(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, bool EAGPIAOHDPF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68E1B20", Offset = "0x68E0520", VA = "0x1868E1B20", Slot = "10")]
	public GameObject JBEHHNHEOLE(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C5D0", Offset = "0x2F7AFD0", VA = "0x182F7C5D0", Slot = "11")]
	public T JBEHHNHEOLE<T>(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CB50", Offset = "0x2F7B550", VA = "0x182F7CB50", Slot = "12")]
	public T JBEHHNHEOLE<T>(T OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C620", Offset = "0x2F7B020", VA = "0x182F7C620")]
	private T JBEHHNHEOLE<T>(GameObject OPBBFNOFOIK, Transform GGEKFPEBLKN, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF, out GameObject BGEKOOHKBDC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C000", Offset = "0x2F7AA00", VA = "0x182F7C000")]
	private T EDEKNNPNGHO<T>(GameObject DLNMCGFEPOP, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68E1770", Offset = "0x68E0170", VA = "0x1868E1770")]
	private void CGDHJNGCGAL(Component AFCHMEJMNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68E1D10", Offset = "0x68E0710", VA = "0x1868E1D10")]
	private void OMCDOCKFECH(Component AFCHMEJMNBE, ILHMGDCILMM BHGFJLDJJON, bool EAGPIAOHDPF, bool MAMIPEGJOBI, [Optional] Type JBDAMKJFJLJ, [Optional] Type OPJOEEBDBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68E1BB0", Offset = "0x68E05B0", VA = "0x1868E1BB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2837150", Offset = "0x2835B50", VA = "0x182837150")]
	public ILHMGDCILMM EFMALMFMJGL<T>(T AJMLEIMJIOL)
	{
		return default(ILHMGDCILMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2837880", Offset = "0x2836280", VA = "0x182837880")]
	public T MKLBNKEKMJE<T>(T LGCPJJBBDLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28379A0", Offset = "0x28363A0", VA = "0x1828379A0")]
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
	[Cpp2IlInjected.Address(RVA = "0xE24610", Offset = "0xE23010", VA = "0x180E24610")]
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
	[Cpp2IlInjected.Address(RVA = "0x68E5280", Offset = "0x68E3C80", VA = "0x1868E5280")]
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
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E5370", Offset = "0x68E3D70", VA = "0x1868E5370", Slot = "4")]
		public void PrepareImposter(ILHMGDCILMM BHGFJLDJJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
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
				[Cpp2IlInjected.Address(RVA = "0x68E5260", Offset = "0x68E3C60", VA = "0x1868E5260")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x68E5250", Offset = "0x68E3C50", VA = "0x1868E5250")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E4470", Offset = "0x68E2E70", VA = "0x1868E4470")]
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
		[Cpp2IlInjected.Address(RVA = "0x68DF840", Offset = "0x68DE240", VA = "0x1868DF840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68E04A0", Offset = "0x68DEEA0", VA = "0x1868E04A0")]
	public static void FNDKCBJJJNK(Vector3 NPBKIEACEMP, Quaternion MICNMFJKHLD, ImposterRenderConfig LKKLEKNGBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x68E0190", Offset = "0x68DEB90", VA = "0x1868E0190")]
	private static void FHAECCHMCNM(Vector3 NPBKIEACEMP, Quaternion MICNMFJKHLD, URPLight HKEKKAPPODJ, ImposterRenderConfig.LightConfig LDELOAOGKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x68E0F40", Offset = "0x68DF940", VA = "0x1868E0F40")]
	public static void MCFMLIJPAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x68DFD20", Offset = "0x68DE720", VA = "0x1868DFD20")]
	private static void DCLAIAHMDKF(int NIBABFDOKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68E0720", Offset = "0x68DF120", VA = "0x1868E0720")]
	public static void KFPCHPKLIBH(ImposterRenderConfig LKKLEKNGBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68E1030", Offset = "0x68DFA30", VA = "0x1868E1030")]
	public static void MEBDLHAOCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68E1130", Offset = "0x68DFB30", VA = "0x1868E1130")]
	public static void NMFFKHOMKGG(GameObject CFEALBKPBCK, RenderTexture MCBMPNNCIFL, ImposterRenderConfig LKKLEKNGBHF, DFDJICCGPEO CEGGCJMNPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68E08A0", Offset = "0x68DF2A0", VA = "0x1868E08A0")]
	private static void LEJDOOFAJLM(GameObject CFEALBKPBCK, RenderTexture MCBMPNNCIFL, ImposterRenderConfig LKKLEKNGBHF, DFDJICCGPEO CEGGCJMNPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68DFA70", Offset = "0x68DE470", VA = "0x1868DFA70")]
	private static void DBGCOIDACCD(GameObject CFEALBKPBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68E0DA0", Offset = "0x68DF7A0", VA = "0x1868E0DA0")]
	public static void MANJBFDGKIG(List<Renderer> FIHAAIGDJNO, List<Material> MMOICLFHNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68E1300", Offset = "0x68DFD00", VA = "0x1868E1300")]
	public static void OOPEMININMH(GameObject OPBBFNOFOIK, Vector3 BKJAEBFEDKP, Vector3 BDGFILOLDLK, float JHKKBPKPOCL, DFDJICCGPEO CEGGCJMNPEG, out Vector3 EJGJFGOEAMI, out Quaternion BDIAFHIGHNB, out float HMKBMFGEIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x68E00F0", Offset = "0x68DEAF0", VA = "0x1868E00F0")]
	public static RenderTexture EJCKDADFGJI(int CNHIJOPNDKB, int PJDCFLLCMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68DF610", Offset = "0x68DE010", VA = "0x1868DF610")]
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
			[Cpp2IlInjected.Address(RVA = "0x68DE470", Offset = "0x68DCE70", VA = "0x1868DE470")]
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
			[Cpp2IlInjected.Address(RVA = "0x68DEA40", Offset = "0x68DD440", VA = "0x1868DEA40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68DEB50", Offset = "0x68DD550", VA = "0x1868DEB50")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject CFEALBKPBCK, RenderTexture MCBMPNNCIFL, ImposterRenderConfig LKKLEKNGBHF, DFDJICCGPEO CEGGCJMNPEG, CancellationToken OIMNLGJCBEC, bool ANPNGMFEKBP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68DE680", Offset = "0x68DD080", VA = "0x1868DE680", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68DEAB0", Offset = "0x68DD4B0", VA = "0x1868DEAB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68DE870", Offset = "0x68DD270", VA = "0x1868DE870")]
		private static Task<RenderTexture> BMIHNAMACPA(AIHNCLINPJL MKOOBDILHFI, CancellationToken OIMNLGJCBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x68DEF40", Offset = "0x68DD940", VA = "0x1868DEF40")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68E4F70", Offset = "0x68E3970", VA = "0x1868E4F70")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68E4C20", Offset = "0x68E3620", VA = "0x1868E4C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
