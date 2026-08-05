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
	private readonly struct NPBEIELPPNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ENLOEBPGGAD CHBNJDBGIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HCNBCPLJCJH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F41F0", Offset = "0x7F29F0", VA = "0x1807F41F0")]
		public NPBEIELPPNP(ENLOEBPGGAD LFDPEMMNOBG, string ALAPAHNONCA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct NJFNDAPGHLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NPBEIELPPNP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CB0950", Offset = "0x5CAF150", VA = "0x185CB0950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CB0CF0", Offset = "0x5CAF4F0", VA = "0x185CB0CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider LEAAFONBAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FAFBNCGOCIM<NPBEIELPPNP, GameObject> CFKINLBIHJO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AMGOBNMEFIO CJGKFBLMMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761300", VA = "0x180762B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FAFBNCGOCIM<NPBEIELPPNP, GameObject> EJIPAIGNFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC5F0", Offset = "0x5CAADF0", VA = "0x185CAC5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int IIFOLCOFACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC750", Offset = "0x5CAAF50", VA = "0x185CAC750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC530", Offset = "0x5CAAD30", VA = "0x185CAC530", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5CACAA0", Offset = "0x5CAB2A0", VA = "0x185CACAA0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC980", Offset = "0x5CAB180", VA = "0x185CAC980")]
	[AsyncStateMachine(typeof(NJFNDAPGHLG))]
	private Task<GameObject> OFIBGDINJKC(NPBEIELPPNP NIAKPMEFLMN, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CAC7A0", Offset = "0x5CAAFA0", VA = "0x185CAC7A0")]
	public Task<GameObject> LoadItemAsync(ENLOEBPGGAD LFDPEMMNOBG, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CACB10", Offset = "0x5CAB310", VA = "0x185CACB10")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PCPDBIOFGPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ENLOEBPGGAD FKCLANOAEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture JDOLAAOIGLN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
		public PCPDBIOFGPP(ENLOEBPGGAD LPDKGNAPENE, Texture PNEGHHIDKPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum IFAILJEMDPI
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
	private class LKFKCDKHPEI : LPPJOFCADCB<Texture>, PEKLKMGJCGE, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct JMFKNAOPNFM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public LKFKCDKHPEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CAFCC0", Offset = "0x5CAE4C0", VA = "0x185CAFCC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5CB04D0", Offset = "0x5CAECD0", VA = "0x185CB04D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ENLOEBPGGAD LPDKGNAPENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture OOJLMNMFOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig ELABOKOKLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken NCEIDHNHODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject CCCKLKGLIIL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FNFCBJEHDPL<Texture> DOLCDEDANML
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CB06D0", Offset = "0x5CAEED0", VA = "0x185CB06D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> OLPHHHLJAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CB0730", Offset = "0x5CAEF30", VA = "0x185CB0730")]
		public LKFKCDKHPEI(ENLOEBPGGAD LPDKGNAPENE, RenderTexture OOJLMNMFOBJ, ImposterRenderConfig ELABOKOKLDP, CancellationToken NCEIDHNHODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CB05E0", Offset = "0x5CAEDE0", VA = "0x185CB05E0")]
		[AsyncStateMachine(typeof(JMFKNAOPNFM))]
		private Task<Texture> OLHNMAGOGKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5CB05D0", Offset = "0x5CAEDD0", VA = "0x185CB05D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5CB0550", Offset = "0x5CAED50", VA = "0x185CB0550")]
		private static void DIEMOCMMIBJ(GameObject CCCKLKGLIIL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OEKAPOAOHEH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5CB0D60", Offset = "0x5CAF560", VA = "0x185CB0D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x843D40", Offset = "0x842540", VA = "0x180843D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Header("General")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[BAKIIHHMALJ(NFNIPNJABGH.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	[SerializeField]
	private IFAILJEMDPI size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[KLGPADANODO("size", IFAILJEMDPI.Custom)]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
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
	private static int BEJGMPOIHDL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture CKIKOEHLIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private ANHHHKONKJG<GameObject> BCKHAFCMDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private HMNIIACEBPJ OJEBFDJKAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OOKDIBNEDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private LPPJOFCADCB<Texture> FBLNPIEBEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ENLOEBPGGAD KNDNLHCFKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EPLACPDJPCP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int BKHFFBLAELP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF780", Offset = "0x5CADF80", VA = "0x185CAF780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF7D0", Offset = "0x5CADFD0", VA = "0x185CAF7D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture MJNIJBLILMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF040", Offset = "0x5CAD840", VA = "0x185CAF040")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x762B70", Offset = "0x761370", VA = "0x180762B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ENLOEBPGGAD FKCLANOAEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x762B30", Offset = "0x761330", VA = "0x180762B30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF2E0", Offset = "0x5CADAE0", VA = "0x185CAF2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool OLBBADNGLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5E10", Offset = "0x4EB4610", VA = "0x184EB5E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int OLFHLAKCHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CAEEC0", Offset = "0x5CAD6C0", VA = "0x185CAEEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CAED70", Offset = "0x5CAD570", VA = "0x185CAED70")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF1F0", Offset = "0x5CAD9F0", VA = "0x185CAF1F0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CAED80", Offset = "0x5CAD580", VA = "0x185CAED80")]
	private void CODJHHILNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF660", Offset = "0x5CADE60", VA = "0x185CAF660")]
	public void Set(ENLOEBPGGAD FJJEBGLOLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF650", Offset = "0x5CADE50", VA = "0x185CAF650")]
	public void Set(Texture PNEGHHIDKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF670", Offset = "0x5CADE70", VA = "0x185CAF670")]
	public void Set(PCPDBIOFGPP IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEE00", Offset = "0x5CAD600", VA = "0x185CAEE00")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF450", Offset = "0x5CADC50", VA = "0x185CAF450")]
	public void SetInternal(ENLOEBPGGAD FJJEBGLOLAF, [Optional] Texture GPGGHAHNOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF440", Offset = "0x5CADC40", VA = "0x185CAF440")]
	public void SetCustomSize(int AIAFLLFGGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x765E60", Offset = "0x764660", VA = "0x180765E60")]
	public void SetAntiAliasing(int CJNBIJGPIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEE10", Offset = "0x5CAD610", VA = "0x185CAEE10")]
	[AsyncStateMachine(typeof(OEKAPOAOHEH))]
	private void IPCMHLIKKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEF60", Offset = "0x5CAD760", VA = "0x185CAEF60")]
	private void JMCANGGLCIA(Texture PNEGHHIDKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CAF700", Offset = "0x5CADF00", VA = "0x185CAF700")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, ELEFMBMCIED
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float JMBLNLDKIEP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	public void PrepareImposter(ANBFPDPCJJC HIKDFDIFDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CAED30", Offset = "0x5CAD530", VA = "0x185CAED30")]
	public void SetReferencePoint(Vector3 CINCGMPJHMP, Quaternion LAEFAMPNPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEB30", Offset = "0x5CAD330", VA = "0x185CAEB30")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CAED10", Offset = "0x5CAD510", VA = "0x185CAED10")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x12E4780", Offset = "0x12E2F80", VA = "0x1812E4780")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JLANIJPOIIO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static JLANIJPOIIO LCFJNEIEIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float LPLGCODFJKE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1EFAAA0", Offset = "0x1EF92A0", VA = "0x181EFAAA0")]
	public JLANIJPOIIO(float NBOPDHIGJMA)
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
		[BAKIIHHMALJ(NFNIPNJABGH.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int OJAFKBPECHG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int LIBOAHBKMDO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> CGAFDHGIKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool MBOOLHCNGCF;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF9B0", Offset = "0x5CAE1B0", VA = "0x185CAF9B0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF8B0", Offset = "0x5CAE0B0", VA = "0x185CAF8B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CAFBF0", Offset = "0x5CAE3F0", VA = "0x185CAFBF0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ENLOEBPGGAD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string FGDCDACIEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JLANIJPOIIO JLANIJPOIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FIPMNCEJDEO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> FCIDONGEOKP(CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HJPENCIBILD(ENLOEBPGGAD GHNNCJBDHKF);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONJJIOKBDHK();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEEEBBGJDMM();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ENJIFELBFLP([Out] LPPJOFCADCB<Texture> CJKEDCCOEPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HNCHKNMDNHL
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CAEA40", Offset = "0x5CAD240", VA = "0x185CAEA40")]
	public static bool DBNAHMNDMFI(ENLOEBPGGAD OGBKENMDLMF, ENLOEBPGGAD APOKAAPBHPE)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, ELEFMBMCIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5CABAE0", Offset = "0x5CAA2E0", VA = "0x185CABAE0", Slot = "4")]
		public void PrepareImposter(ANBFPDPCJJC HIKDFDIFDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ELEFMBMCIED
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ANBFPDPCJJC HIKDFDIFDNM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HAEMDCLGPMA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DCFABFPAFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> LPGECMFNJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AMGOBNMEFIO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject LMELPBNJPEG(GameObject NDAADLGGBHN, Transform KLGMOMIJPLM, bool GGCFDDBJJGN = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LMELPBNJPEG<T>(T NDAADLGGBHN, Transform KLGMOMIJPLM, bool GGCFDDBJJGN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T LMELPBNJPEG<T>(GameObject NDAADLGGBHN, Transform KLGMOMIJPLM, bool GGCFDDBJJGN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject LMELPBNJPEG(GameObject NDAADLGGBHN, Transform KLGMOMIJPLM, ANBFPDPCJJC HIKDFDIFDNM, bool GGCFDDBJJGN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PJFBENJCDOE : IDisposable, AMGOBNMEFIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> NMGNPFHEDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LLIDLBGCAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform IOHMKHKNBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> HDPAHHBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> GEDJFENIBCP;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CB1500", Offset = "0x5CAFD00", VA = "0x185CB1500")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.None)]
	public static void AJCEEBENPCL(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CB1F60", Offset = "0x5CB0760", VA = "0x185CB1F60")]
	[Preserve]
	public PJFBENJCDOE([AKMGDNDIMPI(null)] HAEMDCLGPMA EEFFBDKOBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CB1710", Offset = "0x5CAFF10", VA = "0x185CB1710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CB1E40", Offset = "0x5CB0640", VA = "0x185CB1E40", Slot = "5")]
	public GameObject LMELPBNJPEG(GameObject NDAADLGGBHN, Transform KLGMOMIJPLM, bool GGCFDDBJJGN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2503D30", Offset = "0x2502530", VA = "0x182503D30", Slot = "6")]
	public T LMELPBNJPEG<T>(T NDAADLGGBHN, Transform KLGMOMIJPLM, bool GGCFDDBJJGN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2503D00", Offset = "0x2502500", VA = "0x182503D00", Slot = "7")]
	public T LMELPBNJPEG<T>(GameObject NDAADLGGBHN, Transform KLGMOMIJPLM, bool GGCFDDBJJGN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CB1ED0", Offset = "0x5CB06D0", VA = "0x185CB1ED0", Slot = "8")]
	public GameObject LMELPBNJPEG(GameObject NDAADLGGBHN, Transform KLGMOMIJPLM, ANBFPDPCJJC HIKDFDIFDNM, bool GGCFDDBJJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2503DA0", Offset = "0x25025A0", VA = "0x182503DA0", Slot = "9")]
	public T LMELPBNJPEG<T>(GameObject NDAADLGGBHN, Transform KLGMOMIJPLM, ANBFPDPCJJC HIKDFDIFDNM, bool GGCFDDBJJGN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2503750", Offset = "0x2501F50", VA = "0x182503750")]
	private T LMELPBNJPEG<T>(GameObject NDAADLGGBHN, Transform KLGMOMIJPLM, ANBFPDPCJJC HIKDFDIFDNM, bool GGCFDDBJJGN, [Out] GameObject OFKHBKEEHGB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2503DE0", Offset = "0x25025E0", VA = "0x182503DE0")]
	private T PLKIHKBDPBE<T>(GameObject AAAOHJGLLEG, ANBFPDPCJJC HIKDFDIFDNM, bool GGCFDDBJJGN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CB1600", Offset = "0x5CAFE00", VA = "0x185CB1600")]
	private void CBMCFEAACLF(Component ENFAJMDKEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CB17F0", Offset = "0x5CAFFF0", VA = "0x185CB17F0")]
	private void FCDCCMECCOK(Component ENFAJMDKEKJ, ANBFPDPCJJC HIKDFDIFDNM, bool GGCFDDBJJGN, bool IGOODPAHBGJ, [Optional] Type FNAHAINCOJK, [Optional] Type JGPPEHGELKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CB1CD0", Offset = "0x5CB04D0", VA = "0x185CB1CD0")]
	private void GLLDAINBBPA(GameObject AAAOHJGLLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ANBFPDPCJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> NHBPOMKIILP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29C7790", Offset = "0x29C5F90", VA = "0x1829C7790")]
	public ANBFPDPCJJC ABNCEPDOIJI<T>(T KNECPHNPFCH)
	{
		return default(ANBFPDPCJJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29C7EC0", Offset = "0x29C66C0", VA = "0x1829C7EC0")]
	public T BCFBOGKIONB<T>(T FEAAGHJCDLM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29C7FD0", Offset = "0x29C67D0", VA = "0x1829C7FD0")]
	public bool GBJDFDNKBJP<T>([Out] T KNECPHNPFCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DOEEOAFBOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool MNEOKJNBPBI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xB30410", Offset = "0xB2EC10", VA = "0x180B30410")]
	public DOEEOAFBOEK(bool KLFCBHADDDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KEMGGFKICGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool FHBBMJAFADK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CB0540", Offset = "0x5CAED40", VA = "0x185CB0540")]
	public KEMGGFKICGP(bool EDCADDEEJFI)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, ELEFMBMCIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5CB23A0", Offset = "0x5CB0BA0", VA = "0x185CB23A0", Slot = "4")]
		public void PrepareImposter(ANBFPDPCJJC HIKDFDIFDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x5CB0930", Offset = "0x5CAF130", VA = "0x185CB0930")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5CB0920", Offset = "0x5CAF120", VA = "0x185CB0920")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF850", Offset = "0x5CAE050", VA = "0x185CAF850")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ENPBLDCIPFF
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<URPLight> NJIELILBNHK;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Vector3 FOPHBIHLIMB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 OGEECHIEFEI;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static Camera FPJGDPAALJL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> FMFABCCKBLF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode HECGGLECCMD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color AGIMKFCOJDO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color BCLFAJGLFOL;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color AKKECHALJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap LHGGLLKEHGD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool LFDKOHLPJCM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera NELILMCECHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5CAD220", Offset = "0x5CABA20", VA = "0x185CAD220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CADB60", Offset = "0x5CAC360", VA = "0x185CADB60")]
	public static void JHKJHLMKJPC(Vector3 KLBOHMPPMCJ, Quaternion PPPMAMKJCAI, ImposterRenderConfig INFDJGBENMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CACB50", Offset = "0x5CAB350", VA = "0x185CACB50")]
	private static void AINONAGBBFJ(Vector3 KLBOHMPPMCJ, Quaternion PPPMAMKJCAI, URPLight HCCJNMDMPLF, ImposterRenderConfig.LightConfig PABNOPOEJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD140", Offset = "0x5CAB940", VA = "0x185CAD140")]
	public static void EPAFFGEOFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD7E0", Offset = "0x5CABFE0", VA = "0x185CAD7E0")]
	private static void JEDDLADMPPB(int GNJPIPNHLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CADE80", Offset = "0x5CAC680", VA = "0x185CADE80")]
	public static void MPOBEPNDGOF(ImposterRenderConfig INFDJGBENMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD050", Offset = "0x5CAB850", VA = "0x185CAD050")]
	public static void EDCGCAFBGOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CACE80", Offset = "0x5CAB680", VA = "0x185CACE80")]
	public static void AMOBEFPIOAM(GameObject LBHALMCDMMK, RenderTexture OOJLMNMFOBJ, ImposterRenderConfig INFDJGBENMG, JLANIJPOIIO AGCGDGMFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE2E0", Offset = "0x5CACAE0", VA = "0x185CAE2E0")]
	private static void PGJNPLKEPJB(GameObject LBHALMCDMMK, RenderTexture OOJLMNMFOBJ, ImposterRenderConfig INFDJGBENMG, JLANIJPOIIO AGCGDGMFIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CAE040", Offset = "0x5CAC840", VA = "0x185CAE040")]
	private static void PGBNIBDMIBJ(GameObject LBHALMCDMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CAD430", Offset = "0x5CABC30", VA = "0x185CAD430")]
	public static void HCFOALJKCMO(GameObject NDAADLGGBHN, Vector3 KHJMDHNKIPP, Vector3 CAJDFELEKID, float PLNBDIIJKKI, JLANIJPOIIO AGCGDGMFIBP, [Out] Vector3 BMBNGJIAEHO, [Out] Quaternion CLJNJLDPGKL, [Out] float ICLOLAOKKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CADDD0", Offset = "0x5CAC5D0", VA = "0x185CADDD0")]
	public static RenderTexture LBKBHBJLPHH(int OENMLNGACGK, int EECPDFLCEFA, RenderTextureFormat NODJEJKFPPC = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct LLJIBKPNAEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public MPIIFDIEJMJ HCKMGPBJKNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject CICMNMNGIBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture MJNIJBLILMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig PHHIIJOEPFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public JLANIJPOIIO JLANIJPOIIO;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5CB08B0", Offset = "0x5CAF0B0", VA = "0x185CB08B0")]
			public LLJIBKPNAEA(MPIIFDIEJMJ ILKFMEEJMIC, GameObject BOLMMFPPKAM, RenderTexture OOJLMNMFOBJ, ImposterRenderConfig ELABOKOKLDP, JLANIJPOIIO AGCGDGMFIBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static FAFBNCGOCIM<LLJIBKPNAEA, RenderTexture> FBHDHHEHAIH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<LLJIBKPNAEA> JAALOMEJGMB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int CPGOGAMKFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5CABE20", Offset = "0x5CAA620", VA = "0x185CABE20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC0D0", Offset = "0x5CAA8D0", VA = "0x185CAC0D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LBHALMCDMMK, RenderTexture OOJLMNMFOBJ, ImposterRenderConfig INFDJGBENMG, JLANIJPOIIO AGCGDGMFIBP, CancellationToken NCEIDHNHODH, bool EBOPHJBKDPK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5CABC30", Offset = "0x5CAA430", VA = "0x185CABC30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC030", Offset = "0x5CAA830", VA = "0x185CAC030", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5CABE90", Offset = "0x5CAA690", VA = "0x185CABE90")]
		private static Task<RenderTexture> HBLOCILGLKI(LLJIBKPNAEA PBNNLFMPLDN, CancellationToken NCEIDHNHODH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5CAC4F0", Offset = "0x5CAACF0", VA = "0x185CAC4F0")]
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
