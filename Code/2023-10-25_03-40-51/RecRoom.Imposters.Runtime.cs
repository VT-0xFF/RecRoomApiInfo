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
	private readonly struct NMDFOBEPNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JCJPPKLJLBI GEBPKNIIBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string PHABGLMBMKP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E8680", Offset = "0x7E7480", VA = "0x1807E8680")]
		public NMDFOBEPNJK(JCJPPKLJLBI LBMLJMLACGM, string NPMILPHBDEH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MPJBEPDIAPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NMDFOBEPNJK queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C91BD0", Offset = "0x5C909D0", VA = "0x185C91BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C91F70", Offset = "0x5C90D70", VA = "0x185C91F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider HMKJKPLOBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EAHINCLEHCK<NMDFOBEPNJK, GameObject> KFKEHBNNPFB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EOHDEPDBCDD HLHNLODMIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EAHINCLEHCK<NMDFOBEPNJK, GameObject> CBKONANGOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F460", Offset = "0x5C8E260", VA = "0x185C8F460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BLLBPJGNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F8C0", Offset = "0x5C8E6C0", VA = "0x185C8F8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F3A0", Offset = "0x5C8E1A0", VA = "0x185C8F3A0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F910", Offset = "0x5C8E710", VA = "0x185C8F910", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F5C0", Offset = "0x5C8E3C0", VA = "0x185C8F5C0")]
	[AsyncStateMachine(typeof(MPJBEPDIAPA))]
	private Task<GameObject> ECIDLNDLDOA(NMDFOBEPNJK HBPDKMJJHEB, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F6E0", Offset = "0x5C8E4E0", VA = "0x185C8F6E0")]
	public Task<GameObject> LoadItemAsync(JCJPPKLJLBI LBMLJMLACGM, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F980", Offset = "0x5C8E780", VA = "0x185C8F980")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BLLBECILKOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JCJPPKLJLBI APBGBEIHDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture CKIBKHHMOCP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
		public BLLBECILKOB(JCJPPKLJLBI ONDFDANHNPI, Texture CDDHIOBHLIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ANLPLGKLBIK
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
	private class EHFABKOFFLB : FBMLADGOGPH<Texture>, ADANMMDOODE, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IDBCHIFPAAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public EHFABKOFFLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5C8FD90", Offset = "0x5C8EB90", VA = "0x185C8FD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5C905A0", Offset = "0x5C8F3A0", VA = "0x185C905A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly JCJPPKLJLBI ONDFDANHNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture GABLAMGMIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig GMGFJKLPGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken BCCDJHNACKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject OPAAEOPKJGG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MIDEJKJPMAF<Texture> BIICJKKNKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5C8FAB0", Offset = "0x5C8E8B0", VA = "0x185C8FAB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> PHPPCBHMGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C8FBA0", Offset = "0x5C8E9A0", VA = "0x185C8FBA0")]
		public EHFABKOFFLB(JCJPPKLJLBI ONDFDANHNPI, RenderTexture GABLAMGMIAK, ImposterRenderConfig GMGFJKLPGDO, CancellationToken BCCDJHNACKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F9C0", Offset = "0x5C8E7C0", VA = "0x185C8F9C0")]
		[AsyncStateMachine(typeof(IDBCHIFPAAG))]
		private Task<Texture> CPFKBMONJJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5C8FB10", Offset = "0x5C8E910", VA = "0x185C8FB10", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5C8FB20", Offset = "0x5C8E920", VA = "0x185C8FB20")]
		private static void EPMNMEBOGLF(GameObject OPAAEOPKJGG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AIFECGHADIJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5C8C080", Offset = "0x5C8AE80", VA = "0x185C8C080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x865C40", Offset = "0x864A40", VA = "0x180865C40", Slot = "5")]
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
	[DBHJNHHAHKH(PBHAFHEAPLG.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private ANLPLGKLBIK size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[GFGHIIBEPCI("size", ANLPLGKLBIK.Custom)]
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
	private static int ELEFBINONMO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture EOPIMIPMAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PGMGLGALHLH<GameObject> HNGHGIPMPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GJDHHHJOJJP JFOMKIMDPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource AJBHEMPONAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FBMLADGOGPH<Texture> GMBAIGCHJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private JCJPPKLJLBI GJNGLINFLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture BEPPENJALBB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int EDMFNAICIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C91560", Offset = "0x5C90360", VA = "0x185C91560")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C915B0", Offset = "0x5C903B0", VA = "0x185C915B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KHELIENPPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C90E60", Offset = "0x5C8FC60", VA = "0x185C90E60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x765490", Offset = "0x764290", VA = "0x180765490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JCJPPKLJLBI APBGBEIHDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x760F30", Offset = "0x75FD30", VA = "0x180760F30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C90B50", Offset = "0x5C8F950", VA = "0x185C90B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool AHJKLECFLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E658C0", Offset = "0x4E646C0", VA = "0x184E658C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GCNPGBAPEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C91010", Offset = "0x5C8FE10", VA = "0x185C91010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C90CB0", Offset = "0x5C8FAB0", VA = "0x185C90CB0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C91130", Offset = "0x5C8FF30", VA = "0x185C91130")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C910B0", Offset = "0x5C8FEB0", VA = "0x185C910B0")]
	private void OHNGKGBOBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C91440", Offset = "0x5C90240", VA = "0x185C91440")]
	public void Set(JCJPPKLJLBI PDAMPMHGNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C91430", Offset = "0x5C90230", VA = "0x185C91430")]
	public void Set(Texture CDDHIOBHLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C91450", Offset = "0x5C90250", VA = "0x185C91450")]
	public void Set(BLLBECILKOB POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C90E50", Offset = "0x5C8FC50", VA = "0x185C90E50")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C91230", Offset = "0x5C90030", VA = "0x185C91230")]
	public void SetInternal(JCJPPKLJLBI PDAMPMHGNBG, [Optional] Texture ACLGCFFAFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C91220", Offset = "0x5C90020", VA = "0x185C91220")]
	public void SetCustomSize(int GIEOAAGPJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x769300", Offset = "0x768100", VA = "0x180769300")]
	public void SetAntiAliasing(int CEALBJHJHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C90DA0", Offset = "0x5C8FBA0", VA = "0x185C90DA0")]
	[AsyncStateMachine(typeof(AIFECGHADIJ))]
	private void CANFECEDJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C90CC0", Offset = "0x5C8FAC0", VA = "0x185C90CC0")]
	private void BICLIKCBFOD(Texture CDDHIOBHLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C914E0", Offset = "0x5C902E0", VA = "0x185C914E0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, MHLJIBMDIJF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float BPGLOHMOCCN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	public void PrepareImposter(FJAAGPLJEBH APKDPMMLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C90B10", Offset = "0x5C8F910", VA = "0x185C90B10")]
	public void SetReferencePoint(Vector3 BBEJKAIJGPI, Quaternion IOMLNAOLLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5C90910", Offset = "0x5C8F710", VA = "0x185C90910")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5C90AF0", Offset = "0x5C8F8F0", VA = "0x185C90AF0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1304BB0", Offset = "0x13039B0", VA = "0x181304BB0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JLJBKPABAHM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static JLJBKPABAHM APECAFIOBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float LFBNGLKLIBO;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F4F770", Offset = "0x1F4E570", VA = "0x181F4F770")]
	public JLJBKPABAHM(float OGCOIPKEEEH)
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
		[DBHJNHHAHKH(PBHAFHEAPLG.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int IFMJILCHBGL = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MOALLLPHGGK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> BGDIJECNMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool CNAIEJHLJJH;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C91790", Offset = "0x5C90590", VA = "0x185C91790")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5C91690", Offset = "0x5C90490", VA = "0x185C91690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5C919D0", Offset = "0x5C907D0", VA = "0x185C919D0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JCJPPKLJLBI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string BEFDFMLFIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JLJBKPABAHM JLJBKPABAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IBGOPAIKCGL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> KFLFNECHCMG(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LPCEPMDACBO(JCJPPKLJLBI LKMMHIOOCMN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPMKIPHDJIL();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMHCFENNKID();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PIEKIBCPKBN([Out] FBMLADGOGPH<Texture> MCKIGDCPMIP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JLLDACCJIFM
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C91AA0", Offset = "0x5C908A0", VA = "0x185C91AA0")]
	public static bool JICLJDPFNJP(JCJPPKLJLBI PBKNIMIBPDO, JCJPPKLJLBI AOJLPFAJLLH)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, MHLJIBMDIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C820", Offset = "0x5C8B620", VA = "0x185C8C820", Slot = "4")]
		public void PrepareImposter(FJAAGPLJEBH APKDPMMLKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MHLJIBMDIJF
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(FJAAGPLJEBH APKDPMMLKGB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PCFOINMIHPG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NIOPLPNMICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> EHIFNNGFLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EOHDEPDBCDD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject KLNAMDGKPMA(GameObject LHMPGCOFOMN, Transform LPDGANJNOMK, bool NMOFBMNFGOH = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T KLNAMDGKPMA<T>(T LHMPGCOFOMN, Transform LPDGANJNOMK, bool NMOFBMNFGOH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T KLNAMDGKPMA<T>(GameObject LHMPGCOFOMN, Transform LPDGANJNOMK, bool NMOFBMNFGOH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject KLNAMDGKPMA(GameObject LHMPGCOFOMN, Transform LPDGANJNOMK, FJAAGPLJEBH APKDPMMLKGB, bool NMOFBMNFGOH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AGCOGLGCOBP : IDisposable, EOHDEPDBCDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> KJIOANDLBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> JDHCCDHOPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform GKDCDOAMGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> OFJCAHCIIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BIIILANGJKE;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B9D0", Offset = "0x5C8A7D0", VA = "0x185C8B9D0")]
	[DJDJPHIPNFL(IEJLPKKICHC.None)]
	public static void LKBEDIJGOEL(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C8BC40", Offset = "0x5C8AA40", VA = "0x185C8BC40")]
	[Preserve]
	public AGCOGLGCOBP([FGPOJKOJBFM(null)] PCFOINMIHPG GDLMODBBPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B6C0", Offset = "0x5C8A4C0", VA = "0x185C8B6C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B8B0", Offset = "0x5C8A6B0", VA = "0x185C8B8B0", Slot = "5")]
	public GameObject KLNAMDGKPMA(GameObject LHMPGCOFOMN, Transform LPDGANJNOMK, bool NMOFBMNFGOH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x29BDBF0", Offset = "0x29BC9F0", VA = "0x1829BDBF0", Slot = "6")]
	public T KLNAMDGKPMA<T>(T LHMPGCOFOMN, Transform LPDGANJNOMK, bool NMOFBMNFGOH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29BDC60", Offset = "0x29BCA60", VA = "0x1829BDC60", Slot = "7")]
	public T KLNAMDGKPMA<T>(GameObject LHMPGCOFOMN, Transform LPDGANJNOMK, bool NMOFBMNFGOH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B940", Offset = "0x5C8A740", VA = "0x185C8B940", Slot = "8")]
	public GameObject KLNAMDGKPMA(GameObject LHMPGCOFOMN, Transform LPDGANJNOMK, FJAAGPLJEBH APKDPMMLKGB, bool NMOFBMNFGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29BE200", Offset = "0x29BD000", VA = "0x1829BE200", Slot = "9")]
	public T KLNAMDGKPMA<T>(GameObject LHMPGCOFOMN, Transform LPDGANJNOMK, FJAAGPLJEBH APKDPMMLKGB, bool NMOFBMNFGOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29BDC90", Offset = "0x29BCA90", VA = "0x1829BDC90")]
	private T KLNAMDGKPMA<T>(GameObject LHMPGCOFOMN, Transform LPDGANJNOMK, FJAAGPLJEBH APKDPMMLKGB, bool NMOFBMNFGOH, [Out] GameObject JHLJCPBALBA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29BD750", Offset = "0x29BC550", VA = "0x1829BD750")]
	private T CIBEGBFFBOO<T>(GameObject LEMKPNELLPI, FJAAGPLJEBH APKDPMMLKGB, bool NMOFBMNFGOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B7A0", Offset = "0x5C8A5A0", VA = "0x185C8B7A0")]
	private void IHONHGLLJDF(Component KDELPFFKINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B1E0", Offset = "0x5C89FE0", VA = "0x185C8B1E0")]
	private void DBNPKMKHOGA(Component KDELPFFKINA, FJAAGPLJEBH APKDPMMLKGB, bool NMOFBMNFGOH, bool EAJDAAJLOEM, [Optional] Type AJIEIKNEKEE, [Optional] Type HIDJLGKNDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C8BAD0", Offset = "0x5C8A8D0", VA = "0x185C8BAD0")]
	private void OMBJEKLMBLB(GameObject LEMKPNELLPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FJAAGPLJEBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> DBMHHFGNDGG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2390970", Offset = "0x238F770", VA = "0x182390970")]
	public FJAAGPLJEBH MFACMGCFCOL<T>(T EKJPDPAKGON)
	{
		return default(FJAAGPLJEBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2390090", Offset = "0x238EE90", VA = "0x182390090")]
	public T HAMDPAFEPLN<T>(T PPFOBEPKLDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23901A0", Offset = "0x238EFA0", VA = "0x1823901A0")]
	public bool HBHBLNKJFLH<T>([Out] T EKJPDPAKGON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IFCBECEHLKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool EGMLLHIDFFI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xB50F00", Offset = "0xB4FD00", VA = "0x180B50F00")]
	public IFCBECEHLKF(bool LGIJAELGOKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KOHOBOOKIME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool NDJKNIMFGHP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C91B90", Offset = "0x5C90990", VA = "0x185C91B90")]
	public KOHOBOOKIME(bool FBKIOPGJKPD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, MHLJIBMDIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5C91FE0", Offset = "0x5C90DE0", VA = "0x185C91FE0", Slot = "4")]
		public void PrepareImposter(FJAAGPLJEBH APKDPMMLKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
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
		public Bounds PBGGDELIEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5C90780", Offset = "0x5C8F580", VA = "0x185C90780")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5C90740", Offset = "0x5C8F540", VA = "0x185C90740")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5C90700", Offset = "0x5C8F500", VA = "0x185C90700")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5C90610", Offset = "0x5C8F410", VA = "0x185C90610")]
		private void NALLJHIOMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5C91BB0", Offset = "0x5C909B0", VA = "0x185C91BB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5C91BA0", Offset = "0x5C909A0", VA = "0x185C91BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C91630", Offset = "0x5C90430", VA = "0x185C91630")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class DFLLIILOCEB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> PNCFOAHMFOC;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 LKHAFDOLCAP;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 CCCDLNFDLCG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera MKOPJKLHHNC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> OILKFBDPOGO;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> AMEINFEFFHC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode JGFOINENDCB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color MNFKAAKFEAL;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color NBKLJPJCJNO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color HFOCJMNJJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap BDALKHDHCPH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool LDIBOANCGOL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera LPFIOIHLPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5C8CC10", Offset = "0x5C8BA10", VA = "0x185C8CC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5C8DED0", Offset = "0x5C8CCD0", VA = "0x185C8DED0")]
	public static void FAEDCKEEJFB(Vector3 KGOGDEFPFOD, Quaternion DEBEGMJACOG, ImposterRenderConfig INPBIHJJOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E140", Offset = "0x5C8CF40", VA = "0x185C8E140")]
	private static void FGHOPEKBNPO(Vector3 KGOGDEFPFOD, Quaternion DEBEGMJACOG, URPLight MJKIBPJKHBI, ImposterRenderConfig.LightConfig MPCKNKODCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E7D0", Offset = "0x5C8D5D0", VA = "0x185C8E7D0")]
	public static void OLKHOACNGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5C8DB50", Offset = "0x5C8C950", VA = "0x185C8DB50")]
	private static void DJFKOAOGBCA(int NFAAMGJAOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E470", Offset = "0x5C8D270", VA = "0x185C8E470")]
	public static void FNPBHGKACPN(ImposterRenderConfig INPBIHJJOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E6E0", Offset = "0x5C8D4E0", VA = "0x185C8E6E0")]
	public static void KPBNAACCPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5C8D980", Offset = "0x5C8C780", VA = "0x185C8D980")]
	public static void DHIMDCLCBEB(GameObject CLLHBLGLMPM, RenderTexture GABLAMGMIAK, ImposterRenderConfig INPBIHJJOBG, JLJBKPABAHM GMHEJJONJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5C8D3A0", Offset = "0x5C8C1A0", VA = "0x185C8D3A0")]
	private static void DEOIBKLJNOJ(GameObject CLLHBLGLMPM, RenderTexture GABLAMGMIAK, ImposterRenderConfig INPBIHJJOBG, JLJBKPABAHM GMHEJJONJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5C8C970", Offset = "0x5C8B770", VA = "0x185C8C970")]
	private static void AJCFMIHKDKE(GameObject CLLHBLGLMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5C8CE20", Offset = "0x5C8BC20", VA = "0x185C8CE20")]
	public static void CIGLJECKMHE(GameObject LHMPGCOFOMN, Vector3 MDBPGLIICPG, Vector3 PNFPNKFJOPL, float FENPCPMEHLC, JLJBKPABAHM GMHEJJONJNM, [Out] Vector3 HFLIBCMFFAJ, [Out] Quaternion NPHFGHCPAFB, [Out] float GKKFHGDDNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5C8E630", Offset = "0x5C8D430", VA = "0x185C8E630")]
	public static RenderTexture HGNIAEKOKPG(int IDHAPBPJELB, int EBEJFDNBBNK, RenderTextureFormat GEACENBCPHD = RenderTextureFormat.ARGB32)
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
		public struct FDAAJIGNILD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public OGKAMIBOIGC GCNMAINMAHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject CIPOALKJNMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture KHELIENPPCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig LELNODIFNFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public JLJBKPABAHM JLJBKPABAHM;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5C8FD20", Offset = "0x5C8EB20", VA = "0x185C8FD20")]
			public FDAAJIGNILD(OGKAMIBOIGC CJGEKBJNNGI, GameObject MFNEOILJCCL, RenderTexture GABLAMGMIAK, ImposterRenderConfig GMGFJKLPGDO, JLJBKPABAHM GMHEJJONJNM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static EAHINCLEHCK<FDAAJIGNILD, RenderTexture> DEOALHMKMIG;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<FDAAJIGNILD> IIJHPCDHPPD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int LHFEHIMBPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5C8EE30", Offset = "0x5C8DC30", VA = "0x185C8EE30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5C8EF40", Offset = "0x5C8DD40", VA = "0x185C8EF40")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject CLLHBLGLMPM, RenderTexture GABLAMGMIAK, ImposterRenderConfig INPBIHJJOBG, JLJBKPABAHM GMHEJJONJNM, CancellationToken BCCDJHNACKO, bool LBBIOGMBIFK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5C8EC40", Offset = "0x5C8DA40", VA = "0x185C8EC40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5C8EEA0", Offset = "0x5C8DCA0", VA = "0x185C8EEA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5C8EAA0", Offset = "0x5C8D8A0", VA = "0x185C8EAA0")]
		private static Task<RenderTexture> AHIDOIOBIIC(FDAAJIGNILD OJAJDOPFMND, CancellationToken BCCDJHNACKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F360", Offset = "0x5C8E160", VA = "0x185C8F360")]
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
