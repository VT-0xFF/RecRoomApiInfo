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
	private readonly struct ICPOJEILGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly FPCBBBFKJII JBIFGPDNDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string NDGMEGMCDLN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
		public ICPOJEILGOC(FPCBBBFKJII MOLBKPCAKLP, string CLCFMOIOBPJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct PAHDDMMMKDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public ICPOJEILGOC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3FB0", Offset = "0x5CE33B0", VA = "0x185CE3FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4350", Offset = "0x5CE3750", VA = "0x185CE4350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider GIHICBAJLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LNPBAIDMOIO<ICPOJEILGOC, GameObject> BJBLHMFECLM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HPOHNLNBPPJ JOCNHPHMHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LNPBAIDMOIO<ICPOJEILGOC, GameObject> NBAFENOCNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CDFEF0", Offset = "0x5CDF2F0", VA = "0x185CDFEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int EODHJHFDOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0050", Offset = "0x5CDF450", VA = "0x185CE0050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CDFD10", Offset = "0x5CDF110", VA = "0x185CDFD10", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0280", Offset = "0x5CDF680", VA = "0x185CE0280", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CDFDD0", Offset = "0x5CDF1D0", VA = "0x185CDFDD0")]
	[AsyncStateMachine(typeof(PAHDDMMMKDG))]
	private Task<GameObject> BKCJLNIFPNJ(ICPOJEILGOC CNDKIBKPMFB, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CE00A0", Offset = "0x5CDF4A0", VA = "0x185CE00A0")]
	public Task<GameObject> LoadItemAsync(FPCBBBFKJII MOLBKPCAKLP, CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CE02F0", Offset = "0x5CDF6F0", VA = "0x185CE02F0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MFOIAOHCMOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FPCBBBFKJII PBAPONNLGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly Texture PAMENHACOPL;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
		public MFOIAOHCMOI(FPCBBBFKJII LPLOBEMAMGI, Texture AMKNJHJDPEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum JHEFJCCFCBH
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class HNNFDJPFOCO : EGHLOMAONPH<Texture>, CMAKBFCDDAC, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AAJCFBNEILL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public HNNFDJPFOCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CDDBA0", Offset = "0x5CDCFA0", VA = "0x185CDDBA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5CDE3B0", Offset = "0x5CDD7B0", VA = "0x185CDE3B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly FPCBBBFKJII LPLOBEMAMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly RenderTexture OLBHHJAPDNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly ImposterRenderConfig IBCMAEBNIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly CancellationToken OMFABMCIOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private GameObject NNEOJNFIGGD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public DMGBOCKAFMH<Texture> MFLOPLPPDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CE2970", Offset = "0x5CE1D70", VA = "0x185CE2970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> OANGHOAEDFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2B50", Offset = "0x5CE1F50", VA = "0x185CE2B50")]
		public HNNFDJPFOCO(FPCBBBFKJII LPLOBEMAMGI, RenderTexture OLBHHJAPDNM, ImposterRenderConfig IBCMAEBNIJA, CancellationToken OMFABMCIOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CE29E0", Offset = "0x5CE1DE0", VA = "0x185CE29E0")]
		[AsyncStateMachine(typeof(AAJCFBNEILL))]
		private Task<Texture> NBOEKGJPBAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5CE29D0", Offset = "0x5CE1DD0", VA = "0x185CE29D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2AD0", Offset = "0x5CE1ED0", VA = "0x185CE2AD0")]
		private static void NIOCBGGLACH(GameObject NNEOJNFIGGD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EABNCBILBFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE0330", Offset = "0x5CDF730", VA = "0x185CE0330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82FC80", Offset = "0x82F080", VA = "0x18082FC80", Slot = "5")]
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
	[BEGIBHGLGBK(OECFEFOEJFL.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	[SerializeField]
	private JHEFJCCFCBH size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[PPLPIHAJNHD("size", JHEFJCCFCBH.Custom)]
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
	private static int BDJACGFPEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private RenderTexture OKGAPJBPLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EPBBCOJLICB<GameObject> BJPIDDNMAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private KBDGBPHCLNK POIMNLNPBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private CancellationTokenSource HFJACFBDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private EGHLOMAONPH<Texture> CBOKMPOIKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private FPCBBBFKJII EBONNFINAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Texture FPIKLDIKDJD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int CGMHHBJCAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE38D0", Offset = "0x5CE2CD0", VA = "0x185CE38D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3920", Offset = "0x5CE2D20", VA = "0x185CE3920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture IHLHCIHEDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3060", Offset = "0x5CE2460", VA = "0x185CE3060")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x767710", Offset = "0x766B10", VA = "0x180767710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private FPCBBBFKJII PBAPONNLGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7665C0", Offset = "0x7659C0", VA = "0x1807665C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CE31D0", Offset = "0x5CE25D0", VA = "0x185CE31D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KGMDJMNBMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4EED4A0", Offset = "0x4EEC8A0", VA = "0x184EED4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int NPLBFKHDBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3330", Offset = "0x5CE2730", VA = "0x185CE3330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2F10", Offset = "0x5CE2310", VA = "0x185CE2F10")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CE34B0", Offset = "0x5CE28B0", VA = "0x185CE34B0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2FE0", Offset = "0x5CE23E0", VA = "0x185CE2FE0")]
	private void DFFOODLCJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CE37B0", Offset = "0x5CE2BB0", VA = "0x185CE37B0")]
	public void Set(FPCBBBFKJII MDFIPGCHIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CE37C0", Offset = "0x5CE2BC0", VA = "0x185CE37C0")]
	public void Set(Texture AMKNJHJDPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE37D0", Offset = "0x5CE2BD0", VA = "0x185CE37D0")]
	public void Set(MFOIAOHCMOI LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2F20", Offset = "0x5CE2320", VA = "0x185CE2F20")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE35B0", Offset = "0x5CE29B0", VA = "0x185CE35B0")]
	public void SetInternal(FPCBBBFKJII MDFIPGCHIHB, [Optional] Texture HNNKAAEHLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE35A0", Offset = "0x5CE29A0", VA = "0x185CE35A0")]
	public void SetCustomSize(int JCFBCMIPCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x76DDC0", Offset = "0x76D1C0", VA = "0x18076DDC0")]
	public void SetAntiAliasing(int PBHMFNOPFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2F30", Offset = "0x5CE2330", VA = "0x185CE2F30")]
	[AsyncStateMachine(typeof(EABNCBILBFK))]
	private void DBPNEFHLFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CE33D0", Offset = "0x5CE27D0", VA = "0x185CE33D0")]
	private void NLALFFOCGKC(Texture AMKNJHJDPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3850", Offset = "0x5CE2C50", VA = "0x185CE3850")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, JNGKKLJECCH
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const float MFDEOLANBLL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	public void PrepareImposter(EJKNJLMAAHP OJJNHGGGKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2ED0", Offset = "0x5CE22D0", VA = "0x185CE2ED0")]
	public void SetReferencePoint(Vector3 EDOEDBAJLGN, Quaternion ALNLHNLOHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2CD0", Offset = "0x5CE20D0", VA = "0x185CE2CD0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2EB0", Offset = "0x5CE22B0", VA = "0x185CE2EB0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x12C67F0", Offset = "0x12C5BF0", VA = "0x1812C67F0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KMLIFMJKAHI
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static KMLIFMJKAHI IJLDPPIOPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float HBJGKBPAIAL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1ED6810", Offset = "0x1ED5C10", VA = "0x181ED6810")]
	public KMLIFMJKAHI(float JHDAILNBCLD)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[BEGIBHGLGBK(OECFEFOEJFL.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int EGFFKEHKMEI = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int PCPKGOAJOFF = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly List<Material> LDNHLFJCLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool IKDPBNOCOAG;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3B00", Offset = "0x5CE2F00", VA = "0x185CE3B00")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3A00", Offset = "0x5CE2E00", VA = "0x185CE3A00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3D40", Offset = "0x5CE3140", VA = "0x185CE3D40")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FPCBBBFKJII
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string CIJDADPMEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KMLIFMJKAHI KMLIFMJKAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PMADIAAFFCF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> LFKLPLMODHJ(CancellationToken OMFABMCIOAC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ENCCMEAEGLN(FPCBBBFKJII KEEHOGPOIFD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLPCDHAOIEA();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MCLPEMIKHLG();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HPIDGLEABLL([Out] EGHLOMAONPH<Texture> CALGDKMBJGA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KAHHGFHLAAB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3DE0", Offset = "0x5CE31E0", VA = "0x185CE3DE0")]
	public static bool ICNLCNDDBDA(FPCBBBFKJII DDKFPMJIGGO, FPCBBBFKJII FBECMPFIJGE)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, JNGKKLJECCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF2C0", Offset = "0x5CDE6C0", VA = "0x185CDF2C0", Slot = "4")]
		public void PrepareImposter(EJKNJLMAAHP OJJNHGGGKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JNGKKLJECCH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EJKNJLMAAHP OJJNHGGGKOD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HDNEOPJJKDO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> LIGLBAPJLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HJILKGCGMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HPOHNLNBPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject KEIDMBADJBC(GameObject BDNIDEKLIGD, Transform DCLCDDGJKIC, bool APPFELHKFLC = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T KEIDMBADJBC<T>(T BDNIDEKLIGD, Transform DCLCDDGJKIC, bool APPFELHKFLC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T KEIDMBADJBC<T>(GameObject BDNIDEKLIGD, Transform DCLCDDGJKIC, bool APPFELHKFLC = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject KEIDMBADJBC(GameObject BDNIDEKLIGD, Transform DCLCDDGJKIC, EJKNJLMAAHP OJJNHGGGKOD, bool APPFELHKFLC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AMPKBJIPAGK : IDisposable, HPOHNLNBPPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> MEKCCHLBGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> KCELEJCDNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Transform LIFEIEJIIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<Component> OMCHDANPGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DGCJCAJEMOF;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE500", Offset = "0x5CDD900", VA = "0x185CDE500")]
	[DCEDJGMCFCN(IIPPAMCLFBJ.None)]
	public static void KAGIJELEALE(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEE80", Offset = "0x5CDE280", VA = "0x185CDEE80")]
	[Preserve]
	public AMPKBJIPAGK([LMAFJMDCBJO(null)] HDNEOPJJKDO HEIFGKHJMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE420", Offset = "0x5CDD820", VA = "0x185CDE420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEAE0", Offset = "0x5CDDEE0", VA = "0x185CDEAE0", Slot = "5")]
	public GameObject KEIDMBADJBC(GameObject BDNIDEKLIGD, Transform DCLCDDGJKIC, bool APPFELHKFLC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x29F3BD0", Offset = "0x29F2FD0", VA = "0x1829F3BD0", Slot = "6")]
	public T KEIDMBADJBC<T>(T BDNIDEKLIGD, Transform DCLCDDGJKIC, bool APPFELHKFLC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29F35F0", Offset = "0x29F29F0", VA = "0x1829F35F0", Slot = "7")]
	public T KEIDMBADJBC<T>(GameObject BDNIDEKLIGD, Transform DCLCDDGJKIC, bool APPFELHKFLC = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEB70", Offset = "0x5CDDF70", VA = "0x185CDEB70", Slot = "8")]
	public GameObject KEIDMBADJBC(GameObject BDNIDEKLIGD, Transform DCLCDDGJKIC, EJKNJLMAAHP OJJNHGGGKOD, bool APPFELHKFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29F3B90", Offset = "0x29F2F90", VA = "0x1829F3B90", Slot = "9")]
	public T KEIDMBADJBC<T>(GameObject BDNIDEKLIGD, Transform DCLCDDGJKIC, EJKNJLMAAHP OJJNHGGGKOD, bool APPFELHKFLC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29F3620", Offset = "0x29F2A20", VA = "0x1829F3620")]
	private T KEIDMBADJBC<T>(GameObject BDNIDEKLIGD, Transform DCLCDDGJKIC, EJKNJLMAAHP OJJNHGGGKOD, bool APPFELHKFLC, [Out] GameObject HHNLANEGBHH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29F3150", Offset = "0x29F2550", VA = "0x1829F3150")]
	private T CCHKDPCPHBN<T>(GameObject GHAOKLKOOCA, EJKNJLMAAHP OJJNHGGGKOD, bool APPFELHKFLC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CDED70", Offset = "0x5CDE170", VA = "0x185CDED70")]
	private void MFJMCFIDOOA(Component FNPIKAPNGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE600", Offset = "0x5CDDA00", VA = "0x185CDE600")]
	private void KBNHDCCJJAB(Component FNPIKAPNGBE, EJKNJLMAAHP OJJNHGGGKOD, bool APPFELHKFLC, bool GNEBJHGMEFC, [Optional] Type DAKAAHDLIAC, [Optional] Type BGNKMOFCJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CDEC00", Offset = "0x5CDE000", VA = "0x185CDEC00")]
	private void LJNFDGLDKPF(GameObject GHAOKLKOOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EJKNJLMAAHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private Dictionary<Type, object> KOCAIAPLNPI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x22584A0", Offset = "0x22578A0", VA = "0x1822584A0")]
	public EJKNJLMAAHP FAJCEJLMNJF<T>(T OANMFFLOMAE)
	{
		return default(EJKNJLMAAHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x22593A0", Offset = "0x22587A0", VA = "0x1822593A0")]
	public T KJBHHOOLCCM<T>(T HBPJMDHPOKO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2258BD0", Offset = "0x2257FD0", VA = "0x182258BD0")]
	public bool ICFEPCNMLOH<T>([Out] T OANMFFLOMAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MIIDLBKHKJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool GAKFMNFOHJF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xB15050", Offset = "0xB14450", VA = "0x180B15050")]
	public MIIDLBKHKJO(bool PGGHBCDLAGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JJNDBDMFFBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool MHFMHMLMDAL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3DD0", Offset = "0x5CE31D0", VA = "0x185CE3DD0")]
	public JJNDBDMFFBE(bool CNLMOGEKPBF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, JNGKKLJECCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE43C0", Offset = "0x5CE37C0", VA = "0x185CE43C0", Slot = "4")]
		public void PrepareImposter(EJKNJLMAAHP OJJNHGGGKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
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
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x5CE3F20", Offset = "0x5CE3320", VA = "0x185CE3F20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5CE3F10", Offset = "0x5CE3310", VA = "0x185CE3F10")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CE39A0", Offset = "0x5CE2DA0", VA = "0x185CE39A0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EHOBCNHNJIE
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<URPLight> IKOIPIDIBOJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 DOPMGEPKDAA;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly Vector3 CCBBKOEBJGH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static Camera CFKGIENAOMH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly List<Renderer> MJGDMNBGDIO;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AmbientMode DNFAONMFMKN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static Color MHPOJCHPINJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color EIKJGDFBBEG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color NDKBAOPMFDM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Cubemap CJAOOKAHNKO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static bool CNIPNDNCNLF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera KGFDNBKPDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2230", Offset = "0x5CE1630", VA = "0x185CE2230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1BB0", Offset = "0x5CE0FB0", VA = "0x185CE1BB0")]
	public static void JKBNBOAPKMM(Vector3 GPDJNBHPMHE, Quaternion LPPOGMPEJON, ImposterRenderConfig OMCAPODFAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1F00", Offset = "0x5CE1300", VA = "0x185CE1F00")]
	private static void MCIGMOHAFGL(Vector3 GPDJNBHPMHE, Quaternion LPPOGMPEJON, URPLight IHDKFKHMLBJ, ImposterRenderConfig.LightConfig CPKCCHNLLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1E20", Offset = "0x5CE1220", VA = "0x185CE1E20")]
	public static void KDNNLKOADBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1830", Offset = "0x5CE0C30", VA = "0x185CE1830")]
	private static void JHLBLDHIELG(int OHBBOLMGPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0DF0", Offset = "0x5CE01F0", VA = "0x185CE0DF0")]
	public static void DJFLEKPJLPF(ImposterRenderConfig OMCAPODFAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0D00", Offset = "0x5CE0100", VA = "0x185CE0D00")]
	public static void DHDBFAHEMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0B30", Offset = "0x5CDFF30", VA = "0x185CE0B30")]
	public static void DCKAKCOGEAI(GameObject BLHBGLMHMKH, RenderTexture OLBHHJAPDNM, ImposterRenderConfig OMCAPODFAJF, KMLIFMJKAHI ABHAPAONGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE1250", Offset = "0x5CE0650", VA = "0x185CE1250")]
	private static void GKMDLGDMBHH(GameObject BLHBGLMHMKH, RenderTexture OLBHHJAPDNM, ImposterRenderConfig OMCAPODFAJF, KMLIFMJKAHI ABHAPAONGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0FB0", Offset = "0x5CE03B0", VA = "0x185CE0FB0")]
	private static void DKLLGPGDJEK(GameObject BLHBGLMHMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2440", Offset = "0x5CE1840", VA = "0x185CE2440")]
	public static void ODKAENAFLEB(GameObject BDNIDEKLIGD, Vector3 BABBGENFJDH, Vector3 FJICAJNGMDM, float NNOOHAOAKNJ, KMLIFMJKAHI ABHAPAONGKC, [Out] Vector3 MBLGIJDIFOF, [Out] Quaternion PIGPIDIMLKB, [Out] float ECLOHMJEDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE0A90", Offset = "0x5CDFE90", VA = "0x185CE0A90")]
	public static RenderTexture ALECAAIHBBO(int HAAINFBDEEH, int FFMDGIGMLOC)
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
		public struct MAAKBGNFDJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public NMHMFMOCBJF ACELFLOOKDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public GameObject MHFPOCIDKFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public RenderTexture IHLHCIHEDHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public ImposterRenderConfig MGKGLLCMHHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public KMLIFMJKAHI KMLIFMJKAHI;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5CE3F40", Offset = "0x5CE3340", VA = "0x185CE3F40")]
			public MAAKBGNFDJA(NMHMFMOCBJF KNLNCNMIJHD, GameObject DFFJEDBDAGJ, RenderTexture OLBHHJAPDNM, ImposterRenderConfig IBCMAEBNIJA, KMLIFMJKAHI ABHAPAONGKC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static LNPBAIDMOIO<MAAKBGNFDJA, RenderTexture> AABOMBONEJB;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly List<MAAKBGNFDJA> LGLJFIILDNF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int PNHKNGJCIGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5CDF7A0", Offset = "0x5CDEBA0", VA = "0x185CDF7A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF8B0", Offset = "0x5CDECB0", VA = "0x185CDF8B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject BLHBGLMHMKH, RenderTexture OLBHHJAPDNM, ImposterRenderConfig OMCAPODFAJF, KMLIFMJKAHI ABHAPAONGKC, CancellationToken OMFABMCIOAC, bool GABBBGDBPCI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF410", Offset = "0x5CDE810", VA = "0x185CDF410", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF810", Offset = "0x5CDEC10", VA = "0x185CDF810", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5CDF600", Offset = "0x5CDEA00", VA = "0x185CDF600")]
		private static Task<RenderTexture> BBLPBGFLLAP(MAAKBGNFDJA DOKNMJBLLLD, CancellationToken OMFABMCIOAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5CDFCD0", Offset = "0x5CDF0D0", VA = "0x185CDFCD0")]
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
