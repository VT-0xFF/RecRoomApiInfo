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
	private readonly struct MJOPBHCNEOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly PAKCKBJHBKI COPGPLCFFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string GABNJEJFCJO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x835CA0", Offset = "0x8348A0", VA = "0x180835CA0")]
		public MJOPBHCNEOD(PAKCKBJHBKI GAPJFNICHLM, string ECILOFOHNLJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct CLMLAMDHOBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public MJOPBHCNEOD queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AED0", Offset = "0x5E19AD0", VA = "0x185E1AED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B270", Offset = "0x5E19E70", VA = "0x185E1B270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider AJBKMBDMEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FPEKHKNBNHH<MJOPBHCNEOD, GameObject> OHLKBEDNKLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AMCHNDLFGIG PPNGAAICNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FPEKHKNBNHH<MJOPBHCNEOD, GameObject> IMCJGHALLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D450", Offset = "0x5E1C050", VA = "0x185E1D450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BEKABLNHJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D790", Offset = "0x5E1C390", VA = "0x185E1D790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D5B0", Offset = "0x5E1C1B0", VA = "0x185E1D5B0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D9C0", Offset = "0x5E1C5C0", VA = "0x185E1D9C0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D670", Offset = "0x5E1C270", VA = "0x185E1D670")]
	[AsyncStateMachine(typeof(CLMLAMDHOBC))]
	private Task<GameObject> ECIFKNJNNMD(MJOPBHCNEOD MBLFKBDAKCD, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D7E0", Offset = "0x5E1C3E0", VA = "0x185E1D7E0")]
	public Task<GameObject> LoadItemAsync(PAKCKBJHBKI GAPJFNICHLM, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DA30", Offset = "0x5E1C630", VA = "0x185E1DA30")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CCOIDACGEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PAKCKBJHBKI GIOHMBMLCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HJCPBLKHPHB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
		public CCOIDACGEDO(PAKCKBJHBKI IJAFDGIPFBO, Texture IOEECDIDCEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum EDMHANNJMNJ
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
	private class IIECJCBFCFH : CFFLLKAPPEH<Texture>, IDOFDFPIDEF, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct CNGJBNAOGFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public IIECJCBFCFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E1B2E0", Offset = "0x5E19EE0", VA = "0x185E1B2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5E1BAF0", Offset = "0x5E1A6F0", VA = "0x185E1BAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly PAKCKBJHBKI IJAFDGIPFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture MLJGDIBLHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig MOBDONOGAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken BJFJMBIBKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject EBKHPBFMAKI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HPJLJGHAIKN<Texture> DGHEKEOJAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E1DBA0", Offset = "0x5E1C7A0", VA = "0x185E1DBA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> DABJJELJNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DD00", Offset = "0x5E1C900", VA = "0x185E1DD00")]
		public IIECJCBFCFH(PAKCKBJHBKI IJAFDGIPFBO, RenderTexture MLJGDIBLHMK, ImposterRenderConfig MOBDONOGAKK, CancellationToken BJFJMBIBKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DC10", Offset = "0x5E1C810", VA = "0x185E1DC10")]
		[AsyncStateMachine(typeof(CNGJBNAOGFI))]
		private Task<Texture> JDEEFBCLCJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DC00", Offset = "0x5E1C800", VA = "0x185E1DC00", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DB20", Offset = "0x5E1C720", VA = "0x185E1DB20")]
		private static void CCJFBPPKDBD(GameObject EBKHPBFMAKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OOIGPJFMLCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E21520", Offset = "0x5E20120", VA = "0x185E21520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0C0", Offset = "0x7E9CC0", VA = "0x1807EB0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[AJIIAMJDEPI(GNDHFGBAEMN.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private EDMHANNJMNJ size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[BPCBMHBAJGE("size", EDMHANNJMNJ.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
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

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int BNACNMKLOIO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture HINPGMBCCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LGFEAMBGKDI<GameObject> NCNOFOENDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PABKPJDFADP IMECOOJMBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OEDMIHFDIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private CFFLLKAPPEH<Texture> OCJBLHBKNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private PAKCKBJHBKI JKBIBFJKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DIGCHDFKBII;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int ENLIEMBDAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EDD0", Offset = "0x5E1D9D0", VA = "0x185E1EDD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EE20", Offset = "0x5E1DA20", VA = "0x185E1EE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture ANHNFPKPGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E510", Offset = "0x5E1D110", VA = "0x185E1E510")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7733D0", Offset = "0x771FD0", VA = "0x1807733D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private PAKCKBJHBKI GIOHMBMLCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x776540", Offset = "0x775140", VA = "0x180776540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E6C0", Offset = "0x5E1D2C0", VA = "0x185E1E6C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool EJLAIAOECOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4FE5AC0", Offset = "0x4FE46C0", VA = "0x184FE5AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int HMMAONFKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E900", Offset = "0x5E1D500", VA = "0x185E1E900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E3C0", Offset = "0x5E1CFC0", VA = "0x185E1E3C0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E9A0", Offset = "0x5E1D5A0", VA = "0x185E1E9A0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E3D0", Offset = "0x5E1CFD0", VA = "0x185E1E3D0")]
	private void BEBPLAGLECF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ECF0", Offset = "0x5E1D8F0", VA = "0x185E1ECF0")]
	public void Set(PAKCKBJHBKI MIGJJNKBEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ECE0", Offset = "0x5E1D8E0", VA = "0x185E1ECE0")]
	public void Set(Texture IOEECDIDCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ECA0", Offset = "0x5E1D8A0", VA = "0x185E1ECA0")]
	public void Set(CCOIDACGEDO GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E450", Offset = "0x5E1D050", VA = "0x185E1E450")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EAA0", Offset = "0x5E1D6A0", VA = "0x185E1EAA0")]
	public void SetInternal(PAKCKBJHBKI MIGJJNKBEFL, [Optional] Texture MKJFJBMMAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EA90", Offset = "0x5E1D690", VA = "0x185E1EA90")]
	public void SetCustomSize(int HOGIMGMPAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7733E0", Offset = "0x771FE0", VA = "0x1807733E0")]
	public void SetAntiAliasing(int EGPNBKNBNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E460", Offset = "0x5E1D060", VA = "0x185E1E460")]
	[AsyncStateMachine(typeof(OOIGPJFMLCK))]
	private void GCPPMJGACOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E820", Offset = "0x5E1D420", VA = "0x185E1E820")]
	private void NIMLMLDKIOC(Texture IOEECDIDCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ED50", Offset = "0x5E1D950", VA = "0x185E1ED50")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, DJKAPHDFGDA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float CFHMODIFEED = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
	public void PrepareImposter(KHBIICHDBHK OCFPIAIMFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E380", Offset = "0x5E1CF80", VA = "0x185E1E380")]
	public void SetReferencePoint(Vector3 MNANBFFJBMF, Quaternion HFJOJGBHICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E180", Offset = "0x5E1CD80", VA = "0x185E1E180")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E360", Offset = "0x5E1CF60", VA = "0x185E1E360")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x136DE50", Offset = "0x136CA50", VA = "0x18136DE50")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HKGDMFBOKPK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static HKGDMFBOKPK BAPHKHIAJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float CICFDLGENKC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2022260", Offset = "0x2020E60", VA = "0x182022260")]
	public HKGDMFBOKPK(float POBALGNMNOP)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[AJIIAMJDEPI(GNDHFGBAEMN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int KCFMNJMCLON = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int LMDFDAJMCAF = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> IGMIOMIDLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool LFMAKKBMNHF;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F000", Offset = "0x5E1DC00", VA = "0x185E1F000")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EF00", Offset = "0x5E1DB00", VA = "0x185E1EF00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F240", Offset = "0x5E1DE40", VA = "0x185E1F240")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PAKCKBJHBKI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string EDPAJNIAGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HKGDMFBOKPK HKGDMFBOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HHPEIEGMHJK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> OFFKABACNAN(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFMAFLELDPI(PAKCKBJHBKI LLMHBOEDHFP);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNLEPPJJEAI();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIJCEOMHLPI();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HFOEAECEOFL([Out] CFFLLKAPPEH<Texture> ECCJBLHJHFH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KJFDFOIOOGG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F2D0", Offset = "0x5E1DED0", VA = "0x185E1F2D0")]
	public static bool HGKPFECKHNH(PAKCKBJHBKI OAGANLAIPOD, PAKCKBJHBKI BMNIOFOBLHP)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, DJKAPHDFGDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BB60", Offset = "0x5E1A760", VA = "0x185E1BB60", Slot = "4")]
		public void PrepareImposter(KHBIICHDBHK OCFPIAIMFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DJKAPHDFGDA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(KHBIICHDBHK OCFPIAIMFIA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NKEDEHMOBNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> HAGPCPOBLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GAHOOAFFAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AMCHNDLFGIG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject EACGPBKOIPA(GameObject NMGALPBKFJN, Transform HHNAEDAPOHF, bool FGGKAHCAIFM = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T EACGPBKOIPA<T>(T NMGALPBKFJN, Transform HHNAEDAPOHF, bool FGGKAHCAIFM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T EACGPBKOIPA<T>(GameObject NMGALPBKFJN, Transform HHNAEDAPOHF, bool FGGKAHCAIFM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject EACGPBKOIPA(GameObject NMGALPBKFJN, Transform HHNAEDAPOHF, KHBIICHDBHK OCFPIAIMFIA, bool FGGKAHCAIFM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DIIBPANCAFM : IDisposable, AMCHNDLFGIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> NLPLGNJPAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> PEANEENOIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform JMKHHENJHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> EJNIJHAHPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> GIODOAGKHNA;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C610", Offset = "0x5E1B210", VA = "0x185E1C610")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	public static void JKFPJJDDAIM(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C710", Offset = "0x5E1B310", VA = "0x185E1C710")]
	[Preserve]
	public DIIBPANCAFM([DLBAGNNJKKK(null)] NKEDEHMOBNJ LLACFKAAGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BDC0", Offset = "0x5E1A9C0", VA = "0x185E1BDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BEA0", Offset = "0x5E1AAA0", VA = "0x185E1BEA0", Slot = "5")]
	public GameObject EACGPBKOIPA(GameObject NMGALPBKFJN, Transform HHNAEDAPOHF, bool FGGKAHCAIFM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2386050", Offset = "0x2384C50", VA = "0x182386050", Slot = "6")]
	public T EACGPBKOIPA<T>(T NMGALPBKFJN, Transform HHNAEDAPOHF, bool FGGKAHCAIFM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2385FE0", Offset = "0x2384BE0", VA = "0x182385FE0", Slot = "7")]
	public T EACGPBKOIPA<T>(GameObject NMGALPBKFJN, Transform HHNAEDAPOHF, bool FGGKAHCAIFM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BF30", Offset = "0x5E1AB30", VA = "0x185E1BF30", Slot = "8")]
	public GameObject EACGPBKOIPA(GameObject NMGALPBKFJN, Transform HHNAEDAPOHF, KHBIICHDBHK OCFPIAIMFIA, bool FGGKAHCAIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2386010", Offset = "0x2384C10", VA = "0x182386010", Slot = "9")]
	public T EACGPBKOIPA<T>(GameObject NMGALPBKFJN, Transform HHNAEDAPOHF, KHBIICHDBHK OCFPIAIMFIA, bool FGGKAHCAIFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x23860C0", Offset = "0x2384CC0", VA = "0x1823860C0")]
	private T EACGPBKOIPA<T>(GameObject NMGALPBKFJN, Transform HHNAEDAPOHF, KHBIICHDBHK OCFPIAIMFIA, bool FGGKAHCAIFM, [Out] GameObject KIBAAFFDIKH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2385B40", Offset = "0x2384740", VA = "0x182385B40")]
	private T DPGDPPMNCFK<T>(GameObject LCHNDEILNAI, KHBIICHDBHK OCFPIAIMFIA, bool FGGKAHCAIFM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BCB0", Offset = "0x5E1A8B0", VA = "0x185E1BCB0")]
	private void BAKNNEIPMMN(Component FNLDGAFEDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BFC0", Offset = "0x5E1ABC0", VA = "0x185E1BFC0")]
	private void GFGBMAHNLMH(Component FNLDGAFEDDH, KHBIICHDBHK OCFPIAIMFIA, bool FGGKAHCAIFM, bool IBADAMAAACC, [Optional] Type GFNMNNCBFPK, [Optional] Type DPBCBBLBDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C4A0", Offset = "0x5E1B0A0", VA = "0x185E1C4A0")]
	private void INEIFHJICBA(GameObject LCHNDEILNAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KHBIICHDBHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> FFBEPLLBHND;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x256D0B0", Offset = "0x256BCB0", VA = "0x18256D0B0")]
	public KHBIICHDBHK INLCAGHFLDH<T>(T FNBINLAHGOC)
	{
		return default(KHBIICHDBHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x256D7E0", Offset = "0x256C3E0", VA = "0x18256D7E0")]
	public T IOOJPMIEEDI<T>(T MLNCHKABKBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x256C8E0", Offset = "0x256B4E0", VA = "0x18256C8E0")]
	public bool ELLDKPBLMHI<T>([Out] T FNBINLAHGOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BNDIGAEDIHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool GICFCAHKJGM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xBBFA70", Offset = "0xBBE670", VA = "0x180BBFA70")]
	public BNDIGAEDIHO(bool OJFLAMFKJGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct APNMNEGDHJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool CCDJHIAGFDM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AEC0", Offset = "0x5E19AC0", VA = "0x185E1AEC0")]
	public APNMNEGDHJA(bool KAOJFJIIOKA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, DJKAPHDFGDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E21CC0", Offset = "0x5E208C0", VA = "0x185E21CC0", Slot = "4")]
		public void PrepareImposter(KHBIICHDBHK OCFPIAIMFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds IGBJIPKJLMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5E1DFF0", Offset = "0x5E1CBF0", VA = "0x185E1DFF0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DFB0", Offset = "0x5E1CBB0", VA = "0x185E1DFB0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DF70", Offset = "0x5E1CB70", VA = "0x185E1DF70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DE80", Offset = "0x5E1CA80", VA = "0x185E1DE80")]
		private void MBOJDIKEEHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5E21500", Offset = "0x5E20100", VA = "0x185E21500")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5E214F0", Offset = "0x5E200F0", VA = "0x185E214F0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EEA0", Offset = "0x5E1DAA0", VA = "0x185E1EEA0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LOFJBLPJDDP
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> KHPNONFCHNK;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 AKFFMBNPBDF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 LDMAEJIJBNE;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera PDIHMOEEAKP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> IPKGKAKCPIJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> FKMODDAGJEP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode AODHJMEHNNA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color NDAGLHPKAAN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color BGCMCMMJHJE;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color OBNKDNKMCCI;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap BIHPFBJEKPH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool FKJDGCIHOMC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera JBHCNGFKDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E20AA0", Offset = "0x5E1F6A0", VA = "0x185E20AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5E21090", Offset = "0x5E1FC90", VA = "0x185E21090")]
	public static void PNHLOCFIPPK(Vector3 DDHJCPKNNAL, Quaternion IINFKAKBMJM, ImposterRenderConfig DPGKCFHPMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E20D60", Offset = "0x5E1F960", VA = "0x185E20D60")]
	private static void OIFAHAKEOLH(Vector3 DDHJCPKNNAL, Quaternion IINFKAKBMJM, URPLight HPLAKENDGOB, ImposterRenderConfig.LightConfig GBAIKLDGFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FE10", Offset = "0x5E1EA10", VA = "0x185E1FE10")]
	public static void IJEEMPJOLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F3C0", Offset = "0x5E1DFC0", VA = "0x185E1F3C0")]
	private static void ADPFEKDNNOL(int KNMAFHDEILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E200C0", Offset = "0x5E1ECC0", VA = "0x185E200C0")]
	public static void KIBJBNMIDCM(ImposterRenderConfig DPGKCFHPMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FD20", Offset = "0x5E1E920", VA = "0x185E1FD20")]
	public static void HJBPFCBGKPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FEF0", Offset = "0x5E1EAF0", VA = "0x185E1FEF0")]
	public static void IMIGOAJIPNI(GameObject MIHIDOJKOKG, RenderTexture MLJGDIBLHMK, ImposterRenderConfig DPGKCFHPMPF, HKGDMFBOKPK CGPHIKFGIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F740", Offset = "0x5E1E340", VA = "0x185E1F740")]
	private static void DIMGLEAHELK(GameObject MIHIDOJKOKG, RenderTexture MLJGDIBLHMK, ImposterRenderConfig DPGKCFHPMPF, HKGDMFBOKPK CGPHIKFGIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E20280", Offset = "0x5E1EE80", VA = "0x185E20280")]
	private static void LKIBCKDCKKB(GameObject MIHIDOJKOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E20520", Offset = "0x5E1F120", VA = "0x185E20520")]
	public static void NFBGDMLFNJE(GameObject NMGALPBKFJN, Vector3 IEHEEICOPHO, Vector3 PMAGCHEFBPE, float ALFHGKDHMNI, HKGDMFBOKPK CGPHIKFGIPE, [Out] Vector3 AGHPECGEIEM, [Out] Quaternion NEMKHDEFGKG, [Out] float CAPCCHHPKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E20CB0", Offset = "0x5E1F8B0", VA = "0x185E20CB0")]
	public static RenderTexture OIEMLGGIKKA(int JKPMEJIBHBK, int ANJHOEIDHKI, RenderTextureFormat CCDBHMCDPAB = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct EANFHEBFEKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public EEHJIENCILF BIEOCHKCNBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject MECAMPIGAJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture ANHNFPKPGNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig DIILMLFFNHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public HKGDMFBOKPK HKGDMFBOKPK;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E1DA70", Offset = "0x5E1C670", VA = "0x185E1DA70")]
			public EANFHEBFEKD(EEHJIENCILF IFLPCIJGAMI, GameObject MCEHPKADOBF, RenderTexture MLJGDIBLHMK, ImposterRenderConfig MOBDONOGAKK, HKGDMFBOKPK CGPHIKFGIPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static FPEKHKNBNHH<EANFHEBFEKD, RenderTexture> AAKLMBKAPDN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<EANFHEBFEKD> DKPLECHLNAH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int HPJDBLDNPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E1CD40", Offset = "0x5E1B940", VA = "0x185E1CD40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CFF0", Offset = "0x5E1BBF0", VA = "0x185E1CFF0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MIHIDOJKOKG, RenderTexture MLJGDIBLHMK, ImposterRenderConfig DPGKCFHPMPF, HKGDMFBOKPK CGPHIKFGIPE, CancellationToken BJFJMBIBKLL, bool APPEPCDKLIA = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CB50", Offset = "0x5E1B750", VA = "0x185E1CB50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CF50", Offset = "0x5E1BB50", VA = "0x185E1CF50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1CDB0", Offset = "0x5E1B9B0", VA = "0x185E1CDB0")]
		private static Task<RenderTexture> JEOAMIIPFAK(EANFHEBFEKD GCHCBFHDMJD, CancellationToken BJFJMBIBKLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D410", Offset = "0x5E1C010", VA = "0x185E1D410")]
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
