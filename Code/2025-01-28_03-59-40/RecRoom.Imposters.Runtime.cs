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
	private readonly struct CEEPFPBLPEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly DLGIINMANIH JKDJNJIGPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string OEOKJNDFNOG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
		public CEEPFPBLPEC(DLGIINMANIH ODHAIIBAEIG, string NCGFIKACHDK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FLODJMJJGKK : IAsyncStateMachine
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
		public CEEPFPBLPEC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x724DCE0", Offset = "0x724CEE0", VA = "0x18724DCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x724E0A0", Offset = "0x724D2A0", VA = "0x18724E0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider BBMINNDKADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EDPGFCJPADC<CEEPFPBLPEC, GameObject> CIMDBFBMAII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BNJEKKDEPAJ MAHFLCBCGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EDPGFCJPADC<CEEPFPBLPEC, GameObject> LEKNEEPPHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x724C8F0", Offset = "0x724BAF0", VA = "0x18724C8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int IJCOFFPLFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x724CB70", Offset = "0x724BD70", VA = "0x18724CB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x724C810", Offset = "0x724BA10", VA = "0x18724C810", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x724CD80", Offset = "0x724BF80", VA = "0x18724CD80", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x724CA50", Offset = "0x724BC50", VA = "0x18724CA50")]
	[AsyncStateMachine(typeof(FLODJMJJGKK))]
	private Task<GameObject> BMPOHHDNFHD(CEEPFPBLPEC ELFHLHMEJBG, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x724CBC0", Offset = "0x724BDC0", VA = "0x18724CBC0")]
	public Task<GameObject> LoadItemAsync(DLGIINMANIH ODHAIIBAEIG, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x724CDF0", Offset = "0x724BFF0", VA = "0x18724CDF0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GBNBLCOLDKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DLGIINMANIH BDHKCPDAAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture ICPFOAOAAIN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
		public GBNBLCOLDKJ(DLGIINMANIH GKAIAGFJIMM, Texture AANEOIBPLCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PMGJHBFLEJC
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
	private class OPLNDDNGKAG : ECADBOELABN<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DLBHJKGHODB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OPLNDDNGKAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x724B570", Offset = "0x724A770", VA = "0x18724B570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x724BD60", Offset = "0x724AF60", VA = "0x18724BD60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly DLGIINMANIH GKAIAGFJIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture DOOKDNAFKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig ALOPJHPBAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken BGEKICMONBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D CILBPNNOKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject OMJGHPAKEJJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override OABBPFFKNOC<Texture2D> NAOHIMNAEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7252770", Offset = "0x7251970", VA = "0x187252770", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> PAMDOONHJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7252970", Offset = "0x7251B70", VA = "0x187252970")]
		public OPLNDDNGKAG(DLGIINMANIH GKAIAGFJIMM, RenderTexture DOOKDNAFKKA, ImposterRenderConfig ALOPJHPBAJN, CancellationToken BGEKICMONBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7252880", Offset = "0x7251A80", VA = "0x187252880")]
		[AsyncStateMachine(typeof(DLBHJKGHODB))]
		private Task<Texture2D> NPEPKPHIMGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7252850", Offset = "0x7251A50", VA = "0x187252850", Slot = "10")]
		protected override void KIPPFLOHBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72527D0", Offset = "0x72519D0", VA = "0x1872527D0")]
		private static void KBPFGLLLCCI(GameObject OMJGHPAKEJJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OHEEGELIMNH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7251F30", Offset = "0x7251130", VA = "0x187251F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
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
	[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private PMGJHBFLEJC size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[CGOLJFLDDGE("size", PMGJHBFLEJC.Custom)]
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
	private static int KOICCNGKPPH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture PGAGGGBIJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LBBLGBCCJDK<GameObject> IHBCMILKPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FMIMELHPEBJ EHHELNDBAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource BCFACPBIPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private PDBMJMIDPNE<Texture2D> DPAHAINKDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private DLGIINMANIH NGMOKBMEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture FBMBPDFAEBF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int NJCGMGHNOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7251910", Offset = "0x7250B10", VA = "0x187251910")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7251960", Offset = "0x7250B60", VA = "0x187251960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture GPAOPEHADJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7250FE0", Offset = "0x72501E0", VA = "0x187250FE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0A0", Offset = "0x8FA2A0", VA = "0x1808FB0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private DLGIINMANIH BDHKCPDAAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F2210", Offset = "0x8F1410", VA = "0x1808F2210")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7251270", Offset = "0x7250470", VA = "0x187251270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool AEKKAIINMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1EB0110", Offset = "0x1EAF310", VA = "0x181EB0110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int AAIHIICIKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72513D0", Offset = "0x72505D0", VA = "0x1872513D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7250EE0", Offset = "0x72500E0", VA = "0x187250EE0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72514F0", Offset = "0x72506F0", VA = "0x1872514F0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250670", VA = "0x187251470")]
	private void MJGBLGFFDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72517F0", Offset = "0x72509F0", VA = "0x1872517F0")]
	public void Set(DLGIINMANIH NKGAKDOPJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72517E0", Offset = "0x72509E0", VA = "0x1872517E0")]
	public void Set(Texture AANEOIBPLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7251800", Offset = "0x7250A00", VA = "0x187251800")]
	public void Set(GBNBLCOLDKJ OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7250FD0", Offset = "0x72501D0", VA = "0x187250FD0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72515F0", Offset = "0x72507F0", VA = "0x1872515F0")]
	public void SetInternal(DLGIINMANIH NKGAKDOPJBL, [Optional] Texture OKDCEDHEJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72515E0", Offset = "0x72507E0", VA = "0x1872515E0")]
	public void SetCustomSize(int EFJAKEBLAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8FD8E0", Offset = "0x8FCAE0", VA = "0x1808FD8E0")]
	public void SetAntiAliasing(int IMHAJFDJCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72511C0", Offset = "0x72503C0", VA = "0x1872511C0")]
	[AsyncStateMachine(typeof(OHEEGELIMNH))]
	private void FJFOKBCOBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7250EF0", Offset = "0x72500F0", VA = "0x187250EF0")]
	private void CLLAANOLFAM(Texture AANEOIBPLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7251890", Offset = "0x7250A90", VA = "0x187251890")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, NAHJNGJEMGD
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float PMFAGFFPPPM = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
	public void PrepareImposter(DMABGGJGCHO HLJPDMABNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7250EA0", Offset = "0x72500A0", VA = "0x187250EA0")]
	public void SetReferencePoint(Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7250CB0", Offset = "0x724FEB0", VA = "0x187250CB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7250E80", Offset = "0x7250080", VA = "0x187250E80")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C05100", Offset = "0x1C04300", VA = "0x181C05100")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KPIKBBBODIG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static KPIKBBBODIG AFODENLOCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float AFLGPFFHLLE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x26FF130", Offset = "0x26FE330", VA = "0x1826FF130")]
	public KPIKBBBODIG(float EODNAECKEIH)
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
		[Cpp2IlInjected.Address(RVA = "0x7252DF0", Offset = "0x7251FF0", VA = "0x187252DF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
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
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int NIDCDAALNOG = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int NLBEGDIIOEL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> DBNOBIDAMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool AEPCHJBKFNC;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7251B80", Offset = "0x7250D80", VA = "0x187251B80")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7251A80", Offset = "0x7250C80", VA = "0x187251A80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7251DC0", Offset = "0x7250FC0", VA = "0x187251DC0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DLGIINMANIH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string FJGCHOPBGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KPIKBBBODIG KPIKBBBODIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EMEDCIOCNIO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DLAMJPJEMMH(CancellationToken BGEKICMONBE);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OKFJBPCDGCE(DLGIINMANIH JAINJPLCLDO);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGIMKCJKLJN();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBFGMDBLDJK();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JCODMEAELBC(uint? NKDBNHNGLBH, [Out] PDBMJMIDPNE<Texture2D> IMLHALIDDJH);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CNNALFKKNMO
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x724B330", Offset = "0x724A530", VA = "0x18724B330")]
	public static bool JGOCECFLFKE(DLGIINMANIH JDONINNCANM, DLGIINMANIH BCBHHJAONHH)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, NAHJNGJEMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x724B420", Offset = "0x724A620", VA = "0x18724B420", Slot = "4")]
		public void PrepareImposter(DMABGGJGCHO HLJPDMABNJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NAHJNGJEMGD
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(DMABGGJGCHO HLJPDMABNJO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FMIIIGMOIJC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> BJKACFKDKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> JFHHBICOEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BNJEKKDEPAJ
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFMPBMLBOGL(params Type[] BEPFEFGJEEM);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IFDGMIOIHEB(GameObject CJAMBKAOMGP, Transform DBEHKFODEEL, bool CDCFNKMJKMI = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T IFDGMIOIHEB<T>(T CJAMBKAOMGP, Transform DBEHKFODEEL, bool CDCFNKMJKMI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T IFDGMIOIHEB<T>(GameObject CJAMBKAOMGP, Transform DBEHKFODEEL, bool CDCFNKMJKMI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject IFDGMIOIHEB(GameObject CJAMBKAOMGP, Transform DBEHKFODEEL, DMABGGJGCHO HLJPDMABNJO, bool CDCFNKMJKMI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FJCJAODHLNN : IDisposable, BNJEKKDEPAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> PFPNAOBBKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> JPLHACKIOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform PCANNNLIFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> EMJPHFNODBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> LDDEJNMKBLD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x724CE30", Offset = "0x724C030", VA = "0x18724CE30")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	public static void BHMHEMCKFJH(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x724D8A0", Offset = "0x724CAA0", VA = "0x18724D8A0")]
	[UnityEngine.Scripting.Preserve]
	public FJCJAODHLNN([FMJHJHHALCB(null)] FMIIIGMOIJC GBCNFGNLDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x724CF20", Offset = "0x724C120", VA = "0x18724CF20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x724D850", Offset = "0x724CA50", VA = "0x18724D850", Slot = "5")]
	public void MFMPBMLBOGL(params Type[] BEPFEFGJEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x724D7C0", Offset = "0x724C9C0", VA = "0x18724D7C0", Slot = "6")]
	public GameObject IFDGMIOIHEB(GameObject CJAMBKAOMGP, Transform DBEHKFODEEL, bool CDCFNKMJKMI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3249AD0", Offset = "0x3248CD0", VA = "0x183249AD0", Slot = "7")]
	public T IFDGMIOIHEB<T>(T CJAMBKAOMGP, Transform DBEHKFODEEL, bool CDCFNKMJKMI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3249A80", Offset = "0x3248C80", VA = "0x183249A80", Slot = "8")]
	public T IFDGMIOIHEB<T>(GameObject CJAMBKAOMGP, Transform DBEHKFODEEL, bool CDCFNKMJKMI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x724D730", Offset = "0x724C930", VA = "0x18724D730", Slot = "9")]
	public GameObject IFDGMIOIHEB(GameObject CJAMBKAOMGP, Transform DBEHKFODEEL, DMABGGJGCHO HLJPDMABNJO, bool CDCFNKMJKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x324A1B0", Offset = "0x32493B0", VA = "0x18324A1B0", Slot = "10")]
	public T IFDGMIOIHEB<T>(GameObject CJAMBKAOMGP, Transform DBEHKFODEEL, DMABGGJGCHO HLJPDMABNJO, bool CDCFNKMJKMI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3249BB0", Offset = "0x3248DB0", VA = "0x183249BB0")]
	private T IFDGMIOIHEB<T>(GameObject CJAMBKAOMGP, Transform DBEHKFODEEL, DMABGGJGCHO HLJPDMABNJO, bool CDCFNKMJKMI, [Out] GameObject BGJAODCEBEN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x324A210", Offset = "0x3249410", VA = "0x18324A210")]
	private T NLIAHLHGACE<T>(GameObject GBMEGJCINPI, DMABGGJGCHO HLJPDMABNJO, bool CDCFNKMJKMI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x724D170", Offset = "0x724C370", VA = "0x18724D170")]
	private void EOCKHKBBKOE(Component DMLGABHGKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x724D280", Offset = "0x724C480", VA = "0x18724D280")]
	private void FCNAAMHKINO(Component DMLGABHGKII, DMABGGJGCHO HLJPDMABNJO, bool CDCFNKMJKMI, bool BMJIJDIEJNL, [Optional] Type FFLOODOGIJP, [Optional] Type KGKAECGEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x724D000", Offset = "0x724C200", VA = "0x18724D000")]
	private void EEHANPBCLON(GameObject GBMEGJCINPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DMABGGJGCHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> EILAHLIKNKJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x30F5F90", Offset = "0x30F5190", VA = "0x1830F5F90")]
	public DMABGGJGCHO CEJFMFJKFIE<T>(T LEIJLNIMLAN)
	{
		return default(DMABGGJGCHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x30F5E80", Offset = "0x30F5080", VA = "0x1830F5E80")]
	public T BGMHNJIJIDG<T>(T JEBHMGJFPIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x30F66C0", Offset = "0x30F58C0", VA = "0x1830F66C0")]
	public bool IDIICCOBMBP<T>([Out] T LEIJLNIMLAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GFOBOFDGCOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool ALBIGKFODOC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26FF1B0", Offset = "0x26FE3B0", VA = "0x1826FF1B0")]
	public GFOBOFDGCOP(bool IICDNMMNBND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct COFFMLECKOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool OPMDLPDLNGM;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x724B410", Offset = "0x724A610", VA = "0x18724B410")]
	public COFFMLECKOP(bool NILFJMLKLJK)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, NAHJNGJEMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7252B30", Offset = "0x7251D30", VA = "0x187252B30", Slot = "4")]
		public void PrepareImposter(DMABGGJGCHO HLJPDMABNJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
		public Bounds EPMODKMGBLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7250B20", Offset = "0x724FD20", VA = "0x187250B20")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7250AE0", Offset = "0x724FCE0", VA = "0x187250AE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7250AA0", Offset = "0x724FCA0", VA = "0x187250AA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72509B0", Offset = "0x724FBB0", VA = "0x1872509B0")]
		private void JNDJLJPGBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
				[Cpp2IlInjected.Address(RVA = "0x7251EA0", Offset = "0x72510A0", VA = "0x187251EA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7251E90", Offset = "0x7251090", VA = "0x187251E90")]
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
		[CGOLJFLDDGE("frameCameraToImposterBounds", true)]
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
		[CGOLJFLDDGE("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x72519E0", Offset = "0x7250BE0", VA = "0x1872519E0")]
		public void PHAPEIKBAOE(Vector3 FOODDIGJOOD, Quaternion CKNDCMLGGMA, float LNBHPHEFOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7251A10", Offset = "0x7250C10", VA = "0x187251A10")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class IICBPDILGJI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 EACEIKAIOLH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> BKOFALNMAGK;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> JJFADGDPFPO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera KPDMELCJCOP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> EFJKHAHKJFC;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> ONICCLJGCLA;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode CFOBKIDGHOK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color LKMCHKAIAGI;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color MJDJCKKFNHD;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color EHMEFBEEIKE;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap DDEAGECBHLG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool EOJOMOMDEJD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> NLIKBAOLOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x724E200", Offset = "0x724D400", VA = "0x18724E200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> CMFGLPOOLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x724E6E0", Offset = "0x724D8E0", VA = "0x18724E6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera GDBPCAGEDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7250530", Offset = "0x724F730", VA = "0x187250530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x724F1C0", Offset = "0x724E3C0", VA = "0x18724F1C0")]
	public static void JGMOILIJBMM(Vector3 NFDADPDJBIK, Quaternion LEFNGCIMCAE, ImposterRenderConfig EIHGCMGCELP, bool MPBHKHIMGJB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x724EEA0", Offset = "0x724E0A0", VA = "0x18724EEA0")]
	private static void HFNJHONEGFA(Vector3 NFDADPDJBIK, Quaternion LEFNGCIMCAE, URPLight MJGOHBPNNEO, ImposterRenderConfig.LightConfig AFCPOAOCBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x724E250", Offset = "0x724D450", VA = "0x18724E250")]
	public static void CAJOCHJELIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x724E730", Offset = "0x724D930", VA = "0x18724E730")]
	private static void FEHMONMPJIK(int NBNAMOFICNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7250360", Offset = "0x724F560", VA = "0x187250360")]
	public static void OOLLINBPKHN(ImposterRenderConfig EIHGCMGCELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x724E110", Offset = "0x724D310", VA = "0x18724E110")]
	public static void BHBONFLALJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x724EB60", Offset = "0x724DD60", VA = "0x18724EB60")]
	public static void GGLNIFJBAKK(GameObject OPGDJAHDOPH, RenderTexture DOOKDNAFKKA, ImposterRenderConfig EIHGCMGCELP, KPIKBBBODIG FNFLBLDKMKA, [Optional] Vector3? AAHFOANGNDM, [Optional] Vector3? EKCMLKONAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x724F7D0", Offset = "0x724E9D0", VA = "0x18724F7D0")]
	private static void MIPOMCGOLIM(GameObject OPGDJAHDOPH, RenderTexture DOOKDNAFKKA, ImposterRenderConfig EIHGCMGCELP, KPIKBBBODIG FNFLBLDKMKA, Vector3 AAHFOANGNDM, Vector3 EKCMLKONAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x724E330", Offset = "0x724D530", VA = "0x18724E330")]
	private static void CKNMABLHDIL(GameObject OPGDJAHDOPH, Vector3 PFOLLDJJHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x724F460", Offset = "0x724E660", VA = "0x18724F460")]
	public static void KOCDAFCFHGM(Bounds NCCJDEONGLP, ImposterRenderConfig EIHGCMGCELP, [Out] Vector3 LFCPDBICBAH, [Out] Quaternion CAHGGLHKHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x724FE30", Offset = "0x724F030", VA = "0x18724FE30")]
	private static void NLGFGBDHHCE(GameObject CJAMBKAOMGP, ImposterRenderConfig EIHGCMGCELP, KPIKBBBODIG FNFLBLDKMKA, [Out] Vector3 LFCPDBICBAH, [Out] Quaternion CAHGGLHKHCI, [Out] float KHIEFAJNNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x724E610", Offset = "0x724D810", VA = "0x18724E610")]
	public static RenderTexture CPHOIOJDKJF(int MPOEILOGHHP, int MBOBOHBNOJL, RenderTextureFormat HNCNCHKHLCP = RenderTextureFormat.ARGB32, string MAHOMAPBCKF = "[ImposterRendering]Preview")
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
		public struct MOJEGNPMBBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public LIKAJDLHHFB OCNCNAKDJOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject LLANJJDBLMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture GPAOPEHADJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig IMKDMJODGIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public KPIKBBBODIG KPIKBBBODIG;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7251EC0", Offset = "0x72510C0", VA = "0x187251EC0")]
			public MOJEGNPMBBB(LIKAJDLHHFB DDDDJFLMDFH, GameObject JPAAKPOFOMG, RenderTexture DOOKDNAFKKA, ImposterRenderConfig ALOPJHPBAJN, KPIKBBBODIG FNFLBLDKMKA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static EDPGFCJPADC<MOJEGNPMBBB, RenderTexture> CGGDAODHKLG;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<MOJEGNPMBBB> PHNMJICBKON;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int FDLOAMEGGJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x724C280", Offset = "0x724B480", VA = "0x18724C280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x724C3B0", Offset = "0x724B5B0", VA = "0x18724C3B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject OPGDJAHDOPH, RenderTexture DOOKDNAFKKA, ImposterRenderConfig EIHGCMGCELP, KPIKBBBODIG FNFLBLDKMKA, CancellationToken BGEKICMONBE, bool CBLFKMHLJEE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x724BDD0", Offset = "0x724AFD0", VA = "0x18724BDD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x724C310", Offset = "0x724B510", VA = "0x18724C310", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x724BFE0", Offset = "0x724B1E0", VA = "0x18724BFE0")]
		private static Task<RenderTexture> HKPCKIODNBP(MOJEGNPMBBB HOFGNNCNIGO, CancellationToken BGEKICMONBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x724C7D0", Offset = "0x724B9D0", VA = "0x18724C7D0")]
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
