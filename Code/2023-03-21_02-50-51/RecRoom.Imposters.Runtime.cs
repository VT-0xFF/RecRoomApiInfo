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
	private readonly struct BBEGFJAFACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly AOJLHHPJHEL NKEPFBCNEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BJMLKDGDDDK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x785A30", Offset = "0x784230", VA = "0x180785A30")]
		public BBEGFJAFACA(AOJLHHPJHEL ICBMPKHOLDI, string AIGKKPFNNAM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct BJCLBMHFOFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public BBEGFJAFACA queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64DED40", Offset = "0x64DD540", VA = "0x1864DED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64DF080", Offset = "0x64DD880", VA = "0x1864DF080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider CIDGIBHLGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::CHLFPNDBOOG<BBEGFJAFACA, GameObject> KAAAGCJOOEC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ELPOHLPCCNF OOFLGKFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::CHLFPNDBOOG<BBEGFJAFACA, GameObject> IJOLNJKMCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64E2600", Offset = "0x64E0E00", VA = "0x1864E2600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int DJNEKAHHINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64E29A0", Offset = "0x64E11A0", VA = "0x1864E29A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64E2550", Offset = "0x64E0D50", VA = "0x1864E2550", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64E2930", Offset = "0x64E1130", VA = "0x1864E2930", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64E2400", Offset = "0x64E0C00", VA = "0x1864E2400")]
	[AsyncStateMachine(typeof(BJCLBMHFOFB))]
	private Task<GameObject> APOFMIKECAM(BBEGFJAFACA NFFIDHGDJOK, CancellationToken DIEJHKIAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64E2760", Offset = "0x64E0F60", VA = "0x1864E2760")]
	public Task<GameObject> LoadItemAsync(AOJLHHPJHEL ICBMPKHOLDI, CancellationToken DIEJHKIAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64E29F0", Offset = "0x64E11F0", VA = "0x1864E29F0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class JNFIEBOFDMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AOJLHHPJHEL HMICOHPCPFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture FDHNJOLMCBC;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D56E0", Offset = "0x6D3EE0", VA = "0x1806D56E0")]
		public JNFIEBOFDMJ(AOJLHHPJHEL EJBMDFMOPNE, Texture KDIGAMMGOAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum LGALAKMPDAJ
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
	private class BCIBFOPIMMC : global::FHFGABMPMPC<Texture>, CJMAKIMALDJ, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct BOEPDALGFDC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public BCIBFOPIMMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x64DF110", Offset = "0x64DD910", VA = "0x1864DF110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x64DF810", Offset = "0x64DE010", VA = "0x1864DF810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly AOJLHHPJHEL EJBMDFMOPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture KFPIPKEMGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig EIMAEFJILGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken DIEJHKIAFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject DLMPMKKPLOL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LDGADANDBIO MHJBAABDJHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x64DE980", Offset = "0x64DD180", VA = "0x1864DE980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::FGLDKEJLAKB<Texture> HNBAMGOFKLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x64DEA30", Offset = "0x64DD230", VA = "0x1864DEA30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task OEPAFDJICHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> CCBPDJBMMCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x64DEBA0", Offset = "0x64DD3A0", VA = "0x1864DEBA0")]
		public BCIBFOPIMMC(AOJLHHPJHEL EJBMDFMOPNE, RenderTexture KFPIPKEMGLA, ImposterRenderConfig EIMAEFJILGH, CancellationToken DIEJHKIAFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x64DEA80", Offset = "0x64DD280", VA = "0x1864DEA80")]
		[AsyncStateMachine(typeof(BOEPDALGFDC))]
		private Task<Texture> GACNKDOMPOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x64DE990", Offset = "0x64DD190", VA = "0x1864DE990", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x64DE9A0", Offset = "0x64DD1A0", VA = "0x1864DE9A0")]
		private static void ECHMMLEFPLK(GameObject DLMPMKKPLOL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OPDFBJJIFAL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x64E4AB0", Offset = "0x64E32B0", VA = "0x1864E4AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DEAD0", Offset = "0x6DD2D0", VA = "0x1806DEAD0", Slot = "5")]
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
	[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private LGALAKMPDAJ size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[CPILAAFLPDK("size", 0)]
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
	private RenderTexture EDLFPDNBPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::CCPNGBMKLHP<GameObject> JPNJOEBIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private KKCOJBHLCCF AGHEDNBDGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource GABGOINNOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::FHFGABMPMPC<Texture> GKLMKLEMIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private AOJLHHPJHEL CDPHDLKDFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture CEDPDPFLBKG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture GMOIFKAFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64E2DD0", Offset = "0x64E15D0", VA = "0x1864E2DD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5A0", Offset = "0x6DADA0", VA = "0x1806DC5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private AOJLHHPJHEL HMICOHPCPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB780", Offset = "0x6E9F80", VA = "0x1806EB780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x64E3010", Offset = "0x64E1810", VA = "0x1864E3010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool FLPENACKLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8C0520", Offset = "0x8BED20", VA = "0x1808C0520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int LLPAACFKMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x64E3160", Offset = "0x64E1960", VA = "0x1864E3160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64E2C30", Offset = "0x64E1430", VA = "0x1864E2C30")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64E3170", Offset = "0x64E1970", VA = "0x1864E3170")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64E2D40", Offset = "0x64E1540", VA = "0x1864E2D40")]
	private void GDMOHHPELIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64E34E0", Offset = "0x64E1CE0", VA = "0x1864E34E0")]
	public void Set(AOJLHHPJHEL FEEFIBGNJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64E34D0", Offset = "0x64E1CD0", VA = "0x1864E34D0")]
	public void Set(Texture KDIGAMMGOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64E3490", Offset = "0x64E1C90", VA = "0x1864E3490")]
	public void Set(JNFIEBOFDMJ NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64E2D30", Offset = "0x64E1530", VA = "0x1864E2D30")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64E3270", Offset = "0x64E1A70", VA = "0x1864E3270")]
	public void SetInternal(AOJLHHPJHEL FEEFIBGNJLI, [Optional] Texture LEOCDPJEAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64E3260", Offset = "0x64E1A60", VA = "0x1864E3260")]
	public void SetCustomSize(int ADPGPBFDDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x73C580", Offset = "0x73AD80", VA = "0x18073C580")]
	public void SetAntiAliasing(int IMJOJPNIBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x64E2F40", Offset = "0x64E1740", VA = "0x1864E2F40")]
	[AsyncStateMachine(typeof(OPDFBJJIFAL))]
	private void MPDDBFMAIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x64E2C40", Offset = "0x64E1440", VA = "0x1864E2C40")]
	private void BNBDFKPKPBP(Texture KDIGAMMGOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x64E34F0", Offset = "0x64E1CF0", VA = "0x1864E34F0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, JCAALMJKMFO
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float ACJMMLEEPLO = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "4")]
	public void PrepareImposter(OPBAIAGNNPL NDEGHHCMGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x64E2BF0", Offset = "0x64E13F0", VA = "0x1864E2BF0")]
	public void SetReferencePoint(Vector3 GFAGIPAOELL, Quaternion DLNPDPAPICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x64E2A60", Offset = "0x64E1260", VA = "0x1864E2A60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x64E2BC0", Offset = "0x64E13C0", VA = "0x1864E2BC0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E5EEB0", Offset = "0x1E5D6B0", VA = "0x181E5EEB0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BLFJFIMGFOC
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static BLFJFIMGFOC JJLJPNGBAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float EIHEHHCKFAG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2F35080", Offset = "0x2F33880", VA = "0x182F35080")]
	public BLFJFIMGFOC(float GGNEHFAHBDM)
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
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int HGFOEDKGABH = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int CHACEDKFNKB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> KNDPPMEJJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool IPIKOEIHONK;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x64E36A0", Offset = "0x64E1EA0", VA = "0x1864E36A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x64E35B0", Offset = "0x64E1DB0", VA = "0x1864E35B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x64E38E0", Offset = "0x64E20E0", VA = "0x1864E38E0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AOJLHHPJHEL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string BNHJBFJLKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BLFJFIMGFOC BLFJFIMGFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FNPDHAEDJOK;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> MDMEJOEODFO(CancellationToken DIEJHKIAFPL);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GOPFCAICKKI(AOJLHHPJHEL HAKPJJGEGOM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOGMIPLIOHL();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNPFMMKIOEC();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HGMBIDNHGMK(out global::FHFGABMPMPC<Texture> KDNNLGDKGKG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MPBBDEIMDBD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x64E49D0", Offset = "0x64E31D0", VA = "0x1864E49D0")]
	public static bool DEMAIBLFOMI(AOJLHHPJHEL EKGHNKCNJJB, AOJLHHPJHEL OCFDBJKNNFO)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, JCAALMJKMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x64DF860", Offset = "0x64DE060", VA = "0x1864DF860", Slot = "4")]
		public void PrepareImposter(OPBAIAGNNPL NDEGHHCMGIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JCAALMJKMFO
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(OPBAIAGNNPL NDEGHHCMGIN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HFBHJPEFALA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> EGHBGCHHLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> MCPHCECMIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ELPOHLPCCNF
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHNFIIAJJNG(params Type[] ELMBJAGHLEM);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIGGCLDLJLN(params Type[] ELMBJAGHLEM);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject NPHAMFMDKPP(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, bool FHDJBEIILKP = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T NPHAMFMDKPP<T>(T ONIHIIPCKEF, Transform FAAJOMIIHED, bool FHDJBEIILKP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T NPHAMFMDKPP<T>(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, bool FHDJBEIILKP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject NPHAMFMDKPP(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T NPHAMFMDKPP<T>(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T NPHAMFMDKPP<T>(T ONIHIIPCKEF, Transform FAAJOMIIHED, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MECEEDAEPHA : IDisposable, ELPOHLPCCNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> BIMKFFFPNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> LDHDHCKKIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform CDFKHKFMHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> BDIEGKGDCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CBNLCHFBMGE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x64E4330", Offset = "0x64E2B30", VA = "0x1864E4330")]
	[HAHBDBPNEOA(MDCFJLLNHDJ.None)]
	public static void LJEJEKJKKPP(BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x64E4590", Offset = "0x64E2D90", VA = "0x1864E4590")]
	[Preserve]
	public MECEEDAEPHA([LJAGOLJKNEF(null)] HFBHJPEFALA DCKKKGLNKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x64E3BB0", Offset = "0x64E23B0", VA = "0x1864E3BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x64E4420", Offset = "0x64E2C20", VA = "0x1864E4420", Slot = "5")]
	public void MHNFIIAJJNG(params Type[] ELMBJAGHLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x64E3B60", Offset = "0x64E2360", VA = "0x1864E3B60", Slot = "6")]
	public void DIGGCLDLJLN(params Type[] ELMBJAGHLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64E4470", Offset = "0x64E2C70", VA = "0x1864E4470", Slot = "7")]
	public GameObject NPHAMFMDKPP(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, bool FHDJBEIILKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x24F7A40", Offset = "0x24F6240", VA = "0x1824F7A40", Slot = "8")]
	public T NPHAMFMDKPP<T>(T ONIHIIPCKEF, Transform FAAJOMIIHED, bool FHDJBEIILKP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x24F7AB0", Offset = "0x24F62B0", VA = "0x1824F7AB0", Slot = "9")]
	public T NPHAMFMDKPP<T>(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, bool FHDJBEIILKP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x64E4500", Offset = "0x64E2D00", VA = "0x1864E4500", Slot = "10")]
	public GameObject NPHAMFMDKPP(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24F74C0", Offset = "0x24F5CC0", VA = "0x1824F74C0", Slot = "11")]
	public T NPHAMFMDKPP<T>(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24F7430", Offset = "0x24F5C30", VA = "0x1824F7430", Slot = "12")]
	public T NPHAMFMDKPP<T>(T ONIHIIPCKEF, Transform FAAJOMIIHED, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24F7510", Offset = "0x24F5D10", VA = "0x1824F7510")]
	private T NPHAMFMDKPP<T>(GameObject ONIHIIPCKEF, Transform FAAJOMIIHED, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP, out GameObject HFCHBJMPMCC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24F6ED0", Offset = "0x24F56D0", VA = "0x1824F6ED0")]
	private T MFOLCILFBCJ<T>(GameObject IMPKIJJJHKI, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64E4200", Offset = "0x64E2A00", VA = "0x1864E4200")]
	private void KGMBBJEMCDH(Component DMKJFEIEPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64E3CB0", Offset = "0x64E24B0", VA = "0x1864E3CB0")]
	private void IFDCAIALBLI(Component DMKJFEIEPGB, OPBAIAGNNPL NDEGHHCMGIN, bool FHDJBEIILKP, bool ILEBDIGMDHG, [Optional] Type EFIGNJFKKKK, [Optional] Type KEEPPOKNBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64E3A00", Offset = "0x64E2200", VA = "0x1864E3A00")]
	private void DCDNPPJMPOM(GameObject IMPKIJJJHKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OPBAIAGNNPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> KJCCKOBFEEH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x228F940", Offset = "0x228E140", VA = "0x18228F940")]
	public OPBAIAGNNPL BJPKOCBPDKP<T>(T LNHJOJGBPLK)
	{
		return default(OPBAIAGNNPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2290810", Offset = "0x228F010", VA = "0x182290810")]
	public T HEJAGBNBHFE<T>(T CMEPDMFEMEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2290070", Offset = "0x228E870", VA = "0x182290070")]
	public bool GKBJHBOCHEL<T>(out T LNHJOJGBPLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IMILPGLPKAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool HMDALHFAOFF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xE85CD0", Offset = "0xE844D0", VA = "0x180E85CD0")]
	public IMILPGLPKAH(bool MGKJAJPBODO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ALFJHIIKMFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool MDLBAAKLENN;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x64DE970", Offset = "0x64DD170", VA = "0x1864DE970")]
	public ALFJHIIKMFO(bool GEFFHELJBDP)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, JCAALMJKMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x64E5870", Offset = "0x64E4070", VA = "0x1864E5870", Slot = "4")]
		public void PrepareImposter(OPBAIAGNNPL NDEGHHCMGIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
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
				[Cpp2IlInjected.Address(RVA = "0x64E39E0", Offset = "0x64E21E0", VA = "0x1864E39E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x64E39D0", Offset = "0x64E21D0", VA = "0x1864E39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64E3570", Offset = "0x64E1D70", VA = "0x1864E3570")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DIOFACKDFCA
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> ANEHCCEMGFB;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 FMFLCFJIDAC;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 NDOHNFLHPMO;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera CBLGKEGINKL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string GBABCAHEDDJ = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const HOPDFIGHLKE CNPNBAAAKII = HOPDFIGHLKE.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> AAFIDCAFICD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode JCFNAHPKAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color OOIFPJHNKPB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color OALBHEJKPNK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color MLEFKHENNCK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap IFJJGOIHJJB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool NIPNNJMNFJP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera JAAAKNPPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x64E1150", Offset = "0x64DF950", VA = "0x1864E1150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x64DFF20", Offset = "0x64DE720", VA = "0x1864DFF20")]
	public static void FCBFINFKIGA(Vector3 BHBDNOPKIAB, Quaternion HPMMFJMDLKI, ImposterRenderConfig NIMKOJOPENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x64E0E40", Offset = "0x64DF640", VA = "0x1864E0E40")]
	private static void KFAABBMGIBM(Vector3 BHBDNOPKIAB, Quaternion HPMMFJMDLKI, URPLight IKLKGLFDFEL, ImposterRenderConfig.LightConfig KDNLJCIECID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x64DFC90", Offset = "0x64DE490", VA = "0x1864DFC90")]
	public static void EIFFGGJMCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x64E15B0", Offset = "0x64DFDB0", VA = "0x1864E15B0")]
	private static void OABBDFNAHMA(int AJOFCENAMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x64E09F0", Offset = "0x64DF1F0", VA = "0x1864E09F0")]
	public static void IEBAGCPDLGG(ImposterRenderConfig NIMKOJOPENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x64DF9C0", Offset = "0x64DE1C0", VA = "0x1864DF9C0")]
	public static void ACGBEMOBEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x64DFAC0", Offset = "0x64DE2C0", VA = "0x1864DFAC0")]
	public static void EHJHAJNNADN(GameObject FPJNGPAFAGL, RenderTexture KFPIPKEMGLA, ImposterRenderConfig NIMKOJOPENB, BLFJFIMGFOC ABAHDNCGAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x64E01A0", Offset = "0x64DE9A0", VA = "0x1864E01A0")]
	private static void FOCAKGEKENL(GameObject FPJNGPAFAGL, RenderTexture KFPIPKEMGLA, ImposterRenderConfig NIMKOJOPENB, BLFJFIMGFOC ABAHDNCGAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x64E06A0", Offset = "0x64DEEA0", VA = "0x1864E06A0")]
	private static void GAJONEFHLCE(GameObject FPJNGPAFAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x64DFD80", Offset = "0x64DE580", VA = "0x1864DFD80")]
	public static void EJLDPEDDMID(List<Renderer> JCMJOLBIBAO, List<Material> NKLNMDAFMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x64E0B70", Offset = "0x64DF370", VA = "0x1864E0B70")]
	public static void KEIKGMBHABE(GameObject ONIHIIPCKEF, Vector3 NBIENNFKIPC, Vector3 KGLLNOANOON, float NPOOFMAAMII, BLFJFIMGFOC ABAHDNCGAGL, out Vector3 AEINEGBPHEC, out Quaternion HDDCGGGNACD, out float IECOMPANMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x64E0950", Offset = "0x64DF150", VA = "0x1864E0950")]
	public static RenderTexture GHNMFLLKMEJ(int HOAILLMFABM, int APOJLADNFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x64E1380", Offset = "0x64DFB80", VA = "0x1864E1380")]
	public static void MDIDOEOBEFD()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct LDHHOGLAFJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public MAMJDBJDFAF FBDJHBDHDEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject AOJEIIHBAGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture GMOIFKAFAEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig OKCDEEDHOJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public BLFJFIMGFOC BLFJFIMGFOC;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x64E3960", Offset = "0x64E2160", VA = "0x1864E3960")]
			public LDHHOGLAFJC(MAMJDBJDFAF JKEFCKLOCOL, GameObject DADMLMFLAMA, RenderTexture KFPIPKEMGLA, ImposterRenderConfig EIMAEFJILGH, BLFJFIMGFOC ABAHDNCGAGL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::CHLFPNDBOOG<LDHHOGLAFJC, RenderTexture> NENICHGKAHD;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<LDHHOGLAFJC> EMNJDHNBGHJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int OAMCHMHIHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x64E1E90", Offset = "0x64E0690", VA = "0x1864E1E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64E1FA0", Offset = "0x64E07A0", VA = "0x1864E1FA0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FPJNGPAFAGL, RenderTexture KFPIPKEMGLA, ImposterRenderConfig NIMKOJOPENB, BLFJFIMGFOC ABAHDNCGAGL, CancellationToken DIEJHKIAFPL, bool HFADAAJEKKH = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x64E1AD0", Offset = "0x64E02D0", VA = "0x1864E1AD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x64E1F00", Offset = "0x64E0700", VA = "0x1864E1F00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x64E1CC0", Offset = "0x64E04C0", VA = "0x1864E1CC0")]
		private static Task<RenderTexture> FAKNPKDJEGB(LDHHOGLAFJC KAMJJDLFKMC, CancellationToken DIEJHKIAFPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64E2390", Offset = "0x64E0B90", VA = "0x1864E2390")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x64E5590", Offset = "0x64E3D90", VA = "0x1864E5590")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x64E5240", Offset = "0x64E3A40", VA = "0x1864E5240")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
