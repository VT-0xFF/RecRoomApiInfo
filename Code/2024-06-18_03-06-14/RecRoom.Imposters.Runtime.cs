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
	private readonly struct NCHMCPMNIPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly PGAFFAABJNM BPDGGBFIKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BBAOPMPDOMC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
		public NCHMCPMNIPO(PGAFFAABJNM IENALJOPLOG, string CFJBMDPEFHO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FBEOKKLPJHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NCHMCPMNIPO queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68EBD50", Offset = "0x68EA750", VA = "0x1868EBD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68EC0F0", Offset = "0x68EAAF0", VA = "0x1868EC0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider HLGOENPNPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FHHBAIJDFEL<NCHMCPMNIPO, GameObject> OPGIAOOPBPG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JGDGFNIOKEJ EOKFNIGHAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FHHBAIJDFEL<NCHMCPMNIPO, GameObject> JCDKKNMAAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68EB8F0", Offset = "0x68EA2F0", VA = "0x1868EB8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int IAELKHOHAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68EBC10", Offset = "0x68EA610", VA = "0x1868EBC10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68EB710", Offset = "0x68EA110", VA = "0x1868EB710", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68EBC60", Offset = "0x68EA660", VA = "0x1868EBC60", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68EB7D0", Offset = "0x68EA1D0", VA = "0x1868EB7D0")]
	[AsyncStateMachine(typeof(FBEOKKLPJHK))]
	private Task<GameObject> EKKOEAMALEM(NCHMCPMNIPO GAAPGEADFHC, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68EBA50", Offset = "0x68EA450", VA = "0x1868EBA50")]
	public Task<GameObject> LoadItemAsync(PGAFFAABJNM IENALJOPLOG, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68EBCD0", Offset = "0x68EA6D0", VA = "0x1868EBCD0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BEENGFGNKOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public PGAFFAABJNM MEJJIMPHDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture GGHCKMICHFP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x854210", Offset = "0x852C10", VA = "0x180854210")]
		public BEENGFGNKOH(PGAFFAABJNM BKOMELCKPED, Texture POMOCFBBJEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum LGDNNLLLOED
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
	private class ILJLFJCIDGJ : IDJJAMGHOCK<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct KJBOPKCMJCH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ILJLFJCIDGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68EDA20", Offset = "0x68EC420", VA = "0x1868EDA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68EE220", Offset = "0x68ECC20", VA = "0x1868EE220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly PGAFFAABJNM BKOMELCKPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture BHMKADLMPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig ENPNCBCJDBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken AOLOJHLCMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject LJAFKEAOOAN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override CPAHEHFKIFF<Texture> MBAAKDLOMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68EC1E0", Offset = "0x68EABE0", VA = "0x1868EC1E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> CANEGADKBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68EC3B0", Offset = "0x68EADB0", VA = "0x1868EC3B0")]
		public ILJLFJCIDGJ(PGAFFAABJNM BKOMELCKPED, RenderTexture BHMKADLMPID, ImposterRenderConfig ENPNCBCJDBE, CancellationToken AOLOJHLCMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68EC240", Offset = "0x68EAC40", VA = "0x1868EC240")]
		[AsyncStateMachine(typeof(KJBOPKCMJCH))]
		private Task<Texture> OHKOJBENGNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68EC1D0", Offset = "0x68EABD0", VA = "0x1868EC1D0", Slot = "10")]
		protected override void CFANECHHBKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68EC330", Offset = "0x68EAD30", VA = "0x1868EC330")]
		private static void PDDMDLIBENJ(GameObject LJAFKEAOOAN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DPLCAMEBDOD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x68EA5C0", Offset = "0x68E8FC0", VA = "0x1868EA5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
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
	[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private LGDNNLLLOED size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[HJDMMFEIENC("size", LGDNNLLLOED.Custom)]
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
	private static int PHFIBHEFADJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture JKMGDFHHAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private ILCIBADBPLN<GameObject> ODIJCBHHHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BBADIINDDOJ JOKPPOONNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource NBIMBFBEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private AMHDMMJJKND<Texture> GEHPFPDOEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private PGAFFAABJNM DHEJDCLMHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DDDOIMHAKOE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MNAHOECCJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68ED4E0", Offset = "0x68EBEE0", VA = "0x1868ED4E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68ED530", Offset = "0x68EBF30", VA = "0x1868ED530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture FBKGBBDOBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68ECC30", Offset = "0x68EB630", VA = "0x1868ECC30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84EEC0", Offset = "0x84D8C0", VA = "0x18084EEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private PGAFFAABJNM MEJJIMPHDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84FCC0", Offset = "0x84E6C0", VA = "0x18084FCC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68ECAD0", Offset = "0x68EB4D0", VA = "0x1868ECAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LAFAMODOEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x15746A0", Offset = "0x15730A0", VA = "0x1815746A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int JOOGDINOIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68ECE10", Offset = "0x68EB810", VA = "0x1868ECE10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68ECAB0", Offset = "0x68EB4B0", VA = "0x1868ECAB0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68ED040", Offset = "0x68EBA40", VA = "0x1868ED040")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68ED130", Offset = "0x68EBB30", VA = "0x1868ED130")]
	private void PIKKLEPMPKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68ED400", Offset = "0x68EBE00", VA = "0x1868ED400")]
	public void Set(PGAFFAABJNM ADCFJPJPKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68ED3B0", Offset = "0x68EBDB0", VA = "0x1868ED3B0")]
	public void Set(Texture POMOCFBBJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68ED3C0", Offset = "0x68EBDC0", VA = "0x1868ED3C0")]
	public void Set(BEENGFGNKOH DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68ECAC0", Offset = "0x68EB4C0", VA = "0x1868ECAC0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68ED1C0", Offset = "0x68EBBC0", VA = "0x1868ED1C0")]
	public void SetInternal(PGAFFAABJNM ADCFJPJPKOC, [Optional] Texture EBEIBFAPIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68ED1B0", Offset = "0x68EBBB0", VA = "0x1868ED1B0")]
	public void SetCustomSize(int JFILJNJLFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x858ED0", Offset = "0x8578D0", VA = "0x180858ED0")]
	public void SetAntiAliasing(int JPJHHLFGNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68ECEB0", Offset = "0x68EB8B0", VA = "0x1868ECEB0")]
	[AsyncStateMachine(typeof(DPLCAMEBDOD))]
	private void MOIHLLHOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68ECF60", Offset = "0x68EB960", VA = "0x1868ECF60")]
	private void ONBEGHPIMGF(Texture POMOCFBBJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68ED460", Offset = "0x68EBE60", VA = "0x1868ED460")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HKAAJAFEAPA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float IBFHHCDKPBM = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
	public void PrepareImposter(IBAMNEFMAME FFNDHFNNMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68ECA70", Offset = "0x68EB470", VA = "0x1868ECA70")]
	public void SetReferencePoint(Vector3 KHAKKIFNDKN, Quaternion IMKGMPHEJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68EC870", Offset = "0x68EB270", VA = "0x1868EC870")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68ECA50", Offset = "0x68EB450", VA = "0x1868ECA50")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15E8D10", Offset = "0x15E7710", VA = "0x1815E8D10")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EHGCLNPLFAF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static EHGCLNPLFAF LCNAIGKBLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float MFCCILKPEKC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2150910", Offset = "0x214F310", VA = "0x182150910")]
	public EHGCLNPLFAF(float GJJNBKIDKOG)
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
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int CIMJKDIEOPM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int CKGHGEJNCCD = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> EIMNNCABFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool JMNMJABKAKH;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68ED740", Offset = "0x68EC140", VA = "0x1868ED740")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68ED640", Offset = "0x68EC040", VA = "0x1868ED640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68ED990", Offset = "0x68EC390", VA = "0x1868ED990")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PGAFFAABJNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string CMCHHDNBHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EHGCLNPLFAF EHGCLNPLFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LGGDOEEIGLK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> JMEJDKJLJEH(CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FJOMFOPEECD(PGAFFAABJNM HENLEJBGFIE);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJCILKKOPNP();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKMDDDOBKOB();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EFJCAJJEGDP([Out] AMHDMMJJKND<Texture> MNKNLFKICJK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MBGGGFMCBMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68EE2C0", Offset = "0x68ECCC0", VA = "0x1868EE2C0")]
	public static bool EDBHGLKMGDG(PGAFFAABJNM AMPMABIHPPA, PGAFFAABJNM APNFOJMHHNL)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, HKAAJAFEAPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68EA470", Offset = "0x68E8E70", VA = "0x1868EA470", Slot = "4")]
		public void PrepareImposter(IBAMNEFMAME FFNDHFNNMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HKAAJAFEAPA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(IBAMNEFMAME FFNDHFNNMLH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FMEANHHPDFL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> APGFGHIBNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> MLFELBJMCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JGDGFNIOKEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDMCNNHOHBM(params Type[] HNEEOEFAODI);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JBONCNOFFIE(GameObject GJEJJJDCBIG, Transform EMNGIAIDBPA, bool CJAJJFJDONA = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JBONCNOFFIE<T>(T GJEJJJDCBIG, Transform EMNGIAIDBPA, bool CJAJJFJDONA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JBONCNOFFIE<T>(GameObject GJEJJJDCBIG, Transform EMNGIAIDBPA, bool CJAJJFJDONA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject JBONCNOFFIE(GameObject GJEJJJDCBIG, Transform EMNGIAIDBPA, IBAMNEFMAME FFNDHFNNMLH, bool CJAJJFJDONA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BNPHFEJEALB : IDisposable, JGDGFNIOKEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> HENLPAAOAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> IFJCFJGIOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform AKFJKGMLBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> NOHFENNLHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CKAGIMKFGPE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68E96C0", Offset = "0x68E80C0", VA = "0x1868E96C0")]
	[MHFEIEAPENL(CMFCLNIIIKO.None)]
	public static void CGLKAELBCAP(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68EA030", Offset = "0x68E8A30", VA = "0x1868EA030")]
	[Preserve]
	public BNPHFEJEALB([OHLKLPAILPF(null)] FMEANHHPDFL CDKDGAFCFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68E97B0", Offset = "0x68E81B0", VA = "0x1868E97B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68E99B0", Offset = "0x68E83B0", VA = "0x1868E99B0", Slot = "5")]
	public void JDMCNNHOHBM(params Type[] HNEEOEFAODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68E9920", Offset = "0x68E8320", VA = "0x1868E9920", Slot = "6")]
	public GameObject JBONCNOFFIE(GameObject GJEJJJDCBIG, Transform EMNGIAIDBPA, bool CJAJJFJDONA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28CD7F0", Offset = "0x28CC1F0", VA = "0x1828CD7F0", Slot = "7")]
	public T JBONCNOFFIE<T>(T GJEJJJDCBIG, Transform EMNGIAIDBPA, bool CJAJJFJDONA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x28CD880", Offset = "0x28CC280", VA = "0x1828CD880", Slot = "8")]
	public T JBONCNOFFIE<T>(GameObject GJEJJJDCBIG, Transform EMNGIAIDBPA, bool CJAJJFJDONA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68E9890", Offset = "0x68E8290", VA = "0x1868E9890", Slot = "9")]
	public GameObject JBONCNOFFIE(GameObject GJEJJJDCBIG, Transform EMNGIAIDBPA, IBAMNEFMAME FFNDHFNNMLH, bool CJAJJFJDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28CD8D0", Offset = "0x28CC2D0", VA = "0x1828CD8D0", Slot = "10")]
	public T JBONCNOFFIE<T>(GameObject GJEJJJDCBIG, Transform EMNGIAIDBPA, IBAMNEFMAME FFNDHFNNMLH, bool CJAJJFJDONA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x28CD930", Offset = "0x28CC330", VA = "0x1828CD930")]
	private T JBONCNOFFIE<T>(GameObject GJEJJJDCBIG, Transform EMNGIAIDBPA, IBAMNEFMAME FFNDHFNNMLH, bool CJAJJFJDONA, [Out] GameObject MDPKANFJAOJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x28CDEB0", Offset = "0x28CC8B0", VA = "0x1828CDEB0")]
	private T NBHNDHLHIHK<T>(GameObject AOOABPFBFDN, IBAMNEFMAME FFNDHFNNMLH, bool CJAJJFJDONA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68E95B0", Offset = "0x68E7FB0", VA = "0x1868E95B0")]
	private void BLIDLOJBBPD(Component BHOOAGJPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68E9B70", Offset = "0x68E8570", VA = "0x1868E9B70")]
	private void PIIPGCPLCIC(Component BHOOAGJPBFO, IBAMNEFMAME FFNDHFNNMLH, bool CJAJJFJDONA, bool NHBJCAHNBCC, [Optional] Type AJFOIGLNNLG, [Optional] Type ONGCAODKNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68E9A00", Offset = "0x68E8400", VA = "0x1868E9A00")]
	private void JODJJEAHJPM(GameObject AOOABPFBFDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IBAMNEFMAME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> EHHPGPDBJLI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B52C70", Offset = "0x2B51670", VA = "0x182B52C70")]
	public IBAMNEFMAME BJDAAADFLKD<T>(T IFKIOPDHOFO)
	{
		return default(IBAMNEFMAME);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B52B60", Offset = "0x2B51560", VA = "0x182B52B60")]
	public T AMGKFNFCLFC<T>(T JIEGAHKKHCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B533A0", Offset = "0x2B51DA0", VA = "0x182B533A0")]
	public bool GBFLHMLGFGE<T>([Out] T IFKIOPDHOFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AHPFKKPDDGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool BNGEDOMLGMB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xE21AD0", Offset = "0xE204D0", VA = "0x180E21AD0")]
	public AHPFKKPDDGH(bool DMLCJPCEIDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OGJFGKDDECF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LKJELLJEHII;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68EE3A0", Offset = "0x68ECDA0", VA = "0x1868EE3A0")]
	public OGJFGKDDECF(bool CNLCDLLPLEJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, HKAAJAFEAPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68F0A20", Offset = "0x68EF420", VA = "0x1868F0A20", Slot = "4")]
		public void PrepareImposter(IBAMNEFMAME FFNDHFNNMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
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
		public Bounds DCGAFCGDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x68EC6E0", Offset = "0x68EB0E0", VA = "0x1868EC6E0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x68EC6A0", Offset = "0x68EB0A0", VA = "0x1868EC6A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68EC660", Offset = "0x68EB060", VA = "0x1868EC660")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68EC570", Offset = "0x68EAF70", VA = "0x1868EC570")]
		private void BFBLCABLKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68EE2A0", Offset = "0x68ECCA0", VA = "0x1868EE2A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x68EE290", Offset = "0x68ECC90", VA = "0x1868EE290")]
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
		[Cpp2IlInjected.Address(RVA = "0x68ED5B0", Offset = "0x68EBFB0", VA = "0x1868ED5B0")]
		public void MLPEJACGBOP(Vector3 GJGJEGIJCGC, Quaternion HDDEHDJPFLI, float IJKDNECIAFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68ED5E0", Offset = "0x68EBFE0", VA = "0x1868ED5E0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PGOPDJIOHKO
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 OBGIMHKDJFK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> GLLIOHOMCJE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> BHLMGHBAPPF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera GBAFEKGOPMA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> FFMIJJFMGJC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> DBAGNFGAKEK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode AIALCDGEJOA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color GHEMJBNBPBG;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color MPMCIMBCMKA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color LCGDMBEBDMH;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap LCANPOFAEEJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool FJNMHAGFCJJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> EKPOFCOIHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68EE6F0", Offset = "0x68ED0F0", VA = "0x1868EE6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> OKNADNOCJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68EE810", Offset = "0x68ED210", VA = "0x1868EE810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera KEBNPGGGAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68EE3B0", Offset = "0x68ECDB0", VA = "0x1868EE3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68F0220", Offset = "0x68EEC20", VA = "0x1868F0220")]
	public static void PMAGGFNHCIA(Vector3 AGLHCJHIODD, Quaternion EGCLEACDKDF, ImposterRenderConfig EAKKMCAFBHL, bool ABPFFDLIJBJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68F04C0", Offset = "0x68EEEC0", VA = "0x1868F04C0")]
	private static void PMDJGPBKDEB(Vector3 AGLHCJHIODD, Quaternion EGCLEACDKDF, URPLight JLINNHJBOAJ, ImposterRenderConfig.LightConfig COIKCFJPCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68EE860", Offset = "0x68ED260", VA = "0x1868EE860")]
	public static void HIFEAENBBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68EEF90", Offset = "0x68ED990", VA = "0x1868EEF90")]
	private static void IMCLNBLOEEO(int INJGCDILBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68EF9F0", Offset = "0x68EE3F0", VA = "0x1868EF9F0")]
	public static void LPPOJGJIBNG(ImposterRenderConfig EAKKMCAFBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68EE600", Offset = "0x68ED000", VA = "0x1868EE600")]
	public static void CIMMLFHHAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68EF6B0", Offset = "0x68EE0B0", VA = "0x1868EF6B0")]
	public static void LLNCAHJPCLC(GameObject HOKBMMHFPFL, RenderTexture BHMKADLMPID, ImposterRenderConfig EAKKMCAFBHL, EHGCLNPLFAF HLAIDDMCHKI, [Optional] Vector3? GDAJDKBNPLA, [Optional] Vector3? GGHHADOAHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x68EE940", Offset = "0x68ED340", VA = "0x1868EE940")]
	private static void HPOKBIIOLFN(GameObject HOKBMMHFPFL, RenderTexture BHMKADLMPID, ImposterRenderConfig EAKKMCAFBHL, EHGCLNPLFAF HLAIDDMCHKI, Vector3 GDAJDKBNPLA, Vector3 GGHHADOAHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68EF3C0", Offset = "0x68EDDC0", VA = "0x1868EF3C0")]
	private static void LDKNIEDBAFA(GameObject HOKBMMHFPFL, Vector3 GHFHOJMDPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68EFBB0", Offset = "0x68EE5B0", VA = "0x1868EFBB0")]
	private static void ONBAJIDGOPM(GameObject GJEJJJDCBIG, ImposterRenderConfig EAKKMCAFBHL, EHGCLNPLFAF HLAIDDMCHKI, [Out] Vector3 CKCIDAHOFGG, [Out] Quaternion FAMOMIJDHDL, [Out] float BBPPGDLKCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68EE740", Offset = "0x68ED140", VA = "0x1868EE740")]
	public static RenderTexture EFGJILKCKCC(int HJMKGIJAPGN, int FGABMENJOIE, RenderTextureFormat PHCNDPLEFBH = RenderTextureFormat.ARGB32, string MPBNEKFHMAM = "[ImposterRendering]Preview")
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
		public struct IDNLDLABBIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public EJAAPNKDHLA PCEBLEOAJIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject HOGHJMMODMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture FBKGBBDOBOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig CDDNBHAECKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public EHGCLNPLFAF EHGCLNPLFAF;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x68EC160", Offset = "0x68EAB60", VA = "0x1868EC160")]
			public IDNLDLABBIG(EJAAPNKDHLA JPNMHPHPAJB, GameObject BMGEDDGINAF, RenderTexture BHMKADLMPID, ImposterRenderConfig ENPNCBCJDBE, EHGCLNPLFAF HLAIDDMCHKI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static FHHBAIJDFEL<IDNLDLABBIG, RenderTexture> JODGOFCGMDI;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<IDNLDLABBIG> BOEGCENKNOO;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int IFHCEOEFFEE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x68EAFB0", Offset = "0x68E99B0", VA = "0x1868EAFB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x68EB2B0", Offset = "0x68E9CB0", VA = "0x1868EB2B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject HOKBMMHFPFL, RenderTexture BHMKADLMPID, ImposterRenderConfig EAKKMCAFBHL, EHGCLNPLFAF HLAIDDMCHKI, CancellationToken AOLOJHLCMLE, bool BCAFCGIDEKN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68EADC0", Offset = "0x68E97C0", VA = "0x1868EADC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68EB020", Offset = "0x68E9A20", VA = "0x1868EB020", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68EB0C0", Offset = "0x68E9AC0", VA = "0x1868EB0C0")]
		private static Task<RenderTexture> PEPKEPMNJMG(IDNLDLABBIG HHHPIFLDEKC, CancellationToken AOLOJHLCMLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68EB6D0", Offset = "0x68EA0D0", VA = "0x1868EB6D0")]
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
