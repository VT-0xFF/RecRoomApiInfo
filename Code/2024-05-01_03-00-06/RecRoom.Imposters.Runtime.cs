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
	private readonly struct FHBCMNNMNDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ALBKIFDAOKG IIOLCKGPNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string EMIKMDCGJCD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
		public FHBCMNNMNDF(ALBKIFDAOKG FMJNAKFBFLI, string JNOKBJHHDMH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct GADHFHPBOCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public FHBCMNNMNDF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6233F80", Offset = "0x6232D80", VA = "0x186233F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6234320", Offset = "0x6233120", VA = "0x186234320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider IDFBEGOPCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HOBPGBBGIDA<FHBCMNNMNDF, GameObject> EGGBNJEEIFF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NMAEMPJIFPH FKFFDMBKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private HOBPGBBGIDA<FHBCMNNMNDF, GameObject> DBOICOMJKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6233A40", Offset = "0x6232840", VA = "0x186233A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int PMLAPDBDGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6233E80", Offset = "0x6232C80", VA = "0x186233E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6233980", Offset = "0x6232780", VA = "0x186233980", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6233ED0", Offset = "0x6232CD0", VA = "0x186233ED0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6233BA0", Offset = "0x62329A0", VA = "0x186233BA0")]
	[AsyncStateMachine(typeof(GADHFHPBOCA))]
	private Task<GameObject> FOFOPMLHFKP(FHBCMNNMNDF OMJLDMOHKOA, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6233CC0", Offset = "0x6232AC0", VA = "0x186233CC0")]
	public Task<GameObject> LoadItemAsync(ALBKIFDAOKG FMJNAKFBFLI, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6233F40", Offset = "0x6232D40", VA = "0x186233F40")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HAAHEBKOGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ALBKIFDAOKG PEHKPNJKGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DNDJJLLJBBJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
		public HAAHEBKOGOF(ALBKIFDAOKG PKCKHNCCHNA, Texture AOHFCHDJECC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HHEBKDPBPDF
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
	private class PKIKKDPHHFI : ICKOEGBDKCH<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct CBNOHEOGJNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public PKIKKDPHHFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6232660", Offset = "0x6231460", VA = "0x186232660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6232E60", Offset = "0x6231C60", VA = "0x186232E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ALBKIFDAOKG PKCKHNCCHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture OPKFGOJDBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig JPEMBDAMHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken KANPDHELHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject OIMPFKBAJOC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NPCIDDLFILB<Texture> JEOFKHDOBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6239600", Offset = "0x6238400", VA = "0x186239600", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> ENAMDLEEABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x62397E0", Offset = "0x62385E0", VA = "0x1862397E0")]
		public PKIKKDPHHFI(ALBKIFDAOKG PKCKHNCCHNA, RenderTexture OPKFGOJDBOJ, ImposterRenderConfig JPEMBDAMHAD, CancellationToken KANPDHELHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x62396E0", Offset = "0x62384E0", VA = "0x1862396E0")]
		[AsyncStateMachine(typeof(CBNOHEOGJNL))]
		private Task<Texture> NBPIGLIJBJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62397D0", Offset = "0x62385D0", VA = "0x1862397D0", Slot = "10")]
		protected override void PBMNEGEAJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6239660", Offset = "0x6238460", VA = "0x186239660")]
		private static void MPIIHPDNHGN(GameObject OIMPFKBAJOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KDDIHOJCJMP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6238D10", Offset = "0x6237B10", VA = "0x186238D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x898D70", Offset = "0x897B70", VA = "0x180898D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[FHFEFOGEDAO(KLKJAELFHOF.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private HHEBKDPBPDF size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[ICONPNPMJHG("size", HHEBKDPBPDF.Custom)]
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
	private static int PEPOKHIGGLN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture PBAMGABLNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NMIADHDDJDA<GameObject> LNBFBMPAEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private EEFNJOFHHBM PEJMBKEIGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource PGKPKKCBGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private BCJOGHANCKE<Texture> JCFCPOOCGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ALBKIFDAOKG LHCLDFOEAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DIBNPNGKPAK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int FFMBLLCLKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6235320", Offset = "0x6234120", VA = "0x186235320")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6235370", Offset = "0x6234170", VA = "0x186235370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture EDFILALCLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6234D50", Offset = "0x6233B50", VA = "0x186234D50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B20D0", Offset = "0x7B0ED0", VA = "0x1807B20D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ALBKIFDAOKG PEHKPNJKGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B7050", Offset = "0x7B5E50", VA = "0x1807B7050")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6234B40", Offset = "0x6233940", VA = "0x186234B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool DAPKKDMDPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x531B8B0", Offset = "0x531A6B0", VA = "0x18531B8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int IKDMGLLIBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6234A30", Offset = "0x6233830", VA = "0x186234A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6234930", Offset = "0x6233730", VA = "0x186234930")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6234F00", Offset = "0x6233D00", VA = "0x186234F00")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6234AC0", Offset = "0x62338C0", VA = "0x186234AC0")]
	private void JEEMCFLCKEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6235200", Offset = "0x6234000", VA = "0x186235200")]
	public void Set(ALBKIFDAOKG IMCOBDEHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62351F0", Offset = "0x6233FF0", VA = "0x1862351F0")]
	public void Set(Texture AOHFCHDJECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6235210", Offset = "0x6234010", VA = "0x186235210")]
	public void Set(HAAHEBKOGOF DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6234A20", Offset = "0x6233820", VA = "0x186234A20")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6235000", Offset = "0x6233E00", VA = "0x186235000")]
	public void SetInternal(ALBKIFDAOKG IMCOBDEHDJH, [Optional] Texture KPEBPODLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6234FF0", Offset = "0x6233DF0", VA = "0x186234FF0")]
	public void SetCustomSize(int PGPBFHIKCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B20C0", Offset = "0x7B0EC0", VA = "0x1807B20C0")]
	public void SetAntiAliasing(int NMEJJHOLKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6234CA0", Offset = "0x6233AA0", VA = "0x186234CA0")]
	[AsyncStateMachine(typeof(KDDIHOJCJMP))]
	private void NDKKCNNOHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6234940", Offset = "0x6233740", VA = "0x186234940")]
	private void BPPCBPMGCNJ(Texture AOHFCHDJECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62352A0", Offset = "0x62340A0", VA = "0x1862352A0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, CNMFJBBKLJI
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float FOBNKNOAKGN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
	public void PrepareImposter(JIAKOHPMKMP AHMCCAODOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62348F0", Offset = "0x62336F0", VA = "0x1862348F0")]
	public void SetReferencePoint(Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6234700", Offset = "0x6233500", VA = "0x186234700")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62348D0", Offset = "0x62336D0", VA = "0x1862348D0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1496480", Offset = "0x1495280", VA = "0x181496480")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DOFKPDOPNHP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static DOFKPDOPNHP CGODALNPFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float EJIJGDEFJJC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFFE0", Offset = "0x1FCEDE0", VA = "0x181FCFFE0")]
	public DOFKPDOPNHP(float PNHMGOCGBAA)
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
		[FHFEFOGEDAO(KLKJAELFHOF.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int JIHPMONNDCI = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int HJEHGHKCLMO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> FDCBEAIMDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool JEGHCBJEGOF;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6235570", Offset = "0x6234370", VA = "0x186235570")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6235470", Offset = "0x6234270", VA = "0x186235470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x62357C0", Offset = "0x62345C0", VA = "0x1862357C0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ALBKIFDAOKG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string NALKEONEDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DOFKPDOPNHP DOFKPDOPNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GFOBDIPLOLC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> APBJLCNKLKB(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJDGKHLDJLL(ALBKIFDAOKG GGINNHLAMLI);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FBOPCFCFHEO();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void APEJKECNKAO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AKGJBJOLJLE([Out] BCJOGHANCKE<Texture> GGBFBEDDHIH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MHBOLKIPLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6239510", Offset = "0x6238310", VA = "0x186239510")]
	public static bool CFKMMFHAMOG(ALBKIFDAOKG OBDKNPFLAGI, ALBKIFDAOKG KPIEGDMDBNC)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, CNMFJBBKLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6232ED0", Offset = "0x6231CD0", VA = "0x186232ED0", Slot = "4")]
		public void PrepareImposter(JIAKOHPMKMP AHMCCAODOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CNMFJBBKLJI
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(JIAKOHPMKMP AHMCCAODOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IKCMHEJCLLI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> MIDPFFDLLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> FAHPBNHLDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NMAEMPJIFPH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPDHDBBIJJB(params Type[] CHDGAFJKNGH);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PNBKEIKGELH(GameObject IHFDHAEOMFG, Transform OGCHMLDLLMJ, bool GOHLCIINCPC = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PNBKEIKGELH<T>(T IHFDHAEOMFG, Transform OGCHMLDLLMJ, bool GOHLCIINCPC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PNBKEIKGELH<T>(GameObject IHFDHAEOMFG, Transform OGCHMLDLLMJ, bool GOHLCIINCPC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject PNBKEIKGELH(GameObject IHFDHAEOMFG, Transform OGCHMLDLLMJ, JIAKOHPMKMP AHMCCAODOOJ, bool GOHLCIINCPC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JHLKEKALNLG : IDisposable, NMAEMPJIFPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> EAFPJIPPNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> OALBNBKHIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform HGPDMGEKJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> JALLODJOBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> EOOJGFENNGP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6235F50", Offset = "0x6234D50", VA = "0x186235F50")]
	[DPHBJKOLDBD(OHNOEEJKPCM.None)]
	public static void NHIOCKBFPIL(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x62362D0", Offset = "0x62350D0", VA = "0x1862362D0")]
	[Preserve]
	public JHLKEKALNLG([PENMPEOFMMN(null)] IKCMHEJCLLI EFMOCICMPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6235E20", Offset = "0x6234C20", VA = "0x186235E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6235F00", Offset = "0x6234D00", VA = "0x186235F00", Slot = "5")]
	public void EPDHDBBIJJB(params Type[] CHDGAFJKNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6236240", Offset = "0x6235040", VA = "0x186236240", Slot = "6")]
	public GameObject PNBKEIKGELH(GameObject IHFDHAEOMFG, Transform OGCHMLDLLMJ, bool GOHLCIINCPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x292E3D0", Offset = "0x292D1D0", VA = "0x18292E3D0", Slot = "7")]
	public T PNBKEIKGELH<T>(T IHFDHAEOMFG, Transform OGCHMLDLLMJ, bool GOHLCIINCPC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x292E440", Offset = "0x292D240", VA = "0x18292E440", Slot = "8")]
	public T PNBKEIKGELH<T>(GameObject IHFDHAEOMFG, Transform OGCHMLDLLMJ, bool GOHLCIINCPC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62361B0", Offset = "0x6234FB0", VA = "0x1862361B0", Slot = "9")]
	public GameObject PNBKEIKGELH(GameObject IHFDHAEOMFG, Transform OGCHMLDLLMJ, JIAKOHPMKMP AHMCCAODOOJ, bool GOHLCIINCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x292E470", Offset = "0x292D270", VA = "0x18292E470", Slot = "10")]
	public T PNBKEIKGELH<T>(GameObject IHFDHAEOMFG, Transform OGCHMLDLLMJ, JIAKOHPMKMP AHMCCAODOOJ, bool GOHLCIINCPC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x292E4B0", Offset = "0x292D2B0", VA = "0x18292E4B0")]
	private T PNBKEIKGELH<T>(GameObject IHFDHAEOMFG, Transform OGCHMLDLLMJ, JIAKOHPMKMP AHMCCAODOOJ, bool GOHLCIINCPC, [Out] GameObject OHNLLGBPCBP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x292DF30", Offset = "0x292CD30", VA = "0x18292DF30")]
	private T OHGGMEIMBDH<T>(GameObject EBIGFKEAJMH, JIAKOHPMKMP AHMCCAODOOJ, bool GOHLCIINCPC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6235D10", Offset = "0x6234B10", VA = "0x186235D10")]
	private void BDKGCICFJGO(Component FFDKILKJFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6235850", Offset = "0x6234650", VA = "0x186235850")]
	private void ANPPKEMNCDN(Component FFDKILKJFCC, JIAKOHPMKMP AHMCCAODOOJ, bool GOHLCIINCPC, bool HCJOGIJPICK, [Optional] Type HCBGPIMGPNA, [Optional] Type OACJOKINMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6236040", Offset = "0x6234E40", VA = "0x186236040")]
	private void NLONLJBLNOF(GameObject EBIGFKEAJMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JIAKOHPMKMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> AHHJFMGIEOD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x292F300", Offset = "0x292E100", VA = "0x18292F300")]
	public JIAKOHPMKMP KNPAMBFMNAD<T>(T IFMGJDMPKDO)
	{
		return default(JIAKOHPMKMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x292EA10", Offset = "0x292D810", VA = "0x18292EA10")]
	public T DJGCEJBDGHO<T>(T OPPINNBBHIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x292EB20", Offset = "0x292D920", VA = "0x18292EB20")]
	public bool HIBEGIGNEIP<T>([Out] T IFMGJDMPKDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FFAIEIDFABB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool FMIALOFAAFH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCAAFD0", Offset = "0xCA9DD0", VA = "0x180CAAFD0")]
	public FFAIEIDFABB(bool ENFODHGLNBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OFODFDBIECJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool AAGABOJKBDF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62395F0", Offset = "0x62383F0", VA = "0x1862395F0")]
	public OFODFDBIECJ(bool GNEGDAOGNJD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, CNMFJBBKLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62399A0", Offset = "0x62387A0", VA = "0x1862399A0", Slot = "4")]
		public void PrepareImposter(JIAKOHPMKMP AHMCCAODOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
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
		public Bounds JCDPJGPBLHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6234570", Offset = "0x6233370", VA = "0x186234570")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6234530", Offset = "0x6233330", VA = "0x186234530")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62344F0", Offset = "0x62332F0", VA = "0x1862344F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6234400", Offset = "0x6233200", VA = "0x186234400")]
		private void IJAOKFKALBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
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
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x62394F0", Offset = "0x62382F0", VA = "0x1862394F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x62394E0", Offset = "0x62382E0", VA = "0x1862394E0")]
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
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62353E0", Offset = "0x62341E0", VA = "0x1862353E0")]
		public void BGCGIKNCBBB(Vector3 OBEMCGEALAJ, Quaternion CIIEIHPHJDA, float CCMNAKMGLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6235410", Offset = "0x6234210", VA = "0x186235410")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JMKMMNNMMIM
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 GPDDDCHNHEE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> JNMKFPPOOEE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> JIGGDOHHHGK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera CDENLGJIDCH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> JBAEJODCNBE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> LPDLKHMCEEN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode FENHAGCGBHC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color PPHIBGGFJMF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color PGGJGCAIBOD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color KKMEEKPJDPD;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap EBNNGCHDCNO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool DKNJKPMIAJN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> JMDEABOKIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62377B0", Offset = "0x62365B0", VA = "0x1862377B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> GDDFOIEJHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62378E0", Offset = "0x62366E0", VA = "0x1862378E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera GOFPKIIJFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6236D40", Offset = "0x6235B40", VA = "0x186236D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6237440", Offset = "0x6236240", VA = "0x186237440")]
	public static void HADANHNHLNE(Vector3 PMKNGAHKGDB, Quaternion PLPEGGFEMIP, ImposterRenderConfig EFKLLLGNCFG, bool FAKACJBPKPK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6236F70", Offset = "0x6235D70", VA = "0x186236F70")]
	private static void CKMAFDGNDPF(Vector3 PMKNGAHKGDB, Quaternion PLPEGGFEMIP, URPLight DBFLPJBABHN, ImposterRenderConfig.LightConfig BALDHICPJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6237800", Offset = "0x6236600", VA = "0x186237800")]
	public static void JCALPJFAJOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6238240", Offset = "0x6237040", VA = "0x186238240")]
	private static void LJENMIHIHBO(int IAEDDMJBHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6237290", Offset = "0x6236090", VA = "0x186237290")]
	public static void FGOAJCCGONE(ImposterRenderConfig EFKLLLGNCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62376D0", Offset = "0x62364D0", VA = "0x1862376D0")]
	public static void IHHFELKHMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6238710", Offset = "0x6237510", VA = "0x186238710")]
	public static void OHPMFCFMCHB(GameObject GGELBGGOJEM, RenderTexture OPKFGOJDBOJ, ImposterRenderConfig EFKLLLGNCFG, DOFKPDOPNHP OLINNEGNOCL, [Optional] Vector3? IADCDJDPJAB, [Optional] Vector3? APKKDCFIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6236710", Offset = "0x6235510", VA = "0x186236710")]
	private static void AEAJNAKINAC(GameObject GGELBGGOJEM, RenderTexture OPKFGOJDBOJ, ImposterRenderConfig EFKLLLGNCFG, DOFKPDOPNHP OLINNEGNOCL, Vector3 IADCDJDPJAB, Vector3 APKKDCFIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6237930", Offset = "0x6236730", VA = "0x186237930")]
	private static void JPPMGFPJEKB(GameObject GGELBGGOJEM, Vector3 KFMGIDHEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6237BF0", Offset = "0x62369F0", VA = "0x186237BF0")]
	private static void LBDGFOHLDFJ(GameObject IHFDHAEOMFG, ImposterRenderConfig EFKLLLGNCFG, DOFKPDOPNHP OLINNEGNOCL, [Out] Vector3 GGPNIECOCLD, [Out] Quaternion NLFJBCFIEFB, [Out] float NHCCEJGDCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6238A50", Offset = "0x6237850", VA = "0x186238A50")]
	public static RenderTexture PKFCACEIJMA(int MKALCEDDFGL, int BDEEHMODBBC, RenderTextureFormat FFCCHAGPLED = RenderTextureFormat.ARGB32)
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
		public struct GNIAHMMAKGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public JGKLBIBCBIK KBECFFHKNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject IEBMIOGMKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture EDFILALCLNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig LEJFBCPJDGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public DOFKPDOPNHP DOFKPDOPNHP;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6234390", Offset = "0x6233190", VA = "0x186234390")]
			public GNIAHMMAKGE(JGKLBIBCBIK LMKBOALMHHB, GameObject EMDFMCCNFJJ, RenderTexture OPKFGOJDBOJ, ImposterRenderConfig JPEMBDAMHAD, DOFKPDOPNHP OLINNEGNOCL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static HOBPGBBGIDA<GNIAHMMAKGE, RenderTexture> PHJJDCIBHNA;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<GNIAHMMAKGE> CPOHEAGEPJB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int GNJFJDDDOLL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6233440", Offset = "0x6232240", VA = "0x186233440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6233540", Offset = "0x6232340", VA = "0x186233540")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GGELBGGOJEM, RenderTexture OPKFGOJDBOJ, ImposterRenderConfig EFKLLLGNCFG, DOFKPDOPNHP OLINNEGNOCL, CancellationToken KANPDHELHMD, bool KLPIIOPLLJD = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6233060", Offset = "0x6231E60", VA = "0x186233060", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62334B0", Offset = "0x62322B0", VA = "0x1862334B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6233250", Offset = "0x6232050", VA = "0x186233250")]
		private static Task<RenderTexture> CFBBJNOKDMD(GNIAHMMAKGE PLIDDEPPGMM, CancellationToken KANPDHELHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6233940", Offset = "0x6232740", VA = "0x186233940")]
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
