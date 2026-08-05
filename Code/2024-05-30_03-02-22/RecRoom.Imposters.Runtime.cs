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
	private readonly struct OBFDPIHDMMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BAKNPHODEJB ENJICDCEGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BEDLHJMHALJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9FB690", Offset = "0x9FA890", VA = "0x1809FB690")]
		public OBFDPIHDMMH(BAKNPHODEJB HDMHCKEGNMB, string PPHBJCPFGOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FJENEPANINK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public OBFDPIHDMMH queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x641D3F0", Offset = "0x641C5F0", VA = "0x18641D3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x641D790", Offset = "0x641C990", VA = "0x18641D790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider OCEKIDJENBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AENNINMKNDN<OBFDPIHDMMH, GameObject> ECHGAHALBLM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FIJEANNBOFL OALEDGMFOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private AENNINMKNDN<OBFDPIHDMMH, GameObject> JMMICLJDNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x641CEB0", Offset = "0x641C0B0", VA = "0x18641CEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KFKOMJENIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x641D010", Offset = "0x641C210", VA = "0x18641D010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x641CDF0", Offset = "0x641BFF0", VA = "0x18641CDF0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x641D340", Offset = "0x641C540", VA = "0x18641D340", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x641D220", Offset = "0x641C420", VA = "0x18641D220")]
	[AsyncStateMachine(typeof(FJENEPANINK))]
	private Task<GameObject> NPEFKDABDKF(OBFDPIHDMMH CAAKGJDFAHC, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x641D060", Offset = "0x641C260", VA = "0x18641D060")]
	public Task<GameObject> LoadItemAsync(BAKNPHODEJB HDMHCKEGNMB, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x641D3B0", Offset = "0x641C5B0", VA = "0x18641D3B0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class IMKAMIDMDED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BAKNPHODEJB POOBOBDOPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture IAONGPPGIMB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7D1780", Offset = "0x7D0980", VA = "0x1807D1780")]
		public IMKAMIDMDED(BAKNPHODEJB APNCJHLKLAM, Texture LDDEKCHDPGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum CEDLLOIHHAE
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
	private class GEEELIBEPGJ : ECNPIIPAIGI<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AEJEKDCNPLI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GEEELIBEPGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6419390", Offset = "0x6418590", VA = "0x186419390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6419B90", Offset = "0x6418D90", VA = "0x186419B90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BAKNPHODEJB APNCJHLKLAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LPJMPHFBCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig DJMOMBDCJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken GILHKFNDIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject GOFLMGDCBGE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override PMIHBBCEMHD<Texture> LFOOOOGFCCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x641D880", Offset = "0x641CA80", VA = "0x18641D880", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> OEGABEHMNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x641D9E0", Offset = "0x641CBE0", VA = "0x18641D9E0")]
		public GEEELIBEPGJ(BAKNPHODEJB APNCJHLKLAM, RenderTexture LPJMPHFBCDJ, ImposterRenderConfig DJMOMBDCJAJ, CancellationToken GILHKFNDIJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x641D8F0", Offset = "0x641CAF0", VA = "0x18641D8F0")]
		[AsyncStateMachine(typeof(AEJEKDCNPLI))]
		private Task<Texture> PKCCPADALHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x641D8E0", Offset = "0x641CAE0", VA = "0x18641D8E0", Slot = "10")]
		protected override void HDCKBKCBCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x641D800", Offset = "0x641CA00", VA = "0x18641D800")]
		private static void DHMKIANAIJO(GameObject GOFLMGDCBGE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PDDIFHPJGNP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x64200A0", Offset = "0x641F2A0", VA = "0x1864200A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x939BD0", Offset = "0x938DD0", VA = "0x180939BD0", Slot = "5")]
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
	[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private CEDLLOIHHAE size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[DIPOKMHEBPI("size", CEDLLOIHHAE.Custom)]
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
	private static int INCNPLIIMCM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture OGPFBGDPKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EHOCENJJJJD<GameObject> ABHHGHJMELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GJCJPABGAJD BKNAEJBIFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource IDLLPIFDGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private AECHCDNEFCI<Texture> EDADCJBIIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BAKNPHODEJB DAIFLIJCPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture NMFBICJGDHI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int BCDFCAENLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x641EB10", Offset = "0x641DD10", VA = "0x18641EB10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x641EB60", Offset = "0x641DD60", VA = "0x18641EB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture HLGPBNAKGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x641E390", Offset = "0x641D590", VA = "0x18641E390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CE870", Offset = "0x7CDA70", VA = "0x1807CE870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BAKNPHODEJB POOBOBDOPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFC0", Offset = "0x7CB1C0", VA = "0x1807CBFC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x641E230", Offset = "0x641D430", VA = "0x18641E230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KBELFGCEHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x14B6F60", Offset = "0x14B6160", VA = "0x1814B6F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int LPHLNBDMFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x641E740", Offset = "0x641D940", VA = "0x18641E740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x641E0E0", Offset = "0x641D2E0", VA = "0x18641E0E0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x641E650", Offset = "0x641D850", VA = "0x18641E650")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x641E1B0", Offset = "0x641D3B0", VA = "0x18641E1B0")]
	private void IEFPJHPFPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x641E9F0", Offset = "0x641DBF0", VA = "0x18641E9F0")]
	public void Set(BAKNPHODEJB HPAIFPEFPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x641E9E0", Offset = "0x641DBE0", VA = "0x18641E9E0")]
	public void Set(Texture LDDEKCHDPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x641EA00", Offset = "0x641DC00", VA = "0x18641EA00")]
	public void Set(IMKAMIDMDED HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x641E0F0", Offset = "0x641D2F0", VA = "0x18641E0F0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x641E7F0", Offset = "0x641D9F0", VA = "0x18641E7F0")]
	public void SetInternal(BAKNPHODEJB HPAIFPEFPMI, [Optional] Texture KIGBCDJOIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x641E7E0", Offset = "0x641D9E0", VA = "0x18641E7E0")]
	public void SetCustomSize(int GMGJCJOFPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D47D0", Offset = "0x7D39D0", VA = "0x1807D47D0")]
	public void SetAntiAliasing(int CPPOJFIMDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x641E100", Offset = "0x641D300", VA = "0x18641E100")]
	[AsyncStateMachine(typeof(PDDIFHPJGNP))]
	private void DEDIADJKKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x641E570", Offset = "0x641D770", VA = "0x18641E570")]
	private void OLPPKEMJHCB(Texture LDDEKCHDPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x641EA90", Offset = "0x641DC90", VA = "0x18641EA90")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LBLAGCNCEBL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float COFMGELJNGA = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
	public void PrepareImposter(ANKCOGCBPAB EOHMOLAFOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x641E0A0", Offset = "0x641D2A0", VA = "0x18641E0A0")]
	public void SetReferencePoint(Vector3 HNNAMHMDPNC, Quaternion LNJHJGHHPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x641DEA0", Offset = "0x641D0A0", VA = "0x18641DEA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x641E080", Offset = "0x641D280", VA = "0x18641E080")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x152BB30", Offset = "0x152AD30", VA = "0x18152BB30")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DJIFHEOAFAO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static DJIFHEOAFAO PGIMGAJKBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float FPIGDEPBBPH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x205C060", Offset = "0x205B260", VA = "0x18205C060")]
	public DJIFHEOAFAO(float ICFALOGPCFH)
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
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int LBDIHPEKEEE = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int IFECINCBKKC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> IHCBEOKCNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool NFGKMMAMFAJ;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x641ED70", Offset = "0x641DF70", VA = "0x18641ED70")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x641EC70", Offset = "0x641DE70", VA = "0x18641EC70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x641EFC0", Offset = "0x641E1C0", VA = "0x18641EFC0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BAKNPHODEJB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string BPMLADPFEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DJIFHEOAFAO DJIFHEOAFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OMKIJBFOAAK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DELCJAFCHAA(CancellationToken GILHKFNDIJP);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FLLIPDNELFB(BAKNPHODEJB JPLJHFMPDFD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBNNLLIJIND();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEFPJIFFMFL();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DFIKAMCEILK([Out] AECHCDNEFCI<Texture> NLPMFENJKOF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LLLFENKKACH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x641F050", Offset = "0x641E250", VA = "0x18641F050")]
	public static bool EGNGPIIDCNA(BAKNPHODEJB MBHBINPJKBJ, BAKNPHODEJB FFOLDGBAMGF)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, LBLAGCNCEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6419C00", Offset = "0x6418E00", VA = "0x186419C00", Slot = "4")]
		public void PrepareImposter(ANKCOGCBPAB EOHMOLAFOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LBLAGCNCEBL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ANKCOGCBPAB EOHMOLAFOBC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PLIGMKPDHLD
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DIKKAJKPJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> PCAJFKHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FIJEANNBOFL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLCIAOAKEOC(params Type[] IAGPGLLOEJA);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject POHPEBIOJIO(GameObject PFEBHHJNIAE, Transform BGILIGANMHA, bool OEFAOMCFPIC = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T POHPEBIOJIO<T>(T PFEBHHJNIAE, Transform BGILIGANMHA, bool OEFAOMCFPIC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T POHPEBIOJIO<T>(GameObject PFEBHHJNIAE, Transform BGILIGANMHA, bool OEFAOMCFPIC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject POHPEBIOJIO(GameObject PFEBHHJNIAE, Transform BGILIGANMHA, ANKCOGCBPAB EOHMOLAFOBC, bool OEFAOMCFPIC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NBHFAHJOFOJ : IDisposable, FIJEANNBOFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> BBPDKPKDBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LGHLMOPFMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform OBDBFHFINKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> LKBEEELABHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BPLNNDPHKNO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x641F360", Offset = "0x641E560", VA = "0x18641F360")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	public static void KKAGNGKELMI(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x641FBF0", Offset = "0x641EDF0", VA = "0x18641FBF0")]
	[Preserve]
	public NBHFAHJOFOJ([KFHLAIGNCCH(null)] PLIGMKPDHLD EMJPNDMDOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x641F280", Offset = "0x641E480", VA = "0x18641F280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x641FA80", Offset = "0x641EC80", VA = "0x18641FA80", Slot = "5")]
	public void OLCIAOAKEOC(params Type[] IAGPGLLOEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x641FAD0", Offset = "0x641ECD0", VA = "0x18641FAD0", Slot = "6")]
	public GameObject POHPEBIOJIO(GameObject PFEBHHJNIAE, Transform BGILIGANMHA, bool OEFAOMCFPIC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2FB0", Offset = "0x2AC21B0", VA = "0x182AC2FB0", Slot = "7")]
	public T POHPEBIOJIO<T>(T PFEBHHJNIAE, Transform BGILIGANMHA, bool OEFAOMCFPIC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2AC35D0", Offset = "0x2AC27D0", VA = "0x182AC35D0", Slot = "8")]
	public T POHPEBIOJIO<T>(GameObject PFEBHHJNIAE, Transform BGILIGANMHA, bool OEFAOMCFPIC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x641FB60", Offset = "0x641ED60", VA = "0x18641FB60", Slot = "9")]
	public GameObject POHPEBIOJIO(GameObject PFEBHHJNIAE, Transform BGILIGANMHA, ANKCOGCBPAB EOHMOLAFOBC, bool OEFAOMCFPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3020", Offset = "0x2AC2220", VA = "0x182AC3020", Slot = "10")]
	public T POHPEBIOJIO<T>(GameObject PFEBHHJNIAE, Transform BGILIGANMHA, ANKCOGCBPAB EOHMOLAFOBC, bool OEFAOMCFPIC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3060", Offset = "0x2AC2260", VA = "0x182AC3060")]
	private T POHPEBIOJIO<T>(GameObject PFEBHHJNIAE, Transform BGILIGANMHA, ANKCOGCBPAB EOHMOLAFOBC, bool OEFAOMCFPIC, [Out] GameObject EKNKAGKBAAA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2B10", Offset = "0x2AC1D10", VA = "0x182AC2B10")]
	private T GOILFGNOGLC<T>(GameObject IIDBEBHLIGH, ANKCOGCBPAB EOHMOLAFOBC, bool OEFAOMCFPIC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x641F170", Offset = "0x641E370", VA = "0x18641F170")]
	private void AKCOCHAKKPF(Component NPBKACHANBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x641F5C0", Offset = "0x641E7C0", VA = "0x18641F5C0")]
	private void OALNNINMILM(Component NPBKACHANBH, ANKCOGCBPAB EOHMOLAFOBC, bool OEFAOMCFPIC, bool MLFPAENGHNA, [Optional] Type KPFDMMHBIIA, [Optional] Type NKHJOFAKPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x641F450", Offset = "0x641E650", VA = "0x18641F450")]
	private void LGHFHKKFHMF(GameObject IIDBEBHLIGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ANKCOGCBPAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> DCNODOCDPDP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3DB0", Offset = "0x2FF2FB0", VA = "0x182FF3DB0")]
	public ANKCOGCBPAB HNJFJKPNHAB<T>(T CKAHOFBBDHM)
	{
		return default(ANKCOGCBPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2FF44E0", Offset = "0x2FF36E0", VA = "0x182FF44E0")]
	public T JIBGFLOLNJM<T>(T AKBALOLNFML)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2FF35D0", Offset = "0x2FF27D0", VA = "0x182FF35D0")]
	public bool AAGKBFDKAOO<T>([Out] T CKAHOFBBDHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DLILFHLGPLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool HOLMJGFFLDE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xD65FE0", Offset = "0xD651E0", VA = "0x180D65FE0")]
	public DLILFHLGPLK(bool OEEKAEJGMJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LNLMHIFDICI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool PCEIMAIKEIK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x641F130", Offset = "0x641E330", VA = "0x18641F130")]
	public LNLMHIFDICI(bool FMHOBJEKMEH)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, LBLAGCNCEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64208A0", Offset = "0x641FAA0", VA = "0x1864208A0", Slot = "4")]
		public void PrepareImposter(ANKCOGCBPAB EOHMOLAFOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
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
		public Bounds HMBGBLIMFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x641DD10", Offset = "0x641CF10", VA = "0x18641DD10")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x641DCD0", Offset = "0x641CED0", VA = "0x18641DCD0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x641DC90", Offset = "0x641CE90", VA = "0x18641DC90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x641DBA0", Offset = "0x641CDA0", VA = "0x18641DBA0")]
		private void LCLGPNEACIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x641F150", Offset = "0x641E350", VA = "0x18641F150")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x641F140", Offset = "0x641E340", VA = "0x18641F140")]
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
		[Cpp2IlInjected.Address(RVA = "0x641EBE0", Offset = "0x641DDE0", VA = "0x18641EBE0")]
		public void DDLHPNJOEEK(Vector3 IJAFEPBNIOC, Quaternion LMNLDLMJDAJ, float IMPBJBNBLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x641EC10", Offset = "0x641DE10", VA = "0x18641EC10")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class DEAHOAICBKH
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 PCKCGPCNJDD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> HHHGHBKDCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> GBBJAHEPLGN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera LFHNGAHGGHO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> EIEJBAOPDHF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> DEPKBJMGCOC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode LHOHEBIBBCN;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color IKLEGOMNFKE;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color BBHJJDEEPPM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color HJOLIECKJJF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap KMCABOBMAIG;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool DGGMOCAONPO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> BLHLHLGAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x641B980", Offset = "0x641AB80", VA = "0x18641B980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> DFOHFPCDPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x641B5F0", Offset = "0x641A7F0", VA = "0x18641B5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera ADNFOPGHJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6419D50", Offset = "0x6418F50", VA = "0x186419D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x641BF90", Offset = "0x641B190", VA = "0x18641BF90")]
	public static void OMONIPKMHMH(Vector3 KFNHBHLHABN, Quaternion ANEAMACBBNJ, ImposterRenderConfig BOJDGLJJCBJ, bool HMGFECCOJEK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x641A6F0", Offset = "0x64198F0", VA = "0x18641A6F0")]
	private static void DIFLCAFAKIE(Vector3 KFNHBHLHABN, Quaternion ANEAMACBBNJ, URPLight FCJPFDJOMKA, ImposterRenderConfig.LightConfig CCPLOKFLHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x641A610", Offset = "0x6419810", VA = "0x18641A610")]
	public static void DFJPNCAKBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x641BAC0", Offset = "0x641ACC0", VA = "0x18641BAC0")]
	private static void NFLIEHOGDHD(int PBPLEBBNKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x641AA20", Offset = "0x6419C20", VA = "0x18641AA20")]
	public static void EJELMFNAHJG(ImposterRenderConfig BOJDGLJJCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x641B9D0", Offset = "0x641ABD0", VA = "0x18641B9D0")]
	public static void MDEBEJKFCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x641B640", Offset = "0x641A840", VA = "0x18641B640")]
	public static void HCMEOACMEGB(GameObject GIEAFFEGHCJ, RenderTexture LPJMPHFBCDJ, ImposterRenderConfig BOJDGLJJCBJ, DJIFHEOAFAO BDIFCIAJAFC, [Optional] Vector3? LNKHHEGEEMD, [Optional] Vector3? AHOOFEBKFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x641ABE0", Offset = "0x6419DE0", VA = "0x18641ABE0")]
	private static void FBKMMABKCHD(GameObject GIEAFFEGHCJ, RenderTexture LPJMPHFBCDJ, ImposterRenderConfig BOJDGLJJCBJ, DJIFHEOAFAO BDIFCIAJAFC, Vector3 LNKHHEGEEMD, Vector3 AHOOFEBKFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x641B230", Offset = "0x641A430", VA = "0x18641B230")]
	private static void FMCGGMJPIHL(GameObject GIEAFFEGHCJ, Vector3 MCBDOEINCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6419FA0", Offset = "0x64191A0", VA = "0x186419FA0")]
	private static void DDMGEHNCHMC(GameObject PFEBHHJNIAE, ImposterRenderConfig BOJDGLJJCBJ, DJIFHEOAFAO BDIFCIAJAFC, [Out] Vector3 MJJAJGHKGPP, [Out] Quaternion KECMHLNKCGO, [Out] float LNCNCKGOPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x641B520", Offset = "0x641A720", VA = "0x18641B520")]
	public static RenderTexture FMGPNOCDPAE(int BNEGPEKPMPM, int IPJDBOHPCBD, RenderTextureFormat IBEIMKOECHH = RenderTextureFormat.ARGB32, string CLJNMHBCLDE = "[ImposterRendering]Preview")
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
		public struct NPDIHPPCIKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public MFGPODLAJFB EDNADMBAIOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject KGCDEAHEKOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture HLGPBNAKGMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig CCLKLGDHEKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public DJIFHEOAFAO DJIFHEOAFAO;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6420030", Offset = "0x641F230", VA = "0x186420030")]
			public NPDIHPPCIKI(MFGPODLAJFB KNAMOHMAFIG, GameObject KMGFFGNKHJH, RenderTexture LPJMPHFBCDJ, ImposterRenderConfig DJMOMBDCJAJ, DJIFHEOAFAO BDIFCIAJAFC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static AENNINMKNDN<NPDIHPPCIKI, RenderTexture> HOOALJKKNKM;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<NPDIHPPCIKI> KIPHNJOGOAD;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int KKMPPAKOENH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x641C690", Offset = "0x641B890", VA = "0x18641C690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x641C990", Offset = "0x641BB90", VA = "0x18641C990")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GIEAFFEGHCJ, RenderTexture LPJMPHFBCDJ, ImposterRenderConfig BOJDGLJJCBJ, DJIFHEOAFAO BDIFCIAJAFC, CancellationToken GILHKFNDIJP, bool EFHOJOMCIPJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x641C4A0", Offset = "0x641B6A0", VA = "0x18641C4A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x641C8F0", Offset = "0x641BAF0", VA = "0x18641C8F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x641C700", Offset = "0x641B900", VA = "0x18641C700")]
		private static Task<RenderTexture> NGKOCINNOIB(NPDIHPPCIKI PCOCEDKCICJ, CancellationToken GILHKFNDIJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x641CDB0", Offset = "0x641BFB0", VA = "0x18641CDB0")]
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
