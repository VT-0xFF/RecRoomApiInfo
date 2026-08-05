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
	private readonly struct MAKNIMMDGJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KCHAJAGDGBE BPJPHPJLAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string CFJGBOECNLB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x771A10", Offset = "0x770410", VA = "0x180771A10")]
		public MAKNIMMDGJG(KCHAJAGDGBE EGHFHHIHCNK, string BDPCILFKCLG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct AANBEEFKMAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public MAKNIMMDGJG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6397EF0", Offset = "0x63968F0", VA = "0x186397EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6398230", Offset = "0x6396C30", VA = "0x186398230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider AFFMFJMOHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::BMBCMIAHDIP<MAKNIMMDGJG, GameObject> JHOJNHAENBM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CCPPEOCPGJM GNJCCMHCABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::BMBCMIAHDIP<MAKNIMMDGJG, GameObject> BEDAOKNPLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x639B600", Offset = "0x639A000", VA = "0x18639B600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BHABFFNIBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x639B3E0", Offset = "0x6399DE0", VA = "0x18639B3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x639B1E0", Offset = "0x6399BE0", VA = "0x18639B1E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x639B760", Offset = "0x639A160", VA = "0x18639B760", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x639B290", Offset = "0x6399C90", VA = "0x18639B290")]
	[AsyncStateMachine(typeof(AANBEEFKMAK))]
	private Task<GameObject> HAHLLFMJCNH(MAKNIMMDGJG GHCFNAJNCEO, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x639B430", Offset = "0x6399E30", VA = "0x18639B430")]
	public Task<GameObject> LoadItemAsync(KCHAJAGDGBE EGHFHHIHCNK, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x639B7D0", Offset = "0x639A1D0", VA = "0x18639B7D0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class KPNBCIEJJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KCHAJAGDGBE LHPAHBCFBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture COHDHLLLKID;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C16E0", Offset = "0x6C00E0", VA = "0x1806C16E0")]
		public KPNBCIEJJCD(KCHAJAGDGBE DJOBLCGOGBE, Texture NDIDBNMHFLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum KLMNHDPIOPB
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
	private class ANJPFMJIKOC : global::FGGCDBFMPJN<Texture>, ANEOGICIPNL, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct LACEKGMLLOF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public ANJPFMJIKOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x639DEB0", Offset = "0x639C8B0", VA = "0x18639DEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x639E5B0", Offset = "0x639CFB0", VA = "0x18639E5B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly KCHAJAGDGBE DJOBLCGOGBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture BJJLINOJGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig PPENNIKCHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken KAKEKEHNCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject HDGICFIDIBE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GPMDAFELAJF FFKCDNJMAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6398320", Offset = "0x6396D20", VA = "0x186398320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::OHPLDOPGNGG<Texture> MNADFFFIHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6398330", Offset = "0x6396D30", VA = "0x186398330", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task IBCPPKGEEIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> AHDPPJNKHCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63984A0", Offset = "0x6396EA0", VA = "0x1863984A0")]
		public ANJPFMJIKOC(KCHAJAGDGBE DJOBLCGOGBE, RenderTexture BJJLINOJGLF, ImposterRenderConfig PPENNIKCHNM, CancellationToken KAKEKEHNCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6398380", Offset = "0x6396D80", VA = "0x186398380")]
		[AsyncStateMachine(typeof(LACEKGMLLOF))]
		private Task<Texture> PHBLFBEHNOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6398310", Offset = "0x6396D10", VA = "0x186398310", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6398280", Offset = "0x6396C80", VA = "0x186398280")]
		private static void DHDDFAMFHPH(GameObject HDGICFIDIBE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NJNLCGIKDIL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x639E670", Offset = "0x639D070", VA = "0x18639E670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAD0", Offset = "0x6C94D0", VA = "0x1806CAAD0", Slot = "5")]
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
	[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private KLMNHDPIOPB size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[PKBFELCOBFJ("size", 0)]
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
	private RenderTexture CDOKOLKINAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::EHAOBGIILCF<GameObject> KFGKMJHBOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NPKEGPKMBCL DNFPAFHGBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource FPCHIMCODNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::FGGCDBFMPJN<Texture> IHBEKCINOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private KCHAJAGDGBE DIDFMAKJCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture FLPCFBBCGGJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture MLBHKPKDCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x639BD20", Offset = "0x639A720", VA = "0x18639BD20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C85A0", Offset = "0x6C6FA0", VA = "0x1806C85A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private KCHAJAGDGBE LHPAHBCFBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7780", Offset = "0x6D6180", VA = "0x1806D7780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x639BE90", Offset = "0x639A890", VA = "0x18639BE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool ADNAPGHCNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8AC560", Offset = "0x8AAF60", VA = "0x1808AC560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int CDDMMIAAIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x639BB90", Offset = "0x639A590", VA = "0x18639BB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x639BB70", Offset = "0x639A570", VA = "0x18639BB70")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x639C0B0", Offset = "0x639AAB0", VA = "0x18639C0B0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x639BBA0", Offset = "0x639A5A0", VA = "0x18639BBA0")]
	private void HIEBCOKIIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x639C3D0", Offset = "0x639ADD0", VA = "0x18639C3D0")]
	public void Set(KCHAJAGDGBE EPAABHLHBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x639C3E0", Offset = "0x639ADE0", VA = "0x18639C3E0")]
	public void Set(Texture NDIDBNMHFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x639C3F0", Offset = "0x639ADF0", VA = "0x18639C3F0")]
	public void Set(KPNBCIEJJCD MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x639BB80", Offset = "0x639A580", VA = "0x18639BB80")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x639C1B0", Offset = "0x639ABB0", VA = "0x18639C1B0")]
	public void SetInternal(KCHAJAGDGBE EPAABHLHBIO, [Optional] Texture EHHJEAEGMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x639C1A0", Offset = "0x639ABA0", VA = "0x18639C1A0")]
	public void SetCustomSize(int PKAFBBEMDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x728640", Offset = "0x727040", VA = "0x180728640")]
	public void SetAntiAliasing(int IIFILBFOCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x639BFE0", Offset = "0x639A9E0", VA = "0x18639BFE0")]
	[AsyncStateMachine(typeof(NJNLCGIKDIL))]
	private void MMDKJAHKJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x639BC30", Offset = "0x639A630", VA = "0x18639BC30")]
	private void LJFAJILFINJ(Texture NDIDBNMHFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x639C430", Offset = "0x639AE30", VA = "0x18639C430")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, AFAHPNEBJHB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float MPJPHIILFDJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	public void PrepareImposter(HFOHCBNHBLG HKHEDELGBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x639BB30", Offset = "0x639A530", VA = "0x18639BB30")]
	public void SetReferencePoint(Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x639B9A0", Offset = "0x639A3A0", VA = "0x18639B9A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x639BB00", Offset = "0x639A500", VA = "0x18639BB00")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1928420", Offset = "0x1926E20", VA = "0x181928420")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MJHPJKJFLMI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static MJHPJKJFLMI AMMDEAEAGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float GNIEIMCDBLI;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9A20", Offset = "0x2EC8420", VA = "0x182EC9A20")]
	public MJHPJKJFLMI(float GCLCANBHHPK)
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
		[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int ONJEKBIBDIF = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int CFAPKBABJBL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> HKLCKKNKGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool NCHIKGAJCMP;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x639C5E0", Offset = "0x639AFE0", VA = "0x18639C5E0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x639C4F0", Offset = "0x639AEF0", VA = "0x18639C4F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x639C820", Offset = "0x639B220", VA = "0x18639C820")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KCHAJAGDGBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string PHLEENBNFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MJHPJKJFLMI MJHPJKJFLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MEMAHAFBIDA;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NBADEMCAIFG(CancellationToken KAKEKEHNCME);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CPMCFNPMCON(KCHAJAGDGBE DFHJPOKNFFB);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEIPILJGNBK();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPIJIFPGILF();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AFOGAIOBNFP(out global::FGGCDBFMPJN<Texture> KLCFJEMAOKP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GDKAEOCEJMM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x639B850", Offset = "0x639A250", VA = "0x18639B850")]
	public static bool LCOHJIONHKK(KCHAJAGDGBE MMOODLBIHCO, KCHAJAGDGBE MKIKADNDLKJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, AFAHPNEBJHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x639A750", Offset = "0x6399150", VA = "0x18639A750", Slot = "4")]
		public void PrepareImposter(HFOHCBNHBLG HKHEDELGBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AFAHPNEBJHB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HFOHCBNHBLG HKHEDELGBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ELGEFHHDGMD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> EPBJOMJHPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> HAGHKALJDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CCPPEOCPGJM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPFPMNJLLLC(params Type[] LJPCAFALCCO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPHLEEAIDHM(params Type[] LJPCAFALCCO);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject KEMENMIANCO(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, bool JEAFOEGJGMK = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T KEMENMIANCO<T>(T JFEEEILBEOO, Transform ELGBIOMPEHN, bool JEAFOEGJGMK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T KEMENMIANCO<T>(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, bool JEAFOEGJGMK = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject KEMENMIANCO(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T KEMENMIANCO<T>(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T KEMENMIANCO<T>(T JFEEEILBEOO, Transform ELGBIOMPEHN, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JIGALKMKEEC : IDisposable, CCPPEOCPGJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> FAJBLBNFPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> NHKJJJBAIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform BPBAFMAIAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> LLJCFIFMJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> OOEPGFOIGIH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x639CF40", Offset = "0x639B940", VA = "0x18639CF40")]
	[CJJNALDLMHL(HFKENCJEONK.None)]
	public static void GNBPIFAPGJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x639D440", Offset = "0x639BE40", VA = "0x18639D440")]
	[Preserve]
	public JIGALKMKEEC([HGGCKJALFAG(null)] ELGEFHHDGMD GNMKDDGMMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x639CDF0", Offset = "0x639B7F0", VA = "0x18639CDF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x639CEF0", Offset = "0x639B8F0", VA = "0x18639CEF0", Slot = "5")]
	public void FPFPMNJLLLC(params Type[] LJPCAFALCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x639D040", Offset = "0x639BA40", VA = "0x18639D040", Slot = "6")]
	public void GPHLEEAIDHM(params Type[] LJPCAFALCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x639D320", Offset = "0x639BD20", VA = "0x18639D320", Slot = "7")]
	public GameObject KEMENMIANCO(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, bool JEAFOEGJGMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2843B00", Offset = "0x2842500", VA = "0x182843B00", Slot = "8")]
	public T KEMENMIANCO<T>(T JFEEEILBEOO, Transform ELGBIOMPEHN, bool JEAFOEGJGMK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2843B70", Offset = "0x2842570", VA = "0x182843B70", Slot = "9")]
	public T KEMENMIANCO<T>(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, bool JEAFOEGJGMK = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x639D3B0", Offset = "0x639BDB0", VA = "0x18639D3B0", Slot = "10")]
	public GameObject KEMENMIANCO(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2844160", Offset = "0x2842B60", VA = "0x182844160", Slot = "11")]
	public T KEMENMIANCO<T>(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x28440D0", Offset = "0x2842AD0", VA = "0x1828440D0", Slot = "12")]
	public T KEMENMIANCO<T>(T JFEEEILBEOO, Transform ELGBIOMPEHN, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2843BA0", Offset = "0x28425A0", VA = "0x182843BA0")]
	private T KEMENMIANCO<T>(GameObject JFEEEILBEOO, Transform ELGBIOMPEHN, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK, out GameObject PDFFLAMJPAK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28435A0", Offset = "0x2841FA0", VA = "0x1828435A0")]
	private T IPCMPDGHHDD<T>(GameObject KEHOIMKGHCH, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x639D1F0", Offset = "0x639BBF0", VA = "0x18639D1F0")]
	private void JIFLHPIIKDK(Component DCIOCIFFEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x639C8A0", Offset = "0x639B2A0", VA = "0x18639C8A0")]
	private void BGPFGONILJC(Component DCIOCIFFEAC, HFOHCBNHBLG HKHEDELGBLL, bool JEAFOEGJGMK, bool GEJEIFOCHNF, [Optional] Type NEPGHINEHNN, [Optional] Type AMBMKBHAKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x639D090", Offset = "0x639BA90", VA = "0x18639D090")]
	private void JGOFDMDNNNO(GameObject KEHOIMKGHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HFOHCBNHBLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> DIMIMLICACB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x222D150", Offset = "0x222BB50", VA = "0x18222D150")]
	public HFOHCBNHBLG NLANNFAIKGA<T>(T HMDGBADEDKH)
	{
		return default(HFOHCBNHBLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x222C890", Offset = "0x222B290", VA = "0x18222C890")]
	public T AGGAFJIIBKL<T>(T OGDNNKNPNAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x222C9B0", Offset = "0x222B3B0", VA = "0x18222C9B0")]
	public bool BHPOPCGLBJN<T>(out T HMDGBADEDKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CAOMBEBCAOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool EFMPMJMIPAO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xE93480", Offset = "0xE91E80", VA = "0x180E93480")]
	public CAOMBEBCAOO(bool FMDFEBGGJIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EMAGCEPDPIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool BMBAPEOGDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x639B840", Offset = "0x639A240", VA = "0x18639B840")]
	public EMAGCEPDPIL(bool ELBGBOCJEAP)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, AFAHPNEBJHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x639EE00", Offset = "0x639D800", VA = "0x18639EE00", Slot = "4")]
		public void PrepareImposter(HFOHCBNHBLG HKHEDELGBLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
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
				[Cpp2IlInjected.Address(RVA = "0x639E610", Offset = "0x639D010", VA = "0x18639E610")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x639E600", Offset = "0x639D000", VA = "0x18639E600")]
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
		[Cpp2IlInjected.Address(RVA = "0x639C4B0", Offset = "0x639AEB0", VA = "0x18639C4B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CIMADPHOECE
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> FPDIAOCDNKO;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 IBHMPBEMPCE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 CIOALMGJGNG;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera EKFJJLABGJE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string OAPKBILJEJF = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const NACHGAJDFPA KHHCOPKLPKD = NACHGAJDFPA.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> IJLBOBENPMD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode CMGAJAEAJDE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color CPCNGFCFGLC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color PMELJCEJEKN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color EPDCKLGLIGJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap FBEKOEGLDON;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool HBCKIKLLDFC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera IOEKEPMGAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6399490", Offset = "0x6397E90", VA = "0x186399490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6398A50", Offset = "0x6397450", VA = "0x186398A50")]
	public static void EHGLKOLGGPC(Vector3 DBDBMNINDDA, Quaternion JPKHAJCCGHN, ImposterRenderConfig FFJCPIPFJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6398640", Offset = "0x6397040", VA = "0x186398640")]
	private static void CDBDGAKCJDI(Vector3 DBDBMNINDDA, Quaternion JPKHAJCCGHN, URPLight CMCKEGEJKAK, ImposterRenderConfig.LightConfig POEKIIAHOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x63991D0", Offset = "0x6397BD0", VA = "0x1863991D0")]
	public static void JHEEHGNFGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6399BC0", Offset = "0x63985C0", VA = "0x186399BC0")]
	private static void MPFEHLEOJBO(int MMCNAGFPDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x639A1D0", Offset = "0x6398BD0", VA = "0x18639A1D0")]
	public static void PAEIAHGELIK(ImposterRenderConfig FFJCPIPFJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6398950", Offset = "0x6397350", VA = "0x186398950")]
	public static void COFKBOJCBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x63992C0", Offset = "0x6397CC0", VA = "0x1863992C0")]
	public static void LAJPPPJCCLP(GameObject JLAHOFDPDHO, RenderTexture BJJLINOJGLF, ImposterRenderConfig FFJCPIPFJJL, MJHPJKJFLMI FGBPEMOFBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x63996C0", Offset = "0x63980C0", VA = "0x1863996C0")]
	private static void MAMPPDBNINJ(GameObject JLAHOFDPDHO, RenderTexture BJJLINOJGLF, ImposterRenderConfig FFJCPIPFJJL, MJHPJKJFLMI FGBPEMOFBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x639A350", Offset = "0x6398D50", VA = "0x18639A350")]
	private static void PFDNAMJBLED(GameObject JLAHOFDPDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x639A030", Offset = "0x6398A30", VA = "0x18639A030")]
	public static void ONMGPGGLOND(List<Renderer> ONOBCKNMBIK, List<Material> JJNDMAHMCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6398CD0", Offset = "0x63976D0", VA = "0x186398CD0")]
	public static void HPOHMAKPDLI(GameObject JFEEEILBEOO, Vector3 FNHOGBIJPDF, Vector3 KHNAHMOIPII, float CLHOCICFODB, MJHPJKJFLMI FGBPEMOFBPJ, out Vector3 CENENCFANBD, out Quaternion PALBDMIFFDB, out float CNNJOBFHFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6399F90", Offset = "0x6398990", VA = "0x186399F90")]
	public static RenderTexture OEIELEGHNDC(int BPPJIBCDENC, int GKJBEJDBHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6398FA0", Offset = "0x63979A0", VA = "0x186398FA0")]
	public static void INEEPPMJNEB()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct GPKPOPDJBHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AMHJHFKKEOP PKJCBGFLBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject ALHADEFMEIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture MLBHKPKDCLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig GLNHNLGPBGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public MJHPJKJFLMI MJHPJKJFLMI;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x639B930", Offset = "0x639A330", VA = "0x18639B930")]
			public GPKPOPDJBHF(AMHJHFKKEOP IOHGIBCLENJ, GameObject AJAELDDIPKD, RenderTexture BJJLINOJGLF, ImposterRenderConfig PPENNIKCHNM, MJHPJKJFLMI FGBPEMOFBPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::BMBCMIAHDIP<GPKPOPDJBHF, RenderTexture> CKLENELOFJE;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<GPKPOPDJBHF> LAFHMEBEBMA;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int IHMGMJMCKAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x639AC70", Offset = "0x6399670", VA = "0x18639AC70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x639AD80", Offset = "0x6399780", VA = "0x18639AD80")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject JLAHOFDPDHO, RenderTexture BJJLINOJGLF, ImposterRenderConfig FFJCPIPFJJL, MJHPJKJFLMI FGBPEMOFBPJ, CancellationToken KAKEKEHNCME, bool KBBFFIFBEEA = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x639A8B0", Offset = "0x63992B0", VA = "0x18639A8B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x639ACE0", Offset = "0x63996E0", VA = "0x18639ACE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x639AAA0", Offset = "0x63994A0", VA = "0x18639AAA0")]
		private static Task<RenderTexture> FLHJFLPKDHF(GPKPOPDJBHF OCPFDFJPBCJ, CancellationToken KAKEKEHNCME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x639B170", Offset = "0x6399B70", VA = "0x18639B170")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x639DBD0", Offset = "0x639C5D0", VA = "0x18639DBD0")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x639D880", Offset = "0x639C280", VA = "0x18639D880")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
