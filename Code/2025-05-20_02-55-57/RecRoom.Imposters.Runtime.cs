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
	private readonly struct EOEAMEBFFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly HBLGECAGJBL IKIKNLDOMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string GKPIDFDNOIL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
		public EOEAMEBFFCK(HBLGECAGJBL FHHMIMEDJCG, string AOEGJGILOAO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct LPOGOGCBKAG : IAsyncStateMachine
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
		public EOEAMEBFFCK queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3D00", Offset = "0x7CD2F00", VA = "0x187CD3D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CD40C0", Offset = "0x7CD32C0", VA = "0x187CD40C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider OKNAEMMJGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DHDBJOBDFMD<EOEAMEBFFCK, GameObject> POKPLPKIAKI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HOCJCMPHAIA LMFLIKHHGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DHDBJOBDFMD<EOEAMEBFFCK, GameObject> ENOCAFKKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF9A0", Offset = "0x7CCEBA0", VA = "0x187CCF9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int PMBOCDEOEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF660", Offset = "0x7CCE860", VA = "0x187CCF660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF580", Offset = "0x7CCE780", VA = "0x187CCF580", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB00", Offset = "0x7CCED00", VA = "0x187CCFB00", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF880", Offset = "0x7CCEA80", VA = "0x187CCF880")]
	[AsyncStateMachine(typeof(LPOGOGCBKAG))]
	private Task<GameObject> OMBLKAEOOEP(EOEAMEBFFCK OAKMCINJNCF, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7CCF6B0", Offset = "0x7CCE8B0", VA = "0x187CCF6B0")]
	public Task<GameObject> LoadItemAsync(HBLGECAGJBL FHHMIMEDJCG, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFB70", Offset = "0x7CCED70", VA = "0x187CCFB70")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NFPKMADELJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HBLGECAGJBL DJHGFPJPFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture LFJIKAJNPEG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
		public NFPKMADELJG(HBLGECAGJBL KFNCMIELECN, Texture BEFHHDCIDIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum IDDPBFFJAIM
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
	private class JKHDBCAAPMD : FBGDNDHDIBD<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct MAPJBLFDIMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JKHDBCAAPMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7CD4160", Offset = "0x7CD3360", VA = "0x187CD4160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7CD4950", Offset = "0x7CD3B50", VA = "0x187CD4950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly HBLGECAGJBL KFNCMIELECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture PMHKGBLCIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig NJEILIALFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken HCELDNOKOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D FKIBGJIHAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject LLBOOHIFHEI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override CMEBMOPMCFP<Texture2D> PGNPLOLACCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7CD3840", Offset = "0x7CD2A40", VA = "0x187CD3840", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> FMPPMCAKLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3A40", Offset = "0x7CD2C40", VA = "0x187CD3A40")]
		public JKHDBCAAPMD(HBLGECAGJBL KFNCMIELECN, RenderTexture PMHKGBLCIPJ, ImposterRenderConfig NJEILIALFGH, CancellationToken HCELDNOKOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3950", Offset = "0x7CD2B50", VA = "0x187CD3950")]
		[AsyncStateMachine(typeof(MAPJBLFDIMH))]
		private Task<Texture2D> NPKKAKLGIGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3920", Offset = "0x7CD2B20", VA = "0x187CD3920", Slot = "10")]
		protected override void JHIKCOMNLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7CD38A0", Offset = "0x7CD2AA0", VA = "0x187CD38A0")]
		private static void JECIAGEIBGJ(GameObject LLBOOHIFHEI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DIFLNNDGNIJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7CCE330", Offset = "0x7CCD530", VA = "0x187CCE330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA51B40", Offset = "0xA50D40", VA = "0x180A51B40", Slot = "5")]
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
	[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private IDDPBFFJAIM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[GLHFIOJNDCO("size", IDDPBFFJAIM.Custom)]
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
	private static int KDENJIECEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture KILOGHDACHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DJLKFFDGOIB<GameObject> IBLNCIENAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GCMBNCCDKOG OEODDPFIMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource BDMFGMOCHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private PAACHOBIIFN<Texture2D> PBDMDCKJDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private HBLGECAGJBL NDHPKCKEJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DFIJPGKKLCA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LKDHMLHMEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3310", Offset = "0x7CD2510", VA = "0x187CD3310")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3360", Offset = "0x7CD2560", VA = "0x187CD3360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KGINJLAHKOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2900", Offset = "0x7CD1B00", VA = "0x187CD2900")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private HBLGECAGJBL DJHGFPJPFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2BF0", Offset = "0x7CD1DF0", VA = "0x187CD2BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool OEEMHHEOHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2193A50", Offset = "0x2192C50", VA = "0x182193A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DCJFPDEHBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7CD2AE0", Offset = "0x7CD1CE0", VA = "0x187CD2AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CD28E0", Offset = "0x7CD1AE0", VA = "0x187CD28E0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2E00", Offset = "0x7CD2000", VA = "0x187CD2E00")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2B70", Offset = "0x7CD1D70", VA = "0x187CD2B70")]
	private void LAAHBKDNAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CD31F0", Offset = "0x7CD23F0", VA = "0x187CD31F0")]
	public void Set(HBLGECAGJBL JGLGEKHAMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CD31E0", Offset = "0x7CD23E0", VA = "0x187CD31E0")]
	public void Set(Texture BEFHHDCIDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3200", Offset = "0x7CD2400", VA = "0x187CD3200")]
	public void Set(NFPKMADELJG MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD28F0", Offset = "0x7CD1AF0", VA = "0x187CD28F0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2FE0", Offset = "0x7CD21E0", VA = "0x187CD2FE0")]
	public void SetInternal(HBLGECAGJBL JGLGEKHAMKE, [Optional] Texture CPBONIEBEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2FD0", Offset = "0x7CD21D0", VA = "0x187CD2FD0")]
	public void SetCustomSize(int OEFNBADDKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9FD8D0", Offset = "0x9FCAD0", VA = "0x1809FD8D0")]
	public void SetAntiAliasing(int KBONLNNFCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2D50", Offset = "0x7CD1F50", VA = "0x187CD2D50")]
	[AsyncStateMachine(typeof(DIFLNNDGNIJ))]
	private void NKHBHKMGIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2EF0", Offset = "0x7CD20F0", VA = "0x187CD2EF0")]
	private void PFBOOFCBDEF(Texture BEFHHDCIDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3290", Offset = "0x7CD2490", VA = "0x187CD3290")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, MHEOINMOFAN
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float OOPGKCBPLHH = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void PrepareImposter(JOIHPIONDCH MGEECOGALOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD28A0", Offset = "0x7CD1AA0", VA = "0x187CD28A0")]
	public void SetReferencePoint(Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CD26B0", Offset = "0x7CD18B0", VA = "0x187CD26B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CD2880", Offset = "0x7CD1A80", VA = "0x187CD2880")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E6C0A0", Offset = "0x1E6B2A0", VA = "0x181E6C0A0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BDEJMIJEECM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static BDEJMIJEECM GHCLNMKGLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float AECBDHKJJIL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29E44F0", Offset = "0x29E36F0", VA = "0x1829E44F0")]
	public BDEJMIJEECM(float JPKKMBLNBLL)
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
		[Cpp2IlInjected.Address(RVA = "0x7CD5B30", Offset = "0x7CD4D30", VA = "0x187CD5B30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
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
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int IINOKDMJOLP = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int GGEMELIIJIO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> IEJAIFOCDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool GFEMDBAOGDG;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3570", Offset = "0x7CD2770", VA = "0x187CD3570")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3470", Offset = "0x7CD2670", VA = "0x187CD3470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7CD37B0", Offset = "0x7CD29B0", VA = "0x187CD37B0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HBLGECAGJBL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string PDAIJNPIJON
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BDEJMIJEECM BDEJMIJEECM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MDPMGNAICAL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> AEMEIICCPPM(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJODDJKCNDD(HBLGECAGJBL FNJGMJGALLH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHOAMEPPCOO();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAOFFNDGJKP();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FDNDNHMLFPD(uint? GCOOBIFEGIF, [Out] PAACHOBIIFN<Texture2D> EMFMFMAGBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LNCOIALEDPB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3C10", Offset = "0x7CD2E10", VA = "0x187CD3C10")]
	public static bool GDHHNPHHIDD(HBLGECAGJBL DOEJNLBEHJN, HBLGECAGJBL PKFHFGNCEFI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, MHEOINMOFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE1E0", Offset = "0x7CCD3E0", VA = "0x187CCE1E0", Slot = "4")]
		public void PrepareImposter(JOIHPIONDCH MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MHEOINMOFAN
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(JOIHPIONDCH MGEECOGALOB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GEFPBPLFAML
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> CHIBJIJIDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NNFMCKAKCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HOCJCMPHAIA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCEPKIHMPBK(params Type[] FJIFAMFDFPA);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject DGELCHOFMKJ(GameObject IGJKKFNOEMM, Transform NJHDJGHEICO, bool DKIBOEIABOD = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DGELCHOFMKJ<T>(T IGJKKFNOEMM, Transform NJHDJGHEICO, bool DKIBOEIABOD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DGELCHOFMKJ<T>(GameObject IGJKKFNOEMM, Transform NJHDJGHEICO, bool DKIBOEIABOD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject DGELCHOFMKJ(GameObject IGJKKFNOEMM, Transform NJHDJGHEICO, JOIHPIONDCH MGEECOGALOB, bool DKIBOEIABOD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PDDOPJOOEKG : IDisposable, HOCJCMPHAIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> KNJIDLOHCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> BKKAKMFHHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform BECKMMFPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> GEABHFEGOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> NIOOBFLLHPB;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CD52F0", Offset = "0x7CD44F0", VA = "0x187CD52F0")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	public static void NPCFNJKLMBL(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5440", Offset = "0x7CD4640", VA = "0x187CD5440")]
	[UnityEngine.Scripting.Preserve]
	public PDDOPJOOEKG([ALHAHLCGLLK(null)] GEFPBPLFAML EIPOEJODOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4AE0", Offset = "0x7CD3CE0", VA = "0x187CD4AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CD53F0", Offset = "0x7CD45F0", VA = "0x187CD53F0", Slot = "5")]
	public void OCEPKIHMPBK(params Type[] FJIFAMFDFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4A50", Offset = "0x7CD3C50", VA = "0x187CD4A50", Slot = "6")]
	public GameObject DGELCHOFMKJ(GameObject IGJKKFNOEMM, Transform NJHDJGHEICO, bool DKIBOEIABOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A210", Offset = "0x3A09410", VA = "0x183A0A210", Slot = "7")]
	public T DGELCHOFMKJ<T>(T IGJKKFNOEMM, Transform NJHDJGHEICO, bool DKIBOEIABOD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A2A0", Offset = "0x3A094A0", VA = "0x183A0A2A0", Slot = "8")]
	public T DGELCHOFMKJ<T>(GameObject IGJKKFNOEMM, Transform NJHDJGHEICO, bool DKIBOEIABOD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CD49C0", Offset = "0x7CD3BC0", VA = "0x187CD49C0", Slot = "9")]
	public GameObject DGELCHOFMKJ(GameObject IGJKKFNOEMM, Transform NJHDJGHEICO, JOIHPIONDCH MGEECOGALOB, bool DKIBOEIABOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A8C0", Offset = "0x3A09AC0", VA = "0x183A0A8C0", Slot = "10")]
	public T DGELCHOFMKJ<T>(GameObject IGJKKFNOEMM, Transform NJHDJGHEICO, JOIHPIONDCH MGEECOGALOB, bool DKIBOEIABOD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A2F0", Offset = "0x3A094F0", VA = "0x183A0A2F0")]
	private T DGELCHOFMKJ<T>(GameObject IGJKKFNOEMM, Transform NJHDJGHEICO, JOIHPIONDCH MGEECOGALOB, bool DKIBOEIABOD, [Out] GameObject GJPBLIFCDBB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A920", Offset = "0x3A09B20", VA = "0x183A0A920")]
	private T HPLGABMNMMJ<T>(GameObject GNOLFLMODHC, JOIHPIONDCH MGEECOGALOB, bool DKIBOEIABOD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4BC0", Offset = "0x7CD3DC0", VA = "0x187CD4BC0")]
	private void IMHPEHCLCMF(Component CBNJHLDNKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7CD4CD0", Offset = "0x7CD3ED0", VA = "0x187CD4CD0")]
	private void LICOGAIFGND(Component CBNJHLDNKAL, JOIHPIONDCH MGEECOGALOB, bool DKIBOEIABOD, bool DNDMPAMCGCA, [Optional] Type HMAPEIFMGEO, [Optional] Type GJBHMLAOCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD5180", Offset = "0x7CD4380", VA = "0x187CD5180")]
	private void MLMMEDJPJLK(GameObject GNOLFLMODHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JOIHPIONDCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> NMFMHECPMPI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x38741B0", Offset = "0x38733B0", VA = "0x1838741B0")]
	public JOIHPIONDCH DENBCCCLIHH<T>(T BIBIKPAMPDI)
	{
		return default(JOIHPIONDCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x38748E0", Offset = "0x3873AE0", VA = "0x1838748E0")]
	public T HKFPFFCEPKK<T>(T FAGKKFIFNNI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x38749F0", Offset = "0x3873BF0", VA = "0x1838749F0")]
	public bool LONOHHPMJJI<T>([Out] T BIBIKPAMPDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IEGBCHMMNKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool OCMOJAGCMEM;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29E56C0", Offset = "0x29E48C0", VA = "0x1829E56C0")]
	public IEGBCHMMNKL(bool LGKPONKCPNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KCIIPNNNLOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool BMCAFMOJHPJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CD3C00", Offset = "0x7CD2E00", VA = "0x187CD3C00")]
	public KCIIPNNNLOB(bool BIGLHHHKNEK)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, MHEOINMOFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7CD5880", Offset = "0x7CD4A80", VA = "0x187CD5880", Slot = "4")]
		public void PrepareImposter(JOIHPIONDCH MGEECOGALOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
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
		public Bounds CFFCFCPMANH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7CD2520", Offset = "0x7CD1720", VA = "0x187CD2520")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7CD24E0", Offset = "0x7CD16E0", VA = "0x187CD24E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7CD24A0", Offset = "0x7CD16A0", VA = "0x187CD24A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7CD23B0", Offset = "0x7CD15B0", VA = "0x187CD23B0")]
		private void OJKMFMKKNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CD4140", Offset = "0x7CD3340", VA = "0x187CD4140")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7CD4130", Offset = "0x7CD3330", VA = "0x187CD4130")]
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
		[GLHFIOJNDCO("frameCameraToImposterBounds", true)]
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
		[GLHFIOJNDCO("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x7CD33D0", Offset = "0x7CD25D0", VA = "0x187CD33D0")]
		public void FJHBBHMNCDF(Vector3 DEIEOHGDJPF, Quaternion IOJGGMILCPB, float LIEDNLNJBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD3400", Offset = "0x7CD2600", VA = "0x187CD3400")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class EDJHMGFCBMH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 FPHNCBCMENK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> OLEKNBBPEAJ;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> NMJKAGIONGB;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera FBPHPNLMNIB;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> GPBMPHKICFN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> HJCAHCODKHI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode AGDGFCNOMON;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color MEHLFIJONNB;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color KPPCIBIHKCN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color OAMOGLOPGDF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap PIDKJHKJJCB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool HIFHDIPHCJN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> LKADOEBPPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0690", Offset = "0x7CCF890", VA = "0x187CD0690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> IAPBMNHLAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0970", Offset = "0x7CCFB70", VA = "0x187CD0970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera CGJOMEAPBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CD0460", Offset = "0x7CCF660", VA = "0x187CD0460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1530", Offset = "0x7CD0730", VA = "0x187CD1530")]
	public static void LOOBNBENDCJ(Vector3 HGMICENCPLG, Quaternion LIFACKMCIMP, ImposterRenderConfig LCINFAINBAL, bool CNCHLNJIPMH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0A90", Offset = "0x7CCFC90", VA = "0x187CD0A90")]
	private static void KMHGMIJLFFJ(Vector3 HGMICENCPLG, Quaternion LIFACKMCIMP, URPLight HMKAPFIPHJL, ImposterRenderConfig.LightConfig IDHCMCOJKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0890", Offset = "0x7CCFA90", VA = "0x187CD0890")]
	public static void GOODOCHJBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CD0DB0", Offset = "0x7CCFFB0", VA = "0x187CD0DB0")]
	private static void LDBBCIJDDCG(int JCEAOFBCOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CD06E0", Offset = "0x7CCF8E0", VA = "0x187CD06E0")]
	public static void GDELBFOOCBL(ImposterRenderConfig LCINFAINBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFBB0", Offset = "0x7CCEDB0", VA = "0x187CCFBB0")]
	public static void ADELHKIPAPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CD1DF0", Offset = "0x7CD0FF0", VA = "0x187CD1DF0")]
	public static void PIPMJIPKANH(GameObject AIMGLNHHKJA, RenderTexture PMHKGBLCIPJ, ImposterRenderConfig LCINFAINBAL, BDEJMIJEECM FJMFCMLCIEC, [Optional] Vector3? MEPMJDGIECH, [Optional] Vector3? DPLGENELJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CD17C0", Offset = "0x7CD09C0", VA = "0x187CD17C0")]
	private static void OGEHINAPIPM(GameObject AIMGLNHHKJA, RenderTexture PMHKGBLCIPJ, ImposterRenderConfig LCINFAINBAL, BDEJMIJEECM FJMFCMLCIEC, Vector3 MEPMJDGIECH, Vector3 DPLGENELJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CD01A0", Offset = "0x7CCF3A0", VA = "0x187CD01A0")]
	private static void CMGOMEAGMDG(GameObject AIMGLNHHKJA, Vector3 DKLEDFDPAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD11C0", Offset = "0x7CD03C0", VA = "0x187CD11C0")]
	public static void LEPJKMHDADK(Bounds HLGMCAOCLIN, ImposterRenderConfig LCINFAINBAL, [Out] Vector3 COCHALANCAG, [Out] Quaternion APCBEPHIGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CCFC90", Offset = "0x7CCEE90", VA = "0x187CCFC90")]
	private static void CCGPCFDNLHE(GameObject IGJKKFNOEMM, ImposterRenderConfig LCINFAINBAL, BDEJMIJEECM FJMFCMLCIEC, [Out] Vector3 COCHALANCAG, [Out] Quaternion APCBEPHIGLB, [Out] float DNDKLEOOFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7CD09C0", Offset = "0x7CCFBC0", VA = "0x187CD09C0")]
	public static RenderTexture JHFOLJBKKPK(int GMGIBIFALPD, int PKHBHCLOCLA, RenderTextureFormat HPCBECKKHGG = RenderTextureFormat.ARGB32, string LKILFFBNGMM = "[ImposterRendering]Preview")
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
		public struct IKJFKDAMBOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public HLMGOEMIJGH DJGNJPJOMBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject CABOGAAFDLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture KGINJLAHKOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig KNLODCIJGPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public BDEJMIJEECM BDEJMIJEECM;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7CD2340", Offset = "0x7CD1540", VA = "0x187CD2340")]
			public IKJFKDAMBOP(HLMGOEMIJGH HFCKNONPKCI, GameObject LBBILAJCGNH, RenderTexture PMHKGBLCIPJ, ImposterRenderConfig NJEILIALFGH, BDEJMIJEECM FJMFCMLCIEC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static DHDBJOBDFMD<IKJFKDAMBOP, RenderTexture> CLHNHGIFKDP;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<IKJFKDAMBOP> LKBEOMJECGK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int AHGOKJPNKKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7CCED80", Offset = "0x7CCDF80", VA = "0x187CCED80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF140", Offset = "0x7CCE340", VA = "0x187CCF140")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject AIMGLNHHKJA, RenderTexture PMHKGBLCIPJ, ImposterRenderConfig LCINFAINBAL, BDEJMIJEECM FJMFCMLCIEC, CancellationToken HCELDNOKOAM, bool ENOHNGNDJGN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7CCEB70", Offset = "0x7CCDD70", VA = "0x187CCEB70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF0B0", Offset = "0x7CCE2B0", VA = "0x187CCF0B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CCEE10", Offset = "0x7CCE010", VA = "0x187CCEE10")]
		private static Task<RenderTexture> LADNJIICJLA(IKJFKDAMBOP LGPKLMGHIAO, CancellationToken HCELDNOKOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7CCF540", Offset = "0x7CCE740", VA = "0x187CCF540")]
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
